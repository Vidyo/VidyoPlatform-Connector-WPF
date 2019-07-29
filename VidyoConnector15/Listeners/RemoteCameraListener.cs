using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyoClient;
using VidyoConnector.Model;

namespace VidyoConnector.Listeners
{
    public class RemoteCameraListener : ListenerBase, Connector.IRegisterRemoteCameraEventListener
    {
        public RemoteCameraListener(VidyoConnector.ViewModel.VidyoConnectorViewModel viewModel) : base (viewModel)
        {

        }

        public void OnRemoteCameraAdded(RemoteCamera remoteCamera, Participant participant)
        {
            RemoteCameraModel model = new RemoteCameraModel(remoteCamera, participant);
            ViewModel.RemoteCameraAdded(model);
        }

        public void OnRemoteCameraRemoved(RemoteCamera remoteCamera, Participant participant)
        {
            RemoteCameraModel model = new RemoteCameraModel(remoteCamera, participant);
            ViewModel.RemoteCameraRemoved(model);
        }

        public void OnRemoteCameraStateUpdated(RemoteCamera remoteCamera, Participant participant, Device.DeviceState state)
        {
            RemoteCameraModel model = new RemoteCameraModel(remoteCamera, participant);
            ViewModel.RemoteCameraStateUpdated(model);
        }
    }
}
