using System.Data;
using System.Text.Json;

namespace TaskManager.DB.DB_Config;

public class DataBaseConfig
{
    public string Server { get; set; }
    public string Database { get; set; }
    public string Uid { get; set; }
    public string Pwd { get; set; }

    public override string ToString()
    {
        //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
        return $"{nameof(Server)}={Server};{nameof(Database)}={Database};{nameof(Uid)}={Uid};{nameof(Pwd)}={Pwd}";
    }

    public static DataBaseConfig CreateFromJson(string json)
    {
        try
        {
            var config = JsonSerializer.Deserialize<DataBaseConfig>(json);
            if (config is null) throw new NoNullAllowedException();
            return config;
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}