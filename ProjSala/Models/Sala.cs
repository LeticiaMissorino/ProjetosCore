using System;

namespace ProjSala.Models
{
    public class Sala
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string cidade { get; set; }
        public int qtdeProdessores { get; set; }

        public int qtdeAlunos { get; set; }
    }
}