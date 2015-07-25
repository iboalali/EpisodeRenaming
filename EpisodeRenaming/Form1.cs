using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.Threading;
using System.IO;


//System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

namespace EpisodeRenaming {

    //Client ID: 96bd1d3f62624c5603f5df37b07a2180d747ef691e5ebd635844cc76b92c5537
    //Client Secret: 9dcce9c729701927ad177ee9179f4b2e39c3d75dcd8a3c053d9d791d46c17cd3

    public partial class Form1 : Form {


        // Offline Part

        string folderPath = string.Empty;
        string[] filesInDirectory;
        string[] filesAfterRenaming;
        EpisodeInfo[] episodesInfo;

        struct EpisodeInfo {
            public int seasonNumber;
            public int episodeNumber;

        }

        Dictionary<int, string[]> files;

        // End of Offline Part



        //string[] unnececarryWords = new string[] { "hdtv", "lol", "2hd", "x264",
        //                                            "dim", "720p", "1080p", "acc2",
        //                                            "hd", "web", "dl", "dd5",
        //                                            "264", "bs", "yfn", "acc"};

        //string[] episodeNumberFormat = new string[] { "%S(S2)%%E(E2)%", "%S(1)%%E(2)%" };



        public Form1 () {
            InitializeComponent();

            this.Icon = global::EpisodeRenaming.Properties.Resources.icon;

        }

        private void btnAnalyse_Click ( object sender, EventArgs e ) {
            if ( lblFolderPathForOnline.Text == string.Empty ) {
                return;
            }

            BackgroundWorker bwTvShowSearch = new BackgroundWorker();
            bwTvShowSearch.DoWork += bwTvShowSearch_DoWork;
            bwTvShowSearch.RunWorkerCompleted += bwTvShowSearch_RunWorkerCompleted;

            if ( txtOriginalName.Text == string.Empty ) {
                return;
            }

            string[] arg = new string[] {
                txtOriginalName.Text, 
                "show",
                //"2015"
            };

            bwTvShowSearch.RunWorkerAsync( arg );
            AnalyseFolder( txtPath.Text );
        }

        void bwTvShowSearch_DoWork ( object sender, DoWorkEventArgs e ) {
            string[] arg = ( string[] ) e.Argument;
            Task<string> task = OnlineSearchTrakt.getTvShowSearchResult( arg[0], arg[1]/*, arg[2]*/ );
            e.Result = task.Result;

        }

        void bwTvShowSearch_RunWorkerCompleted ( object sender, RunWorkerCompletedEventArgs e ) {
            string response = ( string ) e.Result;
            //label1.Text = response;
            var show = response.FromJSONArray<TraktTvShowSearchResult>();

            if ( show.Count() == 0 ) {
                System.Media.SystemSounds.Asterisk.Play();
                return;

            }

            DisplayTvShow dTVshow = new DisplayTvShow( show );
            if ( DialogResult.OK == dTVshow.ShowDialog() ) {
                TraktTvShowSearchResult tvShowResult = dTVshow.tvShow;

                BackgroundWorker bwSeasonSearch = new BackgroundWorker();
                bwSeasonSearch.DoWork += bwSeasonSearch_DoWork;
                bwSeasonSearch.RunWorkerCompleted += bwSeasonSearch_RunWorkerCompleted;
                bwSeasonSearch.RunWorkerAsync( tvShowResult );
            }

        }

        private void bwSeasonSearch_DoWork ( object sender, DoWorkEventArgs e ) {
            TraktTvShowSearchResult tvShowResult = ( TraktTvShowSearchResult ) e.Argument;
            Task<string> result = OnlineSearchTrakt.getSeasonSearchResult( tvShowResult.Show.Ids.Slug );

            object[] res = new object[]{
                result,
                tvShowResult
            };
            e.Result = res;
        }

        private void bwSeasonSearch_RunWorkerCompleted ( object sender, RunWorkerCompletedEventArgs e ) {
            TraktTvShowCompleteInfo tvShowCompleteInfo = new TraktTvShowCompleteInfo();
            object[] res =( object[] ) e.Result;

            string response = ( string ) res[0];
            TraktTvShowSearchResult tvShow = ( TraktTvShowSearchResult ) res[1];

            var seasons = response.FromJSONArray<TraktTvSeason>();

            tvShowCompleteInfo.TvShow = tvShow;
            tvShowCompleteInfo.Seasons = ( List<TraktTvSeason> ) seasons;

            TraktTvCache.setTvShow( tvShowCompleteInfo );


        }



        // Deprecated
        private void btnTraktAPI_Click ( object sender, EventArgs e ) {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += bwTvShowSearch_DoWork;
            bw.RunWorkerCompleted += bwTvShowSearch_RunWorkerCompleted;

            if ( txtOriginalName.Text == string.Empty ) {
                return;
            }

            string[] arg = new string[] {
                txtOriginalName.Text, 
                "show",
                //"2015"
            };

            bw.RunWorkerAsync( arg );

        }

        private void AnalyseFolder ( string path ) {
            if ( path == string.Empty ) {
                return;
            }

            filesInDirectory = Directory.GetFiles( path );
            filesAfterRenaming = new string[filesInDirectory.Length];
            episodesInfo = new EpisodeInfo[filesInDirectory.Length];
            files = new Dictionary<int, string[]>();
            lvAllFiles.Items.Clear();

            for ( int i = 0; i < filesInDirectory.Length; i++ ) {
                string before = filesInDirectory[i].Substring( filesInDirectory[i].LastIndexOf( '\\' ) + 1 );
                string after = AnalyseOneEpisode( filesInDirectory[i].Substring( filesInDirectory[i].LastIndexOf( '\\' ) + 1 ), out episodesInfo[i] );
                if ( after == "-1" ) {
                    return;
                }

                files.Add( i, new string[] { before, after } );

                lvAllFiles.Items.Add( new ListViewItem( new string[] { before, after } ) );

            }


        }

        private string AnalyseOneEpisode ( string fileName, out EpisodeInfo epInfo ) {
            string fileExt = fileName.Substring( fileName.LastIndexOf( '.' ) );
            string correctName = txtOriginalName.Text;

            string SeasonNumber = "S";
            string EpisodeNumber = "E";

            string regex1 = @"[sS].\d+[eE].\d+[eE].\d+";
            string regex2 = @"[sS].\d+[eE].\d+";
            string regex3 = @"[^A-Za-z _.]\d+[^A-Za-z _.]";
            string regex4 = @"\d+";

            Match match1 = Regex.Match( fileName, regex1 );
            Match match2 = Regex.Match( fileName, regex2 );
            Match match3 = Regex.Match( fileName, regex3 );
            Match match4 = Regex.Match( fileName, regex4 );

            int index = -1;
            int length = -1;
            string value = String.Empty;

            if ( match1.Success ) {
                index = match1.Index;
                length = match1.Length;
                value = match1.Value;

                SeasonNumber += value[1].ToString() + value[2].ToString();
                EpisodeNumber += value[4].ToString() + value[5].ToString();
                EpisodeNumber += "E" + value[7].ToString() + value[8].ToString();

            } else if ( match2.Success ) {
                index = match2.Index;
                length = match2.Length;
                value = match2.Value;

                SeasonNumber += value[1].ToString() + value[2].ToString();
                EpisodeNumber += value[4].ToString() + value[5].ToString();

            } else if ( match3.Success ) {
                index = match3.Index;
                length = match3.Length;
                value = match3.Value;

                if ( value.Length - 2 == 1 ) {
                    SeasonNumber += "0";
                }

                for ( int i = 0; i < value.Length - 2; i++ ) {
                    SeasonNumber += value[i].ToString();

                }

                EpisodeNumber += value[value.Length - 2].ToString() + value[value.Length - 1].ToString();

            } else if ( match4.Success ) {
                index = match4.Index;
                length = match4.Length;
                value = match4.Value;

                for ( int i = 0; i < value.Length - 2; i++ ) {
                    SeasonNumber += value[i];

                }

                EpisodeNumber += value[value.Length - 2].ToString() + value[value.Length - 1].ToString();

            } else {
                // No Match Found
                epInfo = new EpisodeInfo();
                return "Warning! Couldn't Find the Episode Number";

            }

            if ( txtOriginalName.Text == string.Empty ) {
                string showName = fileName.Substring( 0, index - 1 );
                showName = showName.Replace( ".", " " ).Replace( "_", " " ).Replace( "-", " " );
                txtOriginalName.Text = showName;
                correctName = showName;
            }

            var t = new CultureInfo( "en-US", false ).TextInfo;
            StringBuilder sb = new StringBuilder();

            correctName = removeAllSpacesAtTheEndOfAString( correctName );
            correctName = t.ToTitleCase( correctName );

            sb.Append( correctName + " " );
            sb.Append( SeasonNumber );
            sb.Append( EpisodeNumber );
            sb.Append( fileExt );

            epInfo.seasonNumber = Convert.ToInt32( SeasonNumber.Substring( 1 ) );
            epInfo.episodeNumber = Convert.ToInt32( EpisodeNumber.Substring( 1 ) );
            return sb.ToString();

        }

        private string removeAllSpacesAtTheEndOfAString ( string str ) {
            if ( Char.IsSeparator( str[str.Length - 1] ) ) {
                str = str.Remove( str.Length - 1 );

            } else {
                return str;

            }

            return removeAllSpacesAtTheEndOfAString( str );

        }

        private void btnRename_Click ( object sender, EventArgs e ) {
            for ( int i = 0; i < filesInDirectory.Length; i++ ) {
                File.Move( folderPath + "\\" + files[i][0], folderPath + "\\" + files[i][1] );

            }

            btnOfflineUndo.Enabled = true;

        }

        private void btnOfflineUndo_Click ( object sender, EventArgs e ) {

            for ( int i = 0; i < filesInDirectory.Length; i++ ) {
                File.Move( folderPath + "\\" + files[i][1], folderPath + "\\" + files[i][0] );

            }

            btnOfflineUndo.Enabled = false;

        }

        private void txtOfflineTvShowName_TextChanged ( object sender, EventArgs e ) {
            AnalyseFolder( folderPath );

        }

        private bool checkIfValidFileName ( string fileName ) {
            return !string.IsNullOrEmpty( fileName ) &&
              fileName.IndexOfAny( Path.GetInvalidFileNameChars() ) < 0;

        }

        private void txtOfflineTvShowName_KeyPress ( object sender, KeyPressEventArgs e ) {
            foreach ( char c in Path.GetInvalidFileNameChars() ) {
                if ( c == e.KeyChar && !char.IsControl( e.KeyChar ) ) {
                    e.Handled = true;
                    System.Media.SystemSounds.Asterisk.Play();
                    break;
                }
            }

        }

        private void btnOpenFolder_Click ( object sender, EventArgs e ) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.ShowNewFolderButton = false;


            if ( fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK ) {
                folderPathForOnline = fbd.SelectedPath;
                txtPath.Text = folderPathForOnline;

                AnalyseFolder( fbd.SelectedPath );

            }

        }










        public string folderPathForOnline { get; set; }
    }
}
