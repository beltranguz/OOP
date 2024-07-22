
namespace OOP.Clase
{
    public class Estudiante : Persona
    #region"Atributos"
    {
        public string? Carrera { get; set; }
        public string? Matricula { get; set; }
        #endregion
    #region "Constructor"
        public Estudiante(string nombre, int edad, string ciudad, string carrera, string matricula) : base(nombre, edad, ciudad)
        {   
            this.Carrera = carrera;
            this.Matricula = matricula;
        }
        #endregion
    #region"Metodo"
        public void InformacionEstudiante()

        {
            Informacion();
            Console.WriteLine("Carrera: " + Carrera);
            Console.WriteLine("Matricula: " + Matricula);
        }
        #endregion
    }
}
