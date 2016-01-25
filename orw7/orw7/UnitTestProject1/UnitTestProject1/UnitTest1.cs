using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsComponentNameSpace;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd() // publiczna klasa dodawania
        {
            MathsComponent obj = new MathsComponent(); // tworznie nowego obiektu
            int result = obj.Add(2, 2); //inicjowanie dwóch zmiennych liczbowych
            Assert.AreEqual(4, result); // wynik który ma wyjsc z testu
        }
    }
}
