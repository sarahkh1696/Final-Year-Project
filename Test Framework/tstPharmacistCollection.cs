using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstPharmacistCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsPharmacistCollection APharmacist = new clsPharmacistCollection();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(APharmacist);
        }

        [TestMethod]
        //this will be used for testing ThisPharmacist of the class
        public void ThisPharmacistOK()
        {
            //create an instance of the class collection
            clsPharmacistCollection APharmacist = new clsPharmacistCollection();
            //crate an instance of a Pharmacist class to test the item of data test 
            clsPharmacist TestPharmacist = new clsPharmacist();
            //set its properties 
            TestPharmacist.PharmacistID = 1;
            TestPharmacist.PharmacistName = "TestPharmacistName";
            //assign the test variable to be into a real one 
            APharmacist.ThisPharmacist = TestPharmacist;
            //check if they are identical 
            Assert.AreEqual(APharmacist.ThisPharmacist, TestPharmacist);
        }

        [TestMethod]
        //this will be used for testing ThisPharmacistPropertyOK of the class
        public void ThisPharmacistPropertyOK()
        {
            //create an instance of the class
            clsPharmacistCollection APharmacist = new clsPharmacistCollection();
            //crate an instance of an pharmacist class to test the item of data test 
            clsPharmacist TestPharmacist = new clsPharmacist();
            //set its properties
            TestPharmacist.PharmacistID = 1;
            TestPharmacist.PharmacistName = "TestPharmacistName";
            //assign the test variable to be into a real one 
            APharmacist.ThisPharmacist = TestPharmacist;
            //check if they are identical 
            Assert.AreEqual(APharmacist.ThisPharmacist, TestPharmacist);
        }

        [TestMethod]
        //this will be used for testing the AddMehtodOK of the class
        public void AddMethodOK()
        {
            //create an instance of the class
            clsPharmacistCollection APharmacist = new clsPharmacistCollection();
            //create an instance of an pharmacist class to test the item of data test 
            clsPharmacist TestItem = new clsPharmacist();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PharmacistID = 1;
            TestItem.PharmacistName = "Claire";
            TestItem.ContactNo = "TestContactNo";
            //set ThisPharmacist to the test data
            APharmacist.ThisPharmacist = TestItem;
            //add the record
            PrimaryKey = APharmacist.Add();
            //set the primary key of the test data
            TestItem.PharmacistID = PrimaryKey;
            //test to see that the two values are identical 
            Assert.AreEqual(APharmacist.ThisPharmacist, TestItem);
        }

        [TestMethod]
        //this will be used for testing the DeleteMethod of the class
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsPharmacistCollection APharmacist = new clsPharmacistCollection();
            //crate an instance of an pharmacist class to test the item of data test 
            clsPharmacist TestItem = new clsPharmacist();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PharmacistID = 1;
            TestItem.PharmacistName = "Claire";
            TestItem.ContactNo = "TestContactNo";
            //set ThisPharmacist to the test data
            APharmacist.ThisPharmacist = TestItem;
            //add the item 
            PrimaryKey = APharmacist.Add();
            //set the primary key of the test data 
            TestItem.PharmacistID = PrimaryKey;
            //delete the record
            APharmacist.Delete();
            //now find the record
            Boolean Found = APharmacist.ThisPharmacist.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
            // Check whether they match
            Assert.AreEqual(APharmacist.ThisPharmacist, TestItem);
        }

        [TestMethod]
        //this will be used for testing the UpdateMethod of the class
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsPharmacistCollection APharmacist = new clsPharmacistCollection();
            //crate an instance of a pharmacist class to test the item of data test 
            clsPharmacist TestItem = new clsPharmacist();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.PharmacistID = 1;
            TestItem.PharmacistName = "Claire";
            TestItem.ContactNo = "TestContactNo";
            //set ThisPharmacist to the test data
            APharmacist.ThisPharmacist = TestItem;
            //add the item 
            PrimaryKey = APharmacist.Add();
            //find the pharmacist
            APharmacist.ThisPharmacist.Find(PrimaryKey);
            //set the primary key of the test data 
            TestItem.PharmacistID = PrimaryKey;
            //edit the test data 
            TestItem.PharmacistID = 2;
            TestItem.PharmacistName = "s";
            TestItem.ContactNo = "TestContactNo";
            //set the record based on the updated test data
            APharmacist.ThisPharmacist = TestItem;
            //update the record
            APharmacist.Update();
            //find the record
            APharmacist.ThisPharmacist.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(APharmacist.ThisPharmacist, TestItem);
        }
    }
}

