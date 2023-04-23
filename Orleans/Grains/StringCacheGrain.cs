using Orleans.Runtime;
using OrleansWebAPI7AppDemo.Orleans.Abstractions;

namespace OrleansWebAPI7AppDemo.Orleans.Grains
{
    public class StringCacheGrain : Grain , IStringCacheGrain
    {
        private readonly IPersistentState<UrlDetails> _state;

        public StringCacheGrain([PersistentState(stateName: "url", storageName: "urls")] IPersistentState<UrlDetails> state)
        {
            _state = state;
        }

        public async Task SetValue(string fullUrl)
        {
            _state.State = new UrlDetails() { ShortenedRouteSegment = this.GetPrimaryKeyString(), FullUrl = fullUrl };
            await _state.WriteStateAsync();
        }

        public Task<string> GetValue()
        {
            return Task.FromResult(_state.State.FullUrl);
        }
    }

    [GenerateSerializer]
    public record UrlDetails
    {
        public string FullUrl { get; set; } = String.Empty;
        public string ShortenedRouteSegment { get; set; } = String.Empty;
    }
}
