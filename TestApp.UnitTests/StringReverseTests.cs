using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string actualResult = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actualResult);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "V";

        // Act
        string actualResult = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(1, actualResult.Length);
        Assert.AreEqual("V", actualResult);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "ABC";

        // Act
        string actualResult = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(input.Length, actualResult.Length);
        Assert.AreEqual("CBA", actualResult);
    }
}
