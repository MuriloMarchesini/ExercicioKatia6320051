using System;
using System.CodeDom;
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
        

        private void Mostraropcoes()
        {
            foreach (var opcao in Enum.GetValues(typeof(Opcaopasseio)))
            {
                ListAtividades.Items.Add(opcao);
            }
        }
        
        public enum Opcaopasseio
        {
            Buggy,
            Trilha,
            Lancha
        }
        List<Consumo> Lista;
        Consumo consumo = new Consumo();
        public void PreencherLista()
        {
            Consumo novoConsumo = new Consumo();
            novoConsumo.NumeroQuarto = TxtNumQuarto.Text;
            novoConsumo.Refeição = TxtRefeicao.Text;
            novoConsumo.Refri = TxtRefri.Text;
            novoConsumo.Suco = TxtSuco.Text;
            novoConsumo.Sobremesa = TxtSobremesa.Text;
            novoConsumo.Buggy = 

            Lista.Add(novoConsumo);

        }
        private bool VerificarBuggySelecionado()
        {
            foreach (var item in ListAtividades.CheckedItems)
            {
                if (item.ToString() == Opcaopasseio.Buggy.ToString())
                {
                    // "Buggy" está selecionado
                    return true;
                    novoConsumo.

                }
            }
            return false;
        }
        public Form1()
        {
            
            Lista = new List<Consumo>();
            InitializeComponent();
            Mostraropcoes();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            PreencherLista();
            MessageBox.Show("Salvo com sucesso");
            
        }

        private void button1_Click(object sender, EventArgs e) //botão pesquisar no windows forms
        {
            string numeroquartoprocurado = TxtNumQuarto.Text.Trim();
            bool existequarto = Lista.Exists(consumo => consumo.NumeroQuarto == numeroquartoprocurado);

            if (existequarto)
            {
                MessageBox.Show($"Valor dos Passeios:{"Passeios"}\nValor Consumido:{"valor do consumo"}\nValor Total:{"Valor total"}");
            }
            else
            {
                MessageBox.Show("Número do quarto não encontrado");
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
