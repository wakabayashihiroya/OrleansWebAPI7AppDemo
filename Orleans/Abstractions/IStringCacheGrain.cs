namespace OrleansWebAPI7AppDemo.Orleans.Abstractions
{
    public interface IStringCacheGrain : IGrainWithStringKey
    {
        Task SetValue(string value);
        Task<string> GetValue();
    }
}
