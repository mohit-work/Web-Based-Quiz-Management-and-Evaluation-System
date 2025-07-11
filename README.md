# Quiz Management and Evaluation System

A web-based quiz platform built with **ASP.NET Web Forms** and **MySQL**, designed to simplify the process of creating, managing, and evaluating quizzes. The system supports role-based access for administrators, participants, and reviewers, offering complete control over the quiz lifecycle.

---

## 🚀 Features

### 👨‍💼 Admin Panel
- Create quizzes manually or upload questions via Excel
- Add, edit, or delete questions with a user-friendly interface
- Manage quiz approval requests
- View quiz-specific and user-specific performance analytics

### 🧑‍🎓 User Panel
- View and attempt assigned quizzes within a time limit
- One-way navigation with automatic submission on timeout
- Immediate result display after quiz completion
- View history of completed and missed quizzes

### 🧾 Reviewer Panel
- Review and approve/reject quiz creation requests
- Access global statistics and performance reports

---

## 🛠️ Technology Stack

- **Frontend**: ASP.NET Web Forms (C#)
- **Backend**: .NET Framework
- **Database**: MySQL
- **Excel Integration**: EPPlus (.xlsx support)
- **Styling**: Bootstrap and custom CSS

---

## 📦 Folder Structure Overview

/App_Code          # Shared logic and utility classes
/App_Data          # Uploaded files or data storage
/Scripts           # JavaScript and client-side logic
/Styles            # CSS stylesheets
/quizadmin_*.aspx  # Admin-facing pages
/user.*.aspx       # User-facing quiz pages
/web.config        # Application configuration


---

## ⚙️ Setup Instructions

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-username/quiz-app.git

2. Open the project in Visual Studio.

3. Update the web.config file with your MySQL connection string.
Example:
<connectionStrings>
  <add name="MySqlConn" 
       connectionString="server=localhost;user id=root;password=yourpassword;database=quizdb;" 
       providerName="MySql.Data.MySqlClient" />
</connectionStrings>

4. Import the SQL schema into your MySQL database using MySQL Workbench or the CLI.

5. Build and run the application in Visual Studio (press Ctrl + F5 or use IIS Express).

---

## 🌟 Project Highlights

- **Modular and scalable architecture**
- **Real-time quiz evaluation** with timed assessments
- **Bulk question upload** using Excel (.xlsx)
- **Clean, role-based UI** for different types of users

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

## 👤 Author

**Mohit Anand**  
Developer & Project Maintainer

For suggestions, feedback, or collaboration opportunities, feel free to reach out.
