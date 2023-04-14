string[] nomes = new string[10];


for (int i = 0; i < 10; i++) {
    Console.Write($"Digite o nome da {i+1}ª pessoa: ");
    nomes[i] = Console.ReadLine();
}

Console.Write("Digite o nome que deseja buscar: ");
string nomeBusca = Console.ReadLine();

bool achou = false;
foreach (string nome in nomes) {
    if (nome == nomeBusca) {
    achou = true;
    break;
}

}

if (achou) {
    Console.WriteLine("ACHEI");
} else {
    Console.WriteLine("NÃO ACHEI");
}