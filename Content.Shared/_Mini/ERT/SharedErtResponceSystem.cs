
using Robust.Shared.Prototypes;
using Content.Shared.Mini.ERT.Prototypes;

namespace Content.Shared.Mini.ERT;

public abstract class SharedErtResponceSystem : EntitySystem
{
    [Dependency] private readonly IPrototypeManager _prototype = default!;

    public override void Initialize()
    {
        base.Initialize();
    }

    public int GetErtPrice(ProtoId<ErtTeamPrototype> protoId)
    {
        if (!_prototype.TryIndex(protoId, out var proto))
            return 0;

        return proto.Price;
    }
}
