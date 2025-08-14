using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone("987654321");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
Console.WriteLine("\nTestes concluídos com sucesso!");
