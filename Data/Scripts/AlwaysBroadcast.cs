using Sandbox.ModAPI;
using VRage.Game.Components;

namespace AlwaysBroadcast
{
    [MySessionComponentDescriptor(MyUpdateOrder.BeforeSimulation)]
    public class AlwaysBroadcast : MySessionComponentBase
    {
        public override void UpdateBeforeSimulation()
        {
            if (MyAPIGateway.Session.Player != null && MyAPIGateway.Session.Player.Character != null)
            {
                var control = MyAPIGateway.Session.Player.Character as Sandbox.Game.Entities.IMyControllableEntity;

                if (control != null)
                {
                    if (!control.EnabledBroadcasting)
                    {
                        control.SwitchBroadcasting();
                    }
                }
            }
        }
    }
}