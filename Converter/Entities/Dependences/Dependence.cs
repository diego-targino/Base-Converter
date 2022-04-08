using Converter.Exeptions;
using System;

namespace Converter.Entities
{
    static class Dependence
    {
        public static string isNumberOrLetter(int number)
        {
            if (number <= 9)
            {
                return $"{number}";
            }
            else
            {
                int rest = (int)number % 16;
                string letter = char.ConvertFromUtf32(number + 55);
                return $"{letter}";
            }
        }

        public static string invertString(string converted)
        {
            char[] arr = converted.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static int LetterToNumber(char character)
        {
            string aux = character.ToString();
            int number = char.ConvertToUtf32(aux, 0);
            if (number > 70 || number < 65)
            {
                throw new DomainExepition("The number informed is not a hexadecimal number");
            }
            return number - 55;

        }
    }
}
