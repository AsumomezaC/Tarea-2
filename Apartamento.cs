namespace Tarea_2;

class Apartamento : Casa{
  public Apartamento() : base(50){
  }
  new public void MostrarDatos(){//evita agarrar el metodo de la madre
    Console.WriteLine($"Soy un Apartamento, mi área es {area} m2");
  }
}