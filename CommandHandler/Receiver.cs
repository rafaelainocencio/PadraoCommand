using System;

//CommandHandler
//Manipula dados do command
public class Receiver : IReceiver<Command, IState>
{
    public IState Handle(Command command) //retorna IState, recebe ICommand
    {
        command.Execute();
        return new State(200, "Comando executado com sucesso");
    }
}

