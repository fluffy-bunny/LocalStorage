using System.Threading.Tasks;

namespace Blazored.LocalStorage
{
    public interface IDataTransformer
    {
        /// <summary>
        /// transforms the incoming data to another form
        /// </summary>
        /// <returns>A <see cref="Task<string>"/> representing the transformed data.</returns>
        Task<string> TransformAsync(string data);

        /// <summary>
        /// Reverses an original transformation
        /// </summary>
        /// <returns>A <see cref="Task<string>"/> representing original string prior to transformation.</returns>
        Task<string> UntransformAsync(string data);

        /// <summary>
        /// transforms the incoming data to another form
        /// </summary>
        /// <returns>A <see cref="string"/> representing the transformed data.</returns>
        string Transform(string data);

        /// <summary>
        /// Reverses an original transformation
        /// </summary>
        /// <returns>A <see cref="string"/> representing original string prior to transformation.</returns>
        string Untransform(string data);
    }
}
