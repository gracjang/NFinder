namespace NFinder.Application.Handlers;

using System.Diagnostics;
using Combinatorics.Collections;
using MediatR;
using NFinder.Application.Channels;
using NFinder.Application.Channels.Models;
using NFinder.Application.DTOs.Requests;
using NFinder.Application.DTOs.Responses;
using NFinder.Application.Exceptions;
using NFinder.Domain.ValueObjects;

public class StartJobHandler : IRequestHandler<StartJobRequest, StartJobResponse>
{
    private readonly JobChannel _jobChannel;

    public StartJobHandler(JobChannel jobChannel)
    {
        _jobChannel = jobChannel;
    }

    public async Task<StartJobResponse> Handle(StartJobRequest request, CancellationToken cancellationToken)
    {
        _ = request ?? throw new NullReferenceException(nameof(request));

        var jobId = new JobId(Guid.NewGuid());
        var combinations = CheckCombination(request.Characters);
        if (request.Count > combinations.Count)
        {
            throw new OutOfRangeCombinationCountException(combinations.Count, request.Count);
        }
        
        await _jobChannel.Publish(new ProcessJob(jobId.Value, request.max, request.min, combinations));
        return new StartJobResponse();
    }

    private List<string> CheckCombination(IEnumerable<char> characters)
    {
        var allCombinations = new List<string>();
        var chars = characters.ToList();
        for (var index = 0; index < chars.Count; index++)
        {
            var combinationStrings = new Combinations<char>(chars, index, GenerateOption.WithRepetition);
            allCombinations.AddRange(combinationStrings.Select(c => string.Join("", c)));
        }

        return allCombinations;
    }
}