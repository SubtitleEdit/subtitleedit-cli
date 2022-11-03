namespace seconv.libse.ContainerFormats.Mp4
{
    public class SampleToChunkMap
    {
        public uint FirstChunk { get; set; }
        public uint SamplesPerChunk { get; set; }
        public uint SampleDescriptionIndex { get; set; }
    }
}
