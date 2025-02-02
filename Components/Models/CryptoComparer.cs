using System;
using System.Collections.Generic;

namespace ProjektKrypto2.Components.Models
{
    public class CryptoComparer : IEqualityComparer<Crypto>
    {
        public bool Equals(Crypto? x, Crypto? y) // ✅ Obsługa wartości null, aby naprawić CS8767
        {
            if (x is null || y is null)
                return false;

            return x.Symbol == y.Symbol && x.PriceUsd == y.PriceUsd;
        }

        public int GetHashCode(Crypto obj)
        {
            return HashCode.Combine(obj.Symbol, obj.PriceUsd);
        }
    }
}
