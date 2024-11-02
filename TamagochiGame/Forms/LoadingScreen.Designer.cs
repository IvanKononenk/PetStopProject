namespace PetStop
{
	partial class LoadingScreen
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
			this.PIcBoxLogo = new System.Windows.Forms.PictureBox();
			this.LblHello = new System.Windows.Forms.Label();
			this.LoadingBar = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.PIcBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// PIcBoxLogo
			// 
			this.PIcBoxLogo.Image = global::PetStop.Properties.Resources.logo;
			this.PIcBoxLogo.Location = new System.Drawing.Point(12, 12);
			this.PIcBoxLogo.Name = "PIcBoxLogo";
			this.PIcBoxLogo.Size = new System.Drawing.Size(256, 256);
			this.PIcBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PIcBoxLogo.TabIndex = 0;
			this.PIcBoxLogo.TabStop = false;
			// 
			// LblHello
			// 
			this.LblHello.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblHello.Location = new System.Drawing.Point(274, 12);
			this.LblHello.Name = "LblHello";
			this.LblHello.Size = new System.Drawing.Size(514, 128);
			this.LblHello.TabIndex = 1;
			this.LblHello.Text = "Shadow Serpents представляют...\r\nPetStop";
			this.LblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoadingBar
			// 
			this.LoadingBar.Location = new System.Drawing.Point(274, 143);
			this.LoadingBar.MarqueeAnimationSpeed = 1;
			this.LoadingBar.Name = "LoadingBar";
			this.LoadingBar.Size = new System.Drawing.Size(514, 32);
			this.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.LoadingBar.TabIndex = 2;
			// 
			// LoadingScreen
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(800, 280);
			this.Controls.Add(this.LoadingBar);
			this.Controls.Add(this.LblHello);
			this.Controls.Add(this.PIcBoxLogo);
			this.Font = new System.Drawing.Font("Verdana", 14.25F);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(816, 319);
			this.MinimumSize = new System.Drawing.Size(816, 319);
			this.Name = "LoadingScreen";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Загрузка...";
			this.Load += new System.EventHandler(this.LoadingScreen_Load);
			((System.ComponentModel.ISupportInitialize)(this.PIcBoxLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox PIcBoxLogo;
		private System.Windows.Forms.Label LblHello;
		private System.Windows.Forms.ProgressBar LoadingBar;
	}
}