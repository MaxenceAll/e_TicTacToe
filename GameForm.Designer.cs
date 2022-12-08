namespace e_TicTacToe
{
    partial class GameForm
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
            this.nameJ1 = new System.Windows.Forms.Label();
            this.nameJ2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.turnJX = new System.Windows.Forms.GroupBox();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.scoreJ1 = new System.Windows.Forms.Label();
            this.scoreJ2 = new System.Windows.Forms.Label();
            this.turnJX.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameJ1
            // 
            this.nameJ1.AutoSize = true;
            this.nameJ1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameJ1.Location = new System.Drawing.Point(12, 4);
            this.nameJ1.Name = "nameJ1";
            this.nameJ1.Size = new System.Drawing.Size(84, 27);
            this.nameJ1.TabIndex = 2;
            this.nameJ1.Text = "nameJ1";
            this.nameJ1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameJ2
            // 
            this.nameJ2.AutoSize = true;
            this.nameJ2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameJ2.Location = new System.Drawing.Point(268, 4);
            this.nameJ2.Name = "nameJ2";
            this.nameJ2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameJ2.Size = new System.Drawing.Size(84, 27);
            this.nameJ2.TabIndex = 3;
            this.nameJ2.Text = "nameJ2";
            this.nameJ2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(150, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "VS";
            // 
            // turnJX
            // 
            this.turnJX.Controls.Add(this.btn_3);
            this.turnJX.Controls.Add(this.btn_2);
            this.turnJX.Controls.Add(this.btn_1);
            this.turnJX.Controls.Add(this.btn_6);
            this.turnJX.Controls.Add(this.btn_5);
            this.turnJX.Controls.Add(this.btn_4);
            this.turnJX.Controls.Add(this.btn_9);
            this.turnJX.Controls.Add(this.btn_8);
            this.turnJX.Controls.Add(this.btn_7);
            this.turnJX.Location = new System.Drawing.Point(12, 49);
            this.turnJX.Name = "turnJX";
            this.turnJX.Size = new System.Drawing.Size(337, 350);
            this.turnJX.TabIndex = 6;
            this.turnJX.TabStop = false;
            this.turnJX.Text = "Partie en cours :";
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_3.Location = new System.Drawing.Point(218, 234);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(100, 100);
            this.btn_3.TabIndex = 8;
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_2.Location = new System.Drawing.Point(112, 234);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(100, 100);
            this.btn_2.TabIndex = 7;
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_1.Location = new System.Drawing.Point(6, 234);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(100, 100);
            this.btn_1.TabIndex = 6;
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_6.Location = new System.Drawing.Point(218, 128);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(100, 100);
            this.btn_6.TabIndex = 5;
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_5.Location = new System.Drawing.Point(112, 128);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(100, 100);
            this.btn_5.TabIndex = 4;
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_4.Location = new System.Drawing.Point(6, 128);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(100, 100);
            this.btn_4.TabIndex = 3;
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_9.Location = new System.Drawing.Point(218, 22);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(100, 100);
            this.btn_9.TabIndex = 2;
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_8.Location = new System.Drawing.Point(112, 22);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(100, 100);
            this.btn_8.TabIndex = 1;
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.buttonClick);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_7.Location = new System.Drawing.Point(6, 22);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(100, 100);
            this.btn_7.TabIndex = 0;
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.buttonClick);
            // 
            // scoreJ1
            // 
            this.scoreJ1.AutoSize = true;
            this.scoreJ1.Location = new System.Drawing.Point(45, 31);
            this.scoreJ1.Name = "scoreJ1";
            this.scoreJ1.Size = new System.Drawing.Size(13, 15);
            this.scoreJ1.TabIndex = 7;
            this.scoreJ1.Text = "0";
            // 
            // scoreJ2
            // 
            this.scoreJ2.AutoSize = true;
            this.scoreJ2.Location = new System.Drawing.Point(302, 31);
            this.scoreJ2.Name = "scoreJ2";
            this.scoreJ2.Size = new System.Drawing.Size(13, 15);
            this.scoreJ2.TabIndex = 8;
            this.scoreJ2.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 413);
            this.Controls.Add(this.scoreJ2);
            this.Controls.Add(this.scoreJ1);
            this.Controls.Add(this.turnJX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameJ2);
            this.Controls.Add(this.nameJ1);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe - Partie en cours !";
            this.turnJX.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label nameJ1;
        private Label nameJ2;
        private Label label3;
        private GroupBox turnJX;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Label scoreJ1;
        private Label scoreJ2;
    }
}