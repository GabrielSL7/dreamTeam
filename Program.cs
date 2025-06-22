﻿Console.WriteLine("==== TIME DOS SONHOS DA NBA ====\n");

string[] jogadores = {
    "Michael Jordan (Armador)",
    "LeBron James (Ala)",
    "Kareem Abdul-Jabbar (Pivô)",
    "Magic Johnson (Armador)",
    "Wilt Chamberlain (Pivô)",
    "Bill Russell (Pivô)",
    "Larry Bird (Ala)",
    "Tim Duncan (Ala-pivô)",
    "Oscar Robertson (Armador)",
    "Kobe Bryant (Armador)",
    "Shaquille O'Neal (Pivô)",
    "Kevin Durant (Ala)",
    "Hakeem Olajuwon (Pivô)",
    "Julius Erving (Ala)",
    "Moses Malone (Pivô)",
    "Stephen Curry (Armador)",
    "Dirk Nowitzki (Ala-pivô)",
    "Giannis Antetokounmpo (Ala-pivô)",
    "Jerry West (Armador)",
    "Elgin Baylor (Ala)"
};

List<int> escolhidos = new List<int>();

Console.WriteLine("LISTA DOS 20 MELHORES JOGADORES:\n");

for (int i = 0; i < jogadores.Length; i++)
{
    Console.WriteLine($"{i + 1:D2}) {jogadores[i]}");
}

Console.WriteLine("\nEscolha 5 jogadores para compor seu time ideal.\n");

int contador = 0;

while (escolhidos.Count < 5)
{
    Console.Write($"Jogador #{contador + 1}: Informe o número do Top (1 a 20): ");
    if (!int.TryParse(Console.ReadLine(), out int indice) || indice < 1 || indice > 20)
    {
        Console.WriteLine("⚠️ Número inválido. Tente novamente.\n");
        continue;
    }

    int indiceCorrigido = indice - 1;
    if (escolhidos.Contains(indiceCorrigido))
    {
        Console.WriteLine("⚠️ Jogador já foi escolhido. Tente outro.\n");
        continue;
    }

    escolhidos.Add(indiceCorrigido);
    contador++;
}

escolhidos.Sort();

Console.WriteLine("\n🏀 Seu Time dos Sonhos:\n");

foreach (int id in escolhidos)
{
    Console.WriteLine($" - {jogadores[id]}");
}
