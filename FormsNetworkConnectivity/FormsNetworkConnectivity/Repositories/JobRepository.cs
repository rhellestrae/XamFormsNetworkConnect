using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsNetworkConnectivity.Interfaces;

namespace FormsNetworkConnectivity.Repositories
{
    public class JobRepository : IJobRepository
    {
        public string GetName()
        {
            return "Divikiran";
        }
    }
}
