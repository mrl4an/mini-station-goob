
using Content.Shared.Cargo.Prototypes;
using Content.Shared.Mini.ERT.Prototypes;
using Robust.Shared.Prototypes;

namespace Content.Server.Mini.ERTCall;

[RegisterComponent]
public sealed partial class ErtResponceConsoleComponent : Component
{
    [DataField]
    public List<ProtoId<ErtTeamPrototype>> Teams = new();

    [DataField]
    public ProtoId<CargoAccountPrototype> Account = "Security";
}
