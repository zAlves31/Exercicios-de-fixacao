
Console.Write("Digite o tipo de combustível (A-álcool, G-gasolina): ");
char tipoCombustivel = char.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de litros vendidos: ");
double litros = double.Parse(Console.ReadLine());

double precoLitro = 0.0;
double desconto = 0.0;

switch (tipoCombustivel) {
    case 'A':
    precoLitro = 4.90;
    if (litros <= 20) {
        desconto = 0.03;
    } 
    else {
        desconto = 0.05;
    }
    break;
    case 'G':
        precoLitro = 5.30;
        if (litros <= 20) {
            desconto = 0.04;
    } else {
        desconto = 0.06;
    }
    break;
    default:
        Console.WriteLine("Tipo de combustível inválido!");
    return;
        }

double valorTotal = litros * precoLitro;
double valorDesconto = valorTotal * desconto;
double valorFinal = valorTotal - valorDesconto;

Console.WriteLine($"Valor a pagar: R$ {valorFinal:F2}");