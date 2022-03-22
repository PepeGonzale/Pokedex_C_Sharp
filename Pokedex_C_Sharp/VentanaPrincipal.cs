using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_C_Sharp
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //el pokemon que estamos vi
        public VentanaPrincipal()
        {
            InitializeComponent();


            misPokemons = miConexion.getPokemonsPorId(idActual);
            nombrePokemons.Text = "Nombre " + "\n" + "\n" + misPokemons.Rows[0]["nombre"].ToString();
            especiePokemon.Text =  misPokemons.Rows[0]["especie"].ToString();
            alturaPokemon.Text = "Altura" + "\n" + "\n" + misPokemons.Rows[0]["altura"].ToString();
            pesoPokemon.Text = "Peso" + "\n" + "\n" + misPokemons.Rows[0]["peso"].ToString();
            habilidadPokemon.Text = "Habitat" + "\n" + "\n" + misPokemons.Rows[0]["habilidad"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);

            left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            left.FlatAppearance.BorderSize = 0;
            left.FlatAppearance.MouseDownBackColor = Color.Transparent;
            left.FlatAppearance.MouseOverBackColor = Color.Transparent;
            left.BackColor = Color.Transparent;

            right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            right.FlatAppearance.BorderSize = 0;
            right.FlatAppearance.MouseDownBackColor = Color.Transparent;
            right.FlatAppearance.MouseOverBackColor = Color.Transparent;
            right.BackColor = Color.Transparent;

            EvolucionPokemon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            EvolucionPokemon1.FlatAppearance.BorderSize = 0;
            EvolucionPokemon1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            EvolucionPokemon1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            EvolucionPokemon1.BackColor = Color.Transparent;

            descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            descripcion.FlatAppearance.BorderSize = 0;
            descripcion.FlatAppearance.MouseDownBackColor = Color.Transparent;
            descripcion.FlatAppearance.MouseOverBackColor = Color.Transparent;
            descripcion.BackColor = Color.Transparent;

            movimiento2Pokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            movimiento2Pokemon.FlatAppearance.BorderSize = 0;
            movimiento2Pokemon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            movimiento2Pokemon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            movimiento2Pokemon.BackColor = Color.Transparent;


        }
        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            idActual--;
            if(idActual <= 0)
            {
                idActual = 151;
            }
            misPokemons = miConexion.getPokemonsPorId(idActual);
            nombrePokemons.Text = "Nombre " + "\n" + "\n" + misPokemons.Rows[0]["nombre"].ToString();
            especiePokemon.Text =  misPokemons.Rows[0]["especie"].ToString();
            alturaPokemon.Text = "Altura" + "\n" + "\n" + misPokemons.Rows[0]["altura"].ToString();
            pesoPokemon.Text = "Peso" + "\n" + "\n" + misPokemons.Rows[0]["peso"].ToString();
            habilidadPokemon.Text = "Habitat" + "\n" + "\n" + misPokemons.Rows[0]["habilidad"].ToString();
            
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void right_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151)
            {
                idActual = 1;

            }
            misPokemons = miConexion.getPokemonsPorId(idActual);
            nombrePokemons.Text = "Nombre " + "\n" + "\n" + misPokemons.Rows[0]["nombre"].ToString();
            especiePokemon.Text = misPokemons.Rows[0]["especie"].ToString();
            alturaPokemon.Text = "Altura" + "\n" + "\n" + misPokemons.Rows[0]["altura"].ToString() + " m";
            pesoPokemon.Text = "Peso" + "\n" + "\n" + misPokemons.Rows[0]["peso"].ToString() + " kg";
            habilidadPokemon.Text = "Habitat" + "\n" + "\n" + misPokemons.Rows[0]["habilidad"].ToString();

            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            else
            {
                Application.Exit();
            }
        }

        private void alturaPokemon_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pesoPokemon_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ventana01 ventana1 = new Ventana01();
            ventana1.Show();
            //Se muestra la descripcion del pokemon actual
            ventana1.cambiaDescripcionPokemon(misPokemons.Rows[0]["descripcion"].ToString());
            ventana1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Evoluciones ventana2 = new Evoluciones();
            ventana2.cambiaMovimientosPokemon(misPokemons.Rows[0]["movimiento1"].ToString());
            ventana2.cambiaMovimientosPokemon1(misPokemons.Rows[0]["movimiento2"].ToString());
            ventana2.cambiaHabitat(misPokemons.Rows[0]["habitat"].ToString());
            ventana2.Show();
        }

        private void especiePokemon_Click(object sender, EventArgs e)
        {

        }

        private void EvolucionPokemon1_Click(object sender, EventArgs e)
        {
            Evolucion ventana = new Evolucion(id: idActual);
            ventana.Show();

        }
    }
}
