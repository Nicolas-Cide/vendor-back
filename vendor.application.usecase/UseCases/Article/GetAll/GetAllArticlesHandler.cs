using MediatR;
using vendor.application.dtos;
using vendor.application.Repositories;
using vendor.application.usecase.Commons.Bases;

namespace vendor.application.usecase.UseCases.Article.GetAll
{
    public class GetAllArticlesHandler : IRequestHandler<GetAllArticlesRequest, BaseResponse<List<ArticleDto>>>
    {
        private readonly IVendorRepository _vendorRepository;

        public GetAllArticlesHandler(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        public async Task<BaseResponse<List<ArticleDto>>> Handle(GetAllArticlesRequest request, CancellationToken cancellationToken) 
        {
            var response = new BaseResponse<List<ArticleDto>>();

            try
            {
                var articles = await _vendorRepository.GetAllArticles();

                if (articles.Count == 0) 
                {
                    response.IsSuccess = false;
                    response.Message = "No se ha encontrado ningun artículo";
                }

                response.IsSuccess = true;
                response.Message = "Busqueda sin errores";
                response.Data = articles;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Ha ocurrido un error inesperado";
            }

            return response;
        }
    }
}
