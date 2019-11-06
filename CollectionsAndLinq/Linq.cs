using System;
using System.Collections.Generic;
using System.Linq;
using Akademia3;
using NUnit.Framework;

namespace CollectionsAndLinq
{
    public class Linq
    {
        [Test]
        public void Search_xd_in_list()
        {
            var users = new List<string>() { "malroXd", "dare", "roage",
                "washbasinphxDone", "jealouslewsomed", "rashtoexd", "iffybalgy",
                "likebomb", "roadavoid"};
            var count = 0;

            //count = users.Where(x => x.ToLower().Contains("xd")).Count();

            Assert.AreEqual(3, count);
        }
        //add ToLower()

        [Test]
        public void Get_Adoult_Users_List()
        {
            var users = GetUsers();
            var count = 0;

            var adoultUserList = new List<User>();
            //var adoultUserList = users.Where(x => x.Age > 18).ToList();

            Assert.AreEqual(4, adoultUserList.Count);
        }

        [Test]
        public void Get_Specyfic_User()
        {
            var users = GetUsers();
            var age = 0;

            User selectedUser = new User();
            //var selectedUser = users.Where(x => x.Name == "jealouslewsomed")
            //    .FirstOrDefault();

            if (selectedUser != null)
            {
                age = selectedUser.Age;
            }

            Assert.AreEqual(12, age);
        }


        private List<User> GetUsers()
        {
            var users = new List<User>() {
                new User{ Name = "malroXd", Age = 16},
                new User{ Name = "dare", Age = 31},
                new User{ Name = "roage", Age = 14},
                new User{ Name = "washbasinphxDone", Age = 22},
                new User{ Name = "jealouslewsomed", Age = 12},
                new User{ Name = "rashtoexd", Age = 13},
                new User{ Name = "iffybalgy", Age = 26},
                new User{ Name = "likebomb", Age = 19},
                new User{ Name = "roadavoid", Age = 13}
            };

            return users;
        }
    }
}
