using System.Runtime.Serialization;

namespace EpisodeRenaming {
    [DataContract]
    public class TraktTvShowImagesPoster {

        [DataMember( Name = "full" )]
        public string Full { get; set; }

        [DataMember( Name = "medium" )]
        public string Medium { get; set; }

        [DataMember( Name = "thumb" )]
        public string Thumb { get; set; }

    }
}
