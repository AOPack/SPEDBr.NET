using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpedBr.AppTeste
{
    public partial class ucLeftPanel : UserControl
    {
        public enum UserControlsSistema
        {
            UserControlHome,
            UserControlSintegra,
            UserControlSped
        }

        public ucLeftPanel()
        {
            InitializeComponent();

            LimparPersonalizacaoBotoes();

            btnHome.MouseClick += (sender, args) =>
            {
                CarregarUserControl(UserControlsSistema.UserControlHome);

                PersonalizarBotaoMouseClick(sender as Button);
            };

            btnHome.MouseLeave += (sender, args) => { PersonalizarBotaoMouseLeave(sender as Button); };
            btnHome.MouseMove += (sender, args) => { PersonalizarBotaoMouseMove(sender as Button); };

            btnSintegra.MouseClick += (sender, args) =>
            {
                CarregarUserControl(UserControlsSistema.UserControlSintegra);

                PersonalizarBotaoMouseClick(sender as Button);
            };

            btnSintegra.MouseLeave += (sender, args) => { PersonalizarBotaoMouseLeave(sender as Button); };
            btnSintegra.MouseMove += (sender, args) => { PersonalizarBotaoMouseMove(sender as Button); };

            btnSpedFiscal.MouseClick += (sender, args) =>
            {
                PersonalizarBotaoMouseClick(sender as Button);
            };

            btnSpedFiscal.MouseLeave += (sender, args) => { PersonalizarBotaoMouseLeave(sender as Button); };
            btnSpedFiscal.MouseMove += (sender, args) => { PersonalizarBotaoMouseMove(sender as Button); };
        }

        private void LimparPersonalizacaoBotoes()
        {
            var controles = flowLayoutPanelLeft.Controls;

            foreach (var controle in controles)
            {
                if (controle.GetType() == typeof(Button))
                {
                    var button = controle as Button;

                    if (button != null)
                        if (!button.Name.ToLower().Contains("menu"))
                        {
                            button.BackColor = SystemColors.Control;

                            button.FlatStyle = FlatStyle.Flat;

                            button.FlatAppearance.BorderSize = 1;
                            button.FlatAppearance.MouseOverBackColor = Color.White;
                            button.FlatAppearance.BorderColor = SystemColors.Control;

                            button.ForeColor = SystemColors.ControlText;

                            button.TextAlign = ContentAlignment.MiddleCenter;
                            button.Font = new Font(button.Font, FontStyle.Regular);

                            //button.UseVisualStyleBackColor = false;

                            button.Margin = new Padding(0);

                            button.Size = new Size(244, 40);
                        }
                }
            }
        }

        private void CarregarUserControl(UserControlsSistema ucSistema)
        {
            switch (ucSistema)
            {
                case UserControlsSistema.UserControlSintegra:
                    if (!splitContainer1.Panel2.Controls.Contains(ucSintegra.Instancia))
                    {
                        splitContainer1.Panel2.Controls.Add(ucSintegra.Instancia);
                        ucSintegra.Instancia.Dock = DockStyle.Fill;
                        ucSintegra.Instancia.BringToFront();
                    }
                    else
                        ucSintegra.Instancia.BringToFront();
                    break;
                case UserControlsSistema.UserControlHome:
                    if (!splitContainer1.Panel2.Controls.Contains(ucHome.Instancia))
                    {
                        splitContainer1.Panel2.Controls.Add(ucHome.Instancia);
                        ucHome.Instancia.Dock = DockStyle.Fill;
                        ucHome.Instancia.BringToFront();
                    }
                    else
                        ucHome.Instancia.BringToFront();
                    break;
            }
        }

        private void PersonalizarBotaoMouseClick(Button btn)
        {
            LimparPersonalizacaoBotoes();

            if (btn == null)
                throw new Exception("Falha ao personalizar menu lateral!");

            btn.BackColor = Color.White;

            btn.ForeColor = Color.Red;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderColor = Color.White;
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }

        private void PersonalizarBotaoMouseMove(Button btn)
        {
            if (btn == null)   
                throw new Exception("Falha ao personalizar menu lateral!");

            btn.ForeColor = Color.Red;
            btn.FlatAppearance.BorderColor = Color.White;
        }

        private void PersonalizarBotaoMouseLeave(Button btn)
        {
            if (btn == null)
                throw new Exception("Falha ao personalizar menu lateral!");

            btn.ForeColor = SystemColors.ControlText;
            btn.FlatAppearance.BorderColor = SystemColors.Control;
        }

        private void btnSintegra_Click(object sender, EventArgs e)
        {

        }
    }
}
