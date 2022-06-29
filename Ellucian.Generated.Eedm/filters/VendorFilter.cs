using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Filters used in the vendors API
    /// </summary>
    public class VendorFilter
    {
        /// <summary>
        /// Filter for the person or organization acting as the vendor.
        /// </summary>
        public string vendorDetail { get; set; }

        /// <summary>
        /// The vendor's classification (E.g. federal contract, small business, etc.)
        /// </summary>
        public string classifications { get; set; }

        /// <summary>
        /// The statuses (active, approved, stop payment) that apply to the vendor.
        /// </summary>
        public List<string> statuses { get; set; }

        /// <summary>
        /// The vendor assigned to receive payment for this vendor or the parent vendor.
        /// </summary>
        public List<string> relatedReference { get; set; }

        /// <summary>
        /// Indicates whether a vendor is of the type eProcurement or travel
        /// </summary>
        public string vendorType { get; set; }
    }
}
