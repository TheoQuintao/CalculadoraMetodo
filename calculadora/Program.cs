using Operacoes;

while(true)
{
    return1:
    Console.Clear();
    Console.WriteLine(
        "Qual Operação deseja realizar? \n\n(1) Somar \n(2) Subtração \n(3) Multiplicação \n(4) Divisão \n(5) Sair"
    );
    if(!int.TryParse(Console.ReadLine(), out int Menu))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor invalido!!");
        Thread.Sleep(1500);
        Console.ResetColor();
        goto return1;
    }
    
    switch(Menu)
    {
        case 1:
            Calculos.soma(
                Facilitador.ValorDecimal(1),
                Facilitador.ValorDecimal(2)
            );
            Facilitador.Pausa();
        break;

        case 2:
            Calculos.Subtração(
                Facilitador.ValorDecimal(1),
                Facilitador.ValorDecimal(2)
            );
            Facilitador.Pausa();
        break;

        case 3:
            Calculos.Multiplicação(
                Facilitador.ValorDecimal(1),
                Facilitador.ValorDecimal(2)
            );
            Facilitador.Pausa();
        break;

        case 4:
            Calculos.Divizão(
                Facilitador.ValorDecimal(1),
                Facilitador.ValorDecimal(2)
            );
            Facilitador.Pausa();
        break;

        case 5:
        return;

    }
}