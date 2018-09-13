
using Android.Content;

using Xamarin.Forms;
[assembly: Dependency(typeof(AssemblyService))]
public class AssemblyService : IAssemblyService
{
    string IAssemblyService.GetPackageName()
    {
        //Context context = Forms.Context;
        var context = Android.App.Application.Context;
        var name = context.PackageManager.GetPackageInfo(context.PackageName, 0).PackageName;
        return name;
    }
}
