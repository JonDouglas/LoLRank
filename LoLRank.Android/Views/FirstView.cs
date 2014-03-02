using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using LoLRank.Core.ViewModels;

namespace LoLRank.Android.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
        }

        public new FirstViewModel ViewModel
        {
            get { return (FirstViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }
    }
}