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
    public partial class FrmAltaPokemon : Form
    {
        private Pokemon pokemon = null;
        public FrmAltaPokemon()
        {
            InitializeComponent();
        }
        public FrmAltaPokemon (Pokemon poke)
        {
            InitializeComponent();
            Text = "Modificar Pokemon";
            pokemon = poke;
        }

       
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAltaPokemon.Load(imagen);
            }
            catch (Exception)
            {

                pbxAltaPokemon.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
                pbxAltaPokemon.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void FrmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio negocio = new ElementoNegocio();
            try
            {
                cbxTipo.DataSource = negocio.listar();
                cbxTipo.ValueMember = "id";
                cbxTipo.DisplayMember = "descripcion";
                cbxDebilidad.DataSource = negocio.listar();
                cbxDebilidad.ValueMember = "id";
                cbxDebilidad.DisplayMember = "descripcion";
                 
                if (pokemon!=null)
                {
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtNombre.Text = pokemon.Nombre;
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtUrlImagen.Text = pokemon.UrlImagen;
                    cbxTipo.SelectedValue = pokemon.Tipo.Id;
                    cbxDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           // pokemon = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();
                
                    pokemon.Descripcion = txtDescripcion.Text;
                    pokemon.Nombre = txtNombre.Text;
                    pokemon.Numero = int.Parse(txtNumero.Text);
                    pokemon.UrlImagen = txtUrlImagen.Text;
                    pokemon.Tipo = (Elemento)cbxTipo.SelectedItem;
                    pokemon.Debilidad = (Elemento)cbxDebilidad.SelectedItem;
                  
                if (pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("MODIFICADO EXITOSAMENTE");
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("AGREGADO EXITOSAMENTE");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            this.Close();
        }

       
    }
}
                
                    
                
                    
                
            
            
           
            
            
