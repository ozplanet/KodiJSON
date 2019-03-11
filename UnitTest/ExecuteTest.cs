using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;

namespace UnitTest
{
    public static class ExecuteTest
    {
        public static string GetResponse(object obj)
        {
            string jsonData = JsonConvert.SerializeObject(obj);

            Debug.WriteLine(jsonData);

            using (WebClient client = new WebClient())
            {
                return client.UploadString("http://localhost:8081/jsonrpc", "POST", jsonData);
            }
        }
    }
}
