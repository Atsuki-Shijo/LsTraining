using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LsTraining201
{
    public partial class App : Application
    {
        // メンバ変数
        private Label lbl01 = new Label { Text = "Hello, Xamarin!" };
        private Button btn01 = new Button { Text = "ChangeButton" };
        private Entry ety01 = new Entry { Text = "" };
        private Button btn02 = new Button { Text = "CopyButton" };
        private Button btn03 = new Button { Text = "AddBtn" };
        private Button btn04 = new Button { Text = "ClerBtn" };
        private Entry ety02 = new Entry { Text = "" };
        private StackLayout sLayout = new StackLayout { };
        private ListView list01 = new ListView { RowHeight = 40 };
        private ObservableCollection<string> strList = new ObservableCollection<string>();
        private Image img01 = new Image();
        private DatePicker dtp01 = new DatePicker();
        private WebView web01 = new WebView();

        public App()         {
            double top;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    top = 50;
                    break;
                case Device.Android:
                case Device.UWP:
                default:
                    top = 0;
                    break;
            }
            Thickness thic = new Thickness(10, top, 10, 10);

            // 入れ子のStackLayoutの初期化

            sLayout.Children.Add(btn03);
            sLayout.Children.Add(btn04);
            sLayout.Orientation = StackOrientation.Horizontal;

            list01.ItemsSource = strList;

            // Image(画像)の初期化

            img01.Source = ImageSource.FromResource("LsTraining201.Images.logo.png");
            img01.WidthRequest = 40;
            img01.HeightRequest = 40;

            // WebViewの追加
            web01.Source = "http://ls-style.co.jp/";
            web01.HeightRequest = 200;

            // ページの定義
            MainPage = new ContentPage             {                 Content = new StackLayout                 {                     Margin = thic,                     Children = {                         img01,                         new Label                         { Text = "Hello, Forms!",},                         lbl01,                         btn01,                         dtp01,                         ety01,                         btn02,                         web01,                         new Label { Text = "◆ListView"},                         ety02,                         sLayout,                         list01,                     }                 },             };              // ボタンのクリックイベントを設定                 btn01.Clicked += delegate {

                    if (lbl01.TextColor.Equals(Color.Aqua))
                    {
                        lbl01.TextColor = Color.Black;
                    }
                    else
                    {
                        lbl01.TextColor = Color.Aqua;
                    }
                };

                btn02.Clicked += delegate{

                    if (!string.IsNullOrEmpty(ety01.Text))
                    {
                        lbl01.Text = ety01.Text;
                        ety01.Text = string.Empty;
                    }
                };

                btn03.Clicked += delegate {

                    if (!string.IsNullOrEmpty(ety02.Text))
                    {
                        strList.Add(ety02.Text);
                        ety02.Text = string.Empty;
                    }
                };

                btn04.Clicked += delegate {
                    strList.Clear();
          	    };
            }
    }
}