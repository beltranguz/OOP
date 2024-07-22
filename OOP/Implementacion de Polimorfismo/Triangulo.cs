

using OOP.Clase;

namespace OOP.Implementacion_de_Polimorfismo
{
    public class Triangulo : Figura
    {
        private double Base;
        private double altura;

        public Triangulo(double Base, double altura)
        {
            this.Base = Base;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * altura / 2; 
        }
    }
}
