using FactoryMethod.ConcreteProducts;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreators
{
    public class ViagemCarroFactory : Factory
    {        
        public ViagemCarroFactory(string tipoVeiculo)
        {
            Veiculo = tipoVeiculo;
        }

        public override ViagemAbstract GerarViagem()
        {
            return new ViagemCarro(Veiculo);
        }
    }
}
