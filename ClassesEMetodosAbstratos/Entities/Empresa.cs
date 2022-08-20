using System.Globalization;

namespace ClassesEMetodosAbstratos.Entities
{
    class Empresa : Taxas
    {

        public int QtdFuncionario { get; set; }

        public Empresa()
        {
        }

        public Empresa(string nome, double ganhoAnual, int qtdFuncionario)
            : base (nome, ganhoAnual)
        {
            QtdFuncionario = qtdFuncionario;
        }

        public override double Taxa()
        {
            if (QtdFuncionario > 10)
                return GanhoAnual * 0.14;
            else
                return GanhoAnual * 0.16;
        }
    }
}
