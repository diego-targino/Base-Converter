using Converter.Entities;
using Converter.Entities.Dependences;
using Converter.Entities.Enums;
using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Controller controller = new Controller();
                Console.WriteLine("Please, choice a numeric base to make the operation: " +
                    "\n1 - Binary" +
                    "\n2 - Octal" +
                    "\n3 - Hexadecimal");
                BaseType baseType = Enum.Parse<BaseType>(Console.ReadLine());
                Verifications.BaseTypeVerification(baseType);

                Console.WriteLine("Please, choose a type of conversion: " +
                "\n1 - To Decimal" +
                "\n2 - From Decimal");
                ConvertionType convertion = Enum.Parse<ConvertionType>(Console.ReadLine());
                Verifications.ConvertionTypeVerification(convertion);

                Console.WriteLine("Please, insert the number to make the convertion:");
                string number = Console.ReadLine();

                Console.WriteLine(controller.ChooseConvertion(convertion, baseType, number));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
