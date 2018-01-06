using Microsoft.Azure.Mobile.Server;

namespace boephotoarchiveService.DataObjects
{
    public class Image : EntityData
    {

        public string UserID { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
}