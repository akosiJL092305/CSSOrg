using Microsoft.AspNetCore.Http;

public class OfficerDTO
{
    public string Name { get; set; }
    public string Position { get; set; }
    public string Email { get; set; }
    public string Contact { get; set; }

    // ✅ REQUIRED FOR IMAGE UPLOAD
    public IFormFile Image { get; set; }
}