# Asmita Enterprises - Water Filter & Water Treatment Solutions Website

A complete, production-ready, highly responsive single-page WebAssembly application (SPA) for **Asmita Enterprises** built with **.NET 10 Blazor WebAssembly**.

---

## 🌟 Features & Highlights

- **Pure Client-Side SPA**: Built with .NET 10 Blazor WebAssembly standalone architecture. Zero server database or backend dependencies.
- **Vercel / Static Hosting Ready**: Deployable as pure static HTML/CSS/WASM files to Vercel Hobby or any static host.
- **Visual Design**: Matches reference design layout, color palette (Navy Blue `#0a2540`, Accent Blue `#0284c7`, WhatsApp Green `#25d366`), custom SVG branding, and rounded card styles.
- **Direct WhatsApp Enquiry System**: Prefilled messages targeting `+91 98345 55868` for Free Demo, Product Enquiries, Service Booking, and General Enquiries.
- **Multilingual Support**: Real-time language switching between **English**, **Marathi (मराठी)**, and **Hindi (हिंदी)**.
- **SEO & LocalBusiness Schema**: Preconfigured JSON-LD structured data, Open Graph, Twitter cards, meta tags, `robots.txt`, and `sitemap.xml`.
- **Accessibility & Responsiveness**: Tested across desktop, tablet, and mobile (320px to 1920px viewports).

---

## 🛠️ Technology Stack

- **Framework**: .NET 10 (Blazor WebAssembly Standalone)
- **Language**: C# 13 / Razor Components
- **Styling**: Vanilla CSS3 + Bootstrap 5 (Responsive Grid)
- **Typography**: Google Fonts (*Outfit* & *Inter*)
- **Icons & Graphics**: Clean SVG graphics & vector icons (no competitor logos)

---

## 📂 Project Structure

```
AsmitaEnterprises/
├── Components/
│   ├── Layout/
│   │   └── MainLayout.razor
│   ├── Pages/
│   │   ├── Home.razor
│   │   └── NotFound.razor
│   ├── TermsModal.razor
│   └── FloatingWhatsApp.razor
├── Sections/
│   ├── HeaderSection.razor
│   ├── HeroSection.razor
│   ├── TrustStripSection.razor
│   ├── ProductsSection.razor
│   ├── ServicesSection.razor
│   ├── DemoSection.razor
│   ├── ServiceAreaSection.razor
│   ├── ReviewsSection.razor
│   ├── ContactSection.razor
│   └── FooterSection.razor
├── Models/
│   ├── Product.cs
│   ├── ServiceItem.cs
│   ├── Review.cs
│   └── SiteSettings.cs
├── Services/
│   ├── LanguageService.cs
│   ├── WhatsAppService.cs
│   ├── ProductService.cs
│   ├── ReviewService.cs
│   └── SiteContentService.cs
├── wwwroot/
│   ├── css/
│   │   └── app.css
│   ├── data/
│   │   ├── products.json
│   │   ├── services.json
│   │   ├── reviews.json
│   │   └── site-settings.json
│   ├── images/
│   │   ├── logo/logo.svg
│   │   ├── hero-purifier.svg
│   │   ├── demo-purifier.svg
│   │   └── products/
│   ├── index.html
│   ├── robots.txt
│   └── sitemap.xml
├── vercel.json
├── Program.cs
└── AsmitaEnterprises.csproj

AsmitaEnterprises.Tests/
├── LanguageServiceTests.cs
└── WhatsAppServiceTests.cs
```

---

## 🚀 Local Setup & Instructions

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### 1. Build the Project
```bash
cd AsmitaEnterprises
dotnet build
```

### 2. Run Unit Tests
```bash
dotnet test ..\AsmitaEnterprises.Tests\AsmitaEnterprises.Tests.csproj
```

### 3. Run Locally (Dev Server)
```bash
dotnet run
```
Open your browser at `https://localhost:5001` or `http://localhost:5000`.

### 4. Publish for Static Deployment
```bash
dotnet publish -c Release -o ./publish
```

---

## 🌩️ Vercel Deployment Instructions

1. Push your code to your **GitHub** repository.
2. Connect your GitHub repository to **Vercel**.
3. Set the project configuration:
   - **Framework Preset**: `Other`
   - **Build Command**: `dotnet publish -c Release -o output`
   - **Output Directory**: `output/wwwroot`
4. The included `vercel.json` ensures client-side routes fallback to `index.html`.

---

## ✏️ How to Update Content

- **Products**: Edit `wwwroot/data/products.json` or `Services/ProductService.cs`.
- **Services**: Edit `wwwroot/data/services.json` or `Services/SiteContentService.cs`.
- **Reviews**: Edit `wwwroot/data/reviews.json` or `Services/ReviewService.cs`.
- **Contact Info & Settings**: Edit `wwwroot/data/site-settings.json` or `Services/SiteContentService.cs`.
- **Translations (EN/MR/HI)**: Edit `Services/LanguageService.cs`.