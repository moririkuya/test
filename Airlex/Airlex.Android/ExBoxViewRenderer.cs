using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Airlex.Droid;
using Airlex;
using Android.Content;

[assembly: ExportRenderer(typeof(ExBoxView), typeof(ExBoxViewRenderer))]
namespace Airlex.Droid {
    public class ExBoxViewRenderer : BoxRenderer 
    {
        Context _context;
        public ExBoxViewRenderer(Context context):base(context)
        {
            _context = context;


        }
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null) 
            {

            }
        }
        public override void Draw(Canvas canvas){
                //base.Draw(canvas);

            var exBoxView = (ExBoxView) Element;

            using (var paint = new Paint()){

                
                var density = _context.Resources.DisplayMetrics.Density;
                var shadowSize = 0;
                    var blur = shadowSize;
                var radius = exBoxView.Radius * density;

                paint.AntiAlias = true;


                //var rectangle = new RectF(shadowSize, shadowSize, Width - shadowSize, Height - shadowSize);

                    paint.Color = exBoxView.Color.ToAndroid();
                    paint.SetMaskFilter(null);
                    var rectangle = new RectF(0, 0, Width , Height );
                    canvas.DrawRoundRect(rectangle, radius, radius, paint);

                }
            }
        }
    }

