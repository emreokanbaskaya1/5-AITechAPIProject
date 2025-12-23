# 🤖 AI.Tech - Enterprise AI Platform

[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-purple.svg)](https://dotnet.microsoft.com/apps/aspnet)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)
[![Gemini AI](https://img.shields.io/badge/Gemini-AI%20Powered-orange.svg)](https://ai.google.dev/)

A full-stack enterprise web application built with **ASP.NET Core 8 Web API** and **Google Gemini AI** integration. This project demonstrates modern web development practices, clean architecture, and real-time AI-powered customer service.

## ✨ Features

### 🤖 AI-Powered Customer Service
- **Real-time AI Assistant** powered by Google Gemini 2.5 Flash
- Natural language processing for customer inquiries
- Context-aware responses about services and AI technologies
- Smooth loading states and animations

### 🔌 RESTful Web API
- **10+ API endpoints** with full CRUD operations
- JSON-based request/response structure
- Async/await pattern for optimal performance
- Comprehensive error handling and validation

### 🎨 Modern UI/UX
- **8+ Reusable ViewComponents** for maintainable code
- Fully responsive design with Bootstrap 5
- WOW.js animations for enhanced user experience
- Dynamic content management system

### 🛡️ Admin Panel
- Complete CRUD operations for all entities
- Secure authentication and authorization
- User-friendly interface for content management
- Real-time data updates

## 🏗️ Architecture

This project follows **Clean Architecture** principles with a clear separation of concerns:

```
AITech.Solution/
│
├── AITech.API/                 # RESTful Web API Layer
│   ├── Controllers/            # API Controllers
│   └── Program.cs              # API Configuration
│
├── AITech.WebUI/               # Presentation Layer (MVC/Razor)
│   ├── Controllers/            # MVC Controllers
│   ├── Views/                  # Razor Views
│   ├── ViewComponents/         # Reusable Components
│   ├── Areas/                  # Admin Area
│   └── wwwroot/                # Static Files
│
├── AITech.Business/            # Business Logic Layer
│   ├── Services/               # Business Services
│   └── Extensions/             # Service Extensions
│
├── AITech.DataAccess/          # Data Access Layer
│   ├── Repositories/           # Repository Pattern
│   ├── Context/                # Database Context
│   └── UnitOfWork/             # Unit of Work Pattern
│
├── AITech.Entity/              # Domain Layer
│   └── Entities/               # Domain Models
│
└── AITech.DTO/                 # Data Transfer Objects
    └── DTOs/                   # DTO Classes
```

### Design Patterns Implemented

- ✅ **Repository Pattern** - Data access abstraction
- ✅ **Unit of Work Pattern** - Transaction management
- ✅ **Dependency Injection** - Loose coupling
- ✅ **DTO Pattern** - Data transfer objects
- ✅ **Service Layer Pattern** - Business logic separation
- ✅ **ViewComponent Pattern** - Reusable UI components
- ✅ **Factory Pattern** - Service registration

## 💻 Technology Stack

### Backend
- **ASP.NET Core 8.0** - Web framework
- **Entity Framework Core** - ORM
- **FluentValidation** - Input validation
- **Newtonsoft.Json** - JSON serialization

### Frontend
- **ASP.NET Core MVC** / **Razor Pages**
- **Bootstrap 5** - CSS framework
- **jQuery 3.6.1** - JavaScript library
- **Font Awesome 5.10** - Icons
- **WOW.js** - Scroll animations
- **Owl Carousel** - Testimonial slider

### AI & External Services
- **Google Gemini AI 2.5 Flash** - AI assistant
- **HttpClient** - External API communication

### Database
- **SQL Server** - Primary database
- **Entity Framework Core** - Code-First approach

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads) (2019 or later)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- [Google Gemini API Key](https://ai.google.dev/)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/emreokanbaskaya1/4-AITechAPIProject.git
   cd 4-AITechAPIProject
   ```

2. **Configure the database connection**
   
   Update `appsettings.json` in both `AITech.API` and `AITech.WebUI`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=AITechDb;Trusted_Connection=True;TrustServerCertificate=True;"
     }
   }
   ```

3. **Configure Gemini API Key**
   
   Add your Gemini API key to `appsettings.json` in `AITech.WebUI`:
   ```json
   {
     "Gemini": {
       "ApiKey": "YOUR_GEMINI_API_KEY_HERE"
     }
   }
   ```

4. **Apply database migrations**
   ```bash
   cd AITech.DataAccess
   dotnet ef database update --startup-project ../AITech.API
   ```

5. **Run the API project**
   ```bash
   cd AITech.API
   dotnet run
   ```

6. **Run the Web UI project**
   ```bash
   cd AITech.WebUI
   dotnet run
   ```

7. **Access the application**
   - Web UI: `https://localhost:7001`
   - API: `https://localhost:7002`
   - Swagger: `https://localhost:7002/swagger`

## 📁 Project Structure

### AITech.WebUI (This Project)

```
Controllers/
├── HomeController.cs           # Home page controller
├── UIController.cs             # Main UI controller
├── LoginController.cs          # Authentication
└── NewsletterController.cs     # AI Integration endpoint

ViewComponents/
├── _BannerComponentPartial.cs
├── _AboutComponentPartial.cs
├── _FeatureComponentPartial.cs
├── _ChooseComponentPartial.cs
├── _ProjectComponentPartial.cs
├── _FaqComponentPartial.cs
├── _TestimonialComponentPartial.cs
└── _SocialComponentPartial.cs

Views/
├── UI/
│   └── Index.cshtml            # Main landing page with AI assistant
├── Home/
│   └── Index.cshtml
├── Login/
│   └── Index.cshtml
└── Shared/
    ├── _Layout.cshtml
    ├── _LayoutUI.cshtml
    └── Components/             # ViewComponent views

Areas/Admin/
├── Controllers/
│   ├── CategoryController.cs
│   ├── ProjectController.cs
│   ├── BannerController.cs
│   ├── AboutController.cs
│   ├── AboutItemController.cs
│   ├── FeatureController.cs
│   ├── TestimonialController.cs
│   ├── FaqController.cs
│   ├── SocialController.cs
│   └── ChooseController.cs
└── Views/
    └── [Admin CRUD Views]

Services/
├── GeminiServices/
│   ├── GeminiService.cs        # AI Service Implementation
│   └── IGeminiService.cs       # AI Service Interface
├── CategoryServices/
├── ProjectServices/
├── BannerServices/
├── AboutServices/
├── FeatureServices/
├── TestimonialServices/
├── FaqServices/
├── SocialServices/
└── ChooseServices/

DTOs/
├── GeminiDtos/
│   ├── GeminiRequestDto.cs
│   ├── GeminiResponseDto.cs
│   └── GeminiContentDto.cs
├── CategoryDtos/
├── ProjectDtos/
├── BannerDtos/
└── [Other DTOs]

Validators/
└── ProjectValidator.cs         # FluentValidation

wwwroot/
├── AI-html-1.0.0/              # Template files
│   ├── css/
│   ├── js/
│   ├── img/
│   └── lib/
└── [Static files]
```

## 🤖 AI Integration

### How It Works

The AI assistant is integrated using Google's Gemini 2.5 Flash API:

1. **User Input**: User types a question in the newsletter section
2. **AJAX Request**: Frontend sends POST request to `/Newsletter/AskQuestion`
3. **Controller Processing**: NewsletterController receives and validates the request
4. **AI Service**: GeminiService sends the prompt to Gemini API
5. **Response Processing**: AI response is processed and returned as JSON
6. **UI Update**: Frontend displays the response with smooth animations

### Code Example

**Frontend (JavaScript/jQuery):**
```javascript
$.ajax({
    url: '/Newsletter/AskQuestion',
    type: 'POST',
    contentType: 'application/json',
    data: JSON.stringify({ question: question }),
    success: function (response) {
        if (response.success) {
            $('#aiAnswerText').text(response.answer);
            $('#aiResponse').fadeIn();
        }
    }
});
```

**Backend (C#):**
```csharp
[HttpPost]
public async Task<IActionResult> AskQuestion([FromBody] NewsletterQuestionRequest request)
{
    var aiPrompt = $"You are a customer service representative for AI.Tech... " +
                   $"User question: {request.Question}";
    
    var response = await _geminiService.GetGeminiDataAsync(aiPrompt);
    
    return Json(new { success = true, answer = response });
}
```

## 📡 API Documentation

### Base URL
```
https://localhost:7002/api
```

### Endpoints

#### Categories
- `GET /api/Category` - Get all categories
- `GET /api/Category/{id}` - Get category by ID
- `POST /api/Category` - Create new category
- `PUT /api/Category` - Update category
- `DELETE /api/Category/{id}` - Delete category

#### Projects
- `GET /api/Project` - Get all projects
- `GET /api/Project/{id}` - Get project by ID
- `POST /api/Project` - Create new project
- `PUT /api/Project` - Update project
- `DELETE /api/Project/{id}` - Delete project

#### Banner
- `GET /api/Banner` - Get all banners
- `POST /api/Banner` - Create new banner
- `PUT /api/Banner` - Update banner
- `DELETE /api/Banner/{id}` - Delete banner

#### About
- `GET /api/About` - Get all about sections
- `POST /api/About` - Create new about section
- `PUT /api/About` - Update about section
- `DELETE /api/About/{id}` - Delete about section

#### Features
- `GET /api/Feature` - Get all features
- `POST /api/Feature` - Create new feature
- `PUT /api/Feature` - Update feature
- `DELETE /api/Feature/{id}` - Delete feature

#### Testimonials
- `GET /api/Testimonial` - Get all testimonials
- `POST /api/Testimonial` - Create new testimonial
- `PUT /api/Testimonial` - Update testimonial
- `DELETE /api/Testimonial/{id}` - Delete testimonial

#### FAQs
- `GET /api/Faq` - Get all FAQs
- `POST /api/Faq` - Create new FAQ
- `PUT /api/Faq` - Update FAQ
- `DELETE /api/Faq/{id}` - Delete FAQ

#### Social Media
- `GET /api/Social` - Get all social media links
- `POST /api/Social` - Create new social link
- `PUT /api/Social` - Update social link
- `DELETE /api/Social/{id}` - Delete social link

*For complete API documentation, visit `/swagger` when running the API project.*

## 🎨 ViewComponents

The project uses **8 reusable ViewComponents**:

1. **_BannerComponentPartial** - Hero/Banner section
2. **_AboutComponentPartial** - About us section
3. **_FeatureComponentPartial** - Services/Features showcase
4. **_ChooseComponentPartial** - Why choose us section
5. **_ProjectComponentPartial** - Project portfolio
6. **_FaqComponentPartial** - Frequently asked questions
7. **_TestimonialComponentPartial** - Customer testimonials
8. **_SocialComponentPartial** - Social media links

Each component:
- Fetches data from API asynchronously
- Renders independently
- Can be reused across pages
- Follows DRY principle

## 🔐 Security Features

- ✅ Input validation with FluentValidation
- ✅ CSRF protection (built-in ASP.NET Core)
- ✅ XSS protection with Razor encoding
- ✅ Secure API key management
- ✅ SQL injection prevention with EF Core
- ✅ HTTPS enforcement
- ✅ Authentication & Authorization ready

## 📊 Project Statistics

- **Total Lines of Code**: ~5,000+
- **Controllers**: 12+ (MVC + Admin)
- **Services**: 10+ with interfaces
- **Repositories**: 10+
- **ViewComponents**: 8+
- **DTOs**: 30+
- **Validators**: Multiple FluentValidation classes
- **Views**: 40+ (Admin + Public)

## 🧪 Testing

```bash
# Run unit tests
dotnet test

# Run with coverage
dotnet test /p:CollectCoverage=true
```

## 🌐 Frontend Features

### Bootstrap 5 Components Used
- Grid System (container-fluid, row, col)
- Cards
- Forms
- Buttons
- Alerts
- Modals
- Accordion (FAQs)
- Carousel (Testimonials)

### JavaScript Libraries
- **jQuery 3.6.1** - DOM manipulation & AJAX
- **WOW.js** - Scroll animations
- **Owl Carousel** - Testimonial slider
- **Waypoints** - Scroll tracking
- **CounterUp** - Number animations
- **Easing** - Smooth animations

### CSS Features
- **Custom CSS** (style.css)
- **Bootstrap 5** customization
- **Animate.css** integration
- **Responsive design** (Mobile-first)
- **Font Awesome 5.10** icons
- **Bootstrap Icons 1.4.1**

## 🎯 Admin Panel Features

The admin panel (`/Admin/*`) provides:

- ✅ **Dashboard** - Overview of content
- ✅ **Category Management** - CRUD operations
- ✅ **Project Management** - Portfolio items
- ✅ **Banner Management** - Hero section content
- ✅ **About Management** - Company information
- ✅ **Feature Management** - Services showcase
- ✅ **Testimonial Management** - Customer reviews
- ✅ **FAQ Management** - Questions & answers
- ✅ **Social Media Management** - Social links

### Admin Features
- Server-side validation
- Client-side validation
- Error handling
- Success/Error messages
- Responsive tables
- CRUD operations
- Data persistence

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👨‍💻 Author

**Emre Okan Başkaya**

- GitHub: [@emreokanbaskaya1](https://github.com/emreokanbaskaya1)
- LinkedIn: [Emre Okan Başkaya](https://www.linkedin.com/in/emreokanbaskaya/)
- Email: emreokanbaskaya@gmail.com

## 🙏 Acknowledgments

- [ASP.NET Core Documentation](https://docs.microsoft.com/aspnet/core)
- [Google Gemini AI](https://ai.google.dev/)
- [Bootstrap 5](https://getbootstrap.com/)
- [Font Awesome](https://fontawesome.com/)
- [jQuery](https://jquery.com/)
- HTML Template: [AI.Tech by HTML Codex](https://htmlcodex.com/)
- Distributed by: [ThemeWagon](https://themewagon.com/)

## 📞 Support

If you have any questions or need help:
- Open an issue on GitHub
- Contact me via LinkedIn
- Send an email

## 🚀 Future Enhancements

Planned features for future releases:
- [ ] User authentication system
- [ ] Role-based authorization
- [ ] Advanced AI conversation history
- [ ] Multi-language support
- [ ] Email notifications
- [ ] API rate limiting
- [ ] Caching implementation
- [ ] Unit & Integration tests
- [ ] Docker containerization
- [ ] CI/CD pipeline

## 📈 Performance

- Async/await pattern for all I/O operations
- Efficient database queries with EF Core
- Client-side caching
- Lazy loading for images
- Minified CSS & JavaScript
- CDN for external libraries

## 🔧 Configuration

### appsettings.json Structure

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=...;Database=AITechDb;..."
  },
  "Gemini": {
    "ApiKey": "YOUR_API_KEY"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information"
    }
  },
  "AllowedHosts": "*"
}
```

---

⭐ **If you found this project helpful, please give it a star!**

**Built with ❤️ using ASP.NET Core 8 and Google Gemini AI**
