namespace Common.EntityModel
{
    public abstract class TimestampEntity : IdEntity
    {
        public byte[] Timestamp { get; set; }
    }
}
