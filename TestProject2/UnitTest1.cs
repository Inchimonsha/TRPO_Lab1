using ClassLibrary1;

namespace ���������10
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
            Var11�������������? Var11 = new Var11�������������(default, default, default);
            string? expect = new Var10���������(str, _decimal, Var11).ToString();

            //act
            string? test = new Var10���������("test", 2.44M, Var11).ToString();

            //assert
            Assert.AreEqual(expect, test);
        }
    }
}