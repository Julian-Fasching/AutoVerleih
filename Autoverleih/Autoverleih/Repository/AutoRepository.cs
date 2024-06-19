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
        NpgsqlConnection myconnection = ConnectToDB();
        
        using NpgsqlCommand cmd = new NpgsqlCommand(
            "INSERT INTO auto (NameAuto, Leistung, Kilometerstand, Farbe) VALUES (:v1,:v2,:v3,:v4)", myconnection);
        cmd.Parameters.AddWithValue("v1", autos.NameAuto);
        cmd.Parameters.AddWithValue("v2", autos.Leistung);
        cmd.Parameters.AddWithValue("v3", autos.Kilometerstand);
        cmd.Parameters.AddWithValue("v4", autos.Farbe);
        
        int rowsAffected = cmd.ExecuteNonQuery();
        myconnection.Close();
    }
    
    public void DeleteAuto(Auto AutoId)
    {
        
    }
    
    public void UpdateAuto(Auto autos)
    {
        
    }
    
}