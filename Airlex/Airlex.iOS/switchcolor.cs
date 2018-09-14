using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Airlex;
using Foundation;


[assembly: ResolutionGroupName("Airlex")]
[assembly: ExportEffect(typeof(Airlex.iOS.switchcolor),"switchcolor")]


namespace Airlex.iOS
{
    public class switchcolor : PlatformEffect
    {


        protected override void OnAttached()
        {
            var sw = this.Control as UISwitch;
            sw.OnTintColor = UIColor.Red;
        }

        protected override void OnDetached()
        {
            
        }
    }
}
