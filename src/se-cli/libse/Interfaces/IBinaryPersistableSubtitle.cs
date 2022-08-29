using SeCli.libse.Common;

namespace SeCli.libse.Interfaces
{
    public interface IBinaryPersistableSubtitle
    {
        bool Save(string fileName, Stream stream, Subtitle subtitle, bool batchMode);
    }
}
