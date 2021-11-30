namespace MyLib
{
    public interface IShapeToStringUIConverter
    {
        public string MagicWord { get; }
        string convert(IShape shape);
        IShape convertBack(string buffer);
    }
}
