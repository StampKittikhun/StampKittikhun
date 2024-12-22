namespace MidtermUIProject
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            btncafe = new Button();
            btnroomrent = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btncafe
            // 
            btncafe.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncafe.Location = new Point(161, 495);
            btncafe.Margin = new Padding(4, 5, 4, 5);
            btncafe.Name = "btncafe";
            btncafe.Size = new Size(220, 95);
            btncafe.TabIndex = 0;
            btncafe.Text = "Internet Cafe";
            btncafe.UseVisualStyleBackColor = true;
            btncafe.Click += btncafe_Click;
            // 
            // btnroomrent
            // 
            btnroomrent.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnroomrent.Location = new Point(724, 495);
            btnroomrent.Margin = new Padding(4, 5, 4, 5);
            btnroomrent.Name = "btnroomrent";
            btnroomrent.Size = new Size(220, 95);
            btnroomrent.TabIndex = 1;
            btnroomrent.Text = "Room Rent";
            btnroomrent.UseVisualStyleBackColor = true;
            btnroomrent.Click += btnroomrent_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.Lovepik_com_611255413_Cafe_hand_drawn_illustration_free_illustration;
            pictureBox1.Location = new Point(161, 232);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.Lovepik_com_401448043_hotel;
            pictureBox2.Location = new Point(724, 232);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(218, 196);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // FrmMainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnroomrent);
            Controls.Add(btncafe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "หน้าจอหลัก";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btncafe;
        private Button btnroomrent;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}