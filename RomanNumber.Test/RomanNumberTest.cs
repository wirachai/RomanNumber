﻿using NUnit.Framework;

namespace RomanNumber.Test
{
    [TestFixture]
    internal class RomanNumberTest
    {
        private RomanNumber romanNumber = new RomanNumber();

        [Test]
        public void ToRomanNumber_ShouldBeI_WhenInput1()
        {
            Assert.AreEqual("I", romanNumber.ToRomanNumber(1));
        }

        [Test]
        public void ToRomanNumber_ShouldBeII_WhenInput2()
        {
            Assert.AreEqual("II", romanNumber.ToRomanNumber(2));
        }

        [Test]
        public void ToRomanNumber_ShouldBeIII_WhenInput3()
        {
            Assert.AreEqual("III", romanNumber.ToRomanNumber(3));
        }

        [Test]
        public void ToRomanNumber_ShouldBeIV_WhenInput4()
        {
            Assert.AreEqual("IV", romanNumber.ToRomanNumber(4));
        }

        [Test]
        public void ToRomanNumber_ShouldBeV_WhenInput5()
        {
            Assert.AreEqual("V", romanNumber.ToRomanNumber(5));
        }

        [Test]
        public void ToRomanNumber_ShouldBeVI_WhenInput6()
        {
            Assert.AreEqual("VI", romanNumber.ToRomanNumber(6));
        }

        [Test]
        public void ToRomanNumber_ShouldBeIX_WhenInput9()
        {
            Assert.AreEqual("IX", romanNumber.ToRomanNumber(9));
        }

        [Test]
        public void ToRomanNumber_ShouldBeX_WhenInput10()
        {
            Assert.AreEqual("X", romanNumber.ToRomanNumber(10));
        }

        [Test]
        public void ToRomanNumber_ShouldBeXI_WhenInput11()
        {
            Assert.AreEqual("XI", romanNumber.ToRomanNumber(11));
        }

        [Test]
        public void ToRomanNumber_ShouldBeXLVII_WhenInput47()
        {
            Assert.AreEqual("XLVII", romanNumber.ToRomanNumber(47));
        }

        [Test]
        public void ToRomanNumber_ShouldBeLXXX_WhenInput80()
        {
            Assert.AreEqual("LXXX", romanNumber.ToRomanNumber(80));
        }

        [Test]
        public void ToRomanNumber_ShouldBeXCIX_WhenInput99()
        {
            Assert.AreEqual("XCIX", romanNumber.ToRomanNumber(99));
        }

        [Test]
        public void ToRomanNumber_ShouldBeCCCXXI_WhenInput321()
        {
            Assert.AreEqual("CCCXXI", romanNumber.ToRomanNumber(321));
        }

        [Test]
        public void ToRomanNumber_ShouldBeDCCC_WhenInput800()
        {
            Assert.AreEqual("DCCC", romanNumber.ToRomanNumber(800));
        }

        [Test]
        public void ToRomanNumber_ShouldBeMDC_WhenInput1600()
        {
            Assert.AreEqual("MDC", romanNumber.ToRomanNumber(1600));
        }

        [Test]
        public void ToRomanNumber_ShouldBeMCMXC_WhenInput1990()
        {
            Assert.AreEqual("MCMXC", romanNumber.ToRomanNumber(1990));
        }

        [Test]
        public void ToRomanNumber_ShouldBeMMVIII_WhenInput2008()
        {
            Assert.AreEqual("MMVIII", romanNumber.ToRomanNumber(2008));
        }

        [Test]
        public void ToRomanNumber_ShouldBeMMMM_WhenInput4000()
        {
            Assert.AreEqual("MMMM", romanNumber.ToRomanNumber(4000));
        }
    }
}