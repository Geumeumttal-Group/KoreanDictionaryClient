namespace GeumeumttalGroup.KoreanDictionaryClient.Core.LearnersDictionary;

/// <summary>
/// An enum of avaible sorting methods for sorting the search results.
/// </summary>
public enum DictionarySort
{
    /// <summary>
    /// [Default] Sort search results alphabetically.
    /// </summary>
    Dictionary,
    /// <summary>
    /// Sort search results by populartity of the specific results.
    /// </summary>
    Popularity
}

public static class SortExtention
{
    /// <summary>
    /// Converts the enum to its corresponding string value utilized by the Korean Learners Dictionary API.
    /// </summary>
    public static string ToApiValue(this DictionarySort sort)
    {
        return sort == DictionarySort.Dictionary ? "dict" : "popular";
    }
}
