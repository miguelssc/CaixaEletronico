int valor;
int saque;
int nota200;
int nota100;
int nota50;
int nota20;
int nota10;
int nota5;
int nota2;
int nota1;
Console.WriteLine("--- Caixa Eletronico ---");
Console.WriteLine("");
Console.WriteLine("Digite o valor a ser sacado");
saque =Convert.ToInt16(Console.ReadLine());
if (saque == 0){
    Console.WriteLine("esse valor nao e valido");
    return;
}
valor = saque;
nota200 = (valor / 200);
valor = valor % 200;

nota100 = (valor / 100);
valor = valor % 100;

nota50 = (valor / 50);
valor = valor % 50;

nota20 = (valor / 20);
valor = valor % 20;

nota10 = (valor / 10);
valor = valor % 10;

nota5 = (valor / 5);
valor= valor % 5;

nota2 = (valor / 2);
valor = valor % 2;

nota1 = (valor / 1);
valor = valor % 1;
if (nota200 > 0){
    Console.WriteLine($"{nota200} nota(s) de R$200,00");
}
if (nota100 > 0){
    Console.WriteLine($"{nota100} nota(s) de R$100,00");
}
if (nota50 > 0){
    Console.WriteLine($"{nota50} nota(s) de R$50,00");
}
if (nota20 > 0){
    Console.WriteLine($"{nota20} nota(s) de R$20,00");
}
if (nota10 > 0){
    Console.WriteLine($"{nota10} nota(s) de R$10,00");
}
if (nota5 > 0){
    Console.WriteLine($"{nota5} nota(s) de R$5,00");
}
if (nota2 > 0){
    Console.WriteLine($"{nota2} nota(s) de R$2,00");
}
if (nota1 > 0){
    Console.WriteLine($"{nota1} nota(s) de R$1,00");
}