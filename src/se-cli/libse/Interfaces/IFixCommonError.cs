using seconv.libse.Common;

namespace seconv.libse.Interfaces
{
    public interface IFixCommonError
    {
        void Fix(Subtitle subtitle, IFixCallbacks callbacks);
    }
}
