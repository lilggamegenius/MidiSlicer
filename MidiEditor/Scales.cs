using System.Collections.Generic;
using System.Linq;

namespace MidiEditor
{
    public static class Scales
    {
        public static Dictionary<string, int[]> ScalesFamiliesValuesDict = new Dictionary<string, int[]>()
        {
            // 8 notes
            {"8bebop_dom",      new int[]{ 0, 2, 4, 5, 7, 9, 10, 11} },
            {"8bebop_maj",      new int[]{ 0, 2, 4, 5, 7, 8, 9,  11} },
            {"8bebop_min_melo", new int[]{ 0, 2, 3, 5, 7, 8, 9,  11} },
            {"8spanish",        new int[]{ 0, 1, 3, 4, 5, 6, 8,  10} },
            {"8dim",            new int[]{ 0, 2, 3, 5, 6, 8, 9,  11} },

            // 7 notes
            { "7major_nat",   new int[]{ 0, 2, 4, 5, 7, 9, 11 } },
            { "7minor_harm",  new int[]{ 0, 2, 3, 5, 7, 8, 11 } },
            { "7minor_melo",  new int[]{ 0, 2, 3, 5, 7, 9, 11 } },
            { "7major_harm",  new int[]{ 0, 2, 4, 5, 7, 8, 11 } },
            { "7major_2harm", new int[]{ 0, 1, 4, 5, 7, 8, 11 } },
            { "7major_neap",  new int[]{ 0, 1, 3, 5, 7, 9, 11 } },
            { "7minor_neap",  new int[]{ 0, 1, 3, 5, 7, 8, 11 } },
            { "7major_hung",  new int[]{ 0, 3, 4, 6, 7, 9, 10 } },
            { "7persian",     new int[]{ 0, 1, 4, 5, 6, 8, 11 } },
            { "7verdi_enigm", new int[]{ 0, 1, 4, 6, 8, 10,11 } },
            { "7theta_purvi", new int[]{ 0, 1, 4, 6, 7, 8, 11 } },

            // 6 notes
            { "6blues",        new int[]{ 0, 3, 5, 6, 7, 10 } },
            { "6strange",      new int[]{ 0, 2, 4, 6, 8, 10 } },
            { "6major_hexa",   new int[]{ 0, 2, 4, 5, 7, 9  } },
            { "6aug",          new int[]{ 0, 3, 4, 7, 8, 11 } },
            { "6prom",         new int[]{ 0, 2, 4, 6, 9, 10 } },
            { "6prom_nap",     new int[]{ 0, 1, 4, 6, 9, 10 } },
            { "6tritone",      new int[]{ 0, 1, 4, 6, 7, 10 } },
            { "6tritone_semi", new int[]{ 0, 1, 2, 6, 7, 8  } },
            { "6istrian",      new int[]{ 0, 1, 3, 4, 6, 7  } },

            // 5 notes
            { "5major_penta",  new int[]{ 0, 2, 4, 7, 9 } },
            { "5javanese",     new int[]{ 0, 4, 5, 7, 11} },
            { "5pelog_bem",    new int[]{ 0, 1, 6, 7, 8 } },
            { "5pelog_barang", new int[]{ 0, 2, 6, 7, 9 } },
            { "5jap_in",       new int[]{ 0, 1, 5, 7, 8 } },
            { "5jap_insen",    new int[]{ 0, 1, 5, 7, 10} },
            { "5bartok_penta", new int[]{ 0, 3, 6, 7, 10} },
            { "5phryg6_penta", new int[]{ 0, 1, 3, 7, 9 } },


            // TODO: handle scales with quarter-tones with winmm.dll / midiOutShortMsg()
            // cf. https://autohotkey.com/board/topic/17212-midi-output-from-ahk/page-3

            //// 8 notes with quarter tones
            //{ "8bastanikar",   new float[]{ 0, 1.5, 3.5, 5, 6.5, 7.5, 10.5, 11.5} },
            //{ "8dalanshin",    new float[]{ 0, 1, 2, 3.5, 5, 7, 9, 10.5} },
            //{ "8jiharkah",     new float[]{ 0, 2, 4, 5, 7, 9, 10, 10.5} },
            //{ "8kirdan",       new float[]{ 0, 2, 3, 3.5, 5, 7, 9, 10.5} },
            //{ "8mehayar",      new float[]{ 0, 1.5, 3, 5, 7, 8, 8.5, 10} },
            //{ "8tet",          new float[]{ 0, 1.5, 3, 4.5, 6, 7.5, 9, 10.5} },
            //
            //// 7 notes with quarter tones
            //{ "7hijaz",        new float[]{ 0, 1, 4, 5, 7, 8.5, 10} },
            //{ "7rast",         new float[]{ 0, 2, 3.5, 5, 7, 9, 10.5} },
            //{ "7bayati",       new float[]{ 0, 1.5, 3, 5, 7, 8, 10} },
            //{ "7hardino",      new float[]{ 0, 1.5, 4, 5, 7, 8.5, 11} },
            //{ "7mahur",        new float[]{ 0, 2, 3.5, 5, 7, 9, 11} },
            //{ "7mustaar",      new float[]{ 0, 2.5, 3.5, 5.5, 6.5, 8.5, 10.5} },
            //{ "7saba",         new float[]{ 0, 1.5, 3, 4, 7, 8, 10} },
            //{ "7sikah_baladi", new float[]{ 0, 1.5, 3.5, 5, 7, 8.5, 10.5} },

            // 5 notes with quarter tones
            //{  "5tet_approx",  new float[]{ 0, 2.5, 5, 7, 9.5 } };
        };

        public static Dictionary<string, string> ScalesValuesDict = new Dictionary<string, string>()
        {
            ////////////////////////////// 7 NOTES ////////////////////////////

            { "7major_nat,1", "Natural major / Ionian" },
            { "7major_nat,6,diff:7major_nat;1", "Natural minor / Aeolian (6th mode)" },
            { "7major_nat,2,diff:7major_nat;6", "Dorian (2nd mode)" },
            { "7major_nat,3,diff:7major_nat;6", "Phrygian (3rd mode)" },
            { "7major_nat,4,diff:7major_nat;1", "Lydian (4th mode)" },
            { "7major_nat,5,diff:7major_nat;1", "Mixolydian (5th mode)" },
            { "7major_nat,7,diff:7major_nat;6", "Locrian (7th mode)" },

            { "7minor_harm,1,diff:7major_nat;6", "Harmonic minor" },
            { "7minor_harm,2,diff:7major_nat;7", "Locrian ♮6 (2nd mode)" },
            { "7minor_harm,3,diff:7major_nat;1", "Ionian augmented / Ionian #5 (3rd mode)" },
            { "7minor_harm,4,diff:7major_nat;2", "Romanian minor / Ukrainian Dorian (4th mode)" },
            { "7minor_harm,5,diff:7major_nat;3", "Phrygian dominant / Freygish (5th mode)" },
            { "7minor_harm,6,diff:7major_nat;4", "Lydian #2 (6th mode)" },
            { "7minor_harm,7,diff:7major_nat;7", "Ultra Locrian / Altered ♭♭7 (7th mode)" },

            { "7minor_melo,1,diff:7major_nat;6", "Melodic minor" },
            { "7minor_melo,2,diff:7major_nat;2", "Dorian ♭2 / Phrygian ♮6 (2nd mode)" },
            { "7minor_melo,3,diff:7major_nat;4", "Lydian augmented / Lydian #5 (3rd mode)" },
            { "7minor_melo,4,diff:7major_nat;4", "Bartok / Lydian Dominant (4th mode)" },
            { "7minor_melo,5,diff:7major_nat;5", "Hindu / Mixolydian ♭6 (5th mode)" },
            { "7minor_melo,6,diff:7major_nat;7", "Half-diminished / Locrian ♮2 (6th mode)" },
            { "7minor_melo,7,diff:7major_nat;7", "Super Locrian / Altered (7th mode)" },

            { "7major_2harm,1,diff:7major_nat;1", "Double harmonic major / Byzantine / Gypsy" },
            { "7major_2harm,2,diff:7major_nat;4", "Lydian #2 #6 (2nd mode)" },
            { "7major_2harm,3,diff:7major_nat;3", "Ultra phrygian (3rd mode)" },
            { "7major_2harm,4,diff:7major_nat;6", "Hungarian minor (4th mode)" },
            { "7major_2harm,5", "Oriental / Asian (5th mode)" },
            { "7major_2harm,6,diff:7major_nat;1", "Ionian augmented #2 (6th mode)" },
            { "7major_2harm,7,diff:7major_nat;7", "Locrian ♭♭3 ♭♭7 (7th mode)" },

            { "7major_harm,1,diff:7major_nat;1", "Harmonic major / Ionian ♭6" },
            { "7major_harm,2,diff:7major_nat;2", "Nahawand Murassa' / Dorian ♭5 (2nd mode)" },
            { "7major_harm,3,diff:7major_nat;3", "Phrygian ♭4 (3rd mode)" },
            { "7major_harm,4,diff:7major_nat;4", "Lydian ♭3 / Melodic minor #4 (4th mode)" },
            { "7major_harm,5,diff:7major_nat;5", "Zanjaran / Mixolydian ♭2 (5th mode)" },
            { "7major_harm,6,diff:7major_nat;4", "Lydian augmented #2 (6th mode)" },
            { "7major_harm,7,diff:7major_nat;7", "Locrian ♭♭7 (7th mode)" },

            { "7major_neap,1", "Neapolitan major" },
            { "7major_neap,2", "Leading whole tone (2nd mode)" },
            { "7major_neap,4,diff:7major_nat;4", "Lydian minor (4th mode)" },
            { "7major_neap,5,diff:7major_nat;7", "Arabic / Locrian major (5th mode)" },

            { "7minor_neap,1", "Neapolitan minor" },
            { "7minor_neap,4", "Hungarian gypsy (4th mode)" },

            { "7persian,1,diff:7major_2harm;1", "Persian" },
            { "7persian,4", "Todi theta (4th mode)" },

            { "7major_hung,1", "Hungarian major" },
            { "7verdi_enigm,1", "Verdi's Enigmatica" },
            { "7theta_purvi,1,diff:7major_2harm;1", "Purvi theta / Kamavardhani" },

            ////////////////////////////// 8 NOTES ////////////////////////////
            
            { "8bebop_dom,1,diff:7major_nat;1", "Bebop dominant" },
            { "8bebop_dom,4", "Ichikosucho (4th mode)" },
            { "8bebop_dom,5,diff:7major_nat;2", "Bebop Dorian / Bebop minor (5th mode)" },

            { "8bebop_maj,1,diff:7major_nat;1", "Bebop major" },
            { "8bebop_maj,7,diff:7minor_harm;1", "Bebop harmonic minor (7th mode)" },

            { "8bebop_min_melo,1,diff:7minor_melo;1", "Bebop melodic minor" },

            { "8spanish,1", "Spanish" },

            { "8dim,1", "Diminished" },
            { "8dim,2", "Dominant diminished / Dom-dim (2nd mode)" },

            //////////////////////////////// 6 NOTES ////////////////////////////
            
            { "6blues,1,diff:5major_penta;5", "Blues / Penta. minor + blue note" },
            { "6strange,1", "Whole tone / Strange / Debussy" },

            { "6aug,1", "Augmented / Irish / Scottish" },
            { "6aug,2", "Six-tone symmetrical (2nd mode)" },

            { "6major_hexa,1", "Hexatonic major" },
            { "6prom,1", "Prometheus" },
            { "6prom_nap,1", "Prometheus neapolitan" },
            { "6tritone,1", "Tritone / Petrushka" },
            { "6tritone_semi,1", "Two-semitone tritone" },
            { "6istrian,1", "Istrian" },

            ////////////////////////////// 5 NOTES ////////////////////////////
            
            { "5major_penta,1", "Pentatonic major / Mongolian" },
            { "5major_penta,5", "Pentatonic minor / Yo (5th mode)" },
            { "5major_penta,2", "Egyptian / Suspended (2nd mode)" },
            { "5major_penta,3", "Blues minor / Man gong (3rd mode)" },
            { "5major_penta,4", "Blues major / Ritsusen (4th mode)" },

            { "5jap_in,1", "In" },
            { "5jap_in,2", "Chinese (2nd mode)" },
            { "5jap_in,3", "Hirajoshi (3rd mode)" },
            { "5jap_in,4", "Iwato (4th mode)" },

            { "5jap_insen,1", "Insen" },
            { "5jap_insen,5", "Kumoi (5th mode)" },

            { "5javanese,1", "Javanese" },
            { "5javanese,2", "Balinese (2nd mode)" },
            { "5pelog_bem,1", "Pelog Bem" },
            { "5pelog_barang,1", "Pelog Barang" },

            { "5bartok_penta,1,diff:5major_penta;5", "Pentatonic Bartok" },
            { "5phryg6_penta,1,diff:5major_penta;1", "Pentatonic Phrygian ♮6" },


            //////////////////////////// 8 NOTES ¼ TONES ////////////////////////
            //
            //{ "8jiharkah,1,diff:8bebop_dom;1", "Jiharkah" },
            //{ "8bastanikar,1,diff:8bebop_dom;1", "Bastanikar" },
            //{ "8dalanshin,1", "Dalanshin" },
            //{ "8kirdan,1", "Kirdan" },
            //{ "8mehayar,1,diff:7major_nat;6", "Mehayar / Hoseni / Rahaw" },
            //
            //////////////////////////// 7 NOTES ¼ TONES ////////////////////////
            //
            //{ "7hijaz,1,diff:7minor_harm;5", "Hijaz" },
            //{ "7hijaz,4,diff:7major_harm;1", "Suznak (4th mode)" },
            //{ "7hijaz,5,diff:7bayati;1", "Bayati Shuri (5th mode)" },
            //{ "7hijaz,6", "Huzam (6th mode)" },
            //
            //{ "7rast,1,diff:7major_nat;2", "Rast" },
            //{ "7rast,5,diff:7major_nat;6", "Nayruz / Simdi Huseyni-Ussak (5th mode)" },
            //{ "7rast,6,diff:7major_nat;3", "Ashiran / Arazbar (6th mode)" },
            //{ "7rast,7,diff:7major_nat;1", "Iraq (7th mode)" },
            //
            //{ "7bayati,1,diff:7major_nat;6", "Bayati" },
            //{ "7bayati,4,diff:7major_nat;6", "Ushaq Masri (2nd mode)" },
            //
            //{ "7hardino,1,diff:7major_nat;1", "Hardino" },
            //{ "7mahur,1,diff:7major_nat;1", "Mahur" },
            //{ "7mustaar,1", "Musta'ar" },
            //{ "7sikah_baladi,1,diff:7major_nat;1", "Sikah baladi / 7-TET (Approximation)" },
            //
            //{ "7sikah_baladi,6,diff:7major_nat;1", "Neutral" }

            ////////////////////////////// SPECIFIC ///////////////////////////

            { "negative", "Negative Harmony" },
            { "inversion", "Inversion" },
            { "random", "Random" },
        };

        public static string IdFromScaleName(string name)
        {
            return ScalesValuesDict.FirstOrDefault(x => (x.Value == name)).Key;
        }

        public static int[] GetScaleValues(string scaleId)
        {
            string[] scaleIdModeArray = scaleId.Split(',');
            if (scaleIdModeArray.Length < 2)
                return null;

            string scaleFamily = scaleIdModeArray[0];
            int mode = 0;
            bool res = int.TryParse(scaleIdModeArray[1], out mode);
            if (!res || mode == 0)
                return null;

            int[] scaleFamilyValues = ScalesFamiliesValuesDict[scaleFamily];

            return getModeNotesValues(scaleFamilyValues, mode);
        }

        // get mode notes values given scale and mode number
        private static int[] getModeNotesValues(int[] scaleValues, int mode)
        {
            int nbNotes = scaleValues.Length;
            int[] modeNotesValues = new int[nbNotes];

            for (int i = 0; i < nbNotes; i++)
            {
                int index = (i + (mode - 1)) % nbNotes;
                int noteValue = scaleValues[index];
                modeNotesValues[i] = noteValue;
            }

            int firstInterval = scaleValues[mode - 1];
            for (int i = 0; i < nbNotes; i++)
            {
                modeNotesValues[i] = (modeNotesValues[i] - firstInterval + 12) % 12;
            }

            return modeNotesValues;
        }
    }
}
