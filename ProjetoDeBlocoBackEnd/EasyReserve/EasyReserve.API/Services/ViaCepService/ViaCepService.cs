using EasyReserve.API.Integration.Refit;
using EasyReserve.API.Integration.Response;

namespace EasyReserve.API.Services.ViaCepService;

public class ViaCepService : IViaCepService
{
    private readonly IViaCepIntegrationRefit _viaCepIntegrationRefit;
    
    public ViaCepService(IViaCepIntegrationRefit viaCepIntegrationRefit)
    {
        _viaCepIntegrationRefit = viaCepIntegrationRefit;        
    }
    
    public async Task<ViaCepResponse> GetDataViaCep(string cep)
    {
        var responseData = await _viaCepIntegrationRefit.GetDataViaCep(cep);

        if (responseData != null && responseData.IsSuccessStatusCode)
        {
            return responseData.Content;
        }
        
        return null;
    }
}