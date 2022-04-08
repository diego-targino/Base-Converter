using Converter.Entities.Enums;

namespace Converter.Interface
{
    interface IBaseConverter
    {
        string FromDecimal(ulong decimalNumber);
        ulong ToDecimal(string baseConverter);
        string ChooseOperation(ConvertionType convertion, string number);
    }
}
