using System;
using System.Linq;
using System.Text;

namespace SpedBr.Common
{
    public static class EscreverCamposSpedByAttribute
    {
        /// <summary>
        /// Escrever campos p/ qualquer arquivo do projeto SPED (Contábil, Fiscal, Pis/Cofins)
        /// e não pula linha (util para quem quer controlar as quebras de linha manualmente
        /// </summary>
        /// <param name="source"></param>
        /// <param name="competenciaDeclaracao"></param>
        /// <returns></returns>
        public static string EscreverCamposTrim(this object source, DateTime competenciaDeclaracao)
        {
            return source.EscreverCampos(competenciaDeclaracao).Trim();
        }
        
        /// <summary>
        /// Escrever campos p/ qualquer arquivo do projeto SPED (Contábil, Fiscal, Pis/Cofins)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="competenciaDeclaracao"></param>
        /// <returns></returns>
        public static string EscreverCampos(this object source, DateTime competenciaDeclaracao)
        {
            var type = source.GetType();

            if (type == null)
                throw new Exception("Falha ao identificar tipo do objeto!");

            // Extrai o nome do registro atual. Ex.: RegistroA001 -> Resultado: A001
            var registroAtual = type.Name.Substring(type.Name.Length - 4);

            var spedRegistroAttr =
                (SpedRegistrosAttribute)
                    Attribute.GetCustomAttribute(type, typeof (SpedRegistrosAttribute));

            var deveGerarCamposDoRegistro = true;
            var dataObrigatoriedadeInicial = spedRegistroAttr?.ObrigatoriedadeInicial.ToDateTimeNullable();
            var dataObrigatoriedadeFinal = spedRegistroAttr?.ObrigatoriedadeFinal.ToDateTimeNullable();

            /*
             * Verifica obrigatoriedade de escrita do registro. Ex.: M225/M625 -> Obrigatório a partir de 01/10/2015
             */
            if (dataObrigatoriedadeInicial.HasValue &&
                (dataObrigatoriedadeInicial.Value > competenciaDeclaracao)) deveGerarCamposDoRegistro = false;

            if (dataObrigatoriedadeFinal.HasValue &&
                (dataObrigatoriedadeFinal.Value < competenciaDeclaracao.ObterProximoMesPrimeiroDia().AddDays(-1)))
                deveGerarCamposDoRegistro = false;

            /*
             * http://stackoverflow.com/questions/22306689/get-properties-of-class-by-order-using-reflection
             */
            var listaComPropriedadesOrdenadas =
                type.GetProperties().OrderBy(p => p.GetCustomAttributes(typeof (SpedCamposAttribute), true)
                    .Cast<SpedCamposAttribute>()
                    .Select(a => a.Ordem)
                    .FirstOrDefault())
                    .ToList();

            var sb = new StringBuilder();
            if (deveGerarCamposDoRegistro)
            {
                foreach (var property in listaComPropriedadesOrdenadas)
                {
                    sb.Append("|");
                    foreach (
                        var spedCampoAttr in
                            from Attribute attr in property.GetCustomAttributes(true) select attr as SpedCamposAttribute
                        )
                    {
                        if (spedCampoAttr == null)
                            throw new Exception(
                                $"O campo {property.Name} no registro {registroAtual} não possui atributo SPED definido!");

                        var isLiteralEnum = spedCampoAttr.Tipo == "LE"; // Literal Enum
                        var propertyValue = RegistroBaseSped.GetPropValue(source, property.Name, isLiteralEnum);
                        var propertyValueToStringSafe = propertyValue.ToStringSafe().Trim();

                        /*
                        * INDICADORES PARA FORMATAÇÃO DOS CAMPOS NOS REGISTROS
                        */

                        var isRequired = spedCampoAttr.IsObrigatorio;
                        var isDecimal = property.PropertyType == typeof (decimal);
                        var isNullableDecimal = property.PropertyType == typeof (decimal?);
                        var isDateTime = property.PropertyType == typeof (DateTime);
                        var isNullableDateTime = property.PropertyType == typeof (DateTime?);
                        var hasValue = !string.IsNullOrEmpty(propertyValueToStringSafe) ||
                                       !string.IsNullOrWhiteSpace(propertyValueToStringSafe);

                        var propertyLength = hasValue
                            ? propertyValueToStringSafe.Length
                            : 0;


                        // Verificação necessária p/ ajustes no tamanho de campos como CSTs e Indicadores. Ex.: CST PIS '1' -> Deve estar no arquivo como '01'.
                        var isCodeOrNumberAndHasLength = (spedCampoAttr.Tipo == "C" || spedCampoAttr.Tipo == "N") &&
                                                         (spedCampoAttr.Tamanho > 0 && spedCampoAttr.Tamanho <= 4);

                        var isHour = spedCampoAttr.Tipo == "H";
                        var onlyMonthAndYear = spedCampoAttr.Tipo == "MA";

                        if (isRequired && !hasValue)
                            throw new Exception(
                                $"O campo {spedCampoAttr.Ordem} - {spedCampoAttr.Campo} no Registro {registroAtual} é obrigatório e não foi informado!");

                        const decimal vZero = 0M;
                        if (isRequired && isDecimal &&
                            (propertyValueToStringSafe == string.Empty || propertyValueToStringSafe.ToDecimal() == 0))
                            sb.Append(vZero.ToString("N" + spedCampoAttr.QtdCasas));
                        else
                        {
                            if (isDecimal && hasValue)
                            {
                                var vDecimal =
                                    Convert.ToDecimal(propertyValue).ToString("N" + spedCampoAttr.QtdCasas);
                                sb.Append(vDecimal.ToStringSafe().Replace(".", ""));
                            }
                            else if (isNullableDecimal && hasValue)
                            {
                                var vDecimal =
                                    Convert.ToDecimal(propertyValue).ToString("N" + spedCampoAttr.QtdCasas);
                                sb.Append(vDecimal.ToStringSafe().Replace(".", ""));
                            }
                            else if (isDateTime && hasValue)
                                sb.Append(Convert.ToDateTime(propertyValue).Date.ToString("ddMMyyyy"));
                            else if (isNullableDateTime && hasValue)
                                sb.Append(Convert.ToDateTime(propertyValue).Date.ToString("ddMMyyyy"));
                            else if ((isDateTime && hasValue) && isHour)
                                sb.Append(Convert.ToDateTime(propertyValue).Date.ToString("hhmmss"));
                            else if ((isDateTime && hasValue) && onlyMonthAndYear)
                                sb.Append(Convert.ToDateTime(propertyValue).Date.ToString("MMyyyy"));
                            else if ((isCodeOrNumberAndHasLength && hasValue) || (isLiteralEnum && hasValue))
                                sb.Append(propertyValue.ToString().PadLeft(spedCampoAttr.Tamanho, '0'));
                            else
                            {
                                if (propertyLength > 0 && (propertyLength > spedCampoAttr.Tamanho))
                                    sb.Append(propertyValueToStringSafe.Substring(0, spedCampoAttr.Tamanho));
                                else
                                    sb.Append(propertyValueToStringSafe);
                            }
                        }
                    }
                }
                sb.Append("|");
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
