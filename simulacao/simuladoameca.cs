using System.Collections.Generic;

namespace NyanCatSecurityLab.simulacao
{
    public class SimulacaoAmeaca
    {
        public bool EstaAtiva { get; private set; }

        public void Iniciar()
        {
            EstaAtiva = true;
        }

        public void Encerrar()
        {
            EstaAtiva = false;
        }

        public IReadOnlyList<string> ObterDemonstracao()
        {
            return new List<string>
            {
                "Cenario demonstrativo iniciado.",
                "Um alerta ficticio foi identificado.",
                "Comportamento simulado: tentativa de restringir o acesso a dados.",
                "Recomendacao: verificar processos e alertas de seguranca.",
                "Nenhum arquivo ou configuracao do sistema foi alterado."
            };
        }
    }
}
