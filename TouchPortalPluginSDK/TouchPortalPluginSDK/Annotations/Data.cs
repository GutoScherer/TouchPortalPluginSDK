namespace TouchPortalPluginSDK.Annotations
{
    [System.AttributeUsage(System.AttributeTargets.Parameter)]
    class DataAttribute : System.Attribute
    {
        public string Label { get; }

        public DataAttribute(string label)
        {
            Label = label;
        }
    }
}
