namespace vendor.application.dtos
{
    public class ArticleDto
    {
        public string Codigo { get; set; }
        public string descripcion { get; set; }
        public float Precio { get; set; }
        public int Deposito { get; set; }
    }

    public class ArticlesDto
    {
        public List<ArticleDto> Articulos { get; set; }
    }
}
