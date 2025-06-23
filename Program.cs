string[]caracteristica={ "Endiabrado", "Radioativo", "Endemoniado", "Vermelho", "Possuído", "Macabro", "Sombrio", "Sem Cabeça", "Desconhecido", "Inconsciente", "Oculto", "Esquecido", "Lúgubre", "Invocado", "Caído", "Costurado", "Amaldiçoado", "Anormal", "Perturbado", "Sanguinário", "Tenebroso", "Imortal", "Ressuscitado", "do Pântano", "da Encruzilhada", "do Porão", "do Velho Poço", "sem Perdão", "do Cemitério", "da Meia-Noite", "da Lua Cheia" };

string[]nome={"O Zumbi","O Assassino","O Psicopata","O Alienígena","O Carniceiro","O Matador","O Vampiro","O Maluco","O Vingador","O Monstro","O Bruxo","O Demônio"};

int mes, dia;
string tipo, variedade, monstro;

Console.WriteLine("\n---------- Noite de Terror ----------");
Console.Write("Qual o seu dia de nascimento? (de 1 até 31): ");
dia=Convert.ToInt32(Console.ReadLine());

if (dia<1||dia>31) return;

Console.Write("Qual o seu mês de nascimento? (de 1 até 12): ");
mes=Convert.ToInt32(Console.ReadLine());

if (mes<1||mes> 12) return;

tipo=nome[mes - 1];
variedade=caracteristica[dia - 1];
monstro=$"{tipo} {variedade}";

Console.WriteLine($"\nCorre que está vindo aí o: {monstro}!!!!!");
