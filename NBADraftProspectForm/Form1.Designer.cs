namespace NBADraftProspectForm
{
    partial class frmPlayerInfo
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
            this.gbIdentity = new System.Windows.Forms.GroupBox();
            this.lnameText = new System.Windows.Forms.TextBox();
            this.fnameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fnameField = new System.Windows.Forms.Label();
            this.gbSchool = new System.Windows.Forms.GroupBox();
            this.collegeLevel = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eduLevel = new System.Windows.Forms.ComboBox();
            this.collegeName = new System.Windows.Forms.TextBox();
            this.nameSchool = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.scoutingReport = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.posCheckBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.weightPounds = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.GroupBox();
            this.heightInches = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.heightFeet = new System.Windows.Forms.NumericUpDown();
            this.notes = new System.Windows.Forms.Label();
            this.addNotes = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbIdentity.SuspendLayout();
            this.gbSchool.SuspendLayout();
            this.scoutingReport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.height.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightInches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightFeet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIdentity
            // 
            this.gbIdentity.Controls.Add(this.lnameText);
            this.gbIdentity.Controls.Add(this.fnameText);
            this.gbIdentity.Controls.Add(this.label1);
            this.gbIdentity.Controls.Add(this.fnameField);
            this.gbIdentity.Location = new System.Drawing.Point(12, 97);
            this.gbIdentity.Name = "gbIdentity";
            this.gbIdentity.Size = new System.Drawing.Size(353, 99);
            this.gbIdentity.TabIndex = 0;
            this.gbIdentity.TabStop = false;
            this.gbIdentity.Text = "Identfiers";
            // 
            // lnameText
            // 
            this.lnameText.Location = new System.Drawing.Point(179, 42);
            this.lnameText.Name = "lnameText";
            this.lnameText.Size = new System.Drawing.Size(148, 22);
            this.lnameText.TabIndex = 3;
            // 
            // fnameText
            // 
            this.fnameText.Location = new System.Drawing.Point(7, 42);
            this.fnameText.Name = "fnameText";
            this.fnameText.Size = new System.Drawing.Size(148, 22);
            this.fnameText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name";
            // 
            // fnameField
            // 
            this.fnameField.AutoSize = true;
            this.fnameField.Location = new System.Drawing.Point(1, 22);
            this.fnameField.Name = "fnameField";
            this.fnameField.Size = new System.Drawing.Size(72, 16);
            this.fnameField.TabIndex = 0;
            this.fnameField.Text = "First Name";
            // 
            // gbSchool
            // 
            this.gbSchool.Controls.Add(this.collegeLevel);
            this.gbSchool.Controls.Add(this.label3);
            this.gbSchool.Controls.Add(this.label2);
            this.gbSchool.Controls.Add(this.eduLevel);
            this.gbSchool.Controls.Add(this.collegeName);
            this.gbSchool.Controls.Add(this.nameSchool);
            this.gbSchool.Location = new System.Drawing.Point(12, 202);
            this.gbSchool.Name = "gbSchool";
            this.gbSchool.Size = new System.Drawing.Size(353, 264);
            this.gbSchool.TabIndex = 2;
            this.gbSchool.TabStop = false;
            this.gbSchool.Text = "School Information";
            // 
            // collegeLevel
            // 
            this.collegeLevel.FormattingEnabled = true;
            this.collegeLevel.ItemHeight = 16;
            this.collegeLevel.Items.AddRange(new object[] {
            "Divsion I",
            "Division II",
            "Division III",
            "Other"});
            this.collegeLevel.Location = new System.Drawing.Point(7, 104);
            this.collegeLevel.Name = "collegeLevel";
            this.collegeLevel.Size = new System.Drawing.Size(120, 68);
            this.collegeLevel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Division Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eduLevel
            // 
            this.eduLevel.FormattingEnabled = true;
            this.eduLevel.Items.AddRange(new object[] {
            "Fr.",
            "So.",
            "Jr.",
            "Sr."});
            this.eduLevel.Location = new System.Drawing.Point(277, 40);
            this.eduLevel.Name = "eduLevel";
            this.eduLevel.Size = new System.Drawing.Size(50, 24);
            this.eduLevel.TabIndex = 2;
            this.eduLevel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // collegeName
            // 
            this.collegeName.Location = new System.Drawing.Point(7, 42);
            this.collegeName.Name = "collegeName";
            this.collegeName.Size = new System.Drawing.Size(241, 22);
            this.collegeName.TabIndex = 1;
            // 
            // nameSchool
            // 
            this.nameSchool.AutoSize = true;
            this.nameSchool.Location = new System.Drawing.Point(4, 22);
            this.nameSchool.Name = "nameSchool";
            this.nameSchool.Size = new System.Drawing.Size(106, 16);
            this.nameSchool.TabIndex = 0;
            this.nameSchool.Text = "University Name";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(316, 481);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(146, 42);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // scoutingReport
            // 
            this.scoutingReport.Controls.Add(this.groupBox2);
            this.scoutingReport.Controls.Add(this.groupBox1);
            this.scoutingReport.Controls.Add(this.height);
            this.scoutingReport.Controls.Add(this.notes);
            this.scoutingReport.Controls.Add(this.addNotes);
            this.scoutingReport.Location = new System.Drawing.Point(393, 98);
            this.scoutingReport.Name = "scoutingReport";
            this.scoutingReport.Size = new System.Drawing.Size(362, 368);
            this.scoutingReport.TabIndex = 4;
            this.scoutingReport.TabStop = false;
            this.scoutingReport.Text = "Scouting Report";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.posCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position(s)";
            // 
            // posCheckBox
            // 
            this.posCheckBox.FormattingEnabled = true;
            this.posCheckBox.Items.AddRange(new object[] {
            "Point Guard",
            "Shooting Guard",
            "Small Forward",
            "Power Forward",
            "Center"});
            this.posCheckBox.Location = new System.Drawing.Point(6, 23);
            this.posCheckBox.Name = "posCheckBox";
            this.posCheckBox.Size = new System.Drawing.Size(262, 123);
            this.posCheckBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.weightPounds);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(175, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weight";
            // 
            // weightPounds
            // 
            this.weightPounds.Location = new System.Drawing.Point(6, 25);
            this.weightPounds.Name = "weightPounds";
            this.weightPounds.Size = new System.Drawing.Size(44, 22);
            this.weightPounds.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "lbs.";
            // 
            // height
            // 
            this.height.Controls.Add(this.heightInches);
            this.height.Controls.Add(this.label5);
            this.height.Controls.Add(this.label4);
            this.height.Controls.Add(this.heightFeet);
            this.height.Location = new System.Drawing.Point(6, 22);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(142, 58);
            this.height.TabIndex = 2;
            this.height.TabStop = false;
            this.height.Text = "Height";
            // 
            // heightInches
            // 
            this.heightInches.Location = new System.Drawing.Point(69, 21);
            this.heightInches.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.heightInches.Name = "heightInches";
            this.heightInches.Size = new System.Drawing.Size(45, 22);
            this.heightInches.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "ft";
            // 
            // heightFeet
            // 
            this.heightFeet.Location = new System.Drawing.Point(7, 21);
            this.heightFeet.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.heightFeet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.heightFeet.Name = "heightFeet";
            this.heightFeet.Size = new System.Drawing.Size(37, 22);
            this.heightFeet.TabIndex = 0;
            this.heightFeet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Location = new System.Drawing.Point(7, 244);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(106, 16);
            this.notes.TabIndex = 1;
            this.notes.Text = "Additional Notes";
            // 
            // addNotes
            // 
            this.addNotes.Location = new System.Drawing.Point(6, 266);
            this.addNotes.Name = "addNotes";
            this.addNotes.Size = new System.Drawing.Size(350, 96);
            this.addNotes.TabIndex = 0;
            this.addNotes.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmPlayerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.scoutingReport);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.gbSchool);
            this.Controls.Add(this.gbIdentity);
            this.Name = "frmPlayerInfo";
            this.Text = "NBA Draft Scouting";
            this.Load += new System.EventHandler(this.Form_Load);
            this.gbIdentity.ResumeLayout(false);
            this.gbIdentity.PerformLayout();
            this.gbSchool.ResumeLayout(false);
            this.gbSchool.PerformLayout();
            this.scoutingReport.ResumeLayout(false);
            this.scoutingReport.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.height.ResumeLayout(false);
            this.height.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightInches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightFeet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIdentity;
        private System.Windows.Forms.Label fnameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fnameText;
        private System.Windows.Forms.TextBox lnameText;
        private System.Windows.Forms.GroupBox gbSchool;
        private System.Windows.Forms.Label nameSchool;
        private System.Windows.Forms.TextBox collegeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox eduLevel;
        private System.Windows.Forms.ListBox collegeLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox scoutingReport;
        private System.Windows.Forms.GroupBox height;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.RichTextBox addNotes;
        private System.Windows.Forms.NumericUpDown heightInches;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown heightFeet;
        private System.Windows.Forms.TextBox weightPounds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox posCheckBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
