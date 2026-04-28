// ======================= Data/AppDbContext.cs =======================
using MySql.Data.MySqlClient;

public class AppDbContext
{
    private readonly IConfiguration _config;

    public AppDbContext(IConfiguration config)
    {
        _config = config;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(
            _config.GetConnectionString("DefaultConnection")
        );
    }
}