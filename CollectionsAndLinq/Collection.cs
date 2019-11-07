using System.Collections.Generic;
using System.Linq;
using Akademia3;
using NUnit.Framework;

namespace CollectionsAndLinq
{
    public class Collection
    {

        [Test]
        public void Search_xd_in_list()
        {
            var users = new List<string>() { "malroXd", "dare", "roage",
                "washbasinphxDone", "jealouslewsomed", "rashtoexd", "iffybalgy",
                "likebomb", "roadavoid", "malroXd"};
            var count = 0;

            //implementaton
            //foreach (var user in users)
            //{
            //    if (user.Contains("xd"))
            //    {
            //        count += 1;
            //    }
            //}
            //implementaton

            Assert.AreEqual(4, count);
        }
        //add ToLower()

        [Test]
        public void Search_xd_in_list_no_duplicates()
        {
            var users = new List<string>() { "malroXd", "dare", "roage",
                "washbasinphxDone", "jealouslewsomed", "rashtoexd", "iffybalgy",
                "likebomb", "roadavoid", "malroXd"};
            var count = 0;

            //var setUsers = new HashSet<string>(users);
            //foreach (var user in setUsers)
            //{
            //    if (user.ToLower().Contains("xd"))
            //    {
            //        count += 1;
            //    }
            //}

            Assert.AreEqual(3, count);
        }


        [Test]
        public void Get_Adoult_Users_List()
        {
            var users = GetUsers();
            var count = 0;
            var adoultUserList = new List<User>();

            //foreach (var user in users)
            //{
            //    if (user.Age > 18)
            //    {
            //        adoultUserList.Add(user);
            //    }
            //}

            Assert.AreEqual(4, adoultUserList.Count);
        }

        [Test]
        public void Get_Specyfic_User()
        {
            var users = GetUsers();
            var age = 0;
            User selectedUser = null;

            //foreach (var user in users)
            //{
            //    if (user.Name == "jealouslewsomed")
            //    {
            //        selectedUser = user;
            //    }
            //}

            //if(selectedUser != null)
            //{
            //    age = selectedUser.Age;
            //}

            Assert.AreEqual(12, age);
        }

        [Test]
        public void Get_Specyfic_User_Dictionary()
        {
            var users = new Dictionary<int, string>()
            {
                {13567, "marek" },
                {14532, "czarek" },
                {13412, "warek"}
            };

            var userName = string.Empty;
            //var userName = users[14532];

            Assert.AreEqual("czarek", userName);
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