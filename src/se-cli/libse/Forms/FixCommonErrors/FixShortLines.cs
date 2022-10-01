using seconv.libse.Common;
using seconv.libse.Interfaces;

namespace seconv.libse.Forms.FixCommonErrors
{
    public class FixShortLines : IFixCommonError
    {
        public static class Language
        {
            public static string MergeShortLine { get; set; } = "Merge short line (single sentence)";
        }

        public void Fix(Subtitle subtitle, IFixCallbacks callbacks)
        {
            string fixAction = Language.MergeShortLine;
            int noOfShortLines = 0;
            for (int i = 0; i < subtitle.Paragraphs.Count; i++)
            {
                Paragraph p = subtitle.Paragraphs[i];
                string oldText = p.Text;
                var text = Helper.FixShortLines(p.Text, callbacks.Language);
                if (callbacks.AllowFix(p, fixAction) && oldText != text)
                {
                    p.Text = text;
                    noOfShortLines++;
                    callbacks.AddFixToListView(p, fixAction, oldText, p.Text);
                }
            }
            callbacks.UpdateFixStatus(noOfShortLines, fixAction);
        }
    }
}
