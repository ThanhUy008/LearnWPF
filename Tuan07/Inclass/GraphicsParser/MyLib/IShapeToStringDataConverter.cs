namespace MyLib
{
    public interface IShapeToStringDataConverter
    {
        public string MagicWord { get; }
        string Convert(IShape shape);
        IShape ConvertBack(string buffer);
    }
}
