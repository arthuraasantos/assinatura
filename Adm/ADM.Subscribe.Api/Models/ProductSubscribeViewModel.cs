using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADM.Subscribe.Api.Models
{
    public class ProductSubscribeViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}