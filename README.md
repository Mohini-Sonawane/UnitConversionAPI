# Unit Conversion API

## Overview

This project is an ASP.NET Core 9 Web API that converts values between different units of measurement.

Currently supported categories:

- Length
- Weight / Mass
- Temperature

Examples:

- Meter → Foot
- Kilogram → Pound
- Celsius → Fahrenheit

The project is designed so new units and categories can be added easily in the future.

---

# Technologies

- ASP.NET Core 9 Web API
- C#
- Swagger / OpenAPI
- Dependency Injection
- xUnit

---

# Project Structure

```
src/
    UnitConversion.API
    UnitConversion.Application
    UnitConversion.Domain
    UnitConversion.Infrastructure

tests/
    UnitConversion.Tests
```

---

# Prerequisites

Install:

- .NET 9 SDK
- Visual Studio 2022 (or later)
  OR
- Visual Studio Code

---

# How to Run

## 1. Clone the repository

```bash
git clone https://github.com/yourusername/UnitConversionAPI.git
```

---

## 2. Go to the project folder

```bash
cd UnitConversionAPI
```

---

## 3. Restore packages

```bash
dotnet restore
```

---

## 4. Build the project

```bash
dotnet build
```

---

## 5. Run the API

```bash
dotnet run --project src/UnitConversion.API
```

---

## 6. Open Swagger

After the application starts, open:

```
https://localhost:7200/swagger
```

or

```
http://localhost:5200/swagger
```

(The exact URL will be shown in the terminal.)

---

# Example Request

POST

```
/api/conversion
```

Request

```json
{
  "value": 100,
  "from": "celsius",
  "to": "fahrenheit"
}
```

Response

```json
{
  "originalValue": 100,
  "from": "celsius",
  "to": "fahrenheit",
  "convertedValue": 212
}
```

---

# Design Decisions

### 1. Layered Architecture

The solution separates the API, business logic, domain models, and infrastructure into different projects. This keeps responsibilities clear and makes the code easier to maintain.

### 2. Dependency Injection

Services are registered using ASP.NET Core's built-in dependency injection, making the code easier to test and extend.

### 3. Base Unit Conversion

Each category has a single base unit.

Examples:

- Meter for Length
- Kilogram for Weight
- Celsius for Temperature

Every conversion is performed in two steps:

```
Source Unit
      ↓
Base Unit
      ↓
Target Unit
```

This avoids writing conversion logic between every pair of units.

### 4. Extensibility

New units can be added by registering:

- Unit name
- Category
- Conversion to base unit
- Conversion from base unit

No changes are required to the controller or service.

### 5. Global Exception Handling

A middleware handles exceptions and returns consistent error responses.

### 6. Hardcoded Data

The unit definitions are currently stored in code, as required by the challenge.

In a production system these could come from:

- SQL Server
- Configuration files
- External API

without changing the business logic.

---

# Trade-offs

For simplicity, unit definitions are hardcoded.

This keeps the project small while allowing future replacement with a database or other storage.

Authentication and authorization are not included because they are outside the scope of the challenge.

---

# Running Tests

```bash
dotnet test
```

---

# Future Improvements

- Add more conversion categories (Area, Volume, Time, Speed, Pressure)
- Store units in a database
- Add CRUD APIs for managing units
- Add caching
- API versioning
- FluentValidation
- Integration tests
- Docker support
- CI/CD pipeline
