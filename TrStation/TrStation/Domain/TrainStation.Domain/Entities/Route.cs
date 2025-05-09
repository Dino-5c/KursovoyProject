using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.Domain.Exceptions;
using TrainStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.Domain.Entities.Base;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    /// <summary>
    /// Представляет Маршрут
    /// </summary>
    public class Route : Entity<Guid>
    {
        /// <summary>
        /// Название маршрута
        /// </summary>
        public RoName RouteName { get; private set; }

        /// <summary>
        /// Коллекция станций
        /// </summary>
        private /*readonly*/ ICollection<Station> _stations = []; // Список станций

        public Route(Guid id, RoName routeName) : base(id)
        {
            RouteName = routeName ?? throw new ArgumentNullValueException(nameof(routeName));

        }

        protected Route()
        {

        }


        /// <summary>
        /// Изменение названия маршрута.
        /// </summary>
        /// <param name="routeName">Название маршрута.</param>
        /// <returns>Возвращается true, если получилось изменить название маршрута. В другом случае возвращается false</returns>
        internal bool SetRouteName(Route route, RoName routeName/*, Administrator administrator*/)
        {
            if (route == null) return false;
                // throw new ArgumentNullValueException(nameof(route));
             // if(administrator == typeof(Administrator))
            if (RouteName == routeName) return false;
            RouteName = routeName;
            return true;
        }

        public RoName GetRouteName()
        {
            return RouteName;
        }

        //
        //private void AddStation(Station station)
        //{
        //    _stations.Add(station);
        //}


    }
}
