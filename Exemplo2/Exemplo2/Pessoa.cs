using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Exemplo2
{
    class Pessoa
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}
