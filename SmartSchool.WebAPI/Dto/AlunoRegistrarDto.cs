using System;

namespace SmartSchool.WebAPI.Dto
{
    public class AlunoRegistrarDto
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; } = DateTime.Now;
        public DateTime? DataIni { get; set; } = null;
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; } = true;
    }
}