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

## Changes made during review (October 2026)

The prototype was reviewed, fixed and tested. Every change keeps the original forms, layout and coding style.

### Bugs that stopped features working
- **Schedule, booking and cancel screens were empty.** All sample grinds were dated December 2025 and the screens hide past dates. Sample dates are now relative to today.
- **Grind clashes were never caught.** In Add Grind the clash check set an error but the grind was added anyway. A tutor or room double-booked at the same time is now rejected.
- **Removing a tutor or grind left orphaned data.** Bookings for a removed tutor stayed in the system and Make Booking crashed on them. Removing a tutor, student or grind now cancels the related bookings and records refunds as the specification describes; this completes the commented-out plan in Remove Tutor.
- **Update Tutor saved the wrong rate code.** It stored the full "SNR - €50 per hour…" text, so later bookings for that tutor cost €0. The subject was also never saved. Both are fixed.
- **The X button and some navigation broke the app.** Closing a page with the window's X button left the hidden home page running with no visible window. Some screens opened a new copy of Home or Schedule instead of returning to the existing one. All pages now return to the page that opened them.

### Data-integrity fixes
- **Update Student and Update Tutor saved invalid data.** They changed the record before validating, so an invalid email or phone was saved even after the error message. Changes are now saved only after validation; Update Student also saves name changes.
- **Make Booking used up seats it shouldn't have.** It increased the enrolment before asking about payment and before the already-booked check. All checks now happen first.
- **Cancel Booking half-cancelled bookings.** It removed the booking from the student before the "no refund, proceed?" question, so choosing Cancel left the data inconsistent. Refunds now also tell the user the amount.
- **Add Student and Add Tutor showed "success" before checking for duplicates.** The duplicate check compared object references, so it never matched. Duplicates (same name and email) are now detected first.
- **Add Tutor emptied its own drop-downs.** "Add another" and Refresh cleared the rate and subject lists.

### Crashes fixed
- Show Bookings and Cancel Booking crashed when clicked with no student selected.
- Remove Grind used the selected grind before checking it existed.
- Picking a weekend at the end of the 28-day range in Add Grind moved the date past the allowed maximum.
- Sorting bookings and grinds parsed the displayed date and time text, which fails on regional settings such as US "9:00 AM". It now sorts by the stored date. Remove Grind had the same problem.

### Smaller fixes
- The Tutor Earnings chart drew every tutor's bar at the same position; each tutor now has their own bar.
- Phone validation accepted extra characters before the number (missing `^` anchor), and names made only of spaces passed validation.
- Fixed messages: missing spaces in "Isabelle Lynchto the system", "this student already exists" on the tutor form, and spelling ("succesfully", "selet").
- The booking lists now show the grind's date as well as its time, and the payment prompt shows the price.
- The Schedule page refreshes after adding or removing a grind.

### Testing
The fixed project was compiled and run with Mono on Linux under a virtual display. A scripted test drove the real forms and checked the results: 54 checks covering every menu, the business rules above and the navigation between pages. The Tutor Earnings chart couldn't be run there because Mono's chart control isn't implemented, so that fix was checked by reading the code. It should be opened once in Visual Studio to confirm.

The `bin/` and `obj/` build folders have been removed; Visual Studio recreates them on the first build.
