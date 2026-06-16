using Microsoft.Data.SqlClient;
using Dapper;
namespace TP03.Models;
public class BD 
{
    private string conexion = @"Server=localhost;DataBase=Nombre Base; Integrated Security=True; TrustServerCertificate=True;"; 
    public List<string> agregarPalabras()
    {
        List<string> palabras = new List<string>();
        using(SqlConnection conexion = new SqlConnection (conexion))
        {
            string query = "SELECT * FROM Palabras";
            palabras = conexion.Query<string>(query).ToList();
        }
        return palabras;
    }
}
