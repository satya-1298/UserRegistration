using Registration;

namespace RegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        UserValidation validation = new UserValidation();
        [TestMethod]
        public void GivenFirstName_WhenValidate_ShouldReturnValid()
        {
            try
            {
                string name = "G";
                var result = validation.ValidateFirstName(name);

            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid firstname", ex.Message);
            }
        }

        [TestMethod]
        public void GivenLastName_WhenValidate_ShouldReturnInValid()
        {
            try
            {
                string name = "G";
                var result = validation.ValidateLastName(name);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Lastname", ex.Message);
            }
        }
        [TestMethod]
        public void GivenEmail_WhenValidate_ShouldReturnInValid()
        {
            try
            {
                string mail = "ga@gmail";
                var result = validation.ValidateEmail(mail);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid email", ex.Message);
            }
        }
        [TestMethod]
        public void GivenPhoneNumber_WhenValidate_ShouldReturnInValid()
        {
            try
            {
                string number = "0987";
                var result = validation.ValidateMobileNumber(number);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid mobile number", ex.Message);
            }
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnInValid()
        {
            try
            {
                string pwd = "G";
                var result = validation.ValidatePassWord(pwd);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid password", ex.Message);
            }
        }
    }
}
