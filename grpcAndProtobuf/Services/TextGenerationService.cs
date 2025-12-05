using Grpc.Core;
using AI.Proto; // Must match your csharp_namespace

namespace grpcAndProtobuf.Services;

public class TextGenerationService : TextGeneration.TextGenerationBase
{
    public override Task<GenerateResponse> Generate(GenerateRequest request, ServerCallContext context)
    {
        return Task.FromResult(new GenerateResponse
        {
            Content = $"AI placeholder response for prompt: {request.Prompt}"
        });
    }
}
