using MediatR;
using vendor.application.dtos;
using vendor.application.usecase.Commons.Bases;

namespace vendor.application.usecase.UseCases.Article.GetAll
{
    public class GetAllArticlesRequest : IRequest<BaseResponse<List<ArticleDto>>>
    {
    }
}
