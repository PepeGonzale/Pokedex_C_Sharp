using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_C_Sharp
{
    public partial class Evoluciones : Form
    {
        //Abrimos la conexion con la base de datos de listapokemons
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //el pokemon que estamos viendo
        public Evoluciones()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
         


        }
        private void Ventana02_Load (object sender, EventArgs e)
        {
           
            String posEvolucion = misPokemons.Rows[idActual]["posEvolucion"].ToString();
            misPokemons = miConexion.getPokemonsPorId(idActual);
            if(posEvolucion != null)
            {
                evolucionPokemons.Text = "Nombre " + "\n" + "\n" + misPokemons.Rows[idActual + 1]["nombre"].ToString();
            }
            else
            {
                label1.Text = "No hay evoluciones para este pokemon.";
            }
            
        }
    }
}
