using Newtonsoft.Json;
using System.Text.Json;
using vendor.application.dtos;
using vendor.application.Repositories;
using vendor.utilities.Constants;

namespace vendor.persistence.Repositories
{
    public class VendorRepository : IVendorRepository
    {
        public async Task<List<ArticleDto>> GetAllArticles()
        {
            string jsonData = Data.dataArticles;

            var response = JsonConvert.DeserializeObject<ArticlesDto>(jsonData);

            var responseFiltered = response!.Articulos
                .Where(article => article.Precio > 0 && article.Deposito == 1)
                .ToList();

            return responseFiltered;
        }

        public async Task<List<VendorDto>> GetAllVendors() 
        {
            string jsonData = Data.dataVendors;

            var response = JsonConvert.DeserializeObject<VendorsDto>(jsonData);

            return response!.Vendedores;
        }
    }
}
