using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataISBN;
using System;

namespace KataISBN.UnitTests
{
    [TestClass]
    public class ISBNTests
    {
        [TestMethod]
        public void CodigoDiezTest_ReturnTrue()
        {
            var codigo = new ISBN();

            var result = codigo.CodigoDiez(new String);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CodigoDiezTest_ReturnFalse()
        {
            var codigo = new ISBN();

            var result = codigo.CodigoDiez(new String);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CodigoTreceTest_ReturnTrue()
        {
            var codigo = new ISBN();

            var result = codigo.CodigoTrece(new String);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CodigoTreceTest_ReturnFalse()
        {
            var codigo = new ISBN();

            var result = codigo.CodigoTrece(new String);

            Assert.IsFalse(result);
        }
    }
}
