using EasyReserve.API.Integration.Response;
using Refit;

namespace EasyReserve.API.Integration.Refit;

public interface IViaCepIntegrationRefit
{
    [Get("/ws/{cep}/json")]
    Task<ApiResponse<ViaCepResponse>> GetDataViaCep(string cep);
}