using System;
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
            Commands.ChatCommands.Add(new Command(new List<string>() { "qb.regen", "qb.all" }, Rbuff, "regen"));
            Commands.ChatCommands.Add(new Command(new List<string>() { "qb.melee", "qb.all" }, Mbuff, "melee"));
            Commands.ChatCommands.Add(new Command(new List<string>() { "qb.ranged", "qb.all" }, Rabuff, "ranged"));
            Commands.ChatCommands.Add(new Command(new List<string>() { "qb.magic", "qb.all" }, Mabuff, "magic"));
            Commands.ChatCommands.Add(new Command(new List<string>() { "qb.debuff", "qb.all"}, Dbuff, "debuff"));
            Commands.ChatCommands.Add(new Command("", help, "qb"));
        }
        
        public override Version Version
        {
            get { return new Version("1.0"); }

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
            if (args.Parameters.Count > 0)
            {
                args.Player.SendErrorMessage("Invalid Syntax! Proper syntax: /regen");
            }
            else if (args.Player != null)
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
        public static void Mbuff(CommandArgs args)
        {
            if (args.Parameters.Count > 0)
            {
                args.Player.SendErrorMessage("Invalid Syntax! Proper syntax: /melee");
            }
            else if (args.Player != null)
            {
                args.Player.SetBuff(14, 30000, true);
                args.Player.SetBuff(25, 30000, true);
                args.Player.SetBuff(26, 30000, true);
                args.Player.SetBuff(62, 30000, true);
                args.Player.SetBuff(76, 30000, true);

                args.Player.SendSuccessMessage("You got buffed");
            }
        }
        public static void Rabuff(CommandArgs args)
        {
            if (args.Parameters.Count > 0)
            {
                args.Player.SendErrorMessage("Invalid Syntax! Proper syntax: /ranged");
            }
            else if (args.Player != null)
            {
                args.Player.SetBuff(16, 30000, true);
                args.Player.SetBuff(26, 30000, true);

                args.Player.SendSuccessMessage("You got buffed");
            }
        }
        public static void Mabuff(CommandArgs args)
        {
            if (args.Parameters.Count > 0)
            {
                args.Player.SendErrorMessage("Invalid Syntax! Proper syntax: /magic");
            }
            else if (args.Player != null)
            {
                args.Player.SetBuff(6, 30000, true);
                args.Player.SetBuff(7, 30000, true);
                args.Player.SetBuff(26, 30000, true);

                args.Player.SendSuccessMessage("You got buffed");
            }
        }
        public static void Dbuff(CommandArgs args)
        {
            if (args.Parameters.Count < 1)
            {
                args.Player.SendErrorMessage("Invalid Syntax! Proper syntax: /debuff <player>");
            }
            else if (args.Parameters.Count > 1)
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
                    plr[0].SetBuff(20, 3600, true);
                    plr[0].SetBuff(21, 3600, true);
                    plr[0].SetBuff(22, 3600, true);
                    plr[0].SetBuff(23, 3600, true);
                    plr[0].SetBuff(24, 3600, true);
                    plr[0].SetBuff(30, 3600, true);
                    plr[0].SetBuff(31, 3600, true);
                    plr[0].SetBuff(32, 3600, true);
                    plr[0].SetBuff(33, 3600, true);
                    plr[0].SetBuff(35, 3600, true);
                    plr[0].SetBuff(36, 3600, true);
                    plr[0].SetBuff(46, 3600, true);
                    plr[0].SetBuff(47, 3600, true);
                    plr[0].SetBuff(67, 3600, true);
                    plr[0].SetBuff(68, 3600, true);
                    plr[0].SetBuff(69, 3600, true);
                    plr[0].SetBuff(70, 3600, true);
                    plr[0].SetBuff(80, 3600, true);
                    plr[0].SetBuff(94, 3600, true);

                    args.Player.SendSuccessMessage("You have debuffed {0}", plr[0].Name);

                }
            }
        }
        public static void help(CommandArgs args)
        {
            if (args.Parameters.Count > 2)
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
                else if (args.Parameters[0] == "help")
                {
                    if (args.Parameters.Count == 1)
                    {
                        args.Player.SendInfoMessage("Commads:");
                        args.Player.SendInfoMessage("/regen");
                        args.Player.SendInfoMessage("/melee");
                        args.Player.SendInfoMessage("/ranged");
                        args.Player.SendInfoMessage("/magic");
                        args.Player.SendInfoMessage("/debuff");
                        args.Player.SendInfoMessage("/qb");
                    }
                    else if (args.Parameters[1] == "regen")
                    {
                        args.Player.SendInfoMessage("Syntax: /regen");
                        args.Player.SendInfoMessage("Buffs you with");
                        args.Player.SendInfoMessage(" regeneration, ironskin, well fed, honey, rapid healing,");
                        args.Player.SendInfoMessage("campfire, and heart lamp for 8 minutes");
                    }
                    else if (args.Parameters[1] == "melee")
                    {
                        args.Player.SendInfoMessage("Syntax: /melee");
                        args.Player.SendInfoMessage("Buffs you with");
                        args.Player.SendInfoMessage("Thorns, Tipsy, Well Fed, and Weapon Imbue: Ichor for 8 minutes");
                    }
                    else if (args.Parameters[1] == "ranged")
                    {
                        args.Player.SendInfoMessage("Syntax: /ranged");
                        args.Player.SendInfoMessage("Buffs you with");
                        args.Player.SendInfoMessage("Archery and Well Fed for 8 minutes");
                    }
                    else if (args.Parameters[1] == "magic")
                    {
                        args.Player.SendInfoMessage("Syntax: /magic");
                        args.Player.SendInfoMessage("Buffs you with");
                        args.Player.SendInfoMessage("Mana Regeneration, Magic Power, and Well Fed for 8 minutes");
                    }
                    else if (args.Parameters[1] == "debuff")
                    {
                        args.Player.SendInfoMessage("Syntax: /debuff <player>");
                        args.Player.SendInfoMessage("Debuffs a player with");
                        args.Player.SendInfoMessage("Poisoned, Potion Sickness, Darkness, Cursed,");
                        args.Player.SendInfoMessage("On Fire!, Bleeding, Confused, Slow, Weak,");
                        args.Player.SendInfoMessage("Silenced, Broken Armor, Cursed Inferno, Chilled,");
                        args.Player.SendInfoMessage("Frozen, Burning, Ichor, Venom,");
                        args.Player.SendInfoMessage("Blackout, and Mana Sickness for 10 seconds");
                    }
                    else if (args.Parameters[1] == "qb")
                    {
                        args.Player.SendInfoMessage("Syntax: /qb [help] [command]");
                        args.Player.SendInfoMessage("Displays plugin info and help");
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