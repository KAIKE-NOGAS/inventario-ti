namespace inventario_ti
{
    class OpcaoController
    {
        public int ExibirOpcoes(string titulo, string[] opcoes)
        {
            while (true)
            {
                Console.WriteLine($"=== {titulo} ===");
                for (int i = 0; i < opcoes.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {opcoes[i]}");
                }
                if(int.TryParse(Console.ReadLine(), out int escolha) && escolha >= 1 && escolha <= opcoes.Length)
                {
                    return escolha;
                } else {
                    Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                }
            }
        }           
    }
}
