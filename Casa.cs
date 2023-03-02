namespace Tarea_2;

class Casa{
  public int area;
  public Puerta puerta;
  
  public Casa(int area){
    this.area = area;
    this.puerta = new Puerta();
  }

  public void SetArea(int area){
    this.area = area;
  }

  public void SetPuerta(Puerta puerta){
    this.puerta = puerta;
  }

  public void MostrarDatos(){
    Console.WriteLine($"Soy una Casa, mi área es {this.area} m2");
  }
}