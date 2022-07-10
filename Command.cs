using System;

public class Command : ICommand
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    public Command(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Execute()
    {
        Console.WriteLine($"Comando executado: {this.Id} - {this.Name}");
    }
}
