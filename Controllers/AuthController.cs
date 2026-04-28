using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _db;

    public AuthController(AppDbContext db)
    {
        _db = db;
    }

    // HASH FUNCTION
    private string Hash(string input)
    {
        using var sha = SHA256.Create();
        return Convert.ToBase64String(
            sha.ComputeHash(Encoding.UTF8.GetBytes(input))
        );
    }

    // ================= REGISTER =================
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] User u)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();

            string q = "INSERT INTO users (username, password) VALUES (@u, @p)";

            using var cmd = new MySqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@u", u.Username);
            cmd.Parameters.AddWithValue("@p", Hash(u.Password));

            await cmd.ExecuteNonQueryAsync();

            return Ok(new { message = "Registered successfully" });
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    // ================= LOGIN =================
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] User u)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();

            string query = "SELECT * FROM users WHERE LOWER(username)=LOWER(@u)";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", u.Username);

            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                string storedPassword = reader["password"].ToString();

                if (storedPassword == Hash(u.Password))
                {
                    return Ok(new
                    {
                        username = reader["username"].ToString()
                    });
                }
            }

            return Unauthorized(new { message = "Invalid login" });
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}