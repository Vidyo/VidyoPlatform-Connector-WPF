using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyoClient;
namespace VidyoConnector.Listeners
{
    public class RemoteWindowShareListener : ListenerBase, Connector.IRegisterRemoteWindowShareEventListener
    {
        public RemoteWindowShareListener(ViewModel.VidyoConnectorViewModel viewModel): base(viewModel)
        {

        }
        public void OnRemoteWindowShareAdded(RemoteWindowShare remoteWindowShare, Participant participant)
        {
            this.ViewModel.OnRemoteWindowShareAdded(remoteWindowShare, participant);
        }

        public void OnRemoteWindowShareRemoved(RemoteWindowShare remoteWindowShare, Participant participant)
        {
            this.ViewModel.OnRemoteWindowShareRemoved(remoteWindowShare, participant);
        }

        public void OnRemoteWindowShareStateUpdated(RemoteWindowShare remoteWindowShare, Participant participant, Device.DeviceState state)
        {
            
        }
    }
}
