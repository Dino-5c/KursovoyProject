using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Domain.TrainStation.ValueObjects.Exceptions
{
    internal class StationNameShortValueException(string stationName, int minLength)
         : FormatException($"Station name length {stationName} less than minimum allowed length (допустимая длина) {minLength}") // FormatException. Исключение, которое возникает в случае, если формат аргумента недопустим или строка составного формата построена неправильно.  Наследование  Object ==> Exception ==> SystemException ==> FormatException
    {
        public string StationName => stationName;
        public int MinLength => minLength;
    }
}
