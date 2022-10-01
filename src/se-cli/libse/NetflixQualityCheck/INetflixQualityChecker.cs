using seconv.libse.Common;

namespace seconv.libse.NetflixQualityCheck
{
    public interface INetflixQualityChecker
    {
        void Check(Subtitle subtitle, NetflixQualityController controller);
    }
}
