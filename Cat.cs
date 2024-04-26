namespace Otus_HW12_Prototype
{
    internal class Cat : Animal, ICloneable
    {
        public string color;
        public Cat(string _name, int _age, string _color) : base(_name, _age)
        {
            color = _color;
        }
        public override object Clone()
        {
            return this.MyClone();
        }

        public override Cat MyClone()
        {
            return new Cat(name, age, color);
        }
    }
}
