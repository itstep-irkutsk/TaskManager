using System.Text.Json;

namespace TaskManager.DB2.Crud;

public record DataBaseConfig
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

    public static DataBaseConfig CreateFromJson()
    {
        try
        {
            var json = File.ReadAllText(@"config_db.json");
            var config = JsonSerializer.Deserialize<DataBaseConfig>(json);
            return config;
        }
        catch (ArgumentNullException)
        {
            throw new ArgumentNullException();
        }
        catch (JsonException e)
        {
            throw new JsonException(e.Message);
        }
        catch (NotSupportedException e)
        {
            throw new NotSupportedException(e.Message);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}