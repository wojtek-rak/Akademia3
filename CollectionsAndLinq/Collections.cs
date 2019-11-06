﻿using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CollectionsAndLinq
{
    public class Collections
    {

        [Test]
        public void Search_xd_in_list()
        {
            var count = 0;
            var users = new List<string>() { "malroXd", "dare", "roage",
                "washbasinphxDone", "jealouslewsomed", "rashtoexd", "iffybalgy",
                "likebomb", "roadavoid"};

            //Implementation
            foreach (var user in users)
            {
                if (user.Contains("xd"))
                {
                    count += 1;
                }
            }
            //Implementation

            Assert.AreEqual(3, count);
        }
        //Add ToLower()
    }
}
