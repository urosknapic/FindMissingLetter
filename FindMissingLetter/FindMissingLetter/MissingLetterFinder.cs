namespace FindMissingLetter
{
  public static class MissingLetterFinder
  {
    public static char FindLetter(char[] array)
    {
      if (array != null && array.Length > 1)
      {
        int startingValue = array[0];
        int expectedValue = 0;

        for (int i = 1; i < array.Length; i++)
        {
          expectedValue = startingValue + i;
          var nextLetterDecimal = array[i];
          if (nextLetterDecimal != expectedValue)
          {
            return (char)expectedValue;
          }
        }
      }

      return ' ';
    }
  }
}
