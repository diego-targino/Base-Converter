using Converter.Entities.Enums;
using Converter.Exeptions;
using Converter.Interface;
using System;

namespace Converter.Entities
{
    class HexadecimalBase : IBaseConverter
    {

        public string FromDecimal(ulong decimalNumber)
        {
            string converted = "";
            while (decimalNumber > 15)
            {
                converted = converted + $"{Dependence.isNumberOrLetter((int)decimalNumber % 16)}";
                decimalNumber = decimalNumber / 16;
            }
            converted = converted + $"{Dependence.isNumberOrLetter((int)decimalNumber)}";
            converted = Dependence.invertString(converted);

            return converted;
        }

        public ulong ToDecimal(string hexadecimal)
        {
            hexadecimal = hexadecimal.ToUpper();
            hexadecimal = Dependence.invertString(hexadecimal);
            int i = 0;
            ulong converted = 0;
            foreach (var character in hexadecimal)
            {
                if (char.IsNumber(character))
                {
                    converted = (ulong)(converted + char.GetNumericValue(character) * Math.Pow(16, i));
                }
                else
                {
                    string aux = character.ToString();
                    converted = (ulong)(converted + Dependence.LetterToNumber(character) * Math.Pow(16, i));
                }
                i++;
            }
            return converted;
        }
        public string ChooseOperation(ConvertionType convertion, string number)
        {
            ulong ulongNumber;
            bool isUlong = ulong.TryParse(number, out ulongNumber);

            switch (convertion)
            {
                case ConvertionType.ToDecimal:
                    return $"{ToDecimal(number)}";
                case ConvertionType.FromDecimal:
                    if (!isUlong)
                    {
                        throw new DomainExepition("Invalid value informed");
                    }
                    return $"{FromDecimal(ulongNumber)}";
                default:
                    return "Error";
            }
        }
    }
}
