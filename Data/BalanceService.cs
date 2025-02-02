using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjektKrypto2.Data;

public class BalanceService
{
    private readonly IServiceProvider _serviceProvider;
    private decimal _balance = 0;
    public event Action? OnBalanceChanged;

    public BalanceService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public decimal GetBalance() => _balance;

    public async Task LoadBalanceAsync(string userId)
    {
        using var scope = _serviceProvider.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        var userBalance = await dbContext.UserBalances.FirstOrDefaultAsync(u => u.UserId == userId);
        _balance = userBalance?.Balance ?? 0;

        Console.WriteLine($"[DEBUG] Saldo załadowane: {_balance}");

        OnBalanceChanged?.Invoke(); // Powiadomienie komponentów o zmianie
    }

    public async Task UpdateBalanceAsync(string userId, decimal newBalance)
    {
        using var scope = _serviceProvider.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        var userBalance = await dbContext.UserBalances.FirstOrDefaultAsync(u => u.UserId == userId);
        if (userBalance != null)
        {
            userBalance.Balance = newBalance;
            await dbContext.SaveChangesAsync();
        }
        _balance = newBalance;

        Console.WriteLine($"[DEBUG] Saldo zaktualizowane: {_balance}");

        OnBalanceChanged?.Invoke(); // Powiadomienie komponentów o zmianie
    }

}
