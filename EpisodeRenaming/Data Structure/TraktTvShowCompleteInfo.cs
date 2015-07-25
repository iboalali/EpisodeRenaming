using System.Runtime.Serialization;
using System.Collections.Generic;

namespace EpisodeRenaming {
    [DataContract]
    public class TraktTvShowCompleteInfo {
        [DataMember( Name = "tvShow" )]
        public TraktTvShowSearchResult TvShow { get; set; }

        [DataMember( Name = "seasons" )]
        public List<TraktTvSeason> Seasons { get; set; }

        
    }
}
