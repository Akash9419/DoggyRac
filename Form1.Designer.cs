
namespace DoggyRace
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button5 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.Lovepreetbet = new System.Windows.Forms.Label();
            this.Simranbet = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.Race = new System.Windows.Forms.Button();
            this.dogNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.betsButton = new System.Windows.Forms.Button();
            this.NameOfBettorLabel = new System.Windows.Forms.Label();
            this.lovepreetradio = new System.Windows.Forms.RadioButton();
            this.simranradio = new System.Windows.Forms.RadioButton();
            this.akashradio = new System.Windows.Forms.RadioButton();
            this.MinimumBetLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Akashbet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.betNumeric = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(105, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(629, 10);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(618, 130);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset Position!";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Lovepreetbet
            // 
            this.Lovepreetbet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lovepreetbet.Location = new System.Drawing.Point(542, 77);
            this.Lovepreetbet.Name = "Lovepreetbet";
            this.Lovepreetbet.Size = new System.Drawing.Size(244, 20);
            this.Lovepreetbet.TabIndex = 13;
            this.Lovepreetbet.Text = "Lovepreet\'s Bet";
            this.Lovepreetbet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Simranbet
            // 
            this.Simranbet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Simranbet.Location = new System.Drawing.Point(542, 52);
            this.Simranbet.Name = "Simranbet";
            this.Simranbet.Size = new System.Drawing.Size(244, 20);
            this.Simranbet.TabIndex = 12;
            this.Simranbet.Text = "Simran\'s Bet";
            this.Simranbet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(105, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(629, 10);
            this.button4.TabIndex = 24;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(105, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(629, 10);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(105, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(629, 10);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Dog4
            // 
            this.Dog4.Image = ((System.Drawing.Image)(resources.GetObject("Dog4.Image")));
            this.Dog4.Location = new System.Drawing.Point(114, 186);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(76, 23);
            this.Dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog4.TabIndex = 20;
            this.Dog4.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.Image = ((System.Drawing.Image)(resources.GetObject("Dog3.Image")));
            this.Dog3.Location = new System.Drawing.Point(114, 136);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(76, 23);
            this.Dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog3.TabIndex = 19;
            this.Dog3.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.Image = ((System.Drawing.Image)(resources.GetObject("Dog2.Image")));
            this.Dog2.Location = new System.Drawing.Point(114, 82);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(76, 23);
            this.Dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog2.TabIndex = 18;
            this.Dog2.TabStop = false;
            // 
            // Dog1
            // 
            this.Dog1.Image = ((System.Drawing.Image)(resources.GetObject("Dog1.Image")));
            this.Dog1.Location = new System.Drawing.Point(114, 36);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(76, 23);
            this.Dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog1.TabIndex = 17;
            this.Dog1.TabStop = false;
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.racetrack.Location = new System.Drawing.Point(105, 17);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(630, 199);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 16;
            this.racetrack.TabStop = false;
            // 
            // Race
            // 
            this.Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race.Location = new System.Drawing.Point(699, 123);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(87, 30);
            this.Race.TabIndex = 9;
            this.Race.Text = "Race!";
            this.Race.UseVisualStyleBackColor = true;
            this.Race.Click += new System.EventHandler(this.Race_Click);
            // 
            // dogNumberNumeric
            // 
            this.dogNumberNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dogNumberNumeric.Location = new System.Drawing.Point(266, 125);
            this.dogNumberNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumberNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumberNumeric.Name = "dogNumberNumeric";
            this.dogNumberNumeric.Size = new System.Drawing.Size(54, 22);
            this.dogNumberNumeric.TabIndex = 8;
            this.dogNumberNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(106, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(629, 10);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(437, 125);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(75, 23);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // NameOfBettorLabel
            // 
            this.NameOfBettorLabel.AutoSize = true;
            this.NameOfBettorLabel.Location = new System.Drawing.Point(7, 128);
            this.NameOfBettorLabel.Name = "NameOfBettorLabel";
            this.NameOfBettorLabel.Size = new System.Drawing.Size(97, 16);
            this.NameOfBettorLabel.TabIndex = 4;
            this.NameOfBettorLabel.Text = "Who\'s Betting?";
            // 
            // lovepreetradio
            // 
            this.lovepreetradio.AutoSize = true;
            this.lovepreetradio.Location = new System.Drawing.Point(10, 89);
            this.lovepreetradio.Name = "lovepreetradio";
            this.lovepreetradio.Size = new System.Drawing.Size(87, 20);
            this.lovepreetradio.TabIndex = 3;
            this.lovepreetradio.TabStop = true;
            this.lovepreetradio.Text = "Lovepreet";
            this.lovepreetradio.UseVisualStyleBackColor = true;
            this.lovepreetradio.CheckedChanged += new System.EventHandler(this.lovepreetradio_CheckedChanged);
            // 
            // simranradio
            // 
            this.simranradio.AutoSize = true;
            this.simranradio.Location = new System.Drawing.Point(10, 66);
            this.simranradio.Name = "simranradio";
            this.simranradio.Size = new System.Drawing.Size(68, 20);
            this.simranradio.TabIndex = 2;
            this.simranradio.TabStop = true;
            this.simranradio.Text = "Simran";
            this.simranradio.UseVisualStyleBackColor = true;
            this.simranradio.CheckedChanged += new System.EventHandler(this.simranradio_CheckedChanged);
            // 
            // akashradio
            // 
            this.akashradio.AutoSize = true;
            this.akashradio.Location = new System.Drawing.Point(10, 43);
            this.akashradio.Name = "akashradio";
            this.akashradio.Size = new System.Drawing.Size(64, 20);
            this.akashradio.TabIndex = 1;
            this.akashradio.TabStop = true;
            this.akashradio.Text = "Akash";
            this.akashradio.UseVisualStyleBackColor = true;
            this.akashradio.CheckedChanged += new System.EventHandler(this.akashradio_CheckedChanged);
            // 
            // MinimumBetLabel
            // 
            this.MinimumBetLabel.AutoSize = true;
            this.MinimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumBetLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumBetLabel.Location = new System.Drawing.Point(6, 16);
            this.MinimumBetLabel.Name = "MinimumBetLabel";
            this.MinimumBetLabel.Size = new System.Drawing.Size(120, 24);
            this.MinimumBetLabel.TabIndex = 0;
            this.MinimumBetLabel.Text = "Minimum Bet";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.Lovepreetbet);
            this.groupBox1.Controls.Add(this.Simranbet);
            this.groupBox1.Controls.Add(this.Akashbet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Race);
            this.groupBox1.Controls.Add(this.dogNumberNumeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.betNumeric);
            this.groupBox1.Controls.Add(this.betsButton);
            this.groupBox1.Controls.Add(this.NameOfBettorLabel);
            this.groupBox1.Controls.Add(this.lovepreetradio);
            this.groupBox1.Controls.Add(this.simranradio);
            this.groupBox1.Controls.Add(this.akashradio);
            this.groupBox1.Controls.Add(this.MinimumBetLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(4, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 161);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting ";
            // 
            // Akashbet
            // 
            this.Akashbet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Akashbet.Location = new System.Drawing.Point(542, 27);
            this.Akashbet.Name = "Akashbet";
            this.Akashbet.Size = new System.Drawing.Size(244, 20);
            this.Akashbet.TabIndex = 11;
            this.Akashbet.Text = "Akash\'s Bet";
            this.Akashbet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 109);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = " dog number";
            // 
            // betNumeric
            // 
            this.betNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.betNumeric.Location = new System.Drawing.Point(110, 126);
            this.betNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.betNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betNumeric.Name = "betNumeric";
            this.betNumeric.Size = new System.Drawing.Size(54, 22);
            this.betNumeric.TabIndex = 6;
            this.betNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(105, 120);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(629, 10);
            this.button6.TabIndex = 26;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 110);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.racetrack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label Lovepreetbet;
        private System.Windows.Forms.Label Simranbet;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.Button Race;
        private System.Windows.Forms.NumericUpDown dogNumberNumeric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label NameOfBettorLabel;
        private System.Windows.Forms.RadioButton lovepreetradio;
        private System.Windows.Forms.RadioButton simranradio;
        private System.Windows.Forms.RadioButton akashradio;
        private System.Windows.Forms.Label MinimumBetLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Akashbet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown betNumeric;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

