namespace inventario_ti
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Instanciando a classe OpcaoController
            OpcaoController opcaoController = new OpcaoController();
            // Instanciando a classe InicioView e passando o objeto opcaoController como parâmetro
            InicioView inicioView = new InicioView(opcaoController);
            // Chamando o método Main da classe InicioView
            inicioView.Main();
        }
    }

}
