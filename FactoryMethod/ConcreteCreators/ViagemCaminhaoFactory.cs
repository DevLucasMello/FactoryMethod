using FactoryMethod.ConcreteProducts;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreators
{
    public class ViagemCaminhaoFactory : Factory
    {        
        public ViagemCaminhaoFactory(string tipoVeiculo)
        {
            Veiculo = tipoVeiculo;
        }

        public override ViagemAbstract GerarViagem()
        {
            return new ViagemCaminhao(Veiculo);
        }
    }
}
