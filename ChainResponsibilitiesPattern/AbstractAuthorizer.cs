namespace ChainResponsibilitiesPattern
{
    public abstract class AbstractAuthorizer : IAuthorizer
    {
        public IAuthorizer Next { get; set; }
        public abstract double MaximumAmount { get; }
        public abstract string AuthorizerName { get; }

        public virtual string AuthorizerRequest(Requisition requisition)
        {
            string message;
            if (requisition.Amount > MaximumAmount)
            {
                message = Next.AuthorizerRequest(requisition);
            }
            else
            {
                message = MessageFormat.GetAuthorizationMessage(requisition.Concept, AuthorizerName);
            }

            return message;
        }
    }
}