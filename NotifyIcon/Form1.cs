using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Exclamation;

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;

            notifyIcon1.BalloonTipTitle = "NotyApp";

            notifyIcon1.BalloonTipText = "Приложение работает в фоне. Нажмите дважды, чтобы открыть.";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;

                notifyIcon1.Visible = true;

                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        //Кликнуть два раза по иконке уведомление , и приложение снова откроется
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;

            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }
}
