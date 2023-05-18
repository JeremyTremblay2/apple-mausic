using System;
namespace AppleMAUsIc.Model
{
    public class Album : IEquatable<Album>
    {
        public string Name { get; private set; }

        public string Author { get; private set; }

        public string CoverImageName { get; private set; }

        public string KindOfMusic { get; private set; }

        public DateTime ReleaseDate { get; private set; }

        public Quality SoundQuality { get; private set; }

        public IList<Track> Tracks { get; private set; }

        public string Copyright { get; private set; }

        public int NumberOfTracks
        {
            get => Tracks.Count;
        }

        public TimeSpan TotalDuration
        {
            get => new TimeSpan(Tracks.Sum(t => t.Duration.Ticks));
        }

        public Album(string name, string author, string coverImageName, string kindOfMusic, DateTime releaseDate,
            string copyright, IList<Track> tracks, Quality soundQuality = Quality.LOSSLESS)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("The name of the album cannot be null or empty.");
            }
            if (string.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentException("The name of the author of the album cannot be null or empty.");
            }
            if (string.IsNullOrWhiteSpace(kindOfMusic))
            {
                throw new ArgumentException("The kind of music of the album cannot be null or empty.");
            }
            Name = name;
            Author = author;
            CoverImageName = coverImageName;
            KindOfMusic = kindOfMusic;
            ReleaseDate = releaseDate;
            SoundQuality = soundQuality;
            Tracks = tracks == null ? new List<Track>() : new List<Track>(tracks);
            Copyright = copyright;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (!GetType().Equals(obj.GetType())) return false;
            return Equals(obj as Album);
        }

        public bool Equals(Album other)
        {
            return other != null
                && other.Name.Equals(Name)
                && other.Author.Equals(Author);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Author);
        }

        public override string ToString() => $"{Name} - {Author} - {ReleaseDate}";
    }
}

