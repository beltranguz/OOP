

using OOP.Clase;

namespace OOP.Implementacion_de_Polimorfismo
{
    public class Rectangulo : Figura
    {
        private double Base;
        private double altura;

        public Rectangulo(double Base, double altura)
        {
            this.Base = Base;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * altura;
        }
    }
}
