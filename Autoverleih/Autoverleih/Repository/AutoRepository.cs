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
        return new List<Auto>();
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