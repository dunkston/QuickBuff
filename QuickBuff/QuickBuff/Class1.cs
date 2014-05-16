using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TShockAPI;
using Terraria;
using TerrariaApi.Server;

namespace QuickBuff
{
    [ApiVersion(1, 16)]

    public class QuickBuff : TerrariaPlugin
    {
        public QuickBuff(Main game)
            : base(game)
        {
            Order = 4;
        }

        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command(new List<string>() { "qb.regen", "qb.all" }, Rbuff, "regen"));
            Commands.ChatCommands.Add(new Command(new List<string>() { "qb.melee", "qb.all" }, Mbuff, "melee"));
            Commands.ChatCommands.Add(new Command(new List<string>() { "qb.ranged", "qb.all" }, Rabuff, "ranged"));
            Commands.ChatCommands.Add(new Command(new List<string>() { "qb.magic", "qb.all" }, Mabuff, "magic"));
            Commands.ChatCommands.Add(new Command(new List<string>() { "qb.debuff", "qb.all" }, Dbuff, "debuff"));
            Commands.ChatCommands.Add(new Command("", help, "qb", "quickbuff"));
        }

        public override Version Version
        {
            get { return new Version("1.2"); }
        }

        public override string Name
        {
            get { return "QuickBuff"; }
        }

        public override string Author
        {
            get { return "dunkston"; }
        }

        public override string Description
        {
            get { return "Buff yourself fast"; }
        }

        public static void Rbuff(CommandArgs args)
        {
            if (args.Parameters.Count > 1)
            {
                args.Player.SendErrorMessage("Invalid Syntax! Proper syntax: /regen [player]");
            }
            else if (args.Parameters.Count == 0 && args.Player != null)
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
            else
            {
                var plr = TShock.Utils.FindPlayer(args.Parameters[0]);
                if (plr.Count < 1)
                {
                    args.Player.SendErrorMessage("Invalid Player!");
                }
                else if (plr.Count > 1)
                {
                    TShock.Utils.SendMultipleMatchError(args.Player, plr.Select(p => p.Name));
                }
                else
                {
                    plr[0].SetBuff(2, 30000, true);
                    plr[0].SetBuff(5, 30000, true);
                    plr[0].SetBuff(26, 30000, true);
                    plr[0].SetBuff(48, 30000, true);
                    plr[0].SetBuff(58, 30000, true);
                    plr[0].SetBuff(87, 30000, true);
                    plr[0].SetBuff(89, 30000, true);

                    args.Player.SendSuccessMessage("You have buffed {0} with the regen buff set", plr[0].Name);
                }
            }
        }
        public static void Mbuff(CommandArgs args)
        {
            if (args.Parameters.Count > 1)
            {
                args.Player.SendErrorMessage("Invalid Syntax! Proper syntax: /melee [player]");
            }
            else if (args.Parameters.Count == 0 && args.Player != null)
            {
                args.Player.SetBuff(14, 30000, true);
                args.Player.SetBuff(25, 30000, true);
                args.Player.SetBuff(26, 30000, true);
                args.Player.SetBuff(62, 30000, true);
                args.Player.SetBuff(76, 30000, true);

                args.Player.SendSuccessMessage("You got buffed");
            }
            else
            {
                var plr = TShock.Utils.FindPlayer(args.Parameters[0]);
                if (plr.Count < 1)
                {
                    args.Player.SendErrorMessage("Invalid Player!");
                }
                else if (plr.Count > 1)
                {
                    TShock.Utils.SendMultipleMatchError(args.Player, plr.Select(p => p.Name));
                }
                else
                {
                    plr[0].SetBuff(14, 30000, true);
                    plr[0].SetBuff(25, 30000, true);
                    plr[0].SetBuff(26, 30000, true);
                    plr[0].SetBuff(62, 30000, true);
                    plr[0].SetBuff(76, 30000, true);

                    args.Player.SendSuccessMessage("You have buffed {0} with the melee buff set", plr[0].Name);
                }
            }
        }
        public static void Rabuff(CommandArgs args)
        {
            if (args.Parameters.Count > 1)
            {
                args.Player.SendErrorMessage("Invalid Syntax! Proper syntax: /ranged [player]");
            }
            else if (args.Parameters.Count == 0 && args.Player != null)
            {
                args.Player.SetBuff(16, 30000, true);
                args.Player.SetBuff(26, 30000, true);

                args.Player.SendSuccessMessage("You got buffed");
            }
            else
            {
                var plr = TShock.Utils.FindPlayer(args.Parameters[0]);
                if (plr.Count < 1)
                {
                    args.Player.SendErrorMessage("Invalid Player!");
                }
                else if (plr.Count > 1)
                {
                    TShock.Utils.SendMultipleMatchError(args.Player, plr.Select(p => p.Name));
                }
                else
                {
                    plr[0].SetBuff(16, 30000, true);
                    plr[0].SetBuff(26, 30000, true);

                    args.Player.SendSuccessMessage("You have buffed {0} with the ranged buff set", plr[0].Name);
                }
            }
        }
        public static void Mabuff(CommandArgs args)
        {
            if (args.Parameters.Count > 1)
            {
                args.Player.SendErrorMessage("Invalid Syntax! Proper syntax: /magic [player]");
            }
            else if (args.Parameters.Count == 0 && args.Player != null)
            {
                args.Player.SetBuff(6, 30000, true);
                args.Player.SetBuff(7, 30000, true);
                args.Player.SetBuff(26, 30000, true);

                args.Player.SendSuccessMessage("You got buffed");
            }
            else
            {
                var plr = TShock.Utils.FindPlayer(args.Parameters[0]);
                if (plr.Count < 1)
                {
                    args.Player.SendErrorMessage("Invalid Player!");
                }
                else if (plr.Count > 1)
                {
                    TShock.Utils.SendMultipleMatchError(args.Player, plr.Select(p => p.Name));
                }
                else
                {
                    plr[0].SetBuff(6, 30000, true);
                    plr[0].SetBuff(7, 30000, true);
                    plr[0].SetBuff(26, 30000, true);

                    args.Player.SendSuccessMessage("You have buffed {0} with the magic buff set", plr[0].Name);
                }
            }
        }
        public static void Dbuff(CommandArgs args)
        {
            if (args.Parameters.Count < 1 || args.Parameters.Count > 1)
            {
                args.Player.SendErrorMessage("Invalid Syntax! Proper syntax: /debuff <player>");
            }
            else
            {
                var plr = TShock.Utils.FindPlayer(args.Parameters[0]);
                if (plr.Count < 1)
                {
                    args.Player.SendErrorMessage("Invalid Player!");
                }
                else if (plr.Count > 1)
                {
                    TShock.Utils.SendMultipleMatchError(args.Player, plr.Select(p => p.Name));
                }
                else
                {
                    plr[0].SetBuff(24, 600, true);
                    plr[0].SetBuff(30, 600, true);
                    plr[0].SetBuff(31, 600, true);
                    plr[0].SetBuff(32, 600, true);
                    plr[0].SetBuff(33, 600, true);
                    plr[0].SetBuff(35, 600, true);
                    plr[0].SetBuff(80, 600, true);
                    args.Player.SendSuccessMessage("You have debuffed {0}", plr[0].Name);

                }
            }
        }
        public static void help(CommandArgs args)
        {
            if (args.Parameters.Count > 2 || args.Parameters[0] != "commands" || args.Parameters[0] != "help")
            {
                args.Player.SendErrorMessage("Invalid Syntax! Proper syntax: /qb [help] [command]");
            }
            else
            {
                if (args.Parameters.Count == 0)
                {
                    args.Player.SendInfoMessage("Quick Buff made by dunkston");
                    args.Player.SendInfoMessage("Version 1.1");
                    args.Player.SendInfoMessage("For help, type /qb help");
                }
                else if (args.Parameters[0] == "commands")
                {
                    args.Player.SendInfoMessage("Commads:");
                    args.Player.SendInfoMessage("/regen");
                    args.Player.SendInfoMessage("/melee");
                    args.Player.SendInfoMessage("/ranged");
                    args.Player.SendInfoMessage("/magic");
                    args.Player.SendInfoMessage("/debuff");
                    args.Player.SendInfoMessage("/qb");
                }
                else if (args.Parameters[0] == "help")
                {

                    if (args.Parameters[1] == "regen")
                    {
                        args.Player.SendInfoMessage("Syntax: /regen [player]");
                        args.Player.SendInfoMessage("Buffs you or a player with");
                        args.Player.SendInfoMessage(" regeneration, ironskin, well fed, honey, rapid healing,");
                        args.Player.SendInfoMessage("campfire, and heart lamp for 8 minutes");
                    }
                    else if (args.Parameters[1] == "melee")
                    {
                        args.Player.SendInfoMessage("Syntax: /melee [player]");
                        args.Player.SendInfoMessage("Buffs you or a player with");
                        args.Player.SendInfoMessage("Thorns, Tipsy, Well Fed, and Weapon Imbue: Ichor for 8 minutes");
                    }
                    else if (args.Parameters[1] == "ranged")
                    {
                        args.Player.SendInfoMessage("Syntax: /ranged [player]");
                        args.Player.SendInfoMessage("Buffs you or a player with");
                        args.Player.SendInfoMessage("Archery and Well Fed for 8 minutes");
                    }
                    else if (args.Parameters[1] == "magic")
                    {
                        args.Player.SendInfoMessage("Syntax: /magic [player]");
                        args.Player.SendInfoMessage("Buffs you or a player with");
                        args.Player.SendInfoMessage("Mana Regeneration, Magic Power, and Well Fed for 8 minutes");
                    }
                    else if (args.Parameters[1] == "debuff")
                    {
                        args.Player.SendInfoMessage("Syntax: /debuff <player>");
                        args.Player.SendInfoMessage("On Fire!, Bleeding, Confused, Slow, Weak,");
                        args.Player.SendInfoMessage("Silenced, 6and Blackout for 10 seconds");
                    }
                    else if (args.Parameters[1] == "qb")
                    {
                        args.Player.SendInfoMessage("Syntax: /qb [help/commands] [command]");
                        args.Player.SendInfoMessage("Displays plugin info, commands, and help");
                    }
                    else
                    {
                        args.Player.SendErrorMessage("Invalid command");
                    }
                }
            }
        }
    }
}