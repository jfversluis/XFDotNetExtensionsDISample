using System;
namespace XFDotNetExtensionsDISample
{
    public interface IMyService
    {
        string GetString();
    }

    public class MyService : IMyService
    {
        public string GetString()
        {
            return "Hello!";
        }
    }
}
