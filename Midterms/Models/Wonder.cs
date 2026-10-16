namespace Midterms.Models;

public class Wonder
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Country { get; set; } = "";
    public string Category { get; set; } = "";
    public string Image { get; set; } = "";
    public string Description { get; set; } = "";
    public string Built { get; set; } = "";
    public string BestTime { get; set; } = "";
    public decimal PricePerPerson { get; set; }
    public int Days { get; set; }
}
