char[] pilha = new char[20];
int topo = 0;

void Insere(char valor)
{
  pilha[topo] = valor;
  topo = topo + 1;
}
char Remove()
{
  topo = topo - 1;
  return (pilha[topo]);
}
bool EstaVazia()
{
  if (topo == 0)
      return true;
  else
      return false;
}
bool EstaCheia()
{
  if (topo == 20)
    return true;
  else
    return false;
}

Console.WriteLine("Digite a frase: ");
string entrada = Console.ReadLine();
string saida = "";

for (int i = 0; i <= entrada.Length; i++)
{
  if (i == (entrada.Length))
  {
    while (topo > 0)
      saida = saida + Remove();
  }
  else if (entrada[i] != ' ')
    Insere(entrada[i]);
  else if (entrada[i] == ' ')
  {
    while (topo > 0)
      saida = saida + Remove();
    saida = saida + ' ';
  }
}

Console.WriteLine(saida);
