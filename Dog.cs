namespace Otus_HW12_Prototype
{
    internal class Dog : Animal, ICloneable
    {
        public string breed;
        public Dog(string _name, int _age, string _breed) : base(_name, _age)
        {
            breed = _breed;  
        }
        public override object Clone()
        {
            return this.MyClone();
        }

        public override Dog MyClone()
        {
            return new Dog(name, age, breed);
        }
    }
}
