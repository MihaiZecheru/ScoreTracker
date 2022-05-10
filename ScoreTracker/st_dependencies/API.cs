using System.Net;
using Newtonsoft.Json;

namespace st_dependencies
{
    public class API
    {
        public static int ParseScore(string API_Response)
        {
            try
            {
                Dictionary<string, int> dictionary = JsonConvert.DeserializeObject<Dictionary<string, int>>(API_Response);
                return dictionary["score"];
            }
            catch { return 0; }
        }

        public static async Task<Tuple<bool, string>> Get(string name)
        { 
            string url = $"https://scoretracker.fireapis.com/{name}/1";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-ID", name == "chris" ? "384" : "386");
                client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhcGlfa2V5IjoiOWMzNzMzNWQtMmQ3Yy00ZGJlLWFkMjUtZmRkYjE4MGRkMzg0IiwidGVuYW50X2lkIjo1MDIsImp0aV9rZXkiOiJlNWVkNDc1NS1kYjU1LTQ2MmMtOGMzYi0yZmI2MGQ0MGM2ZmYifQ.0QDcczZSwWA39h3B6NpIYM_HjxKw4SnTHtOy0EN-RNI");

                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    using (HttpContent responseContent = response.Content)
                    {
                        string content = await responseContent.ReadAsStringAsync();

                        int score = ParseScore(content);

                        Tuple<bool, string> result = Tuple.Create(response.StatusCode == HttpStatusCode.OK, $"Current Score For {name.Substring(0, 1).ToUpper() + name.Substring(1)}: {score}");
                        return result;
                    }
                }
            }
        }

        public static async Task<Tuple<bool, string>> Put(string name, int amount)
        {
            Tuple<bool, string> old = await Get(name);

            int score = int.Parse(old.Item2.Substring(old.Item2.IndexOf(':') + 2)) + amount;

            if (score < 0)
            {
                Console.WriteLine("NOTE: Score can not be less than 0");
                score = 0;
            }

            string url = $"https://scoretracker.fireapis.com/{name}/1";

            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("id", "1"),
            new KeyValuePair<string, string>("score", $"{score}")
        };

            HttpContent body = new FormUrlEncodedContent(queries);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-ID", name == "chris" ? "384" : "386");
                client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhcGlfa2V5IjoiOWMzNzMzNWQtMmQ3Yy00ZGJlLWFkMjUtZmRkYjE4MGRkMzg0IiwidGVuYW50X2lkIjo1MDIsImp0aV9rZXkiOiJlNWVkNDc1NS1kYjU1LTQ2MmMtOGMzYi0yZmI2MGQ0MGM2ZmYifQ.0QDcczZSwWA39h3B6NpIYM_HjxKw4SnTHtOy0EN-RNI");

                using (HttpResponseMessage response = await client.PutAsync(url, body))
                {
                    using (HttpContent responseContent = response.Content)
                    {
                        string content = await responseContent.ReadAsStringAsync();

                        Tuple<bool, string> result = Tuple.Create(response.StatusCode == HttpStatusCode.OK, $"Current Score For {name.Substring(0, 1).ToUpper() + name.Substring(1)}: {score}");
                        return result;
                    }
                }
            }
        }
    }
}