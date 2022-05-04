namespace imo.api.Models
{
    public class Imovel
    {
        public int ImovelId { get; set; }
        public string Local { get; set; }
        public string DataImovel { get; set; }
        public string Tipo { get; set; }
        public int Valor { get; set; }
        public string ImagemURL { get; set; }
        public string Descricao { get; set; }
    }
}