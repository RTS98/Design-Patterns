using SocialNetworks;

namespace Iterators
{
    class FacebookIterator(Facebook facebook) : IProfileIterator
    {
        private readonly Facebook _facebook = facebook;
        private readonly Profile[] Profiles = [];

        private int CurrentPosition = 0;

        public Profile GetNext()
        {
            if (HasMore())
            {
                CurrentPosition++;
            }

            return Profiles[CurrentPosition];
        }

        public bool HasMore() => CurrentPosition < Profiles.Length;
    }
}