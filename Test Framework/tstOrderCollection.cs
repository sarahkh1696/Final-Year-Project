using System;
using System.Collections.Generic;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QTPharmacyBackOffice;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //a new instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that is exists 
            Assert.IsNotNull(AllOrders);
        }


        [TestMethod]
        public void OrderListOK()
        {
            //a new instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data in order to assign to the property
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list 
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.DatePlaced = DateTime.Now.Date;
            //TestItem.OrderLineID = 7;
           // TestItem.OrderID = 1;
            TestItem.ShippingAddress = "LE1 4DK"; 
            TestItem.TotalPrice = 10.00m;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        //this will be used for testing ThisOrder of the class
        public void ThisOrderOK()
        {
            //create an instance of the class collection
            clsOrderCollection AnOrder = new clsOrderCollection();
            //crate an instance of a order class to test the item of data test 
            clsOrder TestOrder = new clsOrder();
            //set its properties 
            //TestOrder.OrderID = 1;
            //TestOrder.OrderLineID = 7;
            TestOrder.PatientID = 1;
            TestOrder.TotalPrice = 10.00m;
            TestOrder.Quantity = 1;
            TestOrder.ShippingAddress = "LE1 4DK";
            TestOrder.DatePlaced = DateTime.Now.Date;
            //assign the test variable to be into a real one 
            AnOrder.ThisOrder = TestOrder;
            //check if they are identical 
            Assert.AreEqual(AnOrder.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //a new instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data in order to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object 
            TestOrder.PatientID = 1;
            TestOrder.DatePlaced = DateTime.Now.Date;
            //TestOrder.OrderLineID = 7;
           // TestOrder.OrderID = 1;
            TestOrder.ShippingAddress = "LE1 4DK";
            TestOrder.TotalPrice = 10.00m;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        //this will be used for testing CountOK of the class
        public void CountOK()
        {
            //a new instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create a list for order
            List<clsOrder> OrderList = new List<clsOrder>();
            //new instance of order class to create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            //TestItem.OrderID = 1;
            TestItem.DatePlaced = DateTime.Now.Date;
            //TestItem.OrderLineID = 7;
            TestItem.PatientID = 1;
            TestItem.ShippingAddress = "LE1 4DK";
            TestItem.TotalPrice = 10.00m;
            //add the item to the test list
            OrderList.Add(TestItem);
            //assign the test variable into the real one
            AllOrders.OrderList = OrderList;
            //check if they are identical or not 
            Assert.AreEqual(AllOrders.Count, OrderList.Count);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to creat
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data in order to assign to the property.. in this occassion the data requires to be a list of objects 
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list 
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //set its properties 
            //TestItem.PatientID = 1;
            TestItem.DatePlaced = DateTime.Now.Date;
            //TestItem.OrderLineID = 7;
            TestItem.OrderID = 1;
            TestItem.ShippingAddress = "LE1 4DK";
            TestItem.TotalPrice = 10.00m;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to creat
            clsOrderCollection AnOrder = new clsOrderCollection();
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.DatePlaced = DateTime.Now.Date;
            //TestItem.OrderLineID = 2;
            TestItem.PatientID = 1;
            TestItem.ShippingAddress = "LE1 4DK";
            TestItem.TotalPrice = 10.00m;
            //set ThisOrder to test data 
            AnOrder.ThisOrder = TestItem;
            //add the record 
            PrimaryKey = AnOrder.Add();
            //set the primary key of the test data 
            TestItem.OrderID = PrimaryKey;
            //find the record 
            AnOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the 2 values are the same 
            Assert.AreEqual(AnOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        //this will be used for testing the UpdateMethod of the class
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to creat
            clsOrderCollection AnOrder = new clsOrderCollection();
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
           // TestItem.OrderID = 1;
            TestItem.DatePlaced = DateTime.Now.Date;
            //TestItem.OrderLineID = 7;
            TestItem.PatientID = 1;
            TestItem.ShippingAddress = "LE1 4DK";
            TestItem.TotalPrice = 10.00m;
            //set ThisOrder to test data 
            AnOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AnOrder.Add();
            //set the primary key of the test data 
            TestItem.OrderID = PrimaryKey;
            //update the test data 
            //TestItem.OrderID = 1;
            TestItem.DatePlaced = DateTime.Now.Date;
            //TestItem.OrderLineID = 7;
            TestItem.PatientID = 1;
            TestItem.ShippingAddress = "LE1 4DK";
            TestItem.TotalPrice = 15.00m;
            //set the record based on the updated test data
            AnOrder.ThisOrder = TestItem;
            //update the record
            AnOrder.Update();
            //find the record
            AnOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        //this will be used for testing the DeleteMethod of the class
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to creat
            clsOrderCollection AnOrder = new clsOrderCollection();
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //TestItem.OrderID = 1;
            TestItem.DatePlaced = DateTime.Now.Date;
            //TestItem.OrderLineID = 7;
            TestItem.PatientID = 1;
            TestItem.ShippingAddress = "LE1 4DK";
            TestItem.TotalPrice = 10.00m;
            //set ThisOrder to test data 
            AnOrder.ThisOrder = TestItem;
            //add the item 
            PrimaryKey = AnOrder.Add();
            //set the primary key of the test data 
            TestItem.OrderID = PrimaryKey;
            //delete the record
            AnOrder.Delete();
            //now find the record
            Boolean Found = AnOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
            // Check whether they match
            Assert.AreEqual(AnOrder.ThisOrder, TestItem);
        }
    }
}
