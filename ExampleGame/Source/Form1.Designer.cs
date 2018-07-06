namespace Game1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.renderSurface1 = new Microsoft.Xna.Framework.Winforms.RenderSurface();
            this.renderSurface2 = new Microsoft.Xna.Framework.Winforms.RenderSurface();
            this.renderPanel1 = new Microsoft.Xna.Framework.Winforms.RenderPanel();
            this.lblPanel = new System.Windows.Forms.Label();
            this.renderPanel2 = new Microsoft.Xna.Framework.Winforms.RenderPanel();
            this.lblSurface = new System.Windows.Forms.Label();
            this.renderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderSurface1
            // 
            this.renderSurface1.AutoDraw = false;
            this.renderSurface1.AutoDrawInterval = 100;
            this.renderSurface1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.renderSurface1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("renderSurface1.BackgroundImage")));
            this.renderSurface1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.renderSurface1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.renderSurface1.Location = new System.Drawing.Point(13, 13);
            this.renderSurface1.Name = "renderSurface1";
            this.renderSurface1.Size = new System.Drawing.Size(148, 165);
            this.renderSurface1.TabIndex = 0;
            this.renderSurface1.Text = "renderSurface1";
            this.renderSurface1.Render += new System.EventHandler(this.renderSurface1_Render);
            // 
            // renderSurface2
            // 
            this.renderSurface2.AutoDraw = true;
            this.renderSurface2.AutoDrawInterval = 100;
            this.renderSurface2.BackColor = System.Drawing.Color.LightCoral;
            this.renderSurface2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("renderSurface2.BackgroundImage")));
            this.renderSurface2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.renderSurface2.Location = new System.Drawing.Point(167, 13);
            this.renderSurface2.Name = "renderSurface2";
            this.renderSurface2.Size = new System.Drawing.Size(148, 165);
            this.renderSurface2.TabIndex = 1;
            this.renderSurface2.Text = "renderSurface2";
            this.renderSurface2.Render += new System.EventHandler(this.renderSurface2_Render);
            // 
            // renderPanel1
            // 
            this.renderPanel1.AutoDraw = true;
            this.renderPanel1.AutoDrawInterval = 100;
            this.renderPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.renderPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("renderPanel1.BackgroundImage")));
            this.renderPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.renderPanel1.Controls.Add(this.lblPanel);
            this.renderPanel1.Location = new System.Drawing.Point(13, 184);
            this.renderPanel1.Name = "renderPanel1";
            this.renderPanel1.Size = new System.Drawing.Size(148, 165);
            this.renderPanel1.TabIndex = 2;
            this.renderPanel1.Render += new System.EventHandler(this.renderSurface2_Render);
            // 
            // lblPanel
            // 
            this.lblPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblPanel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel.ForeColor = System.Drawing.Color.Black;
            this.lblPanel.Location = new System.Drawing.Point(10, 43);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(124, 96);
            this.lblPanel.TabIndex = 0;
            this.lblPanel.Text = "I take the background image of the rendered panel!";
            // 
            // renderPanel2
            // 
            this.renderPanel2.AutoDraw = true;
            this.renderPanel2.AutoDrawInterval = 100;
            this.renderPanel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.renderPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("renderPanel2.BackgroundImage")));
            this.renderPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.renderPanel2.Location = new System.Drawing.Point(167, 184);
            this.renderPanel2.Name = "renderPanel2";
            this.renderPanel2.Size = new System.Drawing.Size(148, 165);
            this.renderPanel2.TabIndex = 3;
            this.renderPanel2.Render += new System.EventHandler(this.renderSurface1_Render);
            // 
            // lblSurface
            // 
            this.lblSurface.BackColor = System.Drawing.Color.Transparent;
            this.lblSurface.Location = new System.Drawing.Point(177, 62);
            this.lblSurface.Name = "lblSurface";
            this.lblSurface.Size = new System.Drawing.Size(100, 65);
            this.lblSurface.TabIndex = 4;
            this.lblSurface.Text = "I suck and overlap the render image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 365);
            this.Controls.Add(this.lblSurface);
            this.Controls.Add(this.renderPanel2);
            this.Controls.Add(this.renderPanel1);
            this.Controls.Add(this.renderSurface2);
            this.Controls.Add(this.renderSurface1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.renderPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Xna.Framework.Winforms.RenderSurface renderSurface1;
        private Microsoft.Xna.Framework.Winforms.RenderSurface renderSurface2;
        private Microsoft.Xna.Framework.Winforms.RenderPanel renderPanel1;
        private System.Windows.Forms.Label lblPanel;
        private Microsoft.Xna.Framework.Winforms.RenderPanel renderPanel2;
        private System.Windows.Forms.Label lblSurface;
    }
}