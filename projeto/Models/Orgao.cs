// Em Orgao.cs
using System;

namespace projeto.Models
{
    public class Orgao
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime DataRecebimento { get; set; }
        public string? TipoSanguineo { get; set; }
    }
}
