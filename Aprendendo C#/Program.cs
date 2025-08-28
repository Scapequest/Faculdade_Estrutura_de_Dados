void crescente(int nI, int nF)
{
  if (nI <= nF)
  {
    Console.WriteLine(nI);
    crescente(nI + 1, nF);
  }
}

void decrescente(int nI, int nF)
{
  if (nI >= nF)
  {
    Console.WriteLine(nF);
    decrescente(nI, nF - 1);
  }
}

void impares(int nI, int nF)
{
  if (nI <= nF)
  {
    if (nI % 2 != 0)
      Console.WriteLine(nI);
    impares(nI + 1, nF);
  }
}

int somatoria(int nI, int nF)
{
  if (nI == nF)
    return nF;
  else
    return nI + somatoria(nI + 1, nF);
}

int somatoriaVetor(int[] vetor, int n)
{
  if (n == 0)
    return vetor[n];
  else
    return somatoriaVetor(vetor, n-1) + vetor[n];
}

string op;
op = "0";
while (op != "3")
{
  Console.WriteLine("MENU PRINCIPAL");
  Console.WriteLine("1 - Funções sem vetor");
  Console.WriteLine("2 - Função com vetor");
  Console.WriteLine("3 - Sair");
  Console.WriteLine("Digite a opção desejada: ");
  op = Console.ReadLine();
  if (op == "1")
  {
    int nI, nF;
    Console.WriteLine("Número Inicial: ");
    nI = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Número Final: ");
    nF = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("MENU SECUNDARIO");
    Console.WriteLine("1 - Ordem crescente");
    Console.WriteLine("2 - Ordem decrescente");
    Console.WriteLine("3 - Somente impares");
    Console.WriteLine("4 - Somatório");
    Console.Write("Opção desejada: ");
    string op2 = Console.ReadLine();
    if (op2 == "1")
    {
      Console.WriteLine($"Apresentando ordem crescente entre {nI} e {nF}:");
      crescente(nI, nF);
    }
    else if (op2 == "2")
    {
      Console.WriteLine($"Apresentando ordem decrescente entre {nF} e {nI}:");
      decrescente(nI, nF);
    }
    else if (op2 == "3")
    {
      Console.WriteLine($"Apresentando números ímpares entre {nI} e {nF}:");
      impares(nI, nF);
    }
    else if (op2 == "4")
    {
      Console.WriteLine($"Apresentando somatória dos números entre {nI} e {nF}:");
      Console.WriteLine(somatoria(nI, nF));
    }
  }
  else if (op == "2")
  {
    Console.WriteLine("Digite a quantidade de números desejados: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] vetor = new int[n];
    for (int i = 0; i < n; i++)
    {
      Console.WriteLine($"Digite o {i+1}º número:");
      vetor[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Resultado da Somatória: {somatoriaVetor(vetor, n-1)}");
  }
}