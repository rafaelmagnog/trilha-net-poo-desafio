using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//* IMPLEMANTADO AQUI


Console.WriteLine("--------------------------------------\n MEU TESTE: \n--------------------------------------");

Nokia nk1 = new Nokia("(83) 91234-5678", "Nokia NKA 22", "3335", 32);
Iphone ip1 = new Iphone("(83) 98765-4321", "Iphone 15", "2222", 128);

Console.WriteLine("(Teste Nokia)");
nk1.Ligar();
nk1.InstalarAplicativo("Snake game");
nk1.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("(Teste Iphone)");
ip1.Ligar();
ip1.InstalarAplicativo("LinkedIn");
ip1.ReceberLigacao();



Console.WriteLine("--------------------------------------\n TEMPLATE TESTE: \n--------------------------------------");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");