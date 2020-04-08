using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstPharmacy
    {
        //create some test data to pass the valid method 
        string PharmacyID = "1";
        string PharmacyName = "TestPharmacyName";
        string PharmacyAddress = "TestPharmacyAddress";

        public string TestPharmacy;
        //here is a test for Pharmacy id 
        Int32 TestPharmacyID = 1;
        //here is a test for Pharmacy name 
        String TestPharmacyName = "TestPharmacyName";
        //here is a test for Pharmacy Address 
        String TestPharmacyAddress = "TestPharmacyAddress";

        public string QT { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsPharmacy APharmacy = new clsPharmacy();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(APharmacy);
        }

        [TestMethod]
        //this will be used for testing the PharmacyNameOK of the class
        public void PharmacyNameOK()
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to test the name of the pharmacy
            String PharmacyName = "";
            //send some data to the Pharmacy
            APharmacy.PharmacyName = PharmacyName;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APharmacy.PharmacyName, PharmacyName);
        }

        [TestMethod]
        //this will be used for testing the PharmacyNameProperty of the class
        public void PharmacyNamePropertyOK()
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to test the name of the pharmacy
            String TestData = QT;
            //send some data to the pharmacy
            APharmacy.PharmacyName = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APharmacy.PharmacyName, TestData);
        }

        [TestMethod]
        //this will be used for testing the Pharmacy of the class
        public void PharmacyNameMinBoundary()             // 9 char.
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacyName = "";
            //invoke the method 
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyNameMinPlusOne of the class
        public void PharmacyNameMinPlusOne()              // 10 char.
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacyName = "qt";
            //invoke the method
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyNameMinLessOne of the class
        public void PharmacyNameMinLessOne()               // 14 char.
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "qt";
            //create some test data to test the method
            string PharmacyName = "";
            //invoke the method 
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyNameMaxBoundary of the class
        public void PharmacyNameMaxBoundary()              // 50 char. 
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //test variable by adding 'q' 50 times 
            PharmacyName = PharmacyName.PadRight(50, 'q');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyNameMaxLessOne of the class
        public void PharmacyNameMaxLessOne()             // 49 char.  
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //test variable by adding 'q' 49 times 
            PharmacyName = PharmacyName.PadRight(49, 'q');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyNameMaxPlusOne of the class
        public void PharmacyNameMaxPlusOne()           // 51 char.
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacyName = "qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq";
            //invoke the method
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyNameMid of the class
        public void PharmacyNameMid()         // 25 characters
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacyName = "qqqqqqqqqqqqqqqqqqq";
            //invoke the method
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistIDOK of the class
        public void PharmacyIDOK()
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the pharmacy id
            Int32 PharmacyID = 123456;
            //assign a pharmacy to the variable 
            //send some data to the Pharmacy
            APharmacy.PharmacyID = PharmacyID;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APharmacy.PharmacyID, PharmacyID);
        }

        [TestMethod]
        //this will be used for testing the PharmacyIDPropertyOK of the class
        public void PharmacyIDPropertyOK()
        {
            //create an instance of the class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the Pharmacy Id 
            Int32 PharmacyID;
            //assign a value to the variable to test te id 
            PharmacyID = 123456;
            APharmacy.PharmacyID = PharmacyID;
            //check to see if the data in the variable and the propert are identical 
            Assert.AreEqual(APharmacy.PharmacyID, PharmacyID);
        }

        [TestMethod]
        //this will be used for testing the PharmacyIDMinBoundary of the class
        public void PharmacyIDMinBoundary()                // 8 char.
        {
            //create an instance of the pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string PharmacyID = "11111111";
            //invoke the method 
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyIDMinPlusOne of the class
        public void PharmacyIDMinPlusOne()                 // 9 char.
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacyID = "111111111";
            //invoke the method
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyIDMinLessOne of the class
        public void PharmacyIDMinLessOne()
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            PharmacyID = "1";
            //invoke the method 
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyIDMaxBoundary of the class
        public void PharmacyIDMaxBoundary()                  // 50 char.
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "";
            //create a test data to test the method 
            string PharmacyID = "11111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyIDMaxLessOne of the class
        public void PharmacyIDMaxLessOne()                 // 49 char.
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method 
            string PharmacyID = "1111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyIDMaxPlusOne of the class
        public void PharmacyIDMaxPlusOne()                 // 51 char.  
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacyID = "11111111111111111111111111";
            //invoke the method
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacyIDMid of the class
        public void PharmacyIDMid()                       // 25 characters
        {
            //create an instance of the Pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacyID = "1111111111111111111111111";
            //invoke the method
            Error = APharmacy.Valid(PharmacyName, PharmacyAddress);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PharmacyAddressOK()
        {
            //create an instance of pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            string PharmacyAddress = null;
            //assign the test to variable 
            APharmacy.PharmacyAddress = PharmacyAddress;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APharmacy.PharmacyAddress, PharmacyAddress);
        }

        [TestMethod]
        public void PharmacyAddressPropertyOK()
        {
            //create an instance of pharmacy class
            clsPharmacy APharmacy = new clsPharmacy();
            string PharmacyAddress = null;
            //assign the test to variable 
            APharmacy.PharmacyAddress = PharmacyAddress;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APharmacy.PharmacyAddress, PharmacyAddress);
        }

    }

}

