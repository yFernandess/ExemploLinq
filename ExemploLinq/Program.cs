using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemploLinq
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //FONTE DE DADOS
            var listaProdutos = new List<Produto>()
            {
                new Produto{Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
                new Produto{Id = 4, CategoriaId = 3, Nome = "Short", Status = true, Valor = 50},
                new Produto{Id = 5, CategoriaId = 1, Nome = "Video Game", Status = true, Valor = 1500},
                new Produto{Id = 10, CategoriaId = 2, Nome = "Máquina de Lavar", Status = false, Valor = 1500},
                new Produto{Id = 3, CategoriaId = 2, Nome = "Microondas", Status = true, Valor = 300},
                new Produto{Id = 4, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 5}
            };

            var listaCategorias = new List<Categoria>()
            {
                new Categoria{Id = 1, Status = true, Nome = "Eletronicos"},
                new Categoria{Id = 2, Status = true, Nome = "Vestuário"},
                new Categoria{Id = 3, Status = true, Nome = "Alimentos"}
            };

            //var nomesProduto = from produto in listaProdutos select produto.Nome;

            var result = from prod in listaProdutos
                         select new ProdutoDTO 
                         {
                            Nome = prod.Nome.ToUpper(),
                             Valor = prod.Valor + 10,
                             Status = prod.Status
                         };

            //Executar a consulta
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Nome} | {item.Valor} | {item.Status}");
            }
        }
    }

    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
    }

    class ProdutoDTO
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Status { get; set; }
    }

    class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}
