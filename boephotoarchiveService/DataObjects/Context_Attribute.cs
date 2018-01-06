using Microsoft.Azure.Mobile.Server;

namespace boephotoarchiveService.DataObjects
{
    public class Context_Attribute : EntityData
    {
     
        public string ContextID { get; set; }
        public string AttributeID { get; set; }
        public int SortNumber { get; set; }
    }
}