using StudyingTesting.users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingTesting.poker_hands
{
    public class TableManager
    {
        public static void OpenTable(User user)
        {
            if (user.CanOpenTable())
            {
                Console.WriteLine($"{user.Username} table open !");
            }
            else
            {
                throw new UnauthorizedAccessException($"{user.Username} is not authorized to open a table.");
            }
        }
    }
}
