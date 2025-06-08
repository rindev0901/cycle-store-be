# 🚲 Cycle Store Backend

A modern, robust backend service for a bicycle store management system built with .NET 8.0.

## ✨ Features

- RESTful API architecture
- JWT Authentication
- Swagger/OpenAPI documentation
- CQRS pattern with MediatR
- Supabase integration
- Modern .NET 8.0 features

## 🛠 Tech Stack

- **Framework**: .NET 8.0
- **Authentication**: JWT Bearer
- **API Documentation**: Swagger/OpenAPI
- **Database**: Supabase
- **Architecture Patterns**: 
  - CQRS (Command Query Responsibility Segregation)
  - MediatR for handling commands and queries
  - Clean Architecture principles

## 📋 Prerequisites

- .NET 8.0 SDK
- Visual Studio 2022 or VS Code
- Supabase account and project
- Git

## 🚀 Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/cycle-store-be.git
   cd cycle-store-be
   ```

2. **Configure environment**
   - Copy `appsettings.Development.json` to your local environment
   - Update the configuration with your Supabase credentials
   - Set up your JWT secret key

3. **Restore dependencies**
   ```bash
   dotnet restore
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Access the API documentation**
   - Open your browser and navigate to `https://localhost:5001/swagger`

## 📁 Project Structure

```
cycle-store-be/
├── Controllers/         # API endpoints
├── Common/             # Shared utilities and helpers
├── DependencyInjection/# Service registration and configuration
├── Entities/           # Domain models and entities
├── Contracts/          # DTOs and interfaces
└── Properties/         # Project properties and launch settings
```

## 🔐 Environment Variables

The following environment variables need to be configured:

- `SupabaseUrl`: Your Supabase project URL
- `SupabaseKey`: Your Supabase API key
- `JwtSecret`: Secret key for JWT token generation
- `JwtIssuer`: JWT token issuer
- `JwtAudience`: JWT token audience

## 📝 API Documentation

API documentation is available through Swagger UI when running the application. Navigate to `/swagger` endpoint to explore available endpoints, request/response models, and test the API.

## 🤝 Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 👥 Authors

- Your Name - Initial work

## 🙏 Acknowledgments

- .NET Team for the amazing framework
- Supabase for the backend-as-a-service platform
- All contributors who have helped shape this project