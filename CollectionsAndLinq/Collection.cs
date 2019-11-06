using System.Collections.Generic;
using System.Linq;
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
                "likebomb", "roadavoid"};
            var count = 0;

            //implementaton
            foreach (var user in users)
            {
                if (user.Contains("xd"))
                {
                    count += 1;
                }
            }
            //implementaton

            Assert.AreEqual(3, count);
        }
        //add ToLower()

        [Test]
        public void Search_xd_in_list2()
        {
            var users = new List<string>() { "malroXd", "dare", "roage",
                "washbasinphxDone", "jealouslewsomed", "rashtoexd", "iffybalgy",
                "likebomb", "roadavoid"};
            var count = 0;

            //count = users.Where(x => x.ToLower().Contains("xd")).Count();

            Assert.AreEqual(3, count);
        }
    }
}