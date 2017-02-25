using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace challengeEpicSpiesElectionTracker
{
    public partial class Default : System.Web.UI.Page
    {
        public static void EmptyTextBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ((TextBox)(c)).Text = string.Empty;
                }
                if (c.HasControls())
                {
                    EmptyTextBoxes(c);
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string[] assets = new string[0];
                ViewState.Add("Assets", assets);
                int[] elections = new int[0];
                ViewState.Add("Elections", elections);
                int[] subterfuge = new int[0];
                ViewState.Add("Subterfuge", subterfuge);
                
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {

            string[] assets = (string[])ViewState["Assets"];
            int[] elections = (int[])ViewState["Elections"];
            int[] subterfuge = (int[])ViewState["Subterfuge"];

            if (assetTextBox.Text.Length > 0)
            {
                Array.Resize(ref assets, assets.Length + 1);
                int newestItem = assets.GetUpperBound(0);
                assets[newestItem] = assetTextBox.Text;
                ViewState["Assets"] = assets;
            }
            else
            {
                resultLabel.Text = "<strong>You must enter an Asset codename!</strong>";
                return;
            }

            if (electionsTextBox.Text.Length > 0)
            {
                Array.Resize(ref elections, elections.Length + 1);
                int newestItem = elections.GetUpperBound(0);
                elections[newestItem] = int.Parse(electionsTextBox.Text);
                ViewState["Elections"] = elections;
            }
            else
            {
                resultLabel.Text = "<strong>You must enter a number for Elections rigged!</strong>";
                return;
            }

            if (subterfugeTextBox.Text.Length > 0)
            {
                Array.Resize(ref subterfuge, subterfuge.Length + 1);
                int newestItem = subterfuge.GetUpperBound(0);
                subterfuge[newestItem] = int.Parse(subterfugeTextBox.Text);
                ViewState["Subterfuge"] = subterfuge;
            }
            else
            {
                resultLabel.Text = "<strong>You must enter a number for acts of Subterfuge!</strong>";
                return;
            }

            resultLabel.Text = $"Total elections rigged:<strong>{elections.Sum()}</strong>"
            + $"<br />Average acts of subterfuge per Asset:<strong>{subterfuge.Average():N2}</strong>"
            + $"<br />(The last Asset you added was codenamed <strong>{assets[assets.Length - 1]}</strong>";

            EmptyTextBoxes(Page);
        }
    }
}