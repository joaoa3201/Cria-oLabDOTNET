using NyanCatSecurityLab.simulacao;

var simulacao = new SimulacaoAmeaca();
simulacao.Iniciar();

Console.WriteLine("Nyan Cat Security Lab - demonstracao segura");
foreach (string evento in simulacao.ObterDemonstracao())
{
	Console.WriteLine($"- {evento}");
}

simulacao.Encerrar();
