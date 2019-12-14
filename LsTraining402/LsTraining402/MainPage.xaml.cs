using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace LsTraining402
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> strList = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();

            list01.ItemsSource = strList;
        }

        /// <summary>
        /// 色変更ボタン
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void ChangeButton_Clicked(object sender, System.EventArgs e)
        {
            if (lbl01.TextColor.Equals(Color.Aqua))
            {
                lbl01.TextColor = Color.Black;
            }
            else
            {
                lbl01.TextColor = Color.Aqua;
            }
        }

        /// <summary>
        /// テキストコピーボタン
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void CopyButton_Clicked(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(ety01.Text))
            {
                lbl01.Text = ety01.Text;
                ety01.Text = string.Empty;
            }
        }

        /// <summary>
        /// リスト追加ボタン
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void AddBtn_Clicked(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(ety02.Text))
            {
                strList.Add(ety02.Text);
                ety02.Text = string.Empty;
            }
        }

        /// <summary>         /// リストクリアボタン         /// </summary>         /// <param name="sender">Sender.</param>         /// <param name="e">E.</param>         void ClearBtn_Clicked(object sender, System.EventArgs e)         {             strList.Clear();         }

    }
}
