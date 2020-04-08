using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QTPharmacyTestFramework
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {

            //create an instance of the class we want to create 
            clsOrderLineCollection AnOrder = new clsOrderLineCollection();
            //test to see if it exist
            Assert.IsNotNull(AnOrder);
        }
    }
}
