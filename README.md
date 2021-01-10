# Dental Practice Application System 

This is a web-based software solution developed to support the requirements of the dentist to keep track of patients' information.

## Project Modules
- Appointment
- Patient Registration 
- Patient records, treatment history, appointments.
- Diagnosis & Treatment details

## What has been built
Here is the basic concept:

- :white_check_mark: Dentist registers a new patient by collecting his personal information such as name, dob, health notes, diagnosis and treatments administered
- :white_check_mark: Dentist or secretary schedules upcoming appointments of patients.
- :white_check_mark: Patient List showing all patients registered.
- :white_check_mark: Dashboard showing appointment slots for the current day and number of appointments scheduled for the running week.

## Development Environments :computer:
- Visual Studio 2019
- SQL
- Git 

## Technologies
- [.NET Core SDK 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1) or higher
- [Dapper](https://github.com/StackExchange/Dapper)
- Built-in Dependency Injection
- ASP.NET Core MVC

## Application Architecture
A clean architecture solution has been adopted for this project. Each layer as illustrated in the diagram below has clear responsibilities.

### Application Core
 The `Application Core` holds the business model, which includes the entities, services and interfaces. This layer has been divided into two parts. The first part contains all the common items that will be used in the subsequent layers. Interfaces include abstractions for operations that will be performed using `Infrastructure` such as data access and file system access.

### Infrastructure
The `Infrastructure` layer typically comprises data access implementation and all related tech stack that will be used in the application. In this application, data access implementation
code has been abstracted through the use of the [Repository Design Pattern](https://deviq.com/repository-pattern/).

### Presentation Layer
The presentation layer is the entry point of the application. The Web App project references the `Application Core layer`, and its types
interact with `infrastructure` strictly through interfaces defined in the `Dental.Common`.

![Dental-Archi](https://user-images.githubusercontent.com/23207774/97895854-c0d7fd80-1d4d-11eb-9f7e-b0ac739b33ec.png)


## Application Screens

- ### Authentication
![1](https://user-images.githubusercontent.com/23207774/104124974-5c4ca680-536d-11eb-8d5c-33364d61cf68.png)

- ### View Appointment
 - **View Appointments by month**
![2](https://user-images.githubusercontent.com/23207774/104124986-68d0ff00-536d-11eb-9c73-890eaf7f86fa.png)

 - **View Appointments by week**
 ![3](https://user-images.githubusercontent.com/23207774/104125025-a0d84200-536d-11eb-8fce-b8d01bf355dc.png)
 
- ### Schedule an Appointment
![4](https://user-images.githubusercontent.com/23207774/104125026-a170d880-536d-11eb-811b-8e3eae968252.png)

- ### Patient List
![5](https://user-images.githubusercontent.com/23207774/104124989-6a9ac280-536d-11eb-8635-e7832687988c.png)

- ### Patient Details
 - **Patient Basic Information**
 ![6](https://user-images.githubusercontent.com/23207774/104125029-a2096f00-536d-11eb-97ce-64c751463978.png)
 
 - **Adding a treatment for patient**
 ![7](https://user-images.githubusercontent.com/23207774/104125031-a2a20580-536d-11eb-9585-96aac98e92cc.png)
 
 - **Viewing all treatments for patient**
 ![8](https://user-images.githubusercontent.com/23207774/104125032-a33a9c00-536d-11eb-949f-796db95957d9.png)

 - **View all past and upcoming appointments for patient**
 ![9](https://user-images.githubusercontent.com/23207774/104125033-a3d33280-536d-11eb-9da4-097d77dd995b.png)


