using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ADM.Subscribe.Api.Models;

namespace ADM.Subscribe.Api.Controllers
{
    public class ProductController : ApiController
    {


        [HttpGet]
        [Route("products")]
        public IEnumerable<ProductSubscribeViewModel> Get()
        {
            var products = new List<ProductSubscribeViewModel>()
            {
                new ProductSubscribeViewModel { Descricao = "Módulo de Compras", Id = Guid.NewGuid(), Nome = "Compras", Valor = 29.90m},
                new ProductSubscribeViewModel { Descricao = "Módulo de Estoque", Id = Guid.NewGuid(), Nome = "Estoque", Valor = 29.90m},
                new ProductSubscribeViewModel { Descricao = "Módulo Financeiro", Id = Guid.NewGuid(), Nome = "Financeiro", Valor = 29.90m},
                new ProductSubscribeViewModel { Descricao = "Boletos Registrados \n *preço até 50 boletos/mês", Id = Guid.NewGuid(), Nome = "Boletos registrados", Valor = 39.90m}
            };
            return products;
        } 
    }
}
