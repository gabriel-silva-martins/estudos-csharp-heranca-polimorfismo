using System.Globalization;

namespace ClassesEMetodosAbstratos.Entities
{
    class Pessoa : Taxas
    {
        public double GastosComSaude { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, double ganhoAnual, double gastosComSaude) 
            : base (nome, ganhoAnual)
        {
            GastosComSaude = gastosComSaude;
        } 

        public override double Taxa()
        {
            if (GanhoAnual < 20000.0)
                return (GanhoAnual * 0.15) - (GastosComSaude * 0.5);
            else
                return (GanhoAnual * 0.25) - (GastosComSaude * 0.5);
        }
    }
}
