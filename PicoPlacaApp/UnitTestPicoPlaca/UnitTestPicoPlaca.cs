using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.IO;

namespace UnitTestPicoPlaca
{
    [TestClass]
    public class UnitTestPicoPlaca
    {
        private const string ExpectedPermission = "Car has permission on road";
        private const string ExpectedNoPermission = "Car has not permission on road";

        [TestMethod]
        public void TestHasCarPermission()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PicoPlacaApp.Form1 picoPlaca = new PicoPlacaApp.Form1();

                string licensePlateNumber = "AAC-O123";
                string date = "19/04/2019";
                string time = "18:17";
                picoPlaca.CheckPermission(licensePlateNumber, date, time);

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedPermission, result);
            }
        }

        [TestMethod]
        public void TestCarIsAtPicoTimeAfternoon()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                PicoPlacaApp.Form1 picoPlaca = new PicoPlacaApp.Form1();

                string licensePlateNumber = "MCB-250";
                string date = "19/04/2019";
                string time = "18:17";

                picoPlaca.CheckPermission(licensePlateNumber, date, time);

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedNoPermission, result);
            }
        }

        [TestMethod]
        public void TestCarIsNotAtPicoTime()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                PicoPlacaApp.Form1 picoPlaca = new PicoPlacaApp.Form1();

                string licensePlateNumber = "MCB-250";
                string date = "19/04/2019";
                string time = "12:17";

                picoPlaca.CheckPermission(licensePlateNumber, date, time);

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedPermission, result);
            }
        }
        [TestMethod]
        public void TestCarIsAtPicoTimeMorning()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                PicoPlacaApp.Form1 picoPlaca = new PicoPlacaApp.Form1();

                string licensePlateNumber = "MCB-250";
                string date = "19/04/2019";
                string time = "07:17";

                picoPlaca.CheckPermission(licensePlateNumber, date, time);

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedNoPermission, result);
            }
        }
    }
}
