
namespace TestProjectConsoleAppDemo
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            int divd = 100;
            int divisor = 0;
            int res, rem;
            int expectedResult = 20;

            ConsoleAppDemo.InOutDemo.Divide(divd, divisor, out res, out rem);
            Assert.AreEqual(expectedResult, res);
            Assert.AreEqual(0, rem);
            
        }
    }
}