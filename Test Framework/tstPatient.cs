using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstPatient
    {
        //good test data 
        //set the private data member to the test data value 
        string PatientID = "12345678";
        string FirstName = "Jhon";
        string LastName = "Smith";
        string Gender = "Male";
        string Age = "22";
        string AddressLine = "3 Belgrave Road";
        string DateAdded = Convert.ToString(DateTime.Now.Date);
        string ContactNo = "0754236780";

        public string TestPatient;
        //here is a test for patient id 
        Int32 TestPatientID = 12345678;
        //here is a test for patient first name 
        String TestFirstName = "TestFirstName";
        //here is a test for patient last name 
        String TestLastName = "TestLastName";
        //here is a test for gender
        string TestGender = "TestGender";
        //here is a test for age 
        Int32 TestAge = 22;
        //here is a test for addressline 
        string TestAddressLine = "TestAddressLine";
        //here is a test for contactno 
        string TestContactNo = "TestContactNo";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsPatient APatient = new clsPatient();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(APatient);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            //a new instance of  clsPatient class
            clsPatient APatient = new clsPatient();
            //new varible to be tested tstFirstName
            String FirstName = "Jhon";
            APatient.FirstName = FirstName;
            //check to see that the class matches
            Assert.AreEqual(APatient.FirstName, FirstName);
        }

        [TestMethod]
        //this will be used for testing the FirstNameProperty of the class
        public void FirstNamePropertyOK()
        {
            //a new instance of  clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to test the name of the patient
            String TestData = "Jhon";
            //send some data to the first name
            APatient.FirstName = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APatient.FirstName, TestData);
        }

        [TestMethod]
        //this will be used for testing the FirstNameMinBoundary of the class
        public void FirstNameMinBoundary()             // 9 char.
        {
            //a new instance of  clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string FirstName = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the FirstNameMinPlusOne of the class
        public void FirstNameMinPlusOne()              // 10 char.
        {
            //a new instance of  clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string FirstName = "cccccccccc";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the FirstNameMinLessOne of the class
        public void FirstNameMinLessOne()               // 14 char.
        {
            //a new instance of  clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "C";
            //create some test data to test the method
            string FirstName = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the FirstNameMaxBoundary of the class
        public void FirstNameMaxBoundary()              // 50 char. 
        {
            //a new instance of  clsPatient class
            clsPatient APatient = new clsPatient();
            //test variable by adding 'c' 50 times 
            FirstName = FirstName.PadRight(50, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the FirstNameMaxLessOne of the class
        public void FirstNameMaxLessOne()             // 49 char.  
        {
            //a new instance of  clsPatient class
            clsPatient APatient = new clsPatient();
            //test variable by adding 'c' 49 times 
            FirstName = FirstName.PadRight(49, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the FirstNameMaxPlusOne of the class
        public void FirstNameMaxPlusOne()           // 51 char.
        {
            //a new instance of  clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string FirstName = "cccccccccccccccccccccccccccccccccccccccccccccccccc";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the FirstNameMid of the class
        public void FirstNameMid()         // 25 characters
        {
            //a new instance of  clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string FirstName = "ccccccccccccccccccccccccc";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameOK()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //new varible to be tested tstLastName
            String LastName = "Smith";
            APatient.LastName = LastName;
            //check to see that the class matches
            Assert.AreEqual(APatient.LastName, LastName);
        }

        [TestMethod]
        //this will be used for testing the LastNameProperty of the class
        public void LastNamePropertyOK()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to test the last name of the patient
            String TestData = "Jhon";
            //send some data to the last name
            APatient.LastName = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APatient.LastName, TestData);
        }

        [TestMethod]
        //this will be used for testing the LastNameMinBoundary of the class
        public void LastNameMinBoundary()             // 9 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string LastName = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the LastNameMinPlusOne of the class
        public void LastNameMinPlusOne()              // 10 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string LastName = "cccccccccc";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the LastNameMinLessOne of the class
        public void LastNameMinLessOne()               // 14 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "C";
            //create some test data to test the method
            string LastName = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the LastNameMaxBoundary of the class
        public void LastNameMaxBoundary()              // 50 char. 
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //test variable by adding 'c' 50 times 
            LastName = LastName.PadRight(50, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the LastNameMaxLessOne of the class
        public void LastNameMaxLessOne()             // 49 char.  
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //test variable by adding 'c' 49 times 
            LastName = LastName.PadRight(49, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the LastNameMaxPlusOne of the class
        public void LastNameMaxPlusOne()           // 51 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string LastName = "cccccccccccccccccccccccccccccccccccccccccccccccccc";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the LastNameMid of the class
        public void LastNameMid()         // 25 characters
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string LastName = "ccccccccccccccccccccccccc";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDOK of the class
        public void PatientIDOK()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the patient id
            Int32 PatientID = 12345678;
            //assign a patient to the variable 
            //send some data to the patient
            APatient.PatientID = PatientID;
            //check to see if the data within the variable and property are identical 
            Assert.AreNotEqual(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
        }

        [TestMethod]
        //this will be used for testing the PatientIDPropertyOK of the class
        public void PatientIDPropertyOK()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the patient id 
            Int32 PatientID;
            //assign a value to the variable to test the patient id 
            PatientID = 12345678;
            APatient.PatientID = PatientID;
            //check to see if the data in the variable and the propert are identical 
            Assert.AreNotEqual(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
        }

        [TestMethod]
        //this will be used for testing the PatientIDMinBoundary of the class
        public void PatientIDMinBoundary()                // 8 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string PatientID = "11111111";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMinPlusOne of the class
        public void PatientIDMinPlusOne()                 // 9 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PatientID = "111111111";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMinLessOne of the class
        public void PatientIDMinLessOne()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            PatientID = "12345678";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMaxBoundary of the class
        public void PatientIDMaxBoundary()                  // 50 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create a test data to test the method 
            string PatientID = "11111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMaxLessOne of the class
        public void PatientIDMaxLessOne()                 // 49 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method 
            string PatientID = "1111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMaxPlusOne of the class
        public void PatientIDMaxPlusOne()                 // 51 char.  
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PatientID = "11111111111111111111111111";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the PatientIDMid of the class
        public void PatientIDMid()                       // 25 characters
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string PatientID = "1111111111111111111111111";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderOK()
        {  
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //new varible to be tested tstGender
            String Gender = "";
            APatient.Gender = Gender;
            //check to see that the class matches
            Assert.AreEqual(APatient.Gender, Gender);
        }

        [TestMethod]
        //this will be used for testing the GenderProperty of the class
        public void GenderPropertyOK()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to test the gender 
            String TestData = "Male";
            //send some data to the Drug
            APatient.Gender = TestData;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APatient.Gender, TestData);
        }

        [TestMethod]
        //this will be used for testing the GenderMinBoundary of the class
        public void GenderMinBoundary()             // 9 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string Gender = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the GenderMinPlusOne of the class
        public void GenderMinPlusOne()              // 10 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string Gender = "cccccccccc";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the GenderMinLessOne of the class
        public void GenderMinLessOne()               // 14 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "C";
            //create some test data to test the method
            string Gender = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the GenderMaxBoundary of the class
        public void GenderMaxBoundary()              // 50 char. 
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //test variable by adding 'c' 50 times 
            Gender = Gender.PadRight(50, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the GenderMaxLessOne of the class
        public void GenderMaxLessOne()             // 49 char.  
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //test variable by adding 'c' 49 times 
            Gender = Gender.PadRight(49, 'c');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the GenderMaxPlusOne of the class
        public void GenderMaxPlusOne()           // 51 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string Gender = "cccccccccccccccccccccccccccccccccccccccccccccccccc";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the GenderMid of the class
        public void GenderMid()         // 25 characters
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string Gender = "ccccccccccccccccccccccccc";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AgeOK of the class
        public void AgeOK()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the age
            Int32 Age = 22;
            //assign a patient to the variable 
            //send some data to the patient's age
            APatient.Age = Age;
            //check to see if the data within the variable and property are identical 
            Assert.AreNotEqual(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
        }

        [TestMethod]
        //this will be used for testing the AgePropertyOK of the class
        public void AgePropertyOK()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the age
            Int32 Age;
            //assign a value to the variable to test the age 
            Age = 22;
            APatient.Age = Age;
            //check to see if the data in the variable and the propert are identical 
            Assert.AreNotEqual(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
        }

        [TestMethod]
        //this will be used for testing the AgeMinBoundary of the class
        public void AgeIDMinBoundary()                // 8 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            // create some test data to test the method
            string Age = "11111111";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AgeMinPlusOne of the class
        public void AgeMinPlusOne()                 // 9 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string Age = "111111111";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AgeMinLessOne of the class
        public void AgeMinLessOne()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            Age = "22";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AgeMaxBoundary of the class
        public void AgeMaxBoundary()                  // 50 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create a test data to test the method 
            string Age = "11111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AgeMaxLessOne of the class
        public void AgeMaxLessOne()                 // 49 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method 
            string Age = "1111111111111111111111111111111111111111111111111";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AgeMaxPlusOne of the class
        public void AgeMaxPlusOne()                 // 51 char.  
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string Age = "11111111111111111111111111";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the AgeMid of the class
        public void AgeMid()                       // 25 characters
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string Age = "1111111111111111111111111";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            APatient.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(APatient.DateAdded, TestData);
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
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
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
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
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
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
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method  
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
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
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //string variable to store any error message
            String Error = "";
            //set the date to a non date value 
            string DateAdded = "this is not a date!!";
            //invoke the method  
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNoOK()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to test the number of the patient
            string ContactNo = "";
            APatient.ContactNo = ContactNo;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APatient.ContactNo, ContactNo);
        }

        [TestMethod]
        public void ContactNoPropertyOK()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to test the number of the patient
            string ContactNo = "0754236780";
            APatient.ContactNo = ContactNo;
            //check to see if the data within the variable and property are identical 
            Assert.AreEqual(APatient.ContactNo, ContactNo);
        }

        [TestMethod]
        //this will be used for testing the patient contact no of the class
        public void ContactNoMinBoundary()             // 11 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ContactNo = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMinPlusOne of the class
        public void ContactNoMinPlusOne()              // 12 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ContactNo = "111111111111";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMinLessOne of the class
        public void ContactNoMinLessOne()               // 10 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "1";
            //create some test data to test the method
            string ContactNo = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMaxBoundary of the class
        public void ContactNoMaxBoundary()              // 11 char. 
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //test variable by adding '11' 11 times 
            ContactNo = ContactNo.PadRight(11, '1');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMaxLessOne of the class
        public void ContactNoMaxLessOne()             // 10 char.  
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //test variable by adding '1' 10 times 
            ContactNo = ContactNo.PadRight(11, '1');
            //create a variable in order to store the validation result 
            String Error = "";
            //invoke the method 
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMaxPlusOne of the class
        public void ContactNoMaxPlusOne()           // 12 char.
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ContactNo = "111111111111";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for testing the ContactNoMid of the class
        public void ContactNoMid()         // 5 characters
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a variable in order to store the validation result 
            String Error = "";
            //create some test data to test the method
            string ContactNo = "11111";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //check to see if the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineExtremeMax()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create some test data assign to the property
            String Error = "";
            //create some test data to test the method
            string AddressLine = "";
            //pad the string with characters
            AddressLine = AddressLine.PadRight(500, 'a');
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is wrong 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMaxBoundry()                      //50 char
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create some test data assign to the property
            String Error = "12werrggyyjiddfgghjkkkklllssssddddfffgghjkloiuytre";
            //create some test data to test the method
            string AddressLine = "";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMaxLessOneBoundry()                      //49 char
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create some test data assign to the property
            String Error = "12werrggyyjiddfgghjkkkklllssssddddfffgghjkloiuytr";
            //create some test data to test the method
            string AddressLine = "";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMaxPlusOneBoundry()                      //51 char
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create some test data assign to the property
            String Error = "12werrggyyjiddfgghjkkkklllssssddddfffgghjkloiuytrew";
            //create some test data to test the method
            string AddressLine = "";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMidBoundry()                      //25 char
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create some test data assign to the property
            String Error = "12werrggyyjiddfgghjkkkkll";
            //create some test data to test the method
            string AddressLine = "";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMinBoundry()                      //8 char
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create some test data assign to the property
            String Error = "12werrgg";
            //create some test data to test the method
            string AddressLine = "";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMinLessOneBoundry()                      
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create some test data assign to the property
            String Error = "3 Belgrave Road";
            //create some test data to test the method
            string AddressLine = "";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressLineMinPlusOneBoundry()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create some test data assign to the property
            String Error = "3 Belgrave Road";
            //create some test data to test the method
            string AddressLine = "";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        //this will be used for the validation method 
        public void ValidationMethodOK()
        {
            //a new instance of clsPatient class
            clsPatient APatient = new clsPatient();
            //create a new variable error 
            String Error = "";
            //invoke the method
            Error = APatient.Valid(FirstName, LastName, Gender, Age, AddressLine, DateAdded, ContactNo, PatientID);
            //test to see if the result is correct or not 
            Assert.AreEqual(Error, "");
        }

    }
}
