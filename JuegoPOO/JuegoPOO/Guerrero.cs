class Guerrero : Personaje
{
    public Guerrero(string nombre, string tipo)
        : base(nombre, 150, 25, tipo)
    {
    }

    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} golpea con la espada a {objetivo.Nombre}");
        objetivo.Vida -= Ataque;
    }
}
