using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V7.Widget;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Switch = Android.Widget.Switch;

[assembly: ResolutionGroupName("Airlex")]
[assembly: ExportEffect(typeof(Airlex.Droid.switchcolor),"switchcolor")]
namespace Airlex.Droid
{
    public class switchcolor : PlatformEffect
    {
        protected override void OnAttached()
        {

            var sw = this.Control as SwitchCompat;

            //sw.ThumbDrawable = new ColorDrawable(Android.Graphics.Color.Red);
            //sw.ThumbDrawable = ResourceManager.GetDrawable(Android.App.Application.Context,"face.png");
             int[][] states = new int[3][];
             int[] colors = new int[3];
            int i = 0;

            // Disabled state
            states[i] = new int[] { -Android.Resource.Attribute.StateEnabled};
            colors[i] =Android.Graphics.Color.Blue;
            i++;

            states[i] = new int[] { Android.Resource.Attribute.StateChecked };
            colors[i] = Android.Graphics.Color.Blue;
            i++;

            // Default enabled state
            states[i] = new int[0];
            colors[i] = Android.Graphics.Color.LightGray;
            i++;
            sw.ThumbTintList = new ColorStateList(states, colors);
            sw.ThumbTintMode = PorterDuff.Mode.SrcIn;
        }

        protected override void OnDetached()
        {

        }
    }
}

