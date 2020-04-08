using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstDrugCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsDrugCollection AllDrugs = new clsDrugCollection();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(AllDrugs);
        }

        [TestMethod]
        //this will be used for testing TwoRecordsPresent of the drug class
        public void TwoRecordsPresent()
        {
            //A new instance of clsDrug class collection
            clsDrugCollection AllDrugs = new clsDrugCollection();
            //test to see if it exists or not 
            Assert.AreNotEqual(AllDrugs.Count, 0);
        }

        [TestMethod]
        //this will be used for testing ThisDrug of the class
        public void ThisDrugOK()
        {
            //create an instance of the class collection
            clsDrugCollection ADrug = new clsDrugCollection();
            //crate an instance of a drug class to test the item of data test 
            clsDrug TestDrug = new clsDrug();
            //set its properties 
            TestDrug.DrugID = 216048;
            TestDrug.DrugName = "TestDrugName";
            TestDrug.DrugType = "TestDrugType";
            TestDrug.DrugPrice = 1m;
            TestDrug.Quantity = 2;
            TestDrug.IssuedDate = DateTime.Now.Date;
            TestDrug.ExpiryDate = DateTime.Now.Date;
            //assign the test variable to be into a real one 
            ADrug.ThisDrug = TestDrug;
            //check if they are identical 
            Assert.AreEqual(ADrug.ThisDrug, TestDrug);
        }

        [TestMethod]
        //this will be used for testing ThisDrugPropertyOK of the class
        public void ThisDrugPropertyOK()
        {
            //create an instance of the class
            clsDrugCollection ADrug = new clsDrugCollection();
            //crate an instance of a drug class to test the item of data test 
            clsDrug TestDrug = new clsDrug();
            //set its properties
            TestDrug.DrugID = 1;
            TestDrug.DrugName = "TestDrugName";
            TestDrug.DrugType = "TestDrugType";
            TestDrug.DrugPrice = 1m;
            TestDrug.Quantity = 2;
            TestDrug.IssuedDate = DateTime.Now.Date;
            TestDrug.ExpiryDate = DateTime.Now.Date;
            //assign the test variable to be into a real one 
            ADrug.ThisDrug = TestDrug;
            //check if they are identical 
            Assert.AreEqual(ADrug.ThisDrug, TestDrug);
        }

        [TestMethod]
        //this will be used for testing CountOK of the class
        public void CountOK()
        {
            //new instance of clsDrugCollection class
            clsDrugCollection AllDrugs = new clsDrugCollection();
            //create a list for drug
            List<clsDrug> DrugList = new List<clsDrug>();
            //new instance of clsDrug class to create the item of test data
            clsDrug TestItem = new clsDrug();
            //set its properties
            TestItem.DrugID = 1;
            TestItem.DrugName = "TestDrugName";
            TestItem.DrugType = "TestDrugType";
            TestItem.DrugPrice = 1m;
            TestItem.IssuedDate = DateTime.Now.Date;
            TestItem.ExpiryDate = DateTime.Now.Date;
            //add the item to the test list
            DrugList.Add(TestItem);
            //assign the test variable into the real one
            AllDrugs.DrugList = DrugList;
            //check if they are identical or not 
            Assert.AreEqual(AllDrugs.Count, DrugList.Count);
        }

        [TestMethod]
        //this will be used for testing DrugListOK of the class
        public void DrugListOK()
        {
            //new instance of clsDrugCollection class
            clsDrugCollection AllDrugs = new clsDrugCollection();
            //create a list for Drug
            List<clsDrug> DrugList = new List<clsDrug>();
            //new instance of clsDrug class to create the item of test data
            clsDrug TestItem = new clsDrug();
            //set its properties
            TestItem.DrugID = 1;
            TestItem.DrugName = "TestDrugName";
            TestItem.DrugType = "TestDrugType";
            TestItem.DrugPrice = 1m;
            TestItem.IssuedDate = DateTime.Now.Date; 
            TestItem.ExpiryDate = DateTime.Now.Date;
            //add the item to the test list
            DrugList.Add(TestItem);
            //assign the test variable into the real one
            AllDrugs.DrugList = DrugList;
            //check if they are identical or not 
            Assert.AreEqual(AllDrugs.DrugList, DrugList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //new instance of clsDrugCollection class
            clsDrugCollection AllDrugs = new clsDrugCollection();
            //create a list for drug
            List<clsDrug> DrugList = new List<clsDrug>();
            //new instance of clsDrug class to create the item of test data
            clsDrug TestItem = new clsDrug();
            //set its properties
            TestItem.DrugID = 1;
            TestItem.DrugName = "TestDrugName";
            TestItem.DrugType = "TestDrugType";
            TestItem.DrugPrice = 1m;
            TestItem.IssuedDate = DateTime.Now.Date;
            TestItem.ExpiryDate = DateTime.Now.Date;
            //assign the test variable into the real one
            AllDrugs.DrugList = DrugList;
            //check if they are identical or not 
            Assert.AreEqual(AllDrugs.Count, DrugList.Count);
        }

        [TestMethod]
        //this will be used for testing the AddMehtodOK of the class
        public void AddMethodOK()
        {
            //create an instance of the class
            clsDrugCollection ADrug = new clsDrugCollection();
            //create an instance of a drug class to test the item of data test 
            clsDrug TestItem = new clsDrug();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.DrugName = "TestDrugName";
            TestItem.DrugType = "TestDrugType";
            TestItem.DrugPrice = 1;
            TestItem.IssuedDate = DateTime.Now.Date;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.Quantity = 1; 
            //set ThisDrug to the test data
            ADrug.ThisDrug = TestItem;
            //add the record
            PrimaryKey = ADrug.Add();
            //set the primary key of the test data
            TestItem.DrugID = PrimaryKey;
            //test to see that the two values are identical 
            Assert.AreEqual(ADrug.ThisDrug, TestItem);
        }

        [TestMethod]
        //this will be used for testing the UpdateMethod of the class
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsDrugCollection ADrug = new clsDrugCollection();
            //create an instance of a drug class to test the item of data test 
            clsDrug TestItem = new clsDrug();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            //TestItem.DrugID = 1;
            TestItem.DrugName = "TestDrugName";
            TestItem.DrugType = "TestDrugType";
            TestItem.DrugPrice = 1m;
            TestItem.IssuedDate = DateTime.Now.Date;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.Quantity = 1;
            //set ThisDrug to the test data
            ADrug.ThisDrug = TestItem;
            //add the item 
            PrimaryKey = ADrug.Add();
            //set the primary key of the test data 
            TestItem.DrugID = PrimaryKey;
            //update the test data 
            //TestItem.DrugID = 2;
            TestItem.DrugName = "Celestone";
            TestItem.DrugType = "Steroid";
            TestItem.DrugPrice = 15.50m;
            TestItem.IssuedDate = DateTime.Now.Date;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.Quantity = 1;
            //set the record based on the updated test data
            ADrug.ThisDrug = TestItem;
            //update the record
            ADrug.Update();
            //find the record
            ADrug.ThisDrug.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(ADrug.ThisDrug, TestItem);
        }

        [TestMethod]
        //this will be used for testing the DeleteMethod of the class
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsDrugCollection ADrug = new clsDrugCollection();
            //create an instance of a drug class to test the item of data test 
            clsDrug TestItem = new clsDrug();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            //TestItem.DrugID = 1;
            TestItem.DrugName = "Celestone";
            TestItem.DrugType = "Steroid";
            TestItem.DrugPrice = 15.50m;
            TestItem.IssuedDate = DateTime.Now.Date;
            TestItem.ExpiryDate = DateTime.Now.Date;
            TestItem.Quantity = 1;
            //set ThisDrug to the test data
            ADrug.ThisDrug = TestItem;
            //add the item 
            PrimaryKey = ADrug.Add();
            //set the primary key of the test data 
            TestItem.DrugID = PrimaryKey;
            //delete the record
            ADrug.Delete();
            //now find the record
            Boolean Found = ADrug.ThisDrug.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
            // Check whether they match
            Assert.AreEqual(ADrug.ThisDrug, TestItem);
        }
    }
}
