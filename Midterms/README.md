# Wonders - Hospitality & Tourism Website

**Course:** CSIT 321 - Application Development
**Activity:** Midterm Exam
**Name:** _Your Name Here_
**Section:** _Your Section Here_

## Overview

Wonders is a hospitality and tourism website built with C# and Blazor. It showcases five of the New 7 Wonders of the World and lets visitors browse destinations, read about each location, book a tour package, and contact the company.

The landing page uses a scroll-driven hero: as the user scrolls, the full-screen background and the details of the active wonder change, and the vertical image slices highlight the current destination.

## Tech Stack

- C# / Blazor Web App (Interactive Server), .NET SDK 8.0.400
- MVP (Model-View-Presenter) architecture
- Tailwind CSS (CDN script) and custom CSS
- JavaScript interop for scroll tracking and the sliding nav indicator

## Pages

1. Explore (`/`) - scroll-driven hero, highlights, tour package cards
2. Location details (`/wonder/{id}`) - history, highlights, quick facts, how to get there, tips, pricing
3. Book a Tour (`/book`) - validated booking form with live total (`/book?wonder=ID` preselects a destination)
4. About & Contact (`/about`) - company story, stats, validated contact form

## MVP Structure

- Model: `Models/`, `Services/`
- View: `Components/Pages/`, `Views/` (view interfaces)
- Presenter: `Presenters/`

## How to Run

```bash
dotnet run
```

An internet connection is required (Tailwind CDN and Google Fonts). Data is in memory only.
The namespace is `Midterms`; rename it if your project name differs.
