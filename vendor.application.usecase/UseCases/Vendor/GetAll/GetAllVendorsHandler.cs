using MediatR;
using vendor.application.dtos;
using vendor.application.Repositories;
using vendor.application.usecase.Commons.Bases;

namespace vendor.application.usecase.UseCases.Vendor.GetAll
{
    public class GetAllVendorsHandler : IRequestHandler<GetAllVendorsRequest, BaseResponse<List<VendorDto>>>
    {

        private readonly IVendorRepository _vendorRepository;

        public GetAllVendorsHandler(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        public async Task<BaseResponse<List<VendorDto>>> Handle(GetAllVendorsRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<List<VendorDto>>();

            try
            {
                var vendors = await _vendorRepository.GetAllVendors();

                if (vendors.Count == 0) 
                {
                    response.IsSuccess = false;
                    response.Message = "No se ha encontrado ningun artículo";
                }

                response.IsSuccess = true;
                response.Message = "Busqueda sin errores";
                response.Data = vendors;
            }
            catch (Exception)
            {
                response.IsSuccess = false;
                response.Message = "Ha ocurrido un error inesperado";
            }

            return response;
        }
    }

}
