using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Application.TrainStation.Aplication.Models.Base;

namespace TrainStation.Application.TrainStation.Aplication.Models.Tariffes
{
    public record class TariffZoneModel(
        Guid Id,
        int TarifZoneName,
        decimal Price,
        int Distance
        ) : IModel<Guid>
    {
    }
}
