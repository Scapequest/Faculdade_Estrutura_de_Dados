int[] fila = new int[20];
int inicio = 0, fim = 0;

void Insere(int valor)
{
  fila[fim] = valor;
  fim = fim + 1;
}

int Remove()
{
  inicio = inicio + 1;
  return (fila[inicio - 1]);
}

bool EstaVazia()
{
  if (inicio == fim)
    return true;
  else
    return false;
}

bool EstaCheio()
{
  if (fim == 20)
    return true;
  else
    return false;
}

Console.WriteLine("Quantos números quer digitar?");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
  Console.Write($"Digite o {i+1}º número: ");
  Insere(Convert.ToInt32(Console.ReadLine()));
}

int maior = fila[inicio];
int menor = fila[inicio];
int soma = 0;

while (!EstaVazia())
{
  int temp = Remove();
  if (temp > maior)
    maior = temp;
  if (temp < menor)
    menor = temp;
  soma = soma + temp;
}

float media = (float)soma / n;

Console.WriteLine($"Maior número: {maior}");
Console.WriteLine($"Menor número: {menor}");
Console.WriteLine($"Média Aritmética: {media}");