/*
 * Project name: BimQGame
 * Name: Boa Im
 * Revision history: 
 *      2022 Nov, 23 Added codes
 *      2022 Nov, 24 Added codes
 *      2022 Nov, 25 Added codes
 *      2022 Nov, 27 Added codes, Add summary and comments
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace BimQGame
{
    /// <summary>
    /// This class is for playing a game
    /// </summary>
    public partial class PlayForm : Form
    {
        // Call images from references
        Image None = BimQGame.Properties.Resources.None;
        Image Wall = BimQGame.Properties.Resources.Wall;
        Image RedDoor = BimQGame.Properties.Resources.RedDoor;
        Image GreenDoor = BimQGame.Properties.Resources.GreenDoor;
        Image RedBox = BimQGame.Properties.Resources.RedBox;
        Image GreenBox = BimQGame.Properties.Resources.GreenBox;

        //initialize evertyhing
        int Rows = 0;
        int Columns = 0;
        int totalMove = 0;
        int remainBox = 0;
        int index = -1;
        PictureBox currentPicBox = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public PlayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// when a user click a direction button, this method will be started
        /// </summary>
        /// <param name="sender">up, down, left, right</param>
        /// <param name="e"></param>
        private void DirectionBtnClick(object sender, EventArgs e)
        {
            // saving the button what comes from sender
            Button button = (Button)sender;

            int toMove = -1;

            // checking what button is selected
            switch (button.Text)
            {
                case "Up":
                    for(int i = Convert.ToInt32(currentPicBox.Name)-10; i >= Convert.ToInt32(currentPicBox.Name) % 10; i= i-10)
                    {
                        index = (i / 10 * Columns) + (i % 10);
                        if (pictureBoxes[index].Image == null)
                        {
                            toMove = index;
                        }
                        else if(pictureBoxes[index].Image == GreenDoor || pictureBoxes[index].Image == RedDoor)
                        {
                            if ((currentPicBox.Image == GreenBox && pictureBoxes[index].Image == GreenDoor) || (currentPicBox.Image == RedBox && pictureBoxes[index].Image == RedDoor))
                                toMove = index;
                        }
                        else
                            break;
                            
                    }
                    break;
                case "Down":
                    for (int i = Convert.ToInt32(currentPicBox.Name) + 10; i < 100; i = i + 10)
                    {
                        index = (i / 10 * Columns) + (i % 10);
                        if (pictureBoxes[index].Image == null)
                        {
                            toMove = index;
                        }
                        else if (pictureBoxes[index].Image == GreenDoor || pictureBoxes[index].Image == RedDoor)
                        {
                            if ((currentPicBox.Image == GreenBox && pictureBoxes[index].Image == GreenDoor) || (currentPicBox.Image == RedBox && pictureBoxes[index].Image == RedDoor))
                                toMove = index;
                        }
                        else
                            break;
                    }
                    break;
                case "Left":
                    for (int i = Convert.ToInt32(currentPicBox.Name) - 1; i >= Convert.ToInt32(currentPicBox.Name) / 10 * 10; i--)
                    {
                        index = (i / 10 * Columns) + (i % 10);
                        if (pictureBoxes[index].Image == null)
                        {
                            toMove = index;
                        }
                        else if (pictureBoxes[index].Image == GreenDoor || pictureBoxes[index].Image == RedDoor)
                        {
                            if ((currentPicBox.Image == GreenBox && pictureBoxes[index].Image == GreenDoor) || (currentPicBox.Image == RedBox && pictureBoxes[index].Image == RedDoor))
                                toMove = index;
                        }
                        else
                            break;
                    }
                    break;
                case "Right":
                    for (int i = Convert.ToInt32(currentPicBox.Name) + 1; i <= Convert.ToInt32(currentPicBox.Name) / 10 * 10 + 9; i++)
                    {
                        index = (i / 10 * Columns) + (i % 10);
                        if (pictureBoxes[index].Image == null)
                        {
                            toMove = index;
                        }
                        else if (pictureBoxes[index].Image == GreenDoor || pictureBoxes[index].Image == RedDoor)
                        {
                            if ((currentPicBox.Image == GreenBox && pictureBoxes[index].Image == GreenDoor) || (currentPicBox.Image == RedBox && pictureBoxes[index].Image == RedDoor))
                                toMove = index;
                        }
                        else
                            break;
                    }
                    break;
            }
            // moving a box
            ResetCurrentBox(toMove);
        }

        /// <summary>
        /// This method is for moving the selected box and reseting currentBox
        /// </summary>
        /// <param name="toMove">index of pictureboxes</param>
        private void ResetCurrentBox(int toMove)
        {
            if(toMove != -1)
            {
                if (pictureBoxes[toMove].Image == null)
                {
                    Image currentImage = currentPicBox.Image;

                    currentPicBox.Image = null;
                    currentPicBox = pictureBoxes[toMove];
                    currentPicBox.Image = currentImage;
                    totalMove++;
                    txtMoves.Text = totalMove.ToString();
                }
                // Checking whether the box is going to door matched colour
                else
                {
                    currentPicBox.Image = null;
                    currentPicBox = null;
                    btnUp.Enabled = false;
                    btnDown.Enabled = false;
                    btnLeft.Enabled = false;
                    btnRight.Enabled = false;
                    remainBox--;
                    txtBoxes.Text = remainBox.ToString();
                    totalMove++;
                    txtMoves.Text = totalMove.ToString();

                    // Checking the number of remaining Box and Win or not
                    if (remainBox == 0)
                    {
                        
                        MessageBox.Show($"Congratulations!\nGame END with total {totalMove} times moving", "BimQGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        foreach (gamePictureBox item in pictureBoxes)
                        {
                            this.Controls.Remove(item);
                        }
                        totalMove = 0;
                        txtMoves.Text = totalMove.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// This method is for initializing everything and making pictureboxes for playing game
        /// </summary>
        /// <param name="fileName"></param>
        private void load(string fileName)
        {
            foreach (gamePictureBox item in pictureBoxes)
            {
                this.Controls.Remove(item);
            }
            pictureBoxes.Clear();
            totalMove = 0;
            txtMoves.Text = totalMove.ToString();
            remainBox = 0;
            txtBoxes.Text = remainBox.ToString();
            index = -1;
            currentPicBox = null;

            using (StreamReader reader = new StreamReader(fileName))
            {
                Rows = Convert.ToInt32(reader.ReadLine());
                Columns = Convert.ToInt32(reader.ReadLine());

                int gap = 5;
                int size = 40;
                int startX = 30;
                int startY = 50;

                // Set the pictureBox properties
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        gamePictureBox pictureBox = new gamePictureBox();
                        pictureBox.Height = size;
                        pictureBox.Width = size;
                        pictureBox.Left = startX;
                        pictureBox.Top = startY;
                        pictureBox.BorderStyle = BorderStyle.FixedSingle;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Name = $"{i}{j}";

                        int x = Convert.ToInt32(reader.ReadLine());
                        int y = Convert.ToInt32(reader.ReadLine());
                        int pictureNumber = Convert.ToInt32(reader.ReadLine());

                        switch (pictureNumber)
                        {
                            case 0:
                                pictureBox.Image = null;
                                break;
                            case 1:
                                pictureBox.Image = Wall;
                                break;
                            case 2:
                                pictureBox.Image = RedDoor;
                                break;
                            case 3:
                                pictureBox.Image = GreenDoor;
                                break;
                            case 4:
                                pictureBox.Image = RedBox;
                                break;
                            case 5:
                                pictureBox.Image = GreenBox;
                                break;
                        }

                        Controls.Add(pictureBox);
                        pictureBox.BringToFront();
                        pictureBox.Click += PictureBox_Click;
                        startX = startX + size + gap;
                        pictureBoxes.Add(pictureBox);
                    }
                    startX = 30;
                    startY = startY + size + gap;
                }
            }
            foreach (PictureBox a in pictureBoxes)
            {
                if (a.Image == GreenBox || a.Image == RedBox)
                    remainBox++;
            }
            txtBoxes.Text = remainBox.ToString();
        }

        /// <summary>
        /// this method is for checking whether picturebox is selected or not
        /// </summary>
        /// <param name="sender">what picturebox is selected</param>
        /// <param name="e"></param>
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            currentPicBox= pictureBox;

            if(currentPicBox.Image == GreenBox || currentPicBox.Image == RedBox)
            {
                btnUp.Enabled = true;
                btnDown.Enabled = true;
                btnLeft.Enabled = true;
                btnRight.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a box you want to move");
                btnUp.Enabled = false;
                btnDown.Enabled = false;
                btnLeft.Enabled = false;
                btnRight.Enabled = false;
            }
        }

        /// <summary>
        /// loading a game from txt files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgOpen.Filter = "Text file|*.txt|All files|*.*";
            dlgOpen.InitialDirectory = "c:\\";

            DialogResult result = dlgOpen.ShowDialog();
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    string filename = dlgOpen.FileName;
                    load(filename);
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// close play form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //this is for saving picture boxes
        List<PictureBox> pictureBoxes = new List<PictureBox>();
    }
}
