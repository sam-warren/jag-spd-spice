// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of spice_govministry
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.spice_govministryCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMspiceGovministryCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceGovministryCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceGovministryCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceGovministryCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceGovministryCollection(IList<MicrosoftDynamicsCRMspiceGovministry> value = default(IList<MicrosoftDynamicsCRMspiceGovministry>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMspiceGovministry> Value { get; set; }

    }
}
