using Operacoes;

while(true)
{
    Console.Clear();
    Console.WriteLine(
        "Qual Operação deseja realizar? \n\n(1) Somar \n(2) Subtração \n(3) Multiplicação \n(4) Divisão \n(5) Potenciação \n(6) Sair"
    );
    string Menu = Console.ReadLine()?.ToLower()??" ";
    
    switch(Menu)
    {
        case "1":
        case "somar":
            Calculos.soma(
                Facilitador.ValorDecimal(1),
                Facilitador.ValorDecimal(2)
            );
            Facilitador.Pausa();
        break;

        case "2":
        case "subtração":
            Calculos.Subtração(
                Facilitador.ValorDecimal(1),
                Facilitador.ValorDecimal(2)
            );
            Facilitador.Pausa();
        break;

        case "3":
        case "multiplicação":
            Calculos.Multiplicação(
                Facilitador.ValorDecimal(1),
                Facilitador.ValorDecimal(2)
            );
            Facilitador.Pausa();
        break;

        case "4":
        case "divisão":
            Calculos.Divizão(
                Facilitador.ValorDecimal(1),
                Facilitador.ValorDecimal(2)
            );
            Facilitador.Pausa();
        break;

        case "5":
        case "Potenciação":
            Calculos.Potenciação(
                Facilitador.ValorDouble(1),
                Facilitador.ValorDouble(2)
            );
            Facilitador.Pausa();
        break;

        case "6":
        case "sair":
        return;

    }
}