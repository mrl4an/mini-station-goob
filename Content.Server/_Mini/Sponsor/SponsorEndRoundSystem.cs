using System;
using Content.Shared.GameTicking;
using System.Collections.Generic;
using System.Linq;
public sealed class MyRoundEndSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        
        SubscribeLocalEvent<RoundEndMessageEvent>(OnRoundEnd);
    }

    private void OnRoundEnd(RoundEndMessageEvent ev)
    {
        string nickname = "localhost@JoeGenero1_2";
        int lvl = 1;
        if (!SponsorInfoComponent.listOfSponsors.Any(d => d.Nickname == nickname))
        {
            var player = new SponsorInfoComponent.SponsorInfo(nickname, lvl);
            SponsorInfoComponent.listOfSponsors.Add(player);
            Log.Info($"плюс один подпищик{nickname}");
        }
    }
}
