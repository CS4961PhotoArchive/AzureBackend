using Microsoft.Azure.Mobile.Server;

namespace boephotoarchiveService.DataObjects
{
    public class ICAV : EntityData
    {
    

        public string ImageID { get; set; }
        public string ContextID { get; set; }
        public string AttributeID { get; set; }
        public string Value { get; set; }

    }
}