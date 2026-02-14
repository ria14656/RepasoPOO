using System;

class Program
{
    static void Main()
    {
        //objetos
        Guerrero g = new Guerrero("kirito", "Aliado");
        Mago m = new Mago("akihiko", "Villano");

        // información
        g.MostrarEstado();
        m.MostrarEstado();

        Console.WriteLine("\n--- COMBATE ---\n");

        g.Atacar(m);
        m.Atacar(g);

        Console.WriteLine();

        g.MostrarEstado();
        m.MostrarEstado();
    }
}
