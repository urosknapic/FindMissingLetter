using FindMissingLetter;
using NUnit.Framework;

namespace TestFindMissingLetter
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void WhenEmptyArray_ReturnEmptyString()
    {
      string[] emptyArray = new string[] { };

      string letter = MissingLetterFinder.FindLetter(emptyArray);

      Assert.AreEqual(letter, "");
    }
  }
}