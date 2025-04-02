using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudyingTesting.poker_hands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyingTesting.users;
namespace StudyingTesting.poker_hands.Tests
{
    [TestClass()]
    public class MyTestingTests
    {
        [TestMethod]
        public void PlayerCannotOpenTable()
        {
            User playerUser = new User { Username = "PlayerUser", Roles = new List<User_Role> { User_Role.PLAYER } };

            bool canOpen = playerUser.CanOpenTable();

            Assert.IsFalse(canOpen, "Player should NOT be able to open a table.");
        }
        [TestMethod]
        public void ManagerCanOpenTable()
        {

            User managerUser = new User { Username = "ManagerUser", Roles = new List<User_Role> { User_Role.MANAGER } };


            bool canOpen = managerUser.CanOpenTable();


            Assert.IsTrue(canOpen, "Manager should be able to open a table.");
        }
        [TestMethod]
        public void AdminCanOpenTable()
        {
            
            User adminUser = new User { Username = "AdminUser", Roles = new List<User_Role> { User_Role.ADMIN } };

           
            bool canOpen = adminUser.CanOpenTable();

           
            Assert.IsTrue(canOpen, "Admin should be able to open a table.");
        }
    }
}