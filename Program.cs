namespace Tarea_2;
class Program
{
    static void Main(string[] args)
    {
        // Se hicieron algunos cambios con respecto al programa original
        // pues usando los metodos solicitados, no es posible llegar
        // al resultado deseado, por ejemplo
        // Persona crea una casa, no un apartamento
        Persona persona = new Persona();
        persona.MostrarDatos();
        persona.nombre = "Carlos";
        Apartamento nuevoApartamento = new Apartamento();
        Puerta nuevaPuerta = new Puerta();
        nuevaPuerta.SetColor("Verde");
        nuevoApartamento.SetPuerta(nuevaPuerta);
        persona.SetCasa(nuevoApartamento);
        persona.MostrarDatos();
    }
}
