using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicket
{
    public interface IWallet
    {
        double WalletBalance{get;set;}
        void RechargeWallet();

    }
}