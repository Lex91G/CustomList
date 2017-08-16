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
            Fun<string> list = new Fun<string>();

            list.Add("yes");
            string actualResult = list[0];
            string exspectedResult = "yes";

            Assert.AreEqual(actualResult, exspectedResult);

            
        }
        [TestMethod]
        public void PassingNumbersIn2()
        {
            Fun<string> list = new Fun<string>();

            list.Add("yes");
            list.Add[1]("no");
            string actualResult = list[1];
            string exspectedResult = "no";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void PassingNumbersIn3()
        {
            Fun<string> list = new Fun<string>();
            
            list.Add("yes");
            list.Add[0]("!yes");
            string actualResult = list[0];
            string exspectedResult = "!yes";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void PassingNumbersIn4()
        {
            Fun<string> list = new Fun<string>();

            list.Add[2] ("yes");
            list.Add[0]("!yes");
            list.Add[3]("no");
            list.Add[1]("hello");
            string actualResult = list[1];
            string exspectedResult = "hello";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void PassingNumbersIn5()
        {
            Fun<string> list = new Fun<string>();

            list.Add[1]("!yes");
            list.Add[0]("!yes");
            list.Add[2]("no");
            string actualResult = list[0,1];
            string exspectedResult = "!yes, !yes";


            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void SubtractingNumbers()
        {
            Fun<string> list = new Fun<string>();

            list.Add("Fred");
            list.Add[1]("Mom");
            list.Add[2]("Carol");
            list.Add[3]("Sherrol");
            list.Add[4]("Kevin");
            list.Add[5]("Lydia");

            list.Removeat(1);


            string actualResult = list[1];
            string exspectedResult = "Carol";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void SubtractingNumbers2()
        {
            Fun<string> list = new Fun<string>();

            list.Add("Fred");
            list.Add[1]("Mom");
            list.Add[2]("Carol");
            list.Add[3]("Sherrol");
            list.Add[4]("Kevin");
            list.Add[5]("Lydia");


            list.Removeat(1);
            list.Removear(1);


            string actualResult = list[1];
            string exspectedResult = "Sherrol";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void SubtractingNumbers3()
        {
            Fun<string> list = new Fun<string>();

            list.Add("Fred");
            list.Add[1]("Mom");
            list.Add[2]("Carol");
            list.Add[3]("Sherrol");
            list.Add[4]("Kevin");
            list.Add[5]("Lydia");

            list.Removeat(1);
            list.Removeat(3);


            string actualResult = list[3];
            string exspectedResult = "Lydia";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void SubtractingNumbers4()
        {
            Fun<string> list = new Fun<string>();

            list.Add("Fred");
            list.Add[1]("Mom");
            list.Add[2]("Carol");
            list.Add[3]("Sherrol");
            list.Add[4]("Kevin");
            list.Add[5]("Lydia");

            list.Removeat(0);
            list.Removeat(1);
            list.Removeat(2);


            string actualResult = list[0];
            string exspectedResult = "Sherrol";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void SubtractingNumbers5()
        {
            Fun<string> list = new Fun<string>();

            list.Add("Fred");
            list.Add[1]("Mom");
            list.Add[2]("Carol");
            list.Add[3]("Sherrol");
            list.Add[4]("Kevin");
            list.Add[5]("Lydia");

            list.Removeat(0);
            list.Removeat(3);


            string actualResult = list[3];
            string exspectedResult = "Lydia";

            Assert.AreEqual(actualResult, exspectedResult);
        }
        [TestMethod]
        public void SubtractingNumbers3()
        {
            Fun<string> list = new Fun<string>();

            foreach(list.count)


            string actualResult = list[3];
            string exspectedResult = "Lydia";

            Assert.AreEqual(actualResult, exspectedResult);
        }
    }
    }

