using Converter.Entities.Enums;

namespace Converter.Entities
{
    class Controller
    {
        public BinaryBase binaryBase = new BinaryBase();
        public OctalBase octalBase = new OctalBase();
        public HexadecimalBase hexadecimalBase = new HexadecimalBase();

        public string ChooseConvertion(ConvertionType convertion, BaseType baseType, string number)
        {
            switch (baseType)
            {
                case BaseType.Binary:
                    return binaryBase.ChooseOperation(convertion, number);
                case BaseType.Octal:
                    return octalBase.ChooseOperation(convertion, number);
                case BaseType.Hexadecimal:
                    return hexadecimalBase.ChooseOperation(convertion, number);
                default:
                    return "Error";
            }
        }
    }
}
