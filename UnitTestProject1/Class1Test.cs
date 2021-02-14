using Gipotenyza;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class Class1Test
    {
        [TestMethod]
        public void Gipotenyza_return_5()
        {
            //arange
            int a = 3;
            int b = 4;
            int result = 5;

            //act
            Gipotez v = new Gipotez();
            int actual = v.Sum(a,b);

            //assert
            Assert.AreEqual(result,actual);
            Assert.IsNotNull(result);
        }
    }
    [TestClass]
    public class Class1Test2
    {
        [TestMethod]
        public void Perimeter_return_12()
        {
            //arange
            int a = 3;
            int b = 4;
            int result = 12;

            //act
            Perimeter z = new Perimeter();
            int actual = z.Per(a, b);

            //assert
            Assert.AreEqual(result , actual);
            Assert.IsNotNull(result);
        }
    }
}
