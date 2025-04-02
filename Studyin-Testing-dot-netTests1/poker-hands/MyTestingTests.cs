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

            Console.WriteLine($"Player: {playerUser.Username}, Can open table: {canOpen}");

            if (canOpen)
            {
                Console.WriteLine("❌ ERROR: A player should NOT be able to open a table, but they can!");
            }
            else
            {
                Console.WriteLine("✅ Test Passed: A player cannot open a table.");
            }
        }

        [TestMethod]
        public void ManagerCanOpenTable()
        {
            User managerUser = new User { Username = "ManagerUser", Roles = new List<User_Role> { User_Role.MANAGER } };

            bool canOpen = managerUser.CanOpenTable();

            Console.WriteLine($"Manager: {managerUser.Username}, Can open table: {canOpen}");

            if (canOpen)
            {
                Console.WriteLine("✅ Test Passed: A manager can open a table.");
            }
            else
            {
                Console.WriteLine("❌ ERROR: A manager should be able to open a table, but they cannot!");
            }
        }

        [TestMethod]
        public void AdminCanOpenTable()
        {
            User adminUser = new User { Username = "AdminUser", Roles = new List<User_Role> { User_Role.ADMIN } };

            bool canOpen = adminUser.CanOpenTable();

            Console.WriteLine($"Admin: {adminUser.Username}, Can open table: {canOpen}");

            if (canOpen)
            {
                Console.WriteLine("✅ Test Passed: An admin can open a table.");
            }
            else
            {
                Console.WriteLine("❌ ERROR: An admin should be able to open a table, but they cannot!");
            }
        }

    }
}