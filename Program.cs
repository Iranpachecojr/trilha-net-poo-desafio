using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartfone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345", modelo: "010", imei: "1020", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartfone iphone");
Smartphone iphone = new Iphone(numero: "568923" , modelo: "2030", imei: "5040" , memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("telegram");
