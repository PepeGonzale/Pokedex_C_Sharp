using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pokedex_C_Sharp
{

    class Conexion
    {
        public MySqlConnection conexion; //variable que se encarga de conectarnos al servidor MySql
        

        public Conexion()
        { //el constructor de la clase
            conexion = new MySqlConnection("Server=127.0.0.1; Database=listapokemons; Uid=root; Pwd=; Port=3306 ");
        }

        public DataTable getPokemons()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable pokemons = new DataTable(); //formato que espera el datagridview
                pokemons.Load(resultado);  //convierte MysqlDataReader en DataTable
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }

        public DataTable getPokemonsPorId(int _id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE id='" + _id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la query
                DataTable pokemons = new DataTable(); //formato que espera el datagridview
                pokemons.Load(resultado);  //convierte MysqlDataReader en DataTable
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }


    }
}

