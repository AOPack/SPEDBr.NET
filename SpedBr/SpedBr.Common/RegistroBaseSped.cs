
namespace SpedBr.Common
{
    public class RegistroBaseSped
    {
        [SpedCampos(1, "REG", "C", 4, 0, true)]
        public string REG { get; set; }

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }
}
