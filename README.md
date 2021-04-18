# MidiEditor

Edit MIDI files to other scales, modes and harmonies to obtain new sonorities (more than 70 scales / modes included). Follow only these few steps:
 * Open a MIDI file,
 * Choose the original tonic and scale (for instance C Major),
 * Choose the new destination tonic and scale (for instance C Natural Minor),
 * Click on _Save as_ to export the new MIDI file or  _Save all_ to export to multiple MIDI files with all scales with corresponding number of notes,
 * Listen to what happens...

_Inversion_ scale depends on note's octave, therefore it is recommended to invert given the suitable reference octave note.

Works with GUI and command line:
```
MIDIEditor <file.mid> --src-tonic <noteSrc> --src-scale <scaleIdSrc>
                      --dst-tonic <noteDst> --dst-scale <scaleIdDst>
```

Command line options:
 * *--src-tonic \<noteSrc\>* : Sets the original tonic to specified note,
 * *--src-scale \<scaleIdSrc\>* : Sets the original tonic to specified scale,
 * *--dst-tonic \<noteDst\>* : Sets the destination tonic to specified note,
 * *--dst-scale \<scaleIdDst\>* : Sets the destination tonic to specified scale and save new file (with automatic naming).

_\<noteSrc\> and \<noteDst\> are designated by international notation: A, A#, B, C, C#, D..._
_\<scaleIdSrc\> and \<scaleIdDst\> are designated by scales identifiers, listed in attached MidiEditor/Scales.txt file._

If _\<scaleIdDst\>_ is set to **all**, the file will be exported to multiple files with all scales with corresponding number of notes.

Example usage:
```
MidiEditor.exe "..\samples\Bach - Prelude in C Major.mid" --src-tonic C --src-scale 7major_nat,1
                                                          --dst-tonic C --dst-scale all
```


Have fun!


# MidiSlicer and Midi library

Midi is a small library providing a full featured, easy to use managed wrapper over Microsoft Windows' MIDI API, as well as providing for reading, writing and manipulating MIDI files and in-memory MIDI sequences. It is smaller than other libraries like Wet Dry MIDI and lower level in many ways.

I do some MIDI sequencing and recording and I found it helpful to be able to splice sections out of a MIDI file, but I didn't have a tool that made it easy to do. In the process of creating such a tool, I made a Midi assembly that contained the core MIDI file manipulation options. I also wrote some remedial playback code at first, which used the 32-bit Windows MIDI API.

That library grew as I added more features and shored up what I had. I added some more demos, streaming support, MIDI input support, device enumeration and more. Eventually, I had wrapped maybe 90-95% of the API, and had a battery of MIDI manipulation functions for searching and modifying in memory sequences and files.

In the process, MidiSlicer moved from a first class application to just another demo project, so the solution is still named MidiSlicer - I'm stuck with the GitHub of that name. The core library project is named Midi.

I wrote a [comprehensive article at codeproject](https://www.codeproject.com/Articles/5272315/Midi-A-Windows-MIDI-Library-in-Csharp) on using this library, and I recommend using it. The latest version of the code is always here at GitHub.
