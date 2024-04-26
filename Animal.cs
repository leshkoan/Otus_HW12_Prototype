using Otus_HW12_Prototype.Interfaces;

namespace Otus_HW12_Prototype
{
    internal class Animal : IMyCloneable<Animal>, ICloneable
    {
        public string name;
        public int age;

        public Animal(string _name, int _age)
        {
            this.name = _name;
            this.age = _age;
        }

        public virtual Animal MyClone()
        {
            return new Animal(this.name, this.age);
        }

        public virtual object Clone()
        {
            return this.MyClone();
        }
    }
}
