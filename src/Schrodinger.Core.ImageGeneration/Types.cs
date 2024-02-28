namespace Schrodinger.Core;

public class ImageDescription
{
    /// <summary>
    /// The traits that the image has
    /// </summary>
    public required IList<Trait> Traits { get; set; }

    /// <summary>
    /// Image in base64 format
    /// </summary>
    public required string Image { get; set; }
}

public class Trait(string name, string value)
{
    /// <summary>
    /// The name of the trait type
    /// </summary>
    public string Name { get; set; } = name;

    /// <summary>
    /// The value of the trait the image has
    /// </summary>
    public string Value { get; set; } = value;
}

public class ImageGenerationRequest
{
    /// <summary>
    /// The id of the request. This is used to track the request.
    /// </summary>
    public required string RequestId { get; set; }

    /// <summary>
    /// The parent image that the new image is based on.
    /// </summary>
    public required ImageDescription Parent { get; set; }

    /// <summary>
    /// The new trait that the new image has on top of the parent image.
    /// </summary>
    public required Trait NewTrait { get; set; }
}

public class ImageGenerationResponse
{
    /// <summary>
    /// The id of the request. This is used to track the request. It should be the same as the request id.
    /// </summary>
    public required string RequestId { get; set; }

    /// <summary>
    /// The generated image
    /// </summary>
    public required ImageDescription GeneratedImage { get; set; }

    /// <summary>
    /// It's used to store extra data that may be needed.
    /// </summary>
    public string? ExtraData { get; set; }
}