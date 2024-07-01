using System;
using System.Collections.Generic;

// Define a class for customer support tickets
public class SupportTicket
{
    public int TicketNumber { get; private set; }
    public string CustomerName { get; set; }
    public string IssueDescription { get; set; }
    public DateTime Timestamp { get; private set; }
    public bool Resolved { get; set; }

    public SupportTicket(int ticketNumber, string customerName, string issueDescription)
    {
        TicketNumber = ticketNumber;
        CustomerName = customerName;
        IssueDescription = issueDescription;
        Timestamp = DateTime.Now;
        Resolved = false;
    }

    // Method to mark the ticket as resolved
    public void ResolveTicket()
    {
        Resolved = true;
    }
}

// Main program to demonstrate usage
class Program
{
    static List<SupportTicket> supportTickets = new List<SupportTicket>();
    static int ticketNumberCounter = 1;

    static void Main()
    {
        Console.WriteLine("Welcome to Online Shopping Customer Support");

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Report an issue");
            Console.WriteLine("2. View all open tickets");
            Console.WriteLine("3. Resolve a ticket");
            Console.WriteLine("4. Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    ReportIssue();
                    break;
                case 2:
                    ViewOpenTickets();
                    break;
                case 3:
                    ResolveTicket();
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }

    static void ReportIssue()
    {
        Console.WriteLine("\nEnter your name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("Describe the issue:");
        string issueDescription = Console.ReadLine();

        SupportTicket newTicket = new SupportTicket(ticketNumberCounter, customerName, issueDescription);
        supportTickets.Add(newTicket);
        ticketNumberCounter++;

        Console.WriteLine($"\nThank you, {customerName}. Your ticket number is {newTicket.TicketNumber}.");
    }

    static void ViewOpenTickets()
    {
        if (supportTickets.Count == 0)
        {
            Console.WriteLine("\nNo open support tickets.");
            return;
        }

        Console.WriteLine("\nOpen support tickets:\n");
        foreach (var ticket in supportTickets)
        {
            if (!ticket.Resolved)
            {
                Console.WriteLine($"Ticket #{ticket.TicketNumber} - Customer: {ticket.CustomerName} - Issue: {ticket.IssueDescription} - Reported on: {ticket.Timestamp}");
            }
        }
    }

    static void ResolveTicket()
    {
        if (supportTickets.Count == 0 || supportTickets.All(t => t.Resolved))
        {
            Console.WriteLine("\nNo unresolved tickets to resolve.");
            return;
        }

        Console.WriteLine("\nEnter the ticket number to resolve:");
        int ticketNumber;
        if (!int.TryParse(Console.ReadLine(), out ticketNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid ticket number.");
            return;
        }

        SupportTicket ticketToResolve = supportTickets.Find(t => t.TicketNumber == ticketNumber);

        if (ticketToResolve == null)
        {
            Console.WriteLine($"Ticket #{ticketNumber} not found.");
            return;
        }

        if (ticketToResolve.Resolved)
        {
            Console.WriteLine($"Ticket #{ticketNumber} is already resolved.");
            return;
        }

        ticketToResolve.ResolveTicket();
        Console.WriteLine($"Ticket #{ticketNumber} resolved successfully.");
    }
}
