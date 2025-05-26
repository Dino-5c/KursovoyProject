using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Domain.TrainStation.ValueObjects.Exceptions
{
    internal class TarifZoneNameLongValueException(string tarifZoneName, int maxLength)
        : ArgumentException($"Tarif zone name length {tarifZoneName} greated than maximum allowed length (допустимая длина) {maxLength}") // Было FormatException. Исключение, которое возникает в случае, если формат аргумента недопустим или строка составного формата построена неправильно. Наследование  Object ==> Exception ==> SystemException ==> FormatException
    // ArgumentException, Это исключение выбрасывается, если один из передаваемых методу аргументов является недопустимым. Наследование: Object ==> Exception ==> SystemException ==> ArgumentException
    {
        public string TarifZoneName => tarifZoneName;
        public int MaxLength => maxLength;
    }
}
