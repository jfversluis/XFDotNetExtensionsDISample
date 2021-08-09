using System;
namespace XFDotNetExtensionsDISample
{
    public class MainPageModel
    {
        public string InjectedString { get; set; }

        public MainPageModel(IMyService myService)
        {
            InjectedString = myService.GetString();
        }
    }
}
