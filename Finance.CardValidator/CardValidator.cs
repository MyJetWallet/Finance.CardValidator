namespace Finance.CardValidator
{
    public class CardValidator
    {
        private CardType CardType { get; }
        private bool IsValidCardNumber { get; }
        private string CardNumber { get; }

        public CardValidator(string cardNumber)
        {
            CardNumber = cardNumber;
            IsValidCardNumber = cardNumber.LuhnCheck();
            CardType = cardNumber.GetCardType();
        }

        public CardType GetCardType()
        {
            return CardType;
        }

        public bool IsCardValid()
        {
            return IsValidCardNumber;
        }

        public string GetCardNumber()
        {
            return CardNumber;
        }
    }
}