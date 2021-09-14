using System;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProducts
{
    public class ViagemCarro : ViagemAbstract
    {        
        public ViagemCarro(string tipoVeiculo)
        {
            TipoVeiculo = tipoVeiculo;            
        }

        public override void IniciarViagem()
        {
            Console.WriteLine("Viagem com Carro");
        }
    }
}
