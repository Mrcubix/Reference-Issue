# Why does this exist

There seem to be an issue somewhere, as for some reasons, [`ConvertBack()`](/Reference-Issue/Converters/WordedNumberToIndex.cs#L28) From [`WordedNumberToIndex`](/Reference-Issue/Converters/WordedNumberToIndex.cs) is called with -1 whenever the reference of a collection of items is changed.