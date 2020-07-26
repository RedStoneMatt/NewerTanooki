using Cyotek.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewerTanooki
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

		SaveFile thisSave = new SaveFile();
		List<byte> rawdata = new List<byte>();
		char[] rawstring;
		string originalPath = "";

		int skipStarUpdate = 0;

		public string charToString(List<char> input)
		{
			string output = "";
			foreach(char currentChar in input)
			{
				if (currentChar > 0)
				{
					output += currentChar;
				}
			}
			return output;
		}

		public List<char> stringToChar(string input, int lenght)
		{
			List<char> output = new List<char>();
			foreach(char currentChar in input)
			{
				output.Add(currentChar);
			}
			for(int i = 0; output.Count < lenght; i++)
			{
				output.Add((char)0);
			}
			return output;
		}

		public void loadFile(string path)
		{
			//Reads the Save File, this little part was done by Lory some months ago for one of my older projects, i reused it for this tool as it works good. Thanks to him !
			FileStream rawSave = File.Open(path, FileMode.Open);
			try
			{
				BinaryReader binReader = new BinaryReader(rawSave);
				byte b = binReader.ReadByte();
				while (b != null)
				{
					rawdata.Add(b);
					b = binReader.ReadByte();
				}
				binReader.Close();
			}
			catch (EndOfStreamException e)
			{
				Console.WriteLine("reached end of stream");
				rawSave.Close();
			}

			//make it a string and an int for future things
			rawstring = Encoding.UTF8.GetString(rawdata.ToArray(), 0, rawdata.ToArray().Length).ToCharArray();
			int[] rawint = new int[rawdata.ToArray().Length];
			for (int i = 0; i < rawdata.ToArray().Length - 1; i++)
			{
				rawint[i] = Convert.ToInt32(rawdata[i].ToString());
			}

			//Checks the header
			if (rawstring[0] != 'S' || rawstring[1] != 'M' || rawstring[2] != 'N')
			{
				MessageBox.Show("Invalid SAV File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				//Here the fun starts (or not)

				//Save Header - basic shit that isn't in a particular save file but is global to all the save
				SaveFirstBlock currentHeader = new SaveFirstBlock();

				int headerOffset = 0;

				for (int offset = 0; offset < 4; offset++)
				{
					currentHeader.titleID.Add(rawstring[headerOffset++]);
				}

				currentHeader.field_00 = rawdata[headerOffset++];
				currentHeader.field_01 = rawdata[headerOffset++];
				currentHeader.current_file = rawdata[headerOffset++];
				currentHeader.field_03 = rawdata[headerOffset++];

				for (int offset = 0; offset < 420; offset++)
				{
					byte[] full16 = { rawdata[headerOffset++], rawdata[headerOffset++] };
					Array.Reverse(full16);
					currentHeader.freemode_fav.Add(BitConverter.ToUInt16(full16, 0));
				}

				for (int offset = 0; offset < 420; offset++)
				{
					byte[] full16 = { rawdata[headerOffset++], rawdata[headerOffset++] };
					Array.Reverse(full16);
					currentHeader.coinbtl_fav.Add(BitConverter.ToUInt16(full16, 0));
				}

				byte[] bitfield__full16 = { rawdata[headerOffset++], rawdata[headerOffset++] };
				Array.Reverse(bitfield__full16);
				currentHeader.bitfield = BitConverter.ToUInt16(bitfield__full16, 0);

				byte[] field_69A__full16 = { rawdata[headerOffset++], rawdata[headerOffset++] };
				Array.Reverse(field_69A__full16);
				currentHeader.field_69A = BitConverter.ToUInt16(field_69A__full16, 0);

				byte[] checksum__full32 = { rawdata[headerOffset++], rawdata[headerOffset++], rawdata[headerOffset++], rawdata[headerOffset++] };
				Array.Reverse(checksum__full32);
				currentHeader.checksum = BitConverter.ToUInt32(checksum__full32, 0);

				//Save Files - Everything that is specific to a save file
				List<SaveBlock> allSaves = new List<SaveBlock>();

				int baseOffset = 0x6A0;

				for (int i = 0; i < 6; i++)
				{
					SaveBlock firstSave = new SaveBlock();


					firstSave.field_00 = rawdata[baseOffset++];
					firstSave.field_01 = rawdata[baseOffset++];
					firstSave.bitfield = rawdata[baseOffset++];
					firstSave.current_world = rawdata[baseOffset++];
					firstSave.field_04 = rawdata[baseOffset++];
					firstSave.current_path_node = rawdata[baseOffset++];
					firstSave.field_06 = rawdata[baseOffset++];
					firstSave.switch_on = rawdata[baseOffset++];
					firstSave.field_08 = rawdata[baseOffset++];

					for (int offset = 0; offset < 17; offset++)
					{
						firstSave.powerups_available.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 4; offset++)
					{
						firstSave.player_continues.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 4; offset++)
					{
						firstSave.player_coins.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 4; offset++)
					{
						firstSave.player_lives.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 4; offset++)
					{
						firstSave.player_flags.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 4; offset++)
					{
						firstSave.player_type.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 4; offset++)
					{
						firstSave.player_powerup.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 10; offset++)
					{
						firstSave.worlds_available.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 10; offset++)
					{
						byte[] full32 = { rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++] };
						Array.Reverse(full32);
						firstSave.ambush_countdown.Add(BitConverter.ToUInt32(full32, 0));
					}

					byte[] field_64__full16 = { rawdata[baseOffset++], rawdata[baseOffset++] };
					Array.Reverse(field_64__full16);
					firstSave.field_64 = BitConverter.ToUInt16(field_64__full16, 0);

					baseOffset += 2; //IDK

					byte[] spentStarCoins__full16 = { rawdata[baseOffset++], rawdata[baseOffset++] };
					Array.Reverse(spentStarCoins__full16);
					firstSave.spentStarCoins = BitConverter.ToUInt16(spentStarCoins__full16, 0);

					byte[] score__full16 = { rawdata[baseOffset++], rawdata[baseOffset++] };
					Array.Reverse(score__full16);
					firstSave.score = BitConverter.ToUInt16(score__full16, 0);

					for (int offset = 0; offset < 420; offset++)
					{
						byte[] full32 = { rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++] };
						Array.Reverse(full32);
						firstSave.completions.Add(BitConverter.ToUInt32(full32, 0));
					}

					for (int offset = 0; offset < 32; offset++)
					{
						firstSave.newerWorldName.Add(rawstring[baseOffset++]);
					}

					for (int offset = 0; offset < 2; offset++)
					{
						GXColor thisColor = new GXColor(rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++]);
						firstSave.fsTextColours.Add(thisColor);
					}

					for (int offset = 0; offset < 2; offset++)
					{
						GXColor thisColor = new GXColor(rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++]);
						firstSave.fsHintColours.Add(thisColor);
					}

					for (int offset = 0; offset < 2; offset++)
					{
						GXColor thisColor = new GXColor(rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++]);
						firstSave.hudTextColours.Add(thisColor);
					}

					byte[] hudHintH__full16 = { rawdata[baseOffset++], rawdata[baseOffset++] };
					Array.Reverse(hudHintH__full16);
					firstSave.hudHintH = BitConverter.ToUInt16(hudHintH__full16, 0);

					firstSave.hudHintS = rawdata[baseOffset++];
					firstSave.hudHintL = rawdata[baseOffset++];
					firstSave.currentMapMusic = rawdata[baseOffset++];
					firstSave.newerWorldID = rawdata[baseOffset++];
					firstSave.titleScreenWorld = rawdata[baseOffset++];
					firstSave.titleScreenLevel = rawdata[baseOffset++];

					for (int offset = 0; offset < 6; offset++)
					{
						firstSave.unusedShit.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 10; offset++)
					{
						firstSave.toad_location.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 40; offset++)
					{
						firstSave.field_74C.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 40; offset++)
					{
						firstSave.field_774.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 40; offset++)
					{
						firstSave.field_79C.Add(rawdata[baseOffset++]);
					}

					for (int offset = 0; offset < 420; offset++)
					{
						firstSave.death_counts.Add(rawdata[baseOffset++]);
					}

					firstSave.death_count_3_4_switch = rawdata[baseOffset++];

					for (int offset = 0; offset < 19; offset++)
					{
						firstSave.pad.Add(rawdata[baseOffset++]);
					}

					byte[] checksum2__full32 = { rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++], rawdata[baseOffset++] };
					Array.Reverse(checksum2__full32);
					firstSave.checksum = BitConverter.ToUInt32(checksum2__full32, 0);

					allSaves.Add(firstSave);
				}

				//Adding Header & Saves into thisSave

				thisSave.header = currentHeader;

				int processingSave = 0;
				for(int i = 0; i < 3; i++)
				{
					thisSave.saves.Add(allSaves[processingSave++]);
				}
				for(int i = 0; i < 3; i++)
				{
					thisSave.quickSaves.Add(allSaves[processingSave++]);
				}

				saveNumberComboBox.SelectedIndex = 0;
				LoadSaveIntoBoxes(0, false);
				LoadLevelCompletion(1, 1);
				LoadCoinmodeCompletions(1, 1);
				LoadFreemodeCompletions(1, 1);
				LoadOtherDataSave();
				ReloadOtherDataSaveArrays();

				LoadOtherDataHeader();

				mainTabControl.Enabled = true;
				saveToolStripMenuItem.Enabled = true;
				saveAsToolStripMenuItem.Enabled = true;

				if (thisSave.header.titleID[3] == 'P') { saveRegionComboBox.SelectedIndex = 0; }
				if (thisSave.header.titleID[3] == 'E') { saveRegionComboBox.SelectedIndex = 1; }
				if (thisSave.header.titleID[3] == 'J') { saveRegionComboBox.SelectedIndex = 2; }

				latestSavedFileNumBox.Value = thisSave.header.current_file;
			}
		}
		public List<byte> saveFile()
		{
			//Save the content of the current boxes
			MoveBoxesToData();

			//Create data to return
			List<byte> saveData = new List<byte>();

			//Header
			for (int i = 0; i < 4; i++)
			{
				saveData.Add(Convert.ToByte(thisSave.header.titleID[i]));
			}
			int currentHeaderIndex = saveData.Count;
			saveData.Add(thisSave.header.field_00);
			saveData.Add(thisSave.header.field_01);
			saveData.Add(thisSave.header.current_file);
			saveData.Add(thisSave.header.field_03);
			for(int currentIndex = 0; currentIndex < 420; currentIndex++)
			{
				foreach (byte currentByte in BitConverter.GetBytes(thisSave.header.freemode_fav[currentIndex]).Reverse<byte>())
				{
					saveData.Add(currentByte);
				}
			}
			for(int currentIndex = 0; currentIndex < 420; currentIndex++)
			{
				foreach (byte currentByte in BitConverter.GetBytes(thisSave.header.coinbtl_fav[currentIndex]).Reverse<byte>())
				{
					saveData.Add(currentByte);
				}
			}
			foreach (byte currentByte in BitConverter.GetBytes(thisSave.header.bitfield).Reverse<byte>())
			{
				saveData.Add(currentByte);
			}
			foreach (byte currentByte in BitConverter.GetBytes(thisSave.header.field_69A).Reverse<byte>())
			{
				saveData.Add(currentByte);
			}
			//Header Checksum
			int newCurrentHeaderIndex = saveData.Count;
			byte[] wholeHeader = new byte[newCurrentHeaderIndex - currentHeaderIndex];
			Array.Copy(saveData.ToArray(), currentHeaderIndex, wholeHeader, 0, newCurrentHeaderIndex - currentHeaderIndex);
			uint newHeaderCheckSum = ComputeChecksum(wholeHeader, (uint)wholeHeader.Length);
			foreach (byte currentByte in BitConverter.GetBytes(newHeaderCheckSum).Reverse<byte>())
			{
				saveData.Add(currentByte);
			}

			//Save Data
			List<SaveBlock> totalSaves = thisSave.saves;
			totalSaves.AddRange(thisSave.quickSaves);
			foreach (SaveBlock currentSave in totalSaves)
			{

				int currentIndex = saveData.Count;
				saveData.Add(currentSave.field_00);
				saveData.Add(currentSave.field_01);
				saveData.Add(currentSave.bitfield);
				saveData.Add(currentSave.current_world);
				saveData.Add(currentSave.field_04);
				saveData.Add(currentSave.current_path_node);
				saveData.Add(currentSave.field_06);
				saveData.Add(currentSave.switch_on);
				saveData.Add(currentSave.field_08);
				for(int i = 0; i < 17; i++)
				{
					saveData.Add(currentSave.powerups_available[i]);
				}
				for(int i = 0; i < 4; i++)
				{
					saveData.Add(currentSave.player_continues[i]);
				}
				for(int i = 0; i < 4; i++)
				{
					saveData.Add(currentSave.player_coins[i]);
				}
				for(int i = 0; i < 4; i++)
				{
					saveData.Add(currentSave.player_lives[i]);
				}
				for(int i = 0; i < 4; i++)
				{
					saveData.Add(currentSave.player_flags[i]);
				}
				for(int i = 0; i < 4; i++)
				{
					saveData.Add(currentSave.player_type[i]);
				}
				for(int i = 0; i < 4; i++)
				{
					saveData.Add(currentSave.player_powerup[i]);
				}
				for(int i = 0; i < 10; i++)
				{
					saveData.Add(currentSave.worlds_available[i]);
				}
				for(int i = 0; i < 10; i++)
				{
					foreach (byte currentByte in BitConverter.GetBytes(currentSave.ambush_countdown[i]).Reverse<byte>())
					{
						saveData.Add(currentByte);
					}
				}
				foreach (byte currentByte in BitConverter.GetBytes(currentSave.field_64).Reverse<byte>())
				{
					saveData.Add(currentByte);
				}
				saveData.Add((byte)00); //IDK
				saveData.Add((byte)00); //IDK
				foreach (byte currentByte in BitConverter.GetBytes(currentSave.spentStarCoins).Reverse<byte>())
				{
					saveData.Add(currentByte);
				}
				foreach (byte currentByte in BitConverter.GetBytes(currentSave.score).Reverse<byte>())
				{
					saveData.Add(currentByte);
				}
				for (int i = 0; i < 420; i++)
				{
					foreach (byte currentByte in BitConverter.GetBytes(currentSave.completions[i]).Reverse<byte>())
					{
						saveData.Add(currentByte);
					}
				}
				for (int i = 0; i < 32; i++)
				{
					saveData.Add(Convert.ToByte(currentSave.newerWorldName[i]));
				}
				for (int i = 0; i < 2; i++)
				{
					foreach (byte currentByte in currentSave.fsTextColours[i].GXToByteArray())
					{
						saveData.Add(currentByte);
					}
				}
				for (int i = 0; i < 2; i++)
				{
					foreach (byte currentByte in currentSave.fsHintColours[i].GXToByteArray())
					{
						saveData.Add(currentByte);
					}
				}
				for (int i = 0; i < 2; i++)
				{
					foreach (byte currentByte in currentSave.hudTextColours[i].GXToByteArray())
					{
						saveData.Add(currentByte);
					}
				}
				foreach (byte currentByte in BitConverter.GetBytes(currentSave.hudHintH).Reverse<byte>())
				{
					saveData.Add(currentByte);
				}
				saveData.Add((byte)(currentSave.hudHintS+1));
				saveData.Add((byte)(currentSave.hudHintL+1));
				saveData.Add(currentSave.currentMapMusic);
				saveData.Add(currentSave.newerWorldID);
				saveData.Add(currentSave.titleScreenWorld);
				saveData.Add(currentSave.titleScreenLevel);
				for (int i = 0; i < 6; i++)
				{
					saveData.Add(currentSave.unusedShit[i]);
				}
				for (int i = 0; i < 10; i++)
				{
					saveData.Add(currentSave.toad_location[i]);
				}
				for (int i = 0; i < 40; i++)
				{
					saveData.Add(currentSave.field_74C[i]);
				}
				for (int i = 0; i < 40; i++)
				{
					saveData.Add(currentSave.field_774[i]);
				}
				for (int i = 0; i < 40; i++)
				{
					saveData.Add(currentSave.field_79C[i]);
				}
				for (int i = 0; i < 420; i++)
				{
					saveData.Add(currentSave.death_counts[i]);
				}
				saveData.Add(currentSave.death_count_3_4_switch);
				for (int i = 0; i < 19; i++)
				{
					saveData.Add(currentSave.pad[i]);
				}
				int newCurrentIndex = saveData.Count;

				//Save Data Checksum
				byte[] wholeSaveBlock = new byte[newCurrentIndex - currentIndex];
				Array.Copy(saveData.ToArray(), currentIndex, wholeSaveBlock, 0, newCurrentIndex - currentIndex);
				uint newCheckSum = ComputeChecksum(wholeSaveBlock, (uint)wholeSaveBlock.Length);
				foreach (byte currentByte in BitConverter.GetBytes(newCheckSum).Reverse<byte>())
				{
					saveData.Add(currentByte);
				}
			}


			//Return it
			return saveData;
		}

		public void MoveBoxesToData()
		{
			if(quickSaveCheckBox.Checked)
			{
				//Player Properties
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_coins[0] = (byte)marioCoinsNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_coins[1] = (byte)luigiCoinsNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_coins[2] = (byte)btoadCoinsNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_coins[3] = (byte)ytoadCoinsNumBox.Value;

				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_lives[0] = (byte)marioLivesNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_lives[1] = (byte)luigiLivesNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_lives[2] = (byte)btoadLivesNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_lives[3] = (byte)ytoadLivesNumBox.Value;

				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_powerup[0] = (byte)marioPowerupComboBox.SelectedIndex;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_powerup[1] = (byte)luigiPowerupComboBox.SelectedIndex;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_powerup[2] = (byte)btoadPowerupComboBox.SelectedIndex;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_powerup[3] = (byte)ytoadPowerupComboBox.SelectedIndex;

				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_flags[0] = Convert.ToByte(0 | ((marioStarCheckBox.Checked) ? 1 : 0));
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_flags[1] = Convert.ToByte(0 | ((luigiStarCheckBox.Checked) ? 1 : 0));
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_flags[2] = Convert.ToByte(0 | ((btoadStarCheckBox.Checked) ? 1 : 0));
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].player_flags[3] = Convert.ToByte(0 | ((ytoadStarCheckBox.Checked) ? 1 : 0));

				//World Data
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[0] = (byte)mushroomNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[1] = (byte)fireNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[2] = (byte)propellerNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[3] = (byte)iceNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[4] = (byte)penguinNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[5] = (byte)miniNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[6] = (byte)starNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[7] = (byte)hammerNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[8] = (byte)powerup8NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[9] = (byte)powerup9NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[10] = (byte)powerup10NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[11] = (byte)powerup11NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[12] = (byte)powerup12NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[13] = (byte)powerup13NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[14] = (byte)powerup14NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[15] = (byte)powerup15NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].powerups_available[16] = (byte)powerup16NumBox.Value;

				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].current_world = (byte)currentWorldNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].current_path_node = (byte)currentPathNodeNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].score = (ushort)scoreNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].spentStarCoins = (ushort)spentStarCoinsNumBox.Value;

				//Newer World Data
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].newerWorldName = stringToChar(newerWorldTextBox.Text, 32);

				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].fsTextColours[0] = new GXColor(fsTextTopButton.BackColor.R, fsTextTopButton.BackColor.G, fsTextTopButton.BackColor.B, fsTextTopButton.BackColor.A);
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].fsTextColours[1] = new GXColor(fsTextBottomButton.BackColor.R, fsTextBottomButton.BackColor.G, fsTextBottomButton.BackColor.B, fsTextBottomButton.BackColor.A);

				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].fsHintColours[0] = new GXColor(fsGradientTopButton.BackColor.R, fsGradientTopButton.BackColor.G, fsGradientTopButton.BackColor.B, fsGradientTopButton.BackColor.A);
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].fsHintColours[1] = new GXColor(fsGradientBottomButton.BackColor.R, fsGradientBottomButton.BackColor.G, fsGradientBottomButton.BackColor.B, fsGradientBottomButton.BackColor.A);

				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].hudTextColours[0] = new GXColor(wmTextTopButton.BackColor.R, wmTextTopButton.BackColor.G, wmTextTopButton.BackColor.B, wmTextTopButton.BackColor.A);
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].hudTextColours[1] = new GXColor(wmTextBottomButton.BackColor.R, wmTextBottomButton.BackColor.G, wmTextBottomButton.BackColor.B, wmTextBottomButton.BackColor.A);

				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].hudHintH = (ushort)hudColorButton.BackColor.GetHue();
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].hudHintS = (byte)(hudColorButton.BackColor.GetSaturation() * 100);
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].hudHintL = (byte)((hudColorButton.BackColor.GetBrightness() * 100)-50);

				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].titleScreenWorld = (byte)(titlescreenWorldNumBox.Value - 1);
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].titleScreenLevel = (byte)(titlescreenLevelNumBox.Value - 1);

				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].newerWorldID = (byte)newerWorldID.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].currentMapMusic = (byte)newerMusicID.Value;

				//Header Data
				if (saveRegionComboBox.SelectedIndex == 0) { thisSave.header.titleID[3] = 'P'; }
				if (saveRegionComboBox.SelectedIndex == 1) { thisSave.header.titleID[3] = 'E'; }
				if (saveRegionComboBox.SelectedIndex == 2) { thisSave.header.titleID[3] = 'J'; }

				thisSave.header.current_file = (byte)latestSavedFileNumBox.Value;

				//Other Values
				SaveOtherDataHeader();
				SaveOtherDataSave();
			}
			else
			{
				//Player Properties
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_coins[0] = (byte)marioCoinsNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_coins[1] = (byte)luigiCoinsNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_coins[2] = (byte)btoadCoinsNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_coins[3] = (byte)ytoadCoinsNumBox.Value;

				thisSave.saves[saveNumberComboBox.SelectedIndex].player_lives[0] = (byte)marioLivesNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_lives[1] = (byte)luigiLivesNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_lives[2] = (byte)btoadLivesNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_lives[3] = (byte)ytoadLivesNumBox.Value;

				thisSave.saves[saveNumberComboBox.SelectedIndex].player_powerup[0] = (byte)marioPowerupComboBox.SelectedIndex;
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_powerup[1] = (byte)luigiPowerupComboBox.SelectedIndex;
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_powerup[2] = (byte)btoadPowerupComboBox.SelectedIndex;
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_powerup[3] = (byte)ytoadPowerupComboBox.SelectedIndex;

				thisSave.saves[saveNumberComboBox.SelectedIndex].player_flags[0] = Convert.ToByte(0 | ((marioStarCheckBox.Checked) ? 1 : 0));
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_flags[1] = Convert.ToByte(0 | ((luigiStarCheckBox.Checked) ? 1 : 0));
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_flags[2] = Convert.ToByte(0 | ((btoadStarCheckBox.Checked) ? 1 : 0));
				thisSave.saves[saveNumberComboBox.SelectedIndex].player_flags[3] = Convert.ToByte(0 | ((ytoadStarCheckBox.Checked) ? 1 : 0));

				//World Data
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[0] = (byte)mushroomNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[1] = (byte)fireNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[2] = (byte)propellerNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[3] = (byte)iceNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[4] = (byte)penguinNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[5] = (byte)miniNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[6] = (byte)starNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[7] = (byte)hammerNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[8] = (byte)powerup8NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[9] = (byte)powerup9NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[10] = (byte)powerup10NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[11] = (byte)powerup11NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[12] = (byte)powerup12NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[13] = (byte)powerup13NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[14] = (byte)powerup14NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[15] = (byte)powerup15NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].powerups_available[16] = (byte)powerup16NumBox.Value;

				thisSave.saves[saveNumberComboBox.SelectedIndex].current_world = (byte)currentWorldNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].current_path_node = (byte)currentPathNodeNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].score = (ushort)scoreNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].spentStarCoins = (ushort)spentStarCoinsNumBox.Value;

				//Newer World Data
				thisSave.saves[saveNumberComboBox.SelectedIndex].newerWorldName = stringToChar(newerWorldTextBox.Text, 32);

				thisSave.saves[saveNumberComboBox.SelectedIndex].fsTextColours[0] = new GXColor(fsTextTopButton.BackColor.R, fsTextTopButton.BackColor.G, fsTextTopButton.BackColor.B, fsTextTopButton.BackColor.A);
				thisSave.saves[saveNumberComboBox.SelectedIndex].fsTextColours[1] = new GXColor(fsTextBottomButton.BackColor.R, fsTextBottomButton.BackColor.G, fsTextBottomButton.BackColor.B, fsTextBottomButton.BackColor.A);

				thisSave.saves[saveNumberComboBox.SelectedIndex].fsHintColours[0] = new GXColor(fsGradientTopButton.BackColor.R, fsGradientTopButton.BackColor.G, fsGradientTopButton.BackColor.B, fsGradientTopButton.BackColor.A);
				thisSave.saves[saveNumberComboBox.SelectedIndex].fsHintColours[1] = new GXColor(fsGradientBottomButton.BackColor.R, fsGradientBottomButton.BackColor.G, fsGradientBottomButton.BackColor.B, fsGradientBottomButton.BackColor.A);

				thisSave.saves[saveNumberComboBox.SelectedIndex].hudTextColours[0] = new GXColor(wmTextTopButton.BackColor.R, wmTextTopButton.BackColor.G, wmTextTopButton.BackColor.B, wmTextTopButton.BackColor.A);
				thisSave.saves[saveNumberComboBox.SelectedIndex].hudTextColours[1] = new GXColor(wmTextBottomButton.BackColor.R, wmTextBottomButton.BackColor.G, wmTextBottomButton.BackColor.B, wmTextBottomButton.BackColor.A);

				thisSave.saves[saveNumberComboBox.SelectedIndex].hudHintH = (ushort)hudColorButton.BackColor.GetHue();
				thisSave.saves[saveNumberComboBox.SelectedIndex].hudHintS = (byte)(hudColorButton.BackColor.GetSaturation() * 100);
				thisSave.saves[saveNumberComboBox.SelectedIndex].hudHintL = (byte)((hudColorButton.BackColor.GetBrightness() * 100) - 50);

				thisSave.saves[saveNumberComboBox.SelectedIndex].titleScreenWorld = (byte)(titlescreenWorldNumBox.Value - 1);
				thisSave.saves[saveNumberComboBox.SelectedIndex].titleScreenLevel = (byte)(titlescreenLevelNumBox.Value - 1);

				thisSave.saves[saveNumberComboBox.SelectedIndex].newerWorldID = (byte)newerWorldID.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].currentMapMusic = (byte)newerMusicID.Value;

				//Header Data
				if (saveRegionComboBox.SelectedIndex == 0) { thisSave.header.titleID[3] = 'P'; }
				if (saveRegionComboBox.SelectedIndex == 1) { thisSave.header.titleID[3] = 'E'; }
				if (saveRegionComboBox.SelectedIndex == 2) { thisSave.header.titleID[3] = 'J'; }

				thisSave.header.current_file = (byte)latestSavedFileNumBox.Value;

				//Other Values
				SaveOtherDataHeader();
				SaveOtherDataSave();
			}
		}

		public void LoadSaveIntoBoxes(int saveID, bool isQuick)
		{
			SaveBlock toLoad = ((isQuick) ? thisSave.quickSaves[saveID] : thisSave.saves[saveID]);

			bool isAdvanced = false;
			for(int i = 0; i < 4; i++)
			{
				if((toLoad.player_coins[i] > 99) || (toLoad.player_lives[i] > 99) || (toLoad.player_powerup[i] > 7))
				{
					isAdvanced = true;
				}
			}
			for (int i = 0; i < 17; i++)
			{
				if(i < 8)
				{
					if(toLoad.powerups_available[i] > 99)
					{
						isAdvanced = true;
					}
				}
				else
				{
					if (toLoad.powerups_available[i] > 0)
					{
						isAdvanced = true;
					}
				}
			}
			additionsCheckBox.Checked = isAdvanced;

			//Player Properties
			marioCoinsNumBox.Value = toLoad.player_coins[0];
			luigiCoinsNumBox.Value = toLoad.player_coins[1];
			btoadCoinsNumBox.Value = toLoad.player_coins[2];
			ytoadCoinsNumBox.Value = toLoad.player_coins[3];

			marioLivesNumBox.Value = toLoad.player_lives[0];
			luigiLivesNumBox.Value = toLoad.player_lives[1];
			btoadLivesNumBox.Value = toLoad.player_lives[2];
			ytoadLivesNumBox.Value = toLoad.player_lives[3];

			marioPowerupComboBox.SelectedIndex = toLoad.player_powerup[0];
			luigiPowerupComboBox.SelectedIndex = toLoad.player_powerup[1];
			btoadPowerupComboBox.SelectedIndex = toLoad.player_powerup[2];
			ytoadPowerupComboBox.SelectedIndex = toLoad.player_powerup[3];

			marioStarCheckBox.Checked = Convert.ToBoolean(toLoad.player_flags[0] & 1);
			luigiStarCheckBox.Checked = Convert.ToBoolean(toLoad.player_flags[1] & 1);
			btoadStarCheckBox.Checked = Convert.ToBoolean(toLoad.player_flags[2] & 1);
			ytoadStarCheckBox.Checked = Convert.ToBoolean(toLoad.player_flags[3] & 1);

			//World Data
			mushroomNumBox.Value = toLoad.powerups_available[0];
			fireNumBox.Value = toLoad.powerups_available[1];
			propellerNumBox.Value = toLoad.powerups_available[2];
			iceNumBox.Value = toLoad.powerups_available[3];
			penguinNumBox.Value = toLoad.powerups_available[4];
			miniNumBox.Value = toLoad.powerups_available[5];
			starNumBox.Value = toLoad.powerups_available[6];
			hammerNumBox.Value = toLoad.powerups_available[7];
			if(isAdvanced)
			{
				powerup8NumBox.Value = toLoad.powerups_available[8];
				powerup9NumBox.Value = toLoad.powerups_available[9];
				powerup10NumBox.Value = toLoad.powerups_available[10];
				powerup11NumBox.Value = toLoad.powerups_available[11];
				powerup12NumBox.Value = toLoad.powerups_available[12];
				powerup13NumBox.Value = toLoad.powerups_available[13];
				powerup14NumBox.Value = toLoad.powerups_available[14];
				powerup15NumBox.Value = toLoad.powerups_available[15];
				powerup16NumBox.Value = toLoad.powerups_available[16];
			}

			//Newer World Data
			currentWorldNumBox.Value = toLoad.current_world;
			currentPathNodeNumBox.Value = toLoad.current_path_node;
			scoreNumBox.Value = toLoad.score;
			spentStarCoinsNumBox.Value = toLoad.spentStarCoins;

			newerWorldTextBox.Text = charToString(toLoad.newerWorldName);

			fsTextTopButton.BackColor = Color.FromArgb(toLoad.fsTextColours[0].a, toLoad.fsTextColours[0].r, toLoad.fsTextColours[0].g, toLoad.fsTextColours[0].b);
			fsTextBottomButton.BackColor = Color.FromArgb(toLoad.fsTextColours[1].a, toLoad.fsTextColours[1].r, toLoad.fsTextColours[1].g, toLoad.fsTextColours[1].b);

			fsGradientTopButton.BackColor = Color.FromArgb(toLoad.fsHintColours[0].a, toLoad.fsHintColours[0].r, toLoad.fsHintColours[0].g, toLoad.fsHintColours[0].b);
			fsGradientBottomButton.BackColor = Color.FromArgb(toLoad.fsHintColours[1].a, toLoad.fsHintColours[1].r, toLoad.fsHintColours[1].g, toLoad.fsHintColours[1].b);

			wmTextTopButton.BackColor = Color.FromArgb(toLoad.hudTextColours[0].a, toLoad.hudTextColours[0].r, toLoad.hudTextColours[0].g, toLoad.hudTextColours[0].b);
			wmTextBottomButton.BackColor = Color.FromArgb(toLoad.hudTextColours[1].a, toLoad.hudTextColours[1].r, toLoad.hudTextColours[1].g, toLoad.hudTextColours[1].b);

			HslColor hudcolor = new HslColor(255, Convert.ToDouble(toLoad.hudHintH), Convert.ToDouble(toLoad.hudHintS) / 100.0, Convert.ToDouble(toLoad.hudHintL + 50) / 100.0);
			Color newhud = hudcolor.ToRgbColor();
			hudColorButton.BackColor = Color.FromArgb(255, newhud.R, newhud.G, newhud.B);

			titlescreenWorldNumBox.Value = (byte)(toLoad.titleScreenWorld + 1);
			titlescreenLevelNumBox.Value = (byte)(toLoad.titleScreenLevel + 1);

			newerWorldID.Value = (byte)toLoad.newerWorldID;
			newerMusicID.Value = (byte)toLoad.currentMapMusic;

			//FS Stars
			skipStarUpdate = 5;
			firstStarCheckBox.Checked = Convert.ToBoolean(toLoad.bitfield & 2U);
			secondStarCheckBox.Checked = Convert.ToBoolean(toLoad.bitfield & 4U);
			thirdStarCheckBox.Checked = Convert.ToBoolean(toLoad.bitfield & 8U);
			fourthStarCheckBox.Checked = Convert.ToBoolean(toLoad.bitfield & 0x10U);
			fifthStarCheckBox.Checked = Convert.ToBoolean(toLoad.bitfield & 0x20U);
		}

		public void LoadLevelCompletion(int world, int level)
		{
			int levelIndex = ((world-1) * 42) + (level-1);

			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);

			bool isCoin1 = Convert.ToBoolean(toLoad.completions[levelIndex] & 1);
			bool isCoin2 = Convert.ToBoolean(toLoad.completions[levelIndex] & 2);
			bool isCoin3 = Convert.ToBoolean(toLoad.completions[levelIndex] & 4);

			bool isNormalExit = Convert.ToBoolean(toLoad.completions[levelIndex] & 0x10);
			bool isSecretExit = Convert.ToBoolean(toLoad.completions[levelIndex] & 0x20);

			bool isSGNormalExit = Convert.ToBoolean(toLoad.completions[levelIndex] & 0x80);
			bool isSGSecretExit = Convert.ToBoolean(toLoad.completions[levelIndex] & 0x100);

			bool isUnlocked = Convert.ToBoolean(toLoad.completions[levelIndex] & 0x200);

			firstSCCheckBox.Checked = isCoin1;
			secondSCCheckBox.Checked = isCoin2;
			thirdSCCheckBox.Checked = isCoin3;
			unlockedCheckBox.Checked = isUnlocked;
			normalExitCheckBox.Checked = isNormalExit;
			secretExitCheckBox.Checked = isSecretExit;
			sgNormalExitCheckBox.Checked = isSGNormalExit;
			sgSecretCheckBox.Checked = isSGSecretExit;
		}

		public void SaveLevelCompletion(int world, int level)
		{
			int levelIndex = ((world-1) * 42) + (level-1);

			uint isCoin1 = ((firstSCCheckBox.Checked) ? 1U : 0);
			uint isCoin2 = ((secondSCCheckBox.Checked) ? 2U : 0);
			uint isCoin3 = ((thirdSCCheckBox.Checked) ? 4U : 0);

			uint isNormalExit = ((normalExitCheckBox.Checked) ? 0x10U : 0);
			uint isSecretExit = ((secretExitCheckBox.Checked) ? 0x20U : 0);

			uint isSGNormalExit = ((sgNormalExitCheckBox.Checked) ? 0x80U : 0);
			uint isSGSecretExit = ((sgSecretCheckBox.Checked) ? 0x100U : 0);

			uint isUnlocked = ((unlockedCheckBox.Checked) ? 0x200U : 0);

			uint finalFlag = 0 | isCoin1 | isCoin2 | isCoin3 | isNormalExit | isSecretExit | isSGNormalExit | isSGSecretExit | isUnlocked;
			if (quickSaveCheckBox.Checked)
			{
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].completions[levelIndex] = finalFlag;
			}
			else
			{
				thisSave.saves[saveNumberComboBox.SelectedIndex].completions[levelIndex] = finalFlag;
			}
		}

		public void LoadFreemodeCompletions(int world, int level)
		{
			int levelIndex = ((world - 1) * 42) + (level - 1);

			freemodeNumBox.Value = thisSave.header.freemode_fav[levelIndex];
		}

		public void LoadCoinmodeCompletions(int world, int level)
		{
			int levelIndex = ((world - 1) * 42) + (level - 1);

			coinmodeNumBox.Value = thisSave.header.coinbtl_fav[levelIndex];
		}

		public void SaveFreemodeCompletions(int world, int level)
		{
			int levelIndex = ((world - 1) * 42) + (level - 1);

			thisSave.header.freemode_fav[levelIndex] = Convert.ToUInt16(freemodeNumBox.Value);
		}

		public void SaveCoinmodeCompletions(int world, int level)
		{
			int levelIndex = ((world - 1) * 42) + (level - 1);

			thisSave.header.coinbtl_fav[levelIndex] = Convert.ToUInt16(coinmodeNumBox.Value);
		}

		public void LoadOtherDataHeader()
		{
			headerF00NumBox.Value = thisSave.header.field_00;
			headerF01NumBox.Value = thisSave.header.field_01;
			headerF03NumBox.Value = thisSave.header.field_03;
			headerBFNumBox.Value = thisSave.header.bitfield;
			headerF69ANumBox.Value = thisSave.header.field_69A;
			headerCSNumBox.Value = thisSave.header.checksum;
		}

		public void SaveOtherDataHeader()
		{
			thisSave.header.field_00 = (byte)headerF00NumBox.Value;
			thisSave.header.field_01 = (byte)headerF01NumBox.Value;
			thisSave.header.field_03 = (byte)headerF03NumBox.Value;
			thisSave.header.bitfield = (ushort)headerBFNumBox.Value;
			thisSave.header.field_69A = (ushort)headerF69ANumBox.Value;
			thisSave.header.checksum = (uint)headerCSNumBox.Value;
		}

		public void LoadOtherDataSave()
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);

			currentSaveF00NumBox.Value = toLoad.field_00;
			currentSaveF01NumBox.Value = toLoad.field_01;
			currentSaveBFNumBox.Value = toLoad.bitfield;
			currentSaveF04NumBox.Value = toLoad.field_04;
			currentSaveF06NumBox.Value = toLoad.field_06;
			currentSaveSONumBox.Value = toLoad.switch_on;
			currentSaveF08NumBox.Value = toLoad.field_08;
			//Worlds_available
			//Ambush_countdown
			currentSaveF64NumBox.Value = toLoad.field_64;
			//toad_location
			//field_74C
			//field_774
			//field_79C
			//death_counts
			currentSaveDC34SNumBox.Value = toLoad.death_count_3_4_switch;
			//pad
			currentSaveCSNumBox.Value = toLoad.checksum;
		}

		public void SaveOtherDataSave()
		{
			if(quickSaveCheckBox.Checked)
			{
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].field_00 = (byte)currentSaveF00NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].field_01 = (byte)currentSaveF01NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].bitfield = (byte)currentSaveBFNumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].field_04 = (byte)currentSaveF04NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].field_06 = (byte)currentSaveF06NumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].switch_on = (byte)currentSaveSONumBox.Value;
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].field_08 = (byte)currentSaveF08NumBox.Value;
				//Worlds_available
				//Ambush_countdown
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].field_64 = (ushort)currentSaveF64NumBox.Value;
				//toad_location
				//field_74C
				//field_774
				//field_79C
				//death_counts
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].death_count_3_4_switch = (byte)currentSaveDC34SNumBox.Value;
				//pad
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].checksum = (uint)currentSaveCSNumBox.Value;
			}
			else
			{
				thisSave.saves[saveNumberComboBox.SelectedIndex].field_00 = (byte)currentSaveF00NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].field_01 = (byte)currentSaveF01NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].bitfield = (byte)currentSaveBFNumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].field_04 = (byte)currentSaveF04NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].field_06 = (byte)currentSaveF06NumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].switch_on = (byte)currentSaveSONumBox.Value;
				thisSave.saves[saveNumberComboBox.SelectedIndex].field_08 = (byte)currentSaveF08NumBox.Value;
				//Worlds_available
				//Ambush_countdown
				thisSave.saves[saveNumberComboBox.SelectedIndex].field_64 = (ushort)currentSaveF64NumBox.Value;
				//toad_location
				//field_74C
				//field_774
				//field_79C
				//death_counts
				thisSave.saves[saveNumberComboBox.SelectedIndex].death_count_3_4_switch = (byte)currentSaveDC34SNumBox.Value;
				//pad
				thisSave.saves[saveNumberComboBox.SelectedIndex].checksum = (uint)currentSaveCSNumBox.Value;
			}
		}

		public void ReloadOtherDataSaveArrays()
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			currentSaveWANumBox.Value = toLoad.worlds_available[(int)currentSaveWAparamNumBox.Value];
			currentSaveACNumBox.Value = toLoad.ambush_countdown[(int)currentSaveACparamNumBox.Value];
			currentSaveTLNumBox.Value = toLoad.toad_location[(int)currentSaveTLparamNumBox.Value];
			int fieldIndex1 = ((int)currentSaveF74Cparam1NumBox.Value * 4) + (int)currentSaveF74Cparam2NumBox.Value;
			currentSaveF74CNumBox.Value = toLoad.field_74C[fieldIndex1];
			int fieldIndex2 = ((int)currentSaveF774param1NumBox.Value * 4) + (int)currentSaveF774param2NumBox.Value;
			currentSaveF774NumBox.Value = toLoad.field_774[fieldIndex2];
			int fieldIndex3 = ((int)currentSaveF79Cparam1NumBox.Value * 4) + (int)currentSaveF79Cparam2NumBox.Value;
			currentSaveF79CNumBox.Value = toLoad.field_79C[fieldIndex3];
			int fieldIndex4 = ((int)currentSaveDCparam1NumBox.Value * 42) + (int)currentSaveDCparam2NumBox.Value;
			currentSaveDCNumBox.Value = toLoad.death_counts[fieldIndex4];
			currentSavePNumBox.Value = toLoad.pad[(int)currentSavePparamNumBox.Value];
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				string output;
				dialog.Filter = "NewerSMBW Save File|*.sav|All files (*.*)|*.*";
				dialog.FilterIndex = 1;
				dialog.RestoreDirectory = true;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					thisSave = new SaveFile();
					output = dialog.FileName;
					loadFile(output);
					originalPath = output;
					this.Text = "NewerTanooki - " + output.Split('\\')[output.Split('\\').Length - 1];
				}
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			List<byte> outputFile = new List<byte>();
			outputFile = saveFile();
			using (FileStream outputBin = new FileStream(originalPath, FileMode.Create))
			{
				for (int i = 0; i < outputFile.ToArray().Length; i++)
				{
					outputBin.WriteByte(outputFile[i]);
				}
			}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog textDialog;
			textDialog = new SaveFileDialog();
			textDialog.Filter = "NewerSMBW Save File|*.sav|All files (*.*)|*.*";
			textDialog.DefaultExt = "sav";
			if (textDialog.ShowDialog() == DialogResult.OK)
			{
				//Stream things to get the saved path
				System.IO.Stream fileStream = textDialog.OpenFile();
				System.IO.StreamWriter sw = new System.IO.StreamWriter(fileStream);
				string outputPath = ((FileStream)(sw.BaseStream)).Name;
				sw.Close();
				originalPath = outputPath;
				this.Text = "NewerTanooki - " + outputPath.Split('\\')[outputPath.Split('\\').Length - 1];

				//Save it
				List<byte> outputFile = new List<byte>();
				outputFile = saveFile();
				using (FileStream outputBin = new FileStream(outputPath, FileMode.Create))
				{
					for (int i = 0; i < outputFile.ToArray().Length; i++)
					{
						outputBin.WriteByte(outputFile[i]);
					}
				}
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About a = new About();
			DialogResult dialogresult = a.ShowDialog();
			if (dialogresult == DialogResult.OK)
			{
				a.Close();
			}
		}

		private void Main_Load(object sender, EventArgs e)
		{
			mainTabControl.Enabled = false;
			saveToolStripMenuItem.Enabled = false;
			saveAsToolStripMenuItem.Enabled = false;
		}

		private void fsTextTopButton_Click(object sender, EventArgs e)
		{
			ColorPickerDialog colorPickerDialog = new ColorPickerDialog(); //Made by Cyotek - https://github.com/cyotek/Cyotek.Windows.Forms.ColorPicker - https://www.cyotek.com/blog/colorpicker-controls-for-windows-forms
			colorPickerDialog.Color = fsTextTopButton.BackColor;

			if (colorPickerDialog.ShowDialog() == DialogResult.OK)
			{
				fsTextTopButton.BackColor = colorPickerDialog.Color;
			}
		}

		private void fsTextBottomButton_Click(object sender, EventArgs e)
		{
			ColorPickerDialog colorPickerDialog = new ColorPickerDialog(); //Made by Cyotek - https://github.com/cyotek/Cyotek.Windows.Forms.ColorPicker - https://www.cyotek.com/blog/colorpicker-controls-for-windows-forms
			colorPickerDialog.Color = fsTextBottomButton.BackColor;

			if (colorPickerDialog.ShowDialog() == DialogResult.OK)
			{
				fsTextBottomButton.BackColor = colorPickerDialog.Color;
			}
		}

		private void fsGradientTopButton_Click(object sender, EventArgs e)
		{
			ColorPickerDialog colorPickerDialog = new ColorPickerDialog(); //Made by Cyotek - https://github.com/cyotek/Cyotek.Windows.Forms.ColorPicker - https://www.cyotek.com/blog/colorpicker-controls-for-windows-forms
			colorPickerDialog.Color = fsGradientTopButton.BackColor;

			if (colorPickerDialog.ShowDialog() == DialogResult.OK)
			{
				fsGradientTopButton.BackColor = colorPickerDialog.Color;
			}
		}

		private void fsGradientBottomButton_Click(object sender, EventArgs e)
		{
			ColorPickerDialog colorPickerDialog = new ColorPickerDialog(); //Made by Cyotek - https://github.com/cyotek/Cyotek.Windows.Forms.ColorPicker - https://www.cyotek.com/blog/colorpicker-controls-for-windows-forms
			colorPickerDialog.Color = fsGradientBottomButton.BackColor;

			if (colorPickerDialog.ShowDialog() == DialogResult.OK)
			{
				fsGradientBottomButton.BackColor = colorPickerDialog.Color;
			}
		}

		private void wmTextTopButton_Click(object sender, EventArgs e)
		{
			ColorPickerDialog colorPickerDialog = new ColorPickerDialog(); //Made by Cyotek - https://github.com/cyotek/Cyotek.Windows.Forms.ColorPicker - https://www.cyotek.com/blog/colorpicker-controls-for-windows-forms
			colorPickerDialog.Color = wmTextTopButton.BackColor;

			if (colorPickerDialog.ShowDialog() == DialogResult.OK)
			{
				wmTextTopButton.BackColor = colorPickerDialog.Color;
			}
		}

		private void wmTextBottomButton_Click(object sender, EventArgs e)
		{
			ColorPickerDialog colorPickerDialog = new ColorPickerDialog(); //Made by Cyotek - https://github.com/cyotek/Cyotek.Windows.Forms.ColorPicker - https://www.cyotek.com/blog/colorpicker-controls-for-windows-forms
			colorPickerDialog.Color = wmTextBottomButton.BackColor;

			if (colorPickerDialog.ShowDialog() == DialogResult.OK)
			{
				wmTextBottomButton.BackColor = colorPickerDialog.Color;
			}
		}

		private void hudColorButton_Click(object sender, EventArgs e)
		{
			ColorPickerDialog colorPickerDialog = new ColorPickerDialog(); //Made by Cyotek - https://github.com/cyotek/Cyotek.Windows.Forms.ColorPicker - https://www.cyotek.com/blog/colorpicker-controls-for-windows-forms
			colorPickerDialog.Color = hudColorButton.BackColor;

			if (colorPickerDialog.ShowDialog() == DialogResult.OK)
			{
				hudColorButton.BackColor = colorPickerDialog.Color;
			}
		}

		private void completionNumBox_ValueChanged(object sender, EventArgs e)
		{
			LoadLevelCompletion((int)worldNumBox.Value, (int)levelNumBox.Value);
		}

		private void levelCompletions_CheckedChanged(object sender, EventArgs e)
		{
			SaveLevelCompletion((int)worldNumBox.Value, (int)levelNumBox.Value);
		}

		private void freeCompsNumBox_ValueChanged(object sender, EventArgs e)
		{
			LoadFreemodeCompletions((int)freeWorldNumBox.Value, (int)freeLevelNumBox.Value);
		}

		private void coinCompsNumBox_ValueChanged(object sender, EventArgs e)
		{
			LoadCoinmodeCompletions((int)coinWorldNumBox.Value, (int)coinLevelNumBox.Value);
		}

		private void clearAllLevelsButW9Button_Click(object sender, EventArgs e)
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			for (int i = 0; i < 336; i++)
			{
				toLoad.completions[i] = 0x3B7U;
			}
			for (int i = 377; i < 420; i++)
			{
				toLoad.completions[i] = 0x3B7U;
			}
			LoadLevelCompletion((int)worldNumBox.Value, (int)levelNumBox.Value);
		}

		private void clearAllLevelsButton_Click(object sender, EventArgs e)
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			for (int i = 0; i < 420; i++)
			{
				toLoad.completions[i] = 0x3B7U;
			}
			LoadLevelCompletion((int)worldNumBox.Value, (int)levelNumBox.Value);
		}

		private void clearWorldButton_Click(object sender, EventArgs e)
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			int whichWorld = (int)clearWorldNumBox.Value - 1;
			for (int i = (whichWorld * 42); i < ((whichWorld+1) * 42); i++)
			{
				toLoad.completions[i] = 0x3B7U;
			}
			LoadLevelCompletion((int)worldNumBox.Value, (int)levelNumBox.Value);
		}

		private void clearWorldNumBox_ValueChanged(object sender, EventArgs e)
		{
			clearWorldButton.Text = (clearWorldNumBox.Value < 10) ? ("Clear World " +  clearWorldNumBox.Value) : ("Clear Bonus Worlds");
		}

		private void additionsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (additionsCheckBox.Checked)
			{
				for (int i = 8; i < 17; i++) {
					object newPowerup = ("Powerup ID " + i);
					marioPowerupComboBox.Items.Add(newPowerup);
					luigiPowerupComboBox.Items.Add(newPowerup);
					ytoadPowerupComboBox.Items.Add(newPowerup);
					btoadPowerupComboBox.Items.Add(newPowerup);
				}
				marioLivesNumBox.Maximum = 255;
				luigiLivesNumBox.Maximum = 255;
				ytoadLivesNumBox.Maximum = 255;
				btoadLivesNumBox.Maximum = 255;

				marioCoinsNumBox.Maximum = 255;
				luigiCoinsNumBox.Maximum = 255;
				ytoadCoinsNumBox.Maximum = 255;
				btoadCoinsNumBox.Maximum = 255;

				mushroomNumBox.Maximum = 255;
				fireNumBox.Maximum = 255;
				propellerNumBox.Maximum = 255;
				iceNumBox.Maximum = 255;
				penguinNumBox.Maximum = 255;
				miniNumBox.Maximum = 255;
				starNumBox.Maximum = 255;
				hammerNumBox.Maximum = 255;

				worldAdditionsGroupBox.Enabled = true;
			}
			else
			{
				if (marioPowerupComboBox.SelectedIndex > 7)
				{
					marioPowerupComboBox.SelectedIndex = 0;
				}
				if (luigiPowerupComboBox.SelectedIndex > 7)
				{
					luigiPowerupComboBox.SelectedIndex = 0;
				}
				if (ytoadPowerupComboBox.SelectedIndex > 7)
				{
					ytoadPowerupComboBox.SelectedIndex = 0;
				}
				if (btoadPowerupComboBox.SelectedIndex > 7)
				{
					btoadPowerupComboBox.SelectedIndex = 0;
				}
				for (int i = 8; i < 17; i++)
				{
					marioPowerupComboBox.Items.RemoveAt(marioPowerupComboBox.Items.Count - 1);
					luigiPowerupComboBox.Items.RemoveAt(luigiPowerupComboBox.Items.Count - 1);
					ytoadPowerupComboBox.Items.RemoveAt(ytoadPowerupComboBox.Items.Count - 1);
					btoadPowerupComboBox.Items.RemoveAt(btoadPowerupComboBox.Items.Count - 1);
				}
				marioLivesNumBox.Maximum = 99;
				luigiLivesNumBox.Maximum = 99;
				ytoadLivesNumBox.Maximum = 99;
				btoadLivesNumBox.Maximum = 99;

				marioCoinsNumBox.Maximum = 99;
				luigiCoinsNumBox.Maximum = 99;
				ytoadCoinsNumBox.Maximum = 99;
				btoadCoinsNumBox.Maximum = 99;

				mushroomNumBox.Maximum = 99;
				fireNumBox.Maximum = 99;
				propellerNumBox.Maximum = 99;
				iceNumBox.Maximum = 99;
				penguinNumBox.Maximum = 99;
				miniNumBox.Maximum = 99;
				starNumBox.Maximum = 99;
				hammerNumBox.Maximum = 99;

				powerup8NumBox.Value = 0;
				powerup9NumBox.Value = 0;
				powerup10NumBox.Value = 0;
				powerup11NumBox.Value = 0;
				powerup12NumBox.Value = 0;
				powerup13NumBox.Value = 0;
				powerup14NumBox.Value = 0;
				powerup15NumBox.Value = 0;
				powerup16NumBox.Value = 0;

				worldAdditionsGroupBox.Enabled = false;
			}
		}

		private void saveNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadSaveIntoBoxes(saveNumberComboBox.SelectedIndex, quickSaveCheckBox.Checked);
			LoadLevelCompletion(1, 1);
			LoadCoinmodeCompletions(1, 1);
			LoadFreemodeCompletions(1, 1);
			LoadOtherDataSave();
		}

		private void saveNumberComboBox_Click(object sender, EventArgs e)
		{
			MoveBoxesToData();
		}

		private void currentSaveWAparamNumBox_ValueChanged(object sender, EventArgs e)
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			currentSaveWANumBox.Value = toLoad.worlds_available[(int)currentSaveWAparamNumBox.Value];
		}

		private void currentSaveACparamNumBox_ValueChanged(object sender, EventArgs e)
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			currentSaveACNumBox.Value = toLoad.ambush_countdown[(int)currentSaveACparamNumBox.Value];
		}

		private void currentSaveTLparamNumBox_ValueChanged(object sender, EventArgs e)
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			currentSaveTLNumBox.Value = toLoad.toad_location[(int)currentSaveTLparamNumBox.Value];
		}

		private void currentSaveF74CparamNumBox_ValueChanged(object sender, EventArgs e)
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			int fieldIndex = ((int)currentSaveF74Cparam1NumBox.Value * 4) + (int)currentSaveF74Cparam2NumBox.Value;
			currentSaveF74CNumBox.Value = toLoad.field_74C[fieldIndex];
		}

		private void currentSaveF774paramNumBox_ValueChanged(object sender, EventArgs e)
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			int fieldIndex = ((int)currentSaveF774param1NumBox.Value * 4) + (int)currentSaveF774param2NumBox.Value;
			currentSaveF774NumBox.Value = toLoad.field_774[fieldIndex];
		}

		private void currentSaveF79CparamNumBox_ValueChanged(object sender, EventArgs e)
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			int fieldIndex = ((int)currentSaveF79Cparam1NumBox.Value * 4) + (int)currentSaveF79Cparam2NumBox.Value;
			currentSaveF79CNumBox.Value = toLoad.field_79C[fieldIndex];
		}

		private void currentSaveDCparamNumBox_ValueChanged(object sender, EventArgs e)
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			int fieldIndex = ((int)currentSaveDCparam1NumBox.Value * 42) + (int)currentSaveDCparam2NumBox.Value;
			currentSaveDCNumBox.Value = toLoad.death_counts[fieldIndex];
		}

		private void currentSavePparamNumBox_ValueChanged(object sender, EventArgs e)
		{
			SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
			currentSavePNumBox.Value = toLoad.pad[(int)currentSavePparamNumBox.Value];
		}

		private void currentSaveWANumBox_ValueChanged(object sender, EventArgs e)
		{
			if(quickSaveCheckBox.Checked)
			{
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].worlds_available[(int)currentSaveWAparamNumBox.Value] = (byte)currentSaveWANumBox.Value;
			}
			else
			{
				thisSave.saves[saveNumberComboBox.SelectedIndex].worlds_available[(int)currentSaveWAparamNumBox.Value] = (byte)currentSaveWANumBox.Value;
			}
		}

		private void currentSaveACNumBox_ValueChanged(object sender, EventArgs e)
		{
			if (quickSaveCheckBox.Checked)
			{
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].ambush_countdown[(int)currentSaveACparamNumBox.Value] = (uint)currentSaveACNumBox.Value;
			}
			else
			{
				thisSave.saves[saveNumberComboBox.SelectedIndex].ambush_countdown[(int)currentSaveACparamNumBox.Value] = (uint)currentSaveACNumBox.Value;
			}
		}

		private void currentSaveTLNumBox_ValueChanged(object sender, EventArgs e)
		{
			if (quickSaveCheckBox.Checked)
			{
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].toad_location[(int)currentSaveTLparamNumBox.Value] = (byte)currentSaveTLNumBox.Value;
			}
			else
			{
				thisSave.saves[saveNumberComboBox.SelectedIndex].toad_location[(int)currentSaveTLparamNumBox.Value] = (byte)currentSaveTLNumBox.Value;
			}
		}

		private void currentSaveF74CNumBox_ValueChanged(object sender, EventArgs e)
		{
			int fieldIndex = ((int)currentSaveF74Cparam1NumBox.Value * 4) + (int)currentSaveF74Cparam2NumBox.Value;
			if (quickSaveCheckBox.Checked)
			{
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].field_74C[fieldIndex] = (byte)currentSaveF74CNumBox.Value;
			}
			else
			{
				thisSave.saves[saveNumberComboBox.SelectedIndex].field_74C[fieldIndex] = (byte)currentSaveF74CNumBox.Value;
			}
		}

		private void currentSaveF774NumBox_ValueChanged(object sender, EventArgs e)
		{
			int fieldIndex = ((int)currentSaveF774param1NumBox.Value * 4) + (int)currentSaveF774param2NumBox.Value;
			if (quickSaveCheckBox.Checked)
			{
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].field_774[fieldIndex] = (byte)currentSaveF774NumBox.Value;
			}
			else
			{
				thisSave.saves[saveNumberComboBox.SelectedIndex].field_774[fieldIndex] = (byte)currentSaveF774NumBox.Value;
			}
		}

		private void currentSaveF79CNumBox_ValueChanged(object sender, EventArgs e)
		{
			int fieldIndex = ((int)currentSaveF79Cparam1NumBox.Value * 4) + (int)currentSaveF79Cparam2NumBox.Value;
			if (quickSaveCheckBox.Checked)
			{
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].field_79C[fieldIndex] = (byte)currentSaveF79CNumBox.Value;
			}
			else
			{
				thisSave.saves[saveNumberComboBox.SelectedIndex].field_79C[fieldIndex] = (byte)currentSaveF79CNumBox.Value;
			}
		}

		private void currentSaveDCNumBox_ValueChanged(object sender, EventArgs e)
		{
			int fieldIndex = ((int)currentSaveDCparam1NumBox.Value * 42) + (int)currentSaveDCparam2NumBox.Value;
			if (quickSaveCheckBox.Checked)
			{
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].death_counts[fieldIndex] = (byte)currentSaveDCNumBox.Value;
			}
			else
			{
				thisSave.saves[saveNumberComboBox.SelectedIndex].death_counts[fieldIndex] = (byte)currentSaveDCNumBox.Value;
			}
		}

		private void currentSavePNumBox_ValueChanged(object sender, EventArgs e)
		{
			if (quickSaveCheckBox.Checked)
			{
				thisSave.quickSaves[saveNumberComboBox.SelectedIndex].pad[(int)currentSavePparamNumBox.Value] = (byte)currentSavePNumBox.Value;
			}
			else
			{
				thisSave.saves[saveNumberComboBox.SelectedIndex].pad[(int)currentSavePparamNumBox.Value] = (byte)currentSavePNumBox.Value;
			}
		}

		uint[] HashTable = {
			0x00000000, 0x1DB71064, 0x3B6E20C8, 0x26D930AC,
			0x76DC4190, 0x6B6B51F4, 0x4DB26158, 0x5005713C,
			0xEDB88320, 0xF00F9344, 0xD6D6A3E8, 0xCB61B38C,
			0x9B64C2B0, 0x86D3D2D4, 0xA00AE278, 0xBDBDF21C
		};

		public uint ComputeChecksum(byte[] buffer, uint length) //This wouldn't have been possible without the help of Grop. Enormous thanks to him, you're an awesome person Grop :)
		{
			uint checksum = 0xFFFFFFFF;
			uint uvar5 = length >> 2;

			while (uvar5 != 0)
			{
				checksum = checksum >> 4 ^ HashTable[(checksum ^ buffer[0]) & 0xF];
				checksum = checksum >> 4 ^ HashTable[(checksum ^ buffer[0] >> 4) & 0xF];
				byte pbvar1 = buffer[2];
				checksum = checksum >> 4 ^ HashTable[(checksum ^ buffer[1]) & 0xF];
				checksum = checksum >> 4 ^ HashTable[(checksum ^ buffer[1] >> 4) & 0xF];
				byte pbvar2 = buffer[3];

				List<byte> newBuffer = buffer.ToList();
				newBuffer.RemoveAt(0);
				newBuffer.RemoveAt(0);
				newBuffer.RemoveAt(0);
				newBuffer.RemoveAt(0);
				buffer = newBuffer.ToArray();

				checksum = checksum >> 4 ^ HashTable[(checksum ^ pbvar1) & 0xF];
				checksum = checksum >> 4 ^ HashTable[(checksum ^ pbvar1 >> 4) & 0xF];
				checksum = checksum >> 4 ^ HashTable[(checksum ^ pbvar2) & 0xF];
				checksum = checksum >> 4 ^ HashTable[(checksum ^ pbvar2 >> 4) & 0xF];

				uvar5--;
			}
			length = length & 3;
			if (length == 0)
			{
				return ~checksum;
			}

			while(length != 0)
			{
				byte[] bvar3 = buffer;

				List<byte> newBuffer = buffer.ToList();
				newBuffer.RemoveAt(0);
				buffer = newBuffer.ToArray();

				checksum = checksum >> 4 ^ HashTable[(checksum ^ bvar3[0]) & 0xF];
				checksum = checksum >> 4 ^ HashTable[(checksum ^ bvar3[0] >> 4) & 0xF];

				length--;
			}


			return ~checksum;
		}

		private void fsInfoButton_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("The First Star is the \"Was the game already completed\" Star.\n\nIt is determined if the level slot 08-24 was cleared or not.\n\nTherefore, the best way to get this star is to make it so level 08-24 is cleared in the Level Completions tab.");
		}

		private void ssInfoButton_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("The Second Star is the \"Are all the exits of classical levels got\" Star.\n\nIt is determined by checking if all the levels from the current LevelInfo.bin except those from W9 are cleared or not.\n\nTherefore, the best way to get this star is to use the automated \"Clear Levels (except W9)\" function in the Level Completions tab.");
		}

		private void tsInfoButton_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("The Third Star is the \"Are all the star coins of classical levels collected\" Star.\n\nIt is determined by checking if all the levels from the current LevelInfo.bin except those from W9 have all their star coins collected or not.\n\n");
		}

		private void fosInfoButton_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("The Fourth Star is the \"Are all the exits of W9 levels got\" Star.\n\nIt is determined by checking if all the levels from the 9th world slot in the current LevelInfo.bin are cleared or not.\n\n");
		}

		private void fisInfoButton_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("The Fifth Star is the \"Are all the star coins of W9 levels collected\" Star.\n\nIt is determined by checking if all the star coins from the levels from the 9th world slot in the current LevelInfo.bin are collected or not.\n\n");
		}

		private void starCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (skipStarUpdate < 1) //This is to avoid stars to be broken when placed into checkboxes during the save load
			{
				SaveBlock toLoad = ((quickSaveCheckBox.Checked) ? thisSave.quickSaves[saveNumberComboBox.SelectedIndex] : thisSave.saves[saveNumberComboBox.SelectedIndex]);
				Console.WriteLine("fuck it: " + toLoad.bitfield + " " + currentSaveBFNumBox.Value);
				uint newValue = (uint)toLoad.bitfield;
				newValue &= ~0x3EU; //Remove the star values if there's any
				newValue |= (firstStarCheckBox.Checked ? 2U : 0U) | (secondStarCheckBox.Checked ? 4U : 0U) | (thirdStarCheckBox.Checked ? 8U : 0U) | (fourthStarCheckBox.Checked ? 0x10U : 0U) | (fifthStarCheckBox.Checked ? 0x20U : 0U);
				toLoad.bitfield = (byte)newValue;
				currentSaveBFNumBox.Value = newValue;
				Console.WriteLine("fuck it: " + toLoad.bitfield + " " + currentSaveBFNumBox.Value);
			}
			else
			{
				skipStarUpdate--;
			}
		}
	}

	public class GXColor
	{
		internal byte r;
		internal byte g;
		internal byte b;
		internal byte a;
		public GXColor()
		{ }

		public GXColor(byte newR, byte newG, byte newB, byte newA)
		{
			r = newR;
			g = newG;
			b = newB;
			a = newA;
		}

		public byte[] GXToByteArray()
		{
			byte[] returnToThat = { r, g, b, a };
			return returnToThat;
		}
	}

	public class SaveFirstBlock
	{
		internal List<char> titleID = new List<char>();
		internal byte field_00 = new byte();
		internal byte field_01;
		internal byte current_file;
		internal byte field_03;
		internal List<UInt16> freemode_fav = new List<UInt16>();
		internal List<UInt16> coinbtl_fav = new List<UInt16>();
		internal UInt16 bitfield = new UInt16();
		internal UInt16 field_69A = new UInt16();
		internal UInt32 checksum = new UInt32();
	}

	public class SaveBlock //Ported from NewerSMBW's game.h file, credits to Treeki
	{
		//Main Stuff
		internal byte field_00 = new byte();							// 0x00
		internal byte field_01 = new byte();							// 0x01
		internal byte bitfield = new byte();							// 0x02
		internal byte current_world = new byte();						// 0x03
		internal byte field_04 = new byte();							// 0x04
		internal byte current_path_node = new byte();					// 0x05
		internal byte field_06 = new byte();							// 0x06
		internal byte switch_on = new byte();							// 0x07
		internal byte field_08 = new byte();							// 0x08
		internal List<byte> powerups_available = new List<byte>();		// 0x09
																		//internal byte toad_level_idx[10];     // 0x10
		internal List<byte> player_continues = new List<byte>();		// 0x1A
		internal List<byte> player_coins = new List<byte>();			// 0x1E
		internal List<byte> player_lives = new List<byte>();			// 0x22
		internal List<byte> player_flags = new List<byte>();			// 0x26
		internal List<byte> player_type = new List<byte>();				// 0x2A
		internal List<byte> player_powerup = new List<byte>();			// 0x2E
		internal List<byte> worlds_available = new List<byte>();		// 0x32
		internal List<UInt32> ambush_countdown = new List<UInt32>();    // 0x3C
		internal UInt16 field_64 = new UInt16();						// 0x64
		internal UInt16 spentStarCoins = new UInt16();					// 0x66, used to be credits_hiscore
		internal UInt16 score = new UInt16();							// 0x68
		internal List<UInt32> completions = new List<UInt32>();         // 0x6C

		//Newer Additions, replacing u8 hint_movie_bought[70]
		internal List<char> newerWorldName = new List<char>();			// 0x6FC
		internal List<GXColor> fsTextColours = new List<GXColor>();     // 0x71C
		internal List<GXColor> fsHintColours = new List<GXColor>();     // 0x724
		internal List<GXColor> hudTextColours = new List<GXColor>();    // 0x72C
		internal UInt16 hudHintH = new UInt16();						// 0x734
		internal byte hudHintS = new byte();							// 0x736
		internal byte hudHintL = new byte();							// 0x737
		internal byte currentMapMusic = new byte();						// 0x738
		internal byte newerWorldID = new byte();						// 0x739
		internal byte titleScreenWorld = new byte();					// 0x73A
		internal byte titleScreenLevel = new byte();					// 0x73B
		internal List<byte> unusedShit = new List<byte>();				// 0x73C

		//Back to Main Stuff
		internal List<byte> toad_location = new List<byte>();			// 0x742
		internal List<byte> field_74C = new List<byte>();				// 0x74C
		internal List<byte> field_774 = new List<byte>();				// 0x774
		internal List<byte> field_79C = new List<byte>();				// 0x79C
		internal List<byte> death_counts = new List<byte>();			// 0x7C4
		internal byte death_count_3_4_switch = new byte();				// 0x968
		internal List<byte> pad = new List<byte>();						// 0x969
		internal UInt32 checksum = new UInt32();						// 0x97C
	}

	public class SaveFile
	{
		//Shit
		internal UInt32 field_00 = new UInt32();
		internal UInt32 field_04 = new UInt32();
		internal UInt32 field_08 = new UInt32();
		internal UInt32 field_0C = new UInt32();
		internal UInt32 field_10 = new UInt32();
		internal UInt32 field_14 = new UInt32();
		internal UInt32 field_18 = new UInt32();
		internal UInt32 field_1C = new UInt32();

		//Saves
		internal SaveFirstBlock header = new SaveFirstBlock();
		internal List<SaveBlock> saves = new List<SaveBlock>();
		internal List<SaveBlock> quickSaves = new List<SaveBlock>();
	}
}
