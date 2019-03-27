using System;
using FluentAssertions;
using Framework.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Framework.UnitTests
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod,TestCategory("StringExtension")]
        public void ExtractNumberTest()
        {
            var text = "anoopsimon90";
            text.ExtractNumbers().Should().Be(90);

            var number = "1234";
            number.ExtractNumbers().Should().Be(1234);

            var alphaNumberic = "12Makes36";
            alphaNumberic.ExtractNumbers().Should().Be(1236);
        }

        [TestMethod, TestCategory("StringExtension")]
        public void ExtractLettersTest()
        {
            var text = "anoopsimon90";
            text.ExtractLetters().Should().Be("anoopsimon");

            var number = "1234";
            number.ExtractLetters().Should().Be("");

            var alphaNumberic = "12Makes36";
            alphaNumberic.ExtractLetters().Should().Be("Makes");
        }

        [TestMethod, TestCategory("StringExtension")]
        public void ToDoubleTest()
        {
            var doubleText = "90.00";
            doubleText.ToDouble().Should().Be(90.00);

            var integerText = "1";
            integerText.ToDouble().Should().Be(1);

            
        }

        [TestMethod, TestCategory("StringExtension")]
        public void ToDateTest()
        {
            var monthDDMMYYYY = "12/03/2019";
            monthDDMMYYYY.ToDate().Day.Should().Be(12);
            monthDDMMYYYY.ToDate().Month.Should().Be(3);
            monthDDMMYYYY.ToDate().Year.Should().Be(2019);

            var yyyyMMdd = "2019/12/13";
            yyyyMMdd.ToDate().Day.Should().Be(13);
            yyyyMMdd.ToDate().Month.Should().Be(12);
            yyyyMMdd.ToDate().Year.Should().Be(2019);





        }



    }
}
