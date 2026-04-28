using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

[ApiController]
[Route("api/[controller]")]
public class OfficerController : ControllerBase
{
    private readonly AppDbContext _db;

    public OfficerController(AppDbContext db)
    {
        _db = db;
    }

    // ======================= GET ALL =======================
    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var list = new List<object>();

        using var conn = _db.GetConnection();
        await conn.OpenAsync();

        string query = "SELECT * FROM officers";

        using var cmd = new MySqlCommand(query, conn);
        using var reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            list.Add(new
            {
                id = reader["id"],
                name = reader["full_name"].ToString(),
                position = reader["position"].ToString(),
                email = reader["email"].ToString(),
                contact = reader["contact"].ToString(),
                profileImage = reader["profile_image"].ToString()
            });
        }

        return Ok(list);
    }

    // ======================= ADD =======================
    [HttpPost("add")]
public async Task<IActionResult> Add([FromForm] OfficerDTO o)
{
    try
    {
        using var conn = _db.GetConnection();
        await conn.OpenAsync();

        string fileName = "";

        if (o.Image != null)
        {
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/officers");

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            fileName = Guid.NewGuid() + Path.GetExtension(o.Image.FileName);
            var path = Path.Combine(folder, fileName);

            using var stream = new FileStream(path, FileMode.Create);
            await o.Image.CopyToAsync(stream);
        }

        string query = @"INSERT INTO officers 
        (full_name, position, email, contact, profile_image)
        VALUES (@name, @position, @email, @contact, @image)";

        using var cmd = new MySqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@name", o.Name);
        cmd.Parameters.AddWithValue("@position", o.Position);
        cmd.Parameters.AddWithValue("@email", o.Email);
        cmd.Parameters.AddWithValue("@contact", o.Contact);
        cmd.Parameters.AddWithValue("@image", fileName);

        await cmd.ExecuteNonQueryAsync();

        return Ok(new { message = "Officer added with image" });
    }
    catch (Exception ex)
    {
        return BadRequest(new { message = ex.Message });
    }
}
    // ======================= UPDATE =======================
    [HttpPut("update/{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] OfficerDTO o)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();

            string query = @"UPDATE officers 
                             SET full_name=@name,
                                 position=@position,
                                 email=@email,
                                 contact=@contact
                             WHERE id=@id";

            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", o.Name);
            cmd.Parameters.AddWithValue("@position", o.Position);
            cmd.Parameters.AddWithValue("@email", o.Email);
            cmd.Parameters.AddWithValue("@contact", o.Contact);

            await cmd.ExecuteNonQueryAsync();

            return Ok(new { message = "Officer updated successfully" });
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

    // ======================= DELETE =======================
    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();

            string query = "DELETE FROM officers WHERE id=@id";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            await cmd.ExecuteNonQueryAsync();

            return Ok(new { message = "Officer deleted successfully" });
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}