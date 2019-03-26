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
    }
}
