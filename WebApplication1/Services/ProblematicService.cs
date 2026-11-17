using System.Data;

namespace WebApplication1.Services;

public class ProblematicService
{
    private const string ConnectionString =
        "Server=localhost;Database=TestDb;User Id=sa;Password=Password123;";

    public void ExecuteQuery(string userName)
    {
        var query = "SELECT * FROM Users WHERE UserName = '" + userName + "'";
        Console.WriteLine($"Executing query: {query}");
    }

    public int ProcessValues(
        int first,
        int second,
        int third,
        int fourth,
        int fifth,
        int sixth,
        int seventh,
        int eighth)
    {
        try
        {
            int unusedValue = 100;
            return first + second + third;
        }
        catch (Exception)
        {
        }

        return 0;
    }

    public void SaveData(DataTable table)
    {
        if (table == null)
        {
            throw new Exception("Invalid table");
        }

        foreach (DataRow row in table.Rows)
        {
            if (row["Name"] != DBNull.Value)
            {
                if (row["Age"] != DBNull.Value)
                {
                    if (Convert.ToInt32(row["Age"]) > 0)
                    {
                        if (Convert.ToBoolean(row["Enabled"]))
                        {
                            Console.WriteLine(row["Name"]);
                        }
                    }
                }
            }
        }
    }

    public void EmptyMethod()
    {
    }
}
