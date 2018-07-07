using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BackgroundChangerForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void update_background()
        {
            string fileName;
            if (get_random_num(1,100) <= favFreq)
            {
                if(files_fav.Count >= 1)
                {
                    fileName = get_random_favorite();
                }
                else
                {
                    int fileIndex = get_random_num(0, files.Count);
                    fileName = files.ElementAt(fileIndex);
                }
            }
            else
            {
                int fileIndex = get_random_num(0, files.Count);
                fileName = files.ElementAt(fileIndex);
            }
            set_background(pathDir + "\\" + fileName, (PicStyle) currentStyle);
            add_to_exclusions(fileName);
            remove_excluded_images();
            write_list_to_excfile(excludeFileName);
            pictureBox1.Load(pathDir + "\\" + fileName);
            imageNameTextBox.Text = fileName;

            if (files_fav.Contains(fileName))
            {
                favoriteCheckBox.Checked = true;
                favoriteToolStripMenuItem.Checked = true;
            }
            else
            {
                favoriteCheckBox.Checked = false;
                favoriteToolStripMenuItem.Checked = false;
            }

        }

        private void Switch_Click(object sender, EventArgs e)
        {
            switchCounter.Enabled = false;
            update_background();
            switchCounter.Enabled = true;
        }

        private void switchCounter_Tick(object sender, EventArgs e)
        {
            update_background();
        }

        private void numericUpDownTimer_ValueChanged(object sender, EventArgs e)
        {
            switchCounter.Enabled = false;
            switchCounter.Interval = (int) numericUpDownTimer.Value*1000;
            countdown = (int) numericUpDownTimer.Value;
            update_config_file(configFileName);
            switchCounter.Enabled = true;
        }

        private void numericUpDownBuffer_ValueChanged(object sender, EventArgs e)
        {
            switchCounter.Enabled = false;
            bufferSize = (int) numericUpDownBuffer.Value;
            update_config_file(configFileName);
            switchCounter.Enabled = true;
        }

        private void chooseDirButton_Click(object sender, EventArgs e)
        {
            if(imageDirDialog.ShowDialog() == DialogResult.OK)
            {
                pathDir = imageDirDialog.SelectedPath;
                imageDirLabel.Text = imageDirDialog.SelectedPath;
                update_config_file(configFileName);
            }
        }

        private void startupTimer_Tick(object sender, EventArgs e)
        {
            //INITIALIZATION
            startupTimer.Enabled = false;
            Hide();
            excludeFileName = "exclusion list.txt";
            configFileName = "config.txt";
            favFileName = "favorites.txt";

            if (File.Exists(configFileName))
            {
                int counter = 0;
                foreach (string line in File.ReadLines(configFileName))
                {
                    switch (counter)
                    {
                        case 0:
                            pathDir = Path.GetFullPath(line.Replace(@"\", @"\\"));
                            break;
                        case 1:
                            countdown = Int32.Parse(line);
                            break;
                        case 2:
                            bufferSize = Int32.Parse(line);
                            break;
                        case 3:
                            currentStyle = Int32.Parse(line);
                            break;
                        case 4:
                            favFreq = Int32.Parse(line);
                            break;
                    }
                    counter++;
                }
            }
            else
            {
                if(imageDirDialog.ShowDialog() == DialogResult.OK)
                {
                    pathDir = imageDirDialog.SelectedPath;
                    countdown = 5000;
                    bufferSize = 20;
                    currentStyle = (int) PicStyle.Stretch;
                    favFreq = 10;
                }
                else
                {
                    Close();
                }

            }


            switchCounter.Interval = countdown*1000;

            get_images_from_path(pathDir);
            get_image_exclusions(excludeFileName);
            get_image_favorites(favFileName);
            remove_excluded_images();
            imageDirLabel.Text = pathDir;
            numericUpDownBuffer.Value = bufferSize;
            numericUpDownTimer.Value = countdown;
            styleComboBox.SelectedIndex = currentStyle;
            favoriteFreq_numericUpDown1.Value = favFreq;
            randomize_images();
            update_background();
            switchCounter.Enabled = true;

        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                BringToFront();
                Activate();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if(pauseButton.Text == "Pause")
            {
                switchCounter.Enabled = false;
                pauseButton.Text = "Run";
            }
            else
            {
                switchCounter.Enabled = true;
                pauseButton.Text = "Pause";
            }


        }

        private void styleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch ((int) styleComboBox.SelectedIndex)
            { 
                case (int) PicStyle.Fill:
                    currentStyle = (int)PicStyle.Fill;
                    break;
                case (int)PicStyle.Fit:
                    currentStyle = (int)PicStyle.Fit;
                    break;
                case (int)PicStyle.Stretch:
                    currentStyle = (int)PicStyle.Stretch;
                    break;
                case (int)PicStyle.Tile:
                    currentStyle = (int)PicStyle.Tile;
                break;
                case (int)PicStyle.Center:
                    currentStyle = (int)PicStyle.Center;
                break;
                case (int)PicStyle.Span:
                    currentStyle = (int)PicStyle.Span;
                    break;
            }
            set_background(pathDir + "\\" + imageNameTextBox.Text, (PicStyle)currentStyle);
            update_config_file(configFileName);
        }

        private void favoriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(favoriteCheckBox.Checked)
            {
                add_to_fav(imageNameTextBox.Text);
            }
            else
            {
                remove_from_fav(imageNameTextBox.Text);
            }
            write_list_to_favfile(favFileName);
        }

        private void favoriteToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (favoriteToolStripMenuItem.Checked)
            {
                add_to_fav(imageNameTextBox.Text);
            }
            else
            {
                remove_from_fav(imageNameTextBox.Text);
            }
            write_list_to_favfile(favFileName);
        }

        private void favoriteFreq_numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            favFreq = (int)favoriteFreq_numericUpDown1.Value;
            update_config_file(configFileName);
        }
    }

}
