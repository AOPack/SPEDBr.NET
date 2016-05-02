using System;
using SpedBr.Common;

namespace SpedBr.Outros.Sintegra
{
    public class Registro11
    {
        #region Propriedades

        private string TIPO
        {
            get { return "11"; }
        }

        private string LOGRADOURO { get; set; }

        private string NUMERO { get; set; }

        private string COMPLEMENTO { get; set; }

        private string BAIRRO { get; set; }

        private string CEP { get; set; }

        private string NOME_CONTATO { get; set; }

        private string TELEFONE { get; set; }

        #endregion Propriedades

        public Registro11(
            string logradouro,
            string numero,
            string complemento,
            string bairro,
            string cep,
            string nomeContato,
            string telefone
            )
        {
            this.LOGRADOURO = logradouro;
            this.NUMERO = numero;
            this.COMPLEMENTO = complemento;
            this.BAIRRO = bairro;
            this.CEP = cep;
            this.NOME_CONTATO = nomeContato;
            this.TELEFONE = telefone;
        }

        /// <summary>
        /// Efetua a escrita do Registro 11 do arquivo.
        /// </summary>
        /// <param name="validarCampos">true ou false para realizar a validação dos dados.</param>
        /// <returns>String</returns>
        public string EscreverRegistro11(bool validarCampos = true)
        {
            if (validarCampos)
            {
                // Validar campos
            }

            var r11 = new string(' ', 126);
            try
            {
                r11 = r11.PreencherValorNaLinha(1, 2, TIPO.PadLeft(2, ' '));
                r11 = r11.PreencherValorNaLinha(3, 36, LOGRADOURO.Length > 34 ? LOGRADOURO.Substring(0, 34) : LOGRADOURO.PadRight(34, ' ')).ToUpper();
                r11 = r11.PreencherValorNaLinha(37, 41, NUMERO.Length <= 0 ? new string('0', 5) : NUMERO.PadLeft(5, '0')).ToUpper();

                if (string.IsNullOrEmpty(NUMERO) || 
                    NUMERO.ToUpper() == "S/Nº" || 
                    NUMERO.ToUpper() == "SNº" ||
                    NUMERO.ToUpper() == "SN" ||
                    NUMERO.ToUpper() == "S/N")
                {
                    r11 = r11.PreencherValorNaLinha(42, 63, "S/N".PadRight(22, ' '));
                }
                else
                {
                    r11 = r11.PreencherValorNaLinha(42, 63,
                        COMPLEMENTO.Length > 22
                            ? COMPLEMENTO.Substring(0, 22).PadRight(22, ' ')
                            : COMPLEMENTO.PadRight(22, ' ')).ToUpper();
                }

                r11 = r11.PreencherValorNaLinha(64, 78, BAIRRO.Length > 15 ? BAIRRO.Substring(0, 15) : BAIRRO.PadRight(15, ' ')).ToUpper();
                r11 = r11.PreencherValorNaLinha(79, 86, CEP.PadLeft(8, '0'));
                r11 = r11.PreencherValorNaLinha(87, 114, NOME_CONTATO.Length > 28 ? NOME_CONTATO.Substring(0, 28) : NOME_CONTATO.PadRight(28, ' ')).ToUpper();
                r11 = r11.PreencherValorNaLinha(115, 126, TELEFONE.Replace("(", "").Replace(")", "").Replace("-", "").Replace(".", "").PadLeft(12, '0'));

                return r11;
            }
            catch (Exception e)
            {
                throw new Exception("Falha ao gerar registro tipo 11." + Environment.NewLine + e.Message);
            }
        }
    }
}
