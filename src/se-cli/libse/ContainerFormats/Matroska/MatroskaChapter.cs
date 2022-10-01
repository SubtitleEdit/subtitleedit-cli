namespace seconv.libse.ContainerFormats.Matroska
{
    [Serializable]
    public class MatroskaChapter
    {
        public double StartTime { get; set; }
        public string Name { get; set; }
        public bool Nested { get; set; }
    }
}
