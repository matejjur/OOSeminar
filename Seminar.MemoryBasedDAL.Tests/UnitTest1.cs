using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seminar.Model;

namespace Seminar.MemoryBasedDAL.Tests
{
    [TestClass]
    public class UnitTest1
    {

        private static string username = "username";
        private static string password = "password";

        User user = new User(username, password);

        [TestInitialize]
        public void ReInitializeAccountRepository()
        {
            System.Reflection.FieldInfo fi = typeof(UserRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

            Assert.IsNotNull(fi);

            fi.SetValue(null, null);
        }

        [TestMethod]
        public void Test_LoginCredential()
        {
            UserRepository userRepository = UserRepository.getInstance();
            userRepository.saveUser(user);

            bool status = userRepository.checkCredentials(username, password);

            Assert.IsTrue(status);
        }

        [TestMethod]
        public void Test_Registration()
        {
            UserRepository userRepository = UserRepository.getInstance();
            User user2 = new User("username2", "password2");
            userRepository.saveUser(user2);
            string status = "User registered";

            foreach (User usr in userRepository.getAllUsers())
            {
                if (usr.Username.Equals(username)) status = "Username already in use";
            }

            Assert.AreEqual("User registered", status);
        }

        [TestMethod]
        public void Test_Registration_ShortPassword()
        {
            UserRepository userRepository = UserRepository.getInstance();
            User user2 = new User("username2", "short");
            userRepository.saveUser(user2);
            string status = "User registered";

            foreach (User usr in userRepository.getAllUsers())
            {
                if (usr.Password.Length < 8)
                {
                    status = "Password must be 8 characters or longer";
                }
            }

            Assert.AreEqual("Password must be 8 characters or longer", status);
        }
    }
}