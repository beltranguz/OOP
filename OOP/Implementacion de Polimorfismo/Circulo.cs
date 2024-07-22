

using OOP.Clase;

namespace OOP.Implementacion_de_Polimorfismo
{
    public class Circulo : Figura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }
}
