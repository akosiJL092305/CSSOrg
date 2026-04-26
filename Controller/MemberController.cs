using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace OrgAPI.Controllers
{
    [ApiController]
    [Route("api/member")]
    public class MemberController : ControllerBase
    {
        [HttpPost("member")]
        public IActionResult AddMember(Member m)
        {
            string connStr = "server=localhost;database=csso_db;user=root;password=;";

            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "INSERT INTO members(user_id,fullname,age,address) VALUES(@uid,@fn,@a,@ad)";
            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@uid", m.UserId);
            cmd.Parameters.AddWithValue("@fn", m.Fullname);
            cmd.Parameters.AddWithValue("@a", m.Age);
            cmd.Parameters.AddWithValue("@ad", m.Address);

            cmd.ExecuteNonQuery();

            return Ok("Member saved");
        }
    }
}