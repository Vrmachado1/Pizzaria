namespace Pizzaria
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
            this.lblSabores = new System.Windows.Forms.Label();
            this.cboSabores = new System.Windows.Forms.ComboBox();
            this.grpIngredientes = new System.Windows.Forms.GroupBox();
            this.chkChampignon = new System.Windows.Forms.CheckBox();
            this.chkAzeitona = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.grpBorda = new System.Windows.Forms.GroupBox();
            this.rdbComBordaCheddar = new System.Windows.Forms.RadioButton();
            this.rdbComBorda = new System.Windows.Forms.RadioButton();
            this.rdbSemBorda = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpIngredientes.SuspendLayout();
            this.grpBorda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSabores
            // 
            this.lblSabores.AutoSize = true;
            this.lblSabores.Location = new System.Drawing.Point(27, 27);
            this.lblSabores.Name = "lblSabores";
            this.lblSabores.Size = new System.Drawing.Size(102, 13);
            this.lblSabores.TabIndex = 0;
            this.lblSabores.Text = "Sabores das Pizzas:";
            this.lblSabores.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboSabores
            // 
            this.cboSabores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabores.FormattingEnabled = true;
            this.cboSabores.Location = new System.Drawing.Point(144, 24);
            this.cboSabores.Name = "cboSabores";
            this.cboSabores.Size = new System.Drawing.Size(121, 21);
            this.cboSabores.Sorted = true;
            this.cboSabores.TabIndex = 1;
            // 
            // grpIngredientes
            // 
            this.grpIngredientes.Controls.Add(this.chkChampignon);
            this.grpIngredientes.Controls.Add(this.chkAzeitona);
            this.grpIngredientes.Controls.Add(this.chkCebola);
            this.grpIngredientes.Location = new System.Drawing.Point(30, 72);
            this.grpIngredientes.Name = "grpIngredientes";
            this.grpIngredientes.Size = new System.Drawing.Size(124, 114);
            this.grpIngredientes.TabIndex = 2;
            this.grpIngredientes.TabStop = false;
            this.grpIngredientes.Text = "Ingredientes Adicionais";
            // 
            // chkChampignon
            // 
            this.chkChampignon.AutoSize = true;
            this.chkChampignon.Location = new System.Drawing.Point(6, 87);
            this.chkChampignon.Name = "chkChampignon";
            this.chkChampignon.Size = new System.Drawing.Size(85, 17);
            this.chkChampignon.TabIndex = 6;
            this.chkChampignon.Text = "Champignon";
            this.chkChampignon.UseVisualStyleBackColor = true;
            // 
            // chkAzeitona
            // 
            this.chkAzeitona.AutoSize = true;
            this.chkAzeitona.Location = new System.Drawing.Point(6, 65);
            this.chkAzeitona.Name = "chkAzeitona";
            this.chkAzeitona.Size = new System.Drawing.Size(67, 17);
            this.chkAzeitona.TabIndex = 4;
            this.chkAzeitona.Text = "Azeitona";
            this.chkAzeitona.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(6, 42);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(59, 17);
            this.chkCebola.TabIndex = 4;
            this.chkCebola.Text = "Cebola";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // grpBorda
            // 
            this.grpBorda.Controls.Add(this.rdbComBordaCheddar);
            this.grpBorda.Controls.Add(this.rdbComBorda);
            this.grpBorda.Controls.Add(this.rdbSemBorda);
            this.grpBorda.Location = new System.Drawing.Point(196, 72);
            this.grpBorda.Name = "grpBorda";
            this.grpBorda.Size = new System.Drawing.Size(197, 114);
            this.grpBorda.TabIndex = 3;
            this.grpBorda.TabStop = false;
            this.grpBorda.Text = "Borda";
            // 
            // rdbComBordaCheddar
            // 
            this.rdbComBordaCheddar.AutoSize = true;
            this.rdbComBordaCheddar.Location = new System.Drawing.Point(6, 87);
            this.rdbComBordaCheddar.Name = "rdbComBordaCheddar";
            this.rdbComBordaCheddar.Size = new System.Drawing.Size(190, 17);
            this.rdbComBordaCheddar.TabIndex = 6;
            this.rdbComBordaCheddar.TabStop = true;
            this.rdbComBordaCheddar.Text = "Com borda recheada com Cheddar";
            this.rdbComBordaCheddar.UseVisualStyleBackColor = true;
            // 
            // rdbComBorda
            // 
            this.rdbComBorda.AutoSize = true;
            this.rdbComBorda.Location = new System.Drawing.Point(6, 64);
            this.rdbComBorda.Name = "rdbComBorda";
            this.rdbComBorda.Size = new System.Drawing.Size(130, 17);
            this.rdbComBorda.TabIndex = 4;
            this.rdbComBorda.TabStop = true;
            this.rdbComBorda.Text = "Com Borda Recheada";
            this.rdbComBorda.UseVisualStyleBackColor = true;
            // 
            // rdbSemBorda
            // 
            this.rdbSemBorda.AutoSize = true;
            this.rdbSemBorda.Location = new System.Drawing.Point(6, 42);
            this.rdbSemBorda.Name = "rdbSemBorda";
            this.rdbSemBorda.Size = new System.Drawing.Size(77, 17);
            this.rdbSemBorda.TabIndex = 4;
            this.rdbSemBorda.TabStop = true;
            this.rdbSemBorda.Text = "Sem Borda";
            this.rdbSemBorda.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(196, 204);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(135, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir Pedido";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(30, 204);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(124, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar Pedido";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.grpBorda);
            this.Controls.Add(this.grpIngredientes);
            this.Controls.Add(this.cboSabores);
            this.Controls.Add(this.lblSabores);
            this.Name = "Form1";
            this.Text = "Pizzaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpIngredientes.ResumeLayout(false);
            this.grpIngredientes.PerformLayout();
            this.grpBorda.ResumeLayout(false);
            this.grpBorda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSabores;
        private System.Windows.Forms.ComboBox cboSabores;
        private System.Windows.Forms.GroupBox grpIngredientes;
        private System.Windows.Forms.GroupBox grpBorda;
        private System.Windows.Forms.CheckBox chkAzeitona;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.RadioButton rdbComBorda;
        private System.Windows.Forms.RadioButton rdbSemBorda;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.CheckBox chkChampignon;
        private System.Windows.Forms.RadioButton rdbComBordaCheddar;
    }
}

