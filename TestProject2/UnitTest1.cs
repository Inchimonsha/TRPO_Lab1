using ClassLibrary1;

namespace Должность10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string str = "test";
            decimal _decimal = 2.44M;
            Var11Подразделение? Var11 = new Var11Подразделение(default, default, default);
            string? expect = new Var10Должность(str, _decimal, Var11).ToString();

            //act
            string? test = new Var10Должность("test", 2.44M, Var11).ToString();

            //assert
            Assert.AreEqual(expect, test);
        }
    }
}