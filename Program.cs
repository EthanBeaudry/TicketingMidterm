using System;
using System.IO;
using System.Collections.Generic;

namespace TicketingMidterm
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ticketing System");
            Console.Write("Would you like to create a ticket (Y/N)? ");
            char choice = Console.ReadLine().ToUpper()[0];

            while (choice == 'Y')
            {
                Console.WriteLine("Please enter the number of the ticket type you would like to create:\n1. Bug/Defect ticket\n2. Enahancement ticket\n3. Task ticket");
                int ticketType = Convert.ToInt32(Console.ReadLine());

                if(ticketType == 1)
                {
                    string file = "Tickets.csv";
                    StreamWriter sw = new StreamWriter(file);
                    Ticket ticket = new Ticket();

                    Console.Write("Ticket number: ");
                    ticket.ticketNumber = Console.ReadLine();
                    Console.Write("Summary: ");
                    ticket.ticketSummary = Console.ReadLine();
                    Console.Write("Status: ");
                    ticket.ticketStatus = Console.ReadLine();
                    Console.Write("Priority: ");
                    ticket.ticketPriority = Console.ReadLine();
                    Console.Write("Submitter: ");
                    ticket.ticketSubmitter = Console.ReadLine();
                    Console.Write("Assigned: ");
                    ticket.ticketAssignedTo = Console.ReadLine();
                    Console.WriteLine("Serverity: ");
                    ticket.ticketSeverity = Console.ReadLine();
                    Console.Write("Would you like to add a watcher (Y/N)? ");
                    choice = Console.ReadLine().ToUpper()[0];

                    while (choice == 'Y')
                    {
                        Console.Write("Enter the name of the watcher: ");
                        string addName = Console.ReadLine();
                        ticket.ticketWatchers.Add(addName);
                        Console.Write("Would you like to add another watcher (Y/N)? ");
                        choice = Console.ReadLine().ToUpper()[0];
                    } 

                    sw.WriteLine(ticket.Display());
                    sw.Close();
                    Console.Write("Would you like to create another ticket (Y/N)? ");
                    choice = Console.ReadLine().ToUpper()[0];
                }

                else if(ticketType == 2)
                {
                    string file = "Enhancements.csv";
                    StreamWriter sw = new StreamWriter(file);
                    Enhancements enhancement = new Enhancements();

                    Console.Write("Ticket number: ");
                    enhancement.enhancementNumber = Console.ReadLine();
                    Console.Write("Summary: ");
                    enhancement.enhancementSummary = Console.ReadLine();
                    Console.Write("Status: ");
                    enhancement.enhancementStatus = Console.ReadLine();
                    Console.Write("Priority: ");
                    enhancement.enhancementPriority = Console.ReadLine();
                    Console.Write("Submitter: ");
                    enhancement.enhancementSubmitter = Console.ReadLine();
                    Console.Write("Assigned: ");
                    enhancement.enhancementAssignedTo = Console.ReadLine();
                    Console.Write("Type of software: ");
                    enhancement.enhancementSoftware = Console.ReadLine();
                    Console.Write("Cost: ");
                    enhancement.enhancementCost = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Reason for change: ");
                    enhancement.enhancementReason = Console.ReadLine();
                    Console.Write("Estimate: ");
                    enhancement.enhancementEstimate = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Would you like to add a watcher (Y/N)? ");
                    choice = Console.ReadLine().ToUpper()[0];

                    while (choice == 'Y')
                    {
                        Console.Write("Enter the name of the watcher: ");
                        string addName = Console.ReadLine();
                        enhancement.enhancementWatchers.Add(addName);
                        Console.Write("Would you like to add another watcher (Y/N)? ");
                        choice = Console.ReadLine().ToUpper()[0];
                    }
                    sw.WriteLine(enhancement.Display());
                    sw.Close();
                    Console.Write("Would you like to create another ticket (Y/N)? ");
                    choice = Console.ReadLine().ToUpper()[0];
                }

                else if (ticketType == 3)
                {
                    string file = "Task.csv";
                    StreamWriter sw = new StreamWriter(file);
                    Task task = new Task();

                    Console.Write("Ticket number: ");
                    task.taskNumber = Console.ReadLine();

                    Console.Write("Summary: ");
                    task.taskSummary = Console.ReadLine();

                    Console.Write("Status: ");
                    task.taskStatus = Console.ReadLine();

                    Console.Write("Priority: ");
                    task.taskPriority = Console.ReadLine();

                    Console.Write("Submitter: ");
                    task.taskSubmitter = Console.ReadLine();

                    Console.Write("Assigned: ");
                    task.taskAssignedTo = Console.ReadLine();

                    Console.WriteLine("Project name: ");
                    task.taskProjectName = Console.ReadLine();

                    Console.WriteLine("Enter a due date (MM/DD/YY): ");
                    task.taskDate = DateTime.Parse(Console.ReadLine());

                    Console.Write("Would you like to add a watcher (Y/N)? ");
                    choice = Console.ReadLine().ToUpper()[0];

                    while (choice == 'Y')
                    {
                        Console.Write("Enter the name of the watcher: ");
                        string addName = Console.ReadLine();
                        task.taskWatchers.Add(addName);

                        Console.Write("Would you like to add another watcher (Y/N)? ");
                        choice = Console.ReadLine().ToUpper()[0];
                    }
                    sw.WriteLine(task.Display());
                    sw.Close();
                    
                    Console.Write("Would you like to create another ticket (Y/N)? ");
                    choice = Console.ReadLine().ToUpper()[0];
                }
                else if(ticketType != 1 && ticketType != 2 && ticketType != 3)
                {
                    Console.WriteLine("Error: Please Enter a Valid Number");
                }
            } 
        }
    }
}