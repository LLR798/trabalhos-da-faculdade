using EasyReserve.API.Integration.Response;

namespace EasyReserve.API.Services.ViaCepService;

public interface IViaCepService
{
    Task<ViaCepResponse> GetDataViaCep(string cep);
}