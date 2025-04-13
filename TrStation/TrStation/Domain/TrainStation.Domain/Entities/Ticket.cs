using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.Domain.Exceptions;
using TrStation.Domain.TrainStation.Domain.Entities.Base;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    abstract class Ticket : Entity<Guid>
    {

        public DateTime BuyDate { get; }

        public Guid StartStation { get; private set; }

        public Guid EndStation { get; private set; }

        public Guid BuyerId { get; }

        /// <summary>
        /// Конструктор создания Билета
        /// </summary>
        /// <param name="id">Номер билета</param>
        /// <param name="buyDate">Дата покупки билета</param>
        /// <param name="startStation">Начальная станция</param>
        /// <param name="endStation">Конечная станция</param>
        /// <param name="buyerId"></param>
        /// <exception cref="CoincidenceOfStartAndEndStationException">Исключение, которое срабатывает, если начальная и конечная станции совпадают.</exception>
        public Ticket(Guid id, DateTime buyDate, Guid startStation, Guid endStation, Guid buyerId) : base(id) 
        {
            BuyDate = buyDate; // Проверка даты, времени покупки билета
            if (startStation == endStation) throw new CoincidenceOfStartAndEndStationException(this, startStation, endStation); 
            StartStation = startStation;
                    // Сделать: Проверка, что станции находятся на одном маршруте
            EndStation = endStation;
            BuyerId = buyerId;
        }

        /// <summary>
        /// Изменение номера начальной станции (откуда отправляется поезд).
        /// </summary>
        /// <param name="startStation">Номер начальной станции.</param>
        /// <returns>Возвращается true, если получилось изменить номер начальной станции. В другом случае возвращается false</returns>
        public bool SetStartStation(Guid startStation) 
        {
            if (StartStation == startStation) return false;
            StartStation = startStation;
            return true;
        }

        /// <summary>
        /// Изменение номера конечной станции (до куда идёт поезд).
        /// </summary>
        /// <param name="endStation">Номер конечной станции.</param>
        /// <returns>Возвращается true, если получилось изменить номер конечной станции. В другом случае возвращается false</returns>
        public bool SetEndStation(Guid endStation)
        {
            if (EndStation == endStation) return false;
            if (EndStation == StartStation) return false;
            EndStation= endStation;
            return true;
        }
    }
}
