using System.Runtime.Serialization;

namespace EpisodeRenaming {
    [DataContract]
    public class TraktTvShow {

        [DataMember( Name = "title" )]
        public string Title { get; set; }

        [DataMember( Name = "overview" )]
        public string Overview { get; set; }

        [DataMember( Name = "year" )]
        public int? Year { get; set; }

        [DataMember( Name = "images" )]
        public TraktTvShowImages Images { get; set; }

        [DataMember( Name = "ids" )]
        public TraktTvShowIDs Ids { get; set; }
    }
}
