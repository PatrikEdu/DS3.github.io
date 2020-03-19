using System;

namespace TrabalhoMVC_DB.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
