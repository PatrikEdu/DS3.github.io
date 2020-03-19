using System;

namespace TrabalhoMVC_DB.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Vencimento {get; set;}
        public float Valor { get; set; }
    }
}