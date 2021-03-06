// <auto-generated />
namespace Microsoft.Extensions.ApiDescription.Client
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.Extensions.ApiDescription.Client.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Multiple items have OutputPath='{0}'. All OpenApiReference items must have unique OutputPath metadata.
        /// </summary>
        internal static string DuplicateFileOutputPaths
        {
            get => GetString("DuplicateFileOutputPaths");
        }

        /// <summary>
        /// Multiple items have OutputPath='{0}'. All OpenApiReference items must have unique OutputPath metadata.
        /// </summary>
        internal static string FormatDuplicateFileOutputPaths(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DuplicateFileOutputPaths"), p0);

        /// <summary>
        /// Invalid {0} metadata value for {1} item '{2}'. {0} metadata must not be set to the empty string.
        /// </summary>
        internal static string InvalidEmptyMetadataValue
        {
            get => GetString("InvalidEmptyMetadataValue");
        }

        /// <summary>
        /// Invalid {0} metadata value for {1} item '{2}'. {0} metadata must not be set to the empty string.
        /// </summary>
        internal static string FormatInvalidEmptyMetadataValue(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidEmptyMetadataValue"), p0, p1, p2);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
