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
        public void cambiaMovimientosPokemon(String movimiento)
        {
            movimiento1Pokemon.Text = movimiento;
        }
        public void cambiaMovimientosPokemon1(String movimiento1)
        {
            movimiento2Pokemon.Text = movimiento1;
        }
        public void cambiaHabitat(String habitat)
        {
            habitatPokemon.Text = habitat;
        }
        private void Ventana02_Load (object sender, EventArgs e)
        {
           
           
            
        }
       
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
