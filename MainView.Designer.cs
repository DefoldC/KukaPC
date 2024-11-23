namespace MxAutomation_Example{
	partial class MainView {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.cycle = new System.Windows.Forms.Timer(this.components);
            this.tbDebug = new System.Windows.Forms.TextBox();
            this.tbAxisGroupRef = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bReset = new System.Windows.Forms.Button();
            this.cbMoveEnable = new System.Windows.Forms.CheckBox();
            this.tbOverride = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bMoveToPos2 = new System.Windows.Forms.Button();
            this.bMoveToPos1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lErrorID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_headline = new System.Windows.Forms.Label();
            this.button_closeme = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.bChangeKukFile = new System.Windows.Forms.Button();
            this.openKukaFile = new System.Windows.Forms.OpenFileDialog();
            this.bStartReadKukFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOverride)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bStart, "bStart");
            this.bStart.Name = "bStart";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bStop, "bStop");
            this.bStop.Name = "bStop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // cycle
            // 
            this.cycle.Interval = 2;
            this.cycle.Tick += new System.EventHandler(this.cycle_Tick);
            // 
            // tbDebug
            // 
            resources.ApplyResources(this.tbDebug, "tbDebug");
            this.tbDebug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDebug.Name = "tbDebug";
            // 
            // tbAxisGroupRef
            // 
            resources.ApplyResources(this.tbAxisGroupRef, "tbAxisGroupRef");
            this.tbAxisGroupRef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAxisGroupRef.Name = "tbAxisGroupRef";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bStart);
            this.groupBox1.Controls.Add(this.bStop);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bReset);
            this.groupBox2.Controls.Add(this.cbMoveEnable);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // bReset
            // 
            this.bReset.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bReset, "bReset");
            this.bReset.Name = "bReset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // cbMoveEnable
            // 
            resources.ApplyResources(this.cbMoveEnable, "cbMoveEnable");
            this.cbMoveEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMoveEnable.Name = "cbMoveEnable";
            this.cbMoveEnable.UseVisualStyleBackColor = true;
            this.cbMoveEnable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.cbMoveEnable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // tbOverride
            // 
            resources.ApplyResources(this.tbOverride, "tbOverride");
            this.tbOverride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.tbOverride.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbOverride.LargeChange = 10;
            this.tbOverride.Maximum = 100;
            this.tbOverride.Name = "tbOverride";
            this.tbOverride.Value = 10;
            this.tbOverride.Scroll += new System.EventHandler(this.tbOverride_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bStartReadKukFile);
            this.groupBox3.Controls.Add(this.bChangeKukFile);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.bMoveToPos2);
            this.groupBox3.Controls.Add(this.bMoveToPos1);
            this.groupBox3.Controls.Add(this.tbOverride);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox9
            // 
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.Name = "textBox9";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.label12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.label14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox12
            // 
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // bMoveToPos2
            // 
            this.bMoveToPos2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bMoveToPos2, "bMoveToPos2");
            this.bMoveToPos2.Name = "bMoveToPos2";
            this.bMoveToPos2.UseVisualStyleBackColor = true;
            this.bMoveToPos2.Click += new System.EventHandler(this.bMoveToPos2_Click);
            // 
            // bMoveToPos1
            // 
            this.bMoveToPos1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bMoveToPos1, "bMoveToPos1");
            this.bMoveToPos1.Name = "bMoveToPos1";
            this.bMoveToPos1.UseVisualStyleBackColor = true;
            this.bMoveToPos1.Click += new System.EventHandler(this.bMoveToPos1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lErrorID);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // lErrorID
            // 
            resources.ApplyResources(this.lErrorID, "lErrorID");
            this.lErrorID.Name = "lErrorID";
            this.lErrorID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.lErrorID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // label_version
            // 
            resources.ApplyResources(this.label_version, "label_version");
            this.label_version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.label_version.ForeColor = System.Drawing.Color.White;
            this.label_version.Name = "label_version";
            this.label_version.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label_version.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // label_headline
            // 
            this.label_headline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.label_headline, "label_headline");
            this.label_headline.ForeColor = System.Drawing.Color.White;
            this.label_headline.Name = "label_headline";
            this.label_headline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.label_headline.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            // 
            // button_closeme
            // 
            this.button_closeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_closeme.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button_closeme, "button_closeme");
            this.button_closeme.Name = "button_closeme";
            this.button_closeme.Click += new System.EventHandler(this.button_closeme_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox13);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // textBox13
            // 
            resources.ApplyResources(this.textBox13, "textBox13");
            this.textBox13.Name = "textBox13";
            // 
            // bChangeKukFile
            // 
            this.bChangeKukFile.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bChangeKukFile, "bChangeKukFile");
            this.bChangeKukFile.Name = "bChangeKukFile";
            this.bChangeKukFile.UseVisualStyleBackColor = true;
            this.bChangeKukFile.Click += new System.EventHandler(this.buttonOpenKukaFile_Click);
            // 
            // openKukaFile
            // 
            this.openKukaFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openKukaFile_FileOk);
            // 
            // bStartReadKukFile
            // 
            this.bStartReadKukFile.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.bStartReadKukFile, "bStartReadKukFile");
            this.bStartReadKukFile.Name = "bStartReadKukFile";
            this.bStartReadKukFile.UseVisualStyleBackColor = true;
            this.bStartReadKukFile.Click += new System.EventHandler(this.buttonReadKukaFile_Click);
            // 
            // MainView
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_closeme);
            this.Controls.Add(this.label_headline);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbAxisGroupRef);
            this.Controls.Add(this.tbDebug);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainView_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOverride)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bStart;
		private System.Windows.Forms.Button bStop;
		private System.Windows.Forms.Timer cycle;
		private System.Windows.Forms.TextBox tbDebug;
		private System.Windows.Forms.TextBox tbAxisGroupRef;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.CheckBox cbMoveEnable;
		private System.Windows.Forms.TrackBar tbOverride;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button bMoveToPos2;
		private System.Windows.Forms.Button bMoveToPos1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lErrorID;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_headline;
        private System.Windows.Forms.Label button_closeme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bChangeKukFile;
        private System.Windows.Forms.OpenFileDialog openKukaFile;
        private System.Windows.Forms.Button bStartReadKukFile;
    }
}

