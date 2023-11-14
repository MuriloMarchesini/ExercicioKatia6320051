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
        List<Consumo> Lista;
        Consumo consumo = new Consumo();
        public Form1()
        {
            
            Lista = new List<Consumo>();
            InitializeComponent();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Lista.Add(new Consumo());
            MessageBox.Show("Salvo com sucesso");
            string numeroQuarto = consumo.NumeroQuarto;
            TxtNumQuarto.Text = numeroQuarto;


        }

        private void button1_Click(object sender, EventArgs e) //botão pesquisar no windows forms
        {
            if (Lista.Equals(consumo.NumeroQuarto))
            {
                MessageBox.Show ("Numero certo");
            }  
            else
            {
                MessageBox.Show("Numero errado");
            }
        }

        private void ListAtividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtNumQuarto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtNumQuarto_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
