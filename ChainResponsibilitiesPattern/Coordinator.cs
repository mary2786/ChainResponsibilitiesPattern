namespace ChainResponsibilitiesPattern
{
    public class Coordinator : AbstractAuthorizer
    {
        public override double MaximumAmount => 5000;

        public override string AuthorizerName => "Coordinador";
    }
}
