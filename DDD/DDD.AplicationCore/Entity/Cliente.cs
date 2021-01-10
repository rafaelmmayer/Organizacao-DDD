using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.AplicationCore.Entity
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public string ClientId { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }
    }
}
