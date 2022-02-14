using SistemaCompra.Domain.Core.Model;
using SistemaCompra.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using ProdutoAggre = SistemaCompra.Domain.ProdutoAggregate;


namespace SistemaCompra.Infra.Data
{
    public static class DbInitialize
    {
        public static void Seed(this IContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Produtos.Any())
            {
             
               for(var i =0; i<10; i++)
                {
                    var preco = decimal.Parse(gerador(4));
                    var nome = RandName();
                    var categoria = RandCategory();
                    var produto = new ProdutoAggre.Produto(
                        nome,
                        $"Descrição {nome}",
                        categoria,
                        preco
                    );
                    context.Produtos.Add(produto);
                }
                

            }                
            context.SaveChanges();
        }
        private static string RandCategory()
        {
            string[] categoryNames = new string[3] { "Madeira", "Juncao", "Fixadores" };

            Random rand = new Random(DateTime.Now.Second);
            return categoryNames[rand.Next(0, categoryNames.Length - 1)];


        }
        private static string RandName()
        {
            string[] produtoNames = new string[3] { "Poste", "Tabua", "Guia" };

            Random rand = new Random(DateTime.Now.Second);
            return produtoNames[rand.Next(0, produtoNames.Length - 1)];


        }
        private static string gerador(int leng = 10)
        {
            Random R = new Random();
            return ((long)R.Next(0, 100000) * (long)R.Next(0, 100000)).ToString().PadLeft(leng, '0');
        }
    }
}
