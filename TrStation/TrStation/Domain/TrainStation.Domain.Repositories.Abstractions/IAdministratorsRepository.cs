using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrStation.Domain.TrainStation.Domain.Entities;

namespace TrainStation.Domain.TrainStation.Domain.Repositories.Abstractions
{
    public interface IAdministratorsRepository : IRepository<Administrator, Guid>
    {
        Task<Administrator?> GetAdministratorByLastNameAsync(string lastName, CancellationToken cancellationToken);
    }
}
