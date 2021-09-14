using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public abstract class Factory
    {
        public string Veiculo { get; set; }
        public abstract ViagemAbstract GerarViagem();
    }
}
