using System;
using GoldTree.HabboHotel.GameClients;
using GoldTree.Messages;
namespace GoldTree.Communication.Messages.Navigator
{
	internal sealed class PopularRoomsSearchMessageEvent : Interface
	{
		public void Handle(GameClient Session, ClientMessage Event)
		{
			Session.GetConnection().SendData(GoldTree.GetGame().GetNavigator().SerializeNavigator(Session, Event.PopFixedInt32()));
		}
	}
}
