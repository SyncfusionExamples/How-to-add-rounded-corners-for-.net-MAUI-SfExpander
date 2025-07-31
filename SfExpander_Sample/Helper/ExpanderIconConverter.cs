using System.Globalization;

namespace SfExpander_Sample.Helper
{
    #region ExpanderIconConverter
    public class ExpanderIconConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value != null && (bool)value)
                return ImageSource.FromFile("arrow_down.png");
            else
                return ImageSource.FromFile("arrow_up.png");
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region CornerRadiusConverter
    public class CornerRadiusConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value != null && (bool)value ? new CornerRadius(20, 20, 0, 0) : new CornerRadius(20, 20, 20, 20);
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}