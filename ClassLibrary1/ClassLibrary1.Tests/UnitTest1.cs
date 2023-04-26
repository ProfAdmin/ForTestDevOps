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
            int x = 30; int y = 30;
            int expected = 60;

            MyCalc calc= new MyCalc();
            int actual = calc.Sum(x,y);
            Assert.That(actual, Is.EqualTo(expected));
            Assert.Pass();
        }
    }
}
