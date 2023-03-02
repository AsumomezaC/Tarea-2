namespace Tarea_2;

class Persona{
  public string nombre;
  public Casa casa;
  public Persona(){
    this.nombre = "Juan";
    this.casa = new Casa(50);
  }
  public Persona(string name, Casa casa){
    this.nombre = name;
    this.casa = casa;
  }
  public void SetNombre(string name){
    this.nombre = name;
  }
  public void SetCasa(Casa casa){
    this.casa = casa;
  }
  public void MostrarDatos(){
    Console.WriteLine($"Mi nombre es {this.nombre}");
    this.casa.MostrarDatos();
    this.casa.puerta.MostrarDatos();
  }
}