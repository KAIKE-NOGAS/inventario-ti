namespace inventario_ti
{
    class User
    {
        // Definindo instânicas privadas usuando 
        // auto-implemented properties
        public string? Usuario { get; set; }
        public string? Password { get; set; }
        public Permissao? Permissao { get; set; }

    }

}