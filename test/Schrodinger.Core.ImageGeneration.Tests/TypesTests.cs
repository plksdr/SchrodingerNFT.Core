using Newtonsoft.Json;

namespace Schrodinger.Core.ImageGeneration.Tests;

public class TypesTests
{
    [Fact]
    public void ImageGenerationRequest_Test()
    {
        var request = new ImageGenerationRequest
        {
            RequestId = "123",
            NewTrait = new Trait("Beard", "Long"),
            Parent = new ImageDescription
            {
                Image = "imagedatainbase64",
                Traits = new List<Trait>
                {
                    new("Hat",
                        "Viking Helmet"),
                }
            }
        };
        var requestStr =
            @"{""RequestId"":""123"",""Parent"":{""Traits"":[{""Name"":""Hat"",""Value"":""Viking Helmet""}],""Image"":""imagedatainbase64""},""NewTrait"":{""Name"":""Beard"",""Value"":""Long""}}";

        var json = JsonConvert.SerializeObject(request);
        Assert.Equal(requestStr, json);
    }

    [Fact]
    public void ImageGenerationResponse_Test()
    {
        var response = new ImageGenerationResponse
        {
            RequestId = "123",
            GeneratedImage = new ImageDescription
            {
                Image = "newimagedatainbase64",
                Traits = new List<Trait>
                {
                    new("Hat",
                        "Viking Helmet"),
                    new("Beard", "Long"),
                }
            },
            ExtraData = "some artitrary data"
        };
        var responseStr =
            @"{""RequestId"":""123"",""GeneratedImage"":{""Traits"":[{""Name"":""Hat"",""Value"":""Viking Helmet""},{""Name"":""Beard"",""Value"":""Long""}],""Image"":""newimagedatainbase64""},""ExtraData"":""some artitrary data""}";


        var json = JsonConvert.SerializeObject(response);
        Assert.Equal(responseStr, json);
    }
}