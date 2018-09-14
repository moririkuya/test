using System;
using CoreGraphics;
using Airlex.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Airlex;

[assembly: ExportRenderer(typeof(ExBoxView), typeof(ExBoxViewRenderer))]

namespace Airlex.iOS{
    internal class ExBoxViewRenderer :BoxRenderer {
        public override void Draw(CGRect rect) {
            //base.Draw()rect;
            //Device.BeginInvokeOnMainThread(() =>

               
               var exBoxView = (ExBoxView)Element;
                //using (var context = UIGraphics.GetCurrentContext())
                {
                    var context = UIGraphics.GetCurrentContext();
                    var radius = exBoxView.Radius;
                    context.SetFillColor(exBoxView.Color.ToCGColor());

                var bounds = Bounds.Inset(0,0);
                context.AddPath(CGPath.FromRoundedRect(bounds, radius, radius)); //図の座標設定
                context.DrawPath(CGPathDrawingMode.Fill); //座標をもとに描画
                    LayoutIfNeeded();
                }
            //});
        }
    }
}
