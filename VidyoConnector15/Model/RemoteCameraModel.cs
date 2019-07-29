using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyoClient;
namespace VidyoConnector.Model
{
    public class RemoteCameraModel
    {
        public RemoteCamera Camera { get; private set; }
        public Participant Participant { get; private set; }
        public RemoteCameraModel(RemoteCamera camera, Participant participant)
        {
            Camera = camera;
            Participant = participant;
        }
        public String Name { get { return Participant.GetName(); } }
        public String Id { get { return Participant.GetId(); } }
    }
}
