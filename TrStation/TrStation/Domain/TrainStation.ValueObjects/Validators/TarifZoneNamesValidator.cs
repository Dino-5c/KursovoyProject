using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects.Base;
using TrainStation.Domain.TrainStation.ValueObjects.Exceptions;

namespace TrainStation.Domain.TrainStation.ValueObjects.Validators
{
    public class TarifZoneNamesValidator : IValidator<string>
    {
        /// <summary>
        /// Максимальная длина названия тарифной зоны
        /// </summary>
        public static int MAX_LENGTH => 100;
        /// <summary>
        /// Минимальная длина названия тарифной зоны
        /// </summary>
        public static int MIN_LENGTH => 5;

        /// <summary>
        /// Проверяет строку, чтобы убедиться, что она не является нулевой, пустой и не состоит только из пробелов.
        /// </summary>
        /// <param name="value">Строка, в которой находятся данные.</param>
        /// <exception cref="ArgumentNullOrWhiteSpaceException">Исключение, которое создаётся что если, строка нулевая или состоит из пробелов.</exception>
        /// <exception cref="TarifZoneNameLongValueException">Исключение, которое создаётся, если длина названия тарифной зоны больше допустимой длины.</exception>
        /// <exception cref="TarifZoneNameShortValueException">Исключение, которое создаётся, если длина названия тарифной зоны меньше допустимой длины.</exception>
        public void Validate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullOrWhiteSpaceException(ExceptionMessages.TARIFF_ZONE_NAME_NOT_NULL_OR_WHITE_SPACE, nameof(value)); // Nameof Выражение создает имя переменной, типа или элемента в виде строковой константы.
            if(value.Length > MAX_LENGTH)
                throw new TarifZoneNameLongValueException(value, MAX_LENGTH);
            if (value.Length < MIN_LENGTH)
                throw new TarifZoneNameShortValueException(value, MIN_LENGTH);
        }
    }
}
