using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bastion.Models.Compute;
using MongoDB.Bson;

namespace Bastion.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ComputeConfiguration conf = new ComputeConfiguration();
            Console.WriteLine(conf.ToBsonDocument());
        }
    }
}
