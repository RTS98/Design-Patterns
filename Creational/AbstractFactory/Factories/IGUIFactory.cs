using Buttons;
using Checkboxes;

namespace Factories
{
    interface IGUIFactory
    {
        public IButton CreateButton();
        
        public ICheckbox CreateCheckbox();
    }
}