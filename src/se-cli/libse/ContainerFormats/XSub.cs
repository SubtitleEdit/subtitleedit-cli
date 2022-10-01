using System.Drawing;
using seconv.libse.Common;

namespace seconv.libse.ContainerFormats
{
    public class XSub
    {
        public TimeCode Start { get; set; }
        public TimeCode End { get; set; }
        public int Width { get; }
        public int Height { get; }

        private readonly byte[] _colorBuffer;
        private readonly byte[] _rleBuffer;

        public XSub(string timeCode, int width, int height, byte[] colors, byte[] rle)
        {
            Start = DecodeTimeCode(timeCode.Substring(0, 13));
            End = DecodeTimeCode(timeCode.Substring(13, 12));
            Width = width;
            Height = height;
            _colorBuffer = colors;
            _rleBuffer = rle;
        }

        private static TimeCode DecodeTimeCode(string timeCode)
        {
            var parts = timeCode.Split(new[] { ':', ';', '.', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
            return new TimeCode(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
        }
        
        private static int GetNibble(byte[] buf, int nibbleOffset)
        {
            return (buf[nibbleOffset >> 1] >> ((1 - (nibbleOffset & 1)) << 2)) & 0xf;
        }

        

        private Color GetColor(int start)
        {
            return Color.FromArgb(_colorBuffer[start], _colorBuffer[start + 1], _colorBuffer[start + 2]);
        }

    }
}
