using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstPayment
    {
        //good test data 
        //set the private data member to the test data value 
        string PaymentID = "1201";
        string PatientID = "12345678";
        string PaymentType = "Card";
        string PaymentDate = Convert.ToString(DateTime.Now.Date);
        string Price = Convert.ToString("22.50");

        public string TestPayment;
        //here is a test for payment id
        Int32 TestPaymentID = 1201;
        //here is a test for patient id 
        Int32 TestPatientID = 12345678;
        //here is a test for payment type
        String TestPaymentType = "TestPaymentType";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsPayment APayment = new clsPayment();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(APayment);
        }

        [TestMethod]
        //this will be used for testing the PatientIDOK of the class
        public void PatientIDOK()
        {
            //a new instance of clsPayment class
            clsPayment APatient = new clsPayment();
            //create a variable in order to store the patient id
            Int32 PatientID = 12345678;
            //assign a patient to the variable 
            //send some data to the patient
            APatient.PatientID = PatientID;
            //check to see if the data within the variable and property are identical 
            Assert.AreNotEqual(PaymentID, PaymentType, PaymentDate, Price, PatientID);
        }

        [TestMethod]
        //this will be used for testing the PatientIDPropertyOK of the class
        public void PatientIDPropertyOK()
        {
            //a new instance of clsPayment class
            clsPayment APatient = new clsPayment();
            //create a variable in order to store the patient id 
            Int32 PatientID;
            //assign a value to the variable to test the patient id 
            PatientID = 12345678;
            APatient.PatientID = PatientID;
            //check to see if the data in the variable and the propert are identical 
            Assert.AreNotEqual(PaymentID, PaymentType, PaymentDate, Price, PatientID);
        }

        [TestMethod]
        //this will be used for testing the PatientIDMinBoundary of the class
        public void PatientIDMinBoundary()                // 8 char.
        {
            //a new instance of clsPayment class
            clsPayment APatient = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string PatientID = "11111111";
            //invoke the method 
            Error = APatient.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMinPlusOne of the class
        public void PatientIDMinPlusOne()                 // 9 char.
        {
            //a new instance of clsPayment class
            clsPayment APatient = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PatientID = "111111111";
            //invoke the method
            Error = APatient.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMinLessOne of the class
        public void PatientIDMinLessOne()
        {
            //a new instance of clsPayment class
            clsPayment APatient = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            PatientID = "12345678";
            //invoke the method 
            Error = APatient.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMaxBoundary of the class
        public void PatientIDMaxBoundary()                  // 50 char.
        {
            //a new instance of clsPayment class
            clsPayment APatient = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create a test data to test the method 
            string PatientID = "11111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APatient.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMaxLessOne of the class
        public void PatientIDMaxLessOne()                 // 49 char.
        {
            //a new instance of clsPayment class
            clsPayment APatient = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method 
            string PatientID = "1111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APatient.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMaxPlusOne of the class
        public void PatientIDMaxPlusOne()                 // 51 char.  
        {
            //a new instance of clsPayment class
            clsPayment APatient = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PatientID = "11111111111111111111111111";
            //invoke the method
            Error = APatient.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMid of the class
        public void PatientIDMid()                       // 25 characters
        {
            //a new instance of clsPayment class
            clsPayment APatient = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PatientID = "1111111111111111111111111";
            //invoke the method
            Error = APatient.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PaymentIDOK of the class
        public void PaymentIDOK()
        {
        //a new instance of clsPayment class
        clsPayment APayment = new clsPayment();
        //create a variable in order to store the payment id
        Int32 PaymentID = 1201;
        //assign a patient to the variable 
        //send some data to the payment 
        APayment.PaymentID = PaymentID;
        //check to see if the data within the variable and property are identical 
        Assert.AreNotEqual(PaymentID, PaymentType, PaymentDate, Price, PatientID);
        }

        [TestMethod]
        //this will be used for testing the PaymentIDPropertyOK of the class
        public void PaymentIDPropertyOK()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the payment id 
            Int32 PaymentID;
            //assign a value to the variable to test the payent id 
            PaymentID = 1202;
            APayment.PaymentID = PaymentID;
            //check to see if the data in the variable and the propert are identical 
            Assert.AreNotEqual(PaymentID, PaymentType, PaymentDate, Price, PatientID);
        }

        [TestMethod]
        //this will be used for testing the PaymentIDMinBoundary of the class
        public void PaymentIDMinBoundary()                // 8 char.
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string PaymentID = "11111111";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
         //this will be used for testing the PaymentIDMinPlusOne of the class
         public void PaymentIDMinPlusOne()                 // 9 char.
         {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PaymentID = "111111111";
            //invoke the method
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
         }

        [TestMethod]
        //this will be used for testing the PaymentIDMinLessOne of the class
        public void PaymentIDMinLessOne()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            PaymentID = "1201";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PaymentIDMaxBoundary of the class
        public void PaymentIDMaxBoundary()                  // 50 char.
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create a test data to test the method 
            string PaymentID = "11111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PaymentIDMaxLessOne of the class
        public void PaymentIDMaxLessOne()                 // 49 char.
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method 
            string PaymentID = "1111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PaymentIDMaxPlusOne of the class
        public void PaymentIDMaxPlusOne()                 // 51 char.  
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PaymentID = "11111111111111111111111111";
            //invoke the method
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PaymentIDMid of the class
        public void PaymentIDMid()                       // 25 characters
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PaymentID = "1111111111111111111111111";
            //invoke the method
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeOK()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //new varible to be tested tstPaymentType
            String PaymentType = "";
            APayment.PaymentType = PaymentType;
            //check to see that the class matches
            Assert.AreEqual(APayment.PaymentType, PaymentType);
        }

        [TestMethod]
        //this will be used for testing the PaymentTypeProperty of the class
        public void PaymentTypePropertyOK()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to test the PaymentType 
            String TestData = "Cash";
            //send some data to the Payment
            APayment.PaymentType = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APayment.PaymentType, TestData);
        }

        [TestMethod]
        //this will be used for testing the PaymentTypeMinBoundary of the class
        public void PaymentTypeMinBoundary()             // 9 char.
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PaymentType = "";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PaymentTypeMinPlusOne of the class
        public void PaymentTypeMinPlusOne()              // 10 char.
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PaymentType = "cccccccccc";
            //invoke the method
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PaymentTypeMinLessOne of the class
        public void PaymentTypeMinLessOne()               // 14 char.
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "C";
            //create some test data to test the method
            string PaymentType = "";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PaymentTypeMaxBoundary of the class
        public void PaymentTypeMaxBoundary()              // 50 char. 
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //test variable by adding 'c' 50 times 
            PaymentType = PaymentType.PadRight(50, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PaymentTypeMaxLessOne of the class
        public void PaymentTypeMaxLessOne()             // 49 char.  
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //test variable by adding 'c' 49 times 
            PaymentType = PaymentType.PadRight(49, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PaymentTypeMaxPlusOne of the class
        public void PaymentTypeMaxPlusOne()           // 51 char.
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugType = "cccccccccccccccccccccccccccccccccccccccccccccccccc";
            //invoke the method
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PaymentTypeMid of the class
        public void PaymentTypeMid()         // 25 characters
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PaymentType = "ccccccccccccccccccccccccc";
            //invoke the method
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            APayment.PaymentDate = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APayment.PaymentDate, TestData);
        }

        public void PaymentDateExtremeMin()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 200 years 
            TestDate = TestDate.AddYears(-200);
            //convert the date variable to a string variable 
            string PaymentDate = TestDate.ToString();
            //invoke the method  
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateMinLessOne()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 1 day 
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string PaymentDate = TestDate.ToString();
            //invoke the method  
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateMin()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string PaymentDate = TestDate.ToString();
            //invoke the method  
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateMinPlusOne()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date plus 1 day 
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string PaymentDate = TestDate.ToString();
            //invoke the method  
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateExtremeMax()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 200 years 
            TestDate = TestDate.AddYears(50);
            //convert the date variable to a string variable 
            string PaymentDate = TestDate.ToString();
            //invoke the method  
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateInvalidData()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //set the date to a non date value 
            string PaymentDate = "this is not a date!!";
            //invoke the method  
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should fail 
            string Price = "-0.01";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string Price = "0.00";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string Price = "22.50";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string Price = "49.99";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string Price = "50.00";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "51.00";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMid()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "20.0";
            //invoke the method  
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ValidationMethodOK()
        {
            //a new instance of clsPayment class
            clsPayment APayment = new clsPayment();
            //int variable to store any error message 
            string Error = "";
            //invoke the method 
            Error = APayment.Valid(PaymentID, PaymentType, PaymentDate, Price, PatientID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
