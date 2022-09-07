// See https://aka.ms/new-console-template for more information
Console.WriteLine("Minha calculadora");

int valor1, valor2 = 0;
string operacao = "", continua = "C";

while (continua == "C")
{

Console.WriteLine("Informe o primeiro valor: ");
valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a operação solicitada: (+ - / *) ");
string operação = Console.ReadLine();

Console.WriteLine("Informe o segundo valor: ");
valor2 = int.Parse(Console.ReadLine());



    if (operação == "+")
    {
        Console.WriteLine("Resultado é: " + (valor1 + valor2));
    }

    else if (operação == "-")
    {
        Console.WriteLine("Resultado é: " + (valor1 - valor2));
    }

    else if (operação == "*")
    {
        Console.WriteLine("Resultado é: " + (valor1 * valor2));
    }

    else if (operação == "/")
    {
        Console.WriteLine("Resultado é:" + (valor1 / valor2));
    }
    else
    {
        Console.WriteLine("Operação inválida");
    }

    Console.WriteLine("Digite S para sair ou C para continuar");
    continua = Console.ReadLine();
}
Console.ReadKey();

/*


switch(operacao)
{ 
case "+":
    resultado = valor1 + valor2;
    break;

case "-":
    resultado = valor1 - valor2;
    break;

case "*":
    resultado = valor1 * valor2;
    break;

case "/":
    resultado = valor1 / valor2;
    break;

default:
    Console.WriteLine("Operação inválida");
}

    Console.WriteLine("{0} {1} {2} = {3}", valor1, operacao, valor2, resultado);

*/
