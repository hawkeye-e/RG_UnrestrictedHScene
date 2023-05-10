using BepInEx.Configuration;
using BepInEx.IL2CPP;

namespace UnrestrictedHScene
{
    internal class Constant
    {
        internal const int IDCounterBaseValue = 900;

        internal class HPointType
        {
            internal const int Floor = 0;
            internal const int Standing = 1;
            internal const int Wall = 2;
            internal const int Seat = 3;
            internal const int LongParkSeat = 4;
            internal const int Table = 5;
            internal const int Sofa = 6;
            internal const int Counter = 7;
            internal const int Threesome = 8;
            internal const int Special = 9;
            internal const int FoursomeFloor = 10;
            internal const int FoursomeSeat = 11;
            internal const int FoursomeWall = 12;
            internal const int FoursomeTable = 13;
            internal const int Stairs = 14;
            internal const int Pool = 15;
        }

        internal class MapType
        {
            internal const int OfficeWorkplace = 0;
            internal const int OfficePrivate = 1;
            internal const int ClinicsWorkplace = 2;
            internal const int ClinicsPrivate = 3;
            internal const int SeminarWorkplace = 4;
            internal const int SeminarPrivate = 5;
            internal const int LivehouseWorkplace = 6;
            internal const int LivehousePrivate = 7;
            internal const int CasinoWorkplace = 8;
            internal const int CasinoPrivate = 9;
            internal const int HomeWorkplace = 10;
            internal const int HomePrivate = 11;

            internal const int Cafe = 12;
            internal const int Restaurant = 13;
            internal const int Park = 14;
            internal const int Hotel = 15;

            internal const int AlleyWorkplace = 20;
            internal const int AlleyPrivate = 21;
            internal const int HotSpringWorkplace = 22;
            internal const int HotSpringPrivate = 23;
            internal const int SMRoom = 24;
        }

    }
}
