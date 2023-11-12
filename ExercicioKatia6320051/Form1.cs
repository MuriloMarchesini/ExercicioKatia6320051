using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioKatia6320051
{
    public partial class Form1 : Form
    {
        List<Consumo> list;
        public Form1()
        {
            
            list = new List<Consumo>();
            InitializeComponent();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            var data = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            list.Add(new Consumo(TxtNumQuarto));    
        }
    }
}
