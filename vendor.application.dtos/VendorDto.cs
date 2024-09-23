namespace vendor.application.dtos
{
    public class VendorDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class VendorsDto 
    {
        public List<VendorDto> Vendedores { get; set; }
    }
}
