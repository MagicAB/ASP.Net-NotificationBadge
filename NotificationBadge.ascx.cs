using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class NotificationBadge : System.Web.UI.UserControl
    {
        /// <summary>
        /// Get or set text displayed within the badge.
        /// </summary>
        public string BadgeText { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the badge type to change background color. Accepts presets or valid css color values (hex color codes/ color names). Grey if not set. 
        /// Presets: Error|Warning|Success
        /// </summary>
        public string BadgeType { get; set; } = string.Empty;

        /// <summary>
        /// Get or set badge tooltip.
        /// </summary>
        public string BadgeAltText { get; set; } = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                return;
            }

            InitializeStyles();

            lblBadge.Text = BadgeText;
            lblBadge.ToolTip = BadgeAltText;

            switch (BadgeType)
            {
                case "Error":
                    lblBadge.Style.Add(HtmlTextWriterStyle.BackgroundColor, "#d9534f");
                    break;
                case "Warning":
                    lblBadge.Style.Add(HtmlTextWriterStyle.BackgroundColor, "#f0ad4e");
                    break;
                case "Success":
                    lblBadge.Style.Add(HtmlTextWriterStyle.BackgroundColor, "#5cb85c");
                    break;
                default:
                    if (BadgeType == "")
                    {
                        lblBadge.Style.Add(HtmlTextWriterStyle.BackgroundColor, "#6c757d");
                    }
                    else
                    {
                        lblBadge.Style.Add(HtmlTextWriterStyle.BackgroundColor, BadgeType);
                    }

                    break;
            }

        }

        /// <summary>
        /// Add base css styles to the notification badge
        /// </summary>
        private void InitializeStyles()
        {
            lblBadge.Style.Add(HtmlTextWriterStyle.Display, "inline-block");
            lblBadge.Style.Add("min-width", "10px");
            lblBadge.Style.Add(HtmlTextWriterStyle.MarginTop, "-5px");
            lblBadge.Style.Add(HtmlTextWriterStyle.Padding, "3px 7px");
            lblBadge.Style.Add(HtmlTextWriterStyle.FontSize, "12px");
            lblBadge.Style.Add(HtmlTextWriterStyle.FontWeight, "bold");
            lblBadge.Style.Add("line-height", "1");
            lblBadge.Style.Add(HtmlTextWriterStyle.Color, "#fff");
            lblBadge.Style.Add(HtmlTextWriterStyle.TextAlign, "center");
            lblBadge.Style.Add(HtmlTextWriterStyle.WhiteSpace, "nowrap");
            lblBadge.Style.Add(HtmlTextWriterStyle.VerticalAlign, "middle");
            lblBadge.Style.Add("border-radius", "10px");

        }
    }
}