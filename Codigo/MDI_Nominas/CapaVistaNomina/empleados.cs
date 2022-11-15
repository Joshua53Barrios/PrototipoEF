using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorNomina;

namespace CapaVistaNomina
{
    public partial class empleados : Form
       
    {
        public empleados()
        {
            InitializeComponent();
        }
        Controlador cn = new Controlador();
        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6101";
            TextBox[] Grupotextbox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6};
            TextBox[] Idtextbox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox7.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            panel1.Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox8.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            panel2.Visible = false;
        }
    }
}
