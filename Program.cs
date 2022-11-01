using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("12345678", "NokiaABC", "abcd1234", 50);
Iphone iphone = new Iphone("87654321", "Iphone10", "4321dcba", 60);

nokia.InstalarAplicativo("Facebook");
nokia.Ligar();
nokia.ReceberLigacao();

iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
iphone.ReceberLigacao();
