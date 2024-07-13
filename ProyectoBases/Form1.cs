using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ProyectoBases
{
    public partial class FENAL : Form
    {
        // instruccion para conectar a la base
        // crear objeto "con" e indicar atributos server, database, uid y password
        MySqlConnection con = new MySqlConnection("SERVER=LOCALHOST; DATABASE=Feria_Leon; UID=root; PASSWORD=escom;");

        public FENAL()
        {
            InitializeComponent();
        }

        void viewGridData()
        {
            try
            {
                // al dar click, se crea un objeto que muestra la tabla seleccionadas
                MySqlDataAdapter da = new MySqlDataAdapter("select * from Personal", con);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }

        void ClearTextBox()
        {
            RFC_tx.Clear();
            Nombre_tx.Clear();
            Edad_tx.Clear();
            IdActividad_tx.Clear();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)
        {
            viewGridData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Insertar_bt_Click(object sender, EventArgs e)
        {
            try
            {
                // al dar click, se crea un objeto que inserta elemento con los atributos escritos
                MySqlDataAdapter da = new MySqlDataAdapter("insert into Personal(RFC, Nombre, Edad, idActividad) values('"+RFC_tx.Text+"', '"+Nombre_tx.Text+"', "+Edad_tx.Text+", "+IdActividad_tx.Text+")", con);

                DataSet ds = new DataSet();

                da.Fill(ds);

                MessageBox.Show("Insertado Correctamente");

                viewGridData();
                ClearTextBox();

                RFC_tx.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }

        private void Modificar_bt_Click(object sender, EventArgs e)
        {
            try
            {
                string update = " update Personal set RFC = '" + RFC_tx.Text + "', Nombre = '" + Nombre_tx.Text + "', Edad = " + Edad_tx.Text + ", idActividad = " + IdActividad_tx.Text + " where idPersonal = "+dataGridView1.SelectedRows[0].Cells[0].Value + " ";

                // al dar click, se crea un objeto que inserta elemento con los atributos escritos
                MySqlDataAdapter da = new MySqlDataAdapter(update, con);

                DataSet ds = new DataSet();

                da.Fill(ds);

                MessageBox.Show("Modificado Correctamente");

                viewGridData();
                ClearTextBox();

                RFC_tx.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }

        private void borrar_bt_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = " delete from Personal where idPersonal = " + dataGridView1.SelectedRows[0].Cells[0].Value + " ";

                // al dar click, se crea un objeto que elimina elemento con los atributos escritos
                MySqlDataAdapter da = new MySqlDataAdapter(delete, con);

                DataSet ds = new DataSet();

                da.Fill(ds);

                MessageBox.Show("Eliminado Correctamente");

                viewGridData();
                ClearTextBox();

                RFC_tx.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RFC_tx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_tx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edad_tx_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdActividad_tx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
