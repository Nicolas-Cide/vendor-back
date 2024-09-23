using MediatR;
using vendor.application.dtos;
using vendor.application.usecase.Commons.Bases;

namespace vendor.application.usecase.UseCases.Vendor.GetAll
{
    public class GetAllVendorsRequest : IRequest<BaseResponse<List<VendorDto>>>
    {
    }
}
