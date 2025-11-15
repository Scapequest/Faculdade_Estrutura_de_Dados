No inicio = null;
No fim = null;

void Insere(int valor)
{
    No novo = new No();
    novo.valor = valor;
    novo.prox = null;
    if (inicio == null)
    {
        inicio = novo;
        fim = novo;
    }
    else
    {
        fim.prox = novo;
        fim = novo;
    }
}
int Remove()
{
    int valorRemovido = inicio.valor;
    inicio = inicio.prox;
    if (inicio == null)
    {
        fim = null;
    }
    return valorRemovido;
}

void Exibe()
{
    if (inicio == null)
    {
        Console.WriteLine("Fila está vazia.");
        return;
    }
    No aux = inicio;
    Console.Write("Fila atual: ");
    while (aux != null)
    {
        Console.Write(aux.valor + " ");
        aux = aux.prox;
    }
    Console.WriteLine();
}

string op1;
op1 = "0";
while (op1 != "4")
{
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 - Adicionar número na fila");
    Console.WriteLine("2 - Remover da fila");
    Console.WriteLine("3 - Exibir Fila");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha a opção desejada: ");
    op1 = Console.ReadLine();
    if (op1 == "1")
    {
        Console.WriteLine("Quantos números quer digitar?");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
          Console.Write($"Digite o {i+1}º número: ");
          Insere(Convert.ToInt32(Console.ReadLine()));
        }
        Exibe();
    }
    else if (op1 == "2")
    {
        Console.WriteLine($"Removendo o elemento {Remove()} da fila");
        Exibe();
    }
    else if (op1 == "3")
    {
        Exibe();
    }
}

class No
{
    public int valor;
    public No prox;
}
