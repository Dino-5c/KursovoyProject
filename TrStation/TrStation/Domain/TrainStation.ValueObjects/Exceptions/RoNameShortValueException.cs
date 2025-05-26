using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrStation.Domain.TrainStation.ValueObjects;

namespace TrainStation.Domain.TrainStation.ValueObjects.Exceptions
{
    internal class RoNameShortValueException(string routeName, int minLength)
        : ArgumentException($"Route name length {routeName} less than minimum allowed length (допустимая длина) {minLength}") // Было FormatException. Исключение, которое возникает в случае, если формат аргумента недопустим или строка составного формата построена неправильно.  Наследование  Object ==> Exception ==> SystemException ==> FormatException
    // ArgumentException, Это исключение выбрасывается, если один из передаваемых методу аргументов является недопустимым. Наследование: Object ==> Exception ==> SystemException ==> ArgumentException
    {
        public string RoName => routeName;
        public int MinLength => minLength;
    }
}
