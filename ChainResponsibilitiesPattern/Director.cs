namespace ChainResponsibilitiesPattern
{
    public class Director : AbstractAuthorizer
    {
        public override double MaximumAmount => 50000;
        public override string AuthorizerName => "Director";

        public override string AuthorizerRequest(Requisition requisition)
        {
            string message;
            if (requisition.Amount > MaximumAmount)
            {
                message = MessageFormat.GetRejectionMessage(requisition.Concept, AuthorizerName);
            }
            else
            {
                message = MessageFormat.GetAuthorizationMessage(requisition.Concept, AuthorizerName);
            }

            return message;
        }
    }
}
