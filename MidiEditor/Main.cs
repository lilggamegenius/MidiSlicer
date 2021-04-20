using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using M;
namespace MidiEditor
{
    public partial class Main : Form
    {
        MidiStream _play;
        MidiFile _file;
        MidiFile _processedFile;
        string _tracksLabelFormat;
        bool _dirty;
        bool _reseekDirty;
        bool _isPlaying;

        // notes transfomation
        Label[] labelNotes_;
        //Label[] labelNotesFrequency_;
        ProgressBar[] progressbarNotesFrequency_;
        ComboBox[] comboboxesNotesTransform_;
        int nbNotesInScaleTo_;

		public Main(string[] args = null)
		{
			InitializeComponent();

            var devs = MidiDevice.Outputs;
			OutputComboBox.DisplayMember = "Name";
			foreach (var dev in devs)
				OutputComboBox.Items.Add(dev);
			OutputComboBox.SelectedIndex = 0;
			_tracksLabelFormat = TracksLabel.Text;
			UnitsCombo.SelectedIndex = 0;
			StartCombo.SelectedIndex = 0;
			_processedFile = null;
			_dirty = true;
			_reseekDirty = true;
            _isPlaying = false;

            _UpdateMidiFile();

            labelNotes_ = new Label[12];
            //labelNotesFrequency_ = new Label[12];
            comboboxesNotesTransform_ = new ComboBox[12];
            progressbarNotesFrequency_ = new ProgressBar[12];
            foreach (var control in panelNotes.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox cmb = control as ComboBox;
                    string valueStr = cmb.Name.Replace("comboboxNote", "");
                    int value = -1;
                    bool res = Int32.TryParse(valueStr, out value);
                    if (res && value >= 0)
                        comboboxesNotesTransform_[value] = cmb;
                }
                else if (control is Label)
                {
                    Label label = control as Label;
                    string name = label.Name;
                    if (name.StartsWith("labelNote"))
                    {
                        string valueStr = name.Replace("labelNote", "");
                        int value = -1;
                        bool res = Int32.TryParse(valueStr, out value);
                        if (res && value >= 0)
                            labelNotes_[value] = label;
                    }
                    //else if (name.StartsWith("labelFreq"))
                    //{
                    //    string valueStr = name.Replace("labelFreq", "");
                    //    int value = -1;
                    //    bool res = Int32.TryParse(valueStr, out value);
                    //    if (res && value >= 0)
                    //        labelNotesFrequency_[value] = label;
                    //}
                }
                else if (control is ProgressBar)
                {
                    ProgressBar bar = control as ProgressBar;
                    string valueStr = bar.Name.Replace("progressbarFreq", "");
                    int value = -1;
                    bool res = Int32.TryParse(valueStr, out value);
                    if (res && value >= 0)
                        progressbarNotesFrequency_[value] = bar;
                }
            }

            foreach (KeyValuePair<string, int> noteValue in Notes.NotesValuesDict)
            {
                ComboBox cmb = comboboxesNotesTransform_[noteValue.Value];
                if (cmb == null)
                    continue;

                // init items
                foreach (KeyValuePair<string, int> noteValueItem in Notes.NotesValuesDict)
                    cmb.Items.Add(noteValueItem.Key);

                // set corresponding note as default
                //cmb.SelectedIndex = noteValue.Value;

                comboboxTonicFrom.Items.Add(noteValue.Key);
                comboboxTonicTo.Items.Add(noteValue.Key);

                comboboxInvNoteRef.Items.Add(noteValue.Key);
            }

            foreach (KeyValuePair<string, string> scale in Scales.ScalesValuesDict)
            {
                string scaleId = Scales.IdFromScaleName(scale.Value);
                if (scaleId == "negative" || scaleId == "inversion" || scaleId == "random") // specific
                    continue;

                comboboxScaleFrom.Items.Add(scale.Value);
            }

            initComboboxScaleTo();

            for (int i = 0; i <= 10; i++)
                comboboxInvNoteRefOctave.Items.Add(i);

            nbNotesInScaleTo_ = 0;

            // parse arguments if existing
            parseCommandLineArguments(args);
        }

        private void parseCommandLineArguments(string[] args = null)
        {
            if (args == null || args.Length == 0)
                return;

            // 1st argument: file to open
            string filepath = args[0];
            if (!File.Exists(filepath))
            {
                MessageBox.Show($"File \"{filepath}\" not found.");
                return;
            }

            loadFile(filepath);
            if (args.Length == 1)
                return;

            // get commands from arguments
            Dictionary<string, string> commands = new Dictionary<string, string>();
            for (int i = 1; i < args.Length; i++)
            {
                string command = args[i];
                if (!command.StartsWith("--"))
                    continue;
                command = command.TrimStart('-');

                // get next argument
                if (i + 1 < args.Length)
                {
                    string value = args[i + 1];
                    if (value.StartsWith("--")) // not a value
                        continue;

                    commands.Add(command, value);
                }
            }

            // execute commands

            if (commands.ContainsKey("src-tonic"))
            {
                // select source tonic
                string tonic = commands["src-tonic"];
                int tonicValue = Notes.ValueFromNote(tonic);
                if (0 <= tonicValue && tonicValue <= 12)
                    for (int i = 0; i < comboboxTonicFrom.Items.Count; i++)
                    {
                        string note = comboboxTonicFrom.Items[i].ToString();
                        int noteValue = Notes.ValueFromNote(note);

                        // select both tonics
                        if (noteValue == tonicValue)
                        {
                            comboboxTonicFrom.SelectedIndex = i;
                            comboboxTonicTo.SelectedIndex = i;
                            comboboxInvNoteRef.SelectedIndex = i;
                        }
                    }

            }

            if (commands.ContainsKey("src-scale"))
            {
                // select source scale
                string scale = commands["src-scale"];
                for (int i = 0; i < comboboxScaleFrom.Items.Count; i++)
                {
                    string scaleName = comboboxScaleFrom.Items[i].ToString();
                    string scaleId = Scales.IdFromScaleName(scaleName);

                    if (scaleId.StartsWith(scale))
                        comboboxScaleFrom.SelectedIndex = i;
                }
            }

            if (commands.ContainsKey("dst-tonic"))
            {
                // select source tonic
                string tonic = commands["dst-tonic"];
                int tonicValue = Notes.ValueFromNote(tonic);
                if (0 <= tonicValue && tonicValue <= 12)
                    for (int i = 0; i < comboboxTonicTo.Items.Count; i++)
                    {
                        string note = comboboxTonicTo.Items[i].ToString();
                        int noteValue = Notes.ValueFromNote(note);

                        if (noteValue == tonicValue)
                            comboboxTonicTo.SelectedIndex = i;
                    }
            }

            if (commands.ContainsKey("dst-scale"))
            {
                // select source scale
                string scale = commands["dst-scale"];
                if (comboboxScaleTo.Enabled)
                    for (int i = 0; i < comboboxScaleTo.Items.Count; i++)
                    {
                        string scaleName = comboboxScaleTo.Items[i].ToString();
                        string scaleId = Scales.IdFromScaleName(scaleName);

                        if (scaleId.StartsWith(scale) || scale.ToLower() == "all")
                        {
                            comboboxScaleTo.SelectedIndex = i;

                            // save to file
                            SaveMidiFile.FileName = getSaveFilePath(true /* include directory */);
                            saveFile(SaveMidiFile.FileName);
                        }
                    }

                this.Close();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
		{
			var res = OpenMidiFile.ShowDialog(this);
			if (DialogResult.OK == res)
			{
                loadFile(OpenMidiFile.FileName);
			}
		}

        private void loadFile(string filepath)
        {
            MidiFileBox.Text = filepath;
            _UpdateMidiFile();

            _isPlaying = false;
        }

		void _UpdateMidiFile()
		{
			var exists = false;
			try
			{
				if (File.Exists(MidiFileBox.Text))
					exists = true;
			}
			catch { }
			TrackList.Items.Clear();
			if (!exists)
			{
				TracksLabel.Text = "";
				MidiFileBox.ForeColor = Color.Red;
				_file = null;
				TrackList.Enabled = false;
				buttonPreview.Enabled = false;
				UnitsCombo.Enabled = false;
				StartCombo.Enabled = false;
				OffsetUpDown.Enabled = false;
				LengthUpDown.Enabled = false;
				StretchUpDown.Enabled = false;
				MergeTracksCheckBox.Enabled = false;
				CopyTimingPatchCheckBox.Enabled = false;
				AdjustTempoCheckBox.Enabled = false;
				ResampleUpDown.Enabled = false;
				NormalizeCheckBox.Enabled = false;
				LevelsUpDown.Enabled = false;
				TransposeUpDown.Enabled = false;
				WrapCheckBox.Enabled = false;
				DrumsCheckBox.Enabled = false;
				buttonSaveAs.Enabled = false;
                buttonSaveAll.Enabled = false;
                TempoUpDown.Enabled = false;

                comboboxTonicFrom.SelectedItem = -1;
                comboboxTonicFrom.Enabled = false;
                comboboxScaleFrom.SelectedIndex = -1;
                comboboxScaleFrom.Enabled = false;

                comboboxTonicTo.SelectedItem = -1;
                comboboxTonicTo.Enabled = false;
                comboboxScaleTo.SelectedIndex = -1;
                comboboxScaleTo.Enabled = false;

                Visualizer.Sequence = null;
				Visualizer.Size = VisualizerPanel.Size;

                resetTranformation();
            }
			else
			{
				MidiFileBox.ForeColor = SystemColors.WindowText;
				using (Stream stm = File.OpenRead(MidiFileBox.Text))
                    _file = M.MidiFile.ReadFrom(stm);
				var i = 0;
				foreach (var trk in _file.Tracks)
				{
					var s = trk.Name;
					if (string.IsNullOrEmpty(s))
						s = "Track #" + i.ToString();
					TrackList.Items.Add(s, true);
					++i;
				}
				var sig = _file.TimeSignature;
				var key = _file.KeySignature;

                TracksLabel.Text = string.Format(_tracksLabelFormat, sig.Numerator, sig.Denominator/*, key*/);
				TrackList.Enabled = true;
				buttonPreview.Enabled = true;
				UnitsCombo.Enabled = true;
				StartCombo.Enabled = true;
				OffsetUpDown.Enabled = true;
				LengthUpDown.Enabled = true;
				StretchUpDown.Enabled = true;
				MergeTracksCheckBox.Enabled = true;
				CopyTimingPatchCheckBox.Enabled = true;
				AdjustTempoCheckBox.Enabled = true;
				ResampleUpDown.Enabled = true;
				NormalizeCheckBox.Enabled = true;
				LevelsUpDown.Enabled = true;
				TransposeUpDown.Enabled = true;
				WrapCheckBox.Enabled = true;
				DrumsCheckBox.Enabled = true;
				buttonSaveAs.Enabled = true;
                TempoUpDown.Enabled = true;

                comboboxTonicFrom.Enabled = true;
                comboboxScaleFrom.Enabled = true;
                comboboxTonicTo.Enabled = true;
                comboboxScaleTo.Enabled = true;
                resetTransformNotes();

                StretchUpDown.Value = 1;
				UnitsCombo.SelectedIndex = 0;
				StartCombo.SelectedIndex = 0;
				ResampleUpDown.Value = _file.TimeBase;
				UnitsCombo.SelectedIndex = 0;
				LengthUpDown.Maximum = _file.Length / (decimal)_file.TimeBase;
				OffsetUpDown.Maximum = LengthUpDown.Maximum - 1;
				LengthUpDown.Value = LengthUpDown.Maximum;
				OffsetUpDown.Value = 0;
				AdjustTempoCheckBox.Checked = false;
				MergeTracksCheckBox.Checked = false;
				NormalizeCheckBox.Checked = false;
				CopyTimingPatchCheckBox.Checked = true;
				LevelsUpDown.Value = 1;
				TransposeUpDown.Value = 0;
				WrapCheckBox.Checked = false;
				DrumsCheckBox.Checked = false;
				TempoUpDown.Value = (decimal)_file.Tempo;
				_dirty = true;
				_processedFile = null;
				Visualizer.Sequence = MidiSequence.Merge(_file.Tracks);
				Visualizer.Width = Math.Max(VisualizerPanel.Width,Visualizer.Sequence.Length/4);

                resetTranformation();
                updateNotesFrequency();

                comboboxInvNoteRefOctave.SelectedIndex = 4; // default
			}

            nbNotesInScaleTo_ = 0;
            buttonResetTransform.Enabled = false;
        }

		private void MidiFileBox_Leave(object sender, EventArgs e)
		{
			_UpdateMidiFile();
		}

		private void PreviewButton_Click(object sender, EventArgs e)
		{
			if("Stop ◼" == buttonPreview.Text)
			{
				if (null != _play)
				{
					_play.Close();
				}
				MidiFileBox.Enabled = true;
				buttonLoad.Enabled = true;
				OutputComboBox.Enabled = true;
				buttonPreview.Text = "Preview ♪";
                _isPlaying = false;

                return;
			}
			
			if (null != _play)
			{
				_play.Close();
			}
			MidiFileBox.Enabled = false;
			buttonLoad.Enabled = false;
			OutputComboBox.Enabled = false;
			buttonPreview.Text = "Stop ◼";
			if(_dirty)
				_processedFile=_ProcessFile();
			var mf = _processedFile;
			
			_play = (OutputComboBox.SelectedItem as MidiOutputDevice).Stream;
			var stm = _play;
			// we use 100 events, which should be safe and allow
			// for some measure of SYSEX messages in the stream
			// without bypassing the 64kb limit
			const int MAX_EVENT_COUNT = 100;
			const int RATE_TICKS = 500;
			// our current cursor pos
			var pos = 0;
			// for tracking deltas
			var ofs = 0;
			// for tracking the song position
			var songPos = 0;
			// merge our file for playback
			var seq = MidiSequence.Merge(mf.Tracks);
			var events = seq.Events;
			// the number of events in the seq
			var len = events.Count;
			// stores the next set of events
			var eventList = new List<MidiEvent>(MAX_EVENT_COUNT);
			
			// open the stream
			stm.Open();
			// start it
			stm.Start();

            _isPlaying = true;

            // first set the timebase
            stm.TimeBase = mf.TimeBase;
			// set up our send complete handler
			stm.SendComplete += delegate (object s, EventArgs ea)
			{
				try
				{
					BeginInvoke(new Action(delegate ()
					{
						// clear the list	
						eventList.Clear();
						mf = _processedFile;
						if (_dirty)
						{
							if (_reseekDirty)
							{
								var time = _processedFile.Tracks[0].GetContext(songPos, _processedFile.TimeBase).Time;
								_processedFile = _ProcessFile();
								songPos = _processedFile.Tracks[0].GetPositionAtTime(time, _processedFile.TimeBase);
								mf = _processedFile;
								seq = MidiSequence.Merge(mf.Tracks);
								events = new List<MidiEvent>(seq.GetNextEventsAtPosition(songPos, true));
								len = events.Count;
								pos = 0;
							}
							else
							{
								_processedFile = _ProcessFile();
								mf = _processedFile;
								seq = MidiSequence.Merge(mf.Tracks);
								events = seq.Events;
							}
							Visualizer.Sequence = seq;
							Visualizer.Width = Math.Max(VisualizerPanel.Width, Visualizer.Sequence.Length/4);
						}
						

						ofs = 0;
						len = events.Count;
						// iterate through the next events
						var next = pos + MAX_EVENT_COUNT;
						for (; pos < next && ofs <= RATE_TICKS; ++pos)

						{
							// if it's past the end, loop it
							if (len <= pos)
							{
								pos = 0;
								songPos = 0;
								events = seq.Events;
								break;
							}
							var ev = events[pos];
							ofs += ev.Position;
							songPos += pos;
							if (ev.Position < RATE_TICKS && RATE_TICKS < ofs)
								break;
							// otherwise add the next event
							eventList.Add(ev);
						}
						// send the list of events
						if (MidiStreamState.Closed != stm.State && 0 != eventList.Count)
							stm.SendDirect(eventList);
					}));
				}
				catch { }
				
			};
			// add the first events
			for (pos = 0; pos < MAX_EVENT_COUNT && ofs<=RATE_TICKS; ++pos)
			{
				// if it's past the end, loop it
				if (len <= pos )
				{
					pos = 0;
					songPos = 0;
					events = seq.Events;
					break;
				}
				var ev = events[pos];
				ofs += ev.Position;
				if (ev.Position<RATE_TICKS && RATE_TICKS < ofs)
					break;
				// otherwise add the next event
				eventList.Add(ev);
			}
			// send the list of events
			if (0 != eventList.Count)
				stm.SendDirect(eventList);
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			

		}

		private void UnitsCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			OffsetUpDown.Value = 0;

			if(null!=_file) // sanity
			{
				if(0==UnitsCombo.SelectedIndex) // beats
				{
					LengthUpDown.Maximum = Math.Ceiling(_file.Length / (decimal)_file.TimeBase);
					OffsetUpDown.Maximum = LengthUpDown.Maximum - 1;
				} else // ticks
				{
					LengthUpDown.Maximum = _file.Length;
					OffsetUpDown.Maximum = LengthUpDown.Maximum - 1;
				}
				LengthUpDown.Value = LengthUpDown.Maximum;
				_dirty = true;
			}
		}

		private void buttonSaveAs_Click(object sender, EventArgs e)
		{
            //SaveMidiFile.FileName = Path.GetFileNameWithoutExtension(MidiFileBox.Text) + "_edit.mid";
            SaveMidiFile.FileName = getSaveFilePath();

            DialogResult res = SaveMidiFile.ShowDialog(this);
			if (res == DialogResult.OK)
			{
                saveFile(SaveMidiFile.FileName);
			}
		}

        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Reset();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.SelectedPath = Path.GetDirectoryName(MidiFileBox.Text);

            DialogResult res = folderBrowserDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                int selectedIndexTo = comboboxScaleTo.SelectedIndex;

                // save all scales with same nb. notes
                for (int index = 0; index < comboboxScaleTo.Items.Count; index++)
                {
                    comboboxScaleTo.SelectedIndex = index;

                    string fileName = getSaveFilePath();
                    string filepath = Path.Combine(selectedPath, fileName);
                    saveFile(filepath);
                }

                comboboxScaleTo.SelectedIndex = selectedIndexTo;
            }
        }

        private void saveFile(string filepath)
        {
            var mf = _ProcessFile();
            using (var stm = File.OpenWrite(filepath))
            {
                stm.SetLength(0);
                mf.WriteTo(stm);
            }
        }

        private string getSaveFilePath(bool includeDir = false)
        {
            string filePath = $"{Path.GetFileNameWithoutExtension(MidiFileBox.Text)}_edit.mid";

            if (comboboxTonicTo.SelectedIndex >= 0 && comboboxScaleTo.SelectedIndex >= 0)
            {
                string tonicNew = comboboxTonicTo.Items[comboboxTonicTo.SelectedIndex] as string;
                string scaleNew = comboboxScaleTo.Items[comboboxScaleTo.SelectedIndex] as string;
                scaleNew = scaleNew.Replace("/", "-");

                filePath = $"{Path.GetFileNameWithoutExtension(MidiFileBox.Text)} - {tonicNew} {scaleNew}.mid";
            }

            if (includeDir)
            {
                string dir = Path.GetDirectoryName(MidiFileBox.Text);
                filePath = Path.Combine(dir, filePath);
            }

            return filePath;
        }

        MidiFile _ProcessFile()
		{
			// first we clone the file to be safe
			// that way in case there's no modifications
			// specified in the UI we'll still return 
			// a copy.
			var result = _file.Clone();

			// transpose if specified
			if(0!=TransposeUpDown.Value)
				result = result.Transpose((sbyte)TransposeUpDown.Value, WrapCheckBox.Checked,!DrumsCheckBox.Checked);

            // transform if specified
            if (isTransformed())
            {
                int[] transformTable = getTransformationTable();

                // get inversion parameters if selected
                bool invert = false;
                if (comboboxScaleTo.SelectedIndex >= 0)
                {
                    string selectedScaleTo = comboboxScaleTo.Items[comboboxScaleTo.SelectedIndex] as string;
                    string selectedScaleToId = Scales.IdFromScaleName(selectedScaleTo);
                    invert = (selectedScaleToId.ToLower() == "inversion");
                }

                int noteInvRef = 48; // dummy default
                if (invert)
                {
                    string noteInvRefStr = comboboxInvNoteRef.Items[comboboxInvNoteRef.SelectedIndex] as string;
                    noteInvRef = Notes.ValueFromNote(noteInvRefStr);

                    int octave = comboboxInvNoteRefOctave.SelectedIndex;
                    noteInvRef += 12 * octave;
                }

                result = result.Transform(transformTable, WrapCheckBox.Checked, !DrumsCheckBox.Checked, invert, noteInvRef);
            }

			// resample if specified
			if (ResampleUpDown.Value != _file.TimeBase)
				result = result.Resample(unchecked((short)ResampleUpDown.Value));

			// compute our offset and length in ticks or beats/quarter-notes
			var ofs = OffsetUpDown.Value;
			var len = LengthUpDown.Value;
			if (0 == UnitsCombo.SelectedIndex) // beats
			{
				len = Math.Min(len * _file.TimeBase, _file.Length);
				ofs = Math.Min(ofs * _file.TimeBase, _file.Length);
			}
			switch (StartCombo.SelectedIndex)
			{
				case 1:
					ofs += result.FirstDownBeat;
					break;
				case 2:
					ofs += result.FirstNoteOn;
					break;
			}
			// nseq holds our patch and timing info
			var nseq = new MidiSequence();
			if(0!=ofs && CopyTimingPatchCheckBox.Checked)
			{
				// we only want to scan until the
				// first note on
				// we need to check all tracks so
				// we merge them into mtrk and scan
				// that
				var mtrk = MidiSequence.Merge(result.Tracks);
				var end = mtrk.FirstNoteOn;
				if (0 == end) // break later:
					end = mtrk.Length;
				var ins = 0;
				for (int ic = mtrk.Events.Count, i = 0; i < ic; ++i)
				{
					var ev = mtrk.Events[i];
					if (ev.Position >= end)
						break;
					var m = ev.Message;
					switch (m.Status)
					{
						// the reason we don't check for MidiMessageMetaTempo
						// is a user might have specified MidiMessageMeta for
						// it instead. we want to handle both
						case 0xFF:
							var mm = m as MidiMessageMeta;
							switch (mm.Data1)
							{

								case 0x51: // tempo
								case 0x54: // smpte
									if (0 == nseq.Events.Count)
										nseq.Events.Add(new MidiEvent(0,ev.Message.Clone()));
									else
										nseq.Events.Insert(ins, new MidiEvent(0,ev.Message.Clone()));
									++ins;
									break;
							}
							break;
						default:
							// check if it's a patch change
							if (0xC0 == (ev.Message.Status & 0xF0))
							{
								if (0 == nseq.Events.Count)
									nseq.Events.Add(new MidiEvent(0, ev.Message.Clone()));
								else
									nseq.Events.Insert(ins, new MidiEvent(0, ev.Message.Clone()));
								// increment the insert count
								++ins;
							}
							break;
					}
				}
				// set the track to the loop length
				nseq.Events.Add(new MidiEvent((int)len, new MidiMessageMetaEndOfTrack()));
			}
			// see if track 0 is checked
			var hasTrack0 = TrackList.GetItemChecked(0);
			// slice our loop out of it
			if (0!=ofs || result.Length!=len)
				result = result.GetRange((int)ofs, (int)len,CopyTimingPatchCheckBox.Checked,false);
			// normalize it!
			if (NormalizeCheckBox.Checked)
				result = result.NormalizeVelocities();
			// scale levels
			if (1m != LevelsUpDown.Value)
				result = result.ScaleVelocities((double)LevelsUpDown.Value);

			// create a temporary copy of our
			// track list
			var l = new List<MidiSequence>(result.Tracks);
			// now clear the result
			result.Tracks.Clear();
			for(int ic=l.Count,i=0;i<ic;++i)
			{
				// if the track is checked in the list
				// add it back to result
				if(TrackList.GetItemChecked(i))
				{
					result.Tracks.Add(l[i]);
				}
			}
			if (0 < nseq.Events.Count)
			{
				// if we don't have track zero we insert
				// one.
				if(!hasTrack0)
					result.Tracks.Insert(0,nseq);
				else
				{
					// otherwise we merge with track 0
					result.Tracks[0] = MidiSequence.Merge(nseq, result.Tracks[0]);
					
				}
			}
			// next adjust the tempo
			if (_file.Tempo != (double)TempoUpDown.Value)
			{
				result = result.AdjustTempo((double)TempoUpDown.Value);
			}
			// stretch the result. we do this
			// here so the track lengths are
			// correct and we don't need ofs
			// or len anymore
			if (1m != StretchUpDown.Value)
			{
				result = result.Stretch((double)StretchUpDown.Value, AdjustTempoCheckBox.Checked);
			}
			
			// if merge is checked merge the
			// tracks
			if (MergeTracksCheckBox.Checked)
			{
				var trk = MidiSequence.Merge(result.Tracks);
				result.Tracks.Clear();
				result.Tracks.Add(trk);
			}
			_dirty = false;
			_reseekDirty = false;
			return result;
		}

        private void resetTransformNotes()
        {
            if (comboboxesNotesTransform_ == null || comboboxesNotesTransform_.Length == 0)
                return;

            foreach (KeyValuePair<string, int> noteValue in Notes.NotesValuesDict)
            {
                ComboBox cmb = comboboxesNotesTransform_[noteValue.Value];
                if (cmb == null)
                    continue;

                // enable and reset to corresponding note
                cmb.Enabled = true;
                cmb.SelectedIndex = noteValue.Value;
            }
        }

        private bool isTransformed()
        {
            for (int value = 0; value < 12; value++)
            {
                ComboBox cmb = comboboxesNotesTransform_[value];
                if (cmb == null)
                    continue;

                string note = cmb.Items[cmb.SelectedIndex] as string;
                if (Notes.NotesValuesDict[note] != value)
                    return true;
            }

            return false;
        }

        private int[] getTransformationTable()
        {
            int[] table = new int[12];

            for (int value = 0; value < 12; value++)
            {
                ComboBox cmb = comboboxesNotesTransform_[value];
                if (cmb == null || cmb.SelectedIndex < 0)
                    continue;

                // get selected new note
                string note = cmb.Items[cmb.SelectedIndex] as string;
                int valueNew = Notes.NotesValuesDict[note];

                // get shortest distance
                table[value] = computeShortestNotesDistance(value, valueNew);
            }

            return table;
        }

        // compute shortest distance
        private int computeShortestNotesDistance(int value, int valueNew)
        {
            int distMin = Int32.MaxValue;

            int diff0 = valueNew - value;
            int diff1 = valueNew - value + 12;
            int diff_1 = valueNew - value - 12;
            
            int[] diffs = new int[] { diff0, diff1, diff_1 };
            for (int i = 0; i < diffs.Length; i++)
            {
                int diffCur = diffs[i];
                if (Math.Abs(diffCur) < Math.Abs(distMin))
                    distMin = diffCur;
            }

            return distMin;
        }

        private void updateNotesFrequency(bool fileOpened = false)
        {
            Dictionary<int, int> notesFrequency = _file.NotesFrequency;

            // get max note frequency
            int maxFreq = 0;
            int maxFreqValue = -1;
            for (int value = 0; value < 12; value++)
            {
                //Label labelFreq = labelNotesFrequency_[value];
                int curFreq = notesFrequency[value];
                //labelFreq.Text = curFreq.ToString();

                if (curFreq > maxFreq)
                {
                    maxFreq = curFreq;
                    maxFreqValue = value;
                }

                // disable choice when frequency = 0
                ComboBox cmb = comboboxesNotesTransform_[value];
                if (cmb == null)
                    continue;

                cmb.Enabled = (curFreq > 0);
            }

            // update frequency bars
            for (int value = 0; value < 12; value++)
            {
                ProgressBar barFreq = progressbarNotesFrequency_[value];
                barFreq.Value = (int)Math.Round(notesFrequency[value] / (float)maxFreq * 100);
            }

            // update tonic combo boxes
            comboboxTonicFrom.SelectedIndex = maxFreqValue;
            comboboxTonicTo.SelectedIndex = maxFreqValue;
            comboboxInvNoteRef.SelectedIndex = maxFreqValue;
            updateGUI();
        }

        private void updateGUI()
        {
            // get tonic value
            string tonicSrc = comboboxTonicFrom.Items[comboboxTonicFrom.SelectedIndex] as string;
            int tonicSrcValue = Notes.NotesValuesDict[tonicSrc];

            // highlight scale notes
            for (int i = 0; i < 12; i++)
            {
                Label labelNote = labelNotes_[i];
                labelNote.ForeColor = (i == tonicSrcValue) ? Color.DarkRed : Color.Black;

                ComboBox cmb = comboboxesNotesTransform_[i];
                cmb.ForeColor = (i == tonicSrcValue) ? Color.DarkRed : Color.Black;
            }

            // update inversion panel if inversion selected
            if (comboboxScaleTo.Items.Count > 0 && comboboxScaleTo.SelectedIndex >= 0)
            {
                string selectedScaleTo = comboboxScaleTo.Items[comboboxScaleTo.SelectedIndex] as string;
                string selectedScaleToId = Scales.IdFromScaleName(selectedScaleTo);
                bool invert = (selectedScaleToId.ToLower() == "inversion");
                panelInvRefNote.Enabled = invert;
            }
            else
                panelInvRefNote.Enabled = false;
        }

        private void initComboboxScaleTo()
        {
            // set default transformation scales
            if (comboboxScaleFrom.SelectedIndex < 0)
            {
                comboboxScaleTo.Items.Clear();
                comboboxScaleTo.Items.Add("Negative Harmony");
                comboboxScaleTo.Items.Add("Random");
            }
        }

        private void updateComboboxScaleTo(int nbNotesInScale)
        {
            // nop if already same nb. notes
            if (nbNotesInScale == nbNotesInScaleTo_)
                return;

            // fill combo box only with scales of same nb. notes
            comboboxScaleTo.Items.Clear();
            foreach (KeyValuePair<string, string> scale in Scales.ScalesValuesDict)
            {
                string scaleId = Scales.IdFromScaleName(scale.Value);
                if (scaleId == "negative" || scaleId == "inversion" || scaleId == "random") // specific
                {
                    comboboxScaleTo.Items.Add(scale.Value);
                    continue;
                }

                int[] scaleValues = Scales.GetScaleValues(scaleId);
                int nbNotesInScaleCur = scaleValues.Length;
                if (nbNotesInScaleCur != nbNotesInScale)
                    continue;

                comboboxScaleTo.Items.Add(scale.Value);
            }

            comboboxScaleTo.SelectedIndex = -1;
            nbNotesInScaleTo_ = nbNotesInScale;
        }

        private void highlightScaleNotes(int[] scaleSrcNotesValues)
        {
            if (labelNotes_ == null || labelNotes_.Length == 0)
                return;

            for (int i = 0; i < 12; i++)
            {
                Label labelNote = labelNotes_[i];
                FontStyle style = (scaleSrcNotesValues != null && scaleSrcNotesValues.Contains(i))
                    ? FontStyle.Bold : FontStyle.Regular;
                labelNote.Font = new Font(labelNote.Font, style);
            }
        }

        private void resetTranformation(bool resetScaleFrom = true)
        {
            if (resetScaleFrom)
            {
                comboboxScaleFrom.SelectedIndex = -1;
                highlightScaleNotes(null);
            }

            comboboxScaleTo.SelectedIndex = -1;
            resetTransformNotes();

            _dirty = true;
        }

		private void OutputComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void TrackList_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			_dirty = true;
			_reseekDirty = true;
			
			
		}

		private void _SetDirtyHandler(object sender, EventArgs e)
		{
			_dirty = true;
		}

		private void LengthUpDown_ValueChanged(object sender, EventArgs e)
		{
			_dirty = true;
			_reseekDirty = true;
		}

		private void VisualizerPanel_Resize(object sender, EventArgs e)
		{
			Visualizer.Height = VisualizerPanel.Height;
			if (null != Visualizer.Sequence)
			{
				Visualizer.Width = Math.Max(VisualizerPanel.Width, Visualizer.Sequence.Length/4);
			}
			else
				Visualizer.Width = VisualizerPanel.Width;

		}

        private void comboboxNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dirty = true;
            buttonResetTransform.Enabled = true;

            // display modified notes in bold
            //if (comboboxScaleFrom.SelectedIndex >= 0)
            {
                int[] table = getTransformationTable();
                for (int i = 0; i < 12; i++)
                {
                    ComboBox cmb = comboboxesNotesTransform_[i];
                    FontStyle style = (table[i] == 0) ? FontStyle.Regular : FontStyle.Bold;
                    cmb.Font = new Font(cmb.Font, style);
                }
            }
        }

        private void comboboxTonicScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSaveAll.Enabled = (comboboxTonicFrom.SelectedIndex >= 0 && comboboxScaleFrom.SelectedIndex >= 0);

            if (comboboxTonicFrom.SelectedIndex < 0)
                return;
            updateGUI();

            if ((sender as ComboBox) == comboboxScaleFrom && comboboxScaleFrom.SelectedIndex < 0)
                initComboboxScaleTo();

            // compute source scale notes values

            string tonicSrc = comboboxTonicFrom.Items[comboboxTonicFrom.SelectedIndex] as string;
            int tonicSrcValue = Notes.NotesValuesDict[tonicSrc];

            int[] scaleSrcNotesValues = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // all notes
            int nbNotesInScale = 12;
            if (comboboxScaleFrom.SelectedIndex >= 0)
            {
                string scaleSrcName = comboboxScaleFrom.Items[comboboxScaleFrom.SelectedIndex] as string;
                string scaleSrcId = Scales.IdFromScaleName(scaleSrcName);
                int[] scaleSrcValues = Scales.GetScaleValues(scaleSrcId);
                nbNotesInScale = scaleSrcValues.Length;

                // update combo box scale to with scales with same nb. notes
                updateComboboxScaleTo(nbNotesInScale);

                scaleSrcNotesValues = new int[nbNotesInScale];
                for (int i = 0; i < nbNotesInScale; i++)
                    scaleSrcNotesValues[i] = (tonicSrcValue + scaleSrcValues[i]) % 12;

                // highlight scale notes
                highlightScaleNotes(scaleSrcNotesValues);
            }

            // new notes

            if (comboboxTonicTo.SelectedIndex < 0 || comboboxScaleTo.SelectedIndex < 0)
                return;

            _dirty = true;

            // compute new scale notes values

            string tonicNew = comboboxTonicTo.Items[comboboxTonicTo.SelectedIndex] as string;
            int tonicNewValue = Notes.NotesValuesDict[tonicNew];

            string scaleNewName = comboboxScaleTo.Items[comboboxScaleTo.SelectedIndex] as string;
            string scaleNewId = Scales.IdFromScaleName(scaleNewName);
            int[] scaleNewNotesValues;
            if (scaleNewId == "negative") // negative harmony
            {
                // compute negative notes with regard to new tonic fifth
                int tonicNew5thValue = (tonicNewValue + 7) % 12;
                scaleNewNotesValues = new int[12];
                for (int i = 0; i < 12; i++)
                    scaleNewNotesValues[i] = (7 - i + 12 + 2 * tonicNewValue) % 12;

                scaleSrcNotesValues = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // all notes
            }
            else if (scaleNewId == "inversion") // inversion
            {
                // 1st pass: invert only scale notes
                int[] scaleNewNotesValuesTmp = new int[nbNotesInScale];
                for (int i = 0; i < nbNotesInScale; i++)
                {
                    scaleNewNotesValuesTmp[i] = scaleSrcNotesValues[(nbNotesInScale - i) % nbNotesInScale];
                }

                // 2nd pass: try to invert remaining notes by interpolation
                scaleNewNotesValues = new int[12];
                for (int i = 0; i < 12; i++)
                {
                    // scale note: already computed
                    if (scaleSrcNotesValues.Contains(i))
                    {
                        int index = Array.IndexOf(scaleSrcNotesValues, i);
                        scaleNewNotesValues[i] = scaleNewNotesValuesTmp[index];
                        continue;
                    }

                    // get scale note before and after
                    int scaleIndexBefore = -1;
                    int scaleIndexAfter = -1;
                    for (int j = i; j >= 0; j--)
                    {
                        if (scaleSrcNotesValues.Contains(j))
                            { scaleIndexBefore = Array.IndexOf(scaleSrcNotesValues, j); break; }
                    }
                    for (int j = i; j < 12; j++)
                    {
                        if (scaleSrcNotesValues.Contains(j))
                            { scaleIndexAfter = Array.IndexOf(scaleSrcNotesValues, j); break; }
                    }

                    if (scaleIndexBefore < 0 || scaleIndexAfter < 0)
                        continue;

                    // get interpolated position

                    int noteValueNew = -1;
                    //float scaleIndexInter = (float)(0.5 * (scaleSrcNotesValues[scaleIndexBefore] + scaleSrcNotesValues[scaleIndexAfter]));
                    int invNoteValueBefore = scaleSrcNotesValues[(nbNotesInScale - scaleIndexBefore) % nbNotesInScale];
                    int invNoteValueAfter = scaleSrcNotesValues[(nbNotesInScale - scaleIndexAfter) % nbNotesInScale];
                    int invNotesDist = computeShortestNotesDistance(invNoteValueBefore, invNoteValueAfter);

                    int distFromBefore = computeShortestNotesDistance(i, scaleSrcNotesValues[scaleIndexBefore]);
                    float scaleIndexFrac = (float)(distFromBefore / (float)invNotesDist);

                    // no spaces between inverted notes: place to nearest note (except tonic)
                    if (Math.Abs(invNotesDist) == 1)
                    {
                        if (invNoteValueBefore == tonicNewValue)
                            noteValueNew = invNoteValueAfter;
                        else if (invNoteValueAfter == tonicNewValue)
                            noteValueNew = invNoteValueBefore;
                        else
                            if (scaleIndexFrac < 0.5)
                                noteValueNew = invNoteValueBefore;
                            else
                                noteValueNew = invNoteValueAfter;
                    }
                    // 1 space between inverted notes: place note
                    else if (Math.Abs(invNotesDist) == 2)
                    {
                        noteValueNew = ((invNoteValueBefore + invNoteValueAfter) / 2) % 12;
                    }
                    // n space betweens inverted notes: place note at nearest interpolated position
                    else
                    {
                        noteValueNew = (int)Math.Round(invNoteValueBefore + scaleIndexFrac * invNotesDist) % 12;
                    }

                    scaleNewNotesValues[i] = noteValueNew;
                }

                scaleSrcNotesValues = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // all notes
            }
            else if (scaleNewId == "random") // random
            {
                scaleSrcNotesValues = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // all notes

                Random rnd = new Random();
                scaleNewNotesValues = scaleSrcNotesValues.OrderBy(x => rnd.Next()).ToArray();
            }
            else
            {
                scaleNewNotesValues = new int[nbNotesInScale];
                int[] scaleNewValues = Scales.GetScaleValues(scaleNewId);
                for (int i = 0; i < nbNotesInScale; i++)
                    scaleNewNotesValues[i] = (tonicNewValue + scaleNewValues[i]) % 12;
            }

            // compute new expected notes table

            int[] newNotesTable = new int[12];
            for (int i = 0; i < 12; i++)
            {
                newNotesTable[i] = i; // default

                if (!scaleSrcNotesValues.Contains(i))
                    continue;

                // get note index in source scale notes values
                int index = Array.IndexOf(scaleSrcNotesValues, i);
                if (index < 0)
                    continue;

                // get corresponding note in new scale
                newNotesTable[i] = scaleNewNotesValues[index];
            }

            // pre-fill transform notes

            for (int value = 0; value < 12; value++)
            {
                // disable choice when frequency = 0
                ComboBox cmb = comboboxesNotesTransform_[value];
                if (cmb == null || !cmb.Enabled)
                    continue;

                cmb.SelectedIndex = newNotesTable[value];
            }
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (_isPlaying)
                return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (!MidiFile(files))
                return;

            // ok
            e.Effect = DragDropEffects.Link;
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            if (_isPlaying)
                return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (!MidiFile(files))
                return;

            // ok, open document
            string filepath = files[0];
            loadFile(filepath);
        }

        private bool MidiFile(string[] files)
        {
            if (files == null || files.Length != 1)
                return false;

            // check extension
            string file = files[0];
            if (Path.GetExtension(file).ToLower() != ".mid")
                return false;

            return true;
        }

        private void comboboxInvNoteRef_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dirty = true;
        }

        private void buttonResetTransform_Click(object sender, EventArgs e)
        {
            resetTranformation(false /* resetScaleFrom */);

            buttonResetTransform.Enabled = false;
        }
    }
}
