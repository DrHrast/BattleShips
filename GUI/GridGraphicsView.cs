using Microsoft.Maui.Graphics.Platform;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Controls;

namespace GUI
{
    class GridGraphicsView : GraphicsView
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        public GridGraphicsView(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Drawable = new GridDrawable(rows, columns);
        }

        public class GridDrawable : IDrawable
        {
            private int _rows;
            private int _columns;

            public GridDrawable(int rows, int columns)
            {
                _rows = rows;
                _columns = columns;
            }

            public void Draw(ICanvas canvas, RectF dirtyRect)
            {
                float cellWidth = dirtyRect.Width / _columns;
                float cellHeight = dirtyRect.Height / _rows;

                canvas.StrokeColor = Colors.Black;
                canvas.StrokeSize = 1;

                for (int i = 0; i <= _rows; i++)
                {
                    float y = i * cellHeight;
                    canvas.DrawLine(0, y, dirtyRect.Width, y);
                }

                for (int i = 0; i <= _columns; i++)
                {
                    float x = i * cellWidth;
                    canvas.DrawLine(x, 0, x, dirtyRect.Height);
                }
            }
        }
    }
}
