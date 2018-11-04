using System;
using hw14.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SlogParserOnMolokoTest()
        {
            //Arrange
            var slogs = SlogParser.GetSlogs("молоко");
            string resultMoloko = "";
            //Act
            foreach (var item in slogs)
            {
                resultMoloko += item;
            }
            //Assert
            Assert.AreEqual("мо-ло-ко", resultMoloko);
        }
    }
}
