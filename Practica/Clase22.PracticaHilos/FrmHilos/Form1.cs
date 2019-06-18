using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmHilos
{
    public partial class Form1 : Form
    {
        int contadorA;
        int contadorB;
        int contadorC;
        int contadorD;
        bool clickA;
        bool clickB;
        bool clickC;
        bool clickD;

        public Form1()
        {
            InitializeComponent();
            contadorA = 0;
            contadorB = 0;
            contadorC = 0;
            contadorD = 0;
            clickA = false;
            clickB = false;
            clickC = false;
            clickD = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (!clickA)
            {
                txtUno.Text = contadorA++.ToString();
            }
        }
        private void btnUno_Click(object sender, EventArgs e)
        {
            clickA = !clickA;
        }
    }
}
