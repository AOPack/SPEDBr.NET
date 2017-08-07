using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpedBr.AppTeste
{
    public partial class frmPrincipal : Form, IMessageFilter
    {
        private Panel _pnlRight;

        public frmPrincipal()
        {
            InitializeComponent();
            //transparentTabControl1.MakeTransparent();
            //transparentTabControl1.BackColor = Color.Transparent;

            Application.AddMessageFilter(this);

            //controlsToMove.Add(this);
            _controlsToMove.Add(this.pnlTopo);//Add whatever controls here you want to move the form when it is clicked and dragged
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private readonly HashSet<Control> _controlsToMove = new HashSet<Control>();

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN &&
                 _controlsToMove.Contains(Control.FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.Image = new Bitmap(SpedBr.AppTeste.Properties.Resources.Maximize_Window_26px_w8_white);
                btnMaximize.Update();
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.Image = new Bitmap(SpedBr.AppTeste.Properties.Resources.Restore_Window_26px_w8_white);
                btnMaximize.Update();
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/samuelrochaoliveira/SPEDBr");
        }

        private void lblDonate_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FDBYCQDQ368KA");
        }

        private void lblSystemInformation_Click(object sender, EventArgs e)
        {
            //if (_pnlRight == null)
            //{
            //    _pnlRight = new Panel();
            //    _pnlRight.BackColor = Color.Transparent;
            //    _pnlRight.Dock = DockStyle.Right;
            //    _pnlRight.Height = 100;
            //    _pnlRight.Width = 200;

            //    var lblInformations = new Label();

            //    lblInformations.Text = "SystemInformation:<br/>" + SystemInformation();

            //    _pnlRight.Controls.Add(lblInformations);

            //    this.Controls.Add(_pnlRight);

            //    _pnlRight.BringToFront();
            //    _pnlRight.Update();
            //}

            textBox1.Text = "SystemInformation:<br/>" + SystemInformation();
        }

        private string SystemInformation()
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            try
            {
                sb.AppendFormat("Operation System: {0}<br/>", Environment.OSVersion);
                if (Environment.Is64BitOperatingSystem)
                    sb.AppendFormat("64 Bit Operating System<br/>");
                else
                    sb.AppendFormat("32 Bit Operating System<br/>");
                sb.AppendFormat("SystemDirectory: {0}<br/>", Environment.SystemDirectory);
                sb.AppendFormat("ProcessorCount: {0}<br/>", Environment.ProcessorCount);
                sb.AppendFormat("UserDomainName: {0}<br/>", Environment.UserDomainName);
                sb.AppendFormat("UserName: {0}<br>", Environment.UserName);
                //Drives
                sb.AppendFormat("LogicalDrives:<br>");
                foreach (System.IO.DriveInfo driveInfo in System.IO.DriveInfo.GetDrives())
                {
                    try
                    {
                        sb.AppendFormat("Drive: {0}<br/>VolumeLabel: {1}<br/>DriveType: {2}<br/>DriveFormat: " +
                            "{3}<br/>TotalSize: {4}<br/>AvailableFreeSpace: {5}<br/>",
                            driveInfo.Name, driveInfo.VolumeLabel, driveInfo.DriveType,
                            driveInfo.DriveFormat, driveInfo.TotalSize, driveInfo.AvailableFreeSpace);
                    }
                    catch
                    {
                    }
                }
                sb.AppendFormat("SystemPageSize: {0}<br/>", Environment.SystemPageSize);
                sb.AppendFormat("Version: {0}", Environment.Version);
            }
            catch
            {
            }
            return sb.ToString();
        }
    }
}
