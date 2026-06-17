using Microsoft.Data.SqlClient;
using Dapper;
namespace TP03.Models;
public class BD 
{
    private string conexion = @"Server=localhost;DataBase=Nombre Base; Integrated Security=True; TrustServerCertificate=True;"; 
    public List<string> agregarPalabras()
    {
        List<string> palabras = new List<string>();
        using(SqlConnection conexion_BD = new SqlConnection (conexion))
        {
            string query = "SELECT * FROM Palabras";
            palabras = conexion_BD.Query<string>(query).ToList();
        }
        return palabras;
    }
}
