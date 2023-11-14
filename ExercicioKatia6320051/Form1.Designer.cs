namespace ExercicioKatia6320051
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListAtividades = new System.Windows.Forms.CheckedListBox();
            this.TxtValorTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRefeicao = new System.Windows.Forms.TextBox();
            this.TxtRefri = new System.Windows.Forms.TextBox();
            this.TxtSuco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSobremesa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtNumQuarto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.UseWaitCursor = true;
            // 
            // ListAtividades
            // 
            this.ListAtividades.FormattingEnabled = true;
            resources.ApplyResources(this.ListAtividades, "ListAtividades");
            this.ListAtividades.Name = "ListAtividades";
            this.ListAtividades.UseWaitCursor = true;
            this.ListAtividades.SelectedIndexChanged += new System.EventHandler(this.ListAtividades_SelectedIndexChanged);
            // 
            // TxtValorTotal
            // 
            resources.ApplyResources(this.TxtValorTotal, "TxtValorTotal");
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.UseWaitCursor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.UseWaitCursor = true;
            // 
            // TxtRefeicao
            // 
            resources.ApplyResources(this.TxtRefeicao, "TxtRefeicao");
            this.TxtRefeicao.Name = "TxtRefeicao";
            this.TxtRefeicao.UseWaitCursor = true;
            // 
            // TxtRefri
            // 
            resources.ApplyResources(this.TxtRefri, "TxtRefri");
            this.TxtRefri.Name = "TxtRefri";
            this.TxtRefri.UseWaitCursor = true;
            // 
            // TxtSuco
            // 
            resources.ApplyResources(this.TxtSuco, "TxtSuco");
            this.TxtSuco.Name = "TxtSuco";
            this.TxtSuco.UseWaitCursor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.UseWaitCursor = true;
            // 
            // TxtSobremesa
            // 
            resources.ApplyResources(this.TxtSobremesa, "TxtSobremesa");
            this.TxtSobremesa.Name = "TxtSobremesa";
            this.TxtSobremesa.UseWaitCursor = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.UseWaitCursor = true;
            // 
            // BtnSalvar
            // 
            resources.ApplyResources(this.BtnSalvar, "BtnSalvar");
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.UseWaitCursor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.UseWaitCursor = true;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // BtnPesquisar
            // 
            resources.ApplyResources(this.BtnPesquisar, "BtnPesquisar");
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.UseWaitCursor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNumQuarto
            // 
            resources.ApplyResources(this.TxtNumQuarto, "TxtNumQuarto");
            this.TxtNumQuarto.Name = "TxtNumQuarto";
            this.TxtNumQuarto.UseWaitCursor = true;
            this.TxtNumQuarto.TextChanged += new System.EventHandler(this.TxtNumQuarto_TextChanged_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtNumQuarto);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtSobremesa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSuco);
            this.Controls.Add(this.TxtRefri);
            this.Controls.Add(this.TxtRefeicao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtValorTotal);
            this.Controls.Add(this.ListAtividades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ListAtividades;
        private System.Windows.Forms.Label TxtValorTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtRefeicao;
        private System.Windows.Forms.TextBox TxtRefri;
        private System.Windows.Forms.TextBox TxtSuco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSobremesa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtNumQuarto;
    }
}

