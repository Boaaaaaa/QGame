/*
 * Project name: BimQGame
 * Name: Boa Im
 * Revision history: 
 *      2022 Nov, 4 Created
 *      2022 Nov, 5 Added codes
 *      2022 Nov, 6 Added codes, summary, and comments
 *      2022 Nov, 23 Added codes
 *      2022 Nov, 24 Added codes
 *      2022 Nov, 25 Added codes
 *      2022 Nov, 27 Added codes, Add summary and comments
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Button = System.Windows.Forms.Button;

namespace BimQGame
{
    /// <summary>
    /// This form is for design a game
    /// </summary>
    public partial class DesignForm : Form
    {
        // Call images from references
        Image None = BimQGame.Properties.Resources.None;
        Image Wall = BimQGame.Properties.Resources.Wall;
        Image RedDoor = BimQGame.Properties.Resources.RedDoor;
        Image GreenDoor = BimQGame.Properties.Resources.GreenDoor;
        Image RedBox = BimQGame.Properties.Resources.RedBox;
        Image GreenBox = BimQGame.Properties.Resources.GreenBox;

        // Save currentImage when user click a toolbox button
        bool toolboxClicked = false;
        Image currentImage = null;

        // Save Rows and Columns
        int Rows;
        int Columns;

        // Count each items
        int countWall = 0;
        int countDoor = 0;
        int countBox = 0;
        
        /// <summary>
        /// Initialize Component
        /// </summary>
        public DesignForm()
        {
            InitializeComponent();
            picNone.Image = None;
            picWall.Image = Wall;
            picRedDoor.Image = RedDoor;
            picGreenDoor.Image = GreenDoor;
            picRedBox.Image = RedBox;
            picGreenBox.Image = GreenBox;
        }

        /// <summary>
        /// This method is for closeing this program when user click exit button in stripMenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This method is for generating picture boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            foreach (gamePictureBox item in pictureBoxes)
            {
                this.Controls.Remove(item);
            }
            // check whether user entered right values
            try
            {
                if (string.IsNullOrEmpty(txtRows.Text) || string.IsNullOrEmpty(txtColumns.Text))
                {
                    MessageBox.Show("Please enter a number to row and column");
                }
                else if (Convert.ToInt32(txtRows.Text) > 10 || Convert.ToInt32(txtColumns.Text) > 10 || Convert.ToInt32(txtRows.Text) == 0 || Convert.ToInt32(txtColumns.Text) == 0)
                {
                    MessageBox.Show("Please enter a number equal or less than 10 and greater than 0");
                }
                else
                {
                    Rows = Convert.ToInt32(txtRows.Text);
                    Columns = Convert.ToInt32(txtColumns.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Only number is available");
            }

            int gap = 5;
            int size = 40;
            int startX = 150;
            int startY = 90;

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
                    Controls.Add(pictureBox);
                    pictureBox.Click += PictureBox_Click;
                    startX = startX + size + gap;
                    pictureBoxes.Add(pictureBox);
                }
                startX = 150;
                startY = startY + size + gap;
            }
        }

        /// <summary>
        /// When users click a pictureBox that was generated, this method is activated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            //Check whether there is already a picture in pictureBox and count how many user used the items
            if (toolboxClicked)
            {
                if (pictureBox.Image == null)
                {
                    if (currentImage == Wall)
                        countWall++;
                    else if (currentImage == RedBox || currentImage == GreenBox)
                        countBox++;
                    else if (currentImage == RedDoor || currentImage == GreenDoor)
                        countDoor++;
                }
                else
                {
                    if (pictureBox.Image == Wall)
                    {
                        countWall--;
                        if (currentImage == Wall)
                            countWall++;
                        else if (currentImage == RedBox || currentImage == GreenBox)
                            countBox++;
                        else if (currentImage == RedDoor || currentImage == GreenDoor)
                            countDoor++;
                    }
                    else if (pictureBox.Image == RedBox || pictureBox.Image == GreenBox)
                    {
                        countBox--;
                        if (currentImage == Wall)
                            countWall++;
                        else if (currentImage == RedBox || currentImage == GreenBox)
                            countBox++;
                        else if (currentImage == RedDoor || currentImage == GreenDoor)
                            countDoor++;
                    }
                    else if (pictureBox.Image == RedDoor || pictureBox.Image == GreenDoor)
                    {
                        countDoor--;
                        if (currentImage == Wall)
                            countWall++;
                        else if (currentImage == RedBox || currentImage == GreenBox)
                            countBox++;
                        else if (currentImage == RedDoor || currentImage == GreenDoor)
                            countDoor++;
                    }
                }
                pictureBox.Image = currentImage;
            }
            else
                MessageBox.Show("Please select a toolbox first");
        }

        /// <summary>
        /// this method is for saving currentImage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolboxClick(object sender, EventArgs e)
        {
            Button toolbox = (Button)sender;

            toolboxClicked = true;

            switch (toolbox.Text)
            {
                case "Wall":
                    currentImage = Wall;
                    break;
                case "Red Door":
                    currentImage = RedDoor;
                    break;
                case "Green Door":
                    currentImage = GreenDoor;
                    break;
                case "Red Box":
                    currentImage = RedBox;
                    break;
                case "Green Box":
                    currentImage = GreenBox;
                    break;
                case "None":
                    currentImage = null;
                    break;
            }

        }

        /// <summary>
        /// this method is for saving game information to a text file when user clicked save button in stripMenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"File saved successfully!\nTotal number of Wall: {countWall}\nTotal number of Door: {countDoor}\nTotal number of Box: {countBox}\n");

            dlgSave.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = dlgSave.ShowDialog();

            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        informationBoxes = new int[pictureBoxes.Count(), 3];
                        int countRow = 0;
                        int countCol = 0;
                        for (int i = 0; i < pictureBoxes.Count(); i++)
                        {
                            informationBoxes[i, 0] = countRow;
                            informationBoxes[i, 1] = countCol;

                            if (pictureBoxes[i].Image == null)
                                informationBoxes[i,2] = 0;
                            else if (pictureBoxes[i].Image == Wall)
                                informationBoxes[i, 2] = 1;
                            else if (pictureBoxes[i].Image == RedDoor)
                                informationBoxes[i, 2] = 2;
                            else if (pictureBoxes[i].Image == GreenDoor)
                                informationBoxes[i, 2] = 3;
                            else if (pictureBoxes[i].Image == RedBox)
                                informationBoxes[i, 2] = 4;
                            else if (pictureBoxes[i].Image == GreenBox)
                                informationBoxes[i, 2] = 5;

                            if (countCol < pictureBoxes.Count() / Rows)
                                countCol++;
                            if (countCol == Columns-1) 
                            {
                                countCol = 0;
                                countRow++;
                            }
                        }
                        
                        string fileName = dlgSave.FileName;
                        save(fileName, informationBoxes);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in saving file: " + ex.Message);
                    }
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
        /// this method is for writing information to text file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="numberOfItems"></param>
        private void save(string fileName, Array pictureBox)
        {
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(Rows);
            writer.WriteLine(Columns);

            foreach(int a in informationBoxes)
                writer.WriteLine(a);
            writer.Close();
        }

        int[,] informationBoxes;
        List<PictureBox> pictureBoxes = new List<PictureBox>();
    }
}
