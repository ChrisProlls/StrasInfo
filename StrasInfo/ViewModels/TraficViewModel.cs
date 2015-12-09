using System;
using System.Collections.Generic;
using System.Text;

namespace StrasInfo.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;

    using Windows.Devices.Geolocation;


    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Threading;

    using StrasInfo.Models.TraficInfo;

    public class TraficViewModel : ViewModelBase
    {
        public ObservableCollection<TraficInfoStatus.S> TraficStatus { get; set; }
        public TraficViewModel()
        {
            this.TraficStatus = new ObservableCollection<TraficInfoStatus.S>();
        }

        public void LoadDatas()
        {
            Task.Run(
                async () =>
                {
                    TraficInfoStatus.RootObject rootObject = await TraficInfoStatus.GetInfoJson();

                    foreach (var status in rootObject.s)
                    {

                        status.Geopoint = new Geopoint(new BasicGeoposition
                        {
                            Latitude = status.go.y,
                            Longitude = status.go.x
                        });

                        await DispatcherHelper.RunAsync(() => TraficStatus.Add(status));
                    }
                });
        }
    }
}
