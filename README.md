# Dental Application System 

This is a desktop-based software application developed to support the requirements of the dentist to keep track of patients' information.

> :warning: Project still under development phase.

## Project Modules
- Dashboard
- Patient Registration 
- Patient Appointment
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
- WinForms built-in validation

## Application Architecture
A clean architecture solution has been adopted for this project. Each layer as illustrated in the diagram below has clear responsibilities.

### Application Core
 The `Application Core` holds the business model, which includes the entities, services and interfaces. This layer has been divided into two parts. The first part contains all the
common items that will be used in the subsequent layers. Interfaces include abstractions for operations that will be performed using `Infrastructure` such as data access and file 
system access.

### Infrastructure
The `Infrastructure` layer typically comprises data access implementation and all related tech stack that will be used in the application. In this application, data access implementation
code has been abstracted through the use of the [Repository Design Pattern](https://deviq.com/repository-pattern/).

### Presentation Layer
The presentation layer is the entry point of the application. For this application, a [WinForm](https://docs.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-visual-studio) has been adopted. The WinForm project references the `Application Core layer`, and its types
interact with `infrastructure` strictly through interfaces defined in the `Dental.Common`.

![Dental-Archi](https://user-images.githubusercontent.com/23207774/97895854-c0d7fd80-1d4d-11eb-9f7e-b0ac739b33ec.png)

> :exclamation: The `Program.cs` in the WinForm project is responsible for configuring the application and for wiring up implementation types to interfaces, thereby allowing dependency injection to
work properly at run time.

## Application Screens

- ### Dashboard Overview

![dashboard_app](https://user-images.githubusercontent.com/23207774/97897019-558f2b00-1d4f-11eb-9c6d-5fbec61f16de.png)

- ### Patient List

![patient_list_app](https://user-images.githubusercontent.com/23207774/97897134-7f485200-1d4f-11eb-8f70-9a206cb78feb.png)

- ### Patient Registration & Appointment Schedule

![patient_app](https://user-images.githubusercontent.com/23207774/97897116-76f01700-1d4f-11eb-81c9-480630ce4bd1.png)
