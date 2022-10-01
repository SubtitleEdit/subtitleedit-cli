namespace seconv.libse.ContainerFormats.TransportStream
{
    public class EbuPesDataField
    {
        public int DataUnitId { get; set; }
        public int DataUnitLength { get; set; }
        public byte[] DataField { get; set; }
        public EbuPesDataFieldText FieldText;
    }
}
