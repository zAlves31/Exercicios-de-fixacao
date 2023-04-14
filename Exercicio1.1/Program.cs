Console.Write("Digite o ano atual: ");
int anoAtual = int.Parse(Console.ReadLine());

Console.Write("Digite o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

int idade = anoAtual - anoNascimento;

if (idade >= 16) {
Console.WriteLine("Você poderá votar este ano!");
} 
else 
{
Console.WriteLine("Você não poderá votar este ano.");
}
    

