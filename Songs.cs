namespace dw_homepage_api
{
    public class SongService
    {
        public Song[] GetSongs()
        {
            return
            [
                new(
                    "Magnolia Blues",
                    "Daniel Widegren",
                    "Session 15/07/25 - Charley Patton",
                    1,
                    "Originally by Charley Patton",
                    "150725-magnolia-blues.wav"
                ),
                new(
                    "Hammer Blues",
                    "Daniel Widegren",
                    "Session 15/07/25 - Charley Patton",
                    1,
                    "Originally by Charley Patton",
                    "150725-hammer-blues.wav"
                ),
                new(
                    "Tom Rushen Blues",
                    "Daniel Widegren",
                    "Session 15/07/25 - Charley Patton",
                    1,
                    "Originally by Charley Patton",
                    "150725-tom-rushen-blues.wav"
                ),
                new(
                    "Bird Nest Bound",
                    "Daniel Widegren",
                    "Session 15/07/25 - Charley Patton",
                    1,
                    "Originally by Charley Patton",
                    "150725-bird-nest-bound.wav"
                ),
            ];
        }
    }

    public class Song(string name, string artist, string release, int trackNumber, string information, string fileName)
    {

        public string Name { get; } = name;
        public string Artist { get; } = artist;
        public string Release { get; } = release;
        public int TrackNumber { get; } = trackNumber;
        public string Information { get; } = information;
        public string FileName { get; } = fileName;
    }
}
