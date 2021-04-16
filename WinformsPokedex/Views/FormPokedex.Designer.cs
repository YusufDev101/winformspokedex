
namespace WinformsPokedex.Views
{
    partial class FormPokedex
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelDrawerDex = new System.Windows.Forms.Panel();
            this.LabelDex = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelDrawerHome = new System.Windows.Forms.Panel();
            this.LabelHome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.PictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelDrawerDex.SuspendLayout();
            this.PanelDrawerHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.PictureBoxSearch);
            this.materialCard1.Controls.Add(this.TextBoxSearch);
            this.materialCard1.Controls.Add(this.ButtonBack);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(192, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1072, 62);
            this.materialCard1.TabIndex = 6;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(11, 19);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(28, 22);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "<";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(68, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.PanelDrawerDex);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.PanelDrawerHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 643);
            this.panel1.TabIndex = 7;
            // 
            // PanelDrawerDex
            // 
            this.PanelDrawerDex.BackColor = System.Drawing.Color.Transparent;
            this.PanelDrawerDex.Controls.Add(this.LabelDex);
            this.PanelDrawerDex.Controls.Add(this.pictureBox4);
            this.PanelDrawerDex.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDrawerDex.Location = new System.Drawing.Point(10, 172);
            this.PanelDrawerDex.Name = "PanelDrawerDex";
            this.PanelDrawerDex.Size = new System.Drawing.Size(172, 56);
            this.PanelDrawerDex.TabIndex = 2;
            this.PanelDrawerDex.Click += new System.EventHandler(this.PanelDrawerDex_Click);
            this.PanelDrawerDex.MouseEnter += new System.EventHandler(this.PanelDrawerDex_MouseEnter);
            this.PanelDrawerDex.MouseLeave += new System.EventHandler(this.PanelDrawerDex_MouseLeave);
            // 
            // LabelDex
            // 
            this.LabelDex.AutoSize = true;
            this.LabelDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDex.ForeColor = System.Drawing.Color.White;
            this.LabelDex.Location = new System.Drawing.Point(57, 18);
            this.LabelDex.Name = "LabelDex";
            this.LabelDex.Size = new System.Drawing.Size(77, 20);
            this.LabelDex.TabIndex = 8;
            this.LabelDex.Text = "Pokedex";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(172, 1);
            this.panel4.TabIndex = 0;
            // 
            // PanelDrawerHome
            // 
            this.PanelDrawerHome.BackColor = System.Drawing.Color.Transparent;
            this.PanelDrawerHome.Controls.Add(this.LabelHome);
            this.PanelDrawerHome.Controls.Add(this.pictureBox3);
            this.PanelDrawerHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDrawerHome.Location = new System.Drawing.Point(10, 115);
            this.PanelDrawerHome.Name = "PanelDrawerHome";
            this.PanelDrawerHome.Size = new System.Drawing.Size(172, 56);
            this.PanelDrawerHome.TabIndex = 0;
            this.PanelDrawerHome.Click += new System.EventHandler(this.PanelDrawerHome_Click);
            this.PanelDrawerHome.MouseEnter += new System.EventHandler(this.PanelDrawerHome_MouseEnter);
            this.PanelDrawerHome.MouseLeave += new System.EventHandler(this.PanelDrawerHome_MouseLeave);
            // 
            // LabelHome
            // 
            this.LabelHome.AutoSize = true;
            this.LabelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHome.ForeColor = System.Drawing.Color.White;
            this.LabelHome.Location = new System.Drawing.Point(57, 17);
            this.LabelHome.Name = "LabelHome";
            this.LabelHome.Size = new System.Drawing.Size(56, 20);
            this.LabelHome.TabIndex = 7;
            this.LabelHome.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 14);
            this.panel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(182, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 542);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 101);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 542);
            this.panel6.TabIndex = 9;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(202, 72);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1062, 571);
            this.PanelContainer.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(192, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 10);
            this.panel3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(192, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 571);
            this.panel5.TabIndex = 10;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(71, 30);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(200, 22);
            this.TextBoxSearch.TabIndex = 3;
            // 
            // PictureBoxSearch
            // 
            this.PictureBoxSearch.Image = global::WinformsPokedex.Properties.Resources.search;
            this.PictureBoxSearch.Location = new System.Drawing.Point(246, 31);
            this.PictureBoxSearch.Name = "PictureBoxSearch";
            this.PictureBoxSearch.Size = new System.Drawing.Size(23, 20);
            this.PictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSearch.TabIndex = 0;
            this.PictureBoxSearch.TabStop = false;
            this.PictureBoxSearch.Click += new System.EventHandler(this.PictureBoxSearch_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WinformsPokedex.Properties.Resources.ball;
            this.pictureBox4.Location = new System.Drawing.Point(12, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinformsPokedex.Properties.Resources.home;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::WinformsPokedex.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FormPokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 643);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.panel1);
            this.Name = "FormPokedex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokedex";
            this.Load += new System.EventHandler(this.FormPokedex_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelDrawerDex.ResumeLayout(false);
            this.PanelDrawerDex.PerformLayout();
            this.PanelDrawerHome.ResumeLayout(false);
            this.PanelDrawerHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBoxSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelDrawerDex;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PanelDrawerHome;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LabelDex;
        private System.Windows.Forms.Label LabelHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.TextBox TextBoxSearch;
    }
}