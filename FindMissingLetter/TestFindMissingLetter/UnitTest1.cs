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
      var emptyArray = new char[] { };

      var letter = MissingLetterFinder.FindLetter(emptyArray);

      Assert.AreEqual(letter, ' ');
    }

    [Test]
    public void Finder_WhenOneLetter_ReturnEmptyString()
    {
      var array = new char[] { 'a' };

      var letter = MissingLetterFinder.FindLetter(array);

      Assert.AreEqual(letter, ' ');
    }

    [Test]
    public void Finder_WhenTwoLettersWithoutMissingLetter_ReturnEmptychar()
    {
      char[] array = new char[] { 'a', 'b' };

      Assert.AreEqual(MissingLetterFinder.FindLetter(array), ' ');
    }

    [Test]
    public void Finder_WhenTwoLettersWithoutMissingLetterUppercase_ReturnEmptychar()
    {
      char[] arrayUppercase = new char[] { 'A', 'B' };

      Assert.AreEqual(MissingLetterFinder.FindLetter(arrayUppercase), ' ');
    }

    [Test]
    public void Finder_WhenTwoLettersWithMissingLetterB_ReturnB()
    {
      char[] array = new char[] { 'a', 'c' };

      char letter = MissingLetterFinder.FindLetter(array);

      Assert.AreEqual(letter, 'b');
    }

    [Test]
    public void Finder_WhenTwoLettersWithMissingLetterBUppercas_ReturnBUppercas()
    {
      char[] array = new char[] { 'A', 'C' };

      char letter = MissingLetterFinder.FindLetter(array);

      Assert.AreEqual(letter, 'B');
    }

    [Test]
    public void Finder_WhenTwoLettersWithMissingLetterE_ReturnE()
    {
      char[] array = new char[] { 'a', 'b', 'c', 'd', 'f' };

      char letter = MissingLetterFinder.FindLetter(array);

      Assert.AreEqual(letter, 'e');
    }
  }
}