using System.Collections.Generic;
using System.Linq;

namespace Finance.CardValidator
{
    public static class LuhnChecker
    {
        public static bool LuhnCheck(this string cardNumber)
        {
            return LuhnCheck(cardNumber.Select(c => c - '0').ToArray());
        }
 
        private static bool LuhnCheck(this IReadOnlyCollection<int> digits)
        {
            return GetCheckValue(digits) == 0;
        }
 
        private static int GetCheckValue(IReadOnlyCollection<int> digits)
        {
            return digits.Select((d, i) => i % 2 == digits.Count % 2 ? ((2 * d) % 10) + d / 5 : d).Sum() % 10;
        }
    }
}