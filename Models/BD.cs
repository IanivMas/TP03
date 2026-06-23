using Microsoft.Data.SqlClient;
using Dapper;
namespace TP03.Models;
public class BD 
{
    private string conexion = @"Server=localhost;DataBase=TP03; Integrated Security=True; TrustServerCertificate=True;"; 
    public List<string> agregarPalabras()
    {
        List<string> Palabras = new List<string>();
        using(SqlConnection conexion_BD = new SqlConnection (conexion))
        {
            string query = "SELECT Palabra FROM Palabras";
            Palabras = conexion_BD.Query<string>(query).ToList();
        }
        return Palabras;
    }
}
