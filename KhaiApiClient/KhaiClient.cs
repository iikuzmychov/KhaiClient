using System.Net.Http;

namespace KhaiApiClient;

public class KhaiClient
{
    private const string BaseUrl = "https://education.khai.edu/";

    private HttpClient _httpClient;

    public KhaiApiClient()
    {
        _httpClient = new HttpClient()
        {
            BaseAddress = BaseUrl
        };
    }

    public  Get
}
