# Full Stack Developer Task – ProductApp

Bu proje .NET 8 (Backend) ve Next.js (Frontend) kullanılarak geliştirilmiş basit bir ürün yönetim uygulamasıdır. Amaç ürünleri listelemek ve yeni ürün eklemektir.

Öncelikle PostgreSQL üzerinde `productdb` adında bir veritabanı oluşturulmalı ve `appsettings.json` içindeki bağlantı ayarı kendi kullanıcı adı ve şifrenize göre düzenlenmelidir. Örnek:

````json
"ConnectionStrings": {
  "Default": "Host=localhost;Database=productdb;Username=postgres;Password=12345"
}
Backend için terminalde ProductApi klasörüne gidilip dotnet ef database update komutu ile veritabanı migrate edilir ve ardından dotnet run komutu ile API çalıştırılır. API varsayılan olarak http://localhost:5000 veya https://localhost:5001 adreslerinde çalışır. Swagger arayüzü https://localhost:5001/swagger adresinden test edilebilir.

Frontend tarafında frontend klasörüne girilip npm install komutu ile bağımlılıklar yüklenir. Kök dizine .env.local dosyası eklenip içine NEXT_PUBLIC_API_URL=https://localhost:5001 satırı yazılır. Daha sonra npm run dev komutu ile frontend başlatılır ve http://localhost:3000 adresinden uygulamaya erişilir.

Uygulama içinde /products sayfasında ürün listesi görüntülenir, /add-product sayfasında yeni ürün eklenebilir. Backend ile full-stack entegrasyon sağlanmıştır ve CORS ayarları yapılmıştır. Arayüz TailwindCSS kullanılarak responsive olarak tasarlanmıştır.

Kullanılan teknolojiler: Backend tarafında .NET 8, Entity Framework Core, PostgreSQL, Swagger; frontend tarafında Next.js 14, React, TailwindCSS; veritabanı olarak PostgreSQL.


/* *********************************************************************************************/


/* This is a [Next.js](https://nextjs.org) project bootstrapped with [`create-next-app`](https://nextjs.org/docs/app/api-reference/cli/create-next-app).

## Getting Started

First, run the development server:

```bash
npm run dev
# or
yarn dev
# or
pnpm dev
# or
bun dev
````

Open [http://localhost:3000](http://localhost:3000) with your browser to see the result.

You can start editing the page by modifying `app/page.tsx`. The page auto-updates as you edit the file.

This project uses [`next/font`](https://nextjs.org/docs/app/building-your-application/optimizing/fonts) to automatically optimize and load [Geist](https://vercel.com/font), a new font family for Vercel.

## Learn More

To learn more about Next.js, take a look at the following resources:

- [Next.js Documentation](https://nextjs.org/docs) - learn about Next.js features and API.
- [Learn Next.js](https://nextjs.org/learn) - an interactive Next.js tutorial.

You can check out [the Next.js GitHub repository](https://github.com/vercel/next.js) - your feedback and contributions are welcome!

## Deploy on Vercel

The easiest way to deploy your Next.js app is to use the [Vercel Platform](https://vercel.com/new?utm_medium=default-template&filter=next.js&utm_source=create-next-app&utm_campaign=create-next-app-readme) from the creators of Next.js.

Check out our [Next.js deployment documentation](https://nextjs.org/docs/app/building-your-application/deploying) for more details. \*/
