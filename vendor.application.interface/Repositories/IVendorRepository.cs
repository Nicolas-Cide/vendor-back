using vendor.application.dtos;

namespace vendor.application.Repositories
{
    public interface IVendorRepository 
    {
        Task<List<ArticleDto>> GetAllArticles();

        Task<List<VendorDto>> GetAllVendors();
    }

}

