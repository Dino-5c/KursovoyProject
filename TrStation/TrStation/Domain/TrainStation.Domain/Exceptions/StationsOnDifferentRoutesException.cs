using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrStation.Domain.TrainStation.Domain.Entities;
using static System.Collections.Specialized.BitVector32;

namespace TrainStation.Domain.TrainStation.Domain.Exceptions
{
    public class StationsOnDifferentRoutesException(Ticket ticket, Station startStation, Station endStation)
        : InvalidOperationException($"It can't to buy ticket {ticket}, because station {startStation} and station {endStation} are on different routes.")
    // InvalidOperationException: Исключение, которое выдается при вызове метода, недопустимого для текущего состояния объекта. Наследование: Object ==> Exception ==> SystemException ==> InvalidOperationException
    {
        public Ticket Ticket => ticket;

        public Station StartStation => startStation;

        public Station EndStation => endStation;
    }
}
