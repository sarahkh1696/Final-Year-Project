using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstOrderLine
    {
        //good test data 
        //set the private data member to the test data value 
        string OrderID = "1";
        string OrderLineID = "1";
        string DrugID = "1";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrderLine AnOrder = new clsOrderLine();
            //test to see if it exist
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrderLine AnOrder = new clsOrderLine();
            //create some test data to assign to the property
            Int32 OrderID = 1;
            //assign the data to the property 
            AnOrder.OrderID = OrderID;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.OrderID, OrderID);
        }

        //[TestMethod]
        //public void OrderIDMinLessOne()
        //{
        //    //create an instance of the class we want to create 
        //    clsOrderLine AnOrder = new clsOrderLine();
        //    //create a string variable to store the validation result 
        //    String Error = "";
        //    //create some test data to pass to the method 
        //    string OrderID = "0"; //this should trigger an error 
        //    //invoke the method 
        //    Error = AnOrder.Valid(OrderLineID, OrderID, DrugID);
        //    //test to see that the result is correct 
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void OrderIDMin()
        //{
        //    //create an instance of the class we want to create 
        //    clsOrderLine AnOrder = new clsOrderLine();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method 
        //    string OrderID = "1"; //this should be ok
        //    //invoke the method 
        //    Error = AnOrder.Valid(OrderLineID, OrderID, DrugID);
        //    //test to see that the result is correct 
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void OrderIDMinPlusOne()
        //{
        //    //create an instance of the class we want to create 
        //    clsOrderLine AnOrder = new clsOrderLine();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method 
        //    string OrderID = "sa"; //this should be ok
        //    //invoke the method 
        //    Error = AnOrder.Valid(OrderLineID, OrderID, DrugID);
        //    //test to see that the result is correct 
        //    Assert.AreEqual(Error, "");
        //}


        //[TestMethod]
        //public void OrderLineIDMinLessOne()
        //{
        //    //create an instance of the class we want to create 
        //    clsOrderLine AnOrder = new clsOrderLine();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method 
        //    string OrderLineID = ""; //this should trigger an error
        //    //invoke the method 
        //    Error = AnOrder.Valid(OrderLineID, OrderID, DrugID);
        //    //test to see that the result is correct 
        //    Assert.AreNotEqual(Error, "");
        //}

        //[TestMethod]
        //public void OrderLineIDMin()
        //{
        //    //create an instance of the class we want to create 
        //    clsOrderLine AnOrder = new clsOrderLine();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method 
        //    string OrderLineID = "1"; //this should be ok
        //    //invoke the method 
        //    Error = AnOrder.Valid(OrderLineID, OrderID, DrugID);
        //    //test to see that the result is correct 
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void OrderLineIDMinPlusOne()
        //{
        //    //create an instance of the class we want to create 
        //    clsOrderLine AnOrder = new clsOrderLine();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method 
        //    string OrderLineID = "1"; //this should be ok
        //    //invoke the method 
        //    Error = AnOrder.Valid(OrderLineID, OrderID, DrugID);
        //    //test to see that the result is correct 
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void OrderLineIDPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsOrderLine AnOrder = new clsOrderLine();
        //    //create some test data to assign to the property 
        //    Int32 OrderLineID = 1;
        //    //assign the data to the property 
        //    AnOrder.OrderLineID = OrderLineID;
        //    //test to see that the two values are the same 
        //    Assert.AreEqual(AnOrder.OrderLineID, OrderLineID);
        //}

        //[TestMethod]
        ////this will be used for testing the DrugIDOK of the class
        //public void DrugIDOK()
        //{
        //    //A new instance of clsDrug class
        //    clsOrderLine AnOrder = new clsOrderLine();
        //    //create a variable in order to store the drug id
        //    Int32 DrugID = 1;
        //    //assign a drug to the variable 
        //    //send some data to the drug
        //    AnOrder.DrugID = DrugID;
        //    //check to see if the data within the variable and property are identical 
        //    Assert.AreNotEqual(OrderLineID, OrderID, DrugID);
        //}

        //[TestMethod]
        ////this will be used for testing the DrugIDPropertyOK of the class
        //public void DrugIDPropertyOK()
        //{
        //    //A new instance of clsDrug class
        //    clsOrderLine AnOrder = new clsOrderLine();
        //    //create a variable in order to store the drug Id 
        //    Int32 DrugID;
        //    //assign a value to the variable to test the drug id 
        //    DrugID = 216048;
        //    AnOrder.DrugID = DrugID;
        //    //check to see if the data in the variable and the propert are identical 
        //    Assert.AreNotEqual(OrderLineID, OrderID, DrugID);
        //}

        //[TestMethod]
        ////this will be used for testing the DrugIDMinBoundary of the class
        //public void DrugIDMinBoundary()                // 8 char.
        //{
        //    //A new instance of clsDrug class
        //    clsDrug ADrug = new clsDrug();
        //    //create a variable in order to store the validation result 
        //    String Error = "";
        //    // create some test data to test the method
        //    string DrugID = "11111111";
        //    //invoke the method 
        //    Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
        //    //check to see if the result is wrong
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        ////this will be used for testing the DrugIDMinPlusOne of the class
        //public void DrugIDMinPlusOne()                 // 9 char.
        //{
        //    //A new instance of clsDrug class
        //    clsDrug ADrug = new clsDrug();
        //    //create a variable in order to store the validation result 
        //    String Error = "";
        //    //create some test data to test the method
        //    string DrugID = "111111111";
        //    //invoke the method
        //    Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
        //    //check to see if the result is wrong
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        ////this will be used for testing the DrugIDMinLessOne of the class
        //public void DrugIDMinLessOne()
        //{
        //    //A new instance of clsDrug class
        //    clsDrug ADrug = new clsDrug();
        //    //create a variable in order to store the validation result 
        //    String Error = "";
        //    //create some test data to test the method
        //    DrugID = "216048";
        //    //invoke the method 
        //    Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
        //    //check to see if the result is wrong
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        ////this will be used for testing the DrugIDMaxBoundary of the class
        //public void DrugIDMaxBoundary()                  // 50 char.
        //{
        //    //A new instance of clsDrug class
        //    clsDrug ADrug = new clsDrug();
        //    //create a variable in order to store the validation result 
        //    String Error = "";
        //    //create a test data to test the method 
        //    string DrugID = "11111111111111111111111111111111111111111111111111";
        //    //invoke the method 
        //    Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
        //    //check to see if the result is wrong
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        ////this will be used for testing the DrugIDMaxLessOne of the class
        //public void DrugIDMaxLessOne()                 // 49 char.
        //{
        //    //A new instance of clsDrug class
        //    clsDrug ADrug = new clsDrug();
        //    //create a variable in order to store the validation result 
        //    String Error = "";
        //    //create some test data to test the method 
        //    string DrugID = "1111111111111111111111111111111111111111111111111";
        //    //invoke the method 
        //    Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
        //    //check to see if the result is wrong
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        ////this will be used for testing the DrugIDMaxPlusOne of the class
        //public void DrugIDMaxPlusOne()                 // 51 char.  
        //{
        //    //A new instance of clsDrug class
        //    clsDrug ADrug = new clsDrug();
        //    //create a variable in order to store the validation result 
        //    String Error = "";
        //    //create some test data to test the method
        //    string DrugID = "11111111111111111111111111";
        //    //invoke the method
        //    Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
        //    //check to see if the result is wrong
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        ////this will be used for testing the DrugIDMid of the class
        //public void DrugIDMid()                       // 25 characters
        //{
        //    //A new instance of clsDrug class
        //    clsDrug ADrug = new clsDrug();
        //    //create a variable in order to store the validation result 
        //    String Error = "";
        //    //create some test data to test the method
        //    string DrugID = "1111111111111111111111111";
        //    //invoke the method
        //    Error = ADrug.Valid(DrugName, DrugType, DrugPrice, IssuedDate, ExpiryDate, Quantity, DrugID);
        //    //check to see if the result is wrong
        //    Assert.AreEqual(Error, "");
        //}

    }
}
