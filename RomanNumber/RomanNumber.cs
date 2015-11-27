namespace RomanNumber
{
    public class RomanNumber
    {
        public string ToRomanNumber(int number)
        {
            string[] romanChars = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] romanValues = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string result = string.Empty;
            for (int i = 0; i < romanValues.Length; i++)
            {
                while (number >= romanValues[i])
                {
                    result += romanChars[i];
                    number -= romanValues[i];
                }
            }
            return result;
        }
    }
}