using System;
using System.Collections.Generic;
using System.Globalization;
using Avalonia.Data.Converters;

namespace Issue.Converters
{
    public class NumberToText : IValueConverter
    {
        public Dictionary<uint, string> SomeDictionary { get; set; } = new() 
        {
            [1] = "One",
            [2] = "Two"
        };

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is uint number)
            {
                var index = SomeDictionary[number];
                return index;
            }

            return -1;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string wordedNumber)
            {
                foreach(var entry in SomeDictionary)
                {
                    if (entry.Value == wordedNumber)
                    {
                        var key = entry.Key;
                        return key;
                    }
                }
            }

            return -1;
        } 
    }
}