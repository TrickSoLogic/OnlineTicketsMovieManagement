<<<<<<< HEAD
# OnlineTicketsMovieManagement 
=======
# OnlineTicketsMovieManagement

Online Tickets Movie Management System

Overview
This project is an Online Tickets Movie Management System that facilitates the management of movies, cinemas, actors, producers, and user orders for an online movie ticket booking platform.

Features
Movies: CRUD operations for managing movies, including details, creation, editing, and deletion.
Cinemas: Administration of cinema details and management.
Actors & Producers: Create, edit, and delete actors and producers associated with movies.
Orders: Users can add movies to their cart and complete orders for tickets.

Technologies Used:
1  C#: Backend development using ASP.NET Core MVC for server-side logic.

2  HTML/CSS: Frontend development for UI/UX components.

3  Razor Views: Utilized for templating and frontend logic in ASP.NET Core MVC.

4  Entity Framework Core: ORM used for interacting with the database.

5  SQL Server: Backend database for storing movies, users, orders, and other relevant information.

6  PayPal Integration: Used PayPal's API for payment processing.

7  Visual Studio: IDE for development and project management.

8  Git: Version control system for collaborative development.

Setup Instructions
Clone the repository.
Open the project in Visual Studio.
Ensure you have .NET Core SDK installed.
Set up the database using Entity Framework migrations.
Configure PayPal API credentials in the appropriate settings file.
Run the project locally or deploy it to a hosting service.
PayPal Integration
The project includes PayPal integration for handling payment processing. To use PayPal functionality:

Obtain PayPal API credentials (Client ID, Secret) from the PayPal Developer Dashboard.
Configure these credentials in the appsettings.json or a separate configuration file used for sensitive data.
Implement PayPal SDK for payment processing in the relevant controllers and views.

Contributors:
Vishal Bhat - Software Engineer
>>>>>>> dbf071cfe26a518a0ee9fd1a14bce878f56197fa
