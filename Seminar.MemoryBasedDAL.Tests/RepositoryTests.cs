using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seminar.Model;
using System.Collections.Generic;

namespace Seminar.MemoryBasedDAL.Tests
{
    [TestClass]
    public class RepositoryTests
    {

        private static string username = "username";
        private static string password = "password";

        User user = new User(username, password);

        [TestInitialize]
        public void ReInitializeUserRepository()
        {
            System.Reflection.FieldInfo fi1 = typeof(UserRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

            Assert.IsNotNull(fi1);

            fi1.SetValue(null, null);

            System.Reflection.FieldInfo fi2 = typeof(RecordRepository).GetField("_instance", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

            Assert.IsNotNull(fi2);

            fi2.SetValue(null, null);
        }

        // USER REPOSITORY
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

        [TestMethod]
        public void Test_FindUserById()
        {
            UserRepository userRepository = UserRepository.getInstance();
            User user = new User("username", "password");
            userRepository.saveUser(user);

            User foundUser = userRepository.findUserByID("username");

            Assert.AreNotEqual("Not found", foundUser.Username);
        }


        // RECORD REPOSITORY
        [TestMethod]
        public void Test_AddNewUser()
        {
            RecordRepository recordRepository = RecordRepository.getInstance();
            string username = "username";

            recordRepository.AddUserToDictionary(username, new List<Record>());
            bool status = recordRepository.getUserRecords().ContainsKey("username");

            Assert.IsTrue(status);
        }

        [TestMethod]
        public void Test_DeleteUserRecords()
        {
            RecordRepository recordRepository = RecordRepository.getInstance();
            string username = "username";
            recordRepository.AddUserToDictionary(username, new List<Record>());

            recordRepository.deleteUserRecords(username);
            bool status = recordRepository.getUserRecords().ContainsKey("username");

            Assert.IsFalse(status);
        }

        [TestMethod]
        public void Test_GetRecordById()
        {
            RecordRepository recordRepository = RecordRepository.getInstance();
            Record record = new Record("Happy", "", "01/01/2020", "", "");
            string username = "username";
            bool status = false;
            recordRepository.AddUserToDictionary(username, new List<Record>());
            recordRepository.addNewRecord(record, username);

            Record foundRecord = recordRepository.getRecordByID(username, "01/01/2020");

            if (foundRecord.Feeling != "")
            {
                status = true;
            }

            Assert.IsTrue(status);
        }

    }
}