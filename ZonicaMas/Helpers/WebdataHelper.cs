using System.Threading.Tasks;
using System.Net.Http;

namespace ZonicaMas.Helpers
{
    class WebDataHelper
    {
        private const string imageGetLink = "http://www.radiozonica.com.ar/zonicamasimagenapp.php";
        private const string nameGetLink = "http://www.radiozonica.com.ar/zonicamasnombreapp.php";

        public async static Task<string> GetProgramLink()
        {
            string imageUrl = null;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(imageGetLink);
                imageUrl = await response.Content.ReadAsStringAsync();
            }

            return imageUrl;
        }

        public async static Task<string> GetProgramName()
        {
            string name = null;

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(nameGetLink);
                name = await response.Content.ReadAsStringAsync();
            }

            return name.Trim();
        }
    }
}
