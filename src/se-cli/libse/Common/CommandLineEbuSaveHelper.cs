using seconv.libse.SubtitleFormats;

namespace seconv.libse.Common
{
    public class CommandLineEbuSaveHelper : Ebu.IEbuUiHelper
    {
        private Ebu.EbuGeneralSubtitleInformation _header;
        private byte _justificationCode = 2;
        private string _fileName;
        private Subtitle _subtitle;

        public void Initialize(Ebu.EbuGeneralSubtitleInformation header, byte justificationCode, string fileName, Subtitle subtitle)
        {
            _header = header;
            _justificationCode = justificationCode;
            _fileName = fileName;
            _subtitle = subtitle;
        }

        public bool ShowDialogOk()
        {
            return true;
        }

        public byte JustificationCode
        {
            get => _justificationCode;
            set => _justificationCode = value;
        }

    }
}
