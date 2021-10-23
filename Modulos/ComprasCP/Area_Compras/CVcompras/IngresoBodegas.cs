using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCcompras;

namespace CVcompras
{
    public partial class IngresoBodegas : Form
    {
        clscontrolador logi = new clscontrolador();
        public IngresoBodegas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Area_Compras formulario = new Area_Compras();
            formulario.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox3.Text, textBox1.Text, textBox2.Text }; //valores a ingresar
            if (logi.insertar_bodegas(valores) == null)
            {
                MessageBox.Show("Error al ingresar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox3.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
           


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox3.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
