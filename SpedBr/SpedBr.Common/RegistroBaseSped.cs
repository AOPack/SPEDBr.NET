namespace SpedBr.Common
{
    public class RegistroBaseSped
    {
        [SpedCampos(1, "REG", "C", 4, 0, true)]
        public string Reg { get; set; }

        public static object GetPropValue(object src, string propName, bool isLiteralEnum)
        {
            var isEnum = src.GetType().GetProperty(propName).PropertyType.IsEnum;
            var valueToReturn = src.GetType().GetProperty(propName).GetValue(src, null);

            if (isEnum)
            {
                if (isLiteralEnum)
                    return valueToReturn;

                return (int) valueToReturn;
            }

            return valueToReturn;
        }
    }
}