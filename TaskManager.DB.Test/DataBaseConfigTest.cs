using TaskManager.DB.DB_Config;
using Xunit;

namespace TaskManager.DB.Test;

public class DataBaseConfigTest
{
    [Fact]
    public void ToString_Test()
    {
        const string expected = "Server={server};Database={database};Uid={uid};Pwd={pwd}";
        var dbConfig = new DataBaseConfig
        {
            Server = "{server}",
            Database = "{database}",
            Uid = "{uid}",
            Pwd = "{pwd}"
        };
        var actual = dbConfig.ToString();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CreateFromJson_Test()
    {
        var expectedDbConfig = new DataBaseConfig
        {
            Server = "{server}",
            Database = "{database}",
            Uid = "{uid}",
            Pwd = "{pwd}"
        };
        var actualDbConfig = DataBaseConfig.CreateFromJson();
        Assert.Equal(expectedDbConfig, actualDbConfig);
    }
}