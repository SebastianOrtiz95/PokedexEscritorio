using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseño
{

    public partial class FrmPokemon : Form
    {
        private PokemonNegocio Negocio;
        private List<Pokemon> PokemonLista;
        public FrmPokemon()
        {
            InitializeComponent();
        }

        #region eventos
        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FrmPokemon_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaPokemon altaPokemon = new FrmAltaPokemon();
            altaPokemon.ShowDialog();
            cargarGrilla();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarSeleccionado()) return;
                Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                FrmAltaPokemon modificarPokemon = new FrmAltaPokemon(seleccionado);
                modificarPokemon.ShowDialog();
                cargarGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (validarSeleccionado()) return;
            eliminar();
            cargarGrilla();

        }
        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            if (validarSeleccionado()) return;
            eliminar(true);
            cargarGrilla();
        }
        private void btnBuscarFiltro_Click(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada = new List<Pokemon>();
            string filtro = txtFiltroAvanzado.Text;
            listaFiltrada = PokemonLista.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Tipo.Descripcion.ToLower().Contains(filtro.ToLower()));

            if (filtro != "")
            {
                dgvPokemon.DataSource = listaFiltrada;
            }
            else
            {
                dgvPokemon.DataSource = PokemonLista;
            }
            //if (filtro!="")
            //{
            //    listaFiltrada = PokemonLista.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()));
            //}
            //else
            //{
            //    listaFiltrada = PokemonLista;
            //}
            //dgvPokemon.DataSource = null;
            //dgvPokemon.DataSource = listaFiltrada;
        }
       
        #endregion
        #region metodosPropios
        private void cargarGrilla()
        {
            Negocio = new PokemonNegocio();
            PokemonLista = Negocio.listar();
            dgvPokemon.DataSource = PokemonLista;
            ocultarColumnas();
            //dgvPokemon.Columns["UrlImagen"].Visible = false;
        }
        private void ocultarColumnas()
        {
            dgvPokemon.Columns["UrlImagen"].Visible = false;
            dgvPokemon.Columns["id"].Visible = false;
        }
        private bool validarSeleccionado()
        {
            if (dgvPokemon.CurrentRow == null)
            {
                MessageBox.Show("no hay nada seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
                //pbxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {

                pbxPokemon.Load("https://img.freepik.com/vector-gratis/dibujo-problemas-tecnicos-ordenador_23-2147503369.jpg?w=2000");
                pbxPokemon.SizeMode = PictureBoxSizeMode.Zoom;
                //MostrarSinImagen();
            }
        }
        private void eliminar(bool logico = false)
        {

            Negocio = new PokemonNegocio();
            try
            {
                Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                if (logico)
                {
                    DialogResult = MessageBox.Show("Esta seguro de eliminar", "ELIMINANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes)
                    {
                        Negocio.eliminarLogico(seleccionado);
                        MessageBox.Show("eliminado exitosamente");
                    }
                }
                else
                {
                    DialogResult = MessageBox.Show("Esta seguro de eliminar", "ELIMINANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes)
                    {
                        Negocio.eliminarFisico(seleccionado);
                        MessageBox.Show("eliminado exitosamente");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private void txtFiltroAvanzado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                List<Pokemon> listaFiltrada = new List<Pokemon>();
                string filtro = txtFiltroAvanzado.Text;
                listaFiltrada = PokemonLista.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Tipo.Descripcion.ToLower().Contains(filtro.ToLower()));

                if (filtro != "")
                {
                    dgvPokemon.DataSource = listaFiltrada;
                }
                else
                {
                    dgvPokemon.DataSource = PokemonLista;
                }
            }
        }
    }
}











