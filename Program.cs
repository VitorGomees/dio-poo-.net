using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Testando clase Nokia:
Console.WriteLine("\n---------------------------\nTestando Smartphone Nokia:\n---------------------------");
// Construindo a classe Nokia
Smartphone nokia = new Nokia("94444-4444", "Modelo X", "Imei X", 32);
// Mostrando seu número e usando as funções herdadas da classe Smartphone
Console.WriteLine($"Fazendo operações com o Nokia de número: {nokia.Numero}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

// Testando classe Iphone:
Console.WriteLine("\n---------------------------\nTestando Smartphone Iphone:\n---------------------------");
// Construindo a classe Iphone
Smartphone iphone = new Iphone("98888-8888", "Modelo A", "Imei B", 64);
// Mostrando seu número e usando as funções herdadas da classe Smartphone
Console.WriteLine($"Fazendo operações com o Nokia de número: {iphone.Numero}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");