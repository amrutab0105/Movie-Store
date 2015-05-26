namespace Lab6_Amruta
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.searchByDirector = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.searchByActor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchByReleaseYear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBylanguage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.searchByGenre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.partialTitle = new System.Windows.Forms.TextBox();
            this.searchByPartialTitle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.searchByRating = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.directorList = new System.Windows.Forms.ListBox();
            this.castName = new System.Windows.Forms.ListBox();
            this.releaseYear = new System.Windows.Forms.ListBox();
            this.languages = new System.Windows.Forms.ListBox();
            this.genres = new System.Windows.Forms.ListBox();
            this.ratings = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Director Name:";
            // 
            // searchByDirector
            // 
            this.searchByDirector.BackColor = System.Drawing.SystemColors.Window;
            this.searchByDirector.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDirector.Location = new System.Drawing.Point(391, 83);
            this.searchByDirector.Name = "searchByDirector";
            this.searchByDirector.Size = new System.Drawing.Size(75, 36);
            this.searchByDirector.TabIndex = 2;
            this.searchByDirector.Text = "Search";
            this.searchByDirector.UseVisualStyleBackColor = false;
            this.searchByDirector.Click += new System.EventHandler(this.searchByDirector_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.Window;
            this.close.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(562, 416);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(79, 29);
            this.close.TabIndex = 3;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.AutoGenerateColumns = false;
            this.resultDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.DataSource = this.bindingSource1;
            this.resultDataGrid.Location = new System.Drawing.Point(484, 65);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.Size = new System.Drawing.Size(172, 309);
            this.resultDataGrid.TabIndex = 4;
            this.resultDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultDataGrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Actor/Actress Name:";
            // 
            // searchByActor
            // 
            this.searchByActor.BackColor = System.Drawing.SystemColors.Window;
            this.searchByActor.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByActor.Location = new System.Drawing.Point(391, 141);
            this.searchByActor.Name = "searchByActor";
            this.searchByActor.Size = new System.Drawing.Size(75, 34);
            this.searchByActor.TabIndex = 7;
            this.searchByActor.Text = "Search";
            this.searchByActor.UseVisualStyleBackColor = false;
            this.searchByActor.Click += new System.EventHandler(this.searchByActor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maximum Release Year";
            // 
            // searchByReleaseYear
            // 
            this.searchByReleaseYear.BackColor = System.Drawing.SystemColors.Window;
            this.searchByReleaseYear.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByReleaseYear.Location = new System.Drawing.Point(391, 198);
            this.searchByReleaseYear.Name = "searchByReleaseYear";
            this.searchByReleaseYear.Size = new System.Drawing.Size(75, 33);
            this.searchByReleaseYear.TabIndex = 10;
            this.searchByReleaseYear.Text = "Search";
            this.searchByReleaseYear.UseVisualStyleBackColor = false;
            this.searchByReleaseYear.Click += new System.EventHandler(this.searchByReleaseYear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Language";
            // 
            // searchBylanguage
            // 
            this.searchBylanguage.BackColor = System.Drawing.SystemColors.Window;
            this.searchBylanguage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBylanguage.Location = new System.Drawing.Point(391, 254);
            this.searchBylanguage.Name = "searchBylanguage";
            this.searchBylanguage.Size = new System.Drawing.Size(75, 36);
            this.searchBylanguage.TabIndex = 13;
            this.searchBylanguage.Text = "Search";
            this.searchBylanguage.UseVisualStyleBackColor = false;
            this.searchBylanguage.Click += new System.EventHandler(this.searchBylanguage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Genre";
            // 
            // searchByGenre
            // 
            this.searchByGenre.BackColor = System.Drawing.SystemColors.Window;
            this.searchByGenre.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByGenre.Location = new System.Drawing.Point(391, 312);
            this.searchByGenre.Name = "searchByGenre";
            this.searchByGenre.Size = new System.Drawing.Size(75, 28);
            this.searchByGenre.TabIndex = 16;
            this.searchByGenre.Text = "Search";
            this.searchByGenre.UseVisualStyleBackColor = false;
            this.searchByGenre.Click += new System.EventHandler(this.searchByGenre_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Partial Title:";
            // 
            // partialTitle
            // 
            this.partialTitle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partialTitle.Location = new System.Drawing.Point(207, 366);
            this.partialTitle.Name = "partialTitle";
            this.partialTitle.Size = new System.Drawing.Size(139, 25);
            this.partialTitle.TabIndex = 18;
            // 
            // searchByPartialTitle
            // 
            this.searchByPartialTitle.BackColor = System.Drawing.SystemColors.Window;
            this.searchByPartialTitle.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByPartialTitle.Location = new System.Drawing.Point(391, 354);
            this.searchByPartialTitle.Name = "searchByPartialTitle";
            this.searchByPartialTitle.Size = new System.Drawing.Size(75, 37);
            this.searchByPartialTitle.TabIndex = 19;
            this.searchByPartialTitle.Text = "Search";
            this.searchByPartialTitle.UseVisualStyleBackColor = false;
            this.searchByPartialTitle.Click += new System.EventHandler(this.searchByPartialTitle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Rating";
            // 
            // searchByRating
            // 
            this.searchByRating.BackColor = System.Drawing.SystemColors.Window;
            this.searchByRating.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByRating.Location = new System.Drawing.Point(391, 410);
            this.searchByRating.Name = "searchByRating";
            this.searchByRating.Size = new System.Drawing.Size(75, 35);
            this.searchByRating.TabIndex = 22;
            this.searchByRating.Text = "Search";
            this.searchByRating.UseVisualStyleBackColor = false;
            this.searchByRating.Click += new System.EventHandler(this.searchByRating_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(672, 65);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(459, 306);
            this.result.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(668, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "DETAILS OF SELECTED MOVIE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "SELECT A MOVIE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(450, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "ENTER DATA FOR THE MOVIE TO BE SEARCHED:";
            // 
            // directorList
            // 
            this.directorList.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorList.FormattingEnabled = true;
            this.directorList.ItemHeight = 18;
            this.directorList.Location = new System.Drawing.Point(207, 83);
            this.directorList.Name = "directorList";
            this.directorList.Size = new System.Drawing.Size(139, 40);
            this.directorList.TabIndex = 27;
            // 
            // castName
            // 
            this.castName.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castName.FormattingEnabled = true;
            this.castName.ItemHeight = 18;
            this.castName.Location = new System.Drawing.Point(207, 141);
            this.castName.Name = "castName";
            this.castName.Size = new System.Drawing.Size(139, 40);
            this.castName.TabIndex = 28;
            // 
            // releaseYear
            // 
            this.releaseYear.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseYear.FormattingEnabled = true;
            this.releaseYear.ItemHeight = 18;
            this.releaseYear.Location = new System.Drawing.Point(207, 198);
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Size = new System.Drawing.Size(139, 40);
            this.releaseYear.TabIndex = 29;
            // 
            // languages
            // 
            this.languages.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languages.FormattingEnabled = true;
            this.languages.ItemHeight = 18;
            this.languages.Location = new System.Drawing.Point(207, 258);
            this.languages.Name = "languages";
            this.languages.Size = new System.Drawing.Size(139, 40);
            this.languages.TabIndex = 30;
            // 
            // genres
            // 
            this.genres.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genres.FormattingEnabled = true;
            this.genres.ItemHeight = 18;
            this.genres.Location = new System.Drawing.Point(207, 315);
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(139, 40);
            this.genres.TabIndex = 31;
            // 
            // ratings
            // 
            this.ratings.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratings.FormattingEnabled = true;
            this.ratings.ItemHeight = 18;
            this.ratings.Location = new System.Drawing.Point(207, 410);
            this.ratings.Name = "ratings";
            this.ratings.Size = new System.Drawing.Size(139, 40);
            this.ratings.TabIndex = 32;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1143, 480);
            this.Controls.Add(this.ratings);
            this.Controls.Add(this.genres);
            this.Controls.Add(this.languages);
            this.Controls.Add(this.releaseYear);
            this.Controls.Add(this.castName);
            this.Controls.Add(this.directorList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.result);
            this.Controls.Add(this.searchByRating);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchByPartialTitle);
            this.Controls.Add(this.partialTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchByGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchBylanguage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchByReleaseYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchByActor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultDataGrid);
            this.Controls.Add(this.close);
            this.Controls.Add(this.searchByDirector);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchByDirector;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView resultDataGrid;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchByActor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchByReleaseYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchBylanguage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchByGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox partialTitle;
        private System.Windows.Forms.Button searchByPartialTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchByRating;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox directorList;
        private System.Windows.Forms.ListBox castName;
        private System.Windows.Forms.ListBox releaseYear;
        private System.Windows.Forms.ListBox languages;
        private System.Windows.Forms.ListBox genres;
        private System.Windows.Forms.ListBox ratings;
    }
}