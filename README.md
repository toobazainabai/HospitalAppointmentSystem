# Hospital Appointment System

A comprehensive desktop application for managing hospital appointments and patient scheduling. Built with C# and SQL Server, this system streamlines appointment booking, cancellation, and management processes for healthcare facilities.

##  Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Configuration](#configuration)
- [License](#license)

##  Features

- **Appointment Management**: Create, update, and cancel patient appointments
- **Patient Records**: Maintain comprehensive patient information and medical history
- **Doctor Scheduling**: Manage doctor availability and time slots
- **Real-time Notifications**: Instant appointment confirmations and reminders
- **Search & Filter**: Advanced search capabilities for appointments and patient records
- **Reporting**: Generate appointment and utilization reports
- **User Authentication**: Secure role-based access control
- **Data Persistence**: Reliable SQL Server database backend

##  Tech Stack

- **Frontend**: C# Windows Forms / WPF
- **Backend**: C# (.NET Framework)
- **Database**: SQL Server (T-SQL)
- **Scripting**: PowerShell for automation
- **Build Tools**: Batchfile for deployment

### Language Composition
- C# - 92.2%
- T-SQL - 4.4%
- PowerShell - 1.8%
- Batchfile - 1.6%

##  Prerequisites

- .NET Framework 4.7.2 or higher
- SQL Server 2016 or later
- Windows 10/11 Operating System
- Visual Studio 2019 or higher (for development)

##  Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/toobazainabai/HospitalAppointmentSystem.git
   cd HospitalAppointmentSystem
   ```

2. **Database Setup**
   - Execute the SQL scripts in the `Database` folder to create tables and stored procedures
   - Update connection string in `App.config` with your SQL Server instance

3. **Build the Solution**
   ```bash
   dotnet build
   ```

4. **Run the Application**
   ```bash
   dotnet run
   ```

##  Usage

### For Hospital Administrators
1. Launch the application
2. Log in with your credentials
3. Manage doctor schedules and appointment slots
4. View reports and analytics

### For Receptionists
1. Create new patient appointments
2. Search for existing appointments
3. Manage cancellations and rescheduling
4. Update patient contact information

### For Patients
- Book appointments online
- View appointment history
- Receive appointment reminders
- Manage personal information

##  Project Structure

```
HospitalAppointmentSystem/
├── src/
│   ├── UI/                    # Windows Forms/WPF UI components
│   ├── Core/                  # Business logic and services
│   ├── Data/                  # Database access layer
│   └── Models/                # Data models
├── Database/
│   ├── Schema/                # Database tables and structure
│   └── StoredProcedures/      # SQL Server stored procedures
├── Tests/                     # Unit and integration tests
├── Scripts/                   # PowerShell and batch scripts
├── docs/                      # Documentation
└── README.md                  # This file
```

##  Configuration

### Connection String
Update your connection string in `App.config`:

```xml
<configuration>
  <connectionStrings>
    <add name="HospitalDB" connectionString="Server=YOUR_SERVER;Database=HospitalDB;User Id=sa;Password=YOUR_PASSWORD;" />
  </connectionStrings>
</configuration>
```

### Application Settings
- Modify appointment slot duration in `AppSettings.config`
- Configure notification preferences
- Set working hours and holidays

##  Security Features

- User authentication and authorization
- Role-based access control (Admin, Doctor, Receptionist, Patient)
- Encrypted password storage
- Secure database connections
- Audit logging for critical operations

##  Known Issues

- *No critical issues reported*
- See [Issues](https://github.com/toobazainabai/HospitalAppointmentSystem/issues) for open tickets

##  Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/YourFeature`)
3. Commit changes (`git commit -m 'Add YourFeature'`)
4. Push to branch (`git push origin feature/YourFeature`)
5. Open a Pull Request

##  License

This project is licensed under the GNU Affero General Public License v3.0 - see the [LICENSE](LICENSE) file for details.

##  Support

For issues, questions, or suggestions, please create an issue in the [GitHub Issues](https://github.com/toobazainabai/HospitalAppointmentSystem/issues) section.

##  Author

**toobazainabai**

---

**Last Updated**: June 13, 2026
