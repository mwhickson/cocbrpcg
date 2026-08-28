using cocbrpcg.Entities;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace cocbrpcg.tests;

public class SkillValueTest
{
    [SetUp]
    public void Setup()
    {
        // PASS:
    }

    [TestCase(0, 0, 0)]
    [TestCase(1, 0, 0)]
    [TestCase(10, 5, 2)]
    [TestCase(33, 16, 6)]
    [TestCase(50, 25, 10)]
    [TestCase(99, 49, 19)]
    [TestCase(100, 50, 20)]
    public void SkillValue_Value_ReturnsExpectedResults(int suppliedValue, int expectedHalf, int expectedFifth)
    {
        Skill skill = new("dummy");
        SkillValue v = new(skill, suppliedValue);
        int half = v.Half;
        int fifth = v.Fifth;

        Assert.Multiple(() =>
        {
            Assert.That(half, Is.EqualTo(expectedHalf), $"Value of({v}) should have a half of: {expectedHalf}");
            Assert.That(fifth, Is.EqualTo(expectedFifth), $"Value of({v}) should have a fifth of: {expectedFifth}");
        });
    }
}
