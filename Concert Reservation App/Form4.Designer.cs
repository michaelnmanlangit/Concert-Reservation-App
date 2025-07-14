namespace Concert_Reservation_App
{
    partial class Form4
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
            this.lblArtistName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectSeat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.BackColor = System.Drawing.Color.Transparent;
            this.lblArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.ForeColor = System.Drawing.SystemColors.Info;
            this.lblArtistName.Location = new System.Drawing.Point(64, 47);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(165, 25);
            this.lblArtistName.TabIndex = 0;
            this.lblArtistName.Text = "BEN AND BEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDate.Location = new System.Drawing.Point(104, 90);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(83, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "July 18, 2025";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTime.Location = new System.Drawing.Point(118, 115);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "3:00 PM";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPlace.Location = new System.Drawing.Point(105, 138);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(80, 13);
            this.lblPlace.TabIndex = 4;
            this.lblPlace.Text = "MOA ARENA";
            this.lblPlace.Click += new System.EventHandler(this.lblPlace_Click);
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.BackColor = System.Drawing.Color.Transparent;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.ForeColor = System.Drawing.SystemColors.Info;
            this.lblVenue.Location = new System.Drawing.Point(54, 178);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(87, 24);
            this.lblVenue.TabIndex = 5;
            this.lblVenue.Text = "VENUE:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(55, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 254);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSelectSeat
            // 
            this.btnSelectSeat.Location = new System.Drawing.Point(55, 470);
            this.btnSelectSeat.Name = "btnSelectSeat";
            this.btnSelectSeat.Size = new System.Drawing.Size(198, 37);
            this.btnSelectSeat.TabIndex = 7;
            this.btnSelectSeat.Text = "SELECT YOUR DESIRED SEAT";
            this.btnSelectSeat.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Concert_Reservation_App.Properties.Resources._515922623_2144541529399616_1072195561129697262_n;
            this.ClientSize = new System.Drawing.Size(309, 561);
            this.Controls.Add(this.btnSelectSeat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArtistName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelectSeat;
    }
}