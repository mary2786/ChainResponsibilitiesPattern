namespace ChainResponsibilitiesPattern
{
    /// <summary>
    /// Subdirector
    /// </summary>
    public class AssistantManager : AbstractAuthorizer
    {
        public override double MaximumAmount => 15000;

        public override string AuthorizerName => "Subdirector";
    }
}
