namespace inventario_ti
{
    
    class InicioView
    {
        private OpcaoController _opcaoController;
        private Permissao _administrador;
        private Permissao _gerente;
        private Permissao _agente;

        public InicioView(OpcaoController opcaoControllers, Permissao administrador, Permissao gerente, Permissao agente)
        {
            _opcaoController = opcaoControllers;
            _administrador = administrador;
            _gerente = gerente;
            _agente = agente;
            
        }
        public void Main()
        {
            bool sair = false;
            while(!sair)
            {
                string[] opcoes = { "Cadastramento", "Login", "Sair" };
                int opcao =_opcaoController.ExibirOpcoes("Menu Principal", opcoes);
                switch (opcao)
                {
                    case 1:
                        // Cadastro
                        break;
                    case 2:
                        // Login
                        break;
                    case 3:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opcão inválida.");
                        break;
                }
            }
            
        }
    }
    

}