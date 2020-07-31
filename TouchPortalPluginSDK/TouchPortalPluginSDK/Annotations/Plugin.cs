namespace TouchPortalPluginSDK.Annotations
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    class PluginAttribute : System.Attribute
    {
        public int Sdk { get; }
        
        public int Version { get; }
        
        public string Name { get; }

        public string Id { get; }

        public Configuration Configuration { get; }

        public string PluginStartCmd { get; }

        public CategoryAttribute[] Categories { get; }
    }
}
