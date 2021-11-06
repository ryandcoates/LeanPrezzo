namespace LeanPrezo.Web.Utils
{
  public static class HttpHelper
  {
    // TODO move to HostEnvironment
    public static string BaseUrl { get; set; } = "http://localhost:7071/";
    // "https://leanprezzo-api.azurewebsites.net/";

    public static string Get(string uri)
    {
      if (BaseUrl.EndsWith("/") && uri.StartsWith("/"))
      {
        uri = uri.Substring(1);
      }
      return BaseUrl + uri;
    }
  }
}