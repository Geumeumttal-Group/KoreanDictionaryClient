namespace GeumeumttalGroup.KoreanDictionaryClient.Core.LearnersDictionary;

/// <summary>
/// An enum of avaible parts of the dictionary in which a search can be requested.
/// </summary>
public enum DictionaryPart
{
    /// <summary>
    /// [Default] A search based on the word itself.
    /// </summary>
    Word,
    /// <summary>
    /// A search based on idiomatic expressions and/or proverbs.
    /// </summary>
    IdiomProverb,
    /// <summary>
    /// A search based on definitions.
    /// </summary>
    Definition,
    /// <summary>
    /// A search based on exam utilization.
    /// </summary>
    Exam
}

public static class DictionaryPartExtension
{
    /// <summary>
    /// Converts the enum to its corresponding string value utilized by the Korean Learners Dictionary API.
    /// </summary>
    public static string ToApiValue(this DictionaryPart dictionaryPart)
    {
        return dictionaryPart switch
        {
            DictionaryPart.IdiomProverb => "ip",
            DictionaryPart.Definition => "dfn",
            DictionaryPart.Exam => "exam",
            _ => "word"
        };
    }
}
