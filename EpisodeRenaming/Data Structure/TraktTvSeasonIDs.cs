using System.Runtime.Serialization;

namespace EpisodeRenaming {
    [DataContract]
    public class TraktTvSeasonIDs {

        [DataMember( Name = "trakt" )]
        public int? Trakt { get; set; }

        [DataMember( Name = "tvdb" )]
        public int? Tvdb { get; set; }

        [DataMember( Name = "tmdb" )]
        public int? Tmdb { get; set; }

        [DataMember( Name = "tvrage" )]
        public int? TvRage { get; set; }
    }
}
