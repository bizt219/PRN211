namespace MyDiary_2
{
    partial class Form2
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
            this.dgDiary = new System.Windows.Forms.DataGridView();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnUnfavorite = new System.Windows.Forms.Button();
            this.btnFavoriteView = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDiary
            // 
            this.dgDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiary.Location = new System.Drawing.Point(30, 30);
            this.dgDiary.Name = "dgDiary";
            this.dgDiary.ReadOnly = true;
            this.dgDiary.RowTemplate.Height = 25;
            this.dgDiary.Size = new System.Drawing.Size(383, 450);
            this.dgDiary.TabIndex = 0;
            this.dgDiary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDiary_CellClick);
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContent.Location = new System.Drawing.Point(527, 77);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(529, 335);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(983, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(632, 508);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(169, 33);
            this.txtPass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(527, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(30, 510);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(309, 513);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(858, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ẩn/Bỏ ẩn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDate.Location = new System.Drawing.Point(765, 25);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(291, 33);
            this.txtDate.TabIndex = 2;
            // 
            // btnFavorite
            // 
            this.btnFavorite.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFavorite.Location = new System.Drawing.Point(623, 428);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(77, 36);
            this.btnFavorite.TabIndex = 5;
            this.btnFavorite.Text = "Thích";
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnUnfavorite
            // 
            this.btnUnfavorite.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUnfavorite.Location = new System.Drawing.Point(729, 428);
            this.btnUnfavorite.Name = "btnUnfavorite";
            this.btnUnfavorite.Size = new System.Drawing.Size(103, 36);
            this.btnUnfavorite.TabIndex = 5;
            this.btnUnfavorite.Text = "Bỏ Thích";
            this.btnUnfavorite.UseVisualStyleBackColor = true;
            this.btnUnfavorite.Click += new System.EventHandler(this.btnUnfavorite_Click);
            // 
            // btnFavoriteView
            // 
            this.btnFavoriteView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFavoriteView.Location = new System.Drawing.Point(936, 505);
            this.btnFavoriteView.Name = "btnFavoriteView";
            this.btnFavoriteView.Size = new System.Drawing.Size(120, 36);
            this.btnFavoriteView.TabIndex = 5;
            this.btnFavoriteView.Text = "Xem Thích";
            this.btnFavoriteView.UseVisualStyleBackColor = true;
            this.btnFavoriteView.Click += new System.EventHandler(this.btnFavoriteView_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(818, 508);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(102, 33);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyDiary_2.Properties.Resources.leather_texture_background_leather_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFavoriteView);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUnfavorite);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.dgDiary);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDiary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgDiary;
        private RichTextBox txtContent;
        private Button btnSave;
        private TextBox txtPass;
        private Label label2;
        private Button btnBack;
        private Button btnDelete;
        private Button button1;
        private TextBox txtDate;
        private Button btnFavorite;
        private Button btnUnfavorite;
        private Button btnFavoriteView;
        private Button btnView;
    }
}