# 🏥 Hospital Management System

![C#](https://img.shields.io/badge/C%23-.NET-blue)
![Platform](https://img.shields.io/badge/Platform-Windows-green)
![Database](https://img.shields.io/badge/Database-SQL%20Server-orange)
![License](https://img.shields.io/badge/License-Educational-lightgrey)

A desktop-based Hospital Management System developed using **C# (.NET WinForms)** with **SQL Server** integration.

This system digitalizes hospital operations including patient management, doctor records, admissions, billing, and administrative control — all within a centralized interface.

---

## 📌 Project Overview

The Hospital Management System is designed to streamline hospital workflows by:

- Managing patient records
- Handling doctor information
- Scheduling admissions & discharges
- Generating billing records
- Maintaining structured database storage

The system reduces manual paperwork and improves operational efficiency.

---

## 🚀 Key Features

### 👤 Patient Management
- Add / Update / Delete Patient Records
- View Patient List
- Track Admissions & Discharges

### 👨‍⚕️ Doctor Management
- Add Doctors
- View Doctor List
- Manage Specializations

### 🏨 Room & Admission Management
- Assign Rooms
- Admit Patients
- Discharge Patients

### 💳 Billing System
- Generate Bills
- Maintain Payment Records
- Structured Billing Database

### 🔐 Authentication
- Secure Login System
- Role-based Access

---

## 🛠 Technologies Used

- **C#**
- **.NET Framework (WinForms)**
- **Microsoft SQL Server**
- **ADO.NET (Database Connectivity)**
- **Visual Studio**

---

## 📂 Project Structure

```
Hospital Management System/
│
├── Forms/
│   ├── LoginForm.cs
│   ├── Dashboard.cs
│   ├── PatientAdd.cs
│   ├── DoctorAdd.cs
│   ├── BillingForm.cs
│   └── ...
│
├── Database/
│   ├── HospitalDB_Create.sql
│   ├── Patients.sql
│   ├── Doctors.sql
│   ├── Billing.sql
│   └── Rooms.sql
│
└── Hospital Management System.sln
```

---

## ⚙️ Installation & Setup

### 1️⃣ Clone the Repository
```
git clone https://github.com/your-username/hospital-management-system.git
```

### 2️⃣ Open in Visual Studio
Open the `.sln` file using **Microsoft Visual Studio**.

### 3️⃣ Setup Database
- Open SQL Server
- Run `HospitalDB_Create.sql`
- Execute other SQL files to create required tables

### 4️⃣ Configure Database Connection
Update the connection string in `App.config` if required.

### 5️⃣ Run the Application
Press **Start (F5)** in Visual Studio.

---

## 🌟 Highlights

✔ Structured database integration  
✔ Clean WinForms UI  
✔ Modular form-based architecture  
✔ Real-world hospital workflow simulation  
✔ Secure login & data management  

---

## 📈 Future Improvements

- Online Appointment Booking
- Role-based dashboards (Admin/Staff)
- Advanced Reporting & Analytics
- Cloud Database Integration
- Web-based Version

---

## 👨‍💻 Developed By

Huzaira Rehman  

---

## 📜 License

This project is developed for educational purposes only.

---

⭐ If you found this project helpful, consider giving it a star!
