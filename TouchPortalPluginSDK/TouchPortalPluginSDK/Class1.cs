using TouchPortalPluginSDK.Annotations;

namespace TouchPortalPluginSDK
{
    [Plugin()]
    public class MyPlugin
    {
        public enum Categories
        {
            [Category()]
            BaseCategory
        }


        [Action()]
        public void Foo([Data("Label")] string label, [Data("Label 2")]string param2)
        {

        }

    }
}
