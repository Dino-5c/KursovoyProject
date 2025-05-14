using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Application.TrainStation.Aplication.Models.Base;

namespace TrainStation.Application.TrainStation.Aplication.Models.Administrator
{
    public record class AdministratorModel(Guid Id, string LastName, string FirstName) : IModel<Guid>
    {
    }
}
