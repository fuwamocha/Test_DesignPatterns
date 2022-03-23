namespace TestDecorator
{
    public abstract class Beverage
    {
        public string Description { get; set; } = "不明";

        public enum Size
        {
            Tall,
            Grande,
            Venti
        }

        private Size _size;

        public virtual string GetDescription()
        {
            return Description;
        }

        public virtual Size GetSize()
        {
            return _size;
        }

        public void SetSize(Size size)
        {
            _size = size;
        }

        public abstract float Cost();
    }
}