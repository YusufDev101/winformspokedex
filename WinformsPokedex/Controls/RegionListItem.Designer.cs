
namespace WinformsPokedex.Controls
{
    partial class RegionListItem
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
            this.LabelNumber = new MaterialSkin.Controls.MaterialLabel();
            this.LabelGeneration = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.LabelNumber);
            this.materialCard1.Controls.Add(this.LabelGeneration);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(2, 2);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(117, 42);
            this.materialCard1.TabIndex = 1;
            this.materialCard1.Click += new System.EventHandler(this.materialCard1_Click);
            // 
            // LabelNumber
            // 
            this.LabelNumber.Depth = 0;
            this.LabelNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelNumber.Location = new System.Drawing.Point(13, 17);
            this.LabelNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(89, 21);
            this.LabelNumber.TabIndex = 2;
            this.LabelNumber.Text = "1";
            this.LabelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelGeneration
            // 
            this.LabelGeneration.Depth = 0;
            this.LabelGeneration.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelGeneration.Location = new System.Drawing.Point(9, 1);
            this.LabelGeneration.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelGeneration.Name = "LabelGeneration";
            this.LabelGeneration.Size = new System.Drawing.Size(95, 19);
            this.LabelGeneration.TabIndex = 1;
            this.LabelGeneration.Text = "Generation 1";
            this.LabelGeneration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PokemonListItemCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialCard1);
            this.Name = "PokemonListItemCounter";
            this.Size = new System.Drawing.Size(122, 46);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel LabelGeneration;
        private MaterialSkin.Controls.MaterialLabel LabelNumber;
    }
}
