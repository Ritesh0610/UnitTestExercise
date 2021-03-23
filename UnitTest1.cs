using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDDIntroExercise
{
    [TestClass]
    public class UnitTest1
    {
        Calc.Number objc = new Calc.Number();
        [TestMethod]
        public void Number()
        {
            int num = 4;
            int resSquare = (num * num);
            int resSqrRoot = (int)Math.Sqrt(num);
            int resCube = (num * num * num);
            Assert.AreEqual(resSquare, objc.Square(num));
            Assert.AreEqual(resSqrRoot, objc.SquareRoot(num));
            Assert.AreEqual(resCube, objc.Cube(num));

        }
    }
}
