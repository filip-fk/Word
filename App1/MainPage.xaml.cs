using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            CoreApplicationViewTitleBar coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = false;

            this.ViewModel = new RecordingViewModel();

            num_of_words_r.Text = $"{de_word_der.Items.Count()}" + $"{de_word_der_load.Items.Count()}";

            
        }

        public RecordingViewModel ViewModel { get; set; }


        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

        string pl = string.Empty;

        private void add_word_click(object sender, RoutedEventArgs e)
        {
            // der
            if (der_die_das.SelectedItem == der)
            {
                if ((new_de.Text != null) && (new_bg.Text != null))
                {
                    string lll = string.Empty;

                    if (l.IsChecked == true) { lll = "-"; }
                    else if (ll.IsChecked == true) { lll = "⸚"; }

                    pl = ", " + lll + " " + pl_10.Text;

                    localSettings.Values["de_bg_r_save"] += new_de.Text + "1" + "," + new_bg.Text + "2" + "," + pl + "3" + ";";
                    add_der();
                }
            }

            // die
            if (der_die_das.SelectedItem == die)
            {
                if ((new_de.Text != null) && (new_bg.Text != null))
                {
                    string lll = string.Empty;

                    if (l.IsChecked == true) { lll = "-"; }
                    else if (ll.IsChecked == true) { lll = "⸚"; }

                    pl = ", " + lll + " " + pl_10.Text;

                    localSettings.Values["de_bg_e_save"] += new_de.Text + "1" + "," + new_bg.Text + "2" + "," + pl + "3" + ";";
                    add_die();
                }
            }

            //das
            if (der_die_das.SelectedItem == das)
            {
                if ((new_de.Text != null) && (new_bg.Text != null))
                {
                    string lll = string.Empty;

                    if (l.IsChecked == true) { lll = "-"; }
                    else if (ll.IsChecked == true) { lll = "⸚"; }

                    pl = ", " + lll + " " + pl_10.Text;

                    localSettings.Values["de_bg_s_save"] += new_de.Text + "1" + "," + new_bg.Text + "2" + "," + pl + "3" + ";";
                    add_das();
                }
            }
        }

        public void add_der()
        {
            //de
            StackPanel stp_de_r = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(6), Height = 30 };

            TextBlock txb_de_r = new TextBlock() { Text = "r", Width = 15, Margin = new Thickness(0, 0, 12, 0), VerticalAlignment = VerticalAlignment.Center, FontSize = 25 };

            stp_de_r.Children.Add(txb_de_r);

            StackPanel stp2_de_r = new StackPanel() { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Center };

            TextBlock txb1_de_r_word = new TextBlock() { Text = new_de.Text, FontWeight= FontWeights.Bold, VerticalAlignment = VerticalAlignment.Center, FontSize = 25};
            TextBlock txb2_de_r_plur = new TextBlock() { Text = pl, VerticalAlignment = VerticalAlignment.Center, FontSize = 25 };

            stp2_de_r.Children.Add(txb1_de_r_word);
            stp2_de_r.Children.Add(txb2_de_r_plur);

            stp_de_r.Children.Add(stp2_de_r);

            de_word_der.Items.Add(stp_de_r);

            //bg

            StackPanel stp_bg_r = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(6), Height = 30 };
            
            TextBlock txb1_bg_r_word = new TextBlock() { Text = new_bg.Text, VerticalAlignment = VerticalAlignment.Center, FontSize = 20 };

            stp_bg_r.Children.Add(txb1_bg_r_word);
            
            bg_word_der.Items.Add(stp_bg_r);
        }

        public void add_die()
        {
            //de
            StackPanel stp_de_e = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(6), Height = 30 };

            TextBlock txb_de_e = new TextBlock() { Text = "e", Width = 15, Margin = new Thickness(0, 0, 12, 0), VerticalAlignment = VerticalAlignment.Center, FontSize = 25 };

            stp_de_e.Children.Add(txb_de_e);

            StackPanel stp2_de_e = new StackPanel() { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Center };

            TextBlock txb1_de_e_word = new TextBlock() { Text = new_de.Text, FontWeight = FontWeights.Bold, VerticalAlignment = VerticalAlignment.Center, FontSize = 25 };
            TextBlock txb2_de_e_plur = new TextBlock() { Text = pl, VerticalAlignment = VerticalAlignment.Center, FontSize = 25 };

            stp2_de_e.Children.Add(txb1_de_e_word);
            stp2_de_e.Children.Add(txb2_de_e_plur);

            stp_de_e.Children.Add(stp2_de_e);

            de_word_der.Items.Add(stp_de_e);

            //bg

            StackPanel stp_bg_e = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(6), Height = 30 };

            TextBlock txb1_bg_e_word = new TextBlock() { Text = new_bg.Text, VerticalAlignment = VerticalAlignment.Center, FontSize = 20 };

            stp_bg_e.Children.Add(txb1_bg_e_word);

            bg_word_der.Items.Add(stp_bg_e);
        }

        public void add_das()
        {
            //de
            StackPanel stp_de_s = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(6), Height = 30 };

            TextBlock txb_de_s = new TextBlock() { Text = "s", Width = 15, Margin = new Thickness(0, 0, 12, 0), VerticalAlignment = VerticalAlignment.Center, FontSize = 25 };

            stp_de_s.Children.Add(txb_de_s);

            StackPanel stp2_de_s = new StackPanel() { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Center };

            TextBlock txb1_de_s_word = new TextBlock() { Text = new_de.Text, FontWeight = FontWeights.Bold, VerticalAlignment = VerticalAlignment.Center, FontSize = 25 };
            TextBlock txb2_de_s_plur = new TextBlock() { Text = pl, VerticalAlignment = VerticalAlignment.Center, FontSize = 25 };

            stp2_de_s.Children.Add(txb1_de_s_word);
            stp2_de_s.Children.Add(txb2_de_s_plur);

            stp_de_s.Children.Add(stp2_de_s);

            de_word_der.Items.Add(stp_de_s);

            //bg

            StackPanel stp_bg_s = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(6), Height = 30 };

            TextBlock txb1_bg_s_word = new TextBlock() { Text = new_bg.Text, VerticalAlignment = VerticalAlignment.Center, FontSize = 20 };

            stp_bg_s.Children.Add(txb1_bg_s_word);

            bg_word_der.Items.Add(stp_bg_s);
        }

        private void del_word_click(object sender, RoutedEventArgs e)
        {
            localSettings.Values["de_bg_r_save"] = null;
            localSettings.Values["de_e_save"] = null;
            localSettings.Values["de_s_save"] = null;
            //localSettings.Values["bg_r_save"] = null;
            localSettings.Values["bg_e_save"] = null;
            localSettings.Values["bg_s_save"] = null;

            de_word_der.Items.Clear();
        }

        private void add_word_showCont(object sender, TappedRoutedEventArgs e)
        {
            if (addCont.Visibility == Visibility.Collapsed)
            {
                openAddCont.Begin();
            }

            else closeAddCont.Begin();
        }

        /*
        private void add_word_click(object sender, RoutedEventArgs e)
        {
            if (der_die_das.SelectedItem == der)
            {
                if ((new_de.Text != null) && (new_bg.Text != null))
                {
                    if (de_word_der.Children.Count > 0)
                    {
                        Border der_brd_de = new Border();
                        der_brd_de.Height = 40;
                        der_brd_de.BorderBrush = new SolidColorBrush(Colors.Black);
                        der_brd_de.BorderThickness = new Thickness(0, 1, 0, 0);

                        Border der_brd_bg = new Border();
                        der_brd_bg.Height = 40;
                        der_brd_bg.BorderBrush = new SolidColorBrush(Colors.Black);
                        der_brd_bg.BorderThickness = new Thickness(0, 1, 0, 0);

                        TextBlock newde_toadd = new TextBlock();
                        newde_toadd.Text = new_de.Text;
                        newde_toadd.FontSize = 20;
                        newde_toadd.FontWeight = FontWeights.Bold;
                        newde_toadd.Height = 40;
                        der_brd_de.Child = newde_toadd;

                        TextBlock newbg_toadd = new TextBlock();
                        newbg_toadd.Text = new_bg.Text;
                        newbg_toadd.FontSize = 20;
                        newbg_toadd.Height = 40;
                        newbg_toadd.Margin = new Thickness(5, 0, 0, 0);
                        der_brd_bg.Child = newbg_toadd;

                        de_word_der.Children.Add(der_brd_de);
                        bg_word_der.Children.Add(der_brd_bg);
                    }

                    else
                    {
                        TextBlock newde_toadd = new TextBlock();
                        newde_toadd.Text = new_de.Text;
                        newde_toadd.FontSize = 20;
                        newde_toadd.FontWeight = FontWeights.Bold;
                        newde_toadd.Height = 40;
                        de_word_der.Children.Add(newde_toadd);

                        TextBlock newbg_toadd = new TextBlock();
                        newbg_toadd.Text = new_bg.Text;
                        newbg_toadd.FontSize = 20;
                        newbg_toadd.Height = 40;
                        newbg_toadd.Margin = new Thickness(5, 0, 0, 0);
                        bg_word_der.Children.Add(newbg_toadd);
                    }
                }
            }

            else if (der_die_das.SelectedItem == die)
            {
                if ((new_de.Text != null) && (new_bg.Text != null))
                {
                    if (de_word_die.Children.Count > 0)
                    {
                        Border die_brd_de = new Border();
                        die_brd_de.Height = 40;
                        die_brd_de.BorderBrush = new SolidColorBrush(Colors.Black);
                        die_brd_de.BorderThickness = new Thickness(0, 1, 0, 0);

                        Border die_brd_bg = new Border();
                        die_brd_bg.Height = 40;
                        die_brd_bg.BorderBrush = new SolidColorBrush(Colors.Black);
                        die_brd_bg.BorderThickness = new Thickness(0, 1, 0, 0);

                        TextBlock newde_toadd = new TextBlock();
                        newde_toadd.Text = new_de.Text;
                        newde_toadd.FontSize = 20;
                        newde_toadd.FontWeight = FontWeights.Bold;
                        newde_toadd.Height = 40;
                        die_brd_de.Child = newde_toadd;

                        TextBlock newbg_toadd = new TextBlock();
                        newbg_toadd.Text = new_bg.Text;
                        newbg_toadd.FontSize = 20;
                        newbg_toadd.Height = 40;
                        newbg_toadd.Margin = new Thickness(5, 0, 0, 0);
                        die_brd_bg.Child = newbg_toadd;

                        de_word_die.Children.Add(die_brd_de);
                        bg_word_die.Children.Add(die_brd_bg);
                    }

                    else
                    {
                        TextBlock newde_toadd = new TextBlock();
                        newde_toadd.Text = new_de.Text;
                        newde_toadd.FontSize = 20;
                        newde_toadd.FontWeight = FontWeights.Bold;
                        newde_toadd.Height = 40;
                        de_word_die.Children.Add(newde_toadd);

                        TextBlock newbg_toadd = new TextBlock();
                        newbg_toadd.Text = new_bg.Text;
                        newbg_toadd.FontSize = 20;
                        newbg_toadd.Height = 40;
                        newbg_toadd.Margin = new Thickness(5, 0, 0, 0);
                        bg_word_die.Children.Add(newbg_toadd);
                    }
                }
            }

            else if (der_die_das.SelectedItem == das)
            {
                if (de_word_das.Children.Count > 0)
                {
                    Border das_brd_de = new Border();
                    das_brd_de.Height = 40;
                    das_brd_de.BorderBrush = new SolidColorBrush(Colors.Black);
                    das_brd_de.BorderThickness = new Thickness(0, 1, 0, 0);

                    Border das_brd_bg = new Border();
                    das_brd_bg.Height = 40;
                    das_brd_bg.BorderBrush = new SolidColorBrush(Colors.Black);
                    das_brd_bg.BorderThickness = new Thickness(0, 1, 0, 0);

                    TextBlock newde_toadd = new TextBlock();
                    newde_toadd.Text = new_de.Text;
                    newde_toadd.FontSize = 20;
                    newde_toadd.FontWeight = FontWeights.Bold;
                    newde_toadd.Height = 40;
                    das_brd_de.Child = newde_toadd;

                    TextBlock newbg_toadd = new TextBlock();
                    newbg_toadd.Text = new_bg.Text;
                    newbg_toadd.FontSize = 20;
                    newbg_toadd.Height = 40;
                    newbg_toadd.Margin = new Thickness(5, 0, 0, 0);
                    das_brd_bg.Child = newbg_toadd;

                    de_word_das.Children.Add(das_brd_de);
                    bg_word_das.Children.Add(das_brd_bg);
                }

                else
                {
                    TextBlock newde_toadd = new TextBlock();
                    newde_toadd.Text = new_de.Text;
                    newde_toadd.FontSize = 20;
                    newde_toadd.FontWeight = FontWeights.Bold;
                    newde_toadd.Height = 40;
                    de_word_das.Children.Add(newde_toadd);

                    TextBlock newbg_toadd = new TextBlock();
                    newbg_toadd.Text = new_bg.Text;
                    newbg_toadd.FontSize = 20;
                    newbg_toadd.Height = 40;
                    newbg_toadd.Margin = new Thickness(5, 0, 0, 0);
                    bg_word_das.Children.Add(newbg_toadd);
                }
            }
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        */
    }
}
