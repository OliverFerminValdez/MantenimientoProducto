using MantenimientoProducto.BLL;
using MantenimientoProducto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoProducto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            Productos p = new Productos();
            LlenarCampo(p);
        }
        public Productos LlenarClase()
        {
            Productos p = new Productos();
            p.ProductoId = 0;
            p.Codigo = CodigoTb.Text;
            p.Descripcion = DescripcionTb.Text;
            p.CategoriaId = (int)CategoriaComboBox.SelectedValue;
            p.Precio = (double)PrecioNumericUpDown.Value;
            p.Costo = (double)CostoNumericUpDown.Value;

            return p;
        }
        public void LlenarCampo(Productos producto)
        {
            CodigoTb.Text = producto.Codigo;
            DescripcionTb.Text = producto.Descripcion;
            CostoNumericUpDown.Value = (decimal)producto.Costo;
            PrecioNumericUpDown.Value = (decimal)producto.Precio;
            if (producto.CategoriaId > 0)
                CategoriaComboBox.Text = CategoriasBLL.Buscar(producto.CategoriaId).Descripcion;
            else
                CategoriaComboBox.Text = "";
        }
        public bool Validar()
        {
            bool validado = true;

            if (string.IsNullOrWhiteSpace(CodigoTb.Text))
            {
                MyErrorProvider.SetError(CodigoTb, "El campo codigo no puede estar vacio");
                CodigoTb.Focus();
                validado = false;
            }
            if (string.IsNullOrWhiteSpace(DescripcionTb.Text))
            {
                MyErrorProvider.SetError(DescripcionTb, "El campo descripcion no puede estar vacio");
                DescripcionTb.Focus();
                validado = false;
            }
            if (CostoNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CostoNumericUpDown, "El campo costo, no puede ser 0");
                CostoNumericUpDown.Focus();
                validado = false;
            }
            if (PrecioNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CostoNumericUpDown, "El campo precio, no puede ser 0");
                PrecioNumericUpDown.Focus();
                validado = false;
            }
            return validado;
        }
        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Productos producto = LlenarClase();
                if (ProductosBLL.Guardar(producto))
                {
                    Limpiar();
                    ActualizarLista();

                }
            }
        }
        public void BuscarProducto(int id)
        {
            Productos p = new Productos();
            Limpiar();

            p = ProductosBLL.Buscar(id);

            if (p != null) { LlenarCampo(p); }
            else
            {
                MessageBox.Show("Datos no encontrados");
            }
        }
        private void EditarButton_Click(object sender, EventArgs e)
        {
            GuardarCambiosButton.Visible = true;

            int id = int.Parse(ConsultaDGV.Rows[ConsultaDGV.CurrentRow.Index].Cells[0].Value.ToString());

            if (id != 0)
            {
                Limpiar();
                Productos p = ProductosBLL.Buscar(id);
                LlenarCampo(p);

            }

        }
        public void ActualizarLista()
        {
            ConsultaDGV.DataSource = ProductosBLL.GetProductos();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ConsultaDGV.Rows[ConsultaDGV.CurrentRow.Index].Cells[0].Value.ToString());

            if (id != 0)
            {
                Productos p = ProductosBLL.Buscar(id);

                if (ProductosBLL.Eliminar(p.ProductoId))
                {
                    ActualizarLista();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                }
            }
        }

        private void R_Productos_Load(object sender, EventArgs e)
        {
            GuardarCambiosButton.Visible = false;
            CargarComboBox();
            ActualizarLista();

        }
        public void CargarComboBox()
        {
            CategoriaComboBox.DataSource = CategoriasBLL.GetCategorias();
            CategoriaComboBox.ValueMember = "CategoriaId";
            CategoriaComboBox.DisplayMember = "Descripcion";
        }

        private void GuardarCambiosButton_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p = LlenarClase();
            p.ProductoId = int.Parse(ConsultaDGV.Rows[ConsultaDGV.CurrentRow.Index].Cells[0].Value.ToString());

            if (ProductosBLL.Modificar(p))
            {
                Limpiar();
                ActualizarLista();
                GuardarCambiosButton.Visible = false;
            }
            else { MessageBox.Show("No se guardaron los cambios"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            ActualizarLista();
        }

    }
}
