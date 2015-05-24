using System.Runtime.Serialization;

namespace EpisodeRenaming {

    [DataContract]
    public class TraktTvShowSearchResult {

        [DataMember( Name = "type" )]
        public string Type { get; set; }

        [DataMember( Name = "score" )]
        public float? Score { get; set; }

        [DataMember( Name = "show" )]
        public TraktTvShow Show { get; set; }


    }
}
