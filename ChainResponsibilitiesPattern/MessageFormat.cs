namespace ChainResponsibilitiesPattern
{
    public static class MessageFormat
    {
        public static string GetAuthorizationMessage(string concept, string authorizer)
        {
            return string.Format("{0} \"AUTORIZADA\" por el {1}", concept, authorizer);
        }

        public static string GetRejectionMessage(string concept, string authorizer)
        {
            return string.Format("{0} \"DENEGADA\" por el {1}", concept, authorizer);
        }
    }
}
