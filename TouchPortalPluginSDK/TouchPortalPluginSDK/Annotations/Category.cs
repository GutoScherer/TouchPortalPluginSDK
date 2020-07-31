namespace TouchPortalPluginSDK.Annotations
{
    [System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field)]
    class CategoryAttribute : System.Attribute
    {

        public string Id { get; }

        public string Name { get; }

        public string ImagePath { get; }

        public ActionAttribute[] Actions { get; }

        public EventAttribute[] Events { get; }

        public StateAttribute[] States { get; }
    }
}
