
using Registrant.Data.Interfaces;
using System.Text.Json;

namespace Registrant.Data.Classes;

public class RegistrantData : IRegistrantData
{
    public async Task<List<Entities.Registrant>> GetAllRegistantsAsync()
    {
        string fileName = "נרשמים.json";
        using FileStream openStream = File.OpenRead(fileName);
        List<Entities.Registrant>? registrants =
            await JsonSerializer.DeserializeAsync<List<Entities.Registrant>>(openStream);
        return registrants;
    }
}
