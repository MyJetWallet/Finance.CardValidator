namespace Finance.CardValidator.Tests
{
    public static class TestUtils
    {
        public static CardValidator CreateValidator(this string cardNumber)
        {
            return new CardValidator(cardNumber);
        }
    }
}