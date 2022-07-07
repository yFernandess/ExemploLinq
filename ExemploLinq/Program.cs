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

            // Criar consulta LINQ
            // 01 - Filtrar produtos por nome

            //var result = from produto in listaProdutos
            //             where produto.Nome.ToLower() == "aRroz".ToLower()
            //             select produto;

            // 02 - Filtrar produtos pela primeira letra do nome

            //var result = from produto in listaProdutos
            //             where produto.Nome.ToLower().Substring(0, 1) == "m".ToLower()
            //             select produto;

            // 03 - Filtrar produtos pela primeira letra do nome e status ativo

            //var result = from produto in listaProdutos
            //             where produto.Nome.ToLower().Substring(0, 1) == "m".ToLower() &&
            //             produto.Status == true
            //             select produto;

            // 04 - Ordenar os produtos por ID 

            var result = from produto in listaProdutos
                         where produto.Id > 1 && produto.Id < 6
                         orderby produto.Id descending
                         select produto;

            //Executar a consulta
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Id} / {item.Nome} / {item.Valor} / {item.CategoriaId}");
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

    class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}
