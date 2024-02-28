namespace Schrodinger.Core;

public interface IImageGeneratorGrain
{
    /// <summary>
    /// It generates a new image based on the parent image and the new trait.
    /// </summary>
    /// <param name="request">the request</param>
    /// <returns></returns>
    Task<ImageGenerationResponse> GenerateImageAsync(ImageGenerationRequest request);
}