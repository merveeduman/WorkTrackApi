# WorkTrack – Corporate Task Management System

WorkTrack is a corporate task management application developed to practice modern .NET backend development, Clean Architecture principles, and RESTful API design.

The project aims to provide a structured environment for managing tasks and tracking their progress through different statuses. It is being developed incrementally, with a focus on maintainable code, separation of concerns, and scalable software architecture.

## 🚀 Project Status

**Currently under development.**

The initial backend architecture and basic task management operations have been implemented. New features will be added throughout the development process.

## 🛠️ Technologies

- **C#**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **Microsoft SQL Server**
- **RESTful API**
- **Clean Architecture**
- **Repository Pattern**
- **Git & GitHub**

## 🏗️ Project Architecture

The solution is organized into four main projects:

```text
WorkTrack
│
├── WorkTrack.Api
│   └── Controllers
│
├── WorkTrack.Application
│   ├── DTOs
│   ├── Interfaces
│   └── Services
│
├── WorkTrack.Domain
│   └── Entities
│
└── WorkTrack.Infrastructure
    ├── Persistence
    └── Repositories
```

### Layer Responsibilities

| Layer | Responsibility |
|---|---|
| **API** | Handles HTTP requests and responses through controllers. |
| **Application** | Contains application services, DTOs, and repository interfaces. |
| **Domain** | Contains core entities and business rules. |
| **Infrastructure** | Handles database operations, Entity Framework Core, and repository implementations. |


## 🎯 Project Goals

The main goals of WorkTrack are:

- To apply Clean Architecture principles in a real-world project.
- To improve C# and ASP.NET Core Web API development skills.
- To understand Entity Framework Core and relational database management.
- To implement SOLID principles and common design patterns.
- To gain practical experience with Git, GitHub, testing, and deployment.
