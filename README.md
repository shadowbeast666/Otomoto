# Auto_garaz (Otomoto)

Auto_garaz, also known as Otomoto, is an ASP.NET MVC 6 project.

# Overview

This project aims to provide an intuitive platform where car buyers and sellers can connect, interact, and transact securely. Whether you're a private seller, a used-car dealer, or just an enthusiast, Auto_garaz is the platform for you.

# For project evaluators!

To open the technical documentation, you need to enter a password that is the NAME and SURNAME of the course instructor (in lowercase and with Polish characters, no spaces beetween, like this : adamkowalski).

By default, only one user, superadmin@gmail.com, is added with the password: "123Pa$$word." However, for obvious reasons, this user will only be accessible locally! The hosted version of the application has limited access to users and roles. Only these roles are available : 
- No-authorized, 
- Basic,
- Moderator

Credentials for the online version:
- user@user.user::123Pa$$word.
- mod@mod.mod::123Pa$$word.

To access the SuperAdmin or Admin view, the application needs to be run locally.

Description of permissions:
 - Non-authorized / Registered - ability to view the site
 - Basic - ability to create new announcements and manage own announcements
 - Moderator - full ability to manage announcements
 - Administrator - ability to manage users and roles
- SuperAdmin - ability to manage users and roles + moderator view (without editing options!)

Please note that anyone will be able to change these credentials, rendering access impossible. 
In case of any issues with logging in to any of the available accounts, please contact me for assistance.

# Technology Stack
### Backend :

   .NET Core: A cross-platform framework for building modern cloud-based internet connected applications. .NET Core is the main framework you'll use to write your server-side code.

   ASP.NET Core MVC: A framework for building web applications using the Model-View-Controller design pattern. It provides a structured way to build a web application with clear separation of concerns.

   Entity Framework Core: An Object-Relational Mapping (ORM) framework for .NET. It automates most of the data access layer code you'd normally need to write.

### Database :

   SQL Server: A popular choice for an RDBMS for .NET applications.

### Frontend :

   HTML/CSS/JavaScript: The basic building blocks of the web. ASP.NET MVC allows you to create views using Razor syntax, which integrates server code with HTML.

   Bootstrap: A widely used CSS Framework that helps in designing responsive and mobile-first websites.

   jQuery: A fast, small, and feature-rich JavaScript library. It's used for things like handling user input, manipulating page content, and communicating with the server.

### Features :

   - User Registration and Authentication: Users can register and create their own personal accounts, and securely log in and out.

   - User Profiles: Registered users have profiles where they can provide details about themselves, view their listings, and track their activities on the site.

   - Car Listings: Users can create listings for cars they want to sell, including details like make, model, year, mileage, condition, features, and asking price. Listings can also include photos.

   - Search and Filter: Users can search for cars based on various criteria like make, model, year, price range, and location. Search results can be sorted and filtered further.

   - Listing View: Detailed view of each car listing, with more detailed information and a gallery of images.

   - Administrative Dashboard: A backend dashboard for site admins to manage users, listings, reviews, reports, and site-wide settings.

# Getting Started

To get a local copy up and running, follow these simple steps.
### Prerequisites :

   .NET SDK
   MS Visual Studio 2022
   .Net 6.0
   MS Entity Framework
   MS SQL Server or similar DB

# Installation

### Clone the repo :

bash /cmd

    git clone https://github.com/yourusername/Auto_garaz.git

Create the Otomoto DB and update the connection string accordingly.

- Open the project directory

Add migration to the database :

PM

    add-migration [name]
    
Update the database

    update-database

# Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are greatly appreciated.

    Fork the Project
    Create your Feature Branch (git checkout -b feature/YourFeature)
    Commit your Changes (git commit -m 'Add some YourFeature')
    Push to the Branch (git push origin feature/YourFeature)
    Open a Pull Request

# Authors

    @Shadowbeast

# License

Distributed under the MIT License. See LICENSE for more information.
