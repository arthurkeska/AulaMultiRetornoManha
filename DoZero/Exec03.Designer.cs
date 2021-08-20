
namespace DoZero
{
    partial class Exec03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caloremcaixacol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despesacol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganhoscol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorliquidocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selucroucol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtganhos = new System.Windows.Forms.TextBox();
            this.txtdespesas = new System.Windows.Forms.TextBox();
            this.btncalcula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Caloremcaixacol,
            this.despesacol,
            this.Ganhoscol,
            this.Valorliquidocol,
            this.selucroucol});
            this.dataGridView1.Location = new System.Drawing.Point(141, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 130;
            // 
            // Caloremcaixacol
            // 
            this.Caloremcaixacol.HeaderText = "Valor em caixa";
            this.Caloremcaixacol.Name = "Caloremcaixacol";
            this.Caloremcaixacol.Width = 130;
            // 
            // despesacol
            // 
            this.despesacol.HeaderText = "Despesas do mes";
            this.despesacol.Name = "despesacol";
            this.despesacol.Width = 130;
            // 
            // Ganhoscol
            // 
            this.Ganhoscol.HeaderText = "Ganho do mes";
            this.Ganhoscol.Name = "Ganhoscol";
            this.Ganhoscol.Width = 130;
            // 
            // Valorliquidocol
            // 
            this.Valorliquidocol.HeaderText = "Valor liquido ";
            this.Valorliquidocol.Name = "Valorliquidocol";
            this.Valorliquidocol.Width = 130;
            // 
            // selucroucol
            // 
            this.selucroucol.HeaderText = "Se  lucrou";
            this.selucroucol.Name = "selucroucol";
            this.selucroucol.Width = 130;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSair.Location = new System.Drawing.Point(904, 377);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(146, 102);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(92, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "ganhos do mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(95, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "despesa do mes";
            // 
            // txtganhos
            // 
            this.txtganhos.Location = new System.Drawing.Point(263, 311);
            this.txtganhos.Name = "txtganhos";
            this.txtganhos.Size = new System.Drawing.Size(156, 20);
            this.txtganhos.TabIndex = 4;
            // 
            // txtdespesas
            // 
            this.txtdespesas.Location = new System.Drawing.Point(263, 377);
            this.txtdespesas.Name = "txtdespesas";
            this.txtdespesas.Size = new System.Drawing.Size(156, 20);
            this.txtdespesas.TabIndex = 5;
            // 
            // btncalcula
            // 
            this.btncalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btncalcula.Location = new System.Drawing.Point(730, 380);
            this.btncalcula.Name = "btncalcula";
            this.btncalcula.Size = new System.Drawing.Size(131, 99);
            this.btncalcula.TabIndex = 6;
            this.btncalcula.Text = "Calcula mes";
            this.btncalcula.UseVisualStyleBackColor = true;
            this.btncalcula.Click += new System.EventHandler(this.btncalcula_Click);
            // 
            // Exec03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 491);
            this.Controls.Add(this.btncalcula);
            this.Controls.Add(this.txtdespesas);
            this.Controls.Add(this.txtganhos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Exec03";
            this.Load += new System.EventHandler(this.Exec03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caloremcaixacol;
        private System.Windows.Forms.DataGridViewTextBoxColumn despesacol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ganhoscol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorliquidocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn selucroucol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtganhos;
        private System.Windows.Forms.TextBox txtdespesas;
        private System.Windows.Forms.Button btncalcula;
    }
}