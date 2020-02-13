namespace ChainResponsibilitiesPattern
{
    public interface IAuthorizer
    {
        IAuthorizer Next { get; set; }
        double MaximumAmount { get; }
        string AuthorizerName { get; }
        string AuthorizerRequest(Requisition requisition);
    }
}
