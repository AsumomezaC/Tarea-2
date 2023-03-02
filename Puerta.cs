namespace Tarea_2;

class Puerta{
  public string color;

  public Puerta(){
    this.color = "Café";
  }

  public void SetColor(string color){
    this.color = color;
  }

  public void MostrarDatos(){
    Console.WriteLine($"Soy una puerta, mi color es {this.color}");
  }
}