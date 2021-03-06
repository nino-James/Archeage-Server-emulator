﻿using ArcheAge.ArcheAge.Network.Connections;
using LocalCommons.Network;

namespace ArcheAge.ArcheAge.Network.Packets.Server._05
{
    public sealed class NP_SCResultRestrictCheck_0x01A2 : NetPacket
    {
        public NP_SCResultRestrictCheck_0x01A2(ClientConnection net) : base(01, 0x01A2)
        {
            //SCResultRestrictCheck
            //0D00 DD01 C301 00000000 00000000 00
            ns.Write((int)0x00); //object d
            ns.Write((int)0x00);   //code d
            ns.Write((byte)0x00);  //result c
        }
    }
}