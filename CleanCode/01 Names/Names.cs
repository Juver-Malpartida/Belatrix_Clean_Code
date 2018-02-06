using System.Drawing;

namespace CleanCode.Names
{
    public class Names
    {
        public Bitmap DrawToFile(string fileName)
        {
            var bitMap = new Bitmap(fileName);
            var graphics = Graphics.FromImage(bitMap);
            graphics.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 0));
            graphics.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 20));
            graphics.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 30));
            return bitMap;
        }
    }
}
