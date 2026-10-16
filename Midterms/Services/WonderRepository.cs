using Midterms.Models;

namespace Midterms.Services;

public class WonderRepository : IWonderRepository
{
    private readonly List<Wonder> _wonders = new()
    {
        new()
        {
            Id = 1, Name = "Great Wall of China", Country = "China", Category = "History",
            Image = "images/great-wall.jpg", Built = "7th century BC onward", BestTime = "Apr - Jun, Sep - Oct",
            PricePerPerson = 1250, Days = 6,
            Description = "Thousands of kilometers of walls and watchtowers rolling across mountains and valleys, built over centuries to guard China's northern frontier.",
            Tagline = "A ribbon of stone across the mountains of northern China.",
            Location = "Northern China", Region = "Asia", UnescoYear = 1987,
            History = new()
            {
                "Early defensive walls date to the 7th century BC, when rival states built earthworks against each other. After unifying China around 221 BC, Emperor Qin Shi Huang linked and extended several of them to hold back nomadic raiders from the north.",
                "Later dynasties kept building and repairing. The brick-and-stone sections most visitors walk today were largely built during the Ming dynasty (1368 - 1644), complete with watchtowers, garrison posts, and signal beacons.",
                "A national survey completed in 2012 measured all wall sections from every period at more than 21,000 km, making it one of the largest construction projects in human history."
            },
            Highlights = new()
            {
                new("Mutianyu", "A well-restored section with a cable car and toboggan descent. Quieter than Badaling and great for families."),
                new("Jinshanling", "Partly restored, partly wild. Famous for sunrise photography and the hike toward Simatai."),
                new("Badaling", "The best-known and most accessible section, with the biggest crowds and easy transport from Beijing."),
                new("Jiankou", "Steep, unrestored 'wild wall' for experienced hikers who want dramatic, untouched scenery.")
            },
            Facts = new()
            {
                new("Total length", "21,196 km (2012 survey)"),
                new("Main builders", "Qin to Ming dynasties"),
                new("Typical wall height", "About 6 - 8 m"),
                new("Language", "Mandarin Chinese"),
                new("Currency", "Chinese yuan (CNY)")
            },
            GettingThere = "Most visitors base themselves in Beijing. Mutianyu and Badaling are roughly 1 to 1.5 hours away by car or tour bus, and Jinshanling is about 2.5 hours.",
            NearestAirport = "Beijing Capital (PEK) or Beijing Daxing (PKX)",
            Tips = new()
            {
                "Start early to beat the tour groups, especially at Badaling.",
                "Wear shoes with good grip. The steps are steep and uneven.",
                "Bring water and sun protection; there is little shade on the wall.",
                "Avoid Chinese public holidays such as Golden Week in early October."
            }
        },
        new()
        {
            Id = 2, Name = "Petra", Country = "Jordan", Category = "Culture",
            Image = "images/petra.jpg", Built = "c. 300 BC", BestTime = "Mar - May, Sep - Nov",
            PricePerPerson = 1480, Days = 5,
            Description = "The rose-red city carved into sandstone cliffs by the Nabataeans, reached through a narrow canyon that opens onto the famed Treasury.",
            Tagline = "The rose-red city carved into the cliffs of southern Jordan.",
            Location = "Wadi Musa, southern Jordan", Region = "Middle East", UnescoYear = 1985,
            History = new()
            {
                "Petra was the capital of the Nabataean kingdom. From around the 4th century BC it grew rich by controlling caravan routes that carried incense and spices between Arabia, Egypt, and the Mediterranean.",
                "Rome annexed the Nabataean kingdom in 106 AD and the city kept thriving for a time. Earthquakes, including a major one in 363 AD, and shifting trade routes led to a slow decline.",
                "Petra was largely unknown to the Western world until Swiss explorer Johann Ludwig Burckhardt reached it in 1812. It was named one of the New 7 Wonders of the World in 2007."
            },
            Highlights = new()
            {
                new("The Siq", "A winding canyon about 1.2 km long with towering rock walls that frames your first glimpse of the Treasury."),
                new("Al-Khazneh (The Treasury)", "A rock-cut facade roughly 40 m high, carved into the sandstone cliff face."),
                new("The Monastery (Ad Deir)", "A massive monument reached by about 800 rock-cut steps, with sweeping views at the top."),
                new("Royal Tombs", "A row of grand tomb facades in the cliffs, glowing in changing shades of red and gold."),
                new("Petra by Night", "A candlelit walk through the Siq to the Treasury, offered on selected evenings.")
            },
            Facts = new()
            {
                new("Civilization", "Nabataean"),
                new("Siq length", "About 1.2 km"),
                new("Treasury height", "About 40 m"),
                new("Language", "Arabic"),
                new("Currency", "Jordanian dinar (JOD)")
            },
            GettingThere = "Base yourself in Wadi Musa, the town at the park entrance. It is about 3 hours by road from Amman and about 2 hours from Aqaba.",
            NearestAirport = "Queen Alia International (AMM) in Amman, or Aqaba (AQJ)",
            Tips = new()
            {
                "Arrive at opening time for cooler weather and softer light on the Treasury.",
                "Wear sturdy shoes. The full site involves many kilometers of walking.",
                "Carry plenty of water since shade is limited.",
                "Allow at least one full day, or two if you want to hike up to the Monastery."
            }
        },
        new()
        {
            Id = 3, Name = "Taj Mahal", Country = "India", Category = "Romance",
            Image = "images/taj-mahal.jpg", Built = "1632 - 1653", BestTime = "Oct - Mar",
            PricePerPerson = 1100, Days = 5,
            Description = "A white marble mausoleum on the banks of the Yamuna, built by Emperor Shah Jahan in memory of his wife Mumtaz Mahal.",
            Tagline = "A white marble monument to love on the banks of the Yamuna.",
            Location = "Agra, Uttar Pradesh, India", Region = "Asia", UnescoYear = 1983,
            History = new()
            {
                "Mughal Emperor Shah Jahan commissioned the Taj Mahal after his wife, Mumtaz Mahal, died in 1631. It was built as her tomb and as a statement of imperial power and devotion.",
                "Construction began in 1632. The main mausoleum was finished around 1643 and the full complex around 1653. Thousands of artisans and laborers worked on it, using white marble from Makrana in Rajasthan inlaid with semi-precious stones.",
                "The complex includes the mausoleum, a mosque, a guest house, and formal charbagh gardens. Shah Jahan is buried beside Mumtaz Mahal. The design blends Persian, Islamic, and Indian architectural traditions."
            },
            Highlights = new()
            {
                new("The Mausoleum & Dome", "The central dome rises about 73 m, surrounded by four slender minarets and delicate marble inlay work."),
                new("Charbagh Gardens", "Symmetrical gardens and a long reflecting pool that mirror the monument."),
                new("Sunrise Visit", "Soft pink and golden light with smaller crowds. The most photographed time of day."),
                new("Mehtab Bagh", "A garden across the river with calm, classic views of the Taj, especially at sunset."),
                new("Agra Fort", "A nearby UNESCO-listed Mughal fort where Shah Jahan spent his final years.")
            },
            Facts = new()
            {
                new("Commissioned by", "Emperor Shah Jahan"),
                new("Built for", "Mumtaz Mahal"),
                new("Main material", "White Makrana marble"),
                new("Dome height", "About 73 m"),
                new("Language", "Hindi / English"),
                new("Currency", "Indian rupee (INR)")
            },
            GettingThere = "Agra is about 230 km from Delhi: around 2 hours by express train, or 3 to 4 hours by road.",
            NearestAirport = "Agra (AGR), though most travelers fly into Delhi (DEL)",
            Tips = new()
            {
                "The Taj Mahal is closed to tourists on Fridays. Plan your visit around it.",
                "Go at sunrise for the best light and the thinnest crowds.",
                "Shoes are not worn on the marble platform, so bring socks or use provided shoe covers.",
                "Pack light. Large bags and tripods are restricted at the entrance."
            }
        },
        new()
        {
            Id = 4, Name = "Chichen Itza", Country = "Mexico", Category = "Adventure",
            Image = "images/chichen-itza.png", Built = "c. 600 - 1200 AD", BestTime = "Nov - Apr",
            PricePerPerson = 1390, Days = 4,
            Description = "The great Maya city on the Yucatan Peninsula, crowned by the step pyramid of El Castillo, aligned to the equinox sun.",
            Tagline = "The Maya city where the sun draws a serpent on the pyramid.",
            Location = "Yucatan Peninsula, Mexico", Region = "North America", UnescoYear = 1988,
            History = new()
            {
                "Chichen Itza was one of the largest and most powerful Maya cities, rising to prominence in the Late Classic period and flourishing as a regional center into the 10th and 11th centuries.",
                "Its architecture shows both Maya and Toltec-style influences. After about 1200 the city declined as a political power, but it remained a pilgrimage destination because of its Sacred Cenote.",
                "Today it is one of the most visited archaeological sites in Mexico. Climbing El Castillo has been prohibited since 2006 to protect the structure."
            },
            Highlights = new()
            {
                new("El Castillo (Temple of Kukulcan)", "A step pyramid with 91 steps on each of its four sides plus the top platform, totaling 365. At the equinoxes the sun casts a serpent-shaped shadow down its stairway."),
                new("Great Ball Court", "The largest ball court in Mesoamerica, about 168 m long, famous for its acoustics."),
                new("El Caracol", "A round observatory tower believed to be used for tracking the movements of Venus and the sun."),
                new("Temple of the Warriors", "A pyramid fronted by rows of carved columns, once part of a vast colonnaded hall."),
                new("Sacred Cenote", "A natural sinkhole where the Maya made offerings to the rain god.")
            },
            Facts = new()
            {
                new("Civilization", "Maya, with Toltec influence"),
                new("El Castillo height", "About 30 m with the temple"),
                new("Ball court length", "About 168 m"),
                new("Language", "Spanish"),
                new("Currency", "Mexican peso (MXN)")
            },
            GettingThere = "The site is roughly 2.5 hours by road from Cancun, about 1.5 hours from Merida, and around 40 minutes from the town of Valladolid.",
            NearestAirport = "Cancun (CUN) or Merida (MID)",
            Tips = new()
            {
                "Arrive at opening time to beat both the heat and the tour buses.",
                "Around the March and September equinoxes the serpent effect appears, but crowds are heavy.",
                "Bring a hat, sunscreen, and water. Shade is limited across the site.",
                "Combine your visit with a swim in a nearby cenote such as Ik Kil."
            }
        },
        new()
        {
            Id = 5, Name = "Machu Picchu", Country = "Peru", Category = "Outdoors",
            Image = "images/machu-picchu.jpg", Built = "c. 1450 AD", BestTime = "May - Sep",
            PricePerPerson = 1620, Days = 7,
            Description = "An Inca citadel perched high in the Andes above the Sacred Valley, famed for its terraces, stonework, and misty mountain views.",
            Tagline = "An Inca citadel in the clouds above the Sacred Valley.",
            Location = "Cusco Region, Peru", Region = "South America", UnescoYear = 1983,
            History = new()
            {
                "Machu Picchu was built around 1450 under the Inca emperor Pachacuti, most likely as a royal estate. Its precisely cut stone walls were fitted together without mortar.",
                "The site was abandoned roughly a century later, around the time of the Spanish conquest. The Spanish never found it, which helped preserve it remarkably well.",
                "It was brought to international attention in 1911 by American explorer Hiram Bingham, although local farmers had known about it for generations."
            },
            Highlights = new()
            {
                new("Intihuatana Stone", "A carved granite stone believed to have worked as a ritual sundial or astronomical marker."),
                new("Temple of the Sun", "A curved, finely built temple tied to Inca sun worship and solstice alignments."),
                new("Temple of the Three Windows", "Three large trapezoidal windows framing the mountains beyond."),
                new("Agricultural Terraces", "Sweeping stone terraces that fed the citadel and stabilized the steep slopes."),
                new("Huayna Picchu & Sun Gate", "Hike the iconic peak behind the ruins or walk to the Sun Gate for a high view. Both need separate tickets or planning.")
            },
            Facts = new()
            {
                new("Elevation", "About 2,430 m (7,970 ft)"),
                new("Built by", "Inca, under Pachacuti"),
                new("Classic Inca Trail", "About 43 km over 4 days"),
                new("Language", "Spanish / Quechua"),
                new("Currency", "Peruvian sol (PEN)")
            },
            GettingThere = "Fly to Cusco, then take a train from Cusco or Ollantaytambo to Aguas Calientes and a short bus up to the site. You can also hike the Inca Trail.",
            NearestAirport = "Cusco (CUZ)",
            Tips = new()
            {
                "Book entry tickets and train seats well in advance. Entry is limited and timed.",
                "Spend a day or two in Cusco or the Sacred Valley first to adjust to the altitude.",
                "Bring layers and a rain jacket. Mountain weather changes quickly.",
                "Carry your passport, which is checked at the entrance."
            }
        },
    };

    public IReadOnlyList<Wonder> GetAll() => _wonders;
    public Wonder? GetById(int id) => _wonders.FirstOrDefault(w => w.Id == id);
}
