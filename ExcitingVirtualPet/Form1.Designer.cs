namespace ExcitingVirtualPet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.petPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.catWaterButton = new System.Windows.Forms.Button();
            this.petCatButton = new System.Windows.Forms.Button();
            this.catPlayButton = new System.Windows.Forms.Button();
            this.feedCatButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.affectionMeter = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.boredomMeter = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.thirstMeter = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.hungerMeter = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.foodAmountBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.waterAmountBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.petPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pet Display";
            // 
            // petPictureBox
            // 
            this.petPictureBox.Location = new System.Drawing.Point(6, 19);
            this.petPictureBox.Name = "petPictureBox";
            this.petPictureBox.Size = new System.Drawing.Size(316, 269);
            this.petPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.petPictureBox.TabIndex = 0;
            this.petPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.catWaterButton);
            this.groupBox2.Controls.Add(this.petCatButton);
            this.groupBox2.Controls.Add(this.catPlayButton);
            this.groupBox2.Controls.Add(this.feedCatButton);
            this.groupBox2.Location = new System.Drawing.Point(346, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pet Controls";
            // 
            // catWaterButton
            // 
            this.catWaterButton.Location = new System.Drawing.Point(6, 48);
            this.catWaterButton.Name = "catWaterButton";
            this.catWaterButton.Size = new System.Drawing.Size(211, 23);
            this.catWaterButton.TabIndex = 0;
            this.catWaterButton.Text = "Give Cat Water";
            this.catWaterButton.UseVisualStyleBackColor = true;
            this.catWaterButton.Click += new System.EventHandler(this.catWaterButton_Click);
            // 
            // petCatButton
            // 
            this.petCatButton.Location = new System.Drawing.Point(6, 106);
            this.petCatButton.Name = "petCatButton";
            this.petCatButton.Size = new System.Drawing.Size(211, 23);
            this.petCatButton.TabIndex = 0;
            this.petCatButton.Text = "Pet Cat";
            this.petCatButton.UseVisualStyleBackColor = true;
            this.petCatButton.Click += new System.EventHandler(this.petCatButton_Click);
            // 
            // catPlayButton
            // 
            this.catPlayButton.Location = new System.Drawing.Point(6, 77);
            this.catPlayButton.Name = "catPlayButton";
            this.catPlayButton.Size = new System.Drawing.Size(211, 23);
            this.catPlayButton.TabIndex = 0;
            this.catPlayButton.Text = "Play With Cat";
            this.catPlayButton.UseVisualStyleBackColor = true;
            this.catPlayButton.Click += new System.EventHandler(this.catPlayButton_Click);
            // 
            // feedCatButton
            // 
            this.feedCatButton.Location = new System.Drawing.Point(6, 19);
            this.feedCatButton.Name = "feedCatButton";
            this.feedCatButton.Size = new System.Drawing.Size(211, 23);
            this.feedCatButton.TabIndex = 0;
            this.feedCatButton.Text = "Feed Cat";
            this.feedCatButton.UseVisualStyleBackColor = true;
            this.feedCatButton.Click += new System.EventHandler(this.feedCatButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.affectionMeter);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.boredomMeter);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.thirstMeter);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.hungerMeter);
            this.groupBox3.Location = new System.Drawing.Point(346, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cat Facts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Affection";
            // 
            // affectionMeter
            // 
            this.affectionMeter.Location = new System.Drawing.Point(61, 124);
            this.affectionMeter.Maximum = 10;
            this.affectionMeter.Name = "affectionMeter";
            this.affectionMeter.Size = new System.Drawing.Size(156, 23);
            this.affectionMeter.Step = 1;
            this.affectionMeter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Boredom";
            // 
            // boredomMeter
            // 
            this.boredomMeter.Location = new System.Drawing.Point(61, 87);
            this.boredomMeter.Maximum = 10;
            this.boredomMeter.Name = "boredomMeter";
            this.boredomMeter.Size = new System.Drawing.Size(156, 23);
            this.boredomMeter.Step = 1;
            this.boredomMeter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thirst";
            // 
            // thirstMeter
            // 
            this.thirstMeter.Location = new System.Drawing.Point(61, 52);
            this.thirstMeter.Maximum = 10;
            this.thirstMeter.Name = "thirstMeter";
            this.thirstMeter.Size = new System.Drawing.Size(156, 23);
            this.thirstMeter.Step = 1;
            this.thirstMeter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hunger";
            // 
            // hungerMeter
            // 
            this.hungerMeter.Location = new System.Drawing.Point(61, 19);
            this.hungerMeter.Maximum = 10;
            this.hungerMeter.Name = "hungerMeter";
            this.hungerMeter.Size = new System.Drawing.Size(156, 23);
            this.hungerMeter.Step = 1;
            this.hungerMeter.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.foodAmountBar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.waterAmountBar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 76);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resources";
            // 
            // foodAmountBar
            // 
            this.foodAmountBar.Location = new System.Drawing.Point(199, 24);
            this.foodAmountBar.Maximum = 10;
            this.foodAmountBar.Name = "foodAmountBar";
            this.foodAmountBar.Size = new System.Drawing.Size(162, 23);
            this.foodAmountBar.Step = 1;
            this.foodAmountBar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Food Dish:";
            // 
            // waterAmountBar
            // 
            this.waterAmountBar.Location = new System.Drawing.Point(14, 24);
            this.waterAmountBar.Maximum = 10;
            this.waterAmountBar.Name = "waterAmountBar";
            this.waterAmountBar.Size = new System.Drawing.Size(162, 23);
            this.waterAmountBar.Step = 1;
            this.waterAmountBar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Water Dish:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 407);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Virtual Pet";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox petPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button catWaterButton;
        private System.Windows.Forms.Button petCatButton;
        private System.Windows.Forms.Button catPlayButton;
        private System.Windows.Forms.Button feedCatButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar affectionMeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar boredomMeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar thirstMeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar hungerMeter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar foodAmountBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar waterAmountBar;
        private System.Windows.Forms.Label label5;
    }
}

