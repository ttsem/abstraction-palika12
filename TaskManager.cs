using System;

// Common interface
public interface ITaskDevice
{
    void Execute();
}

// Printer implementation
public class Printer : ITaskDevice
{
    public void Execute()
    {
        Console.WriteLine("Printing document...");
    }
}

// Scanner implementation
public class Scanner : ITaskDevice
{
    public void Execute()
    {
        Console.WriteLine("Scanning document...");
    }
}

// Task Manager
public class TaskManager
{
    public void ExecuteTask(int taskId, ITaskDevice device)
    {
        Console.WriteLine($"Executing Task: {taskId}");
        device.Execute();
    }
}

public class Program
{
    public static void Main()
    {
        var printer = new Printer();
        var scanner = new Scanner();

        var scheduler = new TaskManager();

        scheduler.ExecuteTask(101, printer);
        scheduler.ExecuteTask(102, scanner);
    }
}