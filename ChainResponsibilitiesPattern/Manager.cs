namespace ChainResponsibilitiesPattern
{
    /// <summary>
    /// Gerente
    /// </summary>
    public class Manager : AbstractAuthorizer
    {
        public override double MaximumAmount => 10000;

        public override string AuthorizerName => "Gerente";
    }
}
