using Common.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace Service.Test
{
    [TestClass]
    public class PaymentGatewayServiceTests
    {
        private PaymentGatewayService paymentGatewayService;

        private Mock<IPaymentGatewayFactory> mockPaymentGatewayFactory;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockPaymentGatewayFactory = new Mock<IPaymentGatewayFactory>(MockBehavior.Strict);
            this.paymentGatewayService = new PaymentGatewayService(this.mockPaymentGatewayFactory.Object);
        }

        [TestMethod]
        public async Task Process_Works()
        {
            string expected = "Successsfully";
            // Arrange
            this.mockPaymentGatewayFactory.Setup(mr => mr.GetFilter("upgrade").Filter())
                .ReturnsAsync(expected);

            // Act
            var response = await this.paymentGatewayService.Process("upgrade");

            // Assert
            
            this.mockPaymentGatewayFactory.VerifyAll();
            Assert.AreEqual(expected, response);
        }
    }
}
