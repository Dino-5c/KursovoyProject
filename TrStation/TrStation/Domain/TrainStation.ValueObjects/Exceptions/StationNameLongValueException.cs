using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Domain.TrainStation.ValueObjects.Exceptions
{
    internal class StationNameLongValueException(string stationName, int maxLength)
        : ArgumentException($"Station name length {stationName} greated than maximum allowed length (допустимая длина) {maxLength}") // Было FormatException. Исключение, которое возникает в случае, если формат аргумента недопустим или строка составного формата построена неправильно. Наследование  Object ==> Exception ==> SystemException ==> FormatException
    // ArgumentException, Это исключение выбрасывается, если один из передаваемых методу аргументов является недопустимым. Наследование: Object ==> Exception ==> SystemException ==> ArgumentException
    {
        public string StationName => stationName;

        public int MaxLength => maxLength;
    }
}
