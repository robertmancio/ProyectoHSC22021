using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{   
    public partial class frmEnlaceContableVentas : Form
    {
        conEnlaceVentas con = new conEnlaceVentas();
        public frmEnlaceContableVentas()
        {
            InitializeComponent();
            llenarcbxTipoPoliza();
            llenarcbxCuenta();
            llenarcbxTipoOperacion();
            groupBox1.Enabled = false;
            CenterToScreen();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Llenando combobox de tipo poliza
        public void llenarcbxTipoPoliza()
        {
            try
            {
                comboBox1.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxTipoPoliza();
                comboBox1.Items.Add("Selecione un Tipo de Poliza");
                while (datareader.Read())
                {
                    comboBox1.Items.Add(datareader[0].ToString());
                }
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        //Llenando combobox de cuenta
        public void llenarcbxCuenta()
        {
            try
            {
                comboBox2.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxCuenta();
                comboBox2.Items.Add("Selecione un Cuenta");
                while (datareader.Read())
                {
                    comboBox2.Items.Add(datareader[0].ToString());
                }
                comboBox2.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenarcbxTipoOperacion()
        {
            try
            {
                comboBox3.Items.Clear();
                OdbcDataReader datareader = con.llenarcbxTipoOperacion();
                comboBox3.Items.Add("Selecione un Tipo de Operación");
                while (datareader.Read())
                {
                    comboBox3.Items.Add(datareader[0].ToString());
                }
                comboBox3.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }


        //Obteniendo ID de Tipo Poliza
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                textBox5.Text = consultaTipoPoliza(comboBox1.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        public string consultaTipoPoliza(string nombre)
        {
            string id_modulo = con.consultaTipoPoliza(nombre);

            return id_modulo;
        }

        //Obteniendo ID de Cuenta
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                textBox6.Text = consultaCuenta(comboBox2.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        public string consultaCuenta(string nombre)
        {
            string id_modulo = con.consultaCuenta(nombre);

            return id_modulo;
        }

        //Obteniendo ID de TipoOperacion
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                textBox7.Text = consultaTipoOperacion(comboBox3.Text.ToString());



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        public string consultaTipoOperacion(string nombre)
        {
            string id_modulo = con.consultaTipoOperacion(nombre);

            return id_modulo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string fecha = dateTimePicker3.Value.ToString("yyyy-MM-dd");

                con.insertarEncabezado( textBox1.Text, fecha, textBox5.Text, textBox2.Text);
                MessageBox.Show("Insercion realizada");

                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Debes llenar todos los campos");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            try
            {
                

                con.insertarDetalle(textBox3.Text, textBox1.Text, textBox6.Text, textBox4.Text, textBox7.Text);
                MessageBox.Show("Insercion realizada");

                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void funLimpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            funLimpiar();
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            MessageBox.Show("Partida Finalizada con exito");
        }
    }
}
