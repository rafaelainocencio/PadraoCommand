using System;

						//in - entrada de valores
						//out - devolve o estado da execução
public interface IReceiver<in T, out O> 
	where T : ICommand
	where O : IState
{
	IState Handle(T command);  //tipar a entrada e a saída
}
