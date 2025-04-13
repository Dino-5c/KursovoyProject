using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.Domain.Entities.Base;

namespace TrStation.Domain.TrainStation.Domain.Entities
{

    public class Tariffes : Entity<Guid>
    {
        /// <summary>
        /// Стоимость проезда, цена распространяется до числа, указанного в Distance
        /// </summary>
        public Money Price { get; private set; }
        
        /// <summary>
        /// Расстояние зоны на котором действует цена, расстояние в километрах
        /// </summary>
        public Distance Distance { get; private set; }


        public Tariffes(Guid tariffId, Money money, Distance distance): base(tariffId)
        {
            Price = money;
            Distance = distance;
        }
        /// <summary>
        /// Изменение цены.
        /// </summary>
        /// <param name="money">Цена.</param>
        /// <returns>Возвращается true, если получилось изменить цену проезда в данном регионе. В другом случае возвращается false</returns>
        public bool SetPrice(Money money)
        {
            if (Price == money) return false;
            Price = money;
            return true;
        }
        /// <summary>
        /// Изменение расстояния
        /// </summary>
        /// <param name="distance">Расстояние</param>
        /// <returns>Возвращается  true, если получилось изменить расстояние, на котором действует цена. В другом случае возвращается false</returns>
        public bool SetDistance(Distance distance) 
        {
            if (Distance == distance) return false;
            Distance = distance;
            return true;
        }
        //

    }
}
