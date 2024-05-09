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


IFactoryAlquilable Factoria = new AlquilableFactoryV01();

IAlquilable alquilable1 = Factoria.dameElemento(EnumTipos.Coche, "uyatsuyastauyst", 8);
IAlquilable alquilable2 = Factoria.dameElemento(EnumTipos.Furgoneta, "sasasasas", 9);
IAlquilable alquilable3 = Factoria.dameElemento(EnumTipos.Patinete, "sasasasas", 9);

Console.WriteLine(alquilable1);
Console.WriteLine(alquilable2);

