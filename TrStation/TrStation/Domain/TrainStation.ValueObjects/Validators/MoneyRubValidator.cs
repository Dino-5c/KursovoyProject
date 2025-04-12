using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects.Base;
using TrainStation.Domain.TrainStation.ValueObjects.Exceptions;

namespace TrainStation.Domain.TrainStation.ValueObjects.Validators
{
    /// <summary>
    /// Определяет метод, реализующий проверку десятичной дроби.
    /// </summary>
    public class MoneyRubValidator : IValidator<decimal>
    {
        /// <summary>
        /// Проверяет, что десятичная дробь не является отрицательной и не равна нулю.
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="MoneyAmountNonPositiveException"></exception>
        /// <exception cref="MoneyAmountHasMoreThenTwoDecimalPlacesException"></exception>
        public void Validate(decimal value)
        {
            if (value < 0) 
                throw new MoneyAmountNonPositiveException(ExceptionMessages.MONEY_AMOUNT_NON_POSITIVE, nameof(value), value);
            if (!IsValidAmount(value))
                throw new MoneyAmountHasMoreThenTwoDecimalPlacesException(ExceptionMessages.MONEY_AMOUNT_HAS_NOT_MORE_THEN_TWO_DECIMAL_PLACES, nameof(value), value);
        }

        /// <summary>
        /// Проверка на то, сколько знаков у числа после запятой
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool IsValidAmount(decimal value)
        {
            value = value * 100; // Умножаем value на 100
            value -= (int)value; // Вычитаем из value часть value, приведённую к целочисленному типу
            return value == 0m; // Если разность не равна 0, возвращаем false; число знаков после запятой больше двух
        }

    }
}
