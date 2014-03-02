using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace LoLRank.Core.Services
{
    public interface ILeagueOfLegendsApiService
    {
        Task<string> Request(string url, CancellationTokenSource token = null);
        void CancelCurrent();
        void Cancel(CancellationTokenSource token);
    }
}
