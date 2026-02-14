using System;

class Mago : Personaje
{
   //atributos 
    public int Mana { get; set; }

    // Constructor
    public Mago(string nombre, string tipo)
        : base(nombre, 30, 15, tipo)
    {
        Mana = 30;
    }
    public override void Atacar(Personaje objetivo)
    {
        if (Mana >= 15)
        {
            Console.WriteLine($"{Nombre} lanza un rayo a {objetivo.Nombre}");
            objetivo.Vida -= (Ataque + 10);
            Mana -= 15;
        }
        else
        {
            Console.WriteLine($"{Nombre} no tiene maná suficiente");
        }
    }
}
