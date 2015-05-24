using System.Runtime.Serialization;

namespace EpisodeRenaming {
    [DataContract]
    public class TraktTvShowImages {

        [DataMember( Name = "poster" )]
        public TraktTvShowImagesPoster Poster { get; set; }

        [DataMember( Name = "fanart" )]
        public TraktTvShowImagesFanArt FanArt { get; set; }
    }
}
