namespace Otus_HW12_Prototype.Interfaces
{
    // Создаем дженерик интерфейс IMyCloneable
    interface IMyCloneable<T>
    {
        T MyClone();
    }
}
