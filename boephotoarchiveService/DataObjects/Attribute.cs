using Microsoft.Azure.Mobile.Server;

namespace boephotoarchiveService.DataObjects
{
    public class Attribute : EntityData
    {
        public string Question { get; set; }
        public string FieldType { get; set; }
        public string Required { get; set; }
        public string PossibleValues { get; set; }
    }
}