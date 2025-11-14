namespace TB.Models
//string.Empty para comecar as strings vazias
{
    public class Article
    {
        public int Id { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;
        public string TempoLeitura { get; set; } = string.Empty;
        public string Imagem { get; set; } = string.Empty;
        public string Resumo { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Conteudo { get; set; } = string.Empty;
    }
}