using Converter.Entities.Enums;
using Converter.Exeptions;
using Converter.Interface;
using System;

namespace Converter.Entities
{
    class BinaryBase : IBaseConverter
    {

        public string FromDecimal(ulong decimalNumber)
        {
            string converted = "";
            while (decimalNumber > 1)
            {
                converted = converted + $"{decimalNumber % 2}";
                decimalNumber = decimalNumber / 2;
            }
            converted = converted + $"{decimalNumber}";
            converted = Dependence.invertString(converted);

            return converted;
        }

        public ulong ToDecimal(string binary)
        {
            binary = Dependence.invertString(binary);
            int i = 0;
            ulong converted = 0;
            foreach (var character in binary)
            {
                if (character != '0' || character != '1')
                {
                    throw new DomainExepition("The number informed is not a binary number");
                }
                converted = (ulong)(converted + char.GetNumericValue(character) * Math.Pow(2, i));

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
