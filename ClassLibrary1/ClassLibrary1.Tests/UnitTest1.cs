namespace ClassLibrary1.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int x = 20; int y = 20;
            int expected = 40;

            MyCalc calc= new MyCalc();
            int actual = calc.Sum(x,y);
            Assert.That(actual, Is.EqualTo(expected));
            Assert.Pass();
        }
    }
}
