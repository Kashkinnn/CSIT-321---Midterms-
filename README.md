# Wonders - Hospitality & Tourism Website

**Course:** CSIT 321 - Application Development
**Activity:** Midterm Exam
**Name:** Joel C. Coyoca Jr.
**Section:** F1
**Figma:** https://www.figma.com/design/UD8l2nc67hsuLZzKPL5mVi/Wonders?node-id=0-1&t=DUvUOkCMM6BWErDJ-1
---

## Overview

Wonders is a hospitality and tourism website built with C# and Blazor. It showcases five of the New 7 Wonders of the World and lets visitors browse destinations, book a tour package, and contact the company.

The landing page uses a scroll-driven hero: as the user scrolls, the full-screen background and the details of the active wonder change, and the vertical image slices highlight the current destination.

## Tech Stack

| Item | Details |
|---|---|
| Language | C# |
| Framework | Blazor Web App (Interactive Server render mode) |
| .NET SDK | 8.0.400 |
| Architecture | MVP (Model-View-Presenter) |
| Styling | Tailwind CSS (CDN script) and custom CSS |
| Font | Plus Jakarta Sans (Google Fonts) |
| Interop | JavaScript (scroll tracking, sliding nav indicator) |

## Pages

1. **Explore (`/`)** - Scroll-driven hero with sliding background, image slices, and wonder details, followed by highlights and the tour package cards.
2. **Book a Tour (`/book`)** - Booking form with validation, live price total, and a summary card for the selected destination. Supports preselecting a destination via `/book?wonder=ID`.
3. **About & Contact (`/about`)** - Company story, stats, and a contact form with validation.

## Features

- Scroll-based background change on the landing page, with clickable slices that scroll to a wonder
- Sliding pill indicator in the navigation bar
- Form validation using DataAnnotations
- Live total price calculation based on destination and number of travelers
- Booking and message confirmation screens
- Glassmorphism-style modern UI with a dark theme and gradient accents

## MVP Structure

| Layer | Responsibility | Location |
|---|---|---|
| Model | Data classes and the in-memory repository | `Models/`, `Services/` |
| View | Razor pages implementing view interfaces | `Components/Pages/`, `Views/` |
| Presenter | Logic that handles view events and updates the view | `Presenters/` |

Each page implements a view interface (`IHomeView`, `IBookingView`, `IAboutView`) and creates its presenter in `OnInitialized`. The presenter reads data from `IWonderRepository` and pushes results back to the view through the interface.

## Folder Structure

```
Midterms/
├── Components/
│   ├── Layout/
│   │   └── MainLayout.razor
│   ├── Pages/
│   │   ├── Home.razor
│   │   ├── Book.razor
│   │   └── About.razor
│   ├── App.razor
│   ├── Routes.razor
│   └── _Imports.razor
├── Models/
│   ├── Wonder.cs
│   ├── BookingRequest.cs
│   └── ContactMessage.cs
├── Presenters/
│   ├── HomePresenter.cs
│   ├── BookingPresenter.cs
│   └── AboutPresenter.cs
├── Services/
│   ├── IWonderRepository.cs
│   └── WonderRepository.cs
├── Views/
│   ├── IHomeView.cs
│   ├── IBookingView.cs
│   └── IAboutView.cs
├── wwwroot/
│   ├── css/site.css
│   ├── js/wonders.js
│   └── images/
├── Program.cs
└── README.md
```

## Required Images

Place these files in `wwwroot/images/`:

- `great-wall.jpg`
- `petra.jpg`
- `taj-mahal.jpg`
- `chichen-itza.png`
- `machu-picchu.jpg`

## How to Run

1. Install the .NET SDK 8.0.400 or later in the 8.0 line.
2. Open the project folder in VS Code or a terminal.
3. Make sure all images are inside `wwwroot/images/`.
4. Run:

```bash
dotnet run
```

5. Open the URL shown in the terminal (for example `https://localhost:xxxx`).

## Notes

- An internet connection is required because Tailwind CSS and the Google Font are loaded from a CDN.
- Data is stored in memory only. Bookings and contact messages are not saved to a database, and the booking reference is randomly generated for display.
- The project namespace is `Midterms`. If your project has a different name, update the namespace in all files and `_Imports.razor`.
