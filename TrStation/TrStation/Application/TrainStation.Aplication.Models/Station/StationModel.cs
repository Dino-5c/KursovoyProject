using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Application.TrainStation.Aplication.Models.Base;

namespace TrainStation.Application.TrainStation.Aplication.Models.Station
{
    public record class StationModel(
        Guid Id,
        string StationName,
        Guid RouteId,
        Guid TariffZoneId
        /*, string StationStatus */
        ) : IModel<Guid>
    {
    }
}
