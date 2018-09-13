using Xamarin.Forms;
using Foundation;
[assembly: Dependency(typeof(AssemblyService))]
public class AssemblyService : IAssemblyService
{
    public string GetPackageName()
    {
        string name = NSBundle.MainBundle.InfoDictionary["CFBundleDisplayName"].ToString();
        return name.ToString();
    }
}
