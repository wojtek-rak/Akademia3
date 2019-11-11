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
                "likebomb", "roadavoid", "malroXd"};
            var count = 0;

            count =
                users.Where(x => x.ToLower()
                .Contains("xd"))
                .Count();

            Assert.AreEqual(4, count);
        }

        [Test]
        public void Search_xd_in_list_sql()
        {
            var users = new List<string>() { "malroXd", "dare", "roage",
                "washbasinphxDone", "jealouslewsomed", "rashtoexd", "iffybalgy",
                "likebomb", "roadavoid", "malroXd"};
            var count = 0;

            count =
                (from user in users
                where user.ToLower().Contains("xd")
                select user).Count();

            Assert.AreEqual(4, count);
        }

        [Test]
        public void Search_xd_in_list_no_duplicates()
        {
            var users = new List<string>() { "malroXd", "dare", "roage",
                "washbasinphxDone", "jealouslewsomed", "rashtoexd", "iffybalgy",
                "likebomb", "roadavoid", "malroXd"};
            var count = 0;

            //count = users.ToHashSet().Where(x => x.ToLower().Contains("xd")).Count();

            Assert.AreEqual(3, count);
        }

        [Test]
        public void Remove_Duplicate()
        {
            var users = new List<string>() { "malroXd", "dare", "roage",
                "washbasinphxDone", "jealouslewsomed", "rashtoexd", "iffybalgy",
                "likebomb", "roadavoid", "malroXd"};
            //var count = 0;
            users.Remove("malroXd");


            Assert.AreEqual(10, users.Count());
        }

        [Test]
        public void Get_Adult_Users_List()
        {
            var users = GetUsers();
            var count = 0;

            var adoultUserList = new List<User>();
            //var adoultUserList = users.Where(x => x.Age > 18).ToList();

            Assert.AreEqual(4, adoultUserList.Count);
        }

        [Test]
        public void Get_Specyific_User()
        {
            var users = GetUsers();
            var age = 0;

            User selectedUser = new User();
            //var selectedUser = users.Where(x => x.Name == "jealouslewsomed")
            //    .FirstOrDefault();

            //if (selectedUser != null)
            //{
            //    age = selectedUser.Age;
            //}

            Assert.AreEqual(12, age);
        }

        [Test]
        public void Get_Average_of_User_age()
        {
            var users = GetUsers();
            var count = 0;

            var averageUserAge = 0;
            //var averageUserAge = users.Average(x => x.Age);

            Assert.AreEqual(18.44m, Math.Round((decimal)averageUserAge, 2));
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
