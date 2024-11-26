using MySql.Data.MySqlClient;
using System.Data;

namespace Persistencia
{
    public class UniversidadDAO
    {
        private Conexion conn = new Conexion();
        MySqlCommand command = new MySqlCommand();
        DataTable table = new DataTable();

        // Mostrar todas las facultades
        public DataTable ObtenerFacultades()
        {
            DataTable table = new DataTable();  // Asegúrate de crear una nueva instancia de DataTable

            // Abrir conexión y ejecutar el procedimiento almacenado
            command.Connection = conn.AbrirConexion();
            command.CommandText = "MostrarFacultades";
            command.CommandType = CommandType.StoredProcedure;

            using (var reader = command.ExecuteReader())
            {
                table.Load(reader);  // Cargar los datos en el DataTable
            }

            conn.CerrarConexion();  // Cerrar la conexión

            return table;  // Retornar el DataTable con los datos más recientes
        }

        // Insertar una nueva facultad
        public void InsertarFacultad(string nombre, string ubicacion)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "InsertarFacultad";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_nombre", nombre);
            command.Parameters.AddWithValue("@p_ubicacion", ubicacion);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }

        // Editar una facultad existente
        public void EditarFacultad(int idFacultad, string nombre, string ubicacion)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "EditarFacultad";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_id", idFacultad);
            command.Parameters.AddWithValue("@p_nombre", nombre);
            command.Parameters.AddWithValue("@p_ubicacion", ubicacion);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }

        // Eliminar una facultad
        public void EliminarFacultad(int idFacultad)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "EliminarFacultad";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_id", idFacultad);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }

        // Obtener todas las materias
        public DataTable ObtenerMaterias()
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "MostrarMaterias";
            command.CommandType = CommandType.StoredProcedure;

            using (var reader = command.ExecuteReader())
            {
                table.Load(reader);
            }
            conn.CerrarConexion();
            return table;
        }

        // Insertar una nueva materia
        public void InsertarMateria(int idFacultad, string nombre, string codigo, int semestre)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "InsertarMateria";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_idFacultad", idFacultad);
            command.Parameters.AddWithValue("@p_nombre", nombre);
            command.Parameters.AddWithValue("@p_codigo", codigo);
            command.Parameters.AddWithValue("@p_semestre", semestre);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }

        // Editar una materia existente
        public void EditarMateria(int idMateria, int idFacultad, string nombre, string codigo, int semestre)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "EditarMateria";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_idMateria", idMateria);
            command.Parameters.AddWithValue("@p_idFacultad", idFacultad);
            command.Parameters.AddWithValue("@p_nombre", nombre);
            command.Parameters.AddWithValue("@p_codigo", codigo);
            command.Parameters.AddWithValue("@p_semestre", semestre);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }

        // Eliminar una materia
        public void EliminarMateria(int idMateria)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "EliminarMateria";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_idMateria", idMateria);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }

        // Login de usuario
        public bool LoginCheck(string username, string password)
        {
            bool isAuthenticated = false;

            command.Connection = conn.AbrirConexion();
            command.CommandText = "LoginUsuario";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_username", username);
            command.Parameters.AddWithValue("@p_password", password);

            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)  // Si el lector tiene filas, las credenciales son válidas
                {
                    isAuthenticated = true;
                }
            }

            command.Parameters.Clear();
            conn.CerrarConexion();
            return isAuthenticated;
        }
    }
}
