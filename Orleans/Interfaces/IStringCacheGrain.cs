namespace OrleansWebAPI7AppDemo.Orleans.Interfaces
{
    public interface IStringCacheGrain : IGrainWithStringKey
    {
        Task SetValue(string value);
        Task<string> GetValue();
    }
}
