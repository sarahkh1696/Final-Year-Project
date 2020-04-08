using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstAdminCollection
    {
        public clsAdmin ThisAdmin { get; private set; }

        [TestMethod]
        //this will be used for testing the AdminCollection of the class
        public void InstanceOK()
        {
            //create an instance of the class
            clsAdminCollection AnAdmin = new clsAdminCollection();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(AnAdmin);
        }

        [TestMethod]
        //this will be used for testing ThisAdmin of the class
        public void ThisAdminOK()
        {
            //create an instance of the class collection
            clsAdminCollection AnAdmin = new clsAdminCollection();
            //crate an instance of an admin class to test the item of data test 
            clsAdmin TestAdmin = new clsAdmin();
            //set its properties 
            TestAdmin.AdminID = 1;
            TestAdmin.AdminName = "TestAdminName";
            //assign the test variable to be into a real one 
            AnAdmin.ThisAdmin = TestAdmin;
            //check if they are identical 
            Assert.AreEqual(AnAdmin.ThisAdmin, TestAdmin);
        }

        [TestMethod]
        //this will be used for testing ThisAdminPropertyOK of the class
        public void ThisAdminPropertyOK()
        {
            //create an instance of the class
            clsAdminCollection AnAdmin = new clsAdminCollection();
            //crate an instance of an admin class to test the item of data test 
            clsAdmin TestAdmin = new clsAdmin();
            //set its properties
            TestAdmin.AdminID = 1;
            TestAdmin.AdminName = "TestAdminName";
            //assign the test variable to be into a real one 
            AnAdmin.ThisAdmin = TestAdmin;
            //check if they are identical 
            Assert.AreEqual(AnAdmin.ThisAdmin, TestAdmin);
        }

    //    [TestMethod]
    //    //this will be used for testing the AddMehtodOK of the class
    //    public void AddMethodOK()
    //    {
    //        //create an instance of the class
    //        clsAdminCollection AnAdmin = new clsAdminCollection();
    //        //create an instance of an admin class to test the item of data test 
    //        clsAdmin TestItem = new clsAdmin();
    //        //variable to store the primary key
    //        Int32 PrimaryKey = 0;
    //        //set its properties
    //        TestItem.AdminID = 1;
    //        TestItem.AdminName = "Sam";
    //        //set ThisAdmin to the test data
    //        AnAdmin.ThisAdmin = TestItem;
    //        //add the record
    //        PrimaryKey = AnAdmin.Add();
    //        //set the primary key of the test data
    //        TestItem.AdminID = PrimaryKey;
    //        //test to see that the two values are identical 
    //        Assert.AreEqual(AnAdmin.ThisAdmin, TestItem);
    //    }

    //    [TestMethod]
    //    //this will be used for testing the DeleteMethod of the class
    //    public void DeleteMethodOK()
    //    {
    //        //create an instance of the class
    //        clsAdminCollection AnAdmin = new clsAdminCollection();
    //        //crate an instance of an admin class to test the item of data test 
    //        clsAdmin TestItem = new clsAdmin();
    //        //variable to store the primary key 
    //        Int32 PrimaryKey = 0;
    //        //set its properties
    //        TestItem.AdminID = 1;
    //        TestItem.AdminName = "Sam";
    //        //set ThisAdmin to the test data
    //        AnAdmin.ThisAdmin = TestItem;
    //        //add the item 
    //        PrimaryKey = AnAdmin.Add();
    //        //set the primary key of the test data 
    //        TestItem.AdminID = PrimaryKey;
    //        //delete the record
    //        AnAdmin.Delete();
    //        //now find the record
    //        Boolean Found = AnAdmin.ThisAdmin.Find(PrimaryKey);
    //        //test to see that the record was not found 
    //        Assert.IsFalse(Found);
    //        // Check whether they match
    //        Assert.AreEqual(AnAdmin.ThisAdmin, TestItem);
    //    }

    //    [TestMethod]
    //    //this will be used for testing the UpdateMethod of the class
    //    public void UpdateMethodOK()
    //    {
    //        //create an instance of the class
    //        clsAdminCollection AnAdmin = new clsAdminCollection();
    //        //crate an instance of an admin class to test the item of data test 
    //        clsAdmin TestItem = new clsAdmin();
    //        //variable to store the primary key 
    //        Int32 PrimaryKey = 0;
    //        //set its properties 
    //        TestItem.AdminID = 1;
    //        TestItem.AdminName = "Sam";
    //        //set ThisAdmin to the test data
    //        AnAdmin.ThisAdmin = TestItem;
    //        //add the item 
    //        PrimaryKey = AnAdmin.Add();
    //        //set the primary key of the test data 
    //        TestItem.AdminID = PrimaryKey;
    //        //edit the test data 
    //        TestItem.AdminID = 2;
    //        TestItem.AdminName = "s";
    //        //set the record based on the updated test data
    //        AnAdmin.ThisAdmin = TestItem;
    //        //update the record
    //        AnAdmin.Update();
    //        //find the record
    //        AnAdmin.ThisAdmin.Find(PrimaryKey);
    //        //test to see that the two values are the same
    //        Assert.AreEqual(AnAdmin.ThisAdmin, TestItem);
    //    }
    }

}


