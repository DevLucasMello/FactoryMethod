using FactoryMethod.ConcreteProducts;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreators
{
    public class ViagemAviaoFactory : Factory
    {        
        public ViagemAviaoFactory(string tipoVeiculo)
        {
            Veiculo = tipoVeiculo;
        }

        public override ViagemAbstract GerarViagem()
        {
            return new ViagemAviao(Veiculo);
        }
    }
}
