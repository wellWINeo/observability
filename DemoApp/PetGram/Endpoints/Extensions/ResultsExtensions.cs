using Microsoft.AspNetCore.Http.HttpResults;

namespace PetGram.Endpoints.Extensions;

public static class ResultsExtensions
{
    public static Ok<T> AsOk<T>(this T obj) => TypedResults.Ok(obj);

    public static async Task<Ok> AsOk(this Task task)
    {
        await task;
        return TypedResults.Ok();
    }
    
    public static async Task<Ok<T>> AsOk<T>(this Task<T> task)
        => TypedResults.Ok(await task);

    public static async Task<O> Pipe<I, O>(this Task<I> task, Func<I, O> functor)
        => functor(await task);

    public static async Task<O> Pipe<O>(this Task task, Func<O> functor)
    {
        await task;
        return functor();
    }
}
