using System.Collections.Generic;
namespace RazorPagesMovie.Models{

     public class ViewModelDashboard
    {
        public IEnumerable<DataMerchant> Datamerchant { get; set; }
        public IEnumerable<DataMerchant> Datatrxgeopagos { get; set; }
        public IEnumerable<LogOpeFlow>  LogOpeFlow { get; set; }

    }
    
}