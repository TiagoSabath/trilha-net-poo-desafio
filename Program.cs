using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("1234","IPhone 14","111111",64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("9876","Nokia Tijolão","5555",128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");