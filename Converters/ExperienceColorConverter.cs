using System.Globalization;


namespace PokeApi.Converters
{
    public class ExperienceColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {   
             if (value == null)
                return Colors.Transparent;
           var Base_Experience  = System.Convert.ToInt32(value.ToString().Replace(".", ""));
             if (Base_Experience > 200)
                return Colors.Gold;

            if (Base_Experience > 100)
                return Colors.Orange;

            if (Base_Experience == 0)
                return Colors.Green;

            return Colors.Gray;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
