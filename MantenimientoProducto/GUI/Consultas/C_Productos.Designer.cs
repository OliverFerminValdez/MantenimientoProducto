namespace MantenimientoProducto.GUI.Consultas
{
    partial class C_Productos
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CriterioComboBox = new System.Windows.Forms.TextBox();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.Filtro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 30);
            this.comboBox1.TabIndex = 1;
            // 
            // CriterioComboBox
            // 
            this.CriterioComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioComboBox.Location = new System.Drawing.Point(323, 82);
            this.CriterioComboBox.Name = "CriterioComboBox";
            this.CriterioComboBox.Size = new System.Drawing.Size(364, 28);
            this.CriterioComboBox.TabIndex = 2;
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarBtn.Location = new System.Drawing.Point(693, 80);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(161, 30);
            this.ConsultarBtn.TabIndex = 3;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            // 
            // Filtro
            // 
            this.Filtro.AutoSize = true;
            this.Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro.Location = new System.Drawing.Point(12, 55);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(51, 24);
            this.Filtro.TabIndex = 4;
            this.Filtro.Text = "Filtro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Criterio";
            // 
            // C_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.ConsultarBtn);
            this.Controls.Add(this.CriterioComboBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "C_Productos";
            this.Text = "C_Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox CriterioComboBox;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.Label Filtro;
        private System.Windows.Forms.Label label1;
    }
}