using System.Drawing;
using seconv.libse.Common;

namespace seconv.libse.ContainerFormats.TransportStream
{
    public class TransportStreamSubtitle 
    {
        public Position TransportStreamPosition { get; set; }

        public ulong StartMilliseconds { get; set; }

        public ulong EndMilliseconds { get; set; }

        public DvbSubPes Pes { get; set; }
        //private readonly BluRaySup.BluRaySupParser.PcsData _bdSup;
        public int? ActiveImageIndex { get; set; }

        public bool IsBluRaySup => false;

        public bool IsDvbSub => Pes != null;

        public TransportStreamSubtitle()
        {
        }

        public TransportStreamSubtitle(ulong startMilliseconds, ulong endMilliseconds)
        {
            StartMilliseconds = startMilliseconds;
            EndMilliseconds = endMilliseconds;
        }

        

        public Size GetScreenSize()
        {

            if (Pes != null)
            {
                return Pes.GetScreenSize();
            }

            return new Size(DvbSubPes.DefaultScreenWidth, DvbSubPes.DefaultScreenHeight);
        }

        public bool IsForced
        {
            get
            {

                return false;
            }
        }

        public Position GetPosition()
        {

            if (TransportStreamPosition != null)
            {
                return TransportStreamPosition;
            }

            return new Position(0, 0);
        }

        public TimeCode StartTimeCode => new TimeCode(StartMilliseconds);

        public TimeCode EndTimeCode => new TimeCode(EndMilliseconds);
    }
}
