namespace e_TicTacToe
{
    partial class MainMenu
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
            this.bienvenueMainMenu = new System.Windows.Forms.Label();
            this.start1j = new System.Windows.Forms.Button();
            this.start2j = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBoxJ2 = new System.Windows.Forms.TextBox();
            this.nameBoxJ1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bienvenueMainMenu
            // 
            this.bienvenueMainMenu.AutoSize = true;
            this.bienvenueMainMenu.Font = new System.Drawing.Font("Algerian", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.bienvenueMainMenu.Location = new System.Drawing.Point(10, 10);
            this.bienvenueMainMenu.Name = "bienvenueMainMenu";
            this.bienvenueMainMenu.Size = new System.Drawing.Size(680, 41);
            this.bienvenueMainMenu.TabIndex = 0;
            this.bienvenueMainMenu.Text = "Bienvenue sur le jeu du Morpion !";
            this.bienvenueMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start1j
            // 
            this.start1j.Location = new System.Drawing.Point(50, 101);
            this.start1j.Name = "start1j";
            this.start1j.Size = new System.Drawing.Size(243, 56);
            this.start1j.TabIndex = 1;
            this.start1j.Text = "Jouer en solo !";
            this.start1j.UseVisualStyleBackColor = true;
            this.start1j.Click += new System.EventHandler(this.start1j_Click);
            // 
            // start2j
            // 
            this.start2j.Location = new System.Drawing.Point(50, 187);
            this.start2j.Name = "start2j";
            this.start2j.Size = new System.Drawing.Size(243, 45);
            this.start2j.TabIndex = 2;
            this.start2j.Text = "Jouer à deux !";
            this.start2j.UseVisualStyleBackColor = true;
            this.start2j.Click += new System.EventHandler(this.start2j_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameBoxJ2);
            this.groupBox1.Controls.Add(this.nameBoxJ1);
            this.groupBox1.Location = new System.Drawing.Point(299, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Noms des joueurs !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom joueur 2 :";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom joueur 1 :";
            // 
            // nameBoxJ2
            // 
            this.nameBoxJ2.Location = new System.Drawing.Point(124, 89);
            this.nameBoxJ2.Name = "nameBoxJ2";
            this.nameBoxJ2.Size = new System.Drawing.Size(100, 23);
            this.nameBoxJ2.TabIndex = 1;
            this.nameBoxJ2.Text = "IA";
            this.nameBoxJ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameBoxJ1
            // 
            this.nameBoxJ1.Location = new System.Drawing.Point(124, 33);
            this.nameBoxJ1.Name = "nameBoxJ1";
            this.nameBoxJ1.Size = new System.Drawing.Size(100, 23);
            this.nameBoxJ1.TabIndex = 0;
            this.nameBoxJ1.Text = "Bobby";
            this.nameBoxJ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 282);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.start2j);
            this.Controls.Add(this.start1j);
            this.Controls.Add(this.bienvenueMainMenu);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe ! - Main menu.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label bienvenueMainMenu;
        private Button start1j;
        private Button start2j;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox nameBoxJ2;
        private TextBox nameBoxJ1;
    }
}