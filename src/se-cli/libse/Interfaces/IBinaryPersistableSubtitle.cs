using seconv.libse.Common;

namespace seconv.libse.Interfaces
{
    public interface IBinaryPersistableSubtitle
    {
        bool Save(string fileName, Stream stream, Subtitle subtitle, bool batchMode);
    }
}
