using System.Runtime.Serialization;
using System.Collections.Generic;

namespace EpisodeRenaming {
    [DataContract]
    public class TraktTvSeason {

        [DataMember( Name = "number" )]
        public int? Season { get; set; }

        [DataMember( Name = "ids" )]
        public TraktTvSeasonIDs Ids { get; set; }

        [DataMember( Name = "episodes" )]
        public List<TraktTvEpisode> Episodes { get; set; }


    }
}
