![Cafe POS](https://github.com/user-attachments/assets/3ae7a81f-4595-43dc-b3c2-bab84778e72d)# ☕ Café POS Management System

A robust, desktop-based Point of Sale (POS) solution built with **C#** and **.NET**, designed to streamline cafe operations through automated inventory tracking and role-based management.

## 🚀 Overview
This project is an Object-Oriented Programming (OOP) based Windows Forms Application developed using the .NET Framework. It provides a structured, user-friendly desktop interface to manage operations through a secure, role-based access system. The application uses Visual Studio Server Explorer for database management, ensuring secure and efficient data storage and retrieval.

## ✨ Key Features

### 👤 Admin Capabilities
* **User & Staff Management**: Full control to add, update, and remove employee data, and manage the admin profile.
* **Menu Management**: Category-wise management including adding, updating, and deleting menu items for dine-in and takeaway.
* **Inventory Tracking**: Monitor stock of products and ingredients with automatic updates after sales and a low-stock alert system.
* **Reports & Analytics**: Generate best-selling product reports and view sales performance via a 3-4 month sales graph.

### 🧑‍💼 Employee Capabilities
* **Order Processing**: Efficiently handle dine-in and takeaway orders.
* **Billing & Payments**: Generate instant bills and process payments via cash, card, or digital methods, applying taxes and discounts as needed.
* **Real-time Stock**: View current product lists and stock availability directly from the dashboard.

## 🛠️ Technical Stack
* **Language**: C# 
* **Framework**: .NET Framework (Windows Forms)
* **Database**: Visual Studio Server Explorer
* **Design Principles**: Object-Oriented Programming (Encapsulation, Reusability, and Scalability)

## 📊 Database Design
The system architecture is backed by a database normalized up to the Second Normal Form (2NF) to ensure data consistency and eliminate redundancy.

### Core Relations:
* **Admin/Employees**: Secured user credentials, salary information, and contact details.
* **Inventory**: Tracking Item IDs, categories, pricing, stock levels, and items sold.
* **Orders**: Transactional data including date, total, order type, and payment method, linked to users via Foreign Keys.

## 📝 Contributors (Group 03 - Section P)
| Name | ID |
| :--- | :--- |
| **HOQUE, MUNTASIRUL** | 23-53907-3 |
| **HALIM, RIFAT BIN** | 23-54711-3 |
| **SAIEED, MD ABU** | 23-54744-3 |
| **KHAN, MD FAHIM HOSSAIN** | 24-56561-1 |

---
**Supervised By:** Noboranjan Dey  
**Institution:** American International University-Bangladesh (AIUB)  
**Course:** CSC 2210: Object Oriented Programming 2 (Fall 2025-2026)
<img src="Cafe POS.gif" width="600" alt="Cafe POS Demo">


