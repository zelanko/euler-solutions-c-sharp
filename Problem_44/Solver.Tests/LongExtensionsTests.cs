namespace Solver.Tests;

[TestFixture]
public class LongExtensionsTests
{
    [SetUp]
    public void Setup()
    {
    }    

    [TestCase(1,1)]
    [TestCase(2,5)]
    [TestCase(3,12)]
    [TestCase(4,22)]
    [TestCase(5,35)]
    [TestCase(6,51)]
    [TestCase(7,70)]
    [TestCase(8,92)]
    [TestCase(9,117)]
    [TestCase(10,145)]
    public void ShouldBePentagonal(long number, long expected)
    {
        Assert.That(number > 0, Is.True);
        Assert.That(number.ToPentagonal(), Is.EqualTo(expected));
    }
}