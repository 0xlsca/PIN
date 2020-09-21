﻿using System;
using System.Collections.Generic;
using System.Text;

using MyGameServer.Packets.GSS.Character.BaseController;

using Shared.Udp;

namespace MyGameServer.Controllers.Character {
	[ControllerID(Enums.GSS.Controllers.Character_BaseController)]
	internal class BaseController : Base {
		public override void Init( INetworkClient client, IPlayer player, IShard shard ) {
			// TODO: Implement
			client.NetChans[ChannelType.ReliableGss].SendGSSClass(Test.GSS.Character.BaseController.KeyFrame.Test(player, shard), player.EntityID, msgEnumType: typeof(Enums.GSS.Character.Events));
			client.NetChans[ChannelType.ReliableGss].SendGSSClass( new Packets.GSS.Character.CombatController.KeyFrame() { PlayerID = player.CharacterID }, player.EntityID, msgEnumType: typeof( Enums.GSS.Character.Events ) );
			client.NetChans[ChannelType.ReliableGss].SendGSSClass( new Packets.GSS.Character.LocalEffectsController.KeyFrame() { PlayerID = player.CharacterID }, player.EntityID, msgEnumType: typeof( Enums.GSS.Character.Events ) );
			client.NetChans[ChannelType.ReliableGss].SendGSSClass( new Packets.GSS.Character.MissionAndMarkerController.KeyFrame() { PlayerID = player.CharacterID }, player.EntityID, msgEnumType: typeof( Enums.GSS.Character.Events ) );
			//client.NetChans[ChannelType.ReliableGss].SendGSSClass( new CharacterLoaded(), player.EntityID, msgEnumType: typeof( Enums.GSS.Character.Events ) );
		}

		[MessageID((byte)Enums.GSS.Character.Commands.FetchQueueInfo)]
		public void FetchQueueInfo( INetworkClient client, IPlayer player, ulong EntityID, Packets.GamePacket packet ) {
		}

		[MessageID((byte)Enums.GSS.Character.Commands.PlayerReady)]
		public void PlayerReady( INetworkClient client, IPlayer player, ulong EntityID, Packets.GamePacket packet ) {
			// TODO: Implement
			player.Ready();
		}

		[MessageID((byte)Enums.GSS.Character.Commands.MovementInput)]
		public void MovementInput( INetworkClient client, IPlayer player, ulong EntityID, Packets.GamePacket packet ) {
			// TODO: Implement
		}

		[MessageID((byte)Enums.GSS.Character.Commands.SetMovementSimulation)]
		public void SetMovementSimulation( INetworkClient client, IPlayer player, ulong EntityID, Packets.GamePacket packet ) {
			// TODO: Implement
		}

		[MessageID((byte)Enums.GSS.Character.Commands.BagInventorySettings)]
		public void BagInventorySettings( INetworkClient client, IPlayer player, ulong EntityID, Packets.GamePacket packet ) {
		}
	}
}