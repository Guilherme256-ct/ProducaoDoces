using ProducaoDoces;
ProducaoDoce doces = new ProducaoDoce();

Console.WriteLine("=== Procução Doces===");
Console.WriteLine("Confeiteiro responsável: ");
doces.Confeiteiro= Console.ReadLine();

Console.WriteLine("Capacidade em Kg: ");
doces.CapacidadeKg = double.Parse(Console.ReadLine());

Console.WriteLine("Porcentagem Pronta: ");
doces.PorcentagemPronta= double.Parse(Console.ReadLine());

Console.WriteLine("Taxa de Produção por Hora: ");
doces.TaxaProducaoPorHora= double.Parse(Console.ReadLine());

Console.WriteLine($"Quantidade de Kg faltando: {doces.CalcularKgFaltantes()} Kg");
Console.WriteLine($"Tempo restante em Horas até encher: {doces.CalcularTempoRestanteHoras()} h");
Console.WriteLine($"Valor em R$ faltando: R$ {doces.ValorFaltante()}");
Console.WriteLine($"É produção expessa: {doces.EhProducaoExpressa()}");