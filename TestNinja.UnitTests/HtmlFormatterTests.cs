using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var vormatter = new HtmlFormatter();
            var result = vormatter.FormatAsBold("abc");

            //Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //More generale
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc").IgnoreCase);
        }
    }
}
