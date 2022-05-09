namespace ScoreTrackerApp
{
    partial class score_tracker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(score_tracker));
            this.chris_score = new System.Windows.Forms.Label();
            this.daria_score = new System.Windows.Forms.Label();
            this.chris_panel = new System.Windows.Forms.Panel();
            this.chris_check = new System.Windows.Forms.Button();
            this.chris_textbox = new System.Windows.Forms.TextBox();
            this.chris_remove = new System.Windows.Forms.Button();
            this.chris_add = new System.Windows.Forms.Button();
            this.daria_panel = new System.Windows.Forms.Panel();
            this.daria_check = new System.Windows.Forms.Button();
            this.daria_textbox = new System.Windows.Forms.TextBox();
            this.daria_remove = new System.Windows.Forms.Button();
            this.daria_add = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.loading_cover = new System.Windows.Forms.Panel();
            this.loading_label = new System.Windows.Forms.Label();
            this.chris_panel.SuspendLayout();
            this.daria_panel.SuspendLayout();
            this.loading_cover.SuspendLayout();
            this.SuspendLayout();
            // 
            // chris_score
            // 
            this.chris_score.AutoSize = true;
            this.chris_score.Font = new System.Drawing.Font("Microsoft JhengHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chris_score.Location = new System.Drawing.Point(65, 43);
            this.chris_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chris_score.Name = "chris_score";
            this.chris_score.Size = new System.Drawing.Size(219, 43);
            this.chris_score.TabIndex = 0;
            this.chris_score.Text = "Chris Score: ";
            // 
            // daria_score
            // 
            this.daria_score.AutoSize = true;
            this.daria_score.Font = new System.Drawing.Font("Microsoft JhengHei", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daria_score.Location = new System.Drawing.Point(455, 43);
            this.daria_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.daria_score.Name = "daria_score";
            this.daria_score.Size = new System.Drawing.Size(223, 43);
            this.daria_score.TabIndex = 2;
            this.daria_score.Text = "Daria Score: ";
            // 
            // chris_panel
            // 
            this.chris_panel.Controls.Add(this.chris_check);
            this.chris_panel.Controls.Add(this.chris_textbox);
            this.chris_panel.Controls.Add(this.chris_remove);
            this.chris_panel.Controls.Add(this.chris_add);
            this.chris_panel.Location = new System.Drawing.Point(65, 107);
            this.chris_panel.Name = "chris_panel";
            this.chris_panel.Size = new System.Drawing.Size(224, 212);
            this.chris_panel.TabIndex = 3;
            // 
            // chris_check
            // 
            this.chris_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chris_check.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chris_check.Location = new System.Drawing.Point(12, 155);
            this.chris_check.Name = "chris_check";
            this.chris_check.Size = new System.Drawing.Size(198, 45);
            this.chris_check.TabIndex = 3;
            this.chris_check.Text = "Check";
            this.chris_check.UseVisualStyleBackColor = true;
            this.chris_check.Click += new System.EventHandler(this.chris_check_Click);
            // 
            // chris_textbox
            // 
            this.chris_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chris_textbox.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chris_textbox.Location = new System.Drawing.Point(12, 13);
            this.chris_textbox.Name = "chris_textbox";
            this.chris_textbox.PlaceholderText = "            Amount";
            this.chris_textbox.Size = new System.Drawing.Size(198, 34);
            this.chris_textbox.TabIndex = 2;
            this.chris_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chris_textbox_KeyDown);
            this.chris_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chris_textbox_KeyPress);
            // 
            // chris_remove
            // 
            this.chris_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chris_remove.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chris_remove.Location = new System.Drawing.Point(12, 104);
            this.chris_remove.Name = "chris_remove";
            this.chris_remove.Size = new System.Drawing.Size(198, 45);
            this.chris_remove.TabIndex = 1;
            this.chris_remove.Text = "Remove";
            this.chris_remove.UseVisualStyleBackColor = true;
            this.chris_remove.Click += new System.EventHandler(this.chris_remove_Click);
            // 
            // chris_add
            // 
            this.chris_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chris_add.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chris_add.Location = new System.Drawing.Point(12, 53);
            this.chris_add.Name = "chris_add";
            this.chris_add.Size = new System.Drawing.Size(198, 45);
            this.chris_add.TabIndex = 0;
            this.chris_add.Text = "Add";
            this.chris_add.UseVisualStyleBackColor = true;
            this.chris_add.Click += new System.EventHandler(this.chris_add_Click);
            // 
            // daria_panel
            // 
            this.daria_panel.Controls.Add(this.daria_check);
            this.daria_panel.Controls.Add(this.daria_textbox);
            this.daria_panel.Controls.Add(this.daria_remove);
            this.daria_panel.Controls.Add(this.daria_add);
            this.daria_panel.Location = new System.Drawing.Point(455, 107);
            this.daria_panel.Name = "daria_panel";
            this.daria_panel.Size = new System.Drawing.Size(224, 212);
            this.daria_panel.TabIndex = 4;
            // 
            // daria_check
            // 
            this.daria_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daria_check.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daria_check.Location = new System.Drawing.Point(12, 155);
            this.daria_check.Name = "daria_check";
            this.daria_check.Size = new System.Drawing.Size(198, 45);
            this.daria_check.TabIndex = 4;
            this.daria_check.Text = "Check";
            this.daria_check.UseVisualStyleBackColor = true;
            this.daria_check.Click += new System.EventHandler(this.daria_check_Click);
            // 
            // daria_textbox
            // 
            this.daria_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.daria_textbox.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daria_textbox.Location = new System.Drawing.Point(12, 13);
            this.daria_textbox.Name = "daria_textbox";
            this.daria_textbox.PlaceholderText = "            Amount";
            this.daria_textbox.Size = new System.Drawing.Size(198, 34);
            this.daria_textbox.TabIndex = 2;
            this.daria_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.daria_textbox_KeyDown);
            this.daria_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.daria_textbox_KeyPress);
            // 
            // daria_remove
            // 
            this.daria_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daria_remove.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daria_remove.Location = new System.Drawing.Point(12, 104);
            this.daria_remove.Name = "daria_remove";
            this.daria_remove.Size = new System.Drawing.Size(198, 45);
            this.daria_remove.TabIndex = 1;
            this.daria_remove.Text = "Remove";
            this.daria_remove.UseVisualStyleBackColor = true;
            this.daria_remove.Click += new System.EventHandler(this.daria_remove_Click);
            // 
            // daria_add
            // 
            this.daria_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daria_add.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daria_add.Location = new System.Drawing.Point(12, 53);
            this.daria_add.Name = "daria_add";
            this.daria_add.Size = new System.Drawing.Size(198, 45);
            this.daria_add.TabIndex = 0;
            this.daria_add.Text = "Add";
            this.daria_add.UseVisualStyleBackColor = true;
            this.daria_add.Click += new System.EventHandler(this.daria_add_Click);
            // 
            // loading_cover
            // 
            this.loading_cover.Controls.Add(this.loading_label);
            this.loading_cover.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.loading_cover.Location = new System.Drawing.Point(0, 0);
            this.loading_cover.Name = "loading_cover";
            this.loading_cover.Size = new System.Drawing.Size(757, 356);
            this.loading_cover.TabIndex = 5;
            // 
            // loading_label
            // 
            this.loading_label.AutoSize = true;
            this.loading_label.Font = new System.Drawing.Font("Microsoft JhengHei", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loading_label.Location = new System.Drawing.Point(255, 120);
            this.loading_label.Name = "loading_label";
            this.loading_label.Size = new System.Drawing.Size(239, 59);
            this.loading_label.TabIndex = 0;
            this.loading_label.Text = "Loading...";
            // 
            // score_tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 355);
            this.Controls.Add(this.loading_cover);
            this.Controls.Add(this.daria_panel);
            this.Controls.Add(this.chris_panel);
            this.Controls.Add(this.daria_score);
            this.Controls.Add(this.chris_score);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "score_tracker";
            this.Text = "Score Tracker";
            this.Load += new System.EventHandler(this.score_tracker_Load);
            this.Click += new System.EventHandler(this.score_tracker_Click);
            this.chris_panel.ResumeLayout(false);
            this.chris_panel.PerformLayout();
            this.daria_panel.ResumeLayout(false);
            this.daria_panel.PerformLayout();
            this.loading_cover.ResumeLayout(false);
            this.loading_cover.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label chris_score;
        private Label daria_score;
        private Panel chris_panel;
        private Button chris_add;
        private Button chris_remove;
        private TextBox chris_textbox;
        private Panel daria_panel;
        private TextBox daria_textbox;
        private Button daria_remove;
        private Button daria_add;
        private Button chris_check;
        private Button daria_check;
        private ToolTip tt;
        private Panel loading_cover;
        private Label loading_label;
    }
}