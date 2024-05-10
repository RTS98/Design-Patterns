using Iterators;
using SocialNetworks;

class Program
{
    public static void Main(string[] args)
    {
        Facebook network = new();
        IProfileIterator iterator = network.CreateFriendsIterator();

        while (iterator.HasMore())
        {
            Profile profile = iterator.GetNext();

            // Perform action
        }
    }
}