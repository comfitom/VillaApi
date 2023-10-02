namespace Villa_Unity
{
    public static class SD
    {
        public static string VillaAPI { get; set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}