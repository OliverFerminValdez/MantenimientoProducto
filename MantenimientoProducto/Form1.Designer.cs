namespace MantenimientoProducto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.ConsultaDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.Location = new System.Drawing.Point(692, 30);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(161, 40);
            this.EliminarBtn.TabIndex = 9;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // EditarBtn
            // 
            this.EditarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBtn.Location = new System.Drawing.Point(339, 30);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(161, 40);
            this.EditarBtn.TabIndex = 8;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseVisualStyleBackColor = true;
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarBtn.Location = new System.Drawing.Point(12, 30);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(161, 40);
            this.ConsultarBtn.TabIndex = 7;
            this.ConsultarBtn.Text = "Agregar";
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            // 
            // ConsultaDGV
            // 
            this.ConsultaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDGV.Location = new System.Drawing.Point(12, 106);
            this.ConsultaDGV.Name = "ConsultaDGV";
            this.ConsultaDGV.RowHeadersWidth = 51;
            this.ConsultaDGV.RowTemplate.Height = 24;
            this.ConsultaDGV.Size = new System.Drawing.Size(841, 389);
            this.ConsultaDGV.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 507);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.ConsultarBtn);
            this.Controls.Add(this.ConsultaDGV);
            this.Name = "Form1";
            this.Text = "Mantenimiento de producto";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.DataGridView ConsultaDGV;
    }
}

