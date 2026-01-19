
using Content.Shared.Mini.TimeWindow;

namespace Content.Server.Mini.ERTCall;

[RegisterComponent]
public sealed partial class ErtComputerShuttleComponent : Component
{
    [DataField]
    [ViewVariables(VVAccess.ReadOnly)]
    public bool IsEvacuation = false;

    [DataField]
    [ViewVariables(VVAccess.ReadOnly)]
    public TimedWindow EvacuationWindow = new(TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(10));

    [DataField]
    [ViewVariables(VVAccess.ReadOnly)]
    public TimeSpan NextAnnounceTime = TimeSpan.Zero;
}
