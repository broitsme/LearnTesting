using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PermissionNameSpace;
using LearnTestingNameSpace;
using TwoNumbersFakeNameSpace;
using TwoNumbersNameSpace;
namespace TestAdd
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Mock<Permission> PermissionStub = new Mock<Permission>();
            PermissionStub.Setup(X => X.ExternalMethod()).Returns(true);
            //Act
            TwoNumbersClass TwoNumbersFake = new TwoNumbersFakeClass();
            var Expected = Program.AddWithPermission(TwoNumbersFake,PermissionStub.Object);
            //Assert
            Assert.AreEqual(Expected, TwoNumbersFake.num1 + TwoNumbersFake.num2);
        }
    }
}
