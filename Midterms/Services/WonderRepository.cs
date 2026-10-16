using Midterms.Models;

namespace Midterms.Services;

public class WonderRepository : IWonderRepository
{
    private readonly List<Wonder> _wonders = new()
    {
        new() { Id = 1, Name = "Great Wall of China", Country = "China", Category = "History",
            Image = "images/great-wall.jpg", Built = "7th century BC onward", BestTime = "Apr - Jun, Sep - Oct",
            PricePerPerson = 1250, Days = 6,
            Description = "Thousands of kilometers of walls and watchtowers rolling across mountains and valleys, built over centuries to guard China's northern frontier." },
        new() { Id = 2, Name = "Petra", Country = "Jordan", Category = "Culture",
            Image = "images/petra.jpg", Built = "c. 300 BC", BestTime = "Mar - May, Sep - Nov",
            PricePerPerson = 1480, Days = 5,
            Description = "The rose-red city carved into sandstone cliffs by the Nabataeans, reached through a narrow canyon that opens onto the famed Treasury." },
        new() { Id = 3, Name = "Taj Mahal", Country = "India", Category = "Romance",
            Image = "images/taj-mahal.jpg", Built = "1632 - 1653", BestTime = "Oct - Mar",
            PricePerPerson = 1100, Days = 5,
            Description = "A white marble mausoleum on the banks of the Yamuna, built by Emperor Shah Jahan in memory of his wife Mumtaz Mahal." },
        new() { Id = 4, Name = "Chichen Itza", Country = "Mexico", Category = "Adventure",
            Image = "images/chichen-itza.png", Built = "c. 600 - 1200 AD", BestTime = "Nov - Apr",
            PricePerPerson = 1390, Days = 4,
            Description = "The great Maya city on the Yucatan Peninsula, crowned by the step pyramid of El Castillo, aligned to the equinox sun." },
        new() { Id = 5, Name = "Machu Picchu", Country = "Peru", Category = "Outdoors",
            Image = "images/machu-picchu.jpg", Built = "c. 1450 AD", BestTime = "May - Sep",
            PricePerPerson = 1620, Days = 7,
            Description = "An Inca citadel perched high in the Andes above the Sacred Valley, famed for its terraces, stonework, and misty mountain views." },
    };

    public IReadOnlyList<Wonder> GetAll() => _wonders;
    public Wonder? GetById(int id) => _wonders.FirstOrDefault(w => w.Id == id);
}