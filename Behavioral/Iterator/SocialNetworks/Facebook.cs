using Iterators;

namespace SocialNetworks
{
    class Facebook : ISocialNetwork
    {
        public IProfileIterator CreateFriendsIterator() => new FacebookIterator(this);
    }
}