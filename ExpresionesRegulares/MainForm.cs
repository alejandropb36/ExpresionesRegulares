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
        int opcion;



        public MainForm()
        {
            ip = new Regex(@"([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}");
            fracciones = new Regex(@"(\d+(\.\d)?)/(\d+(\.\d)?)");
            horaAmPm = new Regex(@"((0[0-9])|(1[0-2])):([0-5][0-9])\s((am)|(pm))");
            hora = new Regex(@"(0[0-9])|(1[0-9])|(2[0-3]):([0-5][0-9])\shrs");
            curp = new Regex(@"[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}" +
                                "(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])" +
                                "[HM]{1}" +
                                "(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)" +
                                "[B-DF-HJ-NP-TV-Z]{3}" +
                                "[0-9A-Z]{1}[0-9]{1}");
            mac = new Regex(@"(([0-9]|[A-F]){2}:){5}([0-9]|[A-F]){2}");
            opcion = 0;
            InitializeComponent();
        }

        private void buttonValidr_Click(object sender, EventArgs e)
        {
            string entrada = textBoxEntrada.Text;

            opcion = comboBox1.SelectedIndex;

            switch (opcion)
            {
                case 0:
                    if (horaAmPm.IsMatch(entrada))
                    {
                        labelMessage.Text = "Hora en formato 12 hrs correcto";
                    }
                    else
                    {
                        labelMessage.Text = "Hora en formato 12 hrs incorrecto!";
                    }
                    break;
                case 1:
                    if (hora.IsMatch(entrada))
                    {
                        labelMessage.Text = "Hora en formato 24 hrs correcto";
                    }
                    else
                    {
                        labelMessage.Text = "Hora en formato 24 hrs incorrecto!";
                    }
                    break;
                case 2:
                    if (fracciones.IsMatch(entrada))
                    {
                        labelMessage.Text = "Fracción correcta";
                    }
                    else
                    {
                        labelMessage.Text = "Fracción incorrecta!";
                    }
                    break;
                case 3:
                    if (curp.IsMatch(entrada))
                    {
                        labelMessage.Text = "CURP correcto";
                    }
                    else
                    {
                        labelMessage.Text = "CURP incorrecto!";
                    }
                    break;
                case 4:
                    if (ip.IsMatch(entrada))
                    {
                        labelMessage.Text = "IP correcto";
                    }
                    else
                    {
                        labelMessage.Text = "IP incorrecto!";
                    }
                    break;
                case 5:
                    if (mac.IsMatch(entrada))
                    {
                        labelMessage.Text = "MAC correcto";
                    }
                    else
                    {
                        labelMessage.Text = "MAC incorrecto!";
                    }
                    break;
            }
        }
    }
}
