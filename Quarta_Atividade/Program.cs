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

Console.WriteLine("");