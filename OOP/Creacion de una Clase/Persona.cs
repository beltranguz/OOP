
namespace OOP.Clase
{
    public class Persona
    {
        #region"Atributos"
        public string? Nombre { get; set; }
        public int? Edad { get; set; }
        public string? Ciudad { get; set; }
        #endregion
        #region"Constructor"
        public Persona(string Nombre, int Edad, string Ciudad)

        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Ciudad = Ciudad;

        }
        #endregion
        #region"Metodo"
        public void Informacion()

        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Ciudad: " + Ciudad);

        }

        #endregion
    }
}
