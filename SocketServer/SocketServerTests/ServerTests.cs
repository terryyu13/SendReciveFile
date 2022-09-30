using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocketServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer.Tests
{
    [TestClass()]
    public class ServerTests
    {
        [TestMethod()]
        public void ServerStartTest()
        {
            // Arrange
            var Sut = new SocketServer();
            // Act
            Sut.Show();
            Sut.ServerStart();
            // Assert
            Assert.IsNotNull(Sut);
        }

        [TestMethod()]
        public void ServerSocketCreateSuccess()
        {
            // Arrange
            var Sut = new SocketServer();
            // Act
            bool result = Sut.ServerSocketCreate(8888);
            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void ServerSocketCreateFailure()
        {
            // Arrange
            var Sut = new SocketServer();
            // Act
            bool result = Sut.ServerSocketCreate(-1);
            // Assert
            Assert.AreEqual(false, result);
        }
    }
}