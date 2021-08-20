
namespace ExercicioFM
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
            this.dtMstrar = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGanhos = new System.Windows.Forms.TextBox();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.btnCaucula = new System.Windows.Forms.Button();
            this.IDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDsespesacol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Despesasdomescol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganhocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquidoColl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selucroucol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtMstrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMstrar
            // 
            this.dtMstrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMstrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcol,
            this.ValorDsespesacol,
            this.Despesasdomescol,
            this.Ganhocol,
            this.ValorLiquidoColl,
            this.Selucroucol});
            this.dtMstrar.Location = new System.Drawing.Point(-1, 107);
            this.dtMstrar.Name = "dtMstrar";
            this.dtMstrar.Size = new System.Drawing.Size(701, 204);
            this.dtMstrar.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(605, 404);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExercicioFM.Properties.Resources.viacredi;
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-10, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 72);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 33);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista de do banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ganhos do mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Despesas do mes";
            // 
            // txtGanhos
            // 
            this.txtGanhos.Location = new System.Drawing.Point(194, 345);
            this.txtGanhos.Name = "txtGanhos";
            this.txtGanhos.Size = new System.Drawing.Size(181, 20);
            this.txtGanhos.TabIndex = 7;
            // 
            // txtDespesas
            // 
            this.txtDespesas.Location = new System.Drawing.Point(194, 381);
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(181, 20);
            this.txtDespesas.TabIndex = 8;
            // 
            // btnCaucula
            // 
            this.btnCaucula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(118)))), ((int)(((byte)(18)))));
            this.btnCaucula.Location = new System.Drawing.Point(400, 362);
            this.btnCaucula.Name = "btnCaucula";
            this.btnCaucula.Size = new System.Drawing.Size(75, 23);
            this.btnCaucula.TabIndex = 9;
            this.btnCaucula.Text = "Caucula";
            this.btnCaucula.UseVisualStyleBackColor = false;
            this.btnCaucula.Click += new System.EventHandler(this.btnCaucula_Click);
            // 
            // IDcol
            // 
            this.IDcol.HeaderText = "ID";
            this.IDcol.Name = "IDcol";
            this.IDcol.Width = 50;
            // 
            // ValorDsespesacol
            // 
            this.ValorDsespesacol.HeaderText = "Valor em caixa";
            this.ValorDsespesacol.Name = "ValorDsespesacol";
            // 
            // Despesasdomescol
            // 
            this.Despesasdomescol.HeaderText = "Despeas do mes";
            this.Despesasdomescol.Name = "Despesasdomescol";
            this.Despesasdomescol.Width = 150;
            // 
            // Ganhocol
            // 
            this.Ganhocol.HeaderText = "Ganho  do mes";
            this.Ganhocol.Name = "Ganhocol";
            this.Ganhocol.Width = 150;
            // 
            // ValorLiquidoColl
            // 
            this.ValorLiquidoColl.HeaderText = "Valor Liquido";
            this.ValorLiquidoColl.Name = "ValorLiquidoColl";
            // 
            // Selucroucol
            // 
            this.Selucroucol.HeaderText = "Se lucrou ";
            this.Selucroucol.Name = "Selucroucol";
            // 
            // Exec03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(694, 439);
            this.Controls.Add(this.btnCaucula);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.txtGanhos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dtMstrar);
            this.Name = "Exec03";
            this.Text = "Exec03";
            this.Load += new System.EventHandler(this.Exec03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMstrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMstrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGanhos;
        private System.Windows.Forms.TextBox txtDespesas;
        private System.Windows.Forms.Button btnCaucula;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDsespesacol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Despesasdomescol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ganhocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiquidoColl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selucroucol;
    }
}