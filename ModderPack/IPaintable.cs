using System.Drawing;

namespace ModderPack
{
    public interface IPaintable
    {
        Bitmap Icon { get; }
        string ToolTitle { get; }
        void Draw(Graphics graphics, Pen pen, int x, int y);
        void Start(int x, int y);
        void ClearObj();
        void Fill(Graphics graphics, Brush brush, int x, int y, int borderWidth);
        int needPointsToDraw { get; }
    }
}