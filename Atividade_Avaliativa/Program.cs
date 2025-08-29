int Potencia(int x, int y)
{
    if (y == 1)
        return x;
    else
    {
        return Potencia(x, y - 1) * x;
    }
}
void CubosR(int n)
{
    if (n == 1)
        Console.WriteLine(n*n*n);
    else
    {
        CubosR(n-1);
        Console.WriteLine(n*n*n);
    }
}
int Mdc(int x, int y)
{
    if (x == y)
        return x;
    else if (x < y)
        return Mdc(y, x);
    else
        return Mdc(x-y, y);
}
int FibonacciR(int n)
{
    if (n == 0 || n == 1)
        return n;
    else
        return FibonacciR(n-1) + FibonacciR(n-2);
}
int FibonacciI(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;
    int anterior = 0;
    int atual = 1;
    for (int i = 2; i <= n; i++)
    {
        int proximo = anterior + atual;
        anterior = atual;
        atual = proximo;
    }
    return atual;
}
void Binario(int n)
{
    if (n == 1)
        Console.Write(1);
    else
    {
        Binario(n/2);
        Console.Write(n%2);
    }
}
string op1;
op1 = "0";
while (op1 != "6")
{
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1 - Potência");
    Console.WriteLine("2 - Cubo");
    Console.WriteLine("3 - Algoritmo de Euclide (MDC)");
    Console.WriteLine("4 - Fibonacci");
    Console.WriteLine("5 - Converter Número para Binário");
    Console.WriteLine("6 - Sair");
    Console.Write("Escolha a opção desejada: ");
    op1 = Console.ReadLine();
    if (op1 == "1")
    {
        Console.Write("Digite o número da base: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o número do expoente: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Resultado da Potência: {Potencia(x, y)}");
    }
    else if (op1 == "2")
    {
        Console.Write("Digite o número desejado: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Resultado: ");
        CubosR(n);
    }
    else if (op1 == "3")
    {
        Console.Write("Digite o primeiro número: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Mdc(x, y));
    }
    else if (op1 == "4")
    {
        Console.WriteLine("1 - Opção Recursiva");
        Console.WriteLine("2 - Opção Iterativa");
        Console.Write("Digite a opção desejada: ");
        string op2 = Console.ReadLine();
        if (op2 == "1")
        {
            Console.Write("Digite o número desejado: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FibonacciR(x));  
        }
        else
        {
            Console.Write("Digite o número desejado: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FibonacciI(x));  
        }
    }
    else if (op1 == "5")
    {
        Console.Write("Digite o número desejado: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Resultado: ");
        Binario(n);
        Console.WriteLine("");
    }
}