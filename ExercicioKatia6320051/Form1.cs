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
        double valorPlancha = 500, valorPbuggy = 300, valorPtrilha = 150;
        double valorTotal, valorTotalRef, valorTotalRefri, valorTotalSuco, valorTotalSobremesa;
        double valortotalLancha, valortotalBuggy, valortotalTrilha;
        double valorbuggy = 0, valortrilha = 0, valorlancha = 0;
        string valorlabel, valorpasseios, valorconsumidototal;

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
            
            Lista.Add(novoConsumo);

        }
        public void VerificarBuggySelecionado(object sender, ItemCheckEventArgs e)
        {
            if (ListAtividades.Items[e.Index].ToString() == "Buggy")
            {
                if (e.NewValue == CheckState.Checked)
                {
                    valorbuggy = 1;
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    valorbuggy = 0;
                }
            }
        }
        public void VerificarTrilhaSelecionado(object sender, ItemCheckEventArgs e)
        {
            if (ListAtividades.Items[e.Index].ToString() == "Trilha")
            {
                if (e.NewValue == CheckState.Checked)
                {
                    valortrilha = 1;
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    valortrilha = 0;
                }

            }
        }
        private void LimparDados()
        {
            TxtRefeicao.Text = "";
            TxtRefri.Text = "";
            TxtSuco.Text = "";
            TxtSobremesa.Text = "";
            TxtNumQuarto.Text = "";

            for (int i = 0; i < ListAtividades.Items.Count; i++)
            {
                ListAtividades.SetItemChecked(i, false);
            }
        }

        private void TxtValorTotal_TextChanged(object sender, EventArgs e)
        {
            Calcular();
            TxtValorTotal.Text = ( $"Valor Total: R${valorlabel}");

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
            TxtValorTotal.Text = ($"Valor Total: R${valorlabel}");
        }

        public void VerificarLanchaSelecionado(object sender, ItemCheckEventArgs e)
        {
                valorlancha = 0;

            if (e.NewValue == CheckState.Checked && ListAtividades.Items[e.Index].ToString() == "Lancha")
            {
                valorlancha = 1;
            }
        }
        public void Calcular()
        {
            double.TryParse(TxtRefeicao.Text, out double valorRefeicao);
            double.TryParse(TxtRefri.Text, out double valorRefri);
            double.TryParse(TxtSuco.Text, out double valorSuco);
            double.TryParse(TxtSobremesa.Text, out double valorSobremesa);

            valorTotalRef = (valorRefeicao * 20);
            valorTotalRefri = (valorRefri * 6);
            valorTotalSuco = (valorSuco * 5);
            valorTotalSobremesa = (valorSobremesa * 15);

            valortotalBuggy = (valorbuggy * valorPbuggy);
            valortotalTrilha = (valortrilha * valorPtrilha);
            valortotalLancha = (valorlancha * valorPlancha);

            var valorLabel = (valorTotalRef + valorTotalRefri + valorTotalSuco + valorTotalSobremesa + valortotalBuggy + valortotalTrilha + valortotalLancha);
            valorlabel = Convert.ToString(valorLabel);
            var valorPasseios = valortotalBuggy + valortotalTrilha + valortotalLancha;
            valorpasseios = Convert.ToString(valorPasseios);
            var valorConsumo = (valorTotalRef + valorTotalRefri + valorTotalSuco + valorTotalSobremesa);
            valorconsumidototal = Convert.ToString(valorConsumo); ;

        }
        public Form1()
        {
            
            Lista = new List<Consumo>();
            InitializeComponent();
            Mostraropcoes();
            ListAtividades.ItemCheck += VerificarBuggySelecionado;
            ListAtividades.ItemCheck += VerificarTrilhaSelecionado;
            ListAtividades.ItemCheck += VerificarLanchaSelecionado;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNumQuarto.Text))
            {
                MessageBox.Show("Preencha o número do quarto");
            }
            else
            {
                PreencherLista();
                MessageBox.Show("Salvo com sucesso");
                LimparDados();                      
            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroquartoprocurado = TxtNumQuarto.Text.Trim();

            Consumo consumoEncontrado = Lista.Find(consumo => consumo.NumeroQuarto == numeroquartoprocurado);

            if (consumoEncontrado != null)
            {
             
                Calcular(consumoEncontrado);

                MessageBox.Show($"Numero Do Quarto:{consumoEncontrado.NumeroQuarto}\nValor dos Passeios:{valorpasseios}\nValor Consumido:{valorconsumidototal}\nValor Total:{valorlabel}");
            }
            else
            {
                MessageBox.Show("Número do quarto não encontrado");
            }
        }

        
        public void Calcular(Consumo consumo)
        {
            
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
