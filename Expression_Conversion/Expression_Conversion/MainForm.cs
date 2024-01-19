using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expression_Conversion
{
    /// <summary>
    /// Represents the main form for the Expression Conversion application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the conversion buttons.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // Check which button triggered the event and perform the corresponding conversion
            if (btn == buttonFromInfix)
            {
                textBoxPostfix.Text = ExpressionConvert.InfixToPostfix(textBoxInfix.Text);
                textBoxPrefix.Text = ExpressionConvert.InfixToPrefix(textBoxInfix.Text);
            }
            else if (btn == buttonFromPostfix)
            {
                textBoxInfix.Text = ExpressionConvert.PostfixToInfix(textBoxPostfix.Text);
                textBoxPrefix.Text = ExpressionConvert.PostfixToPrefix(textBoxPostfix.Text);
            }
            else if (btn == buttonFromPrefix)
            {
                textBoxInfix.Text = ExpressionConvert.PrefixToInfix(textBoxPrefix.Text);
                textBoxPostfix.Text = ExpressionConvert.PrefixToPostfix(textBoxPrefix.Text);
            }
        }
    }
}
