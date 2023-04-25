using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myarealib.Tests
{
    [TestClass]
    public class myareaTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int b = 10;
            int c = 10;
            double res = 600;

            myarea p = new myarea();
            double act = p.area(a, b, c);

            Assert.AreEqual(res, act);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 0;
            int b = 10;
            int c = 10;
            double res = 200;

            myarea p = new myarea();
            double act = p.area(a, b, c);

            Assert.AreEqual(res, act);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a = -10;
            int b = 10;
            int c = 10;
            double res = -1;

            myarea p = new myarea();
            double act = p.area(a, b, c);

            Assert.AreEqual(res, act);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int a = -10;
            int b = 10;
            int c = -10;
            double res = -1;

            myarea p = new myarea();
            double act = p.area(a, b, c);

            Assert.AreEqual(res, act);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int a = 1;
            int b = 10;
            int c = 10;
            double res = 240;

            myarea p = new myarea();
            double act = p.area(a, b, c);

            Assert.AreEqual(res, act);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int a = 10;
            int b = 0;
            int c = 0;
            double res = 0;

            myarea p = new myarea();
            double act = p.area(a, b, c);

            Assert.AreEqual(res, act);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int a = 0;
            int b = 0;
            int c = -10;
            double res = -1;

            myarea p = new myarea();
            double act = p.area(a, b, c);

            Assert.AreEqual(res, act);
        }
        [TestMethod]
        public void TestMethod8()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            double res = 0;

            myarea p = new myarea();
            double act = p.area(a, b, c);

            Assert.AreEqual(res, act);
        }
        [TestMethod]
        public void TestMethod9()
        {
            int a = -10;
            int b = -10;
            int c = -10;
            double res = -1;

            myarea p = new myarea();
            double act = p.area(a, b, c);

            Assert.AreEqual(res, act);
        }
        [TestMethod]
        public void TestMethod10()
        {
            int a = 15;
            int b = 100;
            int c = 60;
            double res = 16800;

            myarea p = new myarea();
            double act = p.area(a, b, c);

            Assert.AreEqual(res, act);
        }

    }
}
   