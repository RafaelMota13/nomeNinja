Console.WriteLine();
Console.Write("Digite seu nome: ");

string nomeDigitado = Console.ReadLine();

string nomeNinja = nomeDigitado.ToLower()
                    .Replace("a", "KA")
                    .Replace("á", "KA")
                    .Replace("ã", "KA")
                    .Replace("â", "KA")
                    .Replace("b", "ZU")
                    .Replace("c", "MI")
                    .Replace("d", "TE")
                    .Replace("e", "KU")
                    .Replace("é", "KU")
                    .Replace("ê", "KU")
                    .Replace("f", "LU")
                    .Replace("g", "JI")
                    .Replace("h", "RI")
                    .Replace("i", "KI")
                    .Replace("j", "ZUS")
                    .Replace("k", "ME")
                    .Replace("l", "TA")
                    .Replace("m", "RIN")
                    .Replace("n", "TO")
                    .Replace("o", "MO")
                    .Replace("õ", "MO")
                    .Replace("ó", "MO")
                    .Replace("ô", "MO")
                    .Replace("p", "NO")
                    .Replace("q", "KE")
                    .Replace("r", "SHI")
                    .Replace("s", "ARI")
                    .Replace("t", "CHI")
                    .Replace("u", "DO")
                    .Replace("v", "RU")
                    .Replace("w", "MEI")
                    .Replace("x", "NA")
                    .Replace("y", "FU")
                    .Replace("z", "ZI")
                    .ToLower();

string inicial = nomeNinja.Substring(0,1).ToUpper();
string restante = nomeNinja.Substring(1);

nomeNinja = $"{inicial}{restante}";

Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine($"Seu nome ninja é {nomeNinja}");
Console.WriteLine();

Console.ResetColor();


