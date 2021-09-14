using System;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteProducts
{
    public class ViagemCaminhao : ViagemAbstract
    {
        public ViagemCaminhao(string tipoVeiculo)
        {
            TipoVeiculo = tipoVeiculo;            
        }

        public override void IniciarViagem()
        {
            Console.WriteLine("Viagem com Caminhão");
        }
    }    
}
