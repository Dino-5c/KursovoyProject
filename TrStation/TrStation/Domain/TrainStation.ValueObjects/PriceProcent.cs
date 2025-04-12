using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects.Base;

namespace TrainStation.Domain.TrainStation.ValueObjects
{
    public class PriceProcent(decimal priceProcent) : ValueObject<decimal>(
        new PriceProcentValidator(),
               Math.Round(priceProcent, 2, MidpointRounding.AwayFromZero)) // MidpointRounding, Задает стратегию, которую математические методы округления должны использовать для округления числа.
                                                                         // AwayFromZero, - Стратегия округления до ближайшего числа, и если число находится на полпути между двумя другими, оно округляется до ближайшего числа, которое находится далеко от нуля.)
    {

    }
}
