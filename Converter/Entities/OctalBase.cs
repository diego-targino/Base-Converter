using Converter.Entities.Enums;
using Converter.Exeptions;
using Converter.Interface;
using System;

namespace Converter.Entities
{
    class OctalBase : IBaseConverter
    {

        public string FromDecimal(ulong decimalNumber)
        {
            string converted = "";
            while (decimalNumber > 7)
            {
                converted = converted + $"{decimalNumber % 8}";
                decimalNumber = decimalNumber / 8;
            }
            converted = converted + $"{decimalNumber}";
            converted = Dependence.invertString(converted);

            return converted;
        }

        public ulong ToDecimal(string octal)
        {
            octal = Dependence.invertString(octal);
            int i = 0;
            ulong converted = 0;
            foreach (var character in octal)
            {
                if (character == '8' || character == '9')
                {
                    throw new DomainExepition("The number informed is not a octal number");
                }
                converted = (ulong)(converted + char.GetNumericValue(character) * Math.Pow(8, i));

                i++;
            }

            return converted;
        }
        public string ChooseOperation(ConvertionType convertion, string number)
        {
            ulong ulongNumber = ulong.Parse(number);
            switch (convertion)
            {
                case ConvertionType.ToDecimal:
                    return $"{ToDecimal(number)}";
                case ConvertionType.FromDecimal:
                    return $"{FromDecimal(ulongNumber)}";
                default:
                    return "Error";
            }
        }
    }
}
