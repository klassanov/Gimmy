using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilesHelper.Movago;

namespace XMLTransformer.Tests
{
    /// <summary>
    /// Summary description for MovagoRecordsTest
    /// </summary>
    [TestClass]
    public class MovagoRecordsTest
    {
        private int recordLength = 300;

        public MovagoRecordsTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void MovagoRecordInizialeTest()
        {
            //Arrange
            MovagoRecordIniziale record = new MovagoRecordIniziale();

            //Act
            string recordString = record.GetRecordString();

            //Assert
            Assert.AreEqual(recordString.Length, recordLength);
        }

        [TestMethod]
        public void MovagoRecordDettaglioTestataFatturaTest()
        {
            //Arrange
            MovagoRecordDettaglioTestataFattura record = new MovagoRecordDettaglioTestataFattura();

            //Act
            string recordString = record.GetRecordString();

            //Assert
            Assert.AreEqual(recordString.Length, recordLength);
        }

        [TestMethod]
        public void MovagoRecordDettaglioatturaTest()
        {
            //Arrange
            MovagoRecordDettaglioFattura record = new MovagoRecordDettaglioFattura();

            //Act
            string recordString = record.GetRecordString();

            //Assert
            Assert.AreEqual(recordString.Length, recordLength);
        }

        [TestMethod]
        public void MovagoRecordFinaleTest()
        {
            //Arrange
            MovagoRecordFinale recordFinale = new MovagoRecordFinale();

            //Act
            string recordString=recordFinale.GetRecordString();

            //Assert
            Assert.AreEqual(recordString.Length, recordLength);
        }
    }
}
