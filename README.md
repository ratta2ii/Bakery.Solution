# **Pierre's Bakery**

###### By Trevor Mackin 01/10/2020  

### **Description**

_This is a server side application built in C# using ASP.Net Core MVC. The application is for a Bakery owner to keep track of his Vendors and their orders. The application uses 2 separate classes; One class to add new Vendors, and one class to add new Orders to a specific Vendor. When a user runs the application they should be welcomed on a splash page and given a link to look at their Vendors. From here, the user should be able to add a new vendor, or click on a Vendor in order to view that specific Vendors order. From the list Orders, a user then click on a specific Order to view further details._
#

#
###  **Setup/Installation Requirements**

1. Open https://ratta2ii.github.io/Bakery.Soultion
2. Clone repository to local machine
3. $ dotnet build (run this inside the root directory)
4. $ dotnet watch run (run in the Command Line Interface to View Project)
5. Follow prompts to add Vendors and Orders

#
### **Specifications**

##### Example 1:
#
####
    Welcome to Pierre

    Add New Vendors (This a link that will take you to a page to list all Vendors, with the option to add additional ones to the list.)

##### Example 2:
#
####
    New Vendor Form

    Enter a Vendor Name:
    User Input: Ed's Warehouse

    Enter a Description:
    User Input: Bread (All Types)

    Output: This will store the Vendor in a list of Vendors, then display the complete Vendor List.

##### Example 3:
#

    New Order Form

    Enter Title:
    User Input: Plates

    Enter Description:
    User Input: 200 small white

    Enter a Price:
    User Input: $ 399.99

    OUTPUT: These items will then be stored in a list and displayed in a view in addition to the other orders in the list.

### **Technologies Used**

* C#
* netcoreapp2.2
* ASP.NET Core MVC
* CSS
* Razor

### **License**

Copyright (c) 2019 **Trevor Mackin**
