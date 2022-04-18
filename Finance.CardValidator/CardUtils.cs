using System.Text.RegularExpressions;

namespace Finance.CardValidator
{
    public static class CardUtils
    {
        private const string VisaRegex = @"^4[0-9]{12}(?:[0-9]{3})?$";

        private const string MasterCardRegex =
            @"^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$";

        private const string AmericanExpressRegex = @"^3[47][0-9]{13}$";
        private const string DiscoverRegex = @"^6(?:011|5[0-9]{2})[0-9]{12}$";
        private const string JCBRegex = @"^(?:2131|1800|35\d{3})\d{11}$";

        public static CardType GetCardType(this string cardNumber)
        {
            if (Regex.Match(cardNumber, VisaRegex).Success)
            {
                return CardType.Visa;
            }

            if (Regex.Match(cardNumber, MasterCardRegex).Success)
            {
                return CardType.MasterCard;
            }

            if (Regex.Match(cardNumber, AmericanExpressRegex).Success)
            {
                return CardType.AmericanExpress;
            }

            if (Regex.Match(cardNumber, DiscoverRegex).Success)
            {
                return CardType.Discover;
            }

            return Regex.Match(cardNumber, JCBRegex).Success
                ? CardType.JCB
                : CardType.Unknown;
        }
    }
}