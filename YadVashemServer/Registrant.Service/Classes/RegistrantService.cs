
using Registrant.Data.Interfaces;
using Registrant.Service.Interfaces;

namespace Registrant.Service.Classes;

public class RegistrantService : IRegistrantService
{
    private readonly IRegistrantData _registrantData;
    public RegistrantService(IRegistrantData registrantData)
    {
        _registrantData = registrantData;
    }
    public async Task<List<Entities.Registrant>> GetAllRegistantsAsync()
    {
        return await _registrantData.GetAllRegistantsAsync();
    }
}
