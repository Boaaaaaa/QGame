/*
 * Project name: BimQGame
 * Name: Boa Im
 * Revision history: 
 *      2022 Nov, 4 Created
 *      2022 Nov, 5 Added codes
 *      2022 Nov, 6 Added codes, summary, and comments
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BimQGame
{
    /// <summary>
    /// This is a class for showing panel to users
    /// </summary>
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is for closing this program when users click exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This method is for open the designForm tab when users click design button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesign_Click(object sender, EventArgs e)
        {
            DesignForm designForm = new DesignForm();
            designForm.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            playForm.ShowDialog();
        }
    }
}
