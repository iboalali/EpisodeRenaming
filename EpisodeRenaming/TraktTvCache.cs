using System;
using System.IO;

namespace EpisodeRenaming {
    public class TraktTvCache {

        public static string AppDirectory { get; private set; }
        public static string CacheDirectory { get; private set; }

        static TraktTvCache () {
            AppDirectory = AppDomain.CurrentDomain.BaseDirectory;
            CacheDirectory = Path.Combine( AppDirectory, "Cache" );

            createDirectoryIfNotExist( CacheDirectory );




        }

        public static TraktTvShowSearchResult getTvShow ( string TvShowName ) {
            // Implement

            return new TraktTvShowSearchResult();
        }

        public static void setTvShow ( TraktTvShowCompleteInfo TvShowCompleteInfo ) {
            string folderName = checkIfValidFileNameAndReplaceIt( TvShowCompleteInfo.TvShow.Show.Title );

            try {
                string path = Path.Combine( CacheDirectory, folderName );
                createDirectoryIfNotExist( path );

                File.WriteAllText( Path.Combine( path, "TvShow.json" ), TvShowCompleteInfo.TvShow.ToJSON() );
                File.WriteAllText( Path.Combine( path, "Seasons.json" ), TvShowCompleteInfo.Seasons.ToJSON() );
            } catch ( Exception ) {

                
            }






        }

        private static void createDirectoryIfNotExist ( string dir ) {
            if ( !Directory.Exists( dir ) ) {
                Directory.CreateDirectory( dir );
            }
        }

        private static string checkIfValidFileNameAndReplaceIt ( string fileName ) {
            if ( !string.IsNullOrEmpty( fileName ) &&
              fileName.IndexOfAny( Path.GetInvalidFileNameChars() ) < 0 ) {
                return fileName;
            }

            foreach ( var item in Path.GetInvalidFileNameChars() ) {
                fileName = fileName.Replace( item, ' ' );
            }

            return fileName;
        }





    }
}
