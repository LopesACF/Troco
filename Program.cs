double valorGasto, valorPago, troco;
Console.Write("Digite o valor que foi gasto: R$ ");

valorGasto = double.Parse(Console.ReadLine()!);
Console.Write("Digite o valor que foi pago: R$ ");
valorPago = double.Parse(Console.ReadLine()!);
troco = valorPago - valorGasto;
Console.WriteLine("O valor do troco é: R$ " + troco.ToString());

