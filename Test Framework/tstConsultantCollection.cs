using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstConsultantCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            //check to see that the class is not null and that it exists
            Assert.IsNotNull(AllConsultants);
        }

        [TestMethod]
        //this will be used for testing TwoRecordsPresent of the consultant class
        public void TwoRecordsPresent()
        {
            //create an instance of the class collection
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            //test to see if it exists or not 
            Assert.AreNotEqual(AllConsultants.Count, 2);
        }

        [TestMethod]
        //this will be used for testing ThisConsultant of the class
        public void ThisConsultantOK()
        {
            //create an instance of the class collection
            clsConsultantCollection AConsultant = new clsConsultantCollection();
            //crate an instance of a Consultant class to test the item of data test 
            clsConsultant TestConsultant = new clsConsultant();
            //set its properties 
            TestConsultant.ConsultantID = 1;
            TestConsultant.ConsultantName = "TestConsultantName";
            TestConsultant.ConsultantSpecialist = "TestConsultantSpecialist";
            TestConsultant.ConsultantComment = "TestConsultantComment";
            TestConsultant.DateAdded = DateTime.Now.Date;
            TestConsultant.DrugType = "somedrug";
            //assign the test variable to be into a real one 
            AConsultant.ThisConsultant = TestConsultant;
            //check if they are identical 
            Assert.AreEqual(AConsultant.ThisConsultant, TestConsultant);
        }

        [TestMethod]
        //this will be used for testing ThisConsultantPropertyOK of the class
        public void ThisConsultantPropertyOK()
        {
            //create an instance of the class
            clsConsultantCollection AConsultant = new clsConsultantCollection();
            //crate an instance of a Consultant class to test the item of data test 
            clsConsultant TestConsultant = new clsConsultant();
            //set its properties
            TestConsultant.ConsultantID = 1;
            TestConsultant.ConsultantName = "TestConsultantName";
            TestConsultant.ConsultantSpecialist = "TestConsultantSpecialist";
            TestConsultant.ConsultantComment = "TestConsultantComment";
            TestConsultant.DrugType = "somedrug";
            TestConsultant.DateAdded = DateTime.Now.Date;
            //assign the test variable to be into a real one 
            AConsultant.ThisConsultant = TestConsultant;
            //check if they are identical 
            Assert.AreEqual(AConsultant.ThisConsultant, TestConsultant);
        }

        [TestMethod]
        //this will be used for testing CountOK of the class
        public void CountOK()
        {
            //new instance of clsConsultantCollection class
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            //create a list for consultant
            List<clsConsultant> ConsultantList = new List<clsConsultant>();
            //new instance of clsConsultant class to create the item of test data
            clsConsultant TestItem = new clsConsultant();
            //set its properties
            TestItem.ConsultantID = 1;
            TestItem.ConsultantName = "TestConsultantName";
            TestItem.ConsultantSpecialist = "TestConsultantSpecialist";
            TestItem.ConsultantComment = "TestConsultantComment";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.DrugType = "somedrug";
            //add the item to the test list
            ConsultantList.Add(TestItem);
            //assign the test variable into the real one
            AllConsultants.ConsultantList = ConsultantList;
            //check if they are identical or not 
            Assert.AreEqual(AllConsultants.Count, ConsultantList.Count);
        }

        [TestMethod]
        //this will be used for testing ConsultantListOK of the class
        public void ConsultantListOK()
        {
            //new instance of clsConsultantCollection class
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            //create a list for consultant
            List<clsConsultant> ConsultantList = new List<clsConsultant>();
            //new instance of clsConsultant class to create the item of test data
            clsConsultant TestItem = new clsConsultant();
            //set its properties
            TestItem.ConsultantID = 1;
            TestItem.ConsultantName = "TestConsultantName";
            TestItem.ConsultantSpecialist = "TestConsultantSpecialist";
            TestItem.ConsultantComment = "TestConsultantComment";
            TestItem.DateAdded = DateTime.Now.Date; 
            TestItem.DrugType = "somedrug";
            //add the item to the test list
            ConsultantList.Add(TestItem);
            //assign the test variable into the real one
            AllConsultants.ConsultantList = ConsultantList;
            //check if they are identical or not 
            Assert.AreEqual(AllConsultants.ConsultantList, ConsultantList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //new instance of clsConsultantCollection class
            clsConsultantCollection AllConsultants = new clsConsultantCollection();
            //create a list for consultant
            List<clsConsultant> ConsultantList = new List<clsConsultant>();
            //new instance of clsConsultant class to create the item of test data
            clsConsultant TestItem = new clsConsultant();
            //set its properties
            TestItem.ConsultantID = 1;
            TestItem.ConsultantName = "TestConsultantName";
            TestItem.ConsultantSpecialist = "TestConsultantSpecialist";
            TestItem.ConsultantComment = "TestConsultantComment";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.DrugType = "some drug";
            //assign the test variable into the real one
            AllConsultants.ConsultantList = ConsultantList;
            //check if they are identical or not 
            Assert.AreEqual(AllConsultants.Count, ConsultantList.Count);
        }

        [TestMethod]
        //this will be used for testing the AddMehtodOK of the class
        public void AddMethodOK()
        {
            //create an instance of the class
            clsConsultantCollection AConsultant = new clsConsultantCollection();
            //create an instance of a Consultant class to test the item of data test 
            clsConsultant TestItem = new clsConsultant();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ConsultantID = 1;
            TestItem.ConsultantName = "Gill";
            TestItem.ConsultantSpecialist = "TestConsultantSpecialist";
            TestItem.ConsultantComment = "TestConsultantComment";
            TestItem.DrugType = "SomeDrug";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisConsultant to the test data
            AConsultant.ThisConsultant = TestItem;
            //add the record
            PrimaryKey = AConsultant.Add();
            //set the primary key of the test data
            TestItem.ConsultantID = PrimaryKey;
            //test to see that the two values are identical 
            Assert.AreEqual(AConsultant.ThisConsultant, TestItem);
        }

        
        [TestMethod]
        //this will be used for testing the UpdateMethod of the class
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsConsultantCollection AConsultant = new clsConsultantCollection();
            //crate an instance of a Consultant class to test the item of data test 
            clsConsultant TestItem = new clsConsultant();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.ConsultantID = 1;
            TestItem.ConsultantName = "Gill";
            TestItem.ConsultantSpecialist = "TestConsultantSpecialist";
            TestItem.ConsultantComment = "TestConsultantComment";
            TestItem.DrugType = "somedrug";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisConsultant to the test data
            AConsultant.ThisConsultant = TestItem;
            //add the item 
            PrimaryKey = AConsultant.Add();
            //find the consultant
            AConsultant.ThisConsultant.Find(PrimaryKey);
            //set the primary key of the test data 
            TestItem.ConsultantID = PrimaryKey;
            //edit the test data 
            TestItem.ConsultantID = 2;
            TestItem.ConsultantName = "g";
            TestItem.ConsultantSpecialist = "Dentist";
            TestItem.ConsultantComment = "Add some comment here";
            TestItem.DrugType = "somedrug";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the updated test data
            AConsultant.ThisConsultant = TestItem;
            //update the record
            AConsultant.Update();
            //find the record
            AConsultant.ThisConsultant.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AConsultant.ThisConsultant, TestItem);
        }
    }
}
