using Converter.Entities.Enums;
using Converter.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Entities.Dependences
{
    static class Verifications
    {
        public static void BaseTypeVerification(BaseType baseType)
        {
            int baseTypeLengh = Enum.GetNames(typeof(BaseType)).Length;
            if (((int)baseType) > baseTypeLengh || ((int)baseType) < 1)
            {
                throw new DomainExepition("Base type invalid");
            }
        }
        public static void ConvertionTypeVerification(ConvertionType baseType)
        {
            int baseTypeLengh = Enum.GetNames(typeof(ConvertionType)).Length;
            if (((int)baseType) > baseTypeLengh || ((int)baseType) < 1)
            {
                throw new DomainExepition("Convertion type invalid");
            }
        }

    }
}
