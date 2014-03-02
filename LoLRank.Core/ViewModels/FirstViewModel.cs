using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using LoLRank.Core.Constants;
using LoLRank.Core.Responses;
using LoLRank.Core.Services;
using Newtonsoft.Json;

namespace LoLRank.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _raw;
        private string _time;
        private string _url;
        private bool _cancelable;
        private readonly ILeagueOfLegendsApiService _leagueOfLegendsService;
        private CancellationTokenSource _token;

        public FirstViewModel(ILeagueOfLegendsApiService leagueOfLegendsService)
        {
            _leagueOfLegendsService = leagueOfLegendsService;
            Url = String.Format("https://prod.api.pvp.net/api/lol/na/v1.1/summoner/by-name/RiotSchmick?api_key={0}", ApiKeyConst.Key);
        }

        public string Raw
        {
            get { return _raw; }
            set
            {
                _raw = value;
                RaisePropertyChanged(() => Raw);
            }
        }

        public string Time
        {
            get { return _time; }
            set
            {
                _time = value;
                RaisePropertyChanged(() => Time);
            }
        }

        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
                RaisePropertyChanged(() => Url);
            }
        }

        public bool Cancelable
        {
            get { return _cancelable; }
            set
            {
                _cancelable = value;
                RaisePropertyChanged(() => Cancelable);
            }
        }

        private SummonerDto _summoner;

        public SummonerDto Summoner
        {
            get { return _summoner; }
            set
            {
                _summoner = value;
                RaisePropertyChanged(() => Summoner);
            }
        }

        public ICommand CancelCommand
        {
            get
            {
                return new MvxCommand(() => _leagueOfLegendsService.Cancel(_token), () => Cancelable);
            }
        }

        public ICommand DownloadCommand
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    var st = new Stopwatch();

                    st.Start();
                    Time = "0";

                    try
                    {
                        if (Cancelable)
                        {
                            _token = new CancellationTokenSource();
                            Raw = await _leagueOfLegendsService.Request(Url);
                        }
                        else
                        {
                            Raw = await _leagueOfLegendsService.Request(Url, _token);
                            Summoner = JsonConvert.DeserializeObject<SummonerDto>(Raw);
                        }
                    }
                    catch (Exception ex)
                    {
                        Raw = "Exception " + ex;
                    }
                    finally
                    {
                        st.Stop();
                        Time = st.Elapsed.Seconds.ToString();
                    }
                });
            }
        }

    }
}
