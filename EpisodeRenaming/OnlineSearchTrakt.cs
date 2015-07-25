using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace EpisodeRenaming {
    class OnlineSearchTrakt {

        private static string ClientID = "96bd1d3f62624c5603f5df37b07a2180d747ef691e5ebd635844cc76b92c5537";

        private static Uri baseAddress = new Uri( "https://api-v2launch.trakt.tv/" );
        private static Uri mockBaseAddress = new Uri( "https://private-anon-9796605bd-trakt.apiary-mock.com/" );

        public static async Task<string> getTvShowSearchResult ( string query, string type, string year = "" ) {
            string responseData = String.Empty;
            
            using ( var httpClient = new HttpClient() ) {
                httpClient.BaseAddress = baseAddress;
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation( "trakt-api-version", "2" );
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation( "trakt-api-key", ClientID );

                if ( year == "" ) {
                    using ( var response = await httpClient.GetAsync( "search?query=" + query + "&" + "type=" + type ) ) {
                        responseData = await response.Content.ReadAsStringAsync();
                    }
                } else {
                    using ( var response = await httpClient.GetAsync( "search?query=" + query + "&" + "type=" + type + "&year=" + year ) ) {
                        responseData = await response.Content.ReadAsStringAsync();
                    }
                }
            }

            return responseData;
        }

        public static async Task<string> getSeasonSearchResult ( string TVshowId ) {
            string responseData = String.Empty;

            using ( var httpClient = new HttpClient() ) {
                httpClient.BaseAddress = baseAddress;
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation( "trakt-api-version", "2" );
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation( "trakt-api-key", ClientID );

                using ( var response = await httpClient.GetAsync( "shows/" + TVshowId + "/seasons" ) ) {
                    responseData = await response.Content.ReadAsStringAsync();
                }
            }

            return responseData;
        }




    }
}
