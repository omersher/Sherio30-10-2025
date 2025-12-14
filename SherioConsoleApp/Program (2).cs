using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Model;
using ApiInterface;

namespace ApiInterface
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            ApiService apiService = new ApiService("http://localhost:5064");

            Console.ReadLine();
        }
    }
}
