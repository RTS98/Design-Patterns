using Iterators;

namespace SocialNetworks
{
    interface ISocialNetwork
    {
        IProfileIterator CreateFriendsIterator();
    }
}