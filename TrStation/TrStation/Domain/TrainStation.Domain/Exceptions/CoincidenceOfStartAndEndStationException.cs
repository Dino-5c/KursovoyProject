using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrStation.Domain.TrainStation.Domain.Entities;

namespace TrainStation.Domain.TrainStation.Domain.Exceptions
{
    internal class CoincidenceOfStartAndEndStationException(Ticket ticket, Station startStation, Station endStation)
        : InvalidOperationException($"It impossible to buy ticket number {ticket.Id}, because it for sales on one station - start station {startStation} and end station {endStation} are matched.")
    // InvalidOperationException: Исключение, которое выдается при вызове метода, недопустимого для текущего состояния объекта. Наследование: Object ==> Exception ==> SystemException ==> InvalidOperationException
    {
        public Ticket Ticket => ticket;
        public Station StartStation => startStation;
        public Station EndStation => endStation;
    }
}
