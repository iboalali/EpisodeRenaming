using System.Runtime.Serialization;

namespace EpisodeRenaming {
    [DataContract]
    public class TraktTvEpisode {

        [DataMember( Name = "season" )]
        public int? Season { get; set; }

        [DataMember( Name = "number" )]
        public int? Episode { get; set; }

        [DataMember( Name = "title" )]
        public string Title { get; set; }

        [DataMember( Name = "ids" )]
        public TraktTvEpisodeIDs Ids { get; set; }


    }
}
