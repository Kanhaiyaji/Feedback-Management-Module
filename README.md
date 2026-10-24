# Practical 7 - Feedback Management Module

**AIM:** Develop Feedback Management Module using MVC Layout, Partial View & Validation (HTML Helpers, Validation, Layouts).

Ayush Sharma | 92400103460 | 5EC1 | Batch A | 01CE1523 - .NET Technologies

## Run

1. Install Visual Studio with the ASP.NET and web development workload and .NET Framework 4.8 targeting pack.
2. Open `FeedbackManagement.sln`.
3. Right-click the solution and select Restore NuGet Packages (packages are restored into the solution's `packages` directory).
4. Build the solution and run using IIS Express. Open `http://localhost:5077/`.

This is **ASP.NET MVC 5 on .NET Framework 4.8**, matching the previous MVC practical. It is not a .NET Core project; `dotnet run` does not apply.

## Features demonstrated

- Model: Data Annotations for required fields, name/comment length, email and rating range.
- Controller: GET/POST actions, `ModelState.IsValid`, anti-forgery token, restricted binding and redirect after successful POST.
- Layout: `_Layout.cshtml` and `_ViewStart.cshtml` provide shared navigation and footer.
- HTML helpers: BeginForm, LabelFor, TextBoxFor, DropDownListFor, TextAreaFor, ValidationSummary, ValidationMessageFor and ActionLink.
- Partial view: `_FeedbackCard.cshtml` renders each submitted feedback item using `Html.Partial`.
- Storage: a separate in-memory list per browser session. Data expires with the session or application restart; no database is required for this practical.
- Razor encodes submitted text when displaying it.

## Verified locally

Build succeeded. Browser checks passed for all five required fields, invalid email, rating outside 1-5, valid submission, success redirect, refresh without duplicate submission, multiple partial-view cards, missing anti-forgery token rejection and isolation between sessions.

Real screenshots from the running IIS Express application are in `docs/screenshots/`. The submission PDF contains the relevant source files, output screenshots and repository link.
