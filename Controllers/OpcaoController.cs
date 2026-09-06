namespace inventario_ti
{
    class OpcaoController
    {   
        // Função para exibição de opções no console e retorno
        // do tipo de dado inteiro pela opção escolhida
        private Permissao administrador;
        private Permissao gerente;
        private Permissao agente;

        OpcaoController()
        {
            administrador = new Permissao("Administrador", true, true);
            gerente = new Permissao("Gerente", true, false);
            agente = new Permissao("Agente", false, false);
        }
        public int ExibirOpcoes(string titulo, string[] opcoes)
        {
            while (true)
            {
                Console.WriteLine($"=== {titulo} ===");
                // Loop sobre lista de opções
                // Utilizando Length para captar o vetor
                for (int i = 0; i < opcoes.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {opcoes[i]}");
                }
                // Utilizando TryParse para validar entrada de números inteiros
                // Se o valor não for inteiro retorna para inicio do loop
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
