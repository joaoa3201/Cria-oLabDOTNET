using System;
using System.Collections.Generic;

namespace NyanCatSecurityLab.simulacao
{
    public class RegistroEventos
    {
        private readonly List<string> eventos = new();

        public void Registrar(string mensagem)
        {
            string horario = DateTime.Now.ToString("HH:mm:ss");
            eventos.Add($"{horario} - {mensagem}");
        }

        public IReadOnlyList<string> ObterEventos()
        {
            return eventos.AsReadOnly();
        }

        public void Limpar()
        {
            eventos.Clear();
        }
    }
}