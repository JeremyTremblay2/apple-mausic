using System;
namespace AppleMAUsIc.Model
{
    public class Stub
    {

        public IList<Album> LoadAlbums()
        {
            List<Album> albums = new List<Album>();
            albums.AddRange(
                new List<Album>
                {
                    new Album(
                        "Different World",
                        "Alan Walker",
                        "different_world.png",
                        "Electro House",
                        new DateTime(2018, 12, 14),
                        "℗ 2018 Alan Walker",
                        new List<Track>
                        {
                            new Track("Intro", new TimeSpan(0, 1, 16)),
                            new Track("Lost Control", new TimeSpan(0, 3, 42)),
                            new Track("I Don't Wanna Go", new TimeSpan(0, 2, 41)),
                            new Track("Lilly", new TimeSpan(0, 3, 15)),
                            new Track("Lonely", new TimeSpan(0, 3, 36)),
                            new Track("Do It All For You", new TimeSpan(0, 2, 54)),
                            new Track("Different World", new TimeSpan(0, 3, 22)),
                            new Track("Interlude", new TimeSpan(0, 1, 19)),
                            new Track("Sing Me To Sleep", new TimeSpan(0, 3, 07), true),
                            new Track("All Falls Down", new TimeSpan(0, 3, 18)),
                            new Track("Darside", new TimeSpan(0, 3, 31)),
                            new Track("Alone", new TimeSpan(0, 2, 40)),
                            new Track("Diamond Heart", new TimeSpan(0, 4, 00)),
                            new Track("Faded (interlude)", new TimeSpan(0, 0, 41)),
                            new Track("Faded", new TimeSpan(0, 3, 32), true),
                        },
                        Quality.LOSSLESS_HIGH_QUALITY
                    ),
                    new Album(
                        "Ensemble",
                        "Kendji Girac",
                        "ensemble.png",
                        "Pop",
                        new DateTime(2015, 10, 30),
                        "℗ 2015 Kendji Girac",
                        new List<Track>
                        {
                            new Track("Tu Y Yo", new TimeSpan(0, 3, 42), true),
                            new Track("Me Quemo", new TimeSpan(0, 3, 15), true),
                            new Track("No me mires más (avec Soprano)", new TimeSpan(0, 4, 10), true),
                            new Track("C'est trop", new TimeSpan(0, 2, 42)),
                            new Track("Les yeux de la mama", new TimeSpan(0, 3, 22), true),
                            new Track("Jamais trop tard", new TimeSpan(0, 3, 41)),
                            new Track("Besame", new TimeSpan(0, 3, 26)),
                            new Track("Una mujer", new TimeSpan(0, 3, 39)),
                            new Track("La morale", new TimeSpan(0, 3, 08)),
                            new Track("Mes potes et moi", new TimeSpan(0, 2, 44)),
                            new Track("Où va le monde ?", new TimeSpan(0, 5, 20)),
                            new Track("Ma solitude", new TimeSpan(0, 3, 07)),
                            new Track("Amor y libertad", new TimeSpan(0, 3, 40))
                        },
                        Quality.LOSSLESS_HIGH_QUALITY
                    ),
                    new Album(
                        "Everest",
                        "Soprano",
                        "everest.png",
                        "Rap",
                        new DateTime(2016, 10, 14),
                        "℗ 2016 Rec. 118 / Warner Music France",
                        new List<Track>
                        {
                            new Track("Everest (Intro)", new TimeSpan(0, 3, 02), true),
                            new Track("Mon Everest (featuring Marina Kaye)", new TimeSpan(0, 4, 28)),
                            new Track("En feu", new TimeSpan(0, 3, 22), true),
                            new Track("Le diable ne s'habille plus en Prada", new TimeSpan(0, 4, 18), true),
                            new Track("Cœurdonnier", new TimeSpan(0, 3, 47), true),
                            new Track("Rihanna (featuring Alonzo)", new TimeSpan(0, 3, 59)),
                            new Track("Roule", new TimeSpan(0, 3, 58), true),
                            new Track("Mes Kwell (featuring Zak & Diego)", new TimeSpan(0, 4, 57)),
                            new Track("Parle-moi", new TimeSpan(0, 4, 24)),
                            new Track("Attitude (featuring Black M)", new TimeSpan(0, 3, 52)),
                            new Track("Post Scriptum", new TimeSpan(0, 4, 07)),
                            new Track("Marseille c'est… (featuring Jul)", new TimeSpan(0, 4, 31)),
                            new Track("Mon public", new TimeSpan(0, 3, 18)),
                            new Track("Mon précieux", new TimeSpan(0, 4, 10), true),
                            new Track("Demain c'est maintenant", new TimeSpan(0, 2, 58)),
                            new Track("Marc Landers", new TimeSpan(0, 3, 33)),
                            new Track("Amour siamois (featuring Lili Poe)", new TimeSpan(0, 3, 53), true),
                            new Track("Prélude du phœnix", new TimeSpan(0, 2, 42))
                        },
                        Quality.LOSSLESS_HIGH_QUALITY
                    ),
                    new Album(
                        "La Fête est Finie",
                        "Orelsan",
                        "la_fete_est_finie.png",
                        "Rap",
                        new DateTime(2017, 10, 20),
                        "℗ 2017 7th Magnitude / Wagram Music",
                        new List<Track>
                        {
                            new Track("San", new TimeSpan(0, 4, 02)),
                            new Track("La fête est finie", new TimeSpan(0, 3, 03), true),
                            new Track("Basique", new TimeSpan(0, 2, 43), true),
                            new Track("Tout va bien", new TimeSpan(0, 2, 29), true),
                            new Track("Défaite de famille", new TimeSpan(0, 3, 43), true),
                            new Track("La Lumière", new TimeSpan(0, 3, 13)),
                            new Track("Bonne meuf", new TimeSpan(0, 2, 03)),
                            new Track("Quand est-ce que ça s'arrête ?", new TimeSpan(0, 2, 57)),
                            new Track("Christophe (feat. Maître Gims)", new TimeSpan(0, 2, 46), true),
                            new Track("Zone (feat. Nekfeu & Dizzee Rascal)", new TimeSpan(0, 4, 46)),
                            new Track("Dans ma ville, on traîne", new TimeSpan(0, 4, 00)),
                            new Track("La Pluie (feat. Stromae)", new TimeSpan(0, 2, 55), true),
                            new Track("Paradis", new TimeSpan(0, 3, 49), true),
                            new Track("Notes pour trop tard (feat. Ibeyi)", new TimeSpan(0, 7, 34))
                        },
                        Quality.LOSSLESS_HIGH_QUALITY
                    ),
                    new Album(
                        "Mini World",
                        "Indila",
                        "mini_world.png",
                        "Pop",
                        new DateTime(2014, 2, 24),
                        "℗ 2014 Capitol Music France",
                        new List<Track>
                        {
                            new Track("Dernière danse", new TimeSpan(0, 3, 34), true),
                            new Track("Tourner dans le vide", new TimeSpan(0, 4, 06), true),
                            new Track("Love Story", new TimeSpan(0, 5, 17), true),
                            new Track("S.O.S", new TimeSpan(0, 4, 32), true),
                            new Track("Comme un bateau", new TimeSpan(0, 4, 57)),
                            new Track("Run Run", new TimeSpan(0, 3, 45), true),
                            new Track("Ego", new TimeSpan(0, 4, 16)),
                            new Track("Boîte en argent", new TimeSpan(0, 4, 27)),
                            new Track("Tu ne m'entends pas", new TimeSpan(0, 3, 19)),
                            new Track("Mini World", new TimeSpan(0, 5, 10))
                        },
                        Quality.LOSSLESS_HIGH_QUALITY
                    ),
                    new Album(
                        "Multitude",
                        "Stromae",
                        "multitude.png",
                        "Pop",
                        new DateTime(2022, 3, 4),
                        "℗ 2022 Mosaert",
                        new List<Track>
                        {
                            new Track("Invaincu", new TimeSpan(0, 2, 05)),
                            new Track("Santé", new TimeSpan(0, 3, 10), true),
                            new Track("La Solassitude", new TimeSpan(0, 3, 15), true),
                            new Track("Fils de joie", new TimeSpan(0, 3, 15), true),
                            new Track("L'Enfer", new TimeSpan(0, 3, 10), true),
                            new Track("C'est que du bonheur", new TimeSpan(0, 2, 42)),
                            new Track("Pas vraiment", new TimeSpan(0, 2, 42)),
                            new Track("Riez", new TimeSpan(0, 3, 21)),
                            new Track("Mon Amour", new TimeSpan(0, 2, 52), true),
                            new Track("Déclaration", new TimeSpan(0, 3, 04)),
                            new Track("Mauvaise journée", new TimeSpan(0, 3, 07)),
                            new Track("Bonne journée", new TimeSpan(0, 3, 12))
                        },
                        Quality.LOSSLESS_HIGH_QUALITY
                    ),
                    new Album(
                        "Native",
                        "OneRepublic",
                        "native.png",
                        "Pop",
                        new DateTime(2013, 3, 22),
                        "℗ 2013 Mosley Music/Interscope Records",
                        new List<Track>
                        {
                            new Track("Counting Stars", new TimeSpan(0, 4, 17), true),
                            new Track("If I Lose Myself", new TimeSpan(0, 4, 01), true),
                            new Track("Feel Again", new TimeSpan(0, 3, 05), true),
                            new Track("What You Wanted", new TimeSpan(0, 4, 01)),
                            new Track("I Lived", new TimeSpan(0, 3, 55), true),
                            new Track("Light It Up", new TimeSpan(0, 4, 10)),
                            new Track("Can't Stop", new TimeSpan(0, 4, 09)),
                            new Track("Au Revoir", new TimeSpan(0, 4, 50)),
                            new Track("Burning Bridges", new TimeSpan(0, 4, 17)),
                            new Track("Something I Need", new TimeSpan(0, 4, 01), true),
                            new Track("Preacher", new TimeSpan(0, 4, 08)),
                            new Track("Don't Look Down", new TimeSpan(0, 3, 53))
                        },
                        Quality.LOSSLESS_HIGH_QUALITY
                    ),
                    new Album(
                        "Night Visions",
                        "Imagine Dragons",
                        "night_visions.png",
                        "Indie rock",
                        new DateTime(2012, 9, 4),
                        "℗ 2012 Interscope Records",
                        new List<Track>
                        {
                            new Track("Radioactive (provient de l'EP Continued Silence)", new TimeSpan(0, 3, 06), true),
                            new Track("Tiptoe", new TimeSpan(0, 3, 14)),
                            new Track("It's Time (from It's Time EP)", new TimeSpan(0, 4, 00), true),
                            new Track("Demons (provient de l'EP Continued Silence)", new TimeSpan(0, 2, 57), true),
                            new Track("On Top of the World (provient de l'EP Continued Silence)", new TimeSpan(0, 3, 12), true),
                            new Track("Amsterdam (provient de l'EP It's Time)", new TimeSpan(0, 4, 01)),
                            new Track("Hear Me (provient de l'EP Hell and Silence)", new TimeSpan(0, 3, 55), true),
                            new Track("Every Night", new TimeSpan(0, 3, 37)),
                            new Track("Bleeding Out", new TimeSpan(0, 3, 43)),
                            new Track("Underdog", new TimeSpan(0, 3, 29))
                        },
                        Quality.LOSSLESS_HIGH_QUALITY
                    ),
                    new Album(
                        "Paradize",
                        "Indochine",
                        "paradize.png",
                        "Rock",
                        new DateTime(2002, 3, 14),
                        "℗ 2002 Sony Music Entertainment (France) S.A.",
                        new List<Track>
                        {
                            new Track("Paradize", new TimeSpan(0, 4, 49), true),
                            new Track("Electrastar", new TimeSpan(0, 5, 30)),
                            new Track("Punker", new TimeSpan(0, 2, 50), true),
                            new Track("Mao Boy!", new TimeSpan(0, 5, 42)),
                            new Track("J'ai demandé à la lune", new TimeSpan(0, 3, 29), true),
                            new Track("Dunkerque", new TimeSpan(0, 5, 48)),
                            new Track("Like a Monster", new TimeSpan(0, 3, 56)),
                            new Track("Le Grand Secret (avec Melissa Auf der Maur)", new TimeSpan(0, 5, 50), true),
                            new Track("La Nuit des fées", new TimeSpan(0, 4, 58)),
                            new Track("Marilyn", new TimeSpan(0, 5, 55), true),
                            new Track("Le Manoir", new TimeSpan(0, 5, 05)),
                            new Track("Popstitute", new TimeSpan(0, 4, 00)),
                            new Track("Dark", new TimeSpan(0, 4, 37)),
                            new Track("Comateen I", new TimeSpan(0, 6, 07)),
                            new Track("Un singe en hiver", new TimeSpan(0, 3, 46), true)
                        },
                        Quality.LOSSLESS_HIGH_QUALITY
                    ),
                    new Album(
                        "Recovery",
                        "Eminem",
                        "recovery.png",
                        "Hip Hop",
                        new DateTime(2010, 6, 18),
                        "℗ 2010 Aftermath Records",
                        new List<Track>
                        {
                            new Track("Cold Wind Blows", new TimeSpan(0, 5, 03)),
                            new Track("Talkin' 2 Myself (featuring Kobe)", new TimeSpan(0, 5, 00)),
                            new Track("On Fire", new TimeSpan(0, 3, 33)),
                            new Track("Won't Back Down (featuring Pink)", new TimeSpan(0, 4, 25)),
                            new Track("W.T.P.", new TimeSpan(0, 3, 58)),
                            new Track("Going Through Changes", new TimeSpan(0, 4, 58)),
                            new Track("Not Afraid", new TimeSpan(0, 4, 08), true),
                            new Track("Seduction", new TimeSpan(0, 4, 35)),
                            new Track("No Love (featuring Lil Wayne)", new TimeSpan(0, 4, 59), true),
                            new Track("Space Bound", new TimeSpan(0, 4, 38), true),
                            new Track("Cinderella Man", new TimeSpan(0, 4, 39)),
                            new Track("25 to Life", new TimeSpan(0, 4, 01)),
                            new Track("So Bad", new TimeSpan(0, 5, 25)),
                            new Track("Almost Famous", new TimeSpan(0, 4, 52)),
                            new Track("Love the Way You Lie (featuring Rihanna)", new TimeSpan(0, 4, 23), true),
                            new Track("You're Never Over", new TimeSpan(0, 5, 05)),
                            new Track("Untitled (morceau caché)", new TimeSpan(0, 3, 14))
                        },
                        Quality.LOSSLESS_HIGH_QUALITY
                    ),
                    new Album(
                        "Speak No Evil",
                        "Wayne Shorter",
                        "speak_no_evil.png",
                        "Jazz",
                        new DateTime(1966, 12, 24),
                        "℗ 1966 Blue Note Records",
                        new List<Track>
                        {
                            new Track("Witch Hunt", new TimeSpan(0, 8, 07)),
                            new Track("Fee-Fi-Fo-Fum", new TimeSpan(0, 5, 50)),
                            new Track("Dance Cadaverous", new TimeSpan(0, 6, 45)),
                            new Track("Speak No Evil", new TimeSpan(0, 8, 23), true),
                            new Track("Infant Eyes", new TimeSpan(0, 6, 51)),
                            new Track("Wild Flower", new TimeSpan(0, 6, 00)),
                            new Track("Dance Cadaverous (Prise alternative, bonus)", new TimeSpan(0, 6, 35))
                        },
                        Quality.LOSSLESS
                    ),
                }
            );
            return albums;
        }
    }
}

