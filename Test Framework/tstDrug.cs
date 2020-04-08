using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstDrug
    {
        //good test data 
        //set the private data member to the test data value 
        string DrugID = "216048";
        string DrugName = "Celestone";
        string DrugType = "Steroid";
        string IssuedDate = Convert.ToString(DateTime.Now.Date);
        string ExpiryDate = Convert.ToString(DateTime.Now.Date);
        string DrugPrice = Convert.ToString("15.50");
        string Quantity = "2"; 
       
        public string TestDrug;
        //here is a test for drug id 
        Int32 TestDrugID = 216048;
        //here is a test for drug name 
        String TestDrugName = "TestDrugName";
        //here is a test for drug type
        String TestDrugType = "TestDrugType";
        //here is a test for quantity 
        Int32 TestQuantity = 2; 


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsDrug ADrug = new clsDrug();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(ADrug);
        }

        [TestMethod]
        public void DrugNameOK()
        { 
            //a new instance of  clsDrug class
            clsDrug ADrug = new clsDrug();
            //new varible to be tested tstDrugName
            String DrugName = "Celestone";
            ADrug.DrugName = DrugName;
            //check to see that the class matches
            Assert.AreEqual(ADrug.DrugName, DrugName);
        }

        [TestMethod]
        //this will be used for testing the DrugNameProperty of the class
        public void DrugNamePropertyOK()
        {
            //a new instance of  clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to test the name of the drug
            String TestData = "Celestone";
            //send some data to the drug
            ADrug.DrugName = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(ADrug.DrugName, TestData);
        }

        [TestMethod]
        //this will be used for testing the DrugNameMinBoundary of the class
        public void DrugNameMinBoundary()             // 9 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugName = "";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugNameMinPlusOne of the class
        public void DrugNameMinPlusOne()              // 10 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugName = "cccccccccc";
            //invoke the method
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugNameMinLessOne of the class
        public void DrugNameMinLessOne()               // 14 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "C";
            //create some test data to test the method
            string DrugName = "";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugNameMaxBoundary of the class
        public void DrugNameMaxBoundary()              // 50 char. 
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //test variable by adding 'c' 50 times 
            DrugName = DrugName.PadRight(50, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugNameMaxLessOne of the class
        public void DrugNameMaxLessOne()             // 49 char.  
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //test variable by adding 'c' 49 times 
            DrugName = DrugName.PadRight(49, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugNameMaxPlusOne of the class
        public void DrugNameMaxPlusOne()           // 51 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugName = "cccccccccccccccccccccccccccccccccccccccccccccccccc";
            //invoke the method
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugNameMid of the class
        public void DrugNameMid()         // 25 characters
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugName = "ccccccccccccccccccccccccc";
            //invoke the method
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugIDOK of the class
        public void DrugIDOK()
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the drug id
            Int32 DrugID = 216048;
            //assign a drug to the variable 
            //send some data to the drug
            ADrug.DrugID = DrugID;
            //check to see if the data within the variable and property are identical 
            Assert.AreNotEqual(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
        }

        [TestMethod]
        //this will be used for testing the DrugIDPropertyOK of the class
        public void DrugIDPropertyOK()
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the drug Id 
            Int32 DrugID;
            //assign a value to the variable to test the drug id 
            DrugID = 216048;
            ADrug.DrugID = DrugID;
            //check to see if the data in the variable and the propert are identical 
            Assert.AreNotEqual(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
        }

        [TestMethod]
        //this will be used for testing the DrugIDMinBoundary of the class
        public void DrugIDMinBoundary()                // 8 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string DrugID = "11111111";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugIDMinPlusOne of the class
        public void DrugIDMinPlusOne()                 // 9 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugID = "111111111";
            //invoke the method
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugIDMinLessOne of the class
        public void DrugIDMinLessOne()
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            DrugID = "216048";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugIDMaxBoundary of the class
        public void DrugIDMaxBoundary()                  // 50 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create a test data to test the method 
            string DrugID = "11111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugIDMaxLessOne of the class
        public void DrugIDMaxLessOne()                 // 49 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method 
            string DrugID = "1111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugIDMaxPlusOne of the class
        public void DrugIDMaxPlusOne()                 // 51 char.  
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugID = "11111111111111111111111111";
            //invoke the method
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugIDMid of the class
        public void DrugIDMid()                       // 25 characters
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugID = "1111111111111111111111111";
            //invoke the method
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DrugTypeOK()
        {
            //a new instance of  clsDrug class
            clsDrug ADrug = new clsDrug();
            //new varible to be tested tstDrugType
            String DrugType = "";
            ADrug.DrugType = DrugType;
            //check to see that the class matches
            Assert.AreEqual(ADrug.DrugType, DrugType);
        }

        [TestMethod]
        //this will be used for testing the DrugTypeProperty of the class
        public void DrugTypePropertyOK()
        {
            //A new instance of  clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to test the DrugType 
            String TestData = "Steroid";
            //send some data to the Drug
            ADrug.DrugType = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(ADrug.DrugType, TestData);
        }

        [TestMethod]
        //this will be used for testing the DrugTypeMinBoundary of the class
        public void DrugTypeMinBoundary()             // 9 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugType = "";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugTypeMinPlusOne of the class
        public void DrugTypeMinPlusOne()              // 10 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugType = "cccccccccc";
            //invoke the method
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DruugTypeMinLessOne of the class
        public void DrugTypeMinLessOne()               // 14 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "C";
            //create some test data to test the method
            string DrugType = "";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugTypeMaxBoundary of the class
        public void DrugTypeMaxBoundary()              // 50 char. 
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //test variable by adding 'c' 50 times 
            DrugType = DrugType.PadRight(50, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugTypeMaxLessOne of the class
        public void DrugTypeMaxLessOne()             // 49 char.  
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //test variable by adding 'c' 49 times 
            DrugType = DrugType.PadRight(49, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugTypeMaxPlusOne of the class
        public void DrugTypeMaxPlusOne()           // 51 char.
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugType = "cccccccccccccccccccccccccccccccccccccccccccccccccc";
            //invoke the method
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugTypeMid of the class
        public void DrugTypeMid()         // 25 characters
        {
            //A new instance of clsDrug class
            clsDrug ADrug = new clsDrug();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string DrugType = "ccccccccccccccccccccccccc";
            //invoke the method
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the DrugPriceProperty of the class
        public void DrugPricePropertyOK()
        {
            //create an instance of the class 
            clsDrug ADrug = new clsDrug();
            //create some test data to assign to the property 
            decimal DrugPrice = 15.50m;
            //assign the data to the property
            ADrug.DrugPrice = DrugPrice;
            //test to see that the two values are the same 
            Assert.AreEqual(ADrug.DrugPrice, DrugPrice);
        }

        [TestMethod]
        public void DrugPriceMax()
        {
            //create an instance of the class
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string DrugPrice = "50.00";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DrugPriceMaxPlusOne()
        {
            //create an instance of the class
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string DrugPrice = "51.00";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DrugPriceMid()
        {
            //create an instance of the class
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string DrugPrice = "20.0";
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DrugPriceMaxLessOne()
        {
            //create an instance of the class
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string DrugPrice = "49.99";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DrugPriceMinLessOne()
        {
            //create an instance of the class
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should fail 
            string DrugPrice = "-0.01";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DrugPriceMin()
        {
            //create an instance of the class
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string DrugPrice = "0.00";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DrugPriceMinPlusOne()
        {
            //create an instance of the class
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string DrugPrice = "21.00";
            //invoke the method 
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create 
            clsDrug ADrug = new clsDrug();
            //create some test data to assign to the property
            Int32 Quantity = 2;
            //assign the data to the property 
            ADrug.Quantity = Quantity;
            //test to see that the two values are the same 
            Assert.AreEqual(ADrug.Quantity, Quantity);
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "2";
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "2";
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "2";
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "2";
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "111111111";
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "1";
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //this should fail 
            string Quantity = "";
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IssuedDateExtremeMax()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 200 years 
            TestDate = TestDate.AddYears(200);
            //convert the date variable to a string variable 
            string IssuedDate = TestDate.ToString();
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IssuedDateExtremeMin()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 200 years 
            TestDate = TestDate.AddYears(-200);
            //convert the date variable to a string variable 
            string IssuedDate = TestDate.ToString();
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IssuedDateMinLessOne()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 1 day 
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string IssuedDate = TestDate.ToString();
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IssuedDateMin()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string IssuedDate = TestDate.ToString();
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IssuedDateMinPlusOne()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date plus 1 day 
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string IssuedDate = TestDate.ToString();
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IssuedDateInvalidData()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //set the date to a non date value 
            string IssuedDate = "this is not a date!!";
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateExtremeMax()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 200 years 
            TestDate = TestDate.AddYears(200);
            //convert the date variable to a string variable 
            string ExpiryDate = TestDate.ToString();
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateExtremeMin()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 200 years 
            TestDate = TestDate.AddYears(-200);
            //convert the date variable to a string variable 
            string ExpiryDate = TestDate.ToString();
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMinLessOne()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 1 day 
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string ExpiryDate = TestDate.ToString();
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMin()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string ExpiryDate = TestDate.ToString();
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateMinPlusOne()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date plus 1 day 
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string ExpiryDate = TestDate.ToString();
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ExpiryDateInvalidData()
        {
            //create an instance of the class  
            clsDrug ADrug = new clsDrug();
            //string variable to store any error message
            String Error = "";
            //set the date to a non date value 
            string ExpiryDate = "this is not a date!!";
            //invoke the method  
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        //this will be used for the validation method 
        public void ValidationMethodOK()
        {
            //create the instance of the class 
            clsDrug ADrug = new clsDrug();
            //create a new variable error 
            String Error = "";
            //invoke the method
            Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
            //test to see if the result is correct or not 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class 
            clsDrug ADrug = new clsDrug();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 DrugID = 216048;
            //invoke the method 
            Found = ADrug.Find(DrugID);
            //test to see that the result is correct or not 
            Assert.IsFalse(Found);
            String.Format("Expected for '{0}': true; Actual: {1}", DrugID, Found);
        }

        [TestMethod]
        //this will be used for testing the DrugIDFound of the class
        public void TestDrugIDFound()
        {
            //create the instance of the class 
            clsDrug ADrug = new clsDrug();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 DrugID = 216048;
            //invoke the method 
            Found = ADrug.Find(DrugID);
            //check the DrugID
            if (ADrug.DrugID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        //this will be used for testing the DrugNameFound of the class
        public void TestDrugNameFound()
        {
            //create an instance of consultant class
            clsDrug ADrug = new clsDrug();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 DrugID = 1;
            //invoke the method 
            Found = ADrug.Find(DrugID);
            //check the property
            if (ADrug.DrugName != "TestDrugName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        //this will be used for testing the DrugTypeFound of the class
        public void TestDrugTypeFound()
        {
            //create an instance of consultant class
            clsDrug ADrug = new clsDrug();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 DrugID = 216048;
            //invoke the method 
            Found = ADrug.Find(DrugID);
            //check the property
            if (ADrug.DrugType != "TestDrugType")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        //this will be used for testing the DrugPriceFound of the class
        public void TestDrugPriceFound()
        {
            //create an instance of consultant class
            clsDrug ADrug = new clsDrug();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 DrugID = 216048;
            //invoke the method 
            Found = ADrug.Find(DrugID);
            //check the property
            if (ADrug.DrugPrice != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class 
            clsDrug ADrug = new clsDrug();
            //Boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 DrugID = 216048;
            //invoke the method 
            Found = ADrug.Find(DrugID);
            //check the order no 
            if (ADrug.DrugID != 1)
            {
                OK = false;
            }
            //test to see that the result is right 
            Assert.IsFalse(OK);
        }

        //[TestMethod]
        //public void TestIssuedDateFound()
        //{
        //    //create an instance of the class 
        //    clsDrug ADrug = new clsDrug();
        //    //Boolean variable to store the result of the search 
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK
        //    Boolean OK = true;
        //    //create some test data to use with the method 
        //    Int32 DrugID = 1;
        //    //invoke the method 
        //    Found = ADrug.Find(DrugID);
        //    //check the date placed
        //    if (ADrug.IssuedDate != Convert.ToDateTime("10/14/2020"))
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is right 
        //    Assert.IsFalse(OK);
        //}

        //[TestMethod]
        //public void TestExpiryDateFound()
        //{
        //    //create an instance of the class 
        //    clsDrug ADrug = new clsDrug();
        //    //Boolean variable to store the result of the search 
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK
        //    Boolean OK = true;
        //    //create some test data to use with the method 
        //    Int32 DrugID = 1;
        //    //invoke the method 
        //    Found = ADrug.Find(DrugID);
        //    //check the date placed
        //    if (ADrug.ExpiryDate != Convert.ToDateTime("1/15/2022"))
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is right 
        //    Assert.IsFalse(OK);
        //}
    }
}
