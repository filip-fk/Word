using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace App1
{
    public sealed partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            InitializeComponent();
        }



        public string word_r_17
        {
            get { return (string)GetValue(word_r_17Property); }
            set { SetValue(word_r_17Property, value); }
        }

        // Using a DependencyProperty as the backing store for name.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty word_r_17Property =
            DependencyProperty.Register("word_r_17", typeof(string), typeof(MyUserControl1),null);



        public string word_e_17
        {
            get { return (string)GetValue(word_e_17Property); }
            set { SetValue(word_e_17Property, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty word_e_17Property =
            DependencyProperty.Register("word_e_17", typeof(int), typeof(MyUserControl1), null);



        public string word_s_17
        {
            get { return (string)GetValue(word_s_17Property); }
            set { SetValue(word_s_17Property, value); }
        }

        // Using a DependencyProperty as the backing store for word_s_17.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty word_s_17Property =
            DependencyProperty.Register("word_s_17", typeof(string), typeof(MyUserControl1), null);




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
