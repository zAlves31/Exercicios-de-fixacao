Console.Write("Descrição do produto: ");
string nome = Console.ReadLine();

Console.Write("Quantidade adquirida: ");
int quantidade = int.Parse(Console.ReadLine());

Console.Write("Preço unitário: ");
double preco = double.Parse(Console.ReadLine());

double total = quantidade * preco;
double desconto = 0;

if (quantidade <= 5)
{
    desconto = total * 0.02;
}
else if (quantidade <= 10)
{
    desconto = total * 0.03;
}
else
{
    desconto = total * 0.05;
}

double totalAPagar = total - desconto;

Console.WriteLine($"Total: R$ {total:F2}");
Console.WriteLine($"Desconto: R$ {desconto:F2}");
Console.WriteLine($"Total a pagar: R$ {totalAPagar:F2}");
    
