using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstPharmacyCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsPharmacyCollection APharmacy = new clsPharmacyCollection();
            //check that the class is exists as well as it is not NULL 
            Assert.IsNotNull(APharmacy);
        }

        [TestMethod]
        //this will be used for testing ThisPharmacy of the class
        public void ThisPharmacyOK()
        {
            //create an instance of the class collection
            clsPharmacyCollection APharmacy = new clsPharmacyCollection();
            //crate an instance of a Pharmacy class to test the item of data test 
            clsPharmacy TestPharmacy = new clsPharmacy();
            //set its properties 
            TestPharmacy.PharmacyID = 1;
            TestPharmacy.PharmacyName = "TestPharmacyName";
            //assign the test variable to be into a real one 
            APharmacy.ThisPharmacy = TestPharmacy;
            //check if they are identical 
            Assert.AreEqual(APharmacy.ThisPharmacy, TestPharmacy);
        }

        [TestMethod]
        //this will be used for testing ThisPharmacyPropertyOK of the class
        public void ThisPharmacyPropertyOK()
        {
            //create an instance of the class
            clsPharmacyCollection APharmacy = new clsPharmacyCollection();
            //crate an instance of an pharmacy class to test the item of data test 
            clsPharmacy TestPharmacy = new clsPharmacy();
            //set its properties
            TestPharmacy.PharmacyID = 1;
            TestPharmacy.PharmacyName = "TestPharmacyName";
            //assign the test variable to be into a real one 
            APharmacy.ThisPharmacy = TestPharmacy;
            //check if they are identical 
            Assert.AreEqual(APharmacy.ThisPharmacy, TestPharmacy);
        }

    }
}
