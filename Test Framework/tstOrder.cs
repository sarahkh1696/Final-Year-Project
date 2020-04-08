using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstOrder
    {
        //good test data 
        //set the private data member to the test data value 
        string OrderID = "1";
        string OrderLineID = "7";
        string PatientID = "1";
        string DatePlaced = Convert.ToString(DateTime.Now.Date);
        string Quantity = "1";
        string ShippingAddress = "LE1 4DK";
        string TotalPrice = Convert.ToString("10.00");

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //test to see if it exist
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 OrderID = 7;
            //assign the data to the property 
            AnOrder.OrderID = OrderID;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.OrderID, OrderID);
        }

        [TestMethod]
        public void PatientIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder APatient = new clsOrder();
            //create some test data to assign to the property
            Int32 PatientID = 1;
            //assign the data to the property 
            APatient.PatientID = PatientID;
            //test to see that the two values are the same 
            Assert.AreEqual(APatient.PatientID, PatientID);
        }

        [TestMethod]
        public void OrderLineIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property 
            Int32 OrderLineID = 7;
            //assign the data to the property 
            AnOrder.OrderLineID = OrderLineID;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.OrderLineID, OrderLineID);
        }

        [TestMethod]
        public void DatePlacedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnOrder.DatePlaced = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.DatePlaced, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 Quantity = 7;
            //assign the data to the property 
            AnOrder.Quantity = Quantity;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.Quantity, Quantity);
        }

        [TestMethod]
        public void ShippingAddressPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string ShippingAddress = "1";
            //assign the data to the property 
            AnOrder.ShippingAddress = ShippingAddress;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.ShippingAddress, ShippingAddress);
        }

        [TestMethod]
        public void ShippingAddressExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data assign to the property
            String Error = "";
            //create some test data to test the method
            string ShippingAddress = "";
            //pad the string with characters
            ShippingAddress = ShippingAddress.PadRight(500, 'a');
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is wrong 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxBoundry()                      //50 char
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data assign to the property
            String Error = "12werrggyyjiddfgghjkkkklllssssddddfffgghjkloiuytre";
            //create some test data to test the method
            string ShippingAddress = "";
            //invoke the method
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxLessOneBoundry()                      //49 char
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data assign to the property
            String Error = "12werrggyyjiddfgghjkkkklllssssddddfffgghjkloiuytr";
            //create some test data to test the method
            string ShippingAddress = "";
            //invoke the method
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxPlusOneBoundry()                      //51 char
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data assign to the property
            String Error = "12werrggyyjiddfgghjkkkklllssssddddfffgghjkloiuytrew";
            //create some test data to test the method
            string ShippingAddress = "";
            //invoke the method
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMidBoundry()                      //25 char
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data assign to the property
            String Error = "12werrggyyjiddfgghjkkkkll";
            //create some test data to test the method
            string ShippingAddress = "";
            //invoke the method
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinBoundry()                      //8 char
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data assign to the property
            String Error = "12werrgg";
            //create some test data to test the method
            string ShippingAddress = "";
            //invoke the method
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinLessOneBoundry()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data assign to the property
            String Error = "3 Belgrave Road";
            //create some test data to test the method
            string ShippingAddress = "";
            //invoke the method
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinPlusOneBoundry()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create some test data assign to the property
            String Error = "3 Belgrave Road";
            //create some test data to test the method
            string ShippingAddress = "";
            //invoke the method
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is wrong
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPricePropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder APrice = new clsOrder();
            //create some test data to assign to the property 
            decimal TotalPrice = 1m;
            //assign the data to the property
            APrice.TotalPrice = TotalPrice;
            //test to see that the two values are the same 
            Assert.AreEqual(APrice.TotalPrice, TotalPrice);
        }

        [TestMethod]
        public void ValidationMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //int variable to store any error message 
            string Error = "";
            //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //create a string variable to store the validation result 
            String Error = "";
            //create some test data to pass to the method 
            string OrderID = "0"; //this should trigger an error 
                                  //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string OrderID = "1"; //this should be ok
                                  //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string OrderID = "sa"; //this should be ok
                                   //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderLineIDMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string OrderLineID = ""; //this should trigger an error
                                     //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderLineIDMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string OrderLineID = "7"; //this should be ok
                                      //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderLineIDMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string OrderLineID = "10"; //this should be ok
                                       //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePlacedExtremeMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 200 years 
            TestDate = TestDate.AddYears(-200);
            //convert the date variable to a string variable 
            string DatePlaced = TestDate.ToString();
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePlacedMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less than 1 day 
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string DatePlaced = TestDate.ToString();
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePlacedMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DatePlaced = TestDate.ToString();
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePlacedMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date plus 1 day 
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            string DatePlaced = TestDate.ToString();
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePlacedExtremeMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date to today's date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 200 years 
            TestDate = TestDate.AddYears(50);
            //convert the date variable to a string variable 
            string DatePlaced = TestDate.ToString();
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePlacedInvalidData()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the date to a non date value 
            string DatePlaced = "this is not a date!!";
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail 
            string Quantity = "";
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "7";
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "7";
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "7";
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "7";
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "111111111";
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "7";
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail 
            string TotalPrice = "-0.01";
            //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMin()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string TotalPrice = "0.00";
            //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string TotalPrice = "21.00";
            //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string TotalPrice = "49.99";
            //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMax()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string TotalPrice = "50.00";
            //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string TotalPrice = "51.00";

            //invoke the method 
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalPriceMid()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string TotalPrice = "20.0";
            //invoke the method  
            Error = AnOrder.Valid(OrderLineID, PatientID, DatePlaced, ShippingAddress, Quantity, TotalPrice, OrderID);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

    }
}    

