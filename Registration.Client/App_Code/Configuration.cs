using System.Configuration;

/// <summary>
/// Summary description for Configuration
/// </summary>
public static class Configuration
{
    public static string ApiServerPath => ConfigurationManager.AppSettings["ApiServerPath"];
    public static string WebAppPath => ConfigurationManager.AppSettings["WebAppPath"];
}