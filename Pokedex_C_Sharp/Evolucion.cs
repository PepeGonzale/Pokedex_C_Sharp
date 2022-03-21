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
    public partial class Evolucion : Form
    {
        Conexion miConexion = new Conexion();

        public Evolucion()
        {
        }

        public Evolucion(int id)
        {   
            InitializeComponent();
            DataTable pokemonElegido = miConexion.getPokemonsPorId(id);
            pokemonElegido = miConexion.getPokemonsPorId(id);
            pictureBox1.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            if (pokemonElegido.Rows[0]["posEvolucion"] != DBNull.Value)
            {
                DataTable pokemonElegido2 = miConexion.getPokemonsPorId(id + 1);
                pictureBox2.Image = convierteBlobAImagen((byte[])pokemonElegido2.Rows[0]["imagen"]);
                if (pokemonElegido2.Rows[0]["posEvolucion"] != DBNull.Value)
                {
                    DataTable pokemonElegido3 = miConexion.getPokemonsPorId(id + 2);
                    pictureBox3.Image = convierteBlobAImagen((byte[])pokemonElegido3.Rows[0]["imagen"]);
                }
            }
           

        }
        private Image convierteBlobAImagen(byte[] img)
        {
            return (Image.FromStream(new System.IO.MemoryStream(img)));
        }
    }
    }

