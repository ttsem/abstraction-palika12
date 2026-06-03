using System;

// Printer interface
public interface IPrinter
{
    void Print();
}

// Scanner interface
public interface IScanner
{
    void Scan();
}

// Concrete Printer class
public class Printer : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }
}

// Concrete Scanner class
public class Scanner : IScanner
{
    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}

// Combined device using composition
public class PrintScanner : IPrinter, IScanner
{
    private readonly IPrinter _printer;
    private readonly IScanner _scanner;

    public PrintScanner(IPrinter printer, IScanner scanner)
    {
        _printer = printer;
        _scanner = scanner;
    }

    public void Print()
    {
        _printer.Print();
    }

    public void Scan()
    {
        _scanner.Scan();
    }
}

// Task manager
public class TaskManager
{
    public void PrintTask(int taskId, IPrinter printer)
    {
        Console.WriteLine($"Executing Print Task: {taskId}");
        printer.Print();
    }

    public void ScanTask(int taskId, IScanner scanner)
    {
        Console.WriteLine($"Executing Scan Task: {taskId}");
        scanner.Scan();
    }
}

// Main program
public class Program
{
    public static void Main()
    {
        IPrinter printer = new Printer();
        IScanner scanner = new Scanner();

        // Combined device
        PrintScanner printScanner = new PrintScanner(printer, scanner);

        TaskManager manager = new TaskManager();

        // Individual devices
        manager.PrintTask(101, printer);
        manager.ScanTask(102, scanner);

        // Combined device
        manager.PrintTask(103, printScanner);
        manager.ScanTask(104, printScanner);
    }
}
