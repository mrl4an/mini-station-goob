using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class SponsorManager
{
    public static int GetDonateLevel(string nickname)
    {
        int result = 0;
        if (SponsorInfoComponent.listOfSponsors.FirstOrDefault(p => p.Nickname == nickname) is { DonateLevel: var donatelevel })
        {
            result = donatelevel;
        }
        return result;
    }
    public async Task GetDonatorInfo()
    {
        try
        {
           
        }
        catch (Exception e)
        {
           
        }
    }
}
