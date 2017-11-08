using Microsoft.Azure.Mobile.Server;

namespace boephotoarchiveService.DataObjects
{
    public class Image : EntityData
    {

        public string UserID { get; set; }
        public float Lat { get; set; }
        public float Lon { get; set; }
    }
}