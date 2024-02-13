using System;
using System.Collections.Generic;
using System.Text;

namespace RewardPointsCalulation
{
    class CustomerResponseModel
    {
        public string CustomerName { get; set; }
        public List<int> Transaction { get; set; }
    }
}
