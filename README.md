# DogWalkingManager

DogWalkingManager is a Windows Forms application to manage clients, dogs, and dog walking events.  
It uses **Domain Driven Design (DDD)** principles, the **Repository pattern**, and **JSON persistence** to save data across sessions.

---

## 📦 Project Structure

- `DogWalkingManager` — Windows Forms UI (LoginForm, MainForm)
- `DogWalkingManager.Domain` — Entities and Interfaces
- `DogWalkingManager.Infrastructure` — Repositories, InMemory context, JSON persistence
- `DogWalkingManager.Services` — Business logic services (Authentication, Validation, DogWalkingService)
- `DogWalkingManager.Tests` — Unit tests for services and validation helpers

---

## 🚀 Requirements

- Visual Studio 2022 or newer
- .NET 7.0 SDK installed
  - 📥 [Download .NET 7 SDK here](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- MSTest framework (already included)
- Windows OS (for WinForms compatibility)

---

## 🛠 How to Run

1. Clone or download the repository.
2. Open `DogWalkingManager.sln` in Visual Studio.
3. Set `DogWalkingManager` project as Startup Project.
4. Press `F5` to build and run the application.

---

## 🔐 Default Login Credentials

- **Username:** `admin`
- **Password:** `password`

---

## 🗂 Features

- Add, delete, and manage clients and their dogs.
- Record dog walking sessions (date and duration).
- Validate input fields before saving.
- Save all data locally in JSON files (`clients.json`, `dogs.json`, `walks.json`).
- Load previous session data automatically when reopening.
- Unit tests covering authentication, validation, business logic, and persistence.

---

## 📑 Notes

- JSON files are created in the application root directory.
- No external database needed — everything is stored locally.
- Follows clean coding standards and SonarQube best practices.

---

## 🧪 Running Unit Tests

- Open Test Explorer (`Test -> Test Explorer`).
- Click "Run All Tests" to execute all MSTest-based unit tests.
