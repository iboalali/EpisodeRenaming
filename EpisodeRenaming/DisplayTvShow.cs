using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace EpisodeRenaming {
    public partial class DisplayTvShow : Form {
        IEnumerable<TraktTvShowSearchResult> ShowData;
        public TraktTvShowSearchResult tvShow;
        int Counter = 0;

        public DisplayTvShow ( IEnumerable<TraktTvShowSearchResult> showData ) {
            InitializeComponent();

            this.ShowData = showData;
            DisplayShowData( Counter );

        }

        private void btnClose_Click ( object sender, EventArgs e ) {
            Close();
        }

        private void btnNext_Click ( object sender, EventArgs e ) {
            Counter++;
            if ( Counter >= ShowData.Count() ) {
                Counter--;
                System.Media.SystemSounds.Asterisk.Play();

                return;
            }

            DisplayShowData( Counter );


        }

        private void DisplayShowData ( int position ) {
            lblName.Text = ShowData.ElementAt( position ).Show.Title;
            lblYear.Text = ShowData.ElementAt( position ).Show.Year != null ? ShowData.ElementAt( position ).Show.Year.ToString() : "Unknown";
            lblOverview.Text = ShowData.ElementAt( position ).Show.Overview;

            TraktTvShowIDs ids = ShowData.ElementAt( position ).Show.Ids;

            //lblTrakt.Text = ids.Trakt.ToString();
            //lblTrakt.Text = 
            //lblTrakt.Text
            //lblTrakt.Text
            //lblTrakt.Text
            //lblTrakt.Text





            lblTrakt.Text = ShowData.ElementAt( position ).Show.Ids.Trakt != null ? ShowData.ElementAt( position ).Show.Ids.Trakt.ToString() : "Not Available";
            lblSlug.Text = ShowData.ElementAt( position ).Show.Ids.Slug != "" ? ShowData.ElementAt( position ).Show.Ids.Slug.ToString() : "Not Available";
            lblTvdb.Text = ShowData.ElementAt( position ).Show.Ids.Tvdb != null ? ShowData.ElementAt( position ).Show.Ids.Tvdb.ToString() : "Not Available";
            lblImdb.Text = ShowData.ElementAt( position ).Show.Ids.Imdb != "" ? ShowData.ElementAt( position ).Show.Ids.Imdb.ToString() : "Not Available";
            lblTmdb.Text = ShowData.ElementAt( position ).Show.Ids.Tmdb != null ? ShowData.ElementAt( position ).Show.Ids.Tmdb.ToString() : "Not Available";
            lblTvRage.Text = ShowData.ElementAt( position ).Show.Ids.TvRage != null ? ShowData.ElementAt( position ).Show.Ids.TvRage.ToString() : "Not Available";

            string fileName = string.Empty;

            if ( ShowData.ElementAt( position ).Show.Ids.Imdb != "" ) {
                fileName = "imdb_" + ShowData.ElementAt( position ).Show.Ids.Imdb;
            } else if ( ShowData.ElementAt( position ).Show.Ids.Slug != ""  ) {
                fileName = "slug_" + ShowData.ElementAt( position ).Show.Ids.Slug;
            }
            //continue ...

            fileName += "_" + position;


            if ( ShowData.ElementAt( position ).Show.Images.Poster.Medium != null ) {
                using ( WebClient client = new WebClient() ) {
                    client.DownloadFile( ShowData.ElementAt( position ).Show.Images.Poster.Medium, position + "_poster_medium.jpg" );

                }

                pbShowPoster.Image = new Bitmap( position + "_poster_medium.jpg" );
                pbShowPoster.BringToFront();

            } else if ( ShowData.ElementAt( position ).Show.Images.FanArt.Medium != null ) {
                using ( WebClient client = new WebClient() ) {
                    client.DownloadFile( ShowData.ElementAt( position ).Show.Images.FanArt.Medium, position + "_fanart_medium.jpg" );

                }

                pbShowPoster.Image = new Bitmap( position + "_fanart_medium.jpg" );
                pbShowPoster.BringToFront();

            } else {
                pbShowPoster.Image = new Bitmap( 1, 1 );
                lblNoImageAvailable.BringToFront();

            }


        }

        private void btnPrevious_Click ( object sender, EventArgs e ) {
            Counter--;
            if ( Counter <= 0 ) {
                Counter++;
                System.Media.SystemSounds.Asterisk.Play();

                return;
            }
            DisplayShowData( Counter );

        }

        private void btnUse_Click ( object sender, EventArgs e ) {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            tvShow = ShowData.ElementAt( Counter );
            Close();
        }


    }
}
