using System;
using System.Collections.Generic;

internal class SponsorInfoComponent
{
    public class SponsorInfo
    {
        public string Nickname { get; set; }
        public int DonateLevel { get; set; }
        public SponsorInfo(string nickname, int donateLevel)
        {
            Nickname = nickname;
            DonateLevel = donateLevel;
        }
    }
    public static List<SponsorInfo> listOfSponsors = new List<SponsorInfo>();
}
