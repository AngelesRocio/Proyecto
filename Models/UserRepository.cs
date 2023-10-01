using Microsoft.Data.SqlClient;

namespace Proyecto.Models
{
    public class UserRepository : IUser
    {
        private string _cn;
        public UserRepository()
        {
            //De esta forma obtenemos la cadena de conexión
            _cn = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("cn");
        }
        public IEnumerable<User> getAllUsers()
        {
            //Crearemos la lista que requerimos para llenarlo con los datos de la base de datos
            List<User> users = new List<User>();
            using (SqlConnection cn = new SqlConnection(_cn))
            {
                cn.Open();
                //pasamos el nombre del store-procedure
                SqlCommand cmd = new SqlCommand("sp_listar_usuario", cn);
                //asignamos el tipo de cmd
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    users.Add(new User
                    {

                        idUser = dr.GetInt32(0),
                        name = dr.GetString(1),
                        password = dr.GetString(2),
                        registerDate = dr.GetDateTime(3),
                        birthDate = dr.GetDateTime(4),
                        status = dr.GetInt32(5),
                        email = dr.GetString(6),
                        flag = dr.GetInt32(7),
                        lastSecondName = dr.GetString(8),
                        dni = dr.GetString(9),
                        lastFirstName = dr.GetString(10),
                        phone = dr.GetString(11),

                    });

                    cn.Close();

                }
            }
            return users;
        }
    }
}