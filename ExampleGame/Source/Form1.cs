using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Winforms;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {
        private SpriteBatch sb;
        private Texture2D tex1;
        private Texture2D tex2;

        public Form1()
        {
            InitializeComponent();
            sb = new SpriteBatch(UniversalBackend.GraphicsDevice);
            tex1 = UniversalBackend.Content.Load<Texture2D>("Content/1");
            tex2 = UniversalBackend.Content.Load<Texture2D>("Content/2");
        }

        private void renderSurface1_Render(object sender, EventArgs e)
        {
            sb.Begin();
            sb.Draw(tex1, Vector2.Zero, Color.White);
            sb.End();
        }

        private void renderSurface2_Render(object sender, EventArgs e)
        {
            sb.Begin();
            sb.Draw(tex2, Vector2.Zero, Color.White);
            sb.End();
        }

    }
}
