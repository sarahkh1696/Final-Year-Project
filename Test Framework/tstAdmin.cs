using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstAdmin
    {
        //create some test data to pass the valid method 
        string AdminID = "1";
        string AdminName = "TestAdminName";

        public string TestAdmin;
        //here is a test for admin's id 
        Int32 TestAdminID = 1;
        //here is a test for admin's name 
        String TestAdminName = "TestAdminName";

        public string Sam { get; private set; }
        //public int AdminID { get; private set; }
        //public string AdminName { get; private set; }

        [TestMethod]
        //this will be used for testing the Admin of the class
        public void InstanceOK()
        {
            //create an instance of the class
            clsAdmin AnAdmin = new clsAdmin();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(AnAdmin);
        }

        [TestMethod]
        //this will be used for testing the AdminNameOK of the class
        public void AdminNameOK()
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to test the name of the admin
            String AdminName = "";
            //send some data to the Admin
            AnAdmin.AdminName = AdminName;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(AnAdmin.AdminName, AdminName);
        }

        [TestMethod]
        //this will be used for testing the AdminNameProperty of the class
        public void AdminNamePropertyOK()
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to test the name of the admin
            String TestData = Sam;
            //send some data to the Admin
            AnAdmin.AdminName = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(AnAdmin.AdminName, TestData);
        }

        [TestMethod]
        //this will be used for testing the Admin of the class
        public void AdminNameMinBoundary()             // 15 char.
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string AdminName = "";
            //invoke the method 
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminNameMinPlusOne of the class
        public void AdminNameMinPlusOne()              // 15 char.
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string AdminName = "sssssssssssssss";
            //invoke the method
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminNameMinLessOne of the class
        public void AdminNameMinLessOne()               // 14 char.
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "S";
            // create some test data to test the method
            string AdminName = "";
            //invoke the method 
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminNameMaxBoundary of the class
        public void AdminNameMaxBoundary()              // 15 char. 
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //test variable by adding 's' 15 times 
            AdminName = "";
            AdminName = AdminName.PadRight(15, 's');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminNameMaxLessOne of the class
        public void AdminNameMaxLessOne()             // 14 char.  
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //test variable by adding 's' 14 times 
            AdminName = AdminName.PadRight(14, 's');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminNameMaxPlusOne of the class
        public void AdminNameMaxPlusOne()
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string AdminName = "sssssssssssssss";
            //invoke the method
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminNameMid of the class
        public void AdminNameMid()         // 8 characters
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string AdminName = "ssssssss";
            // invoke the method
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminIDOK of the class
        public void AdminIDOK()
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the admin's id
            Int32 AdminID = 1234;
            //assign an admin to the variable 
            //send some data to the Admin
            AnAdmin.AdminID = AdminID;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(AnAdmin.AdminID, AdminID);
        }

        [TestMethod]
        //this will be used for testing the AdminIDPropertyOK of the class
        public void AdminIDPropertyOK()
        {
            //create an instance of the class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the admin's Id 
            Int32 AdminID;
            //assign a value to the variable to test te id 
            AdminID = 1234;
            AnAdmin.AdminID = AdminID;
            //check to see if the data in the variable and the propert are identical 
            Assert.AreEqual(AnAdmin.AdminID, AdminID);
        }

        [TestMethod]
        //this will be used for testing the AdminIDMinBoundary of the class
        public void AdminIDMinBoundary()                // 8 char.
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string AdminID = "11111111";
            //invoke the method 
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminIDMinPlusOne of the class
        public void AdminIDMinPlusOne()                 // 9 char.
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string AdminID = "111111111";
            //invoke the method
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminIDMinLessOne of the class
        public void AdminIDMinLessOne()
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            AdminID = "1";
            //invoke the method 
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminIDMaxBoundary of the class
        public void AdminIDMaxBoundary()                  // 50 char.
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "";
            //create a test data to test the method 
            string AdminID = "11111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminIDMaxLessOne of the class
        public void AdminIDMaxLessOne()                 // 49 char.
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method 
            string AdminID = "1111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminIDMaxPlusOne of the class
        public void AdminIDMaxPlusOne()                 // 51 char.  
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string AdminID = "11111111111111111111111111";
            //invoke the method
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminIDMid of the class
        public void AdminIDMid()                       // 25 characters
        {
            //create an instance of the Admin class
            clsAdmin AnAdmin = new clsAdmin();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string AdminID = "1111111111111111111111111";
            // invoke the method
            Error = AnAdmin.Valid(AdminName);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AdminIDFound of the class
        public void TestAdminIDFound()
        {
            //create the instance of the class 
            clsAdmin AnAdmin = new clsAdmin();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 AdminID = 1;
            //invoke the method 
            Found = AnAdmin.Find(AdminID);
            //check the AdminID
            if (AnAdmin.AdminID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        //this will be used for testing the AdminNameFound of the class
        public void TestAdminNameFound()
        {
            //create an instance of admin class
            clsAdmin AnAdmin = new clsAdmin();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 TestAdminID = 1;
            //invoke the method 
            Found = AnAdmin.Find(TestAdminID);
            //check the property
            if (AnAdmin.AdminName != "TestAdminName")
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
            clsAdmin AnAdmin = new clsAdmin();
            //create a new variable error 
            String Error = "";
            //invoke the method
            Error = AnAdmin.Valid(AdminName);
            //test to see if the result is correct or not 
            Assert.AreEqual(Error, "");
        }

    }
}
//End of the test 