namespace ClassesEMetodosAbstratos
{
    abstract class Taxas
    {
        public string Nome { get; set; }
        public double GanhoAnual { get; set; }

        public Taxas()
        {
        }

        public Taxas(string nome, double ganhoAnual)
        {
            Nome = nome;
            GanhoAnual = ganhoAnual;
        }

        public abstract double Taxa();
    }
}
