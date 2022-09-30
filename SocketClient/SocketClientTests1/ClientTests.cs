using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocketClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient.Tests
{
    [TestClass()]
    public class ClientTests
    {
        [TestMethod()]
        public void FetchFileTest()
        {
            // Arrange
            var Sut = new SocketClient();
            // Act
            Sut.Show();
            Sut.fetch_file();
            // Assert
            Assert.IsNotNull(Sut);
        }

        [TestMethod()]
        public void ClientSocketCreateSuccess()
        {
            // Arrange
            var Sut = new SocketClient();
            // Act
            var obj = Sut.CreateIPEndPoint("127.0.0.1", "12345");
            // Assert
            Assert.IsInstanceOfType(obj, typeof(IPEndPoint));
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException), "Invalid ip adress")]
        public void ClientSocketCreateIPFailure()
        {
            // Arrange
            var Sut = new SocketClient();
            // Act
            Sut.CreateIPEndPoint("256.256.256.256", "8888");
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException), "Invalid port")]
        public void ClientSocketCreatePortFailure()
        {
            // Arrange
            var Sut = new SocketClient();
            // Act
            Sut.CreateIPEndPoint("127.0.0.1", "-1");
        }
    }
}