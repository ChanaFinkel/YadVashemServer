namespace Registrant.Service.Interfaces;

public interface IRegistrantService
{
    Task<List<Entities.Registrant>> GetAllRegistantsAsync();
}
