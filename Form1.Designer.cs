
namespace CreaturesOfTheSeaGUI
{
    partial class Form1
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
            this.SelectedCreatureDetails = new System.Windows.Forms.RichTextBox();
            this.Crush = new System.Windows.Forms.PictureBox();
            this.Phat = new System.Windows.Forms.PictureBox();
            this.SwimShady = new System.Windows.Forms.PictureBox();
            this.WaterDragon = new System.Windows.Forms.PictureBox();
            this.AppLabel = new System.Windows.Forms.Label();
            this.CreatureInstructions = new System.Windows.Forms.Label();
            this.FeedButton = new System.Windows.Forms.Button();
            this.CommunicateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CrushProgress = new System.Windows.Forms.ProgressBar();
            this.PhatProgress = new System.Windows.Forms.ProgressBar();
            this.SwimShadyProgress = new System.Windows.Forms.ProgressBar();
            this.WaterDragonProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Crush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwimShady)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterDragon)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedCreatureDetails
            // 
            this.SelectedCreatureDetails.Location = new System.Drawing.Point(35, 323);
            this.SelectedCreatureDetails.Name = "SelectedCreatureDetails";
            this.SelectedCreatureDetails.Size = new System.Drawing.Size(725, 96);
            this.SelectedCreatureDetails.TabIndex = 1;
            this.SelectedCreatureDetails.Text = "";
            this.SelectedCreatureDetails.Visible = false;
            // 
            // Crush
            // 
            this.Crush.Image = global::CreaturesOfTheSeaGUI.Resource.Crush;
            this.Crush.Location = new System.Drawing.Point(35, 46);
            this.Crush.Name = "Crush";
            this.Crush.Padding = new System.Windows.Forms.Padding(2);
            this.Crush.Size = new System.Drawing.Size(160, 140);
            this.Crush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Crush.TabIndex = 2;
            this.Crush.TabStop = false;
            this.Crush.Tag = "Crush";
            this.Crush.Click += new System.EventHandler(this.Creature_Click);
            // 
            // Phat
            // 
            this.Phat.Image = global::CreaturesOfTheSeaGUI.Resource.PufferFish;
            this.Phat.Location = new System.Drawing.Point(216, 46);
            this.Phat.Name = "Phat";
            this.Phat.Size = new System.Drawing.Size(158, 140);
            this.Phat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Phat.TabIndex = 3;
            this.Phat.TabStop = false;
            this.Phat.Tag = "Phat";
            this.Phat.Click += new System.EventHandler(this.Creature_Click);
            // 
            // SwimShady
            // 
            this.SwimShady.Image = global::CreaturesOfTheSeaGUI.Resource.SwimShady;
            this.SwimShady.Location = new System.Drawing.Point(395, 46);
            this.SwimShady.Name = "SwimShady";
            this.SwimShady.Size = new System.Drawing.Size(146, 140);
            this.SwimShady.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SwimShady.TabIndex = 4;
            this.SwimShady.TabStop = false;
            this.SwimShady.Tag = "Swim Shady";
            this.SwimShady.Click += new System.EventHandler(this.Creature_Click);
            // 
            // WaterDragon
            // 
            this.WaterDragon.Image = global::CreaturesOfTheSeaGUI.Resource.WaterDragon;
            this.WaterDragon.Location = new System.Drawing.Point(566, 46);
            this.WaterDragon.Name = "WaterDragon";
            this.WaterDragon.Size = new System.Drawing.Size(160, 140);
            this.WaterDragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WaterDragon.TabIndex = 5;
            this.WaterDragon.TabStop = false;
            this.WaterDragon.Tag = "Water Dragon";
            this.WaterDragon.Click += new System.EventHandler(this.Creature_Click);
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppLabel.Location = new System.Drawing.Point(276, 9);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(238, 30);
            this.AppLabel.TabIndex = 7;
            this.AppLabel.Text = "Please select a creature";
            // 
            // CreatureInstructions
            // 
            this.CreatureInstructions.AutoSize = true;
            this.CreatureInstructions.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatureInstructions.Location = new System.Drawing.Point(263, 221);
            this.CreatureInstructions.Name = "CreatureInstructions";
            this.CreatureInstructions.Size = new System.Drawing.Size(278, 30);
            this.CreatureInstructions.TabIndex = 8;
            this.CreatureInstructions.Text = "What would you like to do?";
            this.CreatureInstructions.Visible = false;
            // 
            // FeedButton
            // 
            this.FeedButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FeedButton.Location = new System.Drawing.Point(229, 268);
            this.FeedButton.Name = "FeedButton";
            this.FeedButton.Size = new System.Drawing.Size(112, 42);
            this.FeedButton.TabIndex = 9;
            this.FeedButton.Text = "Feed";
            this.FeedButton.UseVisualStyleBackColor = true;
            this.FeedButton.Visible = false;
            this.FeedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // CommunicateButton
            // 
            this.CommunicateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommunicateButton.Location = new System.Drawing.Point(406, 268);
            this.CommunicateButton.Name = "CommunicateButton";
            this.CommunicateButton.Size = new System.Drawing.Size(135, 42);
            this.CommunicateButton.TabIndex = 10;
            this.CommunicateButton.Text = "Communicate";
            this.CommunicateButton.UseVisualStyleBackColor = true;
            this.CommunicateButton.Visible = false;
            this.CommunicateButton.Click += new System.EventHandler(this.CommunicateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(585, 268);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(122, 42);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Visible = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CrushProgress
            // 
            this.CrushProgress.Location = new System.Drawing.Point(35, 181);
            this.CrushProgress.Name = "CrushProgress";
            this.CrushProgress.Size = new System.Drawing.Size(160, 23);
            this.CrushProgress.TabIndex = 16;
            // 
            // PhatProgress
            // 
            this.PhatProgress.Location = new System.Drawing.Point(216, 181);
            this.PhatProgress.Name = "PhatProgress";
            this.PhatProgress.Size = new System.Drawing.Size(160, 23);
            this.PhatProgress.TabIndex = 17;
            // 
            // SwimShadyProgress
            // 
            this.SwimShadyProgress.Location = new System.Drawing.Point(395, 181);
            this.SwimShadyProgress.Name = "SwimShadyProgress";
            this.SwimShadyProgress.Size = new System.Drawing.Size(146, 23);
            this.SwimShadyProgress.TabIndex = 18;
            // 
            // WaterDragonProgress
            // 
            this.WaterDragonProgress.Location = new System.Drawing.Point(566, 181);
            this.WaterDragonProgress.Name = "WaterDragonProgress";
            this.WaterDragonProgress.Size = new System.Drawing.Size(160, 23);
            this.WaterDragonProgress.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.WaterDragonProgress);
            this.Controls.Add(this.SwimShadyProgress);
            this.Controls.Add(this.PhatProgress);
            this.Controls.Add(this.CrushProgress);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CommunicateButton);
            this.Controls.Add(this.FeedButton);
            this.Controls.Add(this.CreatureInstructions);
            this.Controls.Add(this.AppLabel);
            this.Controls.Add(this.WaterDragon);
            this.Controls.Add(this.SwimShady);
            this.Controls.Add(this.Phat);
            this.Controls.Add(this.Crush);
            this.Controls.Add(this.SelectedCreatureDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Crush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwimShady)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterDragon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox SelectedCreatureDetails;
        private System.Windows.Forms.PictureBox Crush;
        private System.Windows.Forms.PictureBox Phat;
        private System.Windows.Forms.PictureBox SwimShady;
        private System.Windows.Forms.PictureBox WaterDragon;
        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Label CreatureInstructions;
        private System.Windows.Forms.Button FeedButton;
        private System.Windows.Forms.Button CommunicateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ProgressBar CrushProgress;
        private System.Windows.Forms.ProgressBar PhatProgress;
        private System.Windows.Forms.ProgressBar SwimShadyProgress;
        private System.Windows.Forms.ProgressBar WaterDragonProgress;
    }
}

