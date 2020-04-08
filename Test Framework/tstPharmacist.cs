using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstPharmacist
    {
        //create some test data to pass the valid method 
        string PharmacistID = "1";
        string PharmacistName = "TestPharmacistName";
        string ContactNo = "TestContactNo";

        public string TestPharmacist;
        //here is a test for Pharmacist id 
        Int32 TestPharmacistID = 1;
        //here is a test for Pharmacist name 
        String TestPharmacistName = "TestPharmacistName";
        //here is a test for Contact no 
        String TestContactNo = "TestContactNo";

        public string Claire { get; private set; }
      
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsPharmacist APharmacist = new clsPharmacist();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(APharmacist);
        }

        [TestMethod]
        //this will be used for testing the PharmacistNameOK of the class
        public void PharmacistNameOK()
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to test the name of the pharmacist
            String PharmacistName = "";
            //send some data to the Pharmacist
            APharmacist.PharmacistName = PharmacistName;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APharmacist.PharmacistName, PharmacistName);
        }

        [TestMethod]
        //this will be used for testing the PharmacistNameProperty of the class
        public void PharmacistNamePropertyOK()
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to test the name of the pharmacist
            String TestData = Claire;
            //send some data to the pharmacist
            APharmacist.PharmacistName = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APharmacist.PharmacistName, TestData);
        }

        [TestMethod]
        //this will be used for testing the Pharmacist of the class
        public void PharmacistNameMinBoundary()             // 9 char.
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacistName = "";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistNameMinPlusOne of the class
        public void PharmacistNameMinPlusOne()              // 10 char.
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacistName = "cccccccccc";
            //invoke the method
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistNameMinLessOne of the class
        public void PharmacistNameMinLessOne()               // 14 char.
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "C";
            //create some test data to test the method
            string PharmacistName = "";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistNameMaxBoundary of the class
        public void PharmacistNameMaxBoundary()              // 50 char. 
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //test variable by adding 'c' 50 times 
            PharmacistName = PharmacistName.PadRight(50, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistNameMaxLessOne of the class
        public void PharmacistNameMaxLessOne()             // 49 char.  
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //test variable by adding 'c' 49 times 
            PharmacistName = PharmacistName.PadRight(49, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistNameMaxPlusOne of the class
        public void PharmacistNameMaxPlusOne()           // 51 char.
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacistName = "cccccccccccccccccccccccccccccccccccccccccccccccccc";
            //invoke the method
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistNameMid of the class
        public void PharmacistNameMid()         // 25 characters
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacistName = "ccccccccccccccccccccccccc";
            //invoke the method
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistIDOK of the class
        public void PharmacistIDOK()
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the pharmacist id
            Int32 PharmacistID = 123456;
            //assign a pharmacis to the variable 
            //send some data to the Pharmacist
            APharmacist.PharmacistID = PharmacistID;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APharmacist.PharmacistID, PharmacistID);
        }

        [TestMethod]
        //this will be used for testing the PharmacistIDPropertyOK of the class
        public void PharmacistIDPropertyOK()
        {
            //create an instance of the class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the Pharmacist Id 
            Int32 PharmacistID;
            //assign a value to the variable to test te id 
            PharmacistID = 123456;
            APharmacist.PharmacistID = PharmacistID;
            //check to see if the data in the variable and the propert are identical 
            Assert.AreEqual(APharmacist.PharmacistID, PharmacistID);
        }

        [TestMethod]
        //this will be used for testing the PharmacistIDMinBoundary of the class
        public void PharmacistIDMinBoundary()                // 8 char.
        {
            //create an instance of the Admin class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string PharmacistID = "11111111";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistIDMinPlusOne of the class
        public void PharmacistIDMinPlusOne()                 // 9 char.
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacistID = "111111111";
            //invoke the method
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistIDMinLessOne of the class
        public void PharmacistIDMinLessOne()
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            PharmacistID = "1";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistIDMaxBoundary of the class
        public void PharmacistIDMaxBoundary()                  // 50 char.
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create a test data to test the method 
            string PharmacistID = "11111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistIDMaxLessOne of the class
        public void PharmacistIDMaxLessOne()                 // 49 char.
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method 
            string PharmacistID = "1111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistIDMaxPlusOne of the class
        public void PharmacistIDMaxPlusOne()                 // 51 char.  
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacistID = "11111111111111111111111111";
            //invoke the method
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistIDMid of the class
        public void PharmacistIDMid()                       // 25 characters
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PharmacistID = "1111111111111111111111111";
            //invoke the method
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PharmacistIDFound of the class
        public void TestPharmacistIDFound()
        {
            //create the instance of the class 
            clsPharmacist APharmacist = new clsPharmacist();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PharmacistID = 1;
            //invoke the method 
            Found = APharmacist.Find(PharmacistID);
            //check the PharmacistID
            if (APharmacist.PharmacistID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        //this will be used for testing the PharmacistNameFound of the class
        public void TestPharmacistNameFound()
        {
            //create an instance of pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 TestPharmacistID = 1;
            //invoke the method 
            Found = APharmacist.Find(TestPharmacistID);
            //check the property
            if (APharmacist.PharmacistName != "TestPharmacistName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        //this will be used for the validation method 
        public void ValidationMethodOK()
        {
            //create the instance of the class 
            clsPharmacist APharmacist = new clsPharmacist();
            //create a new variable error 
            String Error = "";
            //invoke the method
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //test to see if the result is correct or not 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNoOK()
        {
            //create an instance of pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to test the number of the pharmacist
            string ContactNo = "";
            APharmacist.ContactNo = ContactNo;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APharmacist.ContactNo, ContactNo);
        }

        [TestMethod]
        public void ContactNoPropertyOK()
        {
            //create an instance of pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to test the number of the pharmacist
            string ContactNo = "12345678910";
            APharmacist.ContactNo = ContactNo;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APharmacist.ContactNo, ContactNo);
        }

        [TestMethod]
        //this will be used for testing the pharmacist contact no of the class
        public void ContactNoMinBoundary()             // 11 char.
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ContactNo = "";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMinPlusOne of the class
        public void ContactNoMinPlusOne()              // 12 char.
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ContactNo = "111111111111";
            //invoke the method
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMinLessOne of the class
        public void ContactNoMinLessOne()               // 10 char.
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "1";
            //create some test data to test the method
            string ContactNo = "";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMaxBoundary of the class
        public void ContactNoMaxBoundary()              // 11 char. 
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //test variable by adding '11' 11 times 
            ContactNo = ContactNo.PadRight(11, '1');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMaxLessOne of the class
        public void ContactNoMaxLessOne()             // 10 char.  
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //test variable by adding '1' 10 times 
            ContactNo = ContactNo.PadRight(11, '1');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMaxPlusOne of the class
        public void ContactNoMaxPlusOne()           // 12 char.
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ContactNo = "111111111111";
            //invoke the method
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMid of the class
        public void ContactNoMid()         // 5 characters
        {
            //create an instance of the Pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ContactNo = "11111";
            //invoke the method
            Error = APharmacist.Valid(PharmacistName, ContactNo, PharmacistID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoFound of the class
        public void TestContactNoFound()
        {
            //create an instance of pharmacist class
            clsPharmacist APharmacist = new clsPharmacist();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 TestContactNo = 1;
            //invoke the method 
            Found = APharmacist.Find(TestContactNo);
            //check the property
            if (APharmacist.ContactNo != "TestContactNo")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}
