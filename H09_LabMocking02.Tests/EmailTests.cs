using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace H09_LabMocking02.Tests
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        public void GivenANewEmailAndAnEmailServiceThatReturnsTrue_WhenSending_ThenTheResultShouldBeTrue()
        {
            //GivenANewEmail
            Email mail = new Email();
            //AndAnEmailServiceThatReturnsTrue
            var emailService = new Mock<IMailService>();
            emailService.Setup(s => s.SendMail(It.IsAny<Email>())).Returns(true);

            //WhenSending
            bool actual = mail.Send(emailService.Object);

            //ThenTheResultShouldBeTrue
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void GivenANewEmailAndAnEmailService_WhenSending_ThenTheSendEmailOfTheServiceShouldBeInvoked() {
            //GivenANewEmail
            Email mail = new Email();
            //AndAnEmailServiceThatReturnsTrue
            var emailService = new Mock<IMailService>();
            emailService.Setup(s => s.SendMail(It.IsAny<Email>())).Verifiable();

            //WhenSending
            mail.Send(emailService.Object);

            //ThenTheSendEmailOfTheServiceShouldBeInvoked
            emailService.Verify();
        }

    }
}
