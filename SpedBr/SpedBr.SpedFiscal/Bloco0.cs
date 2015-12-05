using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SpedBr.SpedFiscal
{
    /// <summary>
    /// BLOCO 0: ABERTURA, IDENTIFICAÇÃO E REFERÊNCIAS
    /// </summary>
    public class Bloco0
    {
        /// <summary>
        /// Efetua a geração do BLOCO 0 do arquivo.
        /// </summary>
        /// <param name="reg0000">Abertura do arquivo digital e identificação da entidade.</param>
        /// <param name="reg0001"></param>
        /// <param name="reg0005"></param>
        /// <param name="reg0100"></param>
        /// <param name="validarRegistros"></param>
        /// <returns>String</returns>
        public List<string> EscreverBloco0(Registro0000 reg0000, Registro0001 reg0001, Registro0005 reg0005, Registro0100 reg0100, bool validarRegistros = true)
        {
            var list = new List<string>
            {
                reg0000.EscreverRegistro0000(validarRegistros),
                reg0001.EscreverRegistro0001(validarRegistros),
                reg0005.EscreverRegistro0005(validarRegistros),
                reg0100.EscreverRegistro0100(validarRegistros)
            };

            list.Add(new Registro0990().EscreverRegistro0990(list.Count));
            
            return list;
        }

        /// <summary>
        /// REGISTRO 0000: ABERTURA DO ARQUIVO DIGITAL E IDENTIFICAÇÃO DA ENTIDADE
        /// </summary>
        public class Registro0000
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "0000".
            /// </summary>
            private string REG
            {
                get { return "0000"; }
            }

            /// <summary>
            /// Código da versão do leiaute conforme a tabela indicada no Ato COTEPE.
            /// </summary>
            private string COD_VER { get; set; }

            /// <summary>
            /// Código da finalidade do arquivo:
            /// 0 - Remessa do arquivo original;
            /// 1 - Remessa do arquivo substituto.
            /// </summary>
            private string COD_FIN { get; set; }

            /// <summary>
            /// Data inicial das informações contidas no arquivo.
            /// </summary>
            private DateTime DataInicial { get; set; }

            /// <summary>
            /// Data inicial das informações contidas no arquivo.
            /// </summary>
            private string DT_INI
            {
                get { return this.DataInicial.ToShortDateString().Replace("/", ""); }
            }

            /// <summary>
            /// Data final das informações contidas no arquivo.
            /// </summary>
            private DateTime DataFinal { get; set; }

            /// <summary>
            /// Data final das informações contidas no arquivo.
            /// </summary>
            private string DT_FIN
            {
                get { return this.DataFinal.ToShortDateString().Replace("/", ""); }
            }

            /// <summary>
            /// Nome empresarial da entidade.
            /// </summary>
            private string NOME { get; set; }

            /// <summary>
            /// Número de inscrição da entidade no CNPJ.
            /// </summary>
            private string CNPJ { get; set; }

            /// <summary>
            /// Número de inscrição da entidade no CPF.
            /// </summary>
            private string CPF { get; set; }

            /// <summary>
            /// Sigla da unidade da federação da entidade.
            /// </summary>
            private string UF { get; set; }

            /// <summary>
            /// Inscrição Estadual da entidade.
            /// </summary>
            private string IE { get; set; }

            /// <summary>
            /// Código do município do domicílio fiscal da entidade, conforme a tabela IBGE.
            /// </summary>
            private string COD_MUN { get; set; }

            /// <summary>
            /// Inscrição Municipal da entidade.
            /// </summary>
            private string IM { get; set; }

            /// <summary>
            /// Inscrição da entidade na SUFRAMA.
            /// </summary>
            private string SUFRAMA { get; set; }

            /// <summary>
            /// Perfil de apresentação do arquivo fiscal:
            /// A - Perfil A;
            /// B - Perfil B;
            /// C - Perfil C.
            /// </summary>
            private string IND_PERFIL { get; set; }

            /// <summary>
            /// Indicador de tipo de atividade:
            /// 0 - Industrial ou equiparado a industrial;
            /// 1 - Outros.
            /// </summary>
            private string IND_ATIV { get; set; }

            #endregion Propriedades

            /// <summary>
            /// REGISTRO 0000: ABERTURA DO ARQUIVO DIGITAL E IDENTIFICAÇÃO DA ENTIDADE
            /// </summary>
            /// <param name="codVersao">Código da versão do leiaute conforme a tabela indicada no Ato COTEPE.</param>
            /// <param name="codFinalidade">Código da finalidade do arquivo: 0 - Remessa do arquivo original; 1 - Remessa do arquivo substituto.</param>
            /// <param name="dataInicial">Data inicial das informações contidas no arquivo.</param>
            /// <param name="dataFinal">Data final das informações contidas no arquivo.</param>
            /// <param name="nomeEmpresarial">Nome empresarial da entidade.</param>
            /// <param name="inscrCnpj">Número de inscrição da entidade no CPF.</param>
            /// <param name="inscrCpf">Número de inscrição da entidade no CPF.</param>
            /// <param name="siglaUf">Sigla da unidade da federação da entidade.</param>
            /// <param name="inscrEstadual">Inscrição Estadual da entidade.</param>
            /// <param name="codMunicipioIbge">Código do município do domicílio fiscal da entidade, conforme a tabela IBGE.</param>
            /// <param name="inscrMunicipal">Inscrição Municipal da entidade.</param>
            /// <param name="inscrSuframa">Inscrição da entidade na SUFRAMA.</param>
            /// <param name="indPerfil">Perfil de apresentação do arquivo fiscal: A - Perfil A; B - Perfil B; C - Perfil C.</param>
            /// <param name="indAtividade">Indicador de tipo de atividade: 0 - Industrial ou equiparado a industrial; 1 - Outros.</param>
            public Registro0000(string codVersao, string codFinalidade, DateTime dataInicial, DateTime dataFinal,
                string nomeEmpresarial, string inscrCnpj, string inscrCpf, string siglaUf, string inscrEstadual,
                string codMunicipioIbge, string inscrMunicipal, string inscrSuframa, string indPerfil,
                string indAtividade)
            {
                this.COD_VER = codVersao;
                this.COD_FIN = codFinalidade;
                this.DataInicial = dataInicial;
                this.DataFinal = dataFinal;
                this.NOME = nomeEmpresarial;
                this.CNPJ = inscrCnpj;
                this.CPF = inscrCpf;
                this.UF = siglaUf;
                this.IE = inscrEstadual;
                this.COD_MUN = codMunicipioIbge;
                this.IM = inscrMunicipal;
                this.SUFRAMA = inscrSuframa;
                this.IND_PERFIL = indPerfil;
                this.IND_ATIV = indAtividade;
            }

            /// <summary>
            /// Efetua a escrita do Registro 0000 do arquivo.
            /// </summary>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro0000(bool validarRegistro = true)
            {
                if (validarRegistro)
                {
                    #region Validações

                    #region Validar COD_VER

                    if (this.COD_VER.Trim().Equals(""))
                    {
                        throw new Exception(string.Format("{0}\r\n{1}\r\n{2}\r\n{3}", "Registro 0000 - Campo 02 (COD_VER)",
                            "Preenchimento: O código da versão do leiaute informado é validado conforme a data referenciada no campo DT_FIN.",
                            "Validação: Válido para o período informado. A versão do leiaute informada no arquivo deverá ser válida na data final da escrituração (campo DT_FIN do registro 0000).",
                            "Mensagem: Campo obrigatório COD_VER não informado."));
                    }
                    else
                    {
                        if (this.COD_VER.Length > 3)
                        {
                            throw new Exception(string.Format("{0}", "Mensagem: Campo COD_VER (REGISTRO 0000) não pode conter mais de 3 caracteres."));
                        }
                    }

                    #endregion Validar COD_VER

                    #region Validar COD_FIN

                    if (COD_FIN.Trim().Equals(""))
                    {
                        throw new Exception(string.Format("{0}\r\n{1}\r\n{2}\r\n{3}", "Registro 0000 - Campo 03 (COD_FIN)",
                            "Valores Válidos: [0, 1]",
                            "Preenchimento: Dentro do prazo normal de entrega do arquivo pode ser substituído.",
                            "Mensagem: Campo obrigatório COD_FIN não informado."));
                    }

                    if (!(COD_FIN.Equals("0") || COD_FIN.Equals("1")))
                    {
                        throw new Exception(string.Format("{0}", "Mensagem: Campo COD_FIN (REGISTRO 0000) possui valores pré definidos."));
                    }

                    #endregion Validar COD_FIN

                    if (DataInicial == DateTime.MinValue)
                    {
                        throw new Exception(string.Format("{0}\r\n{1}\r\n{2}", "Registro 0000 - Campo 04 (DT_INI)",
                            "Preenchimento: O valor informado deve ser o primeiro dia do mês, exceto no caso de início de atividades ou de qualquer outro evento que altere a forma e o período de escrituração fiscal do estabelecimento.",
                            "Mensagem: Campo obrigatório DT_INI não informado."));
                    }

                    if (DataFinal == DateTime.MinValue)
                    {
                        throw new Exception(string.Format("{0}\r\n{1}\r\n{2}\r\n{3}", "Registro 0000 - Campo 05 (DT_FIN)",
                            "Preenchimento: O valor informado deve ser o último dia do mês da data inicial, exceto no caso de encerramento de atividades ou de qualquer outro fato determinante para paralisação das atividades do estabelecimento.",
                            "Validação: Verifica se a data informada neste campo pertence ao mesmo mês/ano da data informada no campo DT_INI.",
                            "Mensagem: Campo obrigatório DT_FIN não informado."));
                    }
                    /* validacao para o tamanho do campo NOME */
                    if (NOME.Length > 100)
                    {
                        throw new Exception("Erro -> Tamanho do campo de NOME incorreto(a)");
                    }
                    /* validacao para a obrigatoriedade do campo NOME */
                    if (NOME.Trim().Equals(""))
                    {
                        throw new Exception("Erro -> Campo Obrigatório NOME não informado(a)");
                    }
                    /* validacao para o tamanho do campo CNPJ */
                    if (CNPJ.Length > 14)
                    {
                        throw new Exception("Erro -> Tamanho do campo de CNPJ incorreto(a)");
                    }
                    /* validacao para o tamanho do campo CPF */
                    if (CPF.Length > 11)
                    {
                        throw new Exception("Erro -> Tamanho do campo de CPF incorreto(a)");
                    }
                    /* validacao para o tamanho do campo UF */
                    if (UF.Length > 2)
                    {
                        throw new Exception("Erro -> Tamanho do campo de UF incorreto(a)");
                    }
                    /* validacao para a obrigatoriedade do campo UF */
                    if (UF.Trim().Trim().Equals(""))
                    {
                        throw new Exception("Erro -> Campo Obrigatório UF não informado(a)");
                    }
                    /* validacao para o tamanho do campo IE */
                    if (IE.Length > 14)
                    {
                        throw new Exception("Erro -> Tamanho do campo de IE incorreto(a)");
                    }
                    /* validacao para a obrigatoriedade do campo IE */
                    if (IE.Trim().Trim().Equals(""))
                    {
                        throw new Exception("Erro -> Campo Obrigatório IE não informado(a)");
                    }
                    /* validacao para o tamanho do campo COD_MUN */
                    if (COD_MUN.Length > 7)
                    {
                        throw new Exception("Erro -> Tamanho do campo de COD_MUN incorreto(a)");
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN */
                    if (COD_MUN.Trim().Trim().Equals(""))
                    {
                        throw new Exception("Erro -> Campo Obrigatório COD_MUN não informado(a)");
                    }
                    /* validacao para o tamanho do campo COD_MUN */
                    if (COD_MUN.Length > 7)
                    {
                        throw new Exception("Erro -> Tamanho do campo de COD_MUN incorreto(a)");
                    }
                    /* validacao para o tamanho do campo SUFRAMA */
                    if (SUFRAMA.Length > 9)
                    {
                        throw new Exception("Erro -> Tamanho do campo de SUFRAMA incorreto(a)");
                    }
                    /* validacao para o tamanho do campo IND_PERFIL */
                    if (IND_PERFIL.Length > 1)
                    {
                        throw new Exception("Erro -> Tamanho do campo de IND_PERFIL incorreto(a)");
                    }
                    /* validacao para a obrigatoriedade do campo IND_PERFIL */
                    if (IND_PERFIL.Trim().Trim().Equals(""))
                    {
                        throw new Exception("Erro -> Campo Obrigatório IND_PERFIL não informado(a)");
                    }
                    /* Validacao dos dados passados a IND_PERFIL */
                    if (!(IND_PERFIL.Equals("A") || IND_PERFIL.Equals("B") || IND_PERFIL.Equals("C")))
                    {
                        throw new Exception("Erro -> O campo IND_PERFIL possui valores pré-definidos");
                    }
                    /* validacao para o tamanho do campo IND_ATIV */
                    if (IND_ATIV.Length > 1)
                    {
                        throw new Exception("Erro -> Tamanho do campo de IND_ATIV incorreto(a)");
                    }
                    /* validacao para a obrigatoriedade do campo IND_ATIV */
                    if (IND_ATIV.Trim().Trim().Equals(""))
                    {
                        throw new Exception("Erro -> Campo Obrigatório IND_ATIV não informado(a)");
                    }
                    /* Validacao dos dados passados a IND_ATIV */
                    if (!(IND_ATIV.Equals("0") || IND_ATIV.Equals("1")))
                    {
                        throw new Exception("Erro -> O campo IND_ATIV possui valores pré-definidos");
                    }
                    /* validacoes manuais */

                    /* validacao da data de fim no mesmo mes/ano da data inicio */
                    DateTime dataInicio;
                    DateTime dataFim;
                    try
                    {
                        dataInicio = DateTime.ParseExact(DT_INI, "ddMMyyyy", System.Globalization.CultureInfo.CurrentCulture);
                    }
                    catch (Exception)
                    {
                        throw new Exception("Erro -> Data inválida no campo DT_INI");
                    }
                    try
                    {
                        dataFim = DateTime.ParseExact(DT_FIN, "ddMMyyyy", System.Globalization.CultureInfo.CurrentCulture);
                    }
                    catch (Exception)
                    {
                        throw new Exception("Erro -> Data inválida no campo DT_FIM");
                    }
                    if ((dataInicio.Month != dataFim.Month) || (dataInicio.Year != dataFim.Year))
                    {
                        throw new Exception("Erro -> Mês e Ano não conferem para Data_Final");
                    }
                    /* validar CPF / CNPJ */
                    if (!CNPJ.Trim().Trim().Equals(""))
                    {
                        //if (!Utils.ValidaCNPJ(CNPJ))
                        //throw new Exception("Erro -> CNPJ Inválido");
                    }
                    if (!CPF.Trim().Trim().Equals(""))
                    {
                        //if (!Utils.ValidaCPF(CPF))
                        throw new Exception("Erro -> CPF Inválido");
                    }

                    #endregion Validações
                }

                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|", REG, COD_VER,
                    COD_FIN, DT_INI, DT_FIN, NOME, CNPJ, CPF, UF, IE, COD_MUN, IM, SUFRAMA, IND_PERFIL, IND_ATIV);
            }
        }

        /// <summary>
        /// REGISTRO 0001: ABERTURA DO BLOCO 0
        /// </summary>
        public class Registro0001
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "0001".
            /// </summary>
            private string REG
            {
                get { return "0001"; }
            }

            /// <summary>
            /// Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.
            /// </summary>
            private string IND_MOV { get; set; }

            #endregion Propriedades

            /// <summary>
            /// REGISTRO 0001: ABERTURA DO BLOCO 0
            /// </summary>
            /// <param name="indicadorMovimento">Indicador de movimento: 0 - Bloco com dados informados; 1 - Bloco sem dados informados.</param>
            public Registro0001(string indicadorMovimento)
            {
                this.IND_MOV = indicadorMovimento;
            }

            /// <summary>
            /// Efetua a escrita do Registro 0001 do arquivo.
            /// </summary>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro0001(bool validarRegistro = true)
            {
                if (validarRegistro)
                {
                    if (!(IND_MOV.Equals("0") || IND_MOV.Equals("1")))
                    {
                        throw new Exception(string.Format("{0}", "Mensagem: Para o campo IND_MOV (REGISTRO 0001) são valores válidos: 0 e 1."));
                    }
                }

                return String.Format("|{0}|{1}|", REG, IND_MOV);
            }
        }

        /// <summary>
        /// REGISTRO 0005: DADOS COMPLEMENTARES DA ENTIDADE
        /// </summary>
        public class Registro0005
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "0005".
            /// </summary>
            private string REG
            {
                get { return "0005"; }
            }
            /// <summary>
            /// Nome de fantasia associado ao nome empresarial.
            /// </summary>
            private string FANTASIA { get; set; }
            /// <summary>
            /// Código de endeçamento postal.
            /// </summary>
            private string CEP { get; set; }
            /// <summary>
            /// Logradouro e endereço do imóvel.
            /// </summary>
            private string END { get; set; }
            /// <summary>
            /// Número do imóvel.
            /// </summary>
            private string NUM { get; set; }
            /// <summary>
            /// Dados complementares do endereço.
            /// </summary>
            private string COMPL { get; set; }
            /// <summary>
            /// Bairro em que o imóvel está situado.
            /// </summary>
            private string BAIRRO { get; set; }
            /// <summary>
            /// Número do telefone (DDD+FONE).
            /// </summary>
            private string FONE { get; set; }
            /// <summary>
            /// Número do fax.
            /// </summary>
            private string FAX { get; set; }
            /// <summary>
            /// Endereço do correio eletrônico.
            /// </summary>
            private string EMAIL { get; set; }

            #endregion Propriedades

            /// <summary>
            /// REGISTRO 0005: DADOS COMPLEMENTARES DA ENTIDADE
            /// </summary>
            /// <param name="nomeFantasia">Nome de fantasia associado ao nome empresarial.</param>
            /// <param name="cep">Código de endereçamento postal.</param>
            /// <param name="endereco">Logradouro e endereço do imóvel.</param>
            /// <param name="numero">Número do imóvel.</param>
            /// <param name="complemento">Dados complementares do endereço.</param>
            /// <param name="bairro">Bairro em que o imóvel está situado.</param>
            /// <param name="fone">Número do telefone (DDD+FONE).</param>
            /// <param name="fax">Número do fax.</param>
            /// <param name="email">Endereço do correio eletrônico.</param>
            public Registro0005(string nomeFantasia, string cep, string endereco, string numero, string complemento, string bairro, string fone, string fax, string email)
            {
                this.FANTASIA = nomeFantasia;
                this.CEP = cep;
                this.END = endereco;
                this.NUM = numero;
                this.COMPL = complemento;
                this.BAIRRO = bairro;
                this.FONE = fone;
                this.FAX = fax;
                this.EMAIL = email;
            }

            /// <summary>
            /// Efetua a escrita do Registro 0005 do arquivo.
            /// </summary>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro0005(bool validarRegistro = true)
            {
                if (validarRegistro)
                {
                    //if (!(IND_MOV.Equals("0") || IND_MOV.Equals("1")))
                    //{
                    //    throw new Exception(string.Format("{0}", "Mensagem: Para o campo IND_MOV (REGISTRO 0001) são valores válidos: 0 e 1."));
                    //}
                }

                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", REG, FANTASIA, CEP, END, NUM, COMPL, BAIRRO, FONE, FAX, EMAIL);
            }
        }

        /// <summary>
        /// REGISTRO 0100: DADOS DO CONTABILISTA
        /// </summary>
        public class Registro0100
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "0100".
            /// </summary>
            private string REG
            {
                get { return "0100"; }
            }
            /// <summary>
            /// Nome do contabilista.
            /// </summary>
            private string NOME { get; set; }
            /// <summary>
            /// Número de inscrição do contabilista no CPF.
            /// </summary>
            private string CPF { get; set; }
            /// <summary>
            /// Número de inscrição do contabilista no Conselho Regional de Contabilidade.
            /// </summary>
            private string CRC { get; set; }
            /// <summary>
            /// Número de inscrição do escritório de contabilidade no CNPJ, se houver.
            /// </summary>
            private string CNPJ { get; set; }
            /// <summary>
            /// Código de endereçamento postal.
            /// </summary>
            private string CEP { get; set; }
            /// <summary>
            /// Logradouro e endereço do imóvel.
            /// </summary>
            private string END { get; set; }
            /// <summary>
            /// Número do imóvel.
            /// </summary>
            private string NUM { get; set; }
            /// <summary>
            /// Dados complementares do endereço.
            /// </summary>
            private string COMPL { get; set; }
            /// <summary>
            /// Bairro em que o imóvel está situado.
            /// </summary>
            private string BAIRRO { get; set; }
            /// <summary>
            /// Número de telefone (DDD+FONE).
            /// </summary>
            private string FONE { get; set; }
            /// <summary>
            /// Número do fax.
            /// </summary>
            private string FAX { get; set; }
            /// <summary>
            /// Endereço do correio eletrônico.
            /// </summary>
            private string EMAIL { get; set; }
            /// <summary>
            /// Código do município, conforme tabela IBGE.
            /// </summary>
            private string COD_MUN { get; set; }

            #endregion Propriedades

            /// <summary>
            /// REGISTRO 0100: DADOS DO CONTABILISTA
            /// </summary>
            /// <param name="nomeContabilista">Nome do contabilista.</param>
            /// <param name="cpf">Número de inscrição do contabilista no CPF.</param>
            /// <param name="crc">Número de inscrição do contabilista no Conselho Regional de Contabilidade.</param>
            /// <param name="cnpj">Número de inscrição do escritório de contabilidade no CNPJ, se houver.</param>
            /// <param name="cep">Código de endereçamento postal.</param>
            /// <param name="endereco">Logradouro e endereço do imóvel.</param>
            /// <param name="numero">Número do imóvel.</param>
            /// <param name="complemento">Dados complementares do endereço.</param>
            /// <param name="bairro">Bairro em que o imóvel está situado.</param>
            /// <param name="fone">Número do telefone (DDD+FONE).</param>
            /// <param name="fax">Número do fax.</param>
            /// <param name="email">Endereço do correio eletrônico.</param>
            /// <param name="codigoMunicipio">Código do município, conforme tabela IBGE.</param>
            public Registro0100(string nomeContabilista, string cpf, string crc, string cnpj, string cep,
                string endereco, string numero, string complemento, string bairro, string fone, string fax, string email,
                string codigoMunicipio)
            {
                this.NOME = nomeContabilista;
                this.CPF = cpf;
                this.CRC = crc;
                this.CNPJ = cnpj;
                this.CEP = cep;
                this.END = endereco;
                this.NUM = numero;
                this.COMPL = complemento;
                this.BAIRRO = bairro;
                this.FONE = fone;
                this.FAX = fax;
                this.EMAIL = email;
                this.COD_MUN = codigoMunicipio;
            }

            /// <summary>
            /// Efetua a escrita do Registro 0100 do arquivo.
            /// </summary>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro0100(bool validarRegistro = true)
            {
                if (validarRegistro)
                {
                    //if (!(IND_MOV.Equals("0") || IND_MOV.Equals("1")))
                    //{
                    //    throw new Exception(string.Format("{0}", "Mensagem: Para o campo IND_MOV (REGISTRO 0001) são valores válidos: 0 e 1."));
                    //}
                }

                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|", REG, NOME, CPF, CRC, CNPJ, CEP, END, NUM, COMPL, BAIRRO, FONE, FAX, EMAIL, COD_MUN);
            }
        }
        
        /// <summary>
        /// REGISTRO 0990: ENCERRAMENTO DO BLOCO 0
        /// </summary>
        public class Registro0990
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contento "0990".
            /// </summary>
            private string REG
            {
                get { return "0990"; }
            }

            private string QTD_LIN_0 { get; set; }

            #endregion Propriedades

            /// <summary>
            /// Efetua a escrita do Registro 0990 do arquivo.
            /// </summary>
            /// <param name="qtdLinhas">Quantidade de linhas dos blocos e registros anteriores ao registro 0990.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro0990(int qtdLinhas)
            {
                int qtdLinhasRegistro0990 = 1;

                qtdLinhasRegistro0990 += qtdLinhas;

                return String.Format("|{0}|{1}|", REG, qtdLinhasRegistro0990);
            }
        }
    }
}
