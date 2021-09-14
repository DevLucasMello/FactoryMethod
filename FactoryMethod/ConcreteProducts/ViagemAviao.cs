using System;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProducts
{
    public class ViagemAviao : ViagemAbstract
    {
        public ViagemAviao(string tipoVeiculo)
        {
            TipoVeiculo = tipoVeiculo;            
        }

        public override void IniciarViagem()
        {
            Console.WriteLine("Viagem com Avião");
        }
    }
}
