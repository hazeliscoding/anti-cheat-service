# AntiCheatService 🎮🛡️

[![.NET Version](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Architecture](#architecture)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Running the Application](#running-the-application)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

---

## Introduction

Welcome to **AntiCheatService**! 🎉

AntiCheatService is a microservice built with **.NET 8**, demonstrating **Domain-Driven Design (DDD)** principles, utilizing **MediatR/CQRS** and **FluentValidation**. It serves as an Anti-Cheat and Security System for gaming applications, aggregating player behavior to detect anomalies and potential cheating.

## Features

- **Domain-Driven Design (DDD):** Clean separation of concerns with a focus on the core domain logic.
- **MediatR/CQRS Pattern:** Implements Command and Query Responsibility Segregation for scalability and maintainability.
- **FluentValidation:** Ensures data integrity with robust validation rules.
- **In-Memory Data Store:** Easy to set up and run without the need for a database.
- **Anomaly Detection:** Custom business logic to detect suspicious player activities.
- **Unit Testing:** Comprehensive tests to ensure reliability.
- **Extensible Architecture:** Easily integrate with real databases or expand anomaly detection logic.

## Architecture

The project follows a layered architecture:

- **Domain Layer:** Contains entities, aggregates, and domain events.
- **Application Layer:** Handles commands, queries, and application-specific logic.
- **Infrastructure Layer:** Implements repositories and external services.
- **API Layer:** Exposes endpoints via a Web API.
- **Tests:** Contains unit and integration tests.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Git](https://git-scm.com/)
- A code editor like [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)

### Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/AntiCheatService.git
   cd AntiCheatService
   ```

2. **Restore Packages**

   ```bash
   dotnet restore
   ```

3. **Build the Solution**

   ```bash
   dotnet build
   ```

## Running the Application

### Run the API

Navigate to the API project directory and run the application:

```bash
cd src/AntiCheatService.API
dotnet run
```

The API will start listening on `https://localhost:5001` or `http://localhost:5000`.

### Test the API

You can use [Postman](https://www.postman.com/) or [curl](https://curl.se/) to test the endpoints.

**Example: Record a Player Action**

```bash
curl -X POST https://localhost:5001/api/PlayerActions \
  -H "Content-Type: application/json" \
  -d '{
    "playerId": "player123",
    "actionType": "Shoot",
    "timestamp": "2023-10-01T12:34:56Z",
    "data": "Some additional data"
  }'
```

## Usage

The service exposes endpoints to record player actions and retrieve detected anomalies.

- **Record Player Action:** `POST /api/PlayerActions`
- **Get Anomalies:** (Endpoint to be implemented)

## Project Structure

```
AntiCheatService/
├── src/
│   ├── AntiCheatService.Domain/
│   ├── AntiCheatService.Application/
│   ├── AntiCheatService.Infrastructure/
│   └── AntiCheatService.API/
└── test/
    └── AntiCheatService.Tests/
```

- **`src/AntiCheatService.Domain`** 📂: Contains domain entities and aggregates.
- **`src/AntiCheatService.Application`** 📂: Application logic including commands and queries.
- **`src/AntiCheatService.Infrastructure`** 📂: Infrastructure concerns like repositories.
- **`src/AntiCheatService.API`** 🌐: Web API project exposing endpoints.
- **`test/AntiCheatService.Tests`** 🧪: Unit and integration tests.

## Testing

Run the unit tests to ensure everything is working as expected:

```bash
cd test/AntiCheatService.Tests
dotnet test
```

You should see test results indicating the number of tests passed.

## Contributing

Contributions are welcome! 🤝

1. **Fork the Repository**

   Click the "Fork" button at the top right of this page.

2. **Clone Your Fork**

   ```bash
   git clone https://github.com/yourusername/AntiCheatService.git
   ```

3. **Create a Feature Branch**

   ```bash
   git checkout -b feature/your-feature-name
   ```

4. **Commit Your Changes**

   ```bash
   git commit -m "Add your feature"
   ```

5. **Push to Your Fork**

   ```bash
   git push origin feature/your-feature-name
   ```

6. **Open a Pull Request**

   Go to the original repository and open a pull request.

## License

This project is licensed under the MIT License. 📄 See the [LICENSE](LICENSE) file for details.

## Contact

Feel free to reach out:

- **Email:** [your.email@example.com](mailto:hazel.granados@protonmail.com)
- **GitHub:** [yourusername](https://github.com/hazeliscoding)

---

Made with ❤️ and .NET 8!
