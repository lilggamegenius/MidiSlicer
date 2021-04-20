namespace MidiEditor
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TrackList = new System.Windows.Forms.CheckedListBox();
            this.TracksLabel = new System.Windows.Forms.Label();
            this.MidiFileBox = new System.Windows.Forms.TextBox();
            this.FileLabel = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.OpenMidiFile = new System.Windows.Forms.OpenFileDialog();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.UnitsLabel = new System.Windows.Forms.Label();
            this.UnitsCombo = new System.Windows.Forms.ComboBox();
            this.OffsetUpDown = new System.Windows.Forms.NumericUpDown();
            this.OffsetLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.LengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.SaveMidiFile = new System.Windows.Forms.SaveFileDialog();
            this.MergeTracksCheckBox = new System.Windows.Forms.CheckBox();
            this.StretchLabel = new System.Windows.Forms.Label();
            this.StretchUpDown = new System.Windows.Forms.NumericUpDown();
            this.AdjustTempoCheckBox = new System.Windows.Forms.CheckBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.StartCombo = new System.Windows.Forms.ComboBox();
            this.CopyTimingPatchCheckBox = new System.Windows.Forms.CheckBox();
            this.ResampleLabel = new System.Windows.Forms.Label();
            this.ResampleUpDown = new System.Windows.Forms.NumericUpDown();
            this.NormalizeCheckBox = new System.Windows.Forms.CheckBox();
            this.LevelsLabel = new System.Windows.Forms.Label();
            this.LevelsUpDown = new System.Windows.Forms.NumericUpDown();
            this.TransposeUpDown = new System.Windows.Forms.NumericUpDown();
            this.TransposeLabel = new System.Windows.Forms.Label();
            this.WrapCheckBox = new System.Windows.Forms.CheckBox();
            this.DrumsCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputComboBox = new System.Windows.Forms.ComboBox();
            this.TempoLabel = new System.Windows.Forms.Label();
            this.TempoUpDown = new System.Windows.Forms.NumericUpDown();
            this.VisualizerPanel = new System.Windows.Forms.Panel();
            this.Visualizer = new M.MidiVisualizer();
            this.panelNotes = new System.Windows.Forms.Panel();
            this.buttonResetTransform = new System.Windows.Forms.Button();
            this.panelInvRefNote = new System.Windows.Forms.Panel();
            this.comboboxInvNoteRef = new System.Windows.Forms.ComboBox();
            this.labelInvNoteRef = new System.Windows.Forms.Label();
            this.comboboxInvNoteRefOctave = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxScaleTo = new System.Windows.Forms.ComboBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboboxTonicTo = new System.Windows.Forms.ComboBox();
            this.comboboxScaleFrom = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.comboboxTonicFrom = new System.Windows.Forms.ComboBox();
            this.progressbarFreq11 = new System.Windows.Forms.ProgressBar();
            this.progressbarFreq10 = new System.Windows.Forms.ProgressBar();
            this.progressbarFreq9 = new System.Windows.Forms.ProgressBar();
            this.progressbarFreq8 = new System.Windows.Forms.ProgressBar();
            this.progressbarFreq7 = new System.Windows.Forms.ProgressBar();
            this.progressbarFreq6 = new System.Windows.Forms.ProgressBar();
            this.progressbarFreq5 = new System.Windows.Forms.ProgressBar();
            this.progressbarFreq4 = new System.Windows.Forms.ProgressBar();
            this.progressbarFreq3 = new System.Windows.Forms.ProgressBar();
            this.progressbarFreq2 = new System.Windows.Forms.ProgressBar();
            this.progressbarFreq1 = new System.Windows.Forms.ProgressBar();
            this.progressbarFreq0 = new System.Windows.Forms.ProgressBar();
            this.comboboxNote11 = new System.Windows.Forms.ComboBox();
            this.comboboxNote9 = new System.Windows.Forms.ComboBox();
            this.comboboxNote8 = new System.Windows.Forms.ComboBox();
            this.comboboxNote7 = new System.Windows.Forms.ComboBox();
            this.comboboxNote6 = new System.Windows.Forms.ComboBox();
            this.comboboxNote10 = new System.Windows.Forms.ComboBox();
            this.comboboxNote5 = new System.Windows.Forms.ComboBox();
            this.comboboxNote3 = new System.Windows.Forms.ComboBox();
            this.comboboxNote2 = new System.Windows.Forms.ComboBox();
            this.comboboxNote1 = new System.Windows.Forms.ComboBox();
            this.comboboxNote0 = new System.Windows.Forms.ComboBox();
            this.comboboxNote4 = new System.Windows.Forms.ComboBox();
            this.labelNote11 = new System.Windows.Forms.Label();
            this.labelNote10 = new System.Windows.Forms.Label();
            this.labelNote9 = new System.Windows.Forms.Label();
            this.labelNote8 = new System.Windows.Forms.Label();
            this.labelNote7 = new System.Windows.Forms.Label();
            this.labelNote6 = new System.Windows.Forms.Label();
            this.labelNote5 = new System.Windows.Forms.Label();
            this.labelNote4 = new System.Windows.Forms.Label();
            this.labelNote3 = new System.Windows.Forms.Label();
            this.labelNote2 = new System.Windows.Forms.Label();
            this.labelNote1 = new System.Windows.Forms.Label();
            this.labelNote0 = new System.Windows.Forms.Label();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StretchUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResampleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransposeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempoUpDown)).BeginInit();
            this.VisualizerPanel.SuspendLayout();
            this.panelNotes.SuspendLayout();
            this.panelInvRefNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrackList
            // 
            this.TrackList.CheckOnClick = true;
            this.TrackList.Enabled = false;
            this.TrackList.FormattingEnabled = true;
            this.TrackList.Location = new System.Drawing.Point(1, 52);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(79, 184);
            this.TrackList.TabIndex = 0;
            this.TrackList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TrackList_ItemCheck);
            // 
            // TracksLabel
            // 
            this.TracksLabel.AutoSize = true;
            this.TracksLabel.Location = new System.Drawing.Point(1, 30);
            this.TracksLabel.Name = "TracksLabel";
            this.TracksLabel.Size = new System.Drawing.Size(140, 13);
            this.TracksLabel.TabIndex = 1;
            this.TracksLabel.Text = "Tracks:              {0}/{1} time";
            // 
            // MidiFileBox
            // 
            this.MidiFileBox.Location = new System.Drawing.Point(30, 2);
            this.MidiFileBox.Name = "MidiFileBox";
            this.MidiFileBox.Size = new System.Drawing.Size(297, 20);
            this.MidiFileBox.TabIndex = 2;
            this.MidiFileBox.Leave += new System.EventHandler(this.MidiFileBox_Leave);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(1, 5);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(23, 13);
            this.FileLabel.TabIndex = 3;
            this.FileLabel.Text = "File";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoad.Location = new System.Drawing.Point(333, 1);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(25, 22);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // OpenMidiFile
            // 
            this.OpenMidiFile.DefaultExt = "mid";
            this.OpenMidiFile.Filter = "MIDI files|*.mid|All files|*.*";
            // 
            // buttonPreview
            // 
            this.buttonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreview.Location = new System.Drawing.Point(761, 355);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPreview.TabIndex = 5;
            this.buttonPreview.Text = "Preview ♪";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // UnitsLabel
            // 
            this.UnitsLabel.AutoSize = true;
            this.UnitsLabel.Location = new System.Drawing.Point(86, 55);
            this.UnitsLabel.Name = "UnitsLabel";
            this.UnitsLabel.Size = new System.Drawing.Size(31, 13);
            this.UnitsLabel.TabIndex = 9;
            this.UnitsLabel.Text = "Units";
            // 
            // UnitsCombo
            // 
            this.UnitsCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnitsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitsCombo.FormattingEnabled = true;
            this.UnitsCombo.Items.AddRange(new object[] {
            "Beats",
            "Ticks"});
            this.UnitsCombo.Location = new System.Drawing.Point(121, 52);
            this.UnitsCombo.Name = "UnitsCombo";
            this.UnitsCombo.Size = new System.Drawing.Size(75, 21);
            this.UnitsCombo.TabIndex = 8;
            this.UnitsCombo.SelectedIndexChanged += new System.EventHandler(this.UnitsCombo_SelectedIndexChanged);
            // 
            // OffsetUpDown
            // 
            this.OffsetUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OffsetUpDown.DecimalPlaces = 2;
            this.OffsetUpDown.Location = new System.Drawing.Point(130, 105);
            this.OffsetUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.OffsetUpDown.Name = "OffsetUpDown";
            this.OffsetUpDown.Size = new System.Drawing.Size(66, 20);
            this.OffsetUpDown.TabIndex = 10;
            this.OffsetUpDown.ValueChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // OffsetLabel
            // 
            this.OffsetLabel.AutoSize = true;
            this.OffsetLabel.Location = new System.Drawing.Point(86, 108);
            this.OffsetLabel.Name = "OffsetLabel";
            this.OffsetLabel.Size = new System.Drawing.Size(35, 13);
            this.OffsetLabel.TabIndex = 11;
            this.OffsetLabel.Text = "Offset";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(200, 108);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 13;
            this.LengthLabel.Text = "Length";
            // 
            // LengthUpDown
            // 
            this.LengthUpDown.DecimalPlaces = 2;
            this.LengthUpDown.Location = new System.Drawing.Point(240, 105);
            this.LengthUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LengthUpDown.Name = "LengthUpDown";
            this.LengthUpDown.Size = new System.Drawing.Size(75, 20);
            this.LengthUpDown.TabIndex = 12;
            this.LengthUpDown.ValueChanged += new System.EventHandler(this.LengthUpDown_ValueChanged);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveAs.Location = new System.Drawing.Point(680, 355);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAs.TabIndex = 14;
            this.buttonSaveAs.Text = "Save As...";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // SaveMidiFile
            // 
            this.SaveMidiFile.DefaultExt = "mid";
            this.SaveMidiFile.Filter = "MIDI files|*.mid|All files|*.*";
            // 
            // MergeTracksCheckBox
            // 
            this.MergeTracksCheckBox.AutoSize = true;
            this.MergeTracksCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MergeTracksCheckBox.Location = new System.Drawing.Point(200, 55);
            this.MergeTracksCheckBox.Name = "MergeTracksCheckBox";
            this.MergeTracksCheckBox.Size = new System.Drawing.Size(92, 17);
            this.MergeTracksCheckBox.TabIndex = 15;
            this.MergeTracksCheckBox.Text = "Merge Tracks";
            this.MergeTracksCheckBox.UseVisualStyleBackColor = true;
            this.MergeTracksCheckBox.CheckedChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // StretchLabel
            // 
            this.StretchLabel.AutoSize = true;
            this.StretchLabel.Location = new System.Drawing.Point(86, 132);
            this.StretchLabel.Name = "StretchLabel";
            this.StretchLabel.Size = new System.Drawing.Size(41, 13);
            this.StretchLabel.TabIndex = 19;
            this.StretchLabel.Text = "Stretch";
            // 
            // StretchUpDown
            // 
            this.StretchUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StretchUpDown.DecimalPlaces = 2;
            this.StretchUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.StretchUpDown.Location = new System.Drawing.Point(130, 129);
            this.StretchUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.StretchUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.StretchUpDown.Name = "StretchUpDown";
            this.StretchUpDown.Size = new System.Drawing.Size(66, 20);
            this.StretchUpDown.TabIndex = 18;
            this.StretchUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StretchUpDown.ValueChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // AdjustTempoCheckBox
            // 
            this.AdjustTempoCheckBox.AutoSize = true;
            this.AdjustTempoCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdjustTempoCheckBox.Location = new System.Drawing.Point(200, 131);
            this.AdjustTempoCheckBox.Name = "AdjustTempoCheckBox";
            this.AdjustTempoCheckBox.Size = new System.Drawing.Size(91, 17);
            this.AdjustTempoCheckBox.TabIndex = 20;
            this.AdjustTempoCheckBox.Text = "Adjust Tempo";
            this.AdjustTempoCheckBox.UseVisualStyleBackColor = true;
            this.AdjustTempoCheckBox.CheckedChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(86, 81);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(29, 13);
            this.StartLabel.TabIndex = 22;
            this.StartLabel.Text = "Start";
            // 
            // StartCombo
            // 
            this.StartCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartCombo.FormattingEnabled = true;
            this.StartCombo.Items.AddRange(new object[] {
            "Beginning",
            "First Downbeat",
            "First Note"});
            this.StartCombo.Location = new System.Drawing.Point(121, 78);
            this.StartCombo.Name = "StartCombo";
            this.StartCombo.Size = new System.Drawing.Size(75, 21);
            this.StartCombo.TabIndex = 21;
            this.StartCombo.SelectedIndexChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // CopyTimingPatchCheckBox
            // 
            this.CopyTimingPatchCheckBox.AutoSize = true;
            this.CopyTimingPatchCheckBox.Checked = true;
            this.CopyTimingPatchCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CopyTimingPatchCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyTimingPatchCheckBox.Location = new System.Drawing.Point(200, 77);
            this.CopyTimingPatchCheckBox.Name = "CopyTimingPatchCheckBox";
            this.CopyTimingPatchCheckBox.Size = new System.Drawing.Size(117, 17);
            this.CopyTimingPatchCheckBox.TabIndex = 23;
            this.CopyTimingPatchCheckBox.Text = "Copy Timing/Patch";
            this.CopyTimingPatchCheckBox.UseVisualStyleBackColor = true;
            this.CopyTimingPatchCheckBox.CheckedChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // ResampleLabel
            // 
            this.ResampleLabel.AutoSize = true;
            this.ResampleLabel.Location = new System.Drawing.Point(86, 157);
            this.ResampleLabel.Name = "ResampleLabel";
            this.ResampleLabel.Size = new System.Drawing.Size(54, 13);
            this.ResampleLabel.TabIndex = 25;
            this.ResampleLabel.Text = "Resample";
            // 
            // ResampleUpDown
            // 
            this.ResampleUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResampleUpDown.Location = new System.Drawing.Point(142, 154);
            this.ResampleUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ResampleUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ResampleUpDown.Name = "ResampleUpDown";
            this.ResampleUpDown.Size = new System.Drawing.Size(54, 20);
            this.ResampleUpDown.TabIndex = 24;
            this.ResampleUpDown.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.ResampleUpDown.ValueChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // NormalizeCheckBox
            // 
            this.NormalizeCheckBox.AutoSize = true;
            this.NormalizeCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NormalizeCheckBox.Location = new System.Drawing.Point(200, 181);
            this.NormalizeCheckBox.Name = "NormalizeCheckBox";
            this.NormalizeCheckBox.Size = new System.Drawing.Size(72, 17);
            this.NormalizeCheckBox.TabIndex = 26;
            this.NormalizeCheckBox.Text = "Normalize";
            this.NormalizeCheckBox.UseVisualStyleBackColor = true;
            this.NormalizeCheckBox.CheckedChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // LevelsLabel
            // 
            this.LevelsLabel.AutoSize = true;
            this.LevelsLabel.Location = new System.Drawing.Point(86, 182);
            this.LevelsLabel.Name = "LevelsLabel";
            this.LevelsLabel.Size = new System.Drawing.Size(38, 13);
            this.LevelsLabel.TabIndex = 27;
            this.LevelsLabel.Text = "Levels";
            // 
            // LevelsUpDown
            // 
            this.LevelsUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LevelsUpDown.DecimalPlaces = 2;
            this.LevelsUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.LevelsUpDown.Location = new System.Drawing.Point(130, 180);
            this.LevelsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LevelsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LevelsUpDown.Name = "LevelsUpDown";
            this.LevelsUpDown.Size = new System.Drawing.Size(66, 20);
            this.LevelsUpDown.TabIndex = 28;
            this.LevelsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelsUpDown.ValueChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // TransposeUpDown
            // 
            this.TransposeUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransposeUpDown.Location = new System.Drawing.Point(142, 206);
            this.TransposeUpDown.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.TransposeUpDown.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.TransposeUpDown.Name = "TransposeUpDown";
            this.TransposeUpDown.Size = new System.Drawing.Size(54, 20);
            this.TransposeUpDown.TabIndex = 30;
            this.TransposeUpDown.ValueChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // TransposeLabel
            // 
            this.TransposeLabel.AutoSize = true;
            this.TransposeLabel.Location = new System.Drawing.Point(86, 208);
            this.TransposeLabel.Name = "TransposeLabel";
            this.TransposeLabel.Size = new System.Drawing.Size(57, 13);
            this.TransposeLabel.TabIndex = 29;
            this.TransposeLabel.Text = "Transpose";
            // 
            // WrapCheckBox
            // 
            this.WrapCheckBox.AutoSize = true;
            this.WrapCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WrapCheckBox.Location = new System.Drawing.Point(200, 207);
            this.WrapCheckBox.Name = "WrapCheckBox";
            this.WrapCheckBox.Size = new System.Drawing.Size(52, 17);
            this.WrapCheckBox.TabIndex = 31;
            this.WrapCheckBox.Text = "Wrap";
            this.WrapCheckBox.UseVisualStyleBackColor = true;
            this.WrapCheckBox.CheckedChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // DrumsCheckBox
            // 
            this.DrumsCheckBox.AutoSize = true;
            this.DrumsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrumsCheckBox.Location = new System.Drawing.Point(251, 207);
            this.DrumsCheckBox.Name = "DrumsCheckBox";
            this.DrumsCheckBox.Size = new System.Drawing.Size(56, 17);
            this.DrumsCheckBox.TabIndex = 32;
            this.DrumsCheckBox.Text = "Drums";
            this.DrumsCheckBox.UseVisualStyleBackColor = true;
            this.DrumsCheckBox.CheckedChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // OutputComboBox
            // 
            this.OutputComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputComboBox.FormattingEnabled = true;
            this.OutputComboBox.Location = new System.Drawing.Point(573, 1);
            this.OutputComboBox.Name = "OutputComboBox";
            this.OutputComboBox.Size = new System.Drawing.Size(258, 21);
            this.OutputComboBox.TabIndex = 33;
            this.OutputComboBox.SelectedIndexChanged += new System.EventHandler(this.OutputComboBox_SelectedIndexChanged);
            // 
            // TempoLabel
            // 
            this.TempoLabel.AutoSize = true;
            this.TempoLabel.Location = new System.Drawing.Point(167, 30);
            this.TempoLabel.Name = "TempoLabel";
            this.TempoLabel.Size = new System.Drawing.Size(40, 13);
            this.TempoLabel.TabIndex = 34;
            this.TempoLabel.Text = "Tempo";
            // 
            // TempoUpDown
            // 
            this.TempoUpDown.DecimalPlaces = 3;
            this.TempoUpDown.Location = new System.Drawing.Point(209, 27);
            this.TempoUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.TempoUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TempoUpDown.Name = "TempoUpDown";
            this.TempoUpDown.Size = new System.Drawing.Size(74, 20);
            this.TempoUpDown.TabIndex = 35;
            this.TempoUpDown.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.TempoUpDown.ValueChanged += new System.EventHandler(this._SetDirtyHandler);
            // 
            // VisualizerPanel
            // 
            this.VisualizerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VisualizerPanel.AutoScroll = true;
            this.VisualizerPanel.Controls.Add(this.Visualizer);
            this.VisualizerPanel.Location = new System.Drawing.Point(4, 242);
            this.VisualizerPanel.Name = "VisualizerPanel";
            this.VisualizerPanel.Size = new System.Drawing.Size(311, 107);
            this.VisualizerPanel.TabIndex = 36;
            this.VisualizerPanel.Resize += new System.EventHandler(this.VisualizerPanel_Resize);
            // 
            // Visualizer
            // 
            this.Visualizer.BackColor = System.Drawing.Color.Black;
            this.Visualizer.ChannelColors = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.LightGoldenrodYellow,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.LightCyan,
        System.Drawing.Color.LightPink,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Magenta,
        System.Drawing.Color.Orange,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.Brown,
        System.Drawing.Color.DarkBlue,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.HotPink,
        System.Drawing.Color.DarkGray,
        System.Drawing.Color.DarkMagenta,
        System.Drawing.Color.DarkOrange};
            this.Visualizer.CursorColor = System.Drawing.Color.DarkGoldenrod;
            this.Visualizer.Location = new System.Drawing.Point(0, 0);
            this.Visualizer.Name = "Visualizer";
            this.Visualizer.Sequence = null;
            this.Visualizer.Size = new System.Drawing.Size(311, 107);
            this.Visualizer.TabIndex = 0;
            this.Visualizer.Text = "Visualizer";
            // 
            // panelNotes
            // 
            this.panelNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNotes.Controls.Add(this.buttonResetTransform);
            this.panelNotes.Controls.Add(this.panelInvRefNote);
            this.panelNotes.Controls.Add(this.label9);
            this.panelNotes.Controls.Add(this.label10);
            this.panelNotes.Controls.Add(this.label11);
            this.panelNotes.Controls.Add(this.label12);
            this.panelNotes.Controls.Add(this.label5);
            this.panelNotes.Controls.Add(this.label6);
            this.panelNotes.Controls.Add(this.label7);
            this.panelNotes.Controls.Add(this.label8);
            this.panelNotes.Controls.Add(this.label3);
            this.panelNotes.Controls.Add(this.label4);
            this.panelNotes.Controls.Add(this.label2);
            this.panelNotes.Controls.Add(this.label1);
            this.panelNotes.Controls.Add(this.comboboxScaleTo);
            this.panelNotes.Controls.Add(this.labelTo);
            this.panelNotes.Controls.Add(this.comboboxTonicTo);
            this.panelNotes.Controls.Add(this.comboboxScaleFrom);
            this.panelNotes.Controls.Add(this.labelFrom);
            this.panelNotes.Controls.Add(this.comboboxTonicFrom);
            this.panelNotes.Controls.Add(this.progressbarFreq11);
            this.panelNotes.Controls.Add(this.progressbarFreq10);
            this.panelNotes.Controls.Add(this.progressbarFreq9);
            this.panelNotes.Controls.Add(this.progressbarFreq8);
            this.panelNotes.Controls.Add(this.progressbarFreq7);
            this.panelNotes.Controls.Add(this.progressbarFreq6);
            this.panelNotes.Controls.Add(this.progressbarFreq5);
            this.panelNotes.Controls.Add(this.progressbarFreq4);
            this.panelNotes.Controls.Add(this.progressbarFreq3);
            this.panelNotes.Controls.Add(this.progressbarFreq2);
            this.panelNotes.Controls.Add(this.progressbarFreq1);
            this.panelNotes.Controls.Add(this.progressbarFreq0);
            this.panelNotes.Controls.Add(this.comboboxNote11);
            this.panelNotes.Controls.Add(this.comboboxNote9);
            this.panelNotes.Controls.Add(this.comboboxNote8);
            this.panelNotes.Controls.Add(this.comboboxNote7);
            this.panelNotes.Controls.Add(this.comboboxNote6);
            this.panelNotes.Controls.Add(this.comboboxNote10);
            this.panelNotes.Controls.Add(this.comboboxNote5);
            this.panelNotes.Controls.Add(this.comboboxNote3);
            this.panelNotes.Controls.Add(this.comboboxNote2);
            this.panelNotes.Controls.Add(this.comboboxNote1);
            this.panelNotes.Controls.Add(this.comboboxNote0);
            this.panelNotes.Controls.Add(this.comboboxNote4);
            this.panelNotes.Controls.Add(this.labelNote11);
            this.panelNotes.Controls.Add(this.labelNote10);
            this.panelNotes.Controls.Add(this.labelNote9);
            this.panelNotes.Controls.Add(this.labelNote8);
            this.panelNotes.Controls.Add(this.labelNote7);
            this.panelNotes.Controls.Add(this.labelNote6);
            this.panelNotes.Controls.Add(this.labelNote5);
            this.panelNotes.Controls.Add(this.labelNote4);
            this.panelNotes.Controls.Add(this.labelNote3);
            this.panelNotes.Controls.Add(this.labelNote2);
            this.panelNotes.Controls.Add(this.labelNote1);
            this.panelNotes.Controls.Add(this.labelNote0);
            this.panelNotes.Location = new System.Drawing.Point(333, 31);
            this.panelNotes.Name = "panelNotes";
            this.panelNotes.Size = new System.Drawing.Size(503, 319);
            this.panelNotes.TabIndex = 37;
            // 
            // buttonResetTransform
            // 
            this.buttonResetTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonResetTransform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetTransform.Location = new System.Drawing.Point(352, 276);
            this.buttonResetTransform.Name = "buttonResetTransform";
            this.buttonResetTransform.Size = new System.Drawing.Size(146, 21);
            this.buttonResetTransform.TabIndex = 39;
            this.buttonResetTransform.Text = "Reset transformation";
            this.buttonResetTransform.UseVisualStyleBackColor = true;
            this.buttonResetTransform.Click += new System.EventHandler(this.buttonResetTransform_Click);
            // 
            // panelInvRefNote
            // 
            this.panelInvRefNote.Controls.Add(this.comboboxInvNoteRef);
            this.panelInvRefNote.Controls.Add(this.labelInvNoteRef);
            this.panelInvRefNote.Controls.Add(this.comboboxInvNoteRefOctave);
            this.panelInvRefNote.Enabled = false;
            this.panelInvRefNote.Location = new System.Drawing.Point(270, 127);
            this.panelInvRefNote.Name = "panelInvRefNote";
            this.panelInvRefNote.Size = new System.Drawing.Size(231, 66);
            this.panelInvRefNote.TabIndex = 69;
            // 
            // comboboxInvNoteRef
            // 
            this.comboboxInvNoteRef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxInvNoteRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxInvNoteRef.FormattingEnabled = true;
            this.comboboxInvNoteRef.Location = new System.Drawing.Point(132, 25);
            this.comboboxInvNoteRef.Name = "comboboxInvNoteRef";
            this.comboboxInvNoteRef.Size = new System.Drawing.Size(45, 21);
            this.comboboxInvNoteRef.TabIndex = 66;
            this.comboboxInvNoteRef.SelectedIndexChanged += new System.EventHandler(this.comboboxInvNoteRef_SelectedIndexChanged);
            // 
            // labelInvNoteRef
            // 
            this.labelInvNoteRef.AutoSize = true;
            this.labelInvNoteRef.Location = new System.Drawing.Point(4, 28);
            this.labelInvNoteRef.Name = "labelInvNoteRef";
            this.labelInvNoteRef.Size = new System.Drawing.Size(122, 13);
            this.labelInvNoteRef.TabIndex = 68;
            this.labelInvNoteRef.Text = "Inversion reference note";
            // 
            // comboboxInvNoteRefOctave
            // 
            this.comboboxInvNoteRefOctave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxInvNoteRefOctave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxInvNoteRefOctave.FormattingEnabled = true;
            this.comboboxInvNoteRefOctave.Location = new System.Drawing.Point(183, 25);
            this.comboboxInvNoteRefOctave.Name = "comboboxInvNoteRefOctave";
            this.comboboxInvNoteRefOctave.Size = new System.Drawing.Size(45, 21);
            this.comboboxInvNoteRefOctave.TabIndex = 67;
            this.comboboxInvNoteRefOctave.SelectedIndexChanged += new System.EventHandler(this.comboboxInvNoteRef_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "->";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "->";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "->";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "->";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "->";
            // 
            // comboboxScaleTo
            // 
            this.comboboxScaleTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxScaleTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxScaleTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxScaleTo.FormattingEnabled = true;
            this.comboboxScaleTo.Location = new System.Drawing.Point(240, 101);
            this.comboboxScaleTo.Name = "comboboxScaleTo";
            this.comboboxScaleTo.Size = new System.Drawing.Size(258, 21);
            this.comboboxScaleTo.TabIndex = 53;
            this.comboboxScaleTo.SelectedIndexChanged += new System.EventHandler(this.comboboxTonicScale_SelectedIndexChanged);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(180, 79);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 52;
            this.labelTo.Text = "To";
            // 
            // comboboxTonicTo
            // 
            this.comboboxTonicTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxTonicTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxTonicTo.Enabled = false;
            this.comboboxTonicTo.FormattingEnabled = true;
            this.comboboxTonicTo.Location = new System.Drawing.Point(180, 101);
            this.comboboxTonicTo.Name = "comboboxTonicTo";
            this.comboboxTonicTo.Size = new System.Drawing.Size(45, 21);
            this.comboboxTonicTo.TabIndex = 51;
            this.comboboxTonicTo.SelectedIndexChanged += new System.EventHandler(this.comboboxTonicScale_SelectedIndexChanged);
            // 
            // comboboxScaleFrom
            // 
            this.comboboxScaleFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxScaleFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxScaleFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxScaleFrom.Enabled = false;
            this.comboboxScaleFrom.FormattingEnabled = true;
            this.comboboxScaleFrom.Location = new System.Drawing.Point(240, 26);
            this.comboboxScaleFrom.Name = "comboboxScaleFrom";
            this.comboboxScaleFrom.Size = new System.Drawing.Size(258, 21);
            this.comboboxScaleFrom.TabIndex = 50;
            this.comboboxScaleFrom.SelectedIndexChanged += new System.EventHandler(this.comboboxTonicScale_SelectedIndexChanged);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(180, 4);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(30, 13);
            this.labelFrom.TabIndex = 49;
            this.labelFrom.Text = "From";
            // 
            // comboboxTonicFrom
            // 
            this.comboboxTonicFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxTonicFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxTonicFrom.Enabled = false;
            this.comboboxTonicFrom.FormattingEnabled = true;
            this.comboboxTonicFrom.Location = new System.Drawing.Point(180, 26);
            this.comboboxTonicFrom.Name = "comboboxTonicFrom";
            this.comboboxTonicFrom.Size = new System.Drawing.Size(45, 21);
            this.comboboxTonicFrom.TabIndex = 48;
            this.comboboxTonicFrom.SelectedIndexChanged += new System.EventHandler(this.comboboxTonicScale_SelectedIndexChanged);
            // 
            // progressbarFreq11
            // 
            this.progressbarFreq11.Location = new System.Drawing.Point(27, 276);
            this.progressbarFreq11.Name = "progressbarFreq11";
            this.progressbarFreq11.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq11.TabIndex = 47;
            // 
            // progressbarFreq10
            // 
            this.progressbarFreq10.Location = new System.Drawing.Point(27, 251);
            this.progressbarFreq10.Name = "progressbarFreq10";
            this.progressbarFreq10.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq10.TabIndex = 46;
            // 
            // progressbarFreq9
            // 
            this.progressbarFreq9.Location = new System.Drawing.Point(27, 224);
            this.progressbarFreq9.Name = "progressbarFreq9";
            this.progressbarFreq9.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq9.TabIndex = 45;
            // 
            // progressbarFreq8
            // 
            this.progressbarFreq8.Location = new System.Drawing.Point(27, 201);
            this.progressbarFreq8.Name = "progressbarFreq8";
            this.progressbarFreq8.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq8.TabIndex = 44;
            // 
            // progressbarFreq7
            // 
            this.progressbarFreq7.Location = new System.Drawing.Point(27, 176);
            this.progressbarFreq7.Name = "progressbarFreq7";
            this.progressbarFreq7.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq7.TabIndex = 43;
            // 
            // progressbarFreq6
            // 
            this.progressbarFreq6.Location = new System.Drawing.Point(27, 151);
            this.progressbarFreq6.Name = "progressbarFreq6";
            this.progressbarFreq6.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq6.TabIndex = 42;
            // 
            // progressbarFreq5
            // 
            this.progressbarFreq5.Location = new System.Drawing.Point(27, 126);
            this.progressbarFreq5.Name = "progressbarFreq5";
            this.progressbarFreq5.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq5.TabIndex = 41;
            // 
            // progressbarFreq4
            // 
            this.progressbarFreq4.Location = new System.Drawing.Point(27, 101);
            this.progressbarFreq4.Name = "progressbarFreq4";
            this.progressbarFreq4.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq4.TabIndex = 40;
            // 
            // progressbarFreq3
            // 
            this.progressbarFreq3.Location = new System.Drawing.Point(27, 76);
            this.progressbarFreq3.Name = "progressbarFreq3";
            this.progressbarFreq3.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq3.TabIndex = 39;
            // 
            // progressbarFreq2
            // 
            this.progressbarFreq2.Location = new System.Drawing.Point(27, 51);
            this.progressbarFreq2.Name = "progressbarFreq2";
            this.progressbarFreq2.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq2.TabIndex = 38;
            // 
            // progressbarFreq1
            // 
            this.progressbarFreq1.Location = new System.Drawing.Point(27, 26);
            this.progressbarFreq1.Name = "progressbarFreq1";
            this.progressbarFreq1.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq1.TabIndex = 37;
            // 
            // progressbarFreq0
            // 
            this.progressbarFreq0.Location = new System.Drawing.Point(27, 1);
            this.progressbarFreq0.Name = "progressbarFreq0";
            this.progressbarFreq0.Size = new System.Drawing.Size(73, 21);
            this.progressbarFreq0.TabIndex = 36;
            // 
            // comboboxNote11
            // 
            this.comboboxNote11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote11.Enabled = false;
            this.comboboxNote11.FormattingEnabled = true;
            this.comboboxNote11.Location = new System.Drawing.Point(123, 276);
            this.comboboxNote11.Name = "comboboxNote11";
            this.comboboxNote11.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote11.TabIndex = 35;
            this.comboboxNote11.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // comboboxNote9
            // 
            this.comboboxNote9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote9.Enabled = false;
            this.comboboxNote9.FormattingEnabled = true;
            this.comboboxNote9.Location = new System.Drawing.Point(123, 224);
            this.comboboxNote9.Name = "comboboxNote9";
            this.comboboxNote9.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote9.TabIndex = 34;
            this.comboboxNote9.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // comboboxNote8
            // 
            this.comboboxNote8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote8.Enabled = false;
            this.comboboxNote8.FormattingEnabled = true;
            this.comboboxNote8.Location = new System.Drawing.Point(123, 201);
            this.comboboxNote8.Name = "comboboxNote8";
            this.comboboxNote8.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote8.TabIndex = 33;
            this.comboboxNote8.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // comboboxNote7
            // 
            this.comboboxNote7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote7.Enabled = false;
            this.comboboxNote7.FormattingEnabled = true;
            this.comboboxNote7.Location = new System.Drawing.Point(123, 176);
            this.comboboxNote7.Name = "comboboxNote7";
            this.comboboxNote7.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote7.TabIndex = 32;
            this.comboboxNote7.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // comboboxNote6
            // 
            this.comboboxNote6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote6.Enabled = false;
            this.comboboxNote6.FormattingEnabled = true;
            this.comboboxNote6.Location = new System.Drawing.Point(123, 151);
            this.comboboxNote6.Name = "comboboxNote6";
            this.comboboxNote6.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote6.TabIndex = 31;
            this.comboboxNote6.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // comboboxNote10
            // 
            this.comboboxNote10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote10.Enabled = false;
            this.comboboxNote10.FormattingEnabled = true;
            this.comboboxNote10.Location = new System.Drawing.Point(123, 251);
            this.comboboxNote10.Name = "comboboxNote10";
            this.comboboxNote10.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote10.TabIndex = 30;
            this.comboboxNote10.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // comboboxNote5
            // 
            this.comboboxNote5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote5.Enabled = false;
            this.comboboxNote5.FormattingEnabled = true;
            this.comboboxNote5.Location = new System.Drawing.Point(123, 126);
            this.comboboxNote5.Name = "comboboxNote5";
            this.comboboxNote5.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote5.TabIndex = 29;
            this.comboboxNote5.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // comboboxNote3
            // 
            this.comboboxNote3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote3.Enabled = false;
            this.comboboxNote3.FormattingEnabled = true;
            this.comboboxNote3.Location = new System.Drawing.Point(123, 76);
            this.comboboxNote3.Name = "comboboxNote3";
            this.comboboxNote3.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote3.TabIndex = 28;
            this.comboboxNote3.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // comboboxNote2
            // 
            this.comboboxNote2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote2.Enabled = false;
            this.comboboxNote2.FormattingEnabled = true;
            this.comboboxNote2.Location = new System.Drawing.Point(123, 51);
            this.comboboxNote2.Name = "comboboxNote2";
            this.comboboxNote2.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote2.TabIndex = 27;
            this.comboboxNote2.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // comboboxNote1
            // 
            this.comboboxNote1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote1.Enabled = false;
            this.comboboxNote1.FormattingEnabled = true;
            this.comboboxNote1.Location = new System.Drawing.Point(123, 26);
            this.comboboxNote1.Name = "comboboxNote1";
            this.comboboxNote1.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote1.TabIndex = 26;
            this.comboboxNote1.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // comboboxNote0
            // 
            this.comboboxNote0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote0.Enabled = false;
            this.comboboxNote0.FormattingEnabled = true;
            this.comboboxNote0.Location = new System.Drawing.Point(123, 1);
            this.comboboxNote0.Name = "comboboxNote0";
            this.comboboxNote0.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote0.TabIndex = 25;
            this.comboboxNote0.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // comboboxNote4
            // 
            this.comboboxNote4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNote4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNote4.Enabled = false;
            this.comboboxNote4.FormattingEnabled = true;
            this.comboboxNote4.Location = new System.Drawing.Point(123, 101);
            this.comboboxNote4.Name = "comboboxNote4";
            this.comboboxNote4.Size = new System.Drawing.Size(49, 21);
            this.comboboxNote4.TabIndex = 24;
            this.comboboxNote4.SelectedIndexChanged += new System.EventHandler(this.comboboxNote_SelectedIndexChanged);
            // 
            // labelNote11
            // 
            this.labelNote11.Location = new System.Drawing.Point(4, 279);
            this.labelNote11.Name = "labelNote11";
            this.labelNote11.Size = new System.Drawing.Size(25, 16);
            this.labelNote11.TabIndex = 22;
            this.labelNote11.Text = "B";
            // 
            // labelNote10
            // 
            this.labelNote10.Location = new System.Drawing.Point(4, 254);
            this.labelNote10.Name = "labelNote10";
            this.labelNote10.Size = new System.Drawing.Size(25, 16);
            this.labelNote10.TabIndex = 20;
            this.labelNote10.Text = "A#";
            // 
            // labelNote9
            // 
            this.labelNote9.Location = new System.Drawing.Point(4, 227);
            this.labelNote9.Name = "labelNote9";
            this.labelNote9.Size = new System.Drawing.Size(25, 16);
            this.labelNote9.TabIndex = 18;
            this.labelNote9.Text = "A";
            // 
            // labelNote8
            // 
            this.labelNote8.Location = new System.Drawing.Point(4, 204);
            this.labelNote8.Name = "labelNote8";
            this.labelNote8.Size = new System.Drawing.Size(25, 16);
            this.labelNote8.TabIndex = 16;
            this.labelNote8.Text = "G#";
            // 
            // labelNote7
            // 
            this.labelNote7.Location = new System.Drawing.Point(4, 179);
            this.labelNote7.Name = "labelNote7";
            this.labelNote7.Size = new System.Drawing.Size(25, 16);
            this.labelNote7.TabIndex = 14;
            this.labelNote7.Text = "G";
            // 
            // labelNote6
            // 
            this.labelNote6.Location = new System.Drawing.Point(4, 154);
            this.labelNote6.Name = "labelNote6";
            this.labelNote6.Size = new System.Drawing.Size(25, 16);
            this.labelNote6.TabIndex = 12;
            this.labelNote6.Text = "F#";
            // 
            // labelNote5
            // 
            this.labelNote5.Location = new System.Drawing.Point(4, 129);
            this.labelNote5.Name = "labelNote5";
            this.labelNote5.Size = new System.Drawing.Size(25, 16);
            this.labelNote5.TabIndex = 10;
            this.labelNote5.Text = "F";
            // 
            // labelNote4
            // 
            this.labelNote4.Location = new System.Drawing.Point(4, 104);
            this.labelNote4.Name = "labelNote4";
            this.labelNote4.Size = new System.Drawing.Size(25, 16);
            this.labelNote4.TabIndex = 8;
            this.labelNote4.Text = "E";
            // 
            // labelNote3
            // 
            this.labelNote3.Location = new System.Drawing.Point(4, 79);
            this.labelNote3.Name = "labelNote3";
            this.labelNote3.Size = new System.Drawing.Size(25, 16);
            this.labelNote3.TabIndex = 6;
            this.labelNote3.Text = "D#";
            // 
            // labelNote2
            // 
            this.labelNote2.Location = new System.Drawing.Point(4, 54);
            this.labelNote2.Name = "labelNote2";
            this.labelNote2.Size = new System.Drawing.Size(25, 16);
            this.labelNote2.TabIndex = 4;
            this.labelNote2.Text = "D";
            // 
            // labelNote1
            // 
            this.labelNote1.Location = new System.Drawing.Point(4, 29);
            this.labelNote1.Name = "labelNote1";
            this.labelNote1.Size = new System.Drawing.Size(25, 16);
            this.labelNote1.TabIndex = 2;
            this.labelNote1.Text = "C#";
            // 
            // labelNote0
            // 
            this.labelNote0.Location = new System.Drawing.Point(4, 4);
            this.labelNote0.Name = "labelNote0";
            this.labelNote0.Size = new System.Drawing.Size(25, 16);
            this.labelNote0.TabIndex = 0;
            this.labelNote0.Text = "C";
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveAll.Location = new System.Drawing.Point(599, 355);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAll.TabIndex = 38;
            this.buttonSaveAll.Text = "Save All...";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.Location = new System.Drawing.Point(518, 355);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 39;
            this.buttonExport.Text = "Export...";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 380);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.panelNotes);
            this.Controls.Add(this.VisualizerPanel);
            this.Controls.Add(this.TempoUpDown);
            this.Controls.Add(this.TempoLabel);
            this.Controls.Add(this.OutputComboBox);
            this.Controls.Add(this.DrumsCheckBox);
            this.Controls.Add(this.WrapCheckBox);
            this.Controls.Add(this.TransposeUpDown);
            this.Controls.Add(this.TransposeLabel);
            this.Controls.Add(this.LevelsUpDown);
            this.Controls.Add(this.LevelsLabel);
            this.Controls.Add(this.NormalizeCheckBox);
            this.Controls.Add(this.ResampleUpDown);
            this.Controls.Add(this.CopyTimingPatchCheckBox);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.StartCombo);
            this.Controls.Add(this.AdjustTempoCheckBox);
            this.Controls.Add(this.StretchUpDown);
            this.Controls.Add(this.MergeTracksCheckBox);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.LengthUpDown);
            this.Controls.Add(this.OffsetLabel);
            this.Controls.Add(this.OffsetUpDown);
            this.Controls.Add(this.UnitsLabel);
            this.Controls.Add(this.UnitsCombo);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.MidiFileBox);
            this.Controls.Add(this.TracksLabel);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.StretchLabel);
            this.Controls.Add(this.ResampleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(336, 419);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MIDI Editor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.OffsetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StretchUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResampleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransposeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempoUpDown)).EndInit();
            this.VisualizerPanel.ResumeLayout(false);
            this.panelNotes.ResumeLayout(false);
            this.panelNotes.PerformLayout();
            this.panelInvRefNote.ResumeLayout(false);
            this.panelInvRefNote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox TrackList;
        private System.Windows.Forms.Label TracksLabel;
        private System.Windows.Forms.TextBox MidiFileBox;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.OpenFileDialog OpenMidiFile;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Label UnitsLabel;
        private System.Windows.Forms.ComboBox UnitsCombo;
        private System.Windows.Forms.NumericUpDown OffsetUpDown;
        private System.Windows.Forms.Label OffsetLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.NumericUpDown LengthUpDown;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.SaveFileDialog SaveMidiFile;
        private System.Windows.Forms.CheckBox MergeTracksCheckBox;
        private System.Windows.Forms.Label StretchLabel;
        private System.Windows.Forms.NumericUpDown StretchUpDown;
        private System.Windows.Forms.CheckBox AdjustTempoCheckBox;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.ComboBox StartCombo;
        private System.Windows.Forms.CheckBox CopyTimingPatchCheckBox;
        private System.Windows.Forms.Label ResampleLabel;
        private System.Windows.Forms.NumericUpDown ResampleUpDown;
        private System.Windows.Forms.CheckBox NormalizeCheckBox;
        private System.Windows.Forms.Label LevelsLabel;
        private System.Windows.Forms.NumericUpDown LevelsUpDown;
        private System.Windows.Forms.NumericUpDown TransposeUpDown;
        private System.Windows.Forms.Label TransposeLabel;
        private System.Windows.Forms.CheckBox WrapCheckBox;
        private System.Windows.Forms.CheckBox DrumsCheckBox;
        private System.Windows.Forms.ComboBox OutputComboBox;
        private System.Windows.Forms.Label TempoLabel;
        private System.Windows.Forms.NumericUpDown TempoUpDown;
        private System.Windows.Forms.Panel VisualizerPanel;
        private M.MidiVisualizer Visualizer;
        private System.Windows.Forms.Panel panelNotes;
        private System.Windows.Forms.Label labelNote0;
        private System.Windows.Forms.Label labelNote1;
        private System.Windows.Forms.Label labelNote3;
        private System.Windows.Forms.Label labelNote2;
        private System.Windows.Forms.Label labelNote11;
        private System.Windows.Forms.Label labelNote10;
        private System.Windows.Forms.Label labelNote9;
        private System.Windows.Forms.Label labelNote8;
        private System.Windows.Forms.Label labelNote7;
        private System.Windows.Forms.Label labelNote6;
        private System.Windows.Forms.Label labelNote5;
        private System.Windows.Forms.Label labelNote4;
        private System.Windows.Forms.ComboBox comboboxNote4;
        private System.Windows.Forms.ComboBox comboboxNote0;
        private System.Windows.Forms.ComboBox comboboxNote11;
        private System.Windows.Forms.ComboBox comboboxNote9;
        private System.Windows.Forms.ComboBox comboboxNote8;
        private System.Windows.Forms.ComboBox comboboxNote7;
        private System.Windows.Forms.ComboBox comboboxNote6;
        private System.Windows.Forms.ComboBox comboboxNote10;
        private System.Windows.Forms.ComboBox comboboxNote5;
        private System.Windows.Forms.ComboBox comboboxNote3;
        private System.Windows.Forms.ComboBox comboboxNote2;
        private System.Windows.Forms.ComboBox comboboxNote1;
        private System.Windows.Forms.ProgressBar progressbarFreq0;
        private System.Windows.Forms.ProgressBar progressbarFreq11;
        private System.Windows.Forms.ProgressBar progressbarFreq10;
        private System.Windows.Forms.ProgressBar progressbarFreq9;
        private System.Windows.Forms.ProgressBar progressbarFreq8;
        private System.Windows.Forms.ProgressBar progressbarFreq7;
        private System.Windows.Forms.ProgressBar progressbarFreq6;
        private System.Windows.Forms.ProgressBar progressbarFreq5;
        private System.Windows.Forms.ProgressBar progressbarFreq4;
        private System.Windows.Forms.ProgressBar progressbarFreq3;
        private System.Windows.Forms.ProgressBar progressbarFreq2;
        private System.Windows.Forms.ProgressBar progressbarFreq1;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ComboBox comboboxTonicFrom;
        private System.Windows.Forms.ComboBox comboboxScaleFrom;
        private System.Windows.Forms.ComboBox comboboxScaleTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboboxTonicTo;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboboxInvNoteRefOctave;
        private System.Windows.Forms.ComboBox comboboxInvNoteRef;
        private System.Windows.Forms.Label labelInvNoteRef;
        private System.Windows.Forms.Panel panelInvRefNote;
        private System.Windows.Forms.Button buttonResetTransform;
        private System.Windows.Forms.Button buttonExport;
    }
}