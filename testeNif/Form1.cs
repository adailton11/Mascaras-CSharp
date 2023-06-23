using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeNif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Adicionando uma mascara numa textBox usando o regex. 
            Regex reg = new Regex(@"^([0-9]{9}([LA]{2}|[KN]{2}|[KS]{2}|[HB]{2}|[LN]{2}|[LS]{2}|[KK]{2}|[MX]{2}|[ZR]{2}|[UG]{2})[0-9]{3}$)");

            Match Match = reg.Match(texNIF.Text);

            if (Match.Success)
            {
                String stringNIF;
                stringNIF = texNIF.Text;
                MessageBox.Show("O TEU NIF:",stringNIF);
                  
            }

            else
            {
                MessageBox.Show("NIF INCORRETO. POR FAVOR VERIFIQUE-O, Formato de NIF CORRECTO ANGOLANO: 006106303KS057 ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
