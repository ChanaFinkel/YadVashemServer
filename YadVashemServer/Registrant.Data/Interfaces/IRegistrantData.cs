namespace Registrant.Data.Interfaces;

public interface IRegistrantData
{
    Task<List<Entities.Registrant>> GetAllRegistantsAsync();

}
