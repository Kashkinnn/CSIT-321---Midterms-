namespace Midterms.Models;

public record Fact(string Label, string Value);
public record Highlight(string Title, string Text);

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

    // Details page
    public string Tagline { get; set; } = "";
    public string Location { get; set; } = "";
    public string Region { get; set; } = "";
    public int UnescoYear { get; set; }
    public List<string> History { get; set; } = new();
    public List<Highlight> Highlights { get; set; } = new();
    public List<Fact> Facts { get; set; } = new();
    public List<string> Tips { get; set; } = new();
    public string GettingThere { get; set; } = "";
    public string NearestAirport { get; set; } = "";
}
