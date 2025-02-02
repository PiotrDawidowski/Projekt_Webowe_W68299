# ProjektKrypto2

Projekt **ProjektKrypto2** to aplikacja webowa oparta na Blazor Server, umożliwiająca użytkownikom przeglądanie aktualnych kursów kryptowalut i zarządzanie ich portfelem.

## 📌 **Wymagania systemowe**
- .NET 9.0
- SQL Server (LocalDB)
- Visual Studio 2022+
- Node.js (opcjonalnie, jeśli są używane zależności front-endowe)

---

## 🚀 **Instrukcja uruchomienia**

### 1️⃣ **Klonowanie repozytorium**
```bash
git clone https://github.com/TwojaNazwaUzytkownika/ProjektKrypto2.git
cd ProjektKrypto2
```

### 2️⃣ **Instalacja wymaganych pakietów**
Uruchom poniższe polecenie w terminalu w katalogu projektu:
```bash
dotnet restore
```
To przywróci wszystkie wymagane zależności NuGet.

### 3️⃣ **Ustawienie bazy danych**
Projekt używa **Entity Framework Core**. Aby przygotować bazę danych, wykonaj poniższe kroki:

#### a) **Zastosowanie migracji**
```bash
dotnet ef database update 20250202181531_AddCryptoWalletsTable
```

Jeśli `dotnet ef` nie jest dostępne, zainstaluj narzędzie globalnie:
```bash
dotnet tool install --global dotnet-ef
```

#### b) **Sprawdzenie konfiguracji połączenia**
Plik `appsettings.json` zawiera ustawienia połączenia do SQL Server LocalDB:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\mssqllocaldb;Database=ProjektKrypto2;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
Jeśli używasz innej bazy danych, zmodyfikuj wartość `DefaultConnection`.

### 4️⃣ **Uruchomienie aplikacji**
```bash
dotnet run
```
Aplikacja będzie dostępna pod adresem:
```
http://localhost:7051
```

---

## 📚 **Funkcjonalności**
✅ Pobieranie aktualnych kursów kryptowalut z CoinCap API  
✅ Obsługa użytkowników (logowanie, rejestracja)  
✅ Przechowywanie ulubionych kryptowalut użytkownika  
✅ Automatyczne odświeżanie danych co 2 sekundy  
✅ Wyświetlanie zmian cenowych i ikon kryptowalut  

---

## ⚡ **Technologie użyte w projekcie**
- **Blazor Server** – interaktywny framework webowy
- **Entity Framework Core** – ORM do obsługi bazy danych
- **ASP.NET Core Identity** – system uwierzytelniania
- **SQL Server (LocalDB)** – baza danych
- **HttpClient** – pobieranie danych z API CoinCap

---

## 📄 **Licencja**
Projekt udostępniony na licencji MIT. Możesz swobodnie modyfikować i wykorzystywać go w swoich projektach.

---

## 👥 **Autorzy**
- [Twoje Imię](https://github.com/TwojaNazwaUzytkownika)

Jeśli masz jakiekolwiek pytania lub sugestie, zapraszam do kontaktu poprzez **Issues** lub **Pull Requests**! 🚀
