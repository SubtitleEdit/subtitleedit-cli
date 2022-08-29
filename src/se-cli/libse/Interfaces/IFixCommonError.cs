using SeCli.libse.Common;

namespace SeCli.libse.Interfaces
{
    public interface IFixCommonError
    {
        void Fix(Subtitle subtitle, IFixCallbacks callbacks);
    }
}
