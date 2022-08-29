using SeCli.libse.Common;

namespace SeCli.libse.NetflixQualityCheck
{
    public interface INetflixQualityChecker
    {
        void Check(Subtitle subtitle, NetflixQualityController controller);
    }
}
