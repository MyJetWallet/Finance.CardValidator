using NUnit.Framework;

namespace Finance.CardValidator.Tests
{
    public class CardValidatorTests
    {
        private const string Visa1 = "4929535088219220";
        private const string Visa2 = "4485091863118472";
        private const string MasterCard1 = "5598948529247527";
        private const string MasterCard2 = "5332877434358643";
        private const string AmericanExpress1 = "379240898801878";
        private const string AmericanExpress2 = "374476302204037";
        private const string Discover1 = "6011384679322075";
        private const string Discover2 = "6011663130196826";
        private const string JCB1 = "3537789224953988";
        private const string JCB2 = "3545310902579928";
        private const string Trash1 = "1245151515136";
        private const string Trash2 = "5686252176234";

        [Test]
        public void TestBankCardValidation()
        {
            var visaValidator1 = Visa1.CreateValidator();
            var visaValidator2 = Visa2.CreateValidator();
            var masterCardValidator1 = MasterCard1.CreateValidator();
            var masterCardValidator2 = MasterCard2.CreateValidator();
            var americanExpressValidator1 = AmericanExpress1.CreateValidator();
            var americanExpressValidator2 = AmericanExpress2.CreateValidator();
            var discoverValidator1 = Discover1.CreateValidator();
            var discoverValidator2 = Discover2.CreateValidator();
            var jcbValidator1 = JCB1.CreateValidator();
            var jcbValidator2 = JCB2.CreateValidator();
            var trashValidator1 = Trash1.CreateValidator();
            var trashValidator2 = Trash2.CreateValidator();
            
            Assert.IsTrue(visaValidator1.IsCardValid());
            Assert.IsTrue(visaValidator2.IsCardValid());
            Assert.IsTrue(masterCardValidator1.IsCardValid());
            Assert.IsTrue(masterCardValidator2.IsCardValid());
            Assert.IsTrue(americanExpressValidator1.IsCardValid());
            Assert.IsTrue(americanExpressValidator2.IsCardValid());
            Assert.IsTrue(discoverValidator1.IsCardValid());
            Assert.IsTrue(discoverValidator2.IsCardValid());
            Assert.IsTrue(jcbValidator1.IsCardValid());
            Assert.IsTrue(jcbValidator2.IsCardValid());
            Assert.IsFalse(trashValidator1.IsCardValid());
            Assert.IsFalse(trashValidator2.IsCardValid());
            
            Assert.AreEqual(CardType.Visa ,visaValidator1.GetCardType());
            Assert.AreEqual(CardType.Visa ,visaValidator2.GetCardType());
            Assert.AreEqual(CardType.MasterCard ,masterCardValidator1.GetCardType());
            Assert.AreEqual(CardType.MasterCard ,masterCardValidator2.GetCardType());
            Assert.AreEqual(CardType.AmericanExpress ,americanExpressValidator1.GetCardType());
            Assert.AreEqual(CardType.AmericanExpress ,americanExpressValidator2.GetCardType());
            Assert.AreEqual(CardType.Discover ,discoverValidator1.GetCardType());
            Assert.AreEqual(CardType.Discover ,discoverValidator2.GetCardType());
            Assert.AreEqual(CardType.JCB ,jcbValidator1.GetCardType());
            Assert.AreEqual(CardType.JCB ,jcbValidator2.GetCardType());
            Assert.AreEqual(CardType.Unknown ,trashValidator1.GetCardType());
            Assert.AreEqual(CardType.Unknown ,trashValidator2.GetCardType());
            
            Assert.AreEqual(Visa1 ,visaValidator1.GetCardNumber());
            Assert.AreEqual(Visa2 ,visaValidator2.GetCardNumber());
            Assert.AreEqual(MasterCard1 ,masterCardValidator1.GetCardNumber());
            Assert.AreEqual(MasterCard2 ,masterCardValidator2.GetCardNumber());
            Assert.AreEqual(AmericanExpress1 ,americanExpressValidator1.GetCardNumber());
            Assert.AreEqual(AmericanExpress2 ,americanExpressValidator2.GetCardNumber());
            Assert.AreEqual(Discover1 ,discoverValidator1.GetCardNumber());
            Assert.AreEqual(Discover2 ,discoverValidator2.GetCardNumber());
            Assert.AreEqual(JCB1 ,jcbValidator1.GetCardNumber());
            Assert.AreEqual(JCB2 ,jcbValidator2.GetCardNumber());
            Assert.AreEqual(Trash1 ,trashValidator1.GetCardNumber());
            Assert.AreEqual(Trash2 ,trashValidator2.GetCardNumber());
        }
    }
}