namespace Snake
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pbCanvas = new System.Windows.Forms.PictureBox();
			this.score = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.lblGameOver = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
			this.SuspendLayout();
			// 
			// pbCanvas
			// 
			this.pbCanvas.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pbCanvas.Location = new System.Drawing.Point(12, 12);
			this.pbCanvas.Name = "pbCanvas";
			this.pbCanvas.Size = new System.Drawing.Size(478, 426);
			this.pbCanvas.TabIndex = 0;
			this.pbCanvas.TabStop = false;
			this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
			// 
			// score
			// 
			this.score.AutoSize = true;
			this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.score.ForeColor = System.Drawing.Color.Blue;
			this.score.Location = new System.Drawing.Point(552, 91);
			this.score.Name = "score";
			this.score.Size = new System.Drawing.Size(89, 29);
			this.score.TabIndex = 1;
			this.score.Text = "Score:";
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.lblScore.Location = new System.Drawing.Point(598, 145);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(0, 29);
			this.lblScore.TabIndex = 2;
			// 
			// lblGameOver
			// 
			this.lblGameOver.AutoSize = true;
			this.lblGameOver.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblGameOver.Location = new System.Drawing.Point(81, 137);
			this.lblGameOver.Name = "lblGameOver";
			this.lblGameOver.Size = new System.Drawing.Size(100, 37);
			this.lblGameOver.TabIndex = 3;
			this.lblGameOver.Text = "label1";
			this.lblGameOver.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblGameOver);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.score);
			this.Controls.Add(this.pbCanvas);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbCanvas;
		private System.Windows.Forms.Label score;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.Label lblGameOver;
	}
}

