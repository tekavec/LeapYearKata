using NUnit.Framework;

namespace LeapYear.Tests
{
    [TestFixture]
    public class YearShould
    {
        [Test] public void BeALeapYearIfItIsDivisibleBy4()
        {
            var year = new Year(2016);

            Assert.That(year.IsLeap(), Is.True);
        }

        [Test]
        public void NotBeALeapYearIfItIsNotDivisibleBy4()
        {
            var year = new Year(2015);

            Assert.That(year.IsLeap(), Is.False);
        }

        [Test]
        public void BeALeapYearIfItIsDivisibleBy400()
        {
            var year = new Year(4000);

            Assert.That(year.IsLeap(), Is.True);
        }

        [Test]
        public void NotBeALeapYearIfItIsDivisibleBy100AndNotDivisibleBy400()
        {
            var year = new Year(4100);

            Assert.That(year.IsLeap(), Is.False);
        }

    }
}
