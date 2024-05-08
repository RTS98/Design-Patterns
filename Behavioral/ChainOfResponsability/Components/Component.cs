namespace Components
{
    abstract class Component(string? TooltipText) : IComponent
    {
        protected Container? container;
        protected string? toolTipText = TooltipText;

        public virtual void ShowHelp()
        {
            if (toolTipText != null)
            {
                Console.WriteLine(toolTipText);
            }
            else
            {
                container?.ShowHelp();
            }
        }
    }
}

