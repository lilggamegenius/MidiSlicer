using System.Collections.Generic;
using System.Linq;

namespace MidiEditor
{
    public static class Notes
    {
        public static Dictionary<string, int> NotesValuesDict = new Dictionary<string, int>()
        {
            {"C" , 0},
            {"C#", 1 },
            {"D" , 2 },
            {"D#", 3 },
            {"E" , 4 },
            {"F" , 5 },
            {"F#", 6 },
            {"G" , 7 },
            {"G#", 8 },
            {"A" , 9 },
            {"A#", 10},
            {"B" , 11}
        };

        public static int ValueFromNote(string note)
        {
            return NotesValuesDict.FirstOrDefault(x => (x.Key == note)).Value;
        }

        public static string NoteFromValue(int value)
        {
            return NotesValuesDict.FirstOrDefault(x => (x.Value == value)).Key;
        }
    }
}
