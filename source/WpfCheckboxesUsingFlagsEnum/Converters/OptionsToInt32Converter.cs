using System;
using System.Globalization;
using System.Windows.Data;

using WpfCheckboxesUsingFlagsEnum.Common;

namespace WpfCheckboxesUsingFlagsEnum.Converters
{
    public class OptionsToInt32Converter : IValueConverter
    {
        private Option _option;

        /// <summary>
        /// Konvertiert einen Wert.
        /// </summary>
        /// <returns>
        /// Ein konvertierter Wert. Wenn die Methode null zurückgibt, wird der gültige NULL-Wert verwendet.
        /// </returns>
        /// <param name="value">Der von der Bindungsquelle erzeugte Wert.</param><param name="targetType">Der Typ der 
        /// Bindungsziel-Eigenschaft.</param><param name="parameter">Der zu verwendende Konverterparameter.</param>
        /// <param name="culture">Die im Konverter zu verwendende Kultur.</param>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var parameterAsOptions = (Option)parameter;

            _option = (Option)value;

            return ((parameterAsOptions & _option) != 0);
        }

        /// <summary>
        /// Konvertiert einen Wert.
        /// </summary>
        /// <returns>
        /// Ein konvertierter Wert. Wenn die Methode null zurückgibt, wird der gültige NULL-Wert verwendet.
        /// </returns>
        /// <param name="value">Der Wert, der vom Bindungsziel erzeugt wird.</param><param name="targetType">Der Typ, 
        /// in den konvertiert werden soll.</param><param name="parameter">Der zu verwendende Konverterparameter.
        /// </param><param name="culture">Die im Konverter zu verwendende Kultur.</param>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            _option ^= (Option)parameter;

            return (int)_option;
        }
    }
}