using Registration;

namespace RegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenFirstName_WhenValidate_ShouldReturnValid()
        {
            string name = "Satya";
            UserValidation validation = new UserValidation();
            var result = validation.ValidateFirstName(name);
            Assert.AreEqual("Valid first name", result);
        }
        [TestMethod]
        public void GivenLastName_WhenValidate_ShouldReturnValid()
        {
            string name = "Adabala";
            UserValidation validation = new UserValidation();
            string result = validation.ValidateLastName(name);
            Assert.AreEqual("Valid Last name", result);
        }
        [TestMethod]
        public void GivenEmail_WhenValidate_ShouldReturnValid()
        {
            string email ="abc123@gmail.com";
            UserValidation validation = new UserValidation();
            string result = validation.ValidateEmail(email);
            Assert.AreEqual("Valid email", result);
        }
        [TestMethod]
        public void GivenPhoneNumber_WhenValidate_ShouldReturnValid()
        {
            string phone = "+91 7456344556";
            UserValidation validation = new UserValidation();
            string result = validation.ValidateMobileNumber(phone);
            Assert.AreEqual("Valid mobile number", result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnValid()
        {
            string pwd = "Agtf@1234";
            UserValidation validation = new UserValidation();
            string result = validation.ValidatePassWord(pwd);
            Assert.AreEqual("Valid password", result);
        }
    }
}