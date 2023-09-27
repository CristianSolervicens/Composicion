// See https://aka.ms/new-console-template for more information
using Composicion;

Console.WriteLine("Hello, World!");

Orco MiOrco = new Orco( new Cazador(new Mascota(10, true, 10)),100, 2);
Humano Cristian = new Humano(new Brujo(), 200, 140);

MiOrco.YoSoy();
Cristian.YoSoy();

Console.ReadLine();
