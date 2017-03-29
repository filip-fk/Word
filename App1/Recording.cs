using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace App1
{
    public class Recording
    {
        public string word_de_10 { get; set; }
        public string word_bg_10 { get; set; }
        public string plural_10 { get; set; }

        public string word_de_10_r { get; set; }
        public string word_bg_10_r { get; set; }
        public string plural_10_r { get; set; }

        public string word_de_10_e { get; set; }
        public string word_bg_10_e { get; set; }
        public string plural_10_e { get; set; }

        public string word_de_10_s { get; set; }
        public string word_bg_10_s { get; set; }
        public string plural_10_s { get; set; }

        public string der_die_das_10 { get; set; }

        public string der_die_das_10_r { get; set; }

        public string der_die_das_10_e { get; set; }

        public string der_die_das_10_s { get; set; }

        public DateTime ReleaseDateTime { get; set; }
        public Recording()
        {
            this.word_de_10 = "Wolfgang, Amadeus, Mozart";
            this.word_bg_10 = "Andante in C for Piano";
            this.ReleaseDateTime = new DateTime(1761, 1, 1);
        }
        public string OneLineSummary
        {
            get
            {
                return $"{this.word_bg_10} by {this.word_de_10}, released: "
                    + this.ReleaseDateTime.ToString("d");
            }
        }
    }
    public class RecordingViewModel
    {
        //private Recording defaultRecording = new Recording();
        //public Recording DefaultRecording { get { return this.defaultRecording; } }
        public ObservableCollection<Recording> recordings = new ObservableCollection<Recording>();
        public ObservableCollection<Recording> Recordings { get { return this.recordings; } }
        public RecordingViewModel()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            try
            {
                string value_de = localSettings.Values["de_bg_r_save"].ToString();
                //string value_bg = localSettings.Values["bg_r_save"].ToString();

                string[] split1 = value_de.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var new_word in split1)
                {
                    string de = string.Empty;
                    string bg = string.Empty;
                    string pl = string.Empty;

                    string[] split2 = new_word.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    if (new_word != "")
                    {
                        foreach (string new_de_bg in split2)
                        {
                            //string[] de_split = "1";
                            if (new_de_bg.Contains("1"))
                            {
                                string[] de_split = new_de_bg.Split("1".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                                foreach (var n in de_split)
                                {
                                    de = n;
                                }
                            }

                            else if (new_de_bg.Contains("2"))
                            {
                                string[] de_split = new_de_bg.Split("2".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                                foreach (var n in de_split)
                                {
                                    bg = n;
                                }
                            }

                            else if (new_de_bg.Contains("3"))
                            {
                                string[] de_split = new_de_bg.Split("3".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                                foreach (var n in de_split)
                                {
                                    pl = n;
                                }
                            }
                        }
                    }

                    this.recordings.Add(new Recording()
                    {
                        word_de_10_r = de,
                        plural_10_r = pl,
                        word_bg_10_r = bg,
                        der_die_das_10_r = "r",
                        ReleaseDateTime = new DateTime(1748, 7, 8)
                    });
                }

            }

            catch { }

            try
            {
                string value_de = localSettings.Values["de_bg_e_save"].ToString();
                //string value_bg = localSettings.Values["bg_r_save"].ToString();

                string[] split1 = value_de.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var new_word in split1)
                {
                    string de = string.Empty;
                    string bg = string.Empty;
                    string pl = string.Empty;

                    string[] split2 = new_word.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    if (new_word != "")
                    {
                        foreach (string new_de_bg in split2)
                        {
                            //string[] de_split = "1";
                            if (new_de_bg.Contains("1"))
                            {
                                string[] de_split = new_de_bg.Split("1".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                                foreach (var n in de_split)
                                {
                                    de = n;
                                }
                            }

                            else if (new_de_bg.Contains("2"))
                            {
                                string[] de_split = new_de_bg.Split("2".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                                foreach (var n in de_split)
                                {
                                    bg = n;
                                }
                            }

                            else if (new_de_bg.Contains("3"))
                            {
                                string[] de_split = new_de_bg.Split("3".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                                foreach (var n in de_split)
                                {
                                    pl = n;
                                }
                            }
                        }
                    }

                    this.recordings.Add(new Recording()
                    {
                        word_de_10_e = de,
                        plural_10_e = pl,
                        word_bg_10_e = bg,
                        der_die_das_10_e = "e",
                        ReleaseDateTime = new DateTime(1748, 7, 8)
                    });
                }

            }

            catch { }

            try
            {
                string value_de = localSettings.Values["de_bg_s_save"].ToString();
                //string value_bg = localSettings.Values["bg_r_save"].ToString();

                string[] split1 = value_de.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var new_word in split1)
                {
                    string de = string.Empty;
                    string bg = string.Empty;
                    string pl = string.Empty;

                    string[] split2 = new_word.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    if (new_word != "")
                    {
                        foreach (string new_de_bg in split2)
                        {
                            //string[] de_split = "1";
                            if (new_de_bg.Contains("1"))
                            {
                                string[] de_split = new_de_bg.Split("1".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                                foreach (var n in de_split)
                                {
                                    de = n;
                                }
                            }

                            else if (new_de_bg.Contains("2"))
                            {
                                string[] de_split = new_de_bg.Split("2".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                                foreach (var n in de_split)
                                {
                                    bg = n;
                                }
                            }

                            else if (new_de_bg.Contains("3"))
                            {
                                string[] de_split = new_de_bg.Split("3".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                                foreach (var n in de_split)
                                {
                                    pl = n;
                                }
                            }
                        }
                    }

                    this.recordings.Add(new Recording()
                    {
                        word_de_10_s = de,
                        plural_10_s = pl,
                        word_bg_10_s = bg,
                        der_die_das_10_s = "s",
                        ReleaseDateTime = new DateTime(1748, 7, 8)
                    });
                }

            }

            catch { }

            /*
            this.recordings.Add(new Recording()
            {
                word_de_10 = "Mann",
                plural_10 = ", ⸚ er",
                word_bg_10 = "man",
                der_die_das_10 = "r",
                ReleaseDateTime = new DateTime(1748, 7, 8)
            });
            this.recordings.Add(new Recording()
            {
                word_de_10 = "Ludwig van Beethoven",
                word_bg_10 = "Third Symphony",
                der_die_das_10 = "r",
                ReleaseDateTime = new DateTime(1805, 2, 11)
            });
            this.recordings.Add(new Recording()
            {
                word_de_10 = "George Frideric Handel",
                word_bg_10 = "Serse",
                der_die_das_10 = "r",
                ReleaseDateTime = new DateTime(1737, 12, 3)
            });

    */
        }
    }
}
