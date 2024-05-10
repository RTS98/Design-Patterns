namespace Iterators
{
    interface IProfileIterator
    {
        Profile GetNext();
        bool HasMore();
    }
}