namespace dw_homepage_api
{
    public class SongService
    {
        public Song[] GetSongs()
        {
            return
            [
                new(
                    "Screamin' and Hollerin' the Blues",
                    "Daniel Widegren",
                    "In Hard Luck Together",
                    1,
                    "Originally by Charley Patton",
                    "230926-screamin-blues.wav"
                ),
                new(
                    "Shame Shame Shame",
                    "Daniel Widegren",
                    "In Hard Luck Together",
                    2,
                    "Originally by Jimmy Reed",
                    "230926-shame.wav"
                ),
                new(
                    "Cherry Ball Blues",
                    "Daniel Widegren",
                    "In Hard Luck Together",
                    3,
                    "Originally by Skip James",
                    "230926-cherry-ball.wav"
                ),
                new(
                    "Magnolia Blues",
                    "Daniel Widegren",
                    "In Hard Luck Together",
                    4,
                    "Originally by Charley Patton",
                    "230926-magnolia.wav"
                ),
                new(
                    "Dry Well Blues",
                    "Daniel Widegren",
                    "In Hard Luck Together",
                    5,
                    "Originally by Charley Patton",
                    "230926-dry-well.wav"
                ),
                new(
                    "Every Night About This Time",
                    "Daniel Widegren",
                    "In Hard Luck Together",
                    6,
                    "Originally by Fats Domino",
                    "230926-every-night.wav"
                ),
                new(
                    "Tom Rushen Blues",
                    "Daniel Widegren",
                    "In Hard Luck Together",
                    7,
                    "Originally by Charley Patton",
                    "230926-tom-rushen.wav"
                ),
                new(
                    "Strawberry Wine",
                    "Daniel Widegren",
                    "In Hard Luck Together",
                    8,
                    "Originally by The Band",
                    "230926-strawberry.wav"
                ),
                // new(
                //     "Magnolia Blues",
                //     "Daniel Widegren",
                //     "Session 15/07/25 - Charley Patton",
                //     1,
                //     "Originally by Charley Patton",
                //     "150725-magnolia-blues.wav"
                // ),
                // new(
                //     "Hammer Blues",
                //     "Daniel Widegren",
                //     "Session 15/07/25 - Charley Patton",
                //     1,
                //     "Originally by Charley Patton",
                //     "150725-hammer-blues.wav"
                // ),
                // new(
                //     "Tom Rushen Blues",
                //     "Daniel Widegren",
                //     "Session 15/07/25 - Charley Patton",
                //     1,
                //     "Originally by Charley Patton",
                //     "150725-tom-rushen-blues.wav"
                // ),
                // new(
                //     "Bird Nest Bound",
                //     "Daniel Widegren",
                //     "Session 15/07/25 - Charley Patton",
                //     1,
                //     "Originally by Charley Patton",
                //     "150725-bird-nest-bound.wav"
                // ),
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
