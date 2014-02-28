﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using Terraria;
using TerrariaApi.Server;

namespace Buff
{
    [ApiVersion(1, 15)]

    public class Buff : TerrariaPlugin
    {
        public Buff(Main game)
            : base(game)
        {
            Order = 4;
        }
        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command("", Rbuff, "regen"));
            Commands.ChatCommands.Add(new Command("", Mbuff, "melee"));
        }

        public override Version Version
        {
            get { return new Version("1.0"); }

        }

        public override string Name
        {
            get { return "Buffs"; }
        }

        public override string Author
        {
            get { return "dunkston"; }
        }

        public override string Description
        {
            get { return "Useful buffs"; }
        }

        private void Rbuff(CommandArgs args)
        {
            if (args.Player != null)
            {
                args.Player.SetBuff(2, 30000, true);
                args.Player.SetBuff(5, 30000, true);
                args.Player.SetBuff(26, 30000, true);
                args.Player.SetBuff(48, 30000, true);
                args.Player.SetBuff(58, 30000, true);
                args.Player.SetBuff(87, 30000, true);
                args.Player.SetBuff(89, 30000, true);

                args.Player.SendSuccessMessage("You got buffed");
            }
        }
          private void Mbuff(CommandArgs args)
        {
            if (args.Player != null)
            {
                args.Player.SetBuff(14, 30000, true);
                args.Player.SetBuff(25, 30000, true);
                args.Player.SetBuff(26, 30000, true);
                args.Player.SetBuff(62, 30000, true);
                args.Player.SetBuff(76, 30000, true);

                args.Player.SendSuccessMessage("You got buffed");
            }
        }
    }
}