namespace Hang_Man_game
{
    partial class GAMEFORM
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
            this.hangMan = new System.Windows.Forms.PictureBox();
            this.lblShowWord = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Time_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangMan)).BeginInit();
            this.SuspendLayout();
            // 
            // hangMan
            // 
            this.hangMan.Image = global::Hang_Man_game.Properties.Resources.Hang_man_1;
            this.hangMan.Location = new System.Drawing.Point(204, 12);
            this.hangMan.Name = "hangMan";
            this.hangMan.Size = new System.Drawing.Size(528, 431);
            this.hangMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangMan.TabIndex = 1;
            this.hangMan.TabStop = false;
            this.hangMan.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblShowWord
            // 
            this.lblShowWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowWord.Location = new System.Drawing.Point(309, 458);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.Size = new System.Drawing.Size(304, 37);
            this.lblShowWord.TabIndex = 2;
            this.lblShowWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(135, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.guessClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(276, 596);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "K";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.guessClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(204, 596);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "J";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.guessClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(135, 596);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 43);
            this.button4.TabIndex = 6;
            this.button4.Text = "I";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.guessClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(695, 522);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 43);
            this.button5.TabIndex = 7;
            this.button5.Text = "H";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.guessClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(599, 522);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 43);
            this.button6.TabIndex = 8;
            this.button6.Text = "G";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.guessClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(516, 522);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 43);
            this.button7.TabIndex = 9;
            this.button7.Text = "F";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.guessClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(436, 522);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 43);
            this.button8.TabIndex = 10;
            this.button8.Text = "E";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.guessClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(359, 522);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 43);
            this.button9.TabIndex = 11;
            this.button9.Text = "D";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.guessClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(276, 522);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(52, 43);
            this.button10.TabIndex = 12;
            this.button10.Text = "C";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.guessClick);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(204, 522);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(52, 43);
            this.button11.TabIndex = 13;
            this.button11.Text = "B";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.guessClick);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(135, 660);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(52, 43);
            this.button12.TabIndex = 14;
            this.button12.Text = "Q";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.guessClick);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(695, 596);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(52, 43);
            this.button13.TabIndex = 15;
            this.button13.Text = "P";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.guessClick);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(599, 596);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(52, 43);
            this.button14.TabIndex = 16;
            this.button14.Text = "O";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.guessClick);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(516, 596);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(52, 43);
            this.button15.TabIndex = 17;
            this.button15.Text = "N";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.guessClick);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(436, 596);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(52, 43);
            this.button16.TabIndex = 18;
            this.button16.Text = "M";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.guessClick);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(359, 596);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(52, 43);
            this.button17.TabIndex = 19;
            this.button17.Text = "L";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.guessClick);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(204, 660);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(52, 43);
            this.button18.TabIndex = 20;
            this.button18.Text = "R";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.guessClick);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(276, 660);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(52, 43);
            this.button19.TabIndex = 21;
            this.button19.Text = "S";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.guessClick);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(359, 660);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(52, 43);
            this.button20.TabIndex = 22;
            this.button20.Text = "T";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.guessClick);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(436, 660);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(52, 43);
            this.button21.TabIndex = 23;
            this.button21.Text = "U";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.guessClick);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(516, 660);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(52, 43);
            this.button22.TabIndex = 24;
            this.button22.Text = "V";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.guessClick);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(599, 660);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(52, 43);
            this.button23.TabIndex = 25;
            this.button23.Text = "W";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.guessClick);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(695, 660);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(52, 43);
            this.button24.TabIndex = 26;
            this.button24.Text = "X";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.guessClick);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(135, 720);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(52, 43);
            this.button26.TabIndex = 28;
            this.button26.Text = "Y";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.guessClick);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(204, 720);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(52, 43);
            this.button27.TabIndex = 29;
            this.button27.Text = "Z";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.guessClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "Player name : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Label.Location = new System.Drawing.Point(72, 83);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(0, 20);
            this.ID_Label.TabIndex = 31;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 37);
            this.label2.TabIndex = 32;
            this.label2.Text = "Time : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time_label
            // 
            this.Time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_label.Location = new System.Drawing.Point(57, 206);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(76, 37);
            this.Time_label.TabIndex = 33;
            this.Time_label.Text = "0:00";
            this.Time_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GAMEFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::Hang_Man_game.Properties.Resources.b1;
            this.ClientSize = new System.Drawing.Size(804, 766);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.hangMan);
            this.Name = "GAMEFORM";
            this.Text = "GAMEFORM";
            this.Load += new System.EventHandler(this.GAMEFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox hangMan;
        private System.Windows.Forms.Label lblShowWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID_Label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Time_label;
    }
}