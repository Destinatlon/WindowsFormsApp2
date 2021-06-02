using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System;
using WindowsFormsApp2;
using static WindowsFormsApp2.Form1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCurillic()
        {
            Assert.IsTrue(Validation.IsCurillic("авлрптывлос"));
            Assert.IsFalse(Validation.IsCurillic("авлрптывлос1232314"));
        }
        [TestMethod]
        public void TestPhone()
        {
            Assert.IsTrue(Validation.IsPhoneNumber("+380989066664"));
            Assert.IsFalse(Validation.IsPhoneNumber("+3809890666644"));
            Assert.IsFalse(Validation.IsPhoneNumber("0989066664"));
            Assert.IsFalse(Validation.IsPhoneNumber("89066664fk"));
        }
        [TestMethod]
        public void TestMail()
        {
            Assert.IsTrue(Validation.IsValidMail("devilmaycry@gmail.com"));
            Assert.IsTrue(Validation.IsValidMail("jeka@mail.ru"));
            Assert.IsFalse(Validation.IsValidMail("devilmaycrygmail.com"));
            Assert.IsFalse(Validation.IsValidMail("evilmaycryailru"));
        }
        [TestMethod]
        public void TestRegTax()
        {
            Assert.IsTrue(Validation.IsTaxRegNumber("1234567890",10));
            Assert.IsTrue(Validation.IsTaxRegNumber("123456789010",12));
            Assert.IsFalse(Validation.IsTaxRegNumber("qwertyuiop",10));
            Assert.IsFalse(Validation.IsTaxRegNumber("1q2w3e4r5t",10));
            Assert.IsFalse(Validation.IsTaxRegNumber("123456",5));
            Assert.IsFalse(Validation.IsTaxRegNumber("1234567",25));
        }
        [TestMethod]
        public void TestVat()
        {
            Assert.IsTrue(Validation.IsVatNumber("ua1234567890"));
            Assert.IsTrue(Validation.IsVatNumber("UA1234567890"));
            Assert.IsFalse(Validation.IsVatNumber("ua12345678901012"));
            Assert.IsFalse(Validation.IsVatNumber("1234567890as"));
        }
        [TestMethod]
        public void TestStreetNumber()
        {
            Assert.IsTrue(Validation.IsStreetNumber("79/1"));
            Assert.IsTrue(Validation.IsStreetNumber("791"));
            Assert.IsTrue(Validation.IsStreetNumber("79-1"));
            Assert.IsTrue(Validation.IsStreetNumber("79a"));
            Assert.IsFalse(Validation.IsStreetNumber("dkghb"));
            Assert.IsFalse(Validation.IsStreetNumber("79."));
            Assert.IsFalse(Validation.IsStreetNumber("50*-"));
        }

    }
}
