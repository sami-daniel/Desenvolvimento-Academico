﻿namespace TrabalhoSegundaEtapa.Entities
{
    internal class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Produto()
        {
        }

        public Produto(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
