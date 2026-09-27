class Program
{
    static void Main(string[] args)
    {
        // Lê a linha digitada pelo usuário
        string entrada = Console.ReadLine()!;

        // Remove os espaços em branco do início e do fim
        string textoSemEspacos = entrada.Trim();

        // Verificar se a string não ficou vazia após remover os espaços
        if (textoSemEspacos.Length > 0)
        {
            // Exibir apenas o primeiro caractere (índice 0)
            Console.WriteLine(textoSemEspacos[0]);
        }
    }
}
