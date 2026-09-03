namespace ProducaoDoces
{
    class ProducaoDoce
    {
        //Atributos
        public string Confeiteiro { get; set; }
        public double CapacidadeKg {  get; set; }
        public double PorcentagemPronta {  get; set; }
        public double TaxaProducaoPorHora {  get; set; }
        
        //Métodos
        public double CalcularKgFaltantes()
        {
            return CapacidadeKg-(CapacidadeKg * PorcentagemPronta)/100;
        }
        public double CalcularTempoRestanteHoras()
        {
            return CalcularKgFaltantes()/TaxaProducaoPorHora;
        }
        public double ValorFaltante()
        {
            return CalcularKgFaltantes() * 45.50;
        }
        public bool EhProducaoExpressa()
        {
            return (TaxaProducaoPorHora >= 20 && CalcularTempoRestanteHoras()<1);
        }
    }
}
