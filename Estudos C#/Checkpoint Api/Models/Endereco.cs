using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint_Api.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Cep { get; set; }
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
    }
}