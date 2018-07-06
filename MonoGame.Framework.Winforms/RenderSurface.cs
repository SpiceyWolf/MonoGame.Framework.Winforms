using Microsoft.Xna.Framework.Graphics;
using System;
using System.Windows.Forms;

using _designMode = VisualStudio.DesignMode;

namespace Microsoft.Xna.Framework.Winforms
{
    [System.Drawing.ToolboxBitmap(typeof(RenderSurface), "DesignerIcon")]
    public class RenderSurface : Control
    {
        private Timer _autoDraw = new Timer();
        private Color _clearColor;
        private Viewport _view;

        /// <summary>
        /// If true, will automatically redraw the
        /// surface on the specified interval.
        /// </summary>
        public bool AutoDraw
        {
            get { return _autoDraw.Enabled; }
            set { _autoDraw.Enabled = value; }
        }

        /// <summary>
        /// Specifies the interval in milliseconds
        /// to redraw the surface by.
        /// </summary>
        public int AutoDrawInterval
        {
            get { return _autoDraw.Interval; }
            set { _autoDraw.Interval = value; }
        }

        /// <summary>
        /// Changes the backcolor of the surface when in
        /// designer, and changes the clear color of the
        /// surface renderer when in runtime.
        /// </summary>
        public override System.Drawing.Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                if (!_designMode.Active)
                    _clearColor = new Color(value.R, value.G, value.B, value.A);
            }
        }

        protected override void OnCreateControl()
        {
            if (_designMode.Active)
            {
                // Set pretty icon making it clear its a MonoGame Window in designer
                BackgroundImage = Properties.Resources.DesignerIcon;
                BackgroundImageLayout = ImageLayout.Center;
            }
            else
            {
                // Initialize default properties
                BackColor = BackColor;
                _view = new Viewport(0, 0, Width, Height);

                // Setup Events
                _autoDraw.Tick += (sender, e) => { Invalidate(); };
                Render += OnRender;
                Resize += (sender, e) => { _view = new Viewport(0, 0, Width, Height); };
            }

            base.OnCreateControl();
        }
        protected override void Dispose(bool disposing)
        {
            _autoDraw.Dispose();
            base.Dispose(disposing);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_designMode.Active)
                return;

            // Begin the drawing
            UniversalBackend.BeginDraw(Width, Height);

            // Clear device
            UniversalBackend.GraphicsDevice.Clear(_clearColor);

            // Setup default view
            UniversalBackend.GraphicsDevice.Viewport = _view;

            // Invoke event based render calls
            Render?.Invoke(null, EventArgs.Empty);

            // End the drawing
            UniversalBackend.EndDraw();

            // Present the graphics to our control
            e.Graphics.DrawImage(UniversalBackend.Present(), 0, 0, Width, Height);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (_designMode.Active)
                base.OnPaintBackground(e);
        }

        public event EventHandler Render;
        protected virtual void OnRender(object sender, EventArgs e) { }
    }
}
