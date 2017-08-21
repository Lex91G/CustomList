using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Home;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassingNumbersIn1()
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("yes");
            string actualResult = list[0];
            string exspectedResult = "yes";

            Assert.AreEqual(exspectedResult, actualResult);


        }
        [TestMethod]
        public void PassingNumbersIn2()
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("yes");
            list.Add("no");
            string actualResult = list[1];
            string exspectedResult = "no";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void PassingNumbersIn3()
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("yes");
            list.Add("!yes");
            string actualResult = list[1];
            string exspectedResult = "!yes";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void PassingNumbersIn4()
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("yes");
            list.Add("!yes");
            list.Add("no");
            list.Add("hello");
            string actualResult = list[1];
            string exspectedResult = "!yes";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void PassingNumbersIn5()
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("!yes");
            list.Add("!yes");
            list.Add("no");
            string actualResult = list[0];
            string exspectedResult = "!yes";


            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void SubtractingNumbers()
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("Fred");
            list.Add("Mom");
            list.Add("Carol");
            list.Add("Sherrol");
            list.Add("Kevin");
            list.Add("Lydia");

            list.Remove("Mom");


            string actualResult = list[1];
            string exspectedResult = "Carol";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void SubtractingNumbers2()
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("Fred");
            list.Add("Mom");
            list.Add("Carol");
            list.Add("Sherrol");
            list.Add("Kevin");
            list.Add("Lydia");


            list.Remove("Mom");
            list.Remove("Carol");


            string actualResult = list[1];
            string exspectedResult = "Sherrol";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void SubtractingNumbers3()
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("Fred");
            list.Add("Mom");
            list.Add("Carol");
            list.Add("Sherrol");
            list.Add("Kevin");
            list.Add("Lydia");

            list.Remove("Fred");
            list.Remove("Carol");


            string actualResult = list[0];
            string exspectedResult = "Mom";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void SubtractingNumbers4()
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("Fred");
            list.Add("Mom");
            list.Add("Carol");
            list.Add("Sherrol");
            list.Add("Kevin");
            list.Add("Lydia");

            list.Remove("Fred");
            list.Remove("Mom");
            list.Remove("Kevin");


            string actualResult = list[1];
            string exspectedResult = "Sherrol";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void SubtractingNumbers5()
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("Fred");
            list.Add("Mom");
            list.Add("Carol");
            list.Add("Sherrol");
            list.Add("Kevin");
            list.Add("Lydia");

            list.Remove("Fred");
            list.Remove("Mom");


            string actualResult = list[3];
            string exspectedResult = "Lydia";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void OverloadString1()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            string convert = list.ToString();

            string actualResult = convert;
            string exspectedResult = "123";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void OverloadString2()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(3);
            list.Add(2);


            string convert = list.ToString();

            string actualResult = "32";
            string exspectedResult = "32";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void OverloadString3()
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(2);
            list.Add(3);
            list.Add(1);

            string convert = list.ToString();

            string actualResult = convert;
            string exspectedResult = "321";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void Add2InstancesTest1()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> otherlist = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            otherlist.Add(4);
            otherlist.Add(5);
            otherlist.Add(6);
            CustomList<int> together = list + otherlist;



            int actualResult = together.Count;
            int exspectedResult = 6;

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void Add2InstancesTest2()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> otherlist = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            otherlist.Add(2);
            otherlist.Add(5);
            otherlist.Add(6);
            CustomList<int> together = list + otherlist;


            int actualResult = together[2];
            int exspectedResult = 3;

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void Add2InstancesTest3()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> otherlist = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            otherlist.Add(4);
            otherlist.Add(5);
            CustomList<int> together = list + otherlist;



            int actualResult = together[2];
            int exspectedResult = 4;

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void Subtract1InstancesTest1()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> otherlist = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            otherlist.Add(3);
            otherlist.Add(5);
            otherlist.Add(6);
            CustomList<int> together = list - otherlist;



            int actualResult = together.Count;
            int exspectedResult = 2;

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void Subtract2InstancesTest2()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> otherlist = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            otherlist.Add(3);
            otherlist.Add(5);
            otherlist.Add(6);
            CustomList<int> together = list - otherlist;



            int actualResult = together[2];
            int exspectedResult = 4;

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void Subtract3InstancesTest3()
        {
            CustomList<int> list = new CustomList<int>();
            CustomList<int> otherlist = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            otherlist.Add(1);
            otherlist.Add(5);
            otherlist.Add(4);
            CustomList<int> together = list - otherlist;



            int actualResult = together[1];
            int exspectedResult = 3;

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void CountTest1()
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);

            int actualResult = list.Count;
            int exspectedResult = 8;

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void CountTest2()
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);


            int actualResult = list.Count;
            int exspectedResult = 5;

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void CountTest3()
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(4);
            list.Add(5);


            int actualResult = list.Count;
            int exspectedResult = 2;

            Assert.AreEqual(actualResult, exspectedResult);
        }
        //[TestMethod]
        //public void iterableTest1()
        //{
            
        //CustomList<int> list = new CustomList<int>();
        //list.Add(2);
        //list.Add(3);
        //int loop = 0;
        //foreach(int item in list) {
        //        loop++;
        //    }
        //        int actualResult = loop;
        //        int exspectedResult = 2;

        //        Assert.AreEqual(actualResult, exspectedResult);

        //    }
        [TestMethod]
        public void ZipTest2()
        {
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();

            odd.Add(1);
            odd.Add(3);
            even.Add(2);
            even.Add(4);



             CustomList<int> result = odd.Zip(even);
            int actualResult = result[2];
            int exspectedResult = 3;

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void ZipTest1()
        {
            CustomList<string> odd = new CustomList<string>();
            CustomList<string> even = new CustomList<string>();

            odd.Add("hi");
            odd.Add("my");
            odd.Add("Alex");
            even.Add("there");
            even.Add("names'");
            even.Add("burp");


            CustomList<string> result = odd.Zip(even);
            string actualResult = result[2];
            string exspectedResult = "my";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void ZipTest3()
        {
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            odd.Add(7);
            odd.Add(5);
            odd.Add(3);
            odd.Add(1);
            even.Add(6);
            even.Add(4);
            even.Add(2);
            



            CustomList<int> result = odd.Zip(even);
            int actualResult = result[5];
            int exspectedResult = 2;

            Assert.AreEqual(actualResult, exspectedResult);
        }


    }
    }

