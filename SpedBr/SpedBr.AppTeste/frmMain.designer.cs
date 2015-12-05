namespace SpedBr.AppTeste
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarArquivo = new System.Windows.Forms.Button();
            this.progressBarProgresso = new System.Windows.Forms.ProgressBar();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTotalLinhas = new System.Windows.Forms.Label();
            this.lblTotalLinhasArquivo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblProgressoValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbReg0000CodigoVersao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbReg0000CodigoFinalidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbReg0000RazaoSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbReg0000Cnpj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbReg0000Cpf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbReg0000Uf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbReg0000InscricaoEstadual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbReg0000CodigoMunicipioIbge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbReg0000InscricaoMunicipal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbReg0000InscricaoSuframa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtReg0000DataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtReg0000DataFinal = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txbReg0000IndPerfil = new System.Windows.Forms.TextBox();
            this.txbReg0000IndAtividade = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbReg0001IndMovimento = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.chkValidarArquivo = new System.Windows.Forms.CheckBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGerarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarArquivo.ForeColor = System.Drawing.Color.White;
            this.btnGerarArquivo.Location = new System.Drawing.Point(14, 587);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(100, 30);
            this.btnGerarArquivo.TabIndex = 14;
            this.btnGerarArquivo.Text = "Gerar Arquivo";
            this.btnGerarArquivo.UseVisualStyleBackColor = false;
            this.btnGerarArquivo.Click += new System.EventHandler(this.btnGerarArquivo_Click);
            // 
            // progressBarProgresso
            // 
            this.progressBarProgresso.Location = new System.Drawing.Point(601, 587);
            this.progressBarProgresso.Name = "progressBarProgresso";
            this.progressBarProgresso.Size = new System.Drawing.Size(371, 30);
            this.progressBarProgresso.TabIndex = 1;
            // 
            // lblProgresso
            // 
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.Location = new System.Drawing.Point(537, 587);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(57, 13);
            this.lblProgresso.TabIndex = 2;
            this.lblProgresso.Text = "Progresso:";
            // 
            // rtbResultado
            // 
            this.rtbResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbResultado.Location = new System.Drawing.Point(348, 50);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.ReadOnly = true;
            this.rtbResultado.Size = new System.Drawing.Size(624, 531);
            this.rtbResultado.TabIndex = 16;
            this.rtbResultado.Text = "";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(345, 34);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(347, 587);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTotalLinhas
            // 
            this.lblTotalLinhas.AutoSize = true;
            this.lblTotalLinhas.Location = new System.Drawing.Point(428, 587);
            this.lblTotalLinhas.Name = "lblTotalLinhas";
            this.lblTotalLinhas.Size = new System.Drawing.Size(79, 13);
            this.lblTotalLinhas.TabIndex = 2;
            this.lblTotalLinhas.Text = "Total de linhas:";
            // 
            // lblTotalLinhasArquivo
            // 
            this.lblTotalLinhasArquivo.AutoSize = true;
            this.lblTotalLinhasArquivo.Location = new System.Drawing.Point(428, 604);
            this.lblTotalLinhasArquivo.Name = "lblTotalLinhasArquivo";
            this.lblTotalLinhasArquivo.Size = new System.Drawing.Size(73, 13);
            this.lblTotalLinhasArquivo.TabIndex = 2;
            this.lblTotalLinhasArquivo.Text = "000000 linhas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(120, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblProgressoValor
            // 
            this.lblProgressoValor.AutoSize = true;
            this.lblProgressoValor.Location = new System.Drawing.Point(551, 604);
            this.lblProgressoValor.Name = "lblProgressoValor";
            this.lblProgressoValor.Size = new System.Drawing.Size(30, 13);
            this.lblProgressoValor.TabIndex = 2;
            this.lblProgressoValor.Text = "00 %";
            this.lblProgressoValor.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cód. de Versão";
            // 
            // txbReg0000CodigoVersao
            // 
            this.txbReg0000CodigoVersao.Location = new System.Drawing.Point(9, 32);
            this.txbReg0000CodigoVersao.Name = "txbReg0000CodigoVersao";
            this.txbReg0000CodigoVersao.Size = new System.Drawing.Size(293, 20);
            this.txbReg0000CodigoVersao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cód. de Finalidade";
            // 
            // txbReg0000CodigoFinalidade
            // 
            this.txbReg0000CodigoFinalidade.Location = new System.Drawing.Point(9, 71);
            this.txbReg0000CodigoFinalidade.Name = "txbReg0000CodigoFinalidade";
            this.txbReg0000CodigoFinalidade.Size = new System.Drawing.Size(293, 20);
            this.txbReg0000CodigoFinalidade.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Razão Social";
            // 
            // txbReg0000RazaoSocial
            // 
            this.txbReg0000RazaoSocial.Location = new System.Drawing.Point(9, 188);
            this.txbReg0000RazaoSocial.Name = "txbReg0000RazaoSocial";
            this.txbReg0000RazaoSocial.Size = new System.Drawing.Size(293, 20);
            this.txbReg0000RazaoSocial.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CNPJ";
            // 
            // txbReg0000Cnpj
            // 
            this.txbReg0000Cnpj.Location = new System.Drawing.Point(9, 227);
            this.txbReg0000Cnpj.Name = "txbReg0000Cnpj";
            this.txbReg0000Cnpj.Size = new System.Drawing.Size(293, 20);
            this.txbReg0000Cnpj.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CPF";
            // 
            // txbReg0000Cpf
            // 
            this.txbReg0000Cpf.Location = new System.Drawing.Point(9, 266);
            this.txbReg0000Cpf.Name = "txbReg0000Cpf";
            this.txbReg0000Cpf.Size = new System.Drawing.Size(293, 20);
            this.txbReg0000Cpf.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "UF";
            // 
            // txbReg0000Uf
            // 
            this.txbReg0000Uf.Location = new System.Drawing.Point(9, 305);
            this.txbReg0000Uf.Name = "txbReg0000Uf";
            this.txbReg0000Uf.Size = new System.Drawing.Size(293, 20);
            this.txbReg0000Uf.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "I.E.";
            // 
            // txbReg0000InscricaoEstadual
            // 
            this.txbReg0000InscricaoEstadual.Location = new System.Drawing.Point(9, 344);
            this.txbReg0000InscricaoEstadual.Name = "txbReg0000InscricaoEstadual";
            this.txbReg0000InscricaoEstadual.Size = new System.Drawing.Size(293, 20);
            this.txbReg0000InscricaoEstadual.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Código de Município";
            // 
            // txbReg0000CodigoMunicipioIbge
            // 
            this.txbReg0000CodigoMunicipioIbge.Location = new System.Drawing.Point(9, 383);
            this.txbReg0000CodigoMunicipioIbge.Name = "txbReg0000CodigoMunicipioIbge";
            this.txbReg0000CodigoMunicipioIbge.Size = new System.Drawing.Size(293, 20);
            this.txbReg0000CodigoMunicipioIbge.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Inscrição Municipal";
            // 
            // txbReg0000InscricaoMunicipal
            // 
            this.txbReg0000InscricaoMunicipal.Location = new System.Drawing.Point(9, 422);
            this.txbReg0000InscricaoMunicipal.Name = "txbReg0000InscricaoMunicipal";
            this.txbReg0000InscricaoMunicipal.Size = new System.Drawing.Size(293, 20);
            this.txbReg0000InscricaoMunicipal.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "SUFRAMA";
            // 
            // txbReg0000InscricaoSuframa
            // 
            this.txbReg0000InscricaoSuframa.Location = new System.Drawing.Point(9, 461);
            this.txbReg0000InscricaoSuframa.Name = "txbReg0000InscricaoSuframa";
            this.txbReg0000InscricaoSuframa.Size = new System.Drawing.Size(293, 20);
            this.txbReg0000InscricaoSuframa.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Indicador de Perfil";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Indicador de Atividade";
            // 
            // dtReg0000DataInicial
            // 
            this.dtReg0000DataInicial.Location = new System.Drawing.Point(9, 110);
            this.dtReg0000DataInicial.Name = "dtReg0000DataInicial";
            this.dtReg0000DataInicial.Size = new System.Drawing.Size(293, 20);
            this.dtReg0000DataInicial.TabIndex = 2;
            // 
            // dtReg0000DataFinal
            // 
            this.dtReg0000DataFinal.Location = new System.Drawing.Point(9, 149);
            this.dtReg0000DataFinal.Name = "dtReg0000DataFinal";
            this.dtReg0000DataFinal.Size = new System.Drawing.Size(293, 20);
            this.dtReg0000DataFinal.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Data Inicial";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Data Final";
            // 
            // txbReg0000IndPerfil
            // 
            this.txbReg0000IndPerfil.Location = new System.Drawing.Point(9, 500);
            this.txbReg0000IndPerfil.Name = "txbReg0000IndPerfil";
            this.txbReg0000IndPerfil.Size = new System.Drawing.Size(140, 20);
            this.txbReg0000IndPerfil.TabIndex = 12;
            // 
            // txbReg0000IndAtividade
            // 
            this.txbReg0000IndAtividade.Location = new System.Drawing.Point(162, 500);
            this.txbReg0000IndAtividade.Name = "txbReg0000IndAtividade";
            this.txbReg0000IndAtividade.Size = new System.Drawing.Size(140, 20);
            this.txbReg0000IndAtividade.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(15, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 569);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txbReg0000CodigoVersao);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txbReg0000IndAtividade);
            this.tabPage1.Controls.Add(this.txbReg0000Uf);
            this.tabPage1.Controls.Add(this.txbReg0000IndPerfil);
            this.tabPage1.Controls.Add(this.dtReg0000DataFinal);
            this.tabPage1.Controls.Add(this.txbReg0000InscricaoSuframa);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txbReg0000InscricaoMunicipal);
            this.tabPage1.Controls.Add(this.dtReg0000DataInicial);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txbReg0000CodigoMunicipioIbge);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txbReg0000InscricaoEstadual);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txbReg0000CodigoFinalidade);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txbReg0000Cpf);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txbReg0000Cnpj);
            this.tabPage1.Controls.Add(this.txbReg0000RazaoSocial);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(316, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "0000";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(316, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "0001 - 0005 - 0015";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbReg0001IndMovimento);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO 0001";
            // 
            // txbReg0001IndMovimento
            // 
            this.txbReg0001IndMovimento.Location = new System.Drawing.Point(6, 44);
            this.txbReg0001IndMovimento.Name = "txbReg0001IndMovimento";
            this.txbReg0001IndMovimento.Size = new System.Drawing.Size(292, 20);
            this.txbReg0001IndMovimento.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Indicador de Movimento";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(316, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "0100";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(707, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 29);
            this.label15.TabIndex = 19;
            this.label15.Text = "SPEDBr";
            // 
            // chkValidarArquivo
            // 
            this.chkValidarArquivo.AutoSize = true;
            this.chkValidarArquivo.Checked = true;
            this.chkValidarArquivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkValidarArquivo.Location = new System.Drawing.Point(232, 595);
            this.chkValidarArquivo.Name = "chkValidarArquivo";
            this.chkValidarArquivo.Size = new System.Drawing.Size(106, 17);
            this.chkValidarArquivo.TabIndex = 20;
            this.chkValidarArquivo.Text = "Validar registros?";
            this.chkValidarArquivo.UseVisualStyleBackColor = true;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVersao.Location = new System.Drawing.Point(821, 9);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(151, 29);
            this.lblVersao.TabIndex = 19;
            this.lblVersao.Text = "v.0.00.00.00";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 626);
            this.Controls.Add(this.chkValidarArquivo);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTotalLinhasArquivo);
            this.Controls.Add(this.lblTotalLinhas);
            this.Controls.Add(this.lblProgressoValor);
            this.Controls.Add(this.lblProgresso);
            this.Controls.Add(this.progressBarProgresso);
            this.Controls.Add(this.btnGerarArquivo);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPEDBr";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarArquivo;
        private System.Windows.Forms.ProgressBar progressBarProgresso;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTotalLinhas;
        private System.Windows.Forms.Label lblTotalLinhasArquivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblProgressoValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbReg0000CodigoVersao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbReg0000CodigoFinalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbReg0000RazaoSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbReg0000Cnpj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbReg0000Cpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbReg0000Uf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbReg0000InscricaoEstadual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbReg0000CodigoMunicipioIbge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbReg0000InscricaoMunicipal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbReg0000InscricaoSuframa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtReg0000DataInicial;
        private System.Windows.Forms.DateTimePicker dtReg0000DataFinal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbReg0000IndPerfil;
        private System.Windows.Forms.TextBox txbReg0000IndAtividade;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkValidarArquivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbReg0001IndMovimento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblVersao;
    }
}