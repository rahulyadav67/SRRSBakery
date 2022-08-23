using Newtonsoft.Json;

namespace SRRSBakery.Models
{
    public static class APIClass
    {
        public static async Task<IEnumerable<Item>> GetAPIData(string APIAddress)
        {
            IEnumerable<Item> items = new List<Item>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(APIAddress))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    items = JsonConvert.DeserializeObject<IEnumerable<Item>>(apiResponse);
                }
            }
            return items;
            
        }
        public static async Task<IEnumerable<Category>> GetAPIData2(string APIAddress2)
        {
            IEnumerable<Category> categories = new List<Category>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(APIAddress2))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    categories = JsonConvert.DeserializeObject<IEnumerable<Category>>(apiResponse);
                }
            }
            return categories;

        }
    }
}
