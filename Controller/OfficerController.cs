using Microsoft.AspNetCore.Mvc;
using OrgAPI.Data;
using OrgAPI.Models;

[ApiController]
[Route("api/officer")]
public class OfficerController : ControllerBase
{
    private readonly AppDbContext _context;

    public OfficerController(AppDbContext context)
    {
        _context = context;
    }

    // 🔹 VIEW ALL MEMBERS (Officer View)
    [HttpGet("members")]
    public IActionResult GetAllMembers()
    {
        var members = _context.Members.ToList();
        return Ok(members);
    }

    // 🔹 DELETE MEMBER BY ID
    [HttpDelete("member/{id}")]
    public IActionResult DeleteMember(int id)
    {
        var member = _context.Members.Find(id);
        if (member == null) return NotFound("Member not found");

        _context.Members.Remove(member);
        _context.SaveChanges();

        return Ok("Member deleted");
    }

    // 🔹 VIEW OFFICER LIST
    [HttpGet("list")]
    public IActionResult GetOfficerList()
    {
        var officers = _context.Users
            .Where(u => u.Role == "officer")
            .Select(u => new {
                u.Id,
                u.Username,
                u.Role
            })
            .ToList();

        return Ok(officers);
    }
}