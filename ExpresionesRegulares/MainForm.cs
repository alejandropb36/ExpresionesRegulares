using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ExpresionesRegulares
{
    public partial class MainForm : Form
    {
        private Regex ip;
        private Regex mac;
        private Regex curp;
        private Regex fracciones;
        private Regex horaAmPm;
        private Regex hora;



        public MainForm()
        {
            ip = new Regex(@"([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}");
            fracciones = new Regex(@"\-?\d+(\.\d)?(\/\-?\d+(\.\d+)?)");
            InitializeComponent();
        }

        private void buttonValidr_Click(object sender, EventArgs e)
        {
            string entrada = textBoxEntrada.Text;

            //switch (entrada)
            //{
            //    case 1:
            //        break;
            //}
        }
    }
}
