using Autoverleih.Models;
using Npgsql;

namespace Autoverleih.Repository;

public class AutoRepository
{
    private NpgsqlConnection ConnectToDB()
    {
        string connectionString = "Host=localhost;Database=AutoVerleih;User Id=dbuser;Password=dbuser;";
        
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        
        connection.Open();
        return connection;
        
        

    }
    
    public List<Auto> GetallAutos()
    {
        NpgsqlConnection myconnection = ConnectToDB();
        
        using NpgsqlCommand cmd = new NpgsqlCommand("select * from auto", myconnection);

        using NpgsqlDataReader reader = cmd.ExecuteReader();
        List<Auto> autos = new List<Auto>();
        while (reader.Read())
        {
            Auto newAuto = new Auto();
            newAuto.AutoId = (int)reader["AutoId"];
            newAuto.NameAuto = (string)reader["NameAuto"];
            newAuto.Kilometerstand = (double)reader["Kilometerstand"];
            newAuto.Farbe = (string)reader["Farbe"];
            newAuto.Leistung = (int)reader["Leistung"];

            autos.Add((newAuto));

        }
        
        return autos;
    }

    public void CreateAuto(Auto autos)
    {
        
    }
    
    public void DeleteAuto(Auto AutoId)
    {
        
    }
    
    public void UpdateAuto(Auto autos)
    {
        
    }
    
}