
namespace WinformsPokedex.Controls
{
    partial class PokemonListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.PictureMenu = new System.Windows.Forms.PictureBox();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.PanelColor = new System.Windows.Forms.Panel();
            this.LabelTypes2 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelTypes1 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelName = new MaterialSkin.Controls.MaterialLabel();
            this.ImagePokemon = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.PictureMenu);
            this.materialCard1.Controls.Add(this.LabelNumber);
            this.materialCard1.Controls.Add(this.PanelColor);
            this.materialCard1.Controls.Add(this.LabelTypes2);
            this.materialCard1.Controls.Add(this.LabelTypes1);
            this.materialCard1.Controls.Add(this.LabelName);
            this.materialCard1.Controls.Add(this.ImagePokemon);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(2, 3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(158, 237);
            this.materialCard1.TabIndex = 1;
            this.materialCard1.Click += new System.EventHandler(this.materialCard1_Click);
            // 
            // PictureMenu
            // 
            this.PictureMenu.Image = global::WinformsPokedex.Properties.Resources.dots;
            this.PictureMenu.Location = new System.Drawing.Point(128, -1);
            this.PictureMenu.Name = "PictureMenu";
            this.PictureMenu.Size = new System.Drawing.Size(29, 22);
            this.PictureMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureMenu.TabIndex = 5;
            this.PictureMenu.TabStop = false;
            this.PictureMenu.Click += new System.EventHandler(this.PictureMenu_Click);
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.BackColor = System.Drawing.Color.Transparent;
            this.LabelNumber.Location = new System.Drawing.Point(2, 2);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(19, 13);
            this.LabelNumber.TabIndex = 0;
            this.LabelNumber.Text = "01";
            // 
            // PanelColor
            // 
            this.PanelColor.Location = new System.Drawing.Point(20, 2);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Size = new System.Drawing.Size(120, 5);
            this.PanelColor.TabIndex = 2;
            // 
            // LabelTypes2
            // 
            this.LabelTypes2.Depth = 0;
            this.LabelTypes2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelTypes2.Location = new System.Drawing.Point(84, 199);
            this.LabelTypes2.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTypes2.Name = "LabelTypes2";
            this.LabelTypes2.Size = new System.Drawing.Size(63, 19);
            this.LabelTypes2.TabIndex = 4;
            this.LabelTypes2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTypes1
            // 
            this.LabelTypes1.Depth = 0;
            this.LabelTypes1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelTypes1.Location = new System.Drawing.Point(15, 199);
            this.LabelTypes1.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTypes1.Name = "LabelTypes1";
            this.LabelTypes1.Size = new System.Drawing.Size(63, 19);
            this.LabelTypes1.TabIndex = 3;
            this.LabelTypes1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelName
            // 
            this.LabelName.Depth = 0;
            this.LabelName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelName.Location = new System.Drawing.Point(6, 169);
            this.LabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(150, 19);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Pikachu";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImagePokemon
            // 
            this.ImagePokemon.Image = global::WinformsPokedex.Properties.Resources.logo;
            this.ImagePokemon.Location = new System.Drawing.Point(4, 27);
            this.ImagePokemon.Name = "ImagePokemon";
            this.ImagePokemon.Size = new System.Drawing.Size(150, 136);
            this.ImagePokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePokemon.TabIndex = 0;
            this.ImagePokemon.TabStop = false;
            this.ImagePokemon.Click += new System.EventHandler(this.ImagePokemon_Click);
            // 
            // PokemonListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialCard1);
            this.Name = "PokemonListItem";
            this.Size = new System.Drawing.Size(162, 243);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePokemon;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel LabelName;
        private MaterialSkin.Controls.MaterialLabel LabelTypes1;
        private MaterialSkin.Controls.MaterialLabel LabelTypes2;
        private System.Windows.Forms.Panel PanelColor;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.PictureBox PictureMenu;
    }
}
