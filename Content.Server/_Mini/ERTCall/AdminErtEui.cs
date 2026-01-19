
using Content.Server.EUI;
using Content.Shared.Mini.ERT;
using Content.Shared.Eui;

namespace Content.Server.Mini.ERT;

public sealed class AdminErtEui : BaseEui
{
    public override void Opened()
    {
        StateDirty();
    }

    public override EuiStateBase GetNewState()
    {
        return new AdminErtEuiState();
    }

    // no messages to handle for now
}
