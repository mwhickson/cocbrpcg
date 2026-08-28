using cocbrpcg;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace cocbrpcg.tests;

public class DefaultHelperTest
{
    [SetUp]
    public void Setup()
    {
        // PASS:
    }

    [TestCase(-1, -1, null)]
    [TestCase(0, 0, null)]
    [TestCase(1, 1, -2)]
    [TestCase(63, 1, -2)]
    [TestCase(64, 1, -1)]
    [TestCase(83, 1, -1)]
    [TestCase(84, 1, 0)]
    [TestCase(123, 1, 0)]
    [TestCase(124, 1, 1)]
    [TestCase(163, 1, 1)]
    [TestCase(164, 1, 2)]
    [TestCase(203, 1, 2)]
    [TestCase(204, 1, null)]
    public void CalculateBuild_KnownRanges_ReturnsExpectedResult(int strength, int size, int? expectedResult)
    {
        int? result = DefaultHelper.CalculateBuild(strength, size);
        Assert.That(result, Is.EqualTo(expectedResult), $"Build with strength({strength}) and size({size}) should be: {expectedResult}");
    }


    [TestCase(-1, -1, null)]
    [TestCase(0, 0, null)]
    [TestCase(1, 1, "-2")]
    [TestCase(63, 1, "-2")]
    [TestCase(64, 1, "-1")]
    [TestCase(83, 1, "-1")]
    [TestCase(84, 1, "None")]
    [TestCase(123, 1, "None")]
    [TestCase(124, 1, "1d4")]
    [TestCase(163, 1, "1d4")]
    [TestCase(164, 1, "1d6")]
    [TestCase(203, 1, "1d6")]
    [TestCase(204, 1, null)]
    public void CalculateDamageBonus_KnownRanges_ReturnsExpectedResult(int strength, int size, string? expectedResult)
    {
        string? result = DefaultHelper.CalculateDamageBonus(strength, size);
        Assert.That(result, Is.EqualTo(expectedResult), $"Damage Bonus with strength({strength}) and size({size}) should be: '{expectedResult}'");
    }

    [TestCase(0, 0)]
    [TestCase(1, 0)]
    [TestCase(2, 1)]
    [TestCase(99, 49)]
    [TestCase(100, 50)]
    public void CalculateDefaultDodge_KnownRanges_ReturnsExpectedResult(int dexterity, int expectedResult)
    {
        int? result = DefaultHelper.CalculateDefaultDodge(dexterity);
        Assert.That(result, Is.EqualTo(expectedResult), $"Default Dodge with dexterity({dexterity}) should be: {expectedResult}");
    }

    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(33, 33)]
    [TestCase(50, 50)]
    [TestCase(99, 99)]
    [TestCase(100, 100)]
    public void CalculateDefaultLanguageOwn_KnownRanges_ReturnsExpectedResult(int education, int expectedResult)
    {
        int? result = DefaultHelper.CalculateDefaultLanguageOwn(education);
        Assert.That(result, Is.EqualTo(expectedResult), $"Default Language (Own) with education({education}) should be: {expectedResult}");
    }

    [TestCase(0, 0, 0)]
    [TestCase(8, 1, 0)]
    [TestCase(9, 1, 1)]
    [TestCase(10, 1, 1)]
    [TestCase(18, 1, 1)]
    [TestCase(19, 1, 2)]
    [TestCase(98, 1, 9)]
    [TestCase(99, 1, 10)]
    [TestCase(99, 99, 19)]
    [TestCase(100, 100, 20)]
    public void CalculateHitPoints_KnownRanges_ReturnsExpectedResult(int size, int constitution, int expectedResult)
    {
        int? result = DefaultHelper.CalculateHitPoints(size, constitution);
        Assert.That(result, Is.EqualTo(expectedResult), $"Hit Points with size({size}) and constitution({constitution}) should be: {expectedResult}");
    }

    [Test]
    public void CalculateLuck_ReturnsBetween15And90()
    {
        for (int i = 0; i < 100; i++)
        {
            int result = DefaultHelper.CalculateLuck();
            Assert.That(result, Is.GreaterThanOrEqualTo(15).And.LessThanOrEqualTo(90), $"Luck ({result}) should be between 15 and 90");
        }
    }

    [TestCase(0, 0)]
    [TestCase(1, 0)]
    [TestCase(4, 0)]
    [TestCase(5, 1)]
    [TestCase(9, 1)]
    [TestCase(10, 2)]
    [TestCase(99, 19)]
    [TestCase(100, 20)]
    public void CalculateMagicPoints_KnownRanges_ReturnsExpectedResult(int power, int expectedResult)
    {
        int? result = DefaultHelper.CalculateMagicPoints(power);
        Assert.That(result, Is.EqualTo(expectedResult), $"Magic Points with power({power}) should be: {expectedResult}");
    }

    [Test]
    public void CalculateMoveRate_ReturnsExpectedResult()
    {
        int? result = DefaultHelper.CalculateMoveRate();
        Assert.That(result, Is.EqualTo(DefaultHelper.DefaultMoveRate), $"Move Rate with should be: {DefaultHelper.DefaultMoveRate}");
    }

    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(33, 33)]
    [TestCase(50, 50)]
    [TestCase(99, 99)]
    [TestCase(100, 100)]
    public void CalculateSanityPoints_KnownRanges_ReturnsExpectedResult(int power, int expectedResult)
    {
        int? result = DefaultHelper.CalculateSanityPoints(power);
        Assert.That(result, Is.EqualTo(expectedResult), $"Sanity Points with power({power}) should be: {expectedResult}");
    }
}
