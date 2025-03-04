// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ComplexImageAttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMComplexImageAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexImageAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMComplexImageAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexImageAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMComplexImageAttributeMetadata(bool? isPrimaryImage = default(bool?), int? maxHeight = default(int?), int? maxWidth = default(int?))
        {
            IsPrimaryImage = isPrimaryImage;
            MaxHeight = maxHeight;
            MaxWidth = maxWidth;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPrimaryImage")]
        public bool? IsPrimaryImage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxHeight")]
        public int? MaxHeight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxWidth")]
        public int? MaxWidth { get; set; }

    }
}
