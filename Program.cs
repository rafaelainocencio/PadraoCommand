using System;

namespace PadraoCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver();
            var commanState =  (State)receiver.Handle(new Command(1, "Comando 1"));

            Console.WriteLine($"{commanState.StatusCode} - {commanState.Message}");
        }
    }
}
