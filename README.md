# Grinds Booking System
> **This repository has moved.** The requirements specification and prototype are now part of the full project, alongside the finished Oracle-based system:
> **https://github.com/isabellelynch/GrindsBookingSystemProject**
>
> This repo is kept as the original Requirements Engineering submission (05/12/2025).
**Author:** Isabelle Lynch (T00264026)
**Course:** Computing with Software Development, Requirements Engineering
**Submitted:** 05/12/2025

A Windows Forms prototype of a booking system for a grinds (tuition) practice. The manager can manage tutors and students, build a weekly schedule of grinds, take and cancel bookings on behalf of students, and view revenue and tutor earnings reports.

The prototype accompanies the requirements specification in `SupportingDocumentation/RE_Lynch_Isabelle.docx` ([Markdown version](SupportingDocumentation/RE_Lynch_Isabelle.md)), which describes the full system through its use cases, business rules and data files.

---

## Repository contents

```
SupportingDocumentation/
    RE_Lynch_Isabelle.docx      Requirements specification (use cases, business rules)
    RE_Lynch_Isabelle.md        The same specification in Markdown, readable on GitHub
    images/                     Diagrams used by the Markdown version
Prototype/
    GrindsBookingSystem.sln     Visual Studio solution
    background.jpg              Background image used by the forms
    GrindsBookingSystem/        C# Windows Forms project (.NET Framework 4.7.2)
```

---

## Running the prototype

**Requirements:** Windows and Visual Studio 2019 or later, with the **.NET desktop development** workload (.NET Framework 4.7.2).

1. Open `Prototype/GrindsBookingSystem.sln` in Visual Studio.
2. Press **F5** (or **Start**) to build and run.
3. The app opens on the home page. Use the menu bar to reach each area.

The prototype keeps all data in memory, so every run starts with the same sample data and changes are lost when it closes. The requirements specification's data files (Tutors, Students, Schedule, Bookings, Refunds, TutorRates) are represented by in-memory lists.

### Sample data

| Type | Records |
|------|---------|
| Tutors | 1 Isabelle Lynch (SNR, Maths) · 2 Gavin Lynch (JNR, Science) · 3 Brian Hill (NEW, English) |
| Students | 1 Isabelle Lynch · 2 Gavin Lynch · 3 Brian Hill |
| Grinds | Four upcoming grinds, one about 3 days away and three about 2 weeks away |
| Bookings | Two past bookings (for the reports) and two upcoming ones: student 3 on the grind under 7 days away, and student 1 on a grind more than 7 days away |

Sample dates are calculated from the day the app is run and always fall on weekdays, so there are always upcoming grinds to book and cancel. The two upcoming bookings let you try both cancellation rules: one is refunded, the other isn't.

---

## Features

| Menu | Function |
|------|----------|
| **Tutors** | Add (with Garda vetting confirmation), Remove, Update details, View details |
| **Students** | Add, Remove, Update details, View details |
| **Schedule** | View upcoming grinds, Add a grind, Remove a grind |
| **Bookings** | Make a booking, Cancel a booking, View a student's bookings |
| **Admin** | Yearly revenue analysis, Tutor earnings analysis (bar chart; click a bar for tutor details) |

Wherever a student or tutor is chosen, the ID, first name and surname drop-downs filter each other, so you can find a person by any of them.

### Business rules implemented

- **Contact details:** names must contain letters only, email must be a valid format, and phone must be `XXX-XXXXXXX`.
- **Tutors:** must be Garda vetted before being added. Rate codes are SNR (€50), JNR (€40) and NEW (€30) per grind.
- **Grinds:**
  - Monday to Friday only, starting between 9am and 5pm.
  - Within the next 28 days, and not in the past.
  - Attendance limit between 1 and 20.
  - A tutor or a room can't have two grinds at the same time.
- **Bookings:**
  - A grind can't be overbooked, and a student can't book the same grind twice.
  - Payment is confirmed when the booking is made, and the price comes from the tutor's rate code.
- **Cancellations:** a booking cancelled more than 7 days before the grind is refunded; otherwise no refund is given.
- **Removing a grind:**
  - Not allowed within 7 days if students are enrolled.
  - Otherwise, its bookings are cancelled and fully refunded.
- **Removing a tutor:** their upcoming grinds are removed and all bookings with them are cancelled and fully refunded.
- **Removing a student:** their upcoming bookings are cancelled, with refunds under the normal 7-day rule.

Where the specification says students are emailed about a cancellation, the prototype lists the students to be notified in the confirmation message.

---

## Project structure

| File | Purpose |
|------|---------|
| `frmHome.cs` | Main menu, data classes (`Tutor`, `Student`, `Schedule`, `Booking`, `Refund`), in-memory data stores, sample data, shared validation and helper methods |
| `frmAddTutor`, `frmRemoveTutor`, `frmUpdateTutor`, `frmViewTutorDetails` | Tutor management |
| `frmAddStudent`, `frmRemoveStudent`, `frmUpdateStudent`, `frmViewStudentDetails` | Student management |
| `frmSchedule`, `frmAddGrind`, `frmRemoveGrind` | Schedule management |
| `frmAddBooking`, `frmCancelBooking`, `frmShowBookings` | Bookings |
| `frmAdmin`, `frmTutorReport` | Reporting |

Pages are opened with `frmHome.OpenChild(parent, child)`. This hides the current page and shows it again when the new page closes, whether through Back, by finishing its task, or with the window's X button.

---

## Known limitations

These are expected for a prototype:
- Data is not saved between runs.
- Student emails are not actually sent; the students to notify are listed on screen.
- Revenue is calculated from current bookings by booking date, so a cancelled booking no longer counts towards revenue even if no refund was given.

---
