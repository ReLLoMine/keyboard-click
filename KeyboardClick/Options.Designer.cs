namespace KeyboardClick
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.choose_d_file_sound = new System.Windows.Forms.Button();
            this.OpenDownSoundFile = new System.Windows.Forms.OpenFileDialog();
            this.downFilePath = new System.Windows.Forms.TextBox();
            this.test_d_sound_file = new System.Windows.Forms.Button();
            this.d_file_path_lb = new System.Windows.Forms.Label();
            this.apply_settings = new System.Windows.Forms.Button();
            this.cancel_settings = new System.Windows.Forms.Button();
            this.ok_settings = new System.Windows.Forms.Button();
            this.releaseFilePath = new System.Windows.Forms.TextBox();
            this.r_file_path_lb = new System.Windows.Forms.Label();
            this.choose_r_file_sound = new System.Windows.Forms.Button();
            this.test_r_sound_file = new System.Windows.Forms.Button();
            this.OpenReleaseSoundFile = new System.Windows.Forms.OpenFileDialog();
            this.single_mode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // choose_d_file_sound
            // 
            this.choose_d_file_sound.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.choose_d_file_sound.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_d_file_sound.Location = new System.Drawing.Point(12, 56);
            this.choose_d_file_sound.Name = "choose_d_file_sound";
            this.choose_d_file_sound.Size = new System.Drawing.Size(155, 19);
            this.choose_d_file_sound.TabIndex = 0;
            this.choose_d_file_sound.Text = "Choose sound file";
            this.choose_d_file_sound.UseVisualStyleBackColor = true;
            this.choose_d_file_sound.Click += new System.EventHandler(this.choose_file_sound_Click);
            // 
            // OpenDownSoundFile
            // 
            this.OpenDownSoundFile.DefaultExt = "wav";
            this.OpenDownSoundFile.FileName = "OpenDownSoundFile";
            this.OpenDownSoundFile.Filter = "Sound files|*.wav";
            this.OpenDownSoundFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenSoundFile_FileOk);
            // 
            // downFilePath
            // 
            this.downFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.downFilePath.Font = new System.Drawing.Font("Roboto Condensed", 9.75F);
            this.downFilePath.Location = new System.Drawing.Point(12, 27);
            this.downFilePath.Name = "downFilePath";
            this.downFilePath.ReadOnly = true;
            this.downFilePath.Size = new System.Drawing.Size(320, 23);
            this.downFilePath.TabIndex = 1;
            // 
            // test_d_sound_file
            // 
            this.test_d_sound_file.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.test_d_sound_file.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_d_sound_file.Location = new System.Drawing.Point(177, 56);
            this.test_d_sound_file.Name = "test_d_sound_file";
            this.test_d_sound_file.Size = new System.Drawing.Size(155, 19);
            this.test_d_sound_file.TabIndex = 2;
            this.test_d_sound_file.Text = "Test sound file";
            this.test_d_sound_file.UseVisualStyleBackColor = true;
            this.test_d_sound_file.Click += new System.EventHandler(this.test_d_sound_file_Click);
            // 
            // d_file_path_lb
            // 
            this.d_file_path_lb.AutoSize = true;
            this.d_file_path_lb.Font = new System.Drawing.Font("Roboto Condensed", 9.75F);
            this.d_file_path_lb.Location = new System.Drawing.Point(9, 9);
            this.d_file_path_lb.Name = "d_file_path_lb";
            this.d_file_path_lb.Size = new System.Drawing.Size(115, 15);
            this.d_file_path_lb.TabIndex = 3;
            this.d_file_path_lb.Text = "Down sound file path:";
            // 
            // apply_settings
            // 
            this.apply_settings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.apply_settings.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apply_settings.Location = new System.Drawing.Point(258, 190);
            this.apply_settings.Name = "apply_settings";
            this.apply_settings.Size = new System.Drawing.Size(74, 19);
            this.apply_settings.TabIndex = 4;
            this.apply_settings.Text = "Apply";
            this.apply_settings.UseVisualStyleBackColor = true;
            this.apply_settings.Click += new System.EventHandler(this.apply_settings_Click);
            // 
            // cancel_settings
            // 
            this.cancel_settings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancel_settings.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_settings.Location = new System.Drawing.Point(178, 190);
            this.cancel_settings.Name = "cancel_settings";
            this.cancel_settings.Size = new System.Drawing.Size(74, 19);
            this.cancel_settings.TabIndex = 5;
            this.cancel_settings.Text = "Cancel";
            this.cancel_settings.UseVisualStyleBackColor = true;
            this.cancel_settings.Click += new System.EventHandler(this.cancel_settings_Click);
            // 
            // ok_settings
            // 
            this.ok_settings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ok_settings.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_settings.Location = new System.Drawing.Point(98, 190);
            this.ok_settings.Name = "ok_settings";
            this.ok_settings.Size = new System.Drawing.Size(74, 19);
            this.ok_settings.TabIndex = 6;
            this.ok_settings.Text = "Ok";
            this.ok_settings.UseVisualStyleBackColor = true;
            this.ok_settings.Click += new System.EventHandler(this.ok_settings_Click);
            // 
            // releaseFilePath
            // 
            this.releaseFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.releaseFilePath.Font = new System.Drawing.Font("Roboto Condensed", 9.75F);
            this.releaseFilePath.Location = new System.Drawing.Point(12, 96);
            this.releaseFilePath.Name = "releaseFilePath";
            this.releaseFilePath.ReadOnly = true;
            this.releaseFilePath.Size = new System.Drawing.Size(320, 23);
            this.releaseFilePath.TabIndex = 7;
            // 
            // r_file_path_lb
            // 
            this.r_file_path_lb.AutoSize = true;
            this.r_file_path_lb.Font = new System.Drawing.Font("Roboto Condensed", 9.75F);
            this.r_file_path_lb.Location = new System.Drawing.Point(9, 78);
            this.r_file_path_lb.Name = "r_file_path_lb";
            this.r_file_path_lb.Size = new System.Drawing.Size(127, 15);
            this.r_file_path_lb.TabIndex = 8;
            this.r_file_path_lb.Text = "Release sound file path:";
            // 
            // choose_r_file_sound
            // 
            this.choose_r_file_sound.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.choose_r_file_sound.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_r_file_sound.Location = new System.Drawing.Point(12, 125);
            this.choose_r_file_sound.Name = "choose_r_file_sound";
            this.choose_r_file_sound.Size = new System.Drawing.Size(155, 19);
            this.choose_r_file_sound.TabIndex = 9;
            this.choose_r_file_sound.Text = "Choose sound file";
            this.choose_r_file_sound.UseVisualStyleBackColor = true;
            this.choose_r_file_sound.Click += new System.EventHandler(this.choose_r_file_sound_Click);
            // 
            // test_r_sound_file
            // 
            this.test_r_sound_file.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.test_r_sound_file.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_r_sound_file.Location = new System.Drawing.Point(178, 125);
            this.test_r_sound_file.Name = "test_r_sound_file";
            this.test_r_sound_file.Size = new System.Drawing.Size(155, 19);
            this.test_r_sound_file.TabIndex = 10;
            this.test_r_sound_file.Text = "Test sound file";
            this.test_r_sound_file.UseVisualStyleBackColor = true;
            this.test_r_sound_file.Click += new System.EventHandler(this.test_r_sound_file_Click);
            // 
            // OpenReleaseSoundFile
            // 
            this.OpenReleaseSoundFile.DefaultExt = "wav";
            this.OpenReleaseSoundFile.FileName = "OpenReleaseSoundFile";
            this.OpenReleaseSoundFile.Filter = "Sound files|*.wav";
            this.OpenReleaseSoundFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenReleaseSoundFile_FileOk);
            // 
            // single_mode
            // 
            this.single_mode.AutoSize = true;
            this.single_mode.Font = new System.Drawing.Font("Roboto Condensed", 9.75F);
            this.single_mode.Location = new System.Drawing.Point(12, 150);
            this.single_mode.Name = "single_mode";
            this.single_mode.Size = new System.Drawing.Size(89, 19);
            this.single_mode.TabIndex = 11;
            this.single_mode.Text = "Single mode";
            this.single_mode.UseVisualStyleBackColor = true;
            this.single_mode.CheckedChanged += new System.EventHandler(this.single_mode_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(344, 221);
            this.Controls.Add(this.single_mode);
            this.Controls.Add(this.test_r_sound_file);
            this.Controls.Add(this.choose_r_file_sound);
            this.Controls.Add(this.r_file_path_lb);
            this.Controls.Add(this.releaseFilePath);
            this.Controls.Add(this.ok_settings);
            this.Controls.Add(this.cancel_settings);
            this.Controls.Add(this.apply_settings);
            this.Controls.Add(this.d_file_path_lb);
            this.Controls.Add(this.test_d_sound_file);
            this.Controls.Add(this.downFilePath);
            this.Controls.Add(this.choose_d_file_sound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choose_d_file_sound;
        private System.Windows.Forms.OpenFileDialog OpenDownSoundFile;
        private System.Windows.Forms.TextBox downFilePath;
        private System.Windows.Forms.Button test_d_sound_file;
        private System.Windows.Forms.Label d_file_path_lb;
        private System.Windows.Forms.Button apply_settings;
        private System.Windows.Forms.Button cancel_settings;
        private System.Windows.Forms.Button ok_settings;
        private System.Windows.Forms.TextBox releaseFilePath;
        private System.Windows.Forms.Label r_file_path_lb;
        private System.Windows.Forms.Button choose_r_file_sound;
        private System.Windows.Forms.Button test_r_sound_file;
        private System.Windows.Forms.OpenFileDialog OpenReleaseSoundFile;
        private System.Windows.Forms.CheckBox single_mode;
    }
}