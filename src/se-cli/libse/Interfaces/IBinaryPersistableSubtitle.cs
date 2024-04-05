using seconv.libse.Common;
using System.Text;

namespace seconv.libse.Interfaces
{
    public interface IBinaryPersistableSubtitle
    {
        bool Save(string fileName, Stream stream, Subtitle subtitle, StringBuilder log, bool batchMode);
    }
}
