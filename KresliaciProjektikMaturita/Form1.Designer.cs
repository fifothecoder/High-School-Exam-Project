namespace KresliaciProjektikMaturita
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbQuadratic = new System.Windows.Forms.GroupBox();
            this.lQuadratic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numQC = new System.Windows.Forms.NumericUpDown();
            this.numQB = new System.Windows.Forms.NumericUpDown();
            this.numQA = new System.Windows.Forms.NumericUpDown();
            this.btnQuadratic = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lDayAnswer = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.lMonth = new System.Windows.Forms.Label();
            this.lDay = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnFileReverse = new System.Windows.Forms.Button();
            this.btnFileRandom = new System.Windows.Forms.Button();
            this.btnFileClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAngle = new System.Windows.Forms.Button();
            this.gbAngle = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lAngleAnswer = new System.Windows.Forms.Label();
            this.lAngleH = new System.Windows.Forms.Label();
            this.numAngleHours = new System.Windows.Forms.NumericUpDown();
            this.numAngleMinutes = new System.Windows.Forms.NumericUpDown();
            this.gbDraw = new System.Windows.Forms.GroupBox();
            this.btnClock = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnMotionPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbQuadratic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbAngle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAngleHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngleMinutes)).BeginInit();
            this.gbDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbQuadratic
            // 
            this.gbQuadratic.Controls.Add(this.lQuadratic);
            this.gbQuadratic.Controls.Add(this.label3);
            this.gbQuadratic.Controls.Add(this.label2);
            this.gbQuadratic.Controls.Add(this.label1);
            this.gbQuadratic.Controls.Add(this.numQC);
            this.gbQuadratic.Controls.Add(this.numQB);
            this.gbQuadratic.Controls.Add(this.numQA);
            this.gbQuadratic.Controls.Add(this.btnQuadratic);
            this.gbQuadratic.Location = new System.Drawing.Point(586, 12);
            this.gbQuadratic.Name = "gbQuadratic";
            this.gbQuadratic.Size = new System.Drawing.Size(389, 107);
            this.gbQuadratic.TabIndex = 1;
            this.gbQuadratic.TabStop = false;
            this.gbQuadratic.Text = "Kvadratické rovnice";
            // 
            // lQuadratic
            // 
            this.lQuadratic.AutoSize = true;
            this.lQuadratic.Location = new System.Drawing.Point(19, 85);
            this.lQuadratic.Name = "lQuadratic";
            this.lQuadratic.Size = new System.Drawing.Size(59, 13);
            this.lQuadratic.TabIndex = 7;
            this.lQuadratic.Text = "Výsledok : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "C :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "B :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A :";
            // 
            // numQC
            // 
            this.numQC.Location = new System.Drawing.Point(292, 19);
            this.numQC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQC.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numQC.Name = "numQC";
            this.numQC.Size = new System.Drawing.Size(91, 20);
            this.numQC.TabIndex = 3;
            // 
            // numQB
            // 
            this.numQB.Location = new System.Drawing.Point(169, 19);
            this.numQB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQB.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numQB.Name = "numQB";
            this.numQB.Size = new System.Drawing.Size(91, 20);
            this.numQB.TabIndex = 2;
            // 
            // numQA
            // 
            this.numQA.Location = new System.Drawing.Point(45, 19);
            this.numQA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQA.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numQA.Name = "numQA";
            this.numQA.Size = new System.Drawing.Size(91, 20);
            this.numQA.TabIndex = 1;
            // 
            // btnQuadratic
            // 
            this.btnQuadratic.Location = new System.Drawing.Point(22, 45);
            this.btnQuadratic.Name = "btnQuadratic";
            this.btnQuadratic.Size = new System.Drawing.Size(140, 37);
            this.btnQuadratic.TabIndex = 0;
            this.btnQuadratic.Text = "Vyrátaj";
            this.btnQuadratic.UseVisualStyleBackColor = true;
            this.btnQuadratic.Click += new System.EventHandler(this.btnQuadratic_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lDayAnswer);
            this.groupBox1.Controls.Add(this.lYear);
            this.groupBox1.Controls.Add(this.lMonth);
            this.groupBox1.Controls.Add(this.lDay);
            this.groupBox1.Controls.Add(this.numYear);
            this.groupBox1.Controls.Add(this.numMonth);
            this.groupBox1.Controls.Add(this.numDay);
            this.groupBox1.Controls.Add(this.btnDay);
            this.groupBox1.Location = new System.Drawing.Point(586, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 90);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontrola dní";
            // 
            // lDayAnswer
            // 
            this.lDayAnswer.AutoSize = true;
            this.lDayAnswer.Location = new System.Drawing.Point(166, 57);
            this.lDayAnswer.Name = "lDayAnswer";
            this.lDayAnswer.Size = new System.Drawing.Size(59, 13);
            this.lDayAnswer.TabIndex = 7;
            this.lDayAnswer.Text = "Výsledok : ";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(247, 21);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(33, 13);
            this.lYear.TabIndex = 6;
            this.lYear.Text = "Rok :";
            // 
            // lMonth
            // 
            this.lMonth.AutoSize = true;
            this.lMonth.Location = new System.Drawing.Point(117, 21);
            this.lMonth.Name = "lMonth";
            this.lMonth.Size = new System.Drawing.Size(47, 13);
            this.lMonth.TabIndex = 5;
            this.lMonth.Text = "Mesiac :";
            // 
            // lDay
            // 
            this.lDay.AutoSize = true;
            this.lDay.Location = new System.Drawing.Point(6, 21);
            this.lDay.Name = "lDay";
            this.lDay.Size = new System.Drawing.Size(33, 13);
            this.lDay.TabIndex = 4;
            this.lDay.Text = "Deň :";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(286, 19);
            this.numYear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(91, 20);
            this.numYear.TabIndex = 3;
            this.numYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(169, 19);
            this.numMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(72, 20);
            this.numMonth.TabIndex = 2;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDay
            // 
            this.numDay.Location = new System.Drawing.Point(45, 19);
            this.numDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(66, 20);
            this.numDay.TabIndex = 1;
            this.numDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(9, 45);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(140, 37);
            this.btnDay.TabIndex = 0;
            this.btnDay.Text = "Vyrátaj";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnFileReverse
            // 
            this.btnFileReverse.Location = new System.Drawing.Point(9, 19);
            this.btnFileReverse.Name = "btnFileReverse";
            this.btnFileReverse.Size = new System.Drawing.Size(111, 35);
            this.btnFileReverse.TabIndex = 9;
            this.btnFileReverse.Text = "Opačné poradie";
            this.btnFileReverse.UseVisualStyleBackColor = true;
            this.btnFileReverse.Click += new System.EventHandler(this.btnFileReverse_Click);
            // 
            // btnFileRandom
            // 
            this.btnFileRandom.Location = new System.Drawing.Point(130, 19);
            this.btnFileRandom.Name = "btnFileRandom";
            this.btnFileRandom.Size = new System.Drawing.Size(111, 35);
            this.btnFileRandom.TabIndex = 10;
            this.btnFileRandom.Text = "Náhodné poradie";
            this.btnFileRandom.UseVisualStyleBackColor = true;
            this.btnFileRandom.Click += new System.EventHandler(this.btnFileRandom_Click);
            // 
            // btnFileClear
            // 
            this.btnFileClear.Location = new System.Drawing.Point(250, 19);
            this.btnFileClear.Name = "btnFileClear";
            this.btnFileClear.Size = new System.Drawing.Size(111, 35);
            this.btnFileClear.TabIndex = 11;
            this.btnFileClear.Text = "Vynechané prázdne riadky";
            this.btnFileClear.UseVisualStyleBackColor = true;
            this.btnFileClear.Click += new System.EventHandler(this.btnFileClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFileReverse);
            this.groupBox2.Controls.Add(this.btnFileClear);
            this.groupBox2.Controls.Add(this.btnFileRandom);
            this.groupBox2.Location = new System.Drawing.Point(586, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 68);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Práca so súborom";
            // 
            // btnAngle
            // 
            this.btnAngle.Location = new System.Drawing.Point(201, 19);
            this.btnAngle.Name = "btnAngle";
            this.btnAngle.Size = new System.Drawing.Size(83, 30);
            this.btnAngle.TabIndex = 13;
            this.btnAngle.Text = "Vyrátaj uhol";
            this.btnAngle.UseVisualStyleBackColor = true;
            this.btnAngle.Click += new System.EventHandler(this.btnAngle_Click);
            // 
            // gbAngle
            // 
            this.gbAngle.Controls.Add(this.label4);
            this.gbAngle.Controls.Add(this.lAngleAnswer);
            this.gbAngle.Controls.Add(this.lAngleH);
            this.gbAngle.Controls.Add(this.numAngleHours);
            this.gbAngle.Controls.Add(this.numAngleMinutes);
            this.gbAngle.Controls.Add(this.btnAngle);
            this.gbAngle.Location = new System.Drawing.Point(586, 212);
            this.gbAngle.Name = "gbAngle";
            this.gbAngle.Size = new System.Drawing.Size(389, 56);
            this.gbAngle.TabIndex = 14;
            this.gbAngle.TabStop = false;
            this.gbAngle.Text = "Uhol ručičiek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Minúty :";
            // 
            // lAngleAnswer
            // 
            this.lAngleAnswer.AutoSize = true;
            this.lAngleAnswer.Location = new System.Drawing.Point(290, 28);
            this.lAngleAnswer.Name = "lAngleAnswer";
            this.lAngleAnswer.Size = new System.Drawing.Size(35, 13);
            this.lAngleAnswer.TabIndex = 17;
            this.lAngleAnswer.Text = "Uhol :";
            // 
            // lAngleH
            // 
            this.lAngleH.AutoSize = true;
            this.lAngleH.Location = new System.Drawing.Point(6, 28);
            this.lAngleH.Name = "lAngleH";
            this.lAngleH.Size = new System.Drawing.Size(46, 13);
            this.lAngleH.TabIndex = 16;
            this.lAngleH.Text = "Hodiny :";
            // 
            // numAngleHours
            // 
            this.numAngleHours.Location = new System.Drawing.Point(55, 26);
            this.numAngleHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numAngleHours.Name = "numAngleHours";
            this.numAngleHours.Size = new System.Drawing.Size(42, 20);
            this.numAngleHours.TabIndex = 15;
            this.numAngleHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numAngleMinutes
            // 
            this.numAngleMinutes.Location = new System.Drawing.Point(153, 26);
            this.numAngleMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numAngleMinutes.Name = "numAngleMinutes";
            this.numAngleMinutes.Size = new System.Drawing.Size(42, 20);
            this.numAngleMinutes.TabIndex = 14;
            this.numAngleMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbDraw
            // 
            this.gbDraw.Controls.Add(this.btnClock);
            this.gbDraw.Controls.Add(this.btnCircle);
            this.gbDraw.Controls.Add(this.btnMotionPoint);
            this.gbDraw.Location = new System.Drawing.Point(586, 125);
            this.gbDraw.Name = "gbDraw";
            this.gbDraw.Size = new System.Drawing.Size(389, 81);
            this.gbDraw.TabIndex = 15;
            this.gbDraw.TabStop = false;
            this.gbDraw.Text = "Kreslenie";
            // 
            // btnClock
            // 
            this.btnClock.Location = new System.Drawing.Point(249, 30);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(112, 35);
            this.btnClock.TabIndex = 2;
            this.btnClock.Text = "Pohyb ručičiek";
            this.btnClock.UseVisualStyleBackColor = true;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(130, 30);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(113, 35);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Text = "Vznik kruhu";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnMotionPoint
            // 
            this.btnMotionPoint.Location = new System.Drawing.Point(9, 30);
            this.btnMotionPoint.Name = "btnMotionPoint";
            this.btnMotionPoint.Size = new System.Drawing.Size(114, 35);
            this.btnMotionPoint.TabIndex = 0;
            this.btnMotionPoint.Text = "Pohyb hmotného bodu";
            this.btnMotionPoint.UseVisualStyleBackColor = true;
            this.btnMotionPoint.Click += new System.EventHandler(this.btnMotionPoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.gbDraw);
            this.Controls.Add(this.gbAngle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbQuadratic);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Kreslime si";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbQuadratic.ResumeLayout(false);
            this.gbQuadratic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbAngle.ResumeLayout(false);
            this.gbAngle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAngleHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngleMinutes)).EndInit();
            this.gbDraw.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbQuadratic;
        private System.Windows.Forms.Label lQuadratic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numQC;
        private System.Windows.Forms.NumericUpDown numQB;
        private System.Windows.Forms.NumericUpDown numQA;
        private System.Windows.Forms.Button btnQuadratic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lDayAnswer;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label lMonth;
        private System.Windows.Forms.Label lDay;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.NumericUpDown numDay;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnFileReverse;
        private System.Windows.Forms.Button btnFileRandom;
        private System.Windows.Forms.Button btnFileClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAngle;
        private System.Windows.Forms.GroupBox gbAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lAngleAnswer;
        private System.Windows.Forms.Label lAngleH;
        private System.Windows.Forms.NumericUpDown numAngleHours;
        private System.Windows.Forms.NumericUpDown numAngleMinutes;
        private System.Windows.Forms.GroupBox gbDraw;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnMotionPoint;
    }
}

