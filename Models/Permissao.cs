namespace inventario_ti
{
    class Permissao
    {
        public string? NomeCargo { get; set; }
        public bool? PainelAgentes { get; set;}
        public bool? GerenciamentoUsuarios { get; set; }

        public Permissao(string nomeCargo, bool painelAgentes, bool gerenciamentoUsuarios)
        {
            NomeCargo = nomeCargo;
            PainelAgentes = painelAgentes;
            GerenciamentoUsuarios = gerenciamentoUsuarios;
        }

    }

}