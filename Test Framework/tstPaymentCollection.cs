using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        //this will be used for testing TwoRecordsPresent of the payment class
        public void TwoRecordsPresent()
        {
            //create an instance of the class
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //test to see if it exists or not 
            Assert.AreNotEqual(AllPayments.Count, 2);
        }

        [TestMethod]
        //this will be used for testing ThisPayment of the class
        public void ThisPaymentOK()
        {
            //create an instance of the class collection
            clsPaymentCollection APayment = new clsPaymentCollection();
            //crate an instance of a payment class to test the item of data test 
            clsPayment TestPayment = new clsPayment();
            //set its properties 
            TestPayment.PaymentID = 1201;
            TestPayment.PatientID = 12345678;
            TestPayment.PaymentType = "TestPaymentType";
            TestPayment.PaymentDate = DateTime.Now.Date;
            TestPayment.Price = 22;
            //assign the test variable to be into a real one 
            APayment.ThisPayment = TestPayment;
            //check if they are identical 
            Assert.AreEqual(APayment.ThisPayment, TestPayment);
        }

        [TestMethod]
        //this will be used for testing ThisPaymentPropertyOK of the class
        public void ThisPaymentPropertyOK()
        {
            //create an instance of the class collection
            clsPaymentCollection APayment = new clsPaymentCollection();
            //crate an instance of a payment class to test the item of data test 
            clsPayment TestPayment = new clsPayment();
            //set its properties 
            TestPayment.PaymentID = 1201;
            TestPayment.PatientID = 12345678;
            TestPayment.PaymentType = "TestPaymentType";
            TestPayment.PaymentDate = DateTime.Now.Date;
            TestPayment.Price = 22;
            //assign the test variable to be into a real one 
            APayment.ThisPayment = TestPayment;
            //check if they are identical 
            Assert.AreEqual(APayment.ThisPayment, TestPayment);
        }

        [TestMethod]
        //this will be used for testing CountOK of the class
        public void CountOK()
        {
            //new instance of Payment Collection class
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create a list for payment
            List<clsPayment> PaymentList = new List<clsPayment>();
            //new instance of clsPayment class to create the item of test data
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.PaymentID = 1201;
            TestItem.PatientID = 12345678;
            TestItem.PaymentType = "TestPaymentType";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.Price = 22;
            //add the item to the test list
            PaymentList.Add(TestItem);
            //assign the test variable into the real one
            AllPayments.PaymentList = PaymentList;
            //check if they are identical or not 
            Assert.AreEqual(AllPayments.Count, PaymentList.Count);
        }

        [TestMethod]
        //this will be used for testing PaymentListOK of the class
        public void PaymentListOK()
        {
            //new instance of Payment Collection class
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create a list for payment
            List<clsPayment> PaymentList = new List<clsPayment>();
            //new instance of clsPayment class to create the item of test data
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.PaymentID = 1201;
            TestItem.PatientID = 12345678;
            TestItem.PaymentType = "TestPaymentType";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.Price = 22;
            //add the item to the test list
            PaymentList.Add(TestItem);
            //assign the test variable into the real one
            AllPayments.PaymentList = PaymentList;
            //check if they are identical or not 
            Assert.AreEqual(AllPayments.PaymentList, PaymentList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //new instance of Payment Collection class
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create a list for payment
            List<clsPayment> PaymentList = new List<clsPayment>();
            //new instance of clsPayment class to create the item of test data
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.PaymentID = 1201;
            TestItem.PatientID = 12345678;
            TestItem.PaymentType = "TestPaymentType";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.Price = 22;
            //add the item to the test list
            PaymentList.Add(TestItem);
            //assign the test variable into the real one
            AllPayments.PaymentList = PaymentList;
            //check if they are identical or not 
            Assert.AreEqual(AllPayments.Count, PaymentList.Count);
        }

        [TestMethod]
        //this will be used for testing the AddMehtodOK of the class
        public void AddMethodOK()
        {
            //create an instance of the class collection
            clsPaymentCollection APayment = new clsPaymentCollection();
            //new instance of clsPayment class to create the item of test data
            clsPayment TestItem = new clsPayment();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PaymentID = 1201;
            TestItem.PatientID = 12345678;
            TestItem.PaymentType = "TestPaymentType";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.Price = 22;
            //set ThisPayment to the test data
            APayment.ThisPayment = TestItem;
            //add the record
            PrimaryKey = APayment.Add();
            //set the primary key of the test data
            TestItem.PaymentID = PrimaryKey;
            //test to see that the two values are identical 
            Assert.AreEqual(APayment.ThisPayment, TestItem);
        }

        [TestMethod]
        //this will be used for testing the UpdateMethod of the class
        public void UpdateMethodOK()
        {
            //create an instance of the class collection
            clsPaymentCollection APayment = new clsPaymentCollection();
            //new instance of clsPayment class to create the item of test data
            clsPayment TestItem = new clsPayment();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.PaymentID = 1201;
            TestItem.PatientID = 12345678;
            TestItem.PaymentType = "TestPaymentType";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.Price = 22;
            //set ThisPayment to the test data
            APayment.ThisPayment = TestItem;
            //add the item 
            PrimaryKey = APayment.Add();
            //set the primary key of the test data 
            TestItem.PaymentID = PrimaryKey;
            //update the test data 
            TestItem.PaymentID = 1201;
            TestItem.PatientID = 12345678;
            TestItem.PaymentType = "TestPaymentType";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.Price = 22;
            //set the record based on the updated test data
            APayment.ThisPayment = TestItem;
            //update the record
            APayment.Update();
            //find the record
            APayment.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(APayment.ThisPayment, TestItem);
        }

        [TestMethod]
        //this will be used for testing the DeleteMethod of the class
        public void DeleteMethodOK()
        {
            //create an instance of the class collection
            clsPaymentCollection APayment = new clsPaymentCollection();
            //new instance of clsPayment class to create the item of test data
            clsPayment TestItem = new clsPayment();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PaymentID = 1201;
            TestItem.PatientID = 12345678;
            TestItem.PaymentType = "TestPaymentType";
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.Price = 22;
            //set ThisPayment to the test data
            APayment.ThisPayment = TestItem;
            //add the item 
            PrimaryKey = APayment.Add();
            //set the primary key of the test data 
            TestItem.PaymentID = PrimaryKey;
            //delete the record
            APayment.Delete();
            //now find the record
            Boolean Found = APayment.ThisPayment.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
            // Check whether they match
            Assert.AreEqual(APayment.ThisPayment, TestItem);
        }
    }
}
