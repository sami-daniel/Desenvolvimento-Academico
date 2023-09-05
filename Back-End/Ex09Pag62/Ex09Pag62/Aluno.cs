using System;

namespace Ex09Pag62
{
    internal class Aluno
    {
        public long Matricula { private get; set; }
        public double Nota { private get; set; }

        public Aluno(long matricula, double nota)
        {
            Matricula = matricula;
            Nota = nota;
        }

        public override string ToString()
        {
            return $"Matricula: {Matricula}\nNota: {Nota.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}";
        }
    }
}
