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
    public partial class Bitacora : Form
    {
        
        public Bitacora()
        {
            InitializeComponent();
        }
        Controlador cn = new Controlador();
        private void button1_Click(object sender, EventArgs e)
        {
            cn.bitacora(dataGridView1.Tag.ToString(), dataGridView1);
        }
    }
}
