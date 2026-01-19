
using Content.Server.Mini.ERT;

namespace Content.Server.Mini.ERTCall;

[RegisterComponent, Access(typeof(ErtResponceSystem))]
public sealed partial class ErtSpeciesRoleComponent : Component
{
    [ViewVariables(VVAccess.ReadOnly)]
    public WaitingSpeciesSettings? Settings;
}
