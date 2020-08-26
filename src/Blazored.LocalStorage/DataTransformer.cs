using Blazored.LocalStorage.StorageOptions;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blazored.LocalStorage
{
    public class DataTransformer : IDataTransformer
    {
        public string Transform(string data)
        {
            return data;
        }

        public Task<string> TransformAsync(string data)
        {
            return Task.FromResult(data);
        }

        public string Untransform(string data)
        {
            return data;
        }

        public Task<string> UntransformAsync(string data)
        {
            return Task.FromResult(data);
        }
    }
}
