using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA2MusicTobyZedomi.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2MusicTobyZedomi.Music.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void EqualsTestWhenBothUsersAreTheSame()
        {
            Console.WriteLine("Test for when both users are the same");

            User user1 = new User("Toby","t@gmail.com", "123");
            User user2 = new User("Toby", "t@gmail.com", "123");

            Assert.AreEqual(true,user1.Equals(user2));

        }


        [TestMethod()]
        public void EqualsTestWhenBothUsersAreNotTheSame()
        {
            Console.WriteLine("Test for when both users are the same");

            User user1 = new User("Toby", "t@gmail.com", "123");
            User user2 = new User("Sam", "sam@gmail.com", "123");

            Assert.AreEqual(false, user1.Equals(user2));

        }
    }
}