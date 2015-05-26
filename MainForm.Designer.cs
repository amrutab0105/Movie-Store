namespace Lab6_Amruta
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.movies = new System.Windows.Forms.Button();
            this.cast = new System.Windows.Forms.Button();
            this.genre = new System.Windows.Forms.Button();
            this.director = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // movies
            // 
            this.movies.BackColor = System.Drawing.SystemColors.Window;
            this.movies.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movies.Location = new System.Drawing.Point(3, 104);
            this.movies.Name = "movies";
            this.movies.Size = new System.Drawing.Size(209, 79);
            this.movies.TabIndex = 0;
            this.movies.Text = "Movies";
            this.movies.UseVisualStyleBackColor = false;
            this.movies.Click += new System.EventHandler(this.movies_Click);
            // 
            // cast
            // 
            this.cast.BackColor = System.Drawing.SystemColors.Window;
            this.cast.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cast.Location = new System.Drawing.Point(3, 189);
            this.cast.Name = "cast";
            this.cast.Size = new System.Drawing.Size(209, 97);
            this.cast.TabIndex = 1;
            this.cast.Text = "List of Actors, Actresses and Directors";
            this.cast.UseVisualStyleBackColor = false;
            this.cast.Click += new System.EventHandler(this.cast_Click);
            // 
            // genre
            // 
            this.genre.BackColor = System.Drawing.SystemColors.Window;
            this.genre.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.Location = new System.Drawing.Point(3, 292);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(209, 85);
            this.genre.TabIndex = 2;
            this.genre.Text = "Genre";
            this.genre.UseVisualStyleBackColor = false;
            this.genre.Click += new System.EventHandler(this.genre_Click);
            // 
            // director
            // 
            this.director.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.director.Location = new System.Drawing.Point(3, 383);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(209, 82);
            this.director.TabIndex = 0;
            this.director.Text = "Movie Cast and Crew";
            this.director.Click += new System.EventHandler(this.director_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Window;
            this.search.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(3, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(209, 93);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 79);
            this.label1.TabIndex = 5;
            this.label1.Text = "SDSU Movie Store";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.genre);
            this.panel1.Controls.Add(this.movies);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.director);
            this.panel1.Controls.Add(this.cast);
            this.panel1.Location = new System.Drawing.Point(13, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 468);
            this.panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(895, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button movies;
        private System.Windows.Forms.Button cast;
        private System.Windows.Forms.Button genre;
        private System.Windows.Forms.Button director;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}