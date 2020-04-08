using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstConsultant
    {
        //good test data 
        //set the private data member to the test data value 
        string ConsultantID = "1";
        string PatientID = "1";
        string ConsultantName = "Gill";
        string DateAdded = Convert.ToString(DateTime.Now.Date);
        string DrugType = "Bio";
        string ConsultantSpecialist = "Dentist";
        string ConsultantComment = "Adding some comment here";

        public string TestConsultant;
        //here is a test for Consultant id 
        Int32 TestConsultantID = 1;
        //here is a test for consultant name 
        String TestConsultantName = "TestConsultantName";
        //here is a test for consultant specialist
        String TestConsultantSpecialist = "TestConsultantSpecialist";
        //here is a test for consultant comment
        String TestConsultantComment = "TestConsultantComment";
        //here is a test for drug type
        String TestDrugType = "TestDrugType";
        //here is a test for patient id 
        Int32 TestPatientID = 1;
        //here is a test for date added 
        //DateTime TestDateAdded = ;
        public string Gill { get; private set; }


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsConsultant AConsultant = new clsConsultant();
            //check to see that the class is not null and that it exists
            Assert.IsNotNull(AConsultant);
        }

        [TestMethod]
        public void ConsultantNameOK()
        {
            //A new instance of  clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //new varible to be tested tstConsultantName
            String ConsultantName = Gill;
            AConsultant.ConsultantName = ConsultantName;
            //check to see that the class matches
            Assert.AreEqual(AConsultant.ConsultantName, ConsultantName);
        }

        [TestMethod]
        //this will be used for testing the ConsultantNameProperty of the class
        public void ConsultantNamePropertyOK()
        {
            //A new instance of  clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to test the name of the consultant
            String TestData = Gill;
            //send some data to the consultant
            AConsultant.ConsultantName = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(AConsultant.ConsultantName, TestData);
        }

        [TestMethod]
        //this will be used for testing the ConsultantNameMinBoundary of the class
        public void ConsultantNameMinBoundary()             // 9 char.
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantName = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantNameMinPlusOne of the class
        public void ConsultantNameMinPlusOne()              // 10 char.
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantName = "cccccccccc";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantNameMinLessOne of the class
        public void ConsulltantNameMinLessOne()               // 14 char.
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "C";
            //create some test data to test the method
            string ConsultantName = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantNameMaxBoundary of the class
        public void ConsultantNameMaxBoundary()              // 50 char. 
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //test variable by adding 'c' 50 times 
            ConsultantName = ConsultantName.PadRight(50, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantNameMaxLessOne of the class
        public void ConsultantNameMaxLessOne()             // 49 char.  
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //test variable by adding 'c' 49 times 
            ConsultantName = ConsultantName.PadRight(49, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantNameMaxPlusOne of the class
        public void ConsultantNameMaxPlusOne()           // 51 char.
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantName = "cccccccccccccccccccccccccccccccccccccccccccccccccc";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantNameMid of the class
        public void ConsultantNameMid()         // 25 characters
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantName = "ccccccccccccccccccccccccc";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantIDOK of the class
        public void ConsultantIDOK()
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the Consultant id
            Int32 ConsultantID = 123456;
            //assign a Consultant to the variable 
            //send some data to the Consultant
            AConsultant.ConsultantID = ConsultantID;
            //check to see if the data within the variable and property are identical 
            Assert.AreNotEqual(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded);
        }

        [TestMethod]
        //this will be used for testing the ConsultantIDPropertyOK of the class
        public void ConsultantIDPropertyOK()
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the Consultant Id 
            Int32 ConsultantID;
            //assign a value to the variable to test the consultant id 
            ConsultantID = 123456;
            AConsultant.ConsultantID = ConsultantID;
            //check to see if the data in the variable and the propert are identical 
            Assert.AreNotEqual(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
        }

        [TestMethod]
        //this will be used for testing the ConsultantIDMinBoundary of the class
        public void ConsultantIDMinBoundary()                // 8 char.
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string ConsultantID = "11111111";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantIDMinPlusOne of the class
        public void ConsultantIDMinPlusOne()                 // 9 char.
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantID = "111111111";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantIDMinLessOne of the class
        public void ConsultantIDMinLessOne()
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            ConsultantID = "1";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantIDMaxBoundary of the class
        public void ConsultantIDMaxBoundary()                  // 50 char.
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create a test data to test the method 
            string ConsultantID = "11111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantIDMaxLessOne of the class
        public void ConsultantIDMaxLessOne()                 // 49 char.
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method 
            string ConsultantID = "1111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantIDMaxPlusOne of the class
        public void ConsultantIDMaxPlusOne()                 // 51 char.  
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantID = "11111111111111111111111111";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantIDMid of the class
        public void ConsultantIDMid()                       // 25 characters
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantID = "1111111111111111111111111";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ConsultantSpecialistOK()
        {
            //A new instance of  clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //new varible to be tested tstConsultantSpecialist
            String ConsultantSpecialist = "";
            AConsultant.ConsultantSpecialist = ConsultantSpecialist;
            //check to see that the class matches
            Assert.AreEqual(AConsultant.ConsultantSpecialist, ConsultantSpecialist);
        }

        [TestMethod]
        //this will be used for testing the ConsultantSpecialist Property of the class
        public void ConsultantSpecialistPropertyOK()
        {
            //A new instance of  clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to test the Specialist of the consultant
            String TestData = "Bio";
            //send some data to the Consultant
            AConsultant.ConsultantSpecialist = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(AConsultant.ConsultantSpecialist, TestData);
        }

        [TestMethod]
        //this will be used for testing the ConsultantSpecialistMinBoundary of the class
        public void ConsultantSpecialistMinBoundary()             // 9 char.
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantSpecialist = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantSpecialistMinPlusOne of the class
        public void ConsultantSpecialistMinPlusOne()              // 10 char.
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantSpecialist = "cccccccccc";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantSpecialistMinLessOne of the class
        public void ConsulltantSpecialistMinLessOne()               // 14 char.
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "C";
            //create some test data to test the method
            string ConsultantSpecialist = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantSpecialistMaxBoundary of the class
        public void ConsultantSpecialistMaxBoundary()              // 50 char. 
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //test variable by adding 'c' 50 times 
            ConsultantSpecialist = ConsultantSpecialist.PadRight(50, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantSpecialistMaxLessOne of the class
        public void ConsultantSpecialistMaxLessOne()             // 49 char.  
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //test variable by adding 'c' 49 times 
            ConsultantSpecialist = ConsultantSpecialist.PadRight(49, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantSpecialistMaxPlusOne of the class
        public void ConsultantSpecialistMaxPlusOne()           // 51 char.
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantSpecialist = "cccccccccccccccccccccccccccccccccccccccccccccccccc";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantSpecialistMid of the class
        public void ConsultantSpecialistMid()         // 25 characters
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantSpecialist = "ccccccccccccccccccccccccc";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ConsultantCommentOK()
        {
            //A new instance of  clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //new varible to be tested tstConsultantComment
            String ConsultantComment = "";
            AConsultant.ConsultantComment = ConsultantComment;
            //check to see that the class matches
            Assert.AreEqual(AConsultant.ConsultantComment, ConsultantComment);
        }

        [TestMethod]
        //this will be used for testing the ConsultantComment Property of the class
        public void ConsultantCommentPropertyOK()
        {
            //A new instance of  clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to test consultant comment
            String TestData = "Adding some comment here";
            //send some data to the Consultant
            AConsultant.ConsultantComment = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(AConsultant.ConsultantComment, TestData);
        }

        [TestMethod]
        //this will be used for testing the ConsultantCommentMinBoundary of the class
        public void ConsultantCommentMinBoundary()             // 9 char.
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantComment = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantCommentMinPlusOne of the class
        public void ConsultantCommentMinPlusOne()              // 10 char.
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantComment = "cccccccccc";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantCommentMinLessOne of the class
        public void ConsulltantCommentMinLessOne()               // 14 char.
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "C";
            //create some test data to test the method
            string ConsultantComment = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantCommentMaxBoundary of the class
        public void ConsultantCommentMaxBoundary()              // 50 char. 
        {
            //A new instance of clsConsultant class
            clsConsultant AConsultant = new clsConsultant();
            //test variable by adding 'c' 50 times 
            ConsultantComment = ConsultantComment.PadRight(50, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantCommentMaxLessOne of the class
        public void ConsultantCommentMaxLessOne()             // 49 char.  
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //test variable by adding 'c' 49 times 
            ConsultantComment = ConsultantComment.PadRight(49, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantCommentMaxPlusOne of the class
        public void ConsultantCommentMaxPlusOne()           // 51 char.
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantComment = "cccccccccccccccccccccccccccccccccccccccccccccccccc";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantCommentMid of the class
        public void ConsultantCommentMid()         // 25 characters
        {
            //create an instance of the Consultant class
            clsConsultant AConsultant = new clsConsultant();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ConsultantComment = "ccccccccccccccccccccccccc";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsConsultant ADate = new clsConsultant();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            ADate.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ADate.DateAdded, TestData);
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create 
            clsConsultant ADate = new clsConsultant();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 200 years 
            TestDate = TestDate.AddYears(200);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method  
            Error = ADate.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create 
            clsConsultant ADate = new clsConsultant();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 200 years 
            TestDate = TestDate.AddYears(-200);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method  
            Error = ADate.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create 
            clsConsultant ADate = new clsConsultant();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 1 day 
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method  
            Error = ADate.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create 
            clsConsultant ADate = new clsConsultant();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method  
            Error = ADate.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsConsultant ADate = new clsConsultant();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date plus 1 day 
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method  
            Error = ADate.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create 
            clsConsultant ADate = new clsConsultant();
            //string variable to store any error message
            String Error = "";
            //set the date to a non date value 
            string DateAdded = "this is not a date!!";
            //invoke the method  
            Error = ADate.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ConsultantIDFound of the class
        public void TestConsultantIDFound()
        {
            //create the instance of the class 
            clsConsultant AConsultant = new clsConsultant();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ConsultantID = 1;
            //invoke the method 
            Found = AConsultant.Find(ConsultantID);
            //check the ConsultantID
            if (AConsultant.ConsultantID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //this will be used for testing the ConsultantNameFound of the class
        public void TestConsultantNameFound()
        {
            //create an instance of consultant class
            clsConsultant AConsultant = new clsConsultant();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ConsultantID = 1;
            //invoke the method 
            Found = AConsultant.Find(ConsultantID);
            //check the property
            if (AConsultant.ConsultantName != "TestConsultantName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        //this will be used for testing the ConsultantSpecialistFound of the class
        public void TestConsultantSpecialistFound()
        {
            //create an instance of consultant class
            clsConsultant AConsultant = new clsConsultant();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ConsultantID = 1;
            //invoke the method 
            Found = AConsultant.Find(ConsultantID);
            //check the property
            if (AConsultant.ConsultantSpecialist != "TestConsultantSpecialist")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //this will be used for testing the ConsultantCommentFound of the class
        public void TestConsultantCommentFound()
        {
            //create an instance of consultant class
            clsConsultant AConsultant = new clsConsultant();
            //boolean var to store the result to the validation 
            Boolean Found = false;
            //boolean var to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ConsultantID = 1;
            //invoke the method 
            Found = AConsultant.Find(ConsultantID);
            //check the property
            if (AConsultant.ConsultantName != "TestConsultantComment")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class  
            clsConsultant ADrug = new clsConsultant();
            //Boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 ConsultantID = 1;
            //invoke the method 
            Found = ADrug.Find(ConsultantID);
            //check the date placed
            if (ADrug.DateAdded != Convert.ToDateTime("05/04/2020"))
            {
                OK = false;
            }
            //test to see that the result is right 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //this will be used for the validation method 
        public void ValidationMethodOK()
        {
            //create the instance of the class 
            clsConsultant AConsultant = new clsConsultant();
            //create a new variable error 
            String Error = "";
            //invoke the method
            Error = AConsultant.Valid(ConsultantName, ConsultantComment, ConsultantSpecialist, PatientID, DrugType, DateAdded, ConsultantID);
            //test to see if the result is correct or not 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class 
            clsConsultant AConsultant = new clsConsultant();
            //boolean variable to store the result od the validation 
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 ConsultantID = 1;
            //invoke the method 
            Found = AConsultant.Find(ConsultantID);
            //test to see that the result is correct or not 
            Assert.IsTrue(Found);
            String.Format("Expected for '{0}': true; Actual: {1}", ConsultantID, Found);
        }
    }
}