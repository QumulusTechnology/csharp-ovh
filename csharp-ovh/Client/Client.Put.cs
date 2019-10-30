using System;
using System.Threading.Tasks;

namespace Ovh.Api
{
    public partial class Client
    {
        /// <summary>
        /// Issues an async PUT call
        /// </summary>
        /// <param name="target">API method to call</param>
        /// <param name="data">Json data to send as body</param>
        /// <param name="needAuth">If true, send authentication headers</param>
        /// <returns>Raw API response</returns>
        public Task<string> PutAsync(string target, string data, bool needAuth = true)
        {
            return CallAsync("PUT", target, data, needAuth);
        }

        /// <summary>
        /// Issues an async PUT call
        /// </summary>
        /// <typeparam name="T">Expected return type</typeparam>
        /// <param name="target">API method to call</param>
        /// <param name="data">Json data to send as body</param>
        /// <param name="needAuth">If true, send authentication headers</param>
        /// <returns>API response deserialized to T by JSON.Net</returns>
        public Task<T> PutAsync<T>(string target, string data, bool needAuth = true)
        {
            return CallAsync<T>("PUT", target, data, needAuth);
        }

        /// <summary>
        /// Issues an async PUT call
        /// </summary>
        /// <typeparam name="T">Expected return type</typeparam>
        /// <typeparam name="Y">Input type</typeparam>
        /// <param name="target">API method to call</param>
        /// <param name="data">Json data to send as body</param>
        /// <param name="needAuth">If true, send authentication headers</param>
        /// <returns>API response deserialized to T by JSON.Net with Strongly typed object as input</returns>
        public Task<T> PutAsync<T, Y>(string target, Y data, bool needAuth = true)
            where Y : class
        {
            return CallAsync<T, Y>("PUT", target, data, needAuth);
        }
    }

}