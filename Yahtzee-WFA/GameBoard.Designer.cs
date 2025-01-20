namespace Yahtzee_WFA
{
    partial class GameBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBoxDice1 = new PictureBox();
            btnRollDice = new Button();
            PictureBoxDice2 = new PictureBox();
            PictureBoxDice3 = new PictureBox();
            PictureBoxDice4 = new PictureBox();
            PictureBoxDice5 = new PictureBox();
            PictureBoxDice6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice6).BeginInit();
            SuspendLayout();
            // 
            // PictureBoxDice1
            // 
            PictureBoxDice1.Location = new Point(71, 46);
            PictureBoxDice1.Name = "PictureBoxDice1";
            PictureBoxDice1.Size = new Size(159, 145);
            PictureBoxDice1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxDice1.TabIndex = 0;
            PictureBoxDice1.TabStop = false;
            PictureBoxDice1.Click += pictureBox1_Click;
            // 
            // btnRollDice
            // 
            btnRollDice.Location = new Point(214, 404);
            btnRollDice.Name = "btnRollDice";
            btnRollDice.Size = new Size(293, 58);
            btnRollDice.TabIndex = 1;
            btnRollDice.Text = "Roll the dice";
            btnRollDice.UseVisualStyleBackColor = true;
            btnRollDice.Click += btnRollDice_Click;
            // 
            // PictureBoxDice2
            // 
            PictureBoxDice2.Location = new Point(288, 46);
            PictureBoxDice2.Name = "PictureBoxDice2";
            PictureBoxDice2.Size = new Size(159, 145);
            PictureBoxDice2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxDice2.TabIndex = 2;
            PictureBoxDice2.TabStop = false;
            // 
            // PictureBoxDice3
            // 
            PictureBoxDice3.Location = new Point(512, 46);
            PictureBoxDice3.Name = "PictureBoxDice3";
            PictureBoxDice3.Size = new Size(159, 145);
            PictureBoxDice3.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxDice3.TabIndex = 3;
            PictureBoxDice3.TabStop = false;
            // 
            // PictureBoxDice4
            // 
            PictureBoxDice4.Location = new Point(71, 229);
            PictureBoxDice4.Name = "PictureBoxDice4";
            PictureBoxDice4.Size = new Size(159, 145);
            PictureBoxDice4.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxDice4.TabIndex = 4;
            PictureBoxDice4.TabStop = false;
            // 
            // PictureBoxDice5
            // 
            PictureBoxDice5.Location = new Point(288, 229);
            PictureBoxDice5.Name = "PictureBoxDice5";
            PictureBoxDice5.Size = new Size(159, 145);
            PictureBoxDice5.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxDice5.TabIndex = 5;
            PictureBoxDice5.TabStop = false;
            // 
            // PictureBoxDice6
            // 
            PictureBoxDice6.Location = new Point(512, 229);
            PictureBoxDice6.Name = "PictureBoxDice6";
            PictureBoxDice6.Size = new Size(159, 145);
            PictureBoxDice6.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxDice6.TabIndex = 6;
            PictureBoxDice6.TabStop = false;
            // 
            // GameBoard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 499);
            Controls.Add(PictureBoxDice6);
            Controls.Add(PictureBoxDice5);
            Controls.Add(PictureBoxDice4);
            Controls.Add(PictureBoxDice3);
            Controls.Add(PictureBoxDice2);
            Controls.Add(btnRollDice);
            Controls.Add(PictureBoxDice1);
            Name = "GameBoard";
            Text = "GameBoard";
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice5).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxDice6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox PictureBoxDice1;
        private Button btnRollDice;
        public PictureBox PictureBoxDice2;
        public PictureBox PictureBoxDice3;
        public PictureBox PictureBoxDice4;
        public PictureBox PictureBoxDice5;
        public PictureBox PictureBoxDice6;
    }
}
