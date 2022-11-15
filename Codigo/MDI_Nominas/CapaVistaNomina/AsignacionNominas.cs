using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace CapaVistaNomina
{
    public partial class AsignacionNominas : Form
    {
        Controlador cn = new Controlador();
        public AsignacionNominas()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6102";
            TextBox[] Grupotextbox = { textBox1, textBox2, textBox3, textBox4 };
            TextBox[] Idtextbox = { textBox1, textBox2, textBox3, textBox4 };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "FinalExamen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            cn.llenartablaa(dataGridView2.Tag.ToString(), dataGridView2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            cn.llenartablaa(dataGridView3.Tag.ToString(), dataGridView3);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            cn.llenartablaa(dataGridView4.Tag.ToString(), dataGridView4);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            panel1.Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox6.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            panel2.Visible = false;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            textBox7.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            panel3.Visible = false;
        }
    }
}
