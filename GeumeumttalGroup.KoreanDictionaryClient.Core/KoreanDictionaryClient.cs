namespace GeumeumttalGroup.KoreanDictionaryClient.Core;

/// <summary>
/// Represents an abstract base class for Korean dictionary clients.
/// </summary>
/// <param name="apiKey">The API key that allows your client to access the Korean dictionary API.</param>
public abstract class KoreanDictionaryClient(string apiKey)
{
    /// <summary>
    /// The API key that allows your client to access the Korean dictionary API.
    /// </summary>
    private readonly string _apiKey = apiKey;
}
