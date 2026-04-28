// ======================= Controllers/MemberController.cs =======================
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

[ApiController]
[Route("api/[controller]")]
public class MemberController : ControllerBase
{
    private readonly AppDbContext _db;

    public MemberController(AppDbContext db)
    {
        _db = db;
    }

    [HttpPost("add-member")]
    public async Task<IActionResult> AddMember([FromBody] MemberDTO m)
    {
        try
        {
            if (m == null ||
                string.IsNullOrWhiteSpace(m.Name) ||
                string.IsNullOrWhiteSpace(m.YearSection) ||
                string.IsNullOrWhiteSpace(m.Address) ||
                string.IsNullOrWhiteSpace(m.ContactNumber))
            {
                return BadRequest(new { message = "All fields are required" });
            }

            Console.WriteLine($"Received: {m.Name}, {m.YearSection}, {m.Address}, {m.ContactNumber}");

            using var conn = _db.GetConnection();
            await conn.OpenAsync();

            var sql = @"INSERT INTO members (user_id, full_name, year_section, address, contact)
                        VALUES (@userId, @name, @yearSection, @address, @contact)";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userId", 1); // replace later with logged-in user id
            cmd.Parameters.AddWithValue("@name", m.Name);
            cmd.Parameters.AddWithValue("@yearSection", m.YearSection);
            cmd.Parameters.AddWithValue("@address", m.Address);
            cmd.Parameters.AddWithValue("@contact", m.ContactNumber);

            await cmd.ExecuteNonQueryAsync();

            return Ok(new { message = "Member added successfully" });
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
            return BadRequest(new { message = ex.Message });
        }
    }
    [HttpPut("update/{id}")]
public async Task<IActionResult> UpdateMember(int id, [FromBody] MemberDTO m)
{
    try
    {
        using var conn = _db.GetConnection();
        await conn.OpenAsync();

        string query = @"UPDATE members 
                         SET full_name=@name,
                             year_section=@yearSection,
                             address=@address,
                             contact=@contact
                         WHERE id=@id";

        using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@name", m.Name);
        cmd.Parameters.AddWithValue("@yearSection", m.YearSection);
        cmd.Parameters.AddWithValue("@address", m.Address);
        cmd.Parameters.AddWithValue("@contact", m.ContactNumber);

        await cmd.ExecuteNonQueryAsync();

        return Ok(new { message = "Member updated" });
    }
    catch (Exception ex)
    {
        return BadRequest(new { message = ex.Message });
    }
}
[HttpDelete("delete/{id}")]
public async Task<IActionResult> DeleteMember(int id)
{
    try
    {
        using var conn = _db.GetConnection();
        await conn.OpenAsync();

        string query = "DELETE FROM members WHERE id=@id";

        using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@id", id);

        await cmd.ExecuteNonQueryAsync();

        return Ok(new { message = "Member deleted" });
    }
    catch (Exception ex)
    {
        return BadRequest(new { message = ex.Message });
    }
}
[HttpGet("all")]
public async Task<IActionResult> GetAll()
{
    var list = new List<object>();

    using var conn = _db.GetConnection();
    await conn.OpenAsync();

    string query = "SELECT * FROM members";

    using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
    using var reader = await cmd.ExecuteReaderAsync();

    while(await reader.ReadAsync())
    {
        list.Add(new {
            id = reader["id"],
            name = reader["full_name"].ToString(),
            yearSection = reader["year_section"].ToString(),
            address = reader["address"].ToString(),
            contact = reader["contact"].ToString()
        });
    }

    return Ok(list);
}
}