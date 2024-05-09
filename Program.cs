// See https://aka.ms/new-console-template for more information
using ConsoleAppClases.Garage;
using ConsoleAppClases.Modelo;

ConsoleAppClases.Modelo.Coche MiCitroen = new ConsoleAppClases.Modelo.Coche();
MiCitroen.Matricula = "uishduahsi";
MiCitroen.Cabe = true;

ConsoleAppClases.Modelo.Coche MiSeat = new();
MiSeat.Matricula = "djsdisid";
MiSeat.Cabe = false;

var MiFiat = new ConsoleAppClases.Modelo.Coche();
MiFiat.Matricula = "uhssha";
MiFiat.Cabe = false;

var MiMercedes = new ConsoleAppClases.Modelo.Coche () { Matricula = "ijsaoajsoasj",Cabe = true};
var MiPorche = new ConsoleAppClases.Modelo.Coche("iajsoiajsoajso", false);
var MiFerrari = new ConsoleAppClases.Modelo.Coche("jsiajsiasia", true);
var MiEjemplo = new ConsoleAppClases.Modelo.Coche("sasoajsoas");

Console.WriteLine(MiMercedes);

IAlquilable alquilable = new ConsoleAppClases.Garage.Coche() { Identificador = "jhuhu", Tiempo = 2 };
Console.WriteLine(alquilable);