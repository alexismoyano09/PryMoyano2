using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMoyano2
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classpersonaje objeto = new Classpersonaje();

            objeto.nombre = txtnombre.Text;
            objeto.fuerza = Convert.ToInt32(txtfuerza.Text);
            objeto.destreza = int.Parse( txtdestreza.Text);

            lblinfo.Text += objeto.nombre + "-" +
                objeto.fuerza + "-" +
                objeto.destreza + "\n";

        }
    }
}
