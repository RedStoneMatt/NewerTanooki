using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewerTanooki
{
    public partial class DoCompare : Form
    {
        public DoCompare()
        {
            InitializeComponent();
        }

        public SaveBlock firstSave;
        public SaveBlock secondSave;
        public int id1;
        public int id2;

        public string charToString(List<char> input)
        {
            string output = "";
            foreach (char currentChar in input)
            {
                if (currentChar > 0)
                {
                    output += currentChar;
                }
            }
            return output;
        }

        private void DoCompare_Load(object sender, EventArgs e)
        {
            string s1 = ((id1 < 3) ? ("Save " + (id1 + 1)) : ("Quicksave " + (id1 - 2)));
            string s2 = ((id2 < 3) ? ("Save " + (id2 + 1)) : ("Quicksave " + (id2 - 2)));
            outputTextBox.Text += "Starting comparaison between " + s1 + " and " + s2 + ".\n";

            outputTextBox.Text += "------------\n";

            if (firstSave.field_00 != secondSave.field_00)
            {
                outputTextBox.Text += "field_00 | " + firstSave.field_00 + " -> " + secondSave.field_00 + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.field_01 != secondSave.field_01)
            {
                outputTextBox.Text += "field_01 | " + firstSave.field_01 + " -> " + secondSave.field_01 + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.bitfield != secondSave.bitfield)
            {
                outputTextBox.Text += "bitfield | " + firstSave.bitfield + " -> " + secondSave.bitfield + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.current_world != secondSave.current_world)
            {
                outputTextBox.Text += "current_world | " + firstSave.current_world + " -> " + secondSave.current_world + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.field_04 != secondSave.field_04)
            {
                outputTextBox.Text += "field_04 | " + firstSave.field_04 + " -> " + secondSave.field_04 + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.current_path_node != secondSave.current_path_node)
            {
                outputTextBox.Text += "current_path_node | " + firstSave.current_path_node + " -> " + secondSave.current_path_node + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.field_06 != secondSave.field_06)
            {
                outputTextBox.Text += "field_06 | " + firstSave.field_06 + " -> " + secondSave.field_06 + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.switch_on != secondSave.switch_on)
            {
                outputTextBox.Text += "switch_on | " + firstSave.switch_on + " -> " + secondSave.switch_on + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.field_08 != secondSave.field_08)
            {
                outputTextBox.Text += "field_08 | " + firstSave.field_08 + " -> " + secondSave.field_08 + "\n";
                outputTextBox.Text += "------------\n";
            }

            for (int i = 0; i < 17; i++)
            {
                if (firstSave.powerups_available[i] != secondSave.powerups_available[i])
                {
                    outputTextBox.Text += "powerups_available[" + i + "] | " + firstSave.powerups_available[i] + " -> " + secondSave.powerups_available[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (firstSave.player_continues[i] != secondSave.player_continues[i])
                {
                    outputTextBox.Text += "player_continues[" + i + "] | " + firstSave.player_continues[i] + " -> " + secondSave.player_continues[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (firstSave.player_coins[i] != secondSave.player_coins[i])
                {
                    outputTextBox.Text += "player_coins[" + i + "] | " + firstSave.player_coins[i] + " -> " + secondSave.player_coins[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (firstSave.player_lives[i] != secondSave.player_lives[i])
                {
                    outputTextBox.Text += "player_lives[" + i + "] | " + firstSave.player_lives[i] + " -> " + secondSave.player_lives[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (firstSave.player_flags[i] != secondSave.player_flags[i])
                {
                    outputTextBox.Text += "player_flags[" + i + "] | " + firstSave.player_flags[i] + " -> " + secondSave.player_flags[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (firstSave.player_type[i] != secondSave.player_type[i])
                {
                    outputTextBox.Text += "player_type[" + i + "] | " + firstSave.player_type[i] + " -> " + secondSave.player_type[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (firstSave.player_powerup[i] != secondSave.player_powerup[i])
                {
                    outputTextBox.Text += "player_powerup[" + i + "] | " + firstSave.player_powerup[i] + " -> " + secondSave.player_powerup[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (firstSave.worlds_available[i] != secondSave.worlds_available[i])
                {
                    outputTextBox.Text += "worlds_available[" + i + "] | " + firstSave.worlds_available[i] + " -> " + secondSave.worlds_available[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (firstSave.ambush_countdown[i] != secondSave.ambush_countdown[i])
                {
                    outputTextBox.Text += "ambush_countdown[" + i + "] | 0x" + Convert.ToString(firstSave.ambush_countdown[i], 16) + " -> 0x" + Convert.ToString(secondSave.ambush_countdown[i], 16) + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            if (firstSave.field_64 != secondSave.field_64)
            {
                outputTextBox.Text += "field_64 | " + firstSave.field_64 + " -> " + secondSave.field_64 + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.spentStarCoins != secondSave.spentStarCoins)
            {
                outputTextBox.Text += "spentStarCoins | " + firstSave.spentStarCoins + " -> " + secondSave.spentStarCoins + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.score != secondSave.score)
            {
                outputTextBox.Text += "score | " + firstSave.score + " -> " + secondSave.score + "\n";
                outputTextBox.Text += "------------\n";
            }

            for (int i = 0; i < 420; i++)
            {
                if (firstSave.completions[i] != secondSave.completions[i])
                {
                    int world = i / 42;
                    int level = i % 42;
                    outputTextBox.Text += "completions[" + world + "][" + level + "] | 0x" + Convert.ToString(firstSave.completions[i], 16) + " -> 0x" + Convert.ToString(secondSave.completions[i], 16) + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            if (charToString(firstSave.newerWorldName) != charToString(secondSave.newerWorldName))
            {
                outputTextBox.Text += "newerWorldName | " + charToString(firstSave.newerWorldName) + " -> " + charToString(secondSave.newerWorldName) + "\n";
                outputTextBox.Text += "------------\n";
            }

            for (int i = 0; i < 2; i++)
            {
                if (firstSave.fsTextColours[i].GXtoHexString() != secondSave.fsTextColours[i].GXtoHexString())
                {
                    outputTextBox.Text += "fsTextColours[" + i + "] | " + firstSave.fsTextColours[i].GXtoHexString() + " -> " + secondSave.fsTextColours[i].GXtoHexString() + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 2; i++)
            {
                if (firstSave.fsHintColours[i].GXtoHexString() != secondSave.fsHintColours[i].GXtoHexString())
                {
                    outputTextBox.Text += "fsHintColours[" + i + "] | " + firstSave.fsHintColours[i].GXtoHexString() + " -> " + secondSave.fsHintColours[i].GXtoHexString() + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 2; i++)
            {
                if (firstSave.hudTextColours[i].GXtoHexString() != secondSave.hudTextColours[i].GXtoHexString())
                {
                    outputTextBox.Text += "hudTextColours[" + i + "] | " + firstSave.hudTextColours[i].GXtoHexString() + " -> " + secondSave.hudTextColours[i].GXtoHexString() + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            if (firstSave.hudHintH != secondSave.hudHintH)
            {
                outputTextBox.Text += "hudHintH | " + firstSave.hudHintH + " -> " + secondSave.hudHintH + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.hudHintS != secondSave.hudHintS)
            {
                outputTextBox.Text += "hudHintS | " + firstSave.hudHintS + " -> " + secondSave.hudHintS + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.hudHintL != secondSave.hudHintL)
            {
                outputTextBox.Text += "hudHintL | " + firstSave.hudHintL + " -> " + secondSave.hudHintL + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.currentMapMusic != secondSave.currentMapMusic)
            {
                outputTextBox.Text += "currentMapMusic | " + firstSave.currentMapMusic + " -> " + secondSave.currentMapMusic + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.newerWorldID != secondSave.newerWorldID)
            {
                outputTextBox.Text += "newerWorldID | " + firstSave.newerWorldID + " -> " + secondSave.newerWorldID + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.titleScreenWorld != secondSave.titleScreenWorld)
            {
                outputTextBox.Text += "titleScreenWorld | " + firstSave.titleScreenWorld + " -> " + secondSave.titleScreenWorld + "\n";
                outputTextBox.Text += "------------\n";
            }

            if (firstSave.titleScreenLevel != secondSave.titleScreenLevel)
            {
                outputTextBox.Text += "titleScreenLevel | " + firstSave.titleScreenLevel + " -> " + secondSave.titleScreenLevel + "\n";
                outputTextBox.Text += "------------\n";
            }

            for (int i = 0; i < 10; i++)
            {
                if (firstSave.toad_location[i] != secondSave.toad_location[i])
                {
                    outputTextBox.Text += "toad_location[" + i + "] | " + firstSave.toad_location[i] + " -> " + secondSave.toad_location[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 40; i++)
            {
                if (firstSave.field_74C[i] != secondSave.field_74C[i])
                {
                    int world = i / 4;
                    int level = i % 4;
                    outputTextBox.Text += "field_74C[" + world + "][" + level + "] | " + firstSave.field_74C[i] + " -> " + secondSave.field_74C[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 40; i++)
            {
                if (firstSave.field_774[i] != secondSave.field_774[i])
                {
                    int world = i / 4;
                    int level = i % 4;
                    outputTextBox.Text += "field_774[" + world + "][" + level + "] | " + firstSave.field_774[i] + " -> " + secondSave.field_774[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 40; i++)
            {
                if (firstSave.field_79C[i] != secondSave.field_79C[i])
                {
                    int world = i / 4;
                    int level = i % 4;
                    outputTextBox.Text += "field_79C[" + world + "][" + level + "] | " + firstSave.field_79C[i] + " -> " + secondSave.field_79C[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            for (int i = 0; i < 420; i++)
            {
                if (firstSave.death_counts[i] != secondSave.death_counts[i])
                {
                    int world = i / 42;
                    int level = i % 42;
                    outputTextBox.Text += "death_counts[" + world + "][" + level + "] | " + firstSave.death_counts[i] + " -> " + secondSave.death_counts[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            if (firstSave.death_count_3_4_switch != secondSave.death_count_3_4_switch)
            {
                outputTextBox.Text += "death_count_3_4_switch | " + firstSave.death_count_3_4_switch + " -> " + secondSave.death_count_3_4_switch + "\n";
                outputTextBox.Text += "------------\n";
            }

            for (int i = 0; i < 19; i++)
            {
                if (firstSave.pad[i] != secondSave.pad[i])
                {
                    outputTextBox.Text += "pad[" + i + "] | " + firstSave.pad[i] + " -> " + secondSave.pad[i] + "\n";
                    outputTextBox.Text += "------------\n";
                }
            }

            outputTextBox.Text += "Done !";
        }

        private void clipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputTextBox.Text);
        }
    }
}
