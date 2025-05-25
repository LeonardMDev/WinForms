# Patient Record Management System

## Overview

This is a C# Windows Forms Application that allows users to manage patient records. Users can add, view, search, and save patient information to a local text file (`PatientDetails.txt`).

---

## Features

- ✅ Add new patient records
- ✅ Save patient data to a text file
- ✅ Load and display all stored records
- ✅ Search patients by their ID
- ✅ Clear the input form

---

## File Structure

- **PatientDetails.txt** – The file where patient records are stored in CSV format.
- **Form1.cs** – The main form handling all logic and UI events.
- **Form1.Designer.cs** – Contains the Windows Forms UI layout.
- **Program.cs** – Entry point of the application.

---

## Technologies Used

- C#  
- Windows Forms (.NET Framework)
- File I/O for local storage

---

## How to Use

1. Clone or download the project.
2. Open the solution (`.sln`) file in Visual Studio.
3. Run the project.
4. Use the form to:
   - Enter patient details (ID, name, diagnosis, etc.)
   - Add the record or save it.
   - Search for existing patients by ID.
   - View all records.

---

## Data Format

Patient data is saved in `PatientDetails.txt` as CSV:
