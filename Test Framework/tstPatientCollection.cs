using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstPatientCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsPatientCollection AllPatients = new clsPatientCollection();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(AllPatients);
        }

        [TestMethod]
        //this will be used for testing TwoRecordsPresent of the patient class
        public void TwoRecordsPresent()
        {
            //create an instance of the class
            clsPatientCollection AllPatients = new clsPatientCollection();
            //test to see if it exists or not 
            Assert.AreNotEqual(AllPatients.Count, 1);
        }

        [TestMethod]
        //this will be used for testing ThisPatient of the class
        public void ThisPatientOK()
        {
            //create an instance of the class collection
            clsPatientCollection APatient = new clsPatientCollection();
            //crate an instance of a patient class to test the item of data test 
            clsPatient TestPatient = new clsPatient();
            //set its properties 
            TestPatient.PatientID = 12345678;
            TestPatient.FirstName = "TestFirstName";
            TestPatient.LastName = "TestLastName";
            TestPatient.Gender = "TestGender";
            TestPatient.Age = 22;
            TestPatient.AddressLine = "TestAddressLine";
            TestPatient.DateAdded = DateTime.Now.Date;
            TestPatient.ContactNo = "TestContactNo";
            //assign the test variable to be into a real one 
            APatient.ThisPatient = TestPatient;
            //check if they are identical 
            Assert.AreEqual(APatient.ThisPatient, TestPatient);
        }

        [TestMethod]
        //this will be used for testing ThisPatientPropertyOK of the class
        public void ThisPatientPropertyOK()
        {
            //create an instance of the class
            clsPatientCollection APatient = new clsPatientCollection();
            //create an instance of a patient class to test the item of data test 
            clsPatient TestPatient = new clsPatient();
            //set its properties 
            TestPatient.PatientID = 12345678;
            TestPatient.FirstName = "TestFirstName";
            TestPatient.LastName = "TestLastName";
            TestPatient.Gender = "TestGender";
            TestPatient.Age = 22;
            TestPatient.AddressLine = "TestAddressLine";
            TestPatient.DateAdded = DateTime.Now.Date;
            TestPatient.ContactNo = "TestContactNo";
            //assign the test variable to be into a real one 
            APatient.ThisPatient = TestPatient;
            //check if they are identical 
            Assert.AreEqual(APatient.ThisPatient, TestPatient);
        }

        [TestMethod]
        //this will be used for testing CountOK of the class
        public void CountOK()
        {
            //new instance of Patient Collection class
            clsPatientCollection AllPatients = new clsPatientCollection();
            //create a list for patient
            List<clsPatient> PatientList = new List<clsPatient>();
            //new instance of clsPatient class to create the item of test data
            clsPatient TestItem = new clsPatient();
            //set its properties
            TestItem.PatientID = 12345678;
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.Gender = "TestGender";
            TestItem.Age = 22;
            TestItem.AddressLine = "TestAddressLine";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNo = "TestContactNo";
            //add the item to the test list
            PatientList.Add(TestItem);
            //assign the test variable into the real one
            AllPatients.PatientList = PatientList;
            //check if they are identical or not 
            Assert.AreEqual(AllPatients.Count, PatientList.Count);
        }

        [TestMethod]
        //this will be used for testing PatientListOK of the class
        public void PatientListOK()
        {
            //new instance of Patient Collection class
            clsPatientCollection AllPatients = new clsPatientCollection();
            //create a list for patient
            List<clsPatient> PatientList = new List<clsPatient>();
            //new instance of clsPatient class to create the item of test data
            clsPatient TestItem = new clsPatient();
            //set its properties
            TestItem.PatientID = 12345678;
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.Gender = "TestGender";
            TestItem.Age = 22;
            TestItem.AddressLine = "TestAddressLine";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNo = "TestContactNo";
            //add the item to the test list
            PatientList.Add(TestItem);
            //assign the test variable into the real one
            AllPatients.PatientList = PatientList;
            //check if they are identical or not 
            Assert.AreEqual(AllPatients.PatientList, PatientList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //new instance of Patient Collection class
            clsPatientCollection AllPatients = new clsPatientCollection();
            //create a list for patient
            List<clsPatient> PatientList = new List<clsPatient>();
            //new instance of clsPatient class to create the item of test data
            clsPatient TestItem = new clsPatient();
            //set its properties
            TestItem.PatientID = 12345678;
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.Gender = "TestGender";
            TestItem.Age = 22;
            TestItem.AddressLine = "TestAddressLine";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNo = "TestContactNo";
            //assign the test variable into the real one
            AllPatients.PatientList = PatientList;
            //check if they are identical or not 
            Assert.AreEqual(AllPatients.Count, PatientList.Count);
        }

        [TestMethod]
        //this will be used for testing the AddMehtodOK of the class
        public void AddMethodOK()
        {
            //new instance of Patient Collection class
            clsPatientCollection APatient = new clsPatientCollection();
            //new instance of clsPatient class to create the item of test data
            clsPatient TestItem = new clsPatient();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PatientID = 12345678;
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.Gender = "TestGender";
            TestItem.Age = 22;
            TestItem.AddressLine = "TestAddressLine";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNo = "TestContactNo";
            //set ThisPatient to the test data
            APatient.ThisPatient = TestItem;
            //add the record
            PrimaryKey = APatient.Add();
            //set the primary key of the test data
            TestItem.PatientID = PrimaryKey;
            //test to see that the two values are identical 
            Assert.AreEqual(APatient.ThisPatient, TestItem);
        }

        [TestMethod]
        //this will be used for testing the UpdateMethod of the class
        public void UpdateMethodOK()
        {
            //new instance of Patient Collection class
            clsPatientCollection APatient = new clsPatientCollection();
            //new instance of clsPatient class to create the item of test data
            clsPatient TestItem = new clsPatient();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.PatientID = 12345678;
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.Gender = "TestGender";
            TestItem.Age = 22;
            TestItem.AddressLine = "TestAddressLine";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNo = "TestContactNo";
            //set ThisPatient to the test data
            APatient.ThisPatient = TestItem;
            //add the item 
            PrimaryKey = APatient.Add();
            //set the primary key of the test data 
            TestItem.PatientID = PrimaryKey;
            //update the test data 
            TestItem.PatientID = 12345678;
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.Gender = "TestGender";
            TestItem.Age = 22;
            TestItem.AddressLine = "TestAddressLine";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNo = "TestContactNo";
            //set the record based on the updated test data
            APatient.ThisPatient = TestItem;
            //update the record
            APatient.Update();
            //find the record
            APatient.ThisPatient.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(APatient.ThisPatient, TestItem);
        }

        [TestMethod]
        //this will be used for testing the DeleteMethod of the class
        public void DeleteMethodOK()
        {
            //new instance of Patient Collection class
            clsPatientCollection APatient = new clsPatientCollection();
            //new instance of clsPatient class to create the item of test data
            clsPatient TestItem = new clsPatient();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PatientID = 12345678;
            TestItem.FirstName = "TestFirstName";
            TestItem.LastName = "TestLastName";
            TestItem.Gender = "TestGender";
            TestItem.Age = 22;
            TestItem.AddressLine = "TestAddressLine";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ContactNo = "TestContactNo";
            //set ThisPatient to the test data
            APatient.ThisPatient = TestItem;
            //add the item 
            PrimaryKey = APatient.Add();
            //set the primary key of the test data 
            TestItem.PatientID = PrimaryKey;
            //delete the record
            APatient.Delete();
            //now find the record
            Boolean Found = APatient.ThisPatient.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
            // Check whether they match
            Assert.AreEqual(APatient.ThisPatient, TestItem);
        }
    }
}

