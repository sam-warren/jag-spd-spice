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
    /// CanBeReferencingResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMCanBeReferencingResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCanBeReferencingResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCanBeReferencingResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCanBeReferencingResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCanBeReferencingResponse(bool? canBeReferencing = default(bool?))
        {
            CanBeReferencing = canBeReferencing;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanBeReferencing")]
        public bool? CanBeReferencing { get; set; }

    }
}
