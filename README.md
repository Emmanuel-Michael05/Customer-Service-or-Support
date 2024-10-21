# Customer Support Ticket System Console Application

## Description
This project is a console-based customer support ticket management system, specifically designed for online shopping platforms. Users can report issues, view open tickets, and resolve issues via a simple menu-driven interface. The system tracks tickets with a unique ticket number, customer details, issue description, timestamp, and resolved status.

## Features
- **Report an Issue**: Customers can report issues by entering their name and describing the issue. Each ticket is assigned a unique ticket number.
- **View Open Tickets**: Displays all open (unresolved) tickets with details such as ticket number, customer name, issue description, and the timestamp when the issue was reported.
- **Resolve a Ticket**: Allows a customer support representative to mark a ticket as resolved by providing the ticket number.
- **Simple Menu Interface**: Provides an easy-to-navigate menu for interacting with the system.

## How to Use
1. **Report an Issue**: 
   - Select option `1` from the main menu.
   - Enter your name and describe the issue.
   - The system will generate a unique ticket number and acknowledge the submission.
   
2. **View Open Tickets**:
   - Select option `2` to display a list of all unresolved tickets.
   - Each ticket is displayed with the ticket number, customer name, issue description, and timestamp.

3. **Resolve a Ticket**:
   - Select option `3`, then enter the ticket number you wish to resolve.
   - The system will mark the ticket as resolved and confirm the action.

4. **Exit**:
   - Select option `4` to exit the program.

## How to Run
1. Clone or download this repository.
2. Open the project in Visual Studio Code or any C# IDE.
3. Run the application by pressing `F5` or using the terminal/console to execute:
   ```bash
   dotnet run
Follow the prompts to report, view, and resolve support tickets.
## Example Output
Welcome to Online Shopping Customer Support

Select an option:
1. Report an issue
2. View all open tickets
3. Resolve a ticket
4. Exit

Enter your choice: 1

Enter your name: John Doe
Describe the issue: Order not delivered yet.

Thank you, John Doe. Your ticket number is 1.

Select an option:
1. Report an issue
2. View all open tickets
3. Resolve a ticket
4. Exit

Enter your choice: 2

Open support tickets:
Ticket #1 - Customer: John Doe - Issue: Order not delivered yet. - Reported on: 10/19/2024 12:34 PM
## Files
Program.cs: Contains the logic for managing customer support tickets, including reporting issues, viewing unresolved tickets, and resolving tickets.
## Classes
SupportTicket: Represents a customer support ticket with properties like ticket number, customer name, issue description, timestamp, and resolved status. It also includes a method to mark the ticket as resolved.
Program: Contains the main logic of the application, including a menu interface for user interaction, and methods to report, view, and resolve tickets.

## Author
Emmanuel Michael Ikechukwu


This `README.md` gives an overview of your customer support ticket system, explaining its functionality, how to run the application, and example outputs. You can modify it to suit any additional features or improvements you may want to include.
