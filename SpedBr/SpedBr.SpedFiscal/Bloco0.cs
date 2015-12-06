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
        /// <param name="reg0001">Abertura do Bloco 0.</param>
        /// <param name="reg0005">Dados complementares da entidade.</param>
        /// <param name="registros0015">Dados do contribuinte substituto.</param>
        /// <param name="reg0100">Dados do contabilista.</param>
        /// <param name="registros0150">Dados dos participantes.</param>
        /// <param name="registros0190">Dados das unidades de medida.</param>
        /// <param name="registros0200">Dados dos produtos/serviços.</param>
        /// <param name="validarRegistros">true ou false para realizar a validação dos dados.</param>
        /// <returns>String</returns>
        public List<string> EscreverBloco0(Registro0000 reg0000, Registro0001 reg0001, Registro0005 reg0005,
            List<Registro0015> registros0015, Registro0100 reg0100, List<Registro0150> registros0150,
            List<Registro0190> registros0190, List<Registro0200> registros0200, bool validarRegistros = true)
        {
            var list = new List<string>
            {
                reg0000.EscreverRegistro0000(validarRegistros),
                reg0001.EscreverRegistro0001(validarRegistros),
                reg0005.EscreverRegistro0005(validarRegistros)
            };

            foreach (var reg0015 in registros0015)
            {
                list.Add(new Registro0015().EscreverRegistro0015(reg0015));
            }

            list.Add(reg0100.EscreverRegistro0100(validarRegistros));

            foreach (var reg0150 in registros0150)
            {
                list.AddRange(new Registro0150().EscreverRegistro0150(reg0150));
            }

            foreach (var reg0190 in registros0190)
            {
                list.Add(new Registro0190().EscreverRegistro0190(reg0190));
            }

            foreach (var reg0200 in registros0200)
            {
                list.AddRange(new Registro0200().EscreverRegistro0200(reg0200));
            }

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
            /// Texto fixo contendo "0000".
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
            private FinalidadeArquivo CodigoFinalidade { get; set; }

            /// <summary>
            /// Código da finalidade do arquivo:
            /// 0 - Remessa do arquivo original;
            /// 1 - Remessa do arquivo substituto.
            /// </summary>
            private string COD_FIN {
                get
                {
                    switch (CodigoFinalidade)
                    {
                        case FinalidadeArquivo.RemessaArquivoOriginal:
                            return "0";
                            break;
                        case FinalidadeArquivo.RemessaArquivoSubstituto:
                            return "1";
                            break;
                        default:
                            return "--'";
                            break;
                    }
                } 
            }

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
            public Registro0000(string codVersao, FinalidadeArquivo codFinalidade, DateTime dataInicial, DateTime dataFinal,
                string nomeEmpresarial, string inscrCnpj, string inscrCpf, string siglaUf, string inscrEstadual,
                string codMunicipioIbge, string inscrMunicipal, string inscrSuframa, string indPerfil,
                string indAtividade)
            {
                this.COD_VER = codVersao;
                this.CodigoFinalidade = codFinalidade;
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
            /// Texto fixo contendo "0001".
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
            /// Texto fixo contendo "0005".
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
            public Registro0005(string nomeFantasia, string cep, string endereco, string numero, string complemento,
                string bairro, string fone, string fax, string email)
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

                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", REG, FANTASIA, CEP, END, NUM, COMPL,
                    BAIRRO, FONE, FAX, EMAIL);
            }
        }

        /// <summary>
        /// REGISTRO 0015: DADOS DO CONTRIBUINTE SUBSTITUTO
        /// </summary>
        public class Registro0015
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "0015".
            /// </summary>
            private string REG
            {
                get { return "0015"; }
            }

            /// <summary>
            /// Sigla da unidade da federação do contribuinte substituído.
            /// </summary>
            public string UF_ST { get; set; }

            /// <summary>
            /// Inscrição Estadual do contribuinte substituto na unidade da federação do contribuinte substituído.
            /// </summary>
            public string IE_ST { get; set; }

            #endregion Propriedades

            /// <summary>
            /// Efetua a escrita do Registro 0015 do arquivo.
            /// </summary>
            /// <param name="inscrEstadual"></param>
            /// <param name="validarRegistro">true ou false para realizar a validação dos dados.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro0015(Registro0015 inscrEstadual, bool validarRegistro = true)
            {
                return String.Format("|{0}|{1}|{2}|", REG, inscrEstadual.UF_ST, inscrEstadual.IE_ST);
            }
        }

        /// <summary>
        /// REGISTRO 0100: DADOS DO CONTABILISTA
        /// </summary>
        public class Registro0100
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "0100".
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

                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|", REG, NOME, CPF,
                    CRC, CNPJ, CEP, END, NUM, COMPL, BAIRRO, FONE, FAX, EMAIL, COD_MUN);
            }
        }

        /// <summary>
        /// REGISTRO 0150: TABELA DE CADASTRO DO PARTICIPANTE
        /// </summary>
        public class Registro0150
        {
            /// <summary>
            /// REGISTRO 0175: ALTERAÇÃO DA TABELA DE CADASTRO DE PARTICIPANTE
            /// </summary>
            public class Registro0175
            {
                /// <summary>
                /// Texto fixo contendo "0175".
                /// </summary>
                public string REG
                {
                    get { return "0175"; }
                }

                /// <summary>
                /// Data de alteração do cadastro.
                /// </summary>
                public DateTime DataAlteracao { get; set; }

                /// <summary>
                /// Data de alteração do cadastro.
                /// </summary>
                public string DT_ALT
                {
                    get { return this.DataAlteracao.ToShortDateString().Replace("/", ""); }
                }

                /// <summary>
                /// Número do campo alterado (campos 03 a 13, exceto 07)
                /// </summary>
                public string NR_CAMPO { get; set; }

                /// <summary>
                /// Conteúdo anterior do campo.
                /// </summary>
                public string CONT_ANT { get; set; }
            }

            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "0150".
            /// </summary>
            public string REG
            {
                get { return "0150"; }
            }

            /// <summary>
            /// Código de identificação do participante no arquivo.
            /// </summary>
            public string COD_PART { get; set; }

            /// <summary>
            /// Nome pessoal ou empresarial do participante.
            /// </summary>
            public string NOME { get; set; }

            /// <summary>
            /// Código do país do participante, conforme a tabela indicada no item 3.2.1.
            /// </summary>
            public string COD_PAIS { get; set; }

            /// <summary>
            /// CNPJ do participante.
            /// </summary>
            public string CNPJ { get; set; }

            /// <summary>
            /// CPF do participante.
            /// </summary>
            public string CPF { get; set; }

            /// <summary>
            /// Inscrição Estadual do participante.
            /// </summary>
            public string IE { get; set; }

            /// <summary>
            /// Código do município, conforme a tabela IBGE.
            /// </summary>
            public string COD_MUN { get; set; }

            /// <summary>
            /// Número de inscrição do participante na SUFRAMA
            /// </summary>
            public string SUFRAMA { get; set; }

            /// <summary>
            /// Logradouro e endereço do imóvel.
            /// </summary>
            public string END { get; set; }

            /// <summary>
            /// Número do imóvel.
            /// </summary>
            public string NUM { get; set; }

            /// <summary>
            /// Dados complementares do endereço.
            /// </summary>
            public string COMPL { get; set; }

            /// <summary>
            /// Bairro em que o imóvel está situado.
            /// </summary>
            public string BAIRRO { get; set; }

            /// <summary>
            /// Lista de alterações nos dados do participante.
            /// </summary>
            public List<Registro0175> ListaAlteracoes { get; set; }

            #endregion Propriedades

            public Registro0150()
            {
                this.ListaAlteracoes = new List<Registro0175>();
            }

            /// <summary>
            /// Efetua a escrita do Registro 0150 do arquivo.
            /// </summary>
            /// <param name="participante">Dados do participante a ser incluído no arquivo.</param>
            /// <returns>String</returns>
            internal List<string> EscreverRegistro0150(Registro0150 participante)
            {
                var list = new List<string>();

                list.Add(String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|", REG,
                    participante.COD_PART, participante.NOME, participante.COD_PAIS, participante.CNPJ, participante.CPF,
                    participante.IE, participante.COD_MUN, participante.SUFRAMA, participante.END, participante.NUM,
                    participante.COMPL, participante.BAIRRO));

                if (participante.ListaAlteracoes.Count > 0)
                {
                    foreach (var alt in participante.ListaAlteracoes)
                    {
                        list.Add(String.Format("|{0}|{1}|{2}|{3}|", alt.REG, alt.DT_ALT, alt.NR_CAMPO, alt.CONT_ANT));
                    }
                }

                return list;
            }
        }

        /// <summary>
        /// REGISTRO 0190: IDENTIFICAÇÃO DAS UNIDADES DE MEDIDA
        /// </summary>
        public class Registro0190
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "0190".
            /// </summary>
            private string REG
            {
                get { return "0190"; }
            }

            /// <summary>
            /// Código da unidade de medida.
            /// </summary>
            public string UNID { get; set; }

            /// <summary>
            /// Descrição da unidade de medida.
            /// </summary>
            public string DESCR { get; set; }

            /// <summary>
            /// Efetua a escrita do Registro 0190 do arquivo.
            /// </summary>
            /// <param name="unidadeMedida">Dados da unidade de medida a ser escrita no arquivo.</param>
            /// <returns>String</returns>
            internal string EscreverRegistro0190(Registro0190 unidadeMedida)
            {
                return String.Format("|{0}|{1}|{2}|", REG, unidadeMedida.UNID, unidadeMedida.DESCR);
            }

            #endregion
        }

        /// <summary>
        /// REGISTRO 0200: IDENTIFICAÇÃO DO ITEM (PRODUTOS E SERVIÇOS)
        /// </summary>
        public class Registro0200
        {
            public class Registro0205
            {
                #region Propriedades

                /// <summary>
                /// Texto fixo contendo "0205".
                /// </summary>
                public string REG
                {
                    get { return "0205"; }
                }

                public string DESCR_ANT_ITEM { get; set; }

                /// <summary>
                /// Data inicial de utilização da descrição do item.
                /// </summary>
                public DateTime DataInicial { get; set; }

                /// <summary>
                /// Data inicial de utilização da descrição do item.
                /// </summary>
                public string DT_INI
                {
                    get { return this.DataInicial.ToShortDateString().Replace("/", ""); }
                }

                /// <summary>
                /// Data final de utilização da descrição do item.
                /// </summary>
                public DateTime DataFinal { get; set; }

                /// <summary>
                /// Data final de utilização da descrição do item.
                /// </summary>
                public string DT_FIN
                {
                    get { return this.DataInicial.ToShortDateString().Replace("/", ""); }
                }

                /// <summary>
                /// Código anterior do item com relação à última informação apresentada.
                /// </summary>
                public string COD_ANT_ITEM { get; set; }

                #endregion
            }

            public class Registro0206
            {
                #region Propriedades

                /// <summary>
                /// Texto fixo contendo "0206".
                /// </summary>
                public string REG
                {
                    get { return "0206"; }
                }

                /// <summary>
                /// Código do combustível, conforme tabela publicada pela ANP.
                /// </summary>
                public string COD_COMB { get; set; }

                #endregion
            }

            public class Registro0210
            {
                #region Propriedades

                /// <summary>
                /// Texto fixo contendo "0210".
                /// </summary>
                public string REG
                {
                    get { return "0210"; }
                }

                /// <summary>
                /// Código do item componente/insumo (campo 02 do Registro 0200).
                /// </summary>
                public string COD_ITEM_COMP { get; set; }

                /// <summary>
                /// Quantidade do item componente/insumo para se produzir uma unidade do item composto/resultante.
                /// </summary>
                public decimal QTD_COMP { get; set; }

                /// <summary>
                /// Perda/quebra normal percentual do insumo/componente para se produzir uma unidade do item composto/resultante.
                /// </summary>
                public decimal PERDA { get; set; }

                #endregion
            }

            public class Registro0220
            {
                #region Propriedades

                /// <summary>
                /// Texto fixo contendo "0220".
                /// </summary>
                public string REG
                {
                    get { return "0220"; }
                }

                /// <summary>
                /// Unidade comercial a ser convertida na unidade de estoque, referida no registro 0200.
                /// </summary>
                public string UNID_CONV { get; set; }

                /// <summary>
                /// Fator de conversão: fator utilizado para converter (multiplicar) a unidade a ser convertida na unidade adotada no inventário.
                /// </summary>
                public decimal FAT_CONV { get; set; }

                #endregion
            }

            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "0200".
            /// </summary>
            private string REG
            {
                get { return "0200"; }
            }

            /// <summary>
            /// Código do item.
            /// </summary>
            public string COD_ITEM { get; set; }

            /// <summary>
            /// Descrição do item.
            /// </summary>
            public string DESCR_ITEM { get; set; }

            /// <summary>
            /// Representação alfanumérica do código de barra do produto, se houver.
            /// </summary>
            public string COD_BARRA { get; set; }

            /// <summary>
            /// Código anterior do item com relação à última informação apresentada.
            /// Conforme Guia_Prático_da_EFD_Versao_2.0.17 -> "informar no 0205"
            /// </summary>
            public string COD_ANT_ITEM { get { return ""; } }

            /// <summary>
            /// Unidade de medida utilizada na quantificação de estoques.
            /// </summary>
            public string UNID_INV { get; set; }

            /// <summary>
            /// Tipo do item - Atividades Industriais, Comerciais e Serviços: 00 - Mercadoria para Revenda; 01 - Matéria-Prima; 02 - Embalagem; 03 - Produto em Processo; 04 - Produto Acabado; 05 - Subproduto; 06 - Produto Intermediário; 07 - Material de Uso e Consumo; 08 - Ativo Imobilizado; 09 - Serviços; 10 - Outros insumos; 99 - Outras.
            /// </summary>
            public TipoItem TipoDoItem { get; set; }

            /// <summary>
            /// Tipo do item - Atividades Industriais, Comerciais e Serviços: 00 - Mercadoria para Revenda; 01 - Matéria-Prima; 02 - Embalagem; 03 - Produto em Processo; 04 - Produto Acabado; 05 - Subproduto; 06 - Produto Intermediário; 07 - Material de Uso e Consumo; 08 - Ativo Imobilizado; 09 - Serviços; 10 - Outros insumos; 99 - Outras.
            /// </summary>
            private string TIPO_ITEM
            {
                get
                {
                    switch (TipoDoItem)
                    {
                        case TipoItem.MercadoriaRevenda:
                            return "00";
                            break;
                        case TipoItem.MateriaPrima:
                            return "01";
                            break;
                        case TipoItem.Embalagem:
                            return "02";
                            break;
                        case TipoItem.ProdutoProcesso:
                            return "03";
                            break;
                        case TipoItem.ProdutoAcabado:
                            return "04";
                            break;
                        case TipoItem.Subproduto:
                            return "05";
                            break;
                        case TipoItem.ProdutoIntermediario:
                            return "06";
                            break;
                        case TipoItem.MaterialUsoConsumo:
                            return "07";
                            break;
                        case TipoItem.AtivoImobilizado:
                            return "08";
                            break;
                        case TipoItem.Servicos:
                            return "09";
                            break;
                        case TipoItem.OutrosInsumos:
                            return "10";
                            break;
                        case TipoItem.Outras:
                            return "99";
                            break;
                        default:
                            return "";
                            break;
                    }
                }
            }

            /// <summary>
            /// Código da Nomenclatura Comum do Mercosul
            /// </summary>
            public string COD_NCM { get; set; }

            /// <summary>
            /// Código EX, conforme a TIPI
            /// </summary>
            public string EX_IPI { get; set; }

            /// <summary>
            /// Código do gênero do item
            /// </summary>
            public string COD_GEN { get; set; }

            /// <summary>
            /// Código do serviço conforme a lista do Anexo I da Lei Complementar Federal n 116/2003.
            /// </summary>
            public string COD_LST { get; set; }

            /// <summary>
            /// Alíquota de ICMS aplicável ao item nas operações internas.
            /// </summary>
            public decimal ALIQ_ICMS { get; set; }

            public List<Registro0205> ListaAlteracoes { get; set; }

            public Registro0206 CodigoAnp { get; set; }

            public List<Registro0210> ListaConsumoEspecPadronizado { get; set; }

            public List<Registro0220> ListaFatoresConversaoUnidades { get; set; } 

            #endregion Propriedades

            public Registro0200()
            {
                this.ListaAlteracoes = new List<Registro0205>();
                this.ListaConsumoEspecPadronizado = new List<Registro0210>();
                this.ListaFatoresConversaoUnidades = new List<Registro0220>();
            }

            /// <summary>
            /// Efetua a escrita do Registro 0200 do arquivo.
            /// </summary>
            /// <param name="produtoServico">Dados do produto/serviço a ser incluído no arquivo.</param>
            /// <returns></returns>
            internal List<string> EscreverRegistro0200(Registro0200 produtoServico)
            {
                var list = new List<string>();

                list.Add(String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|", REG, produtoServico.COD_ITEM, produtoServico.DESCR_ITEM,
                    produtoServico.COD_BARRA, produtoServico.COD_ANT_ITEM, produtoServico.UNID_INV,
                    produtoServico.TIPO_ITEM, produtoServico.COD_NCM, produtoServico.EX_IPI, produtoServico.COD_GEN,
                    produtoServico.COD_LST, produtoServico.ALIQ_ICMS));

                if (produtoServico.ListaAlteracoes.Count > 0)
                {
                    foreach (var alt in produtoServico.ListaAlteracoes)
                    {
                        list.Add(String.Format("|{0}|{1}|{2}|{3}|{4}|", alt.REG, alt.DESCR_ANT_ITEM, alt.DT_INI, alt.DT_FIN, alt.COD_ANT_ITEM));
                    }
                }

                if (produtoServico.CodigoAnp != null)
                {
                    list.Add(String.Format("|{0}|{1}|", produtoServico.CodigoAnp.REG, produtoServico.CodigoAnp.COD_COMB));
                }

                if (produtoServico.ListaConsumoEspecPadronizado.Count > 0)
                {
                    foreach (var consumoPadronizado in produtoServico.ListaConsumoEspecPadronizado)
                    {
                        list.Add(String.Format("|{0}|{1}|{2}|{3}|", consumoPadronizado.REG, consumoPadronizado.COD_ITEM_COMP, consumoPadronizado.QTD_COMP, consumoPadronizado.PERDA));
                    }
                }

                if (produtoServico.ListaFatoresConversaoUnidades.Count > 0)
                {
                    foreach (var fatorConversao in produtoServico.ListaFatoresConversaoUnidades)
                    {
                        list.Add(String.Format("|{0}|{1}|{2}|", fatorConversao.REG, fatorConversao.UNID_CONV, fatorConversao.FAT_CONV));
                    }
                }

                return list;
            }
        }

        /// <summary>
        /// REGISTRO 0990: ENCERRAMENTO DO BLOCO 0
        /// </summary>
        public class Registro0990
        {
            #region Propriedades

            /// <summary>
            /// Texto fixo contendo "0990".
            /// </summary>
            private string REG
            {
                get { return "0990"; }
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco 0.
            /// </summary>
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
