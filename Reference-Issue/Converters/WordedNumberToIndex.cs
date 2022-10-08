using System;
using System.Collections.Generic;
using System.Globalization;
using Avalonia.Data.Converters;
using System.Linq;

namespace Issue.Converters
{
    public class WordedNumberToIndex : IValueConverter
    {
        public Dictionary<uint, string> SomeDictionary { get; set; } = new() 
        {
            [1] = "One",
            [2] = "Two"
        };

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string wordedNumber)
            {
                var index = SomeDictionary.Values.ToList().IndexOf(wordedNumber);
                return index;
            }

            return -1;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is int index)
            {
                if (SomeDictionary.Count > index && index >= 0)
                {
                    var resValue = SomeDictionary.Values.ToArray()[index];
                    return resValue;
                }
            }

            return -1;
        } 
    }
}