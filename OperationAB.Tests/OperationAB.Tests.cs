using NUnit.Framework;
using System.Linq;

namespace OperationAB.Tests
{
    public class Tests
    {
        [SetUp]
            //this method will be done before each test
        public void Setup()
        {
            
        }

        [Test]
        public void Concat_AandB_return_AB()
        {
            //arrange
            string a = "A";
            string b = "B";
            string expected = "AB";


            //act
            OperationLibrary.Concat concat = new OperationLibrary.Concat();
            string actual = concat.DoOperation(a, b);


            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}