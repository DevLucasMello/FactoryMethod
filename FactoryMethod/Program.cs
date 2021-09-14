using System;
using FactoryMethod.ConcreteCreators;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory viagemFactory = null;
            Console.Write("Digite o tipo de viagem: ");
            string tipoViagem = Console.ReadLine();
            Console.WriteLine("");

            switch (tipoViagem.ToLower())
            {
                case "carro":
                    viagemFactory = new ViagemCarroFactory(tipoViagem);
                    break;
                case "aviao":
                    viagemFactory = new ViagemAviaoFactory(tipoViagem);
                    break;
                case "caminhao":
                    viagemFactory = new ViagemCaminhaoFactory(tipoViagem);
                    break;
                default:                    
                    break;
            }

            ViagemAbstract viagem = viagemFactory.GerarViagem();
            viagem.IniciarViagem();
        }
    }
}
