using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace DragBox
{
    public class DragLabel : Label
    {
        private object linkedObject;
        private Color normalColor;
        private Color linkedColor;
        private bool linked = false;
        private Point lastLocation;

        public DragLabel()
        {
            this.BackColor = Color.Transparent;
            base.TextAlign = ContentAlignment.MiddleCenter;
        }

        [Browsable(true)]
        [Description("Sets the DragBox's Linked Object")]
        [DisplayName("Linked Object")]
        [DefaultValue(null)]
        public object LinkedObject
        {
            get
            {
                return this.linkedObject;
            }
            set
            {
                this.linkedObject = value;
            }
        }

        [Browsable(true)]
        [Description("Whether the DragLabel is linked or not")]
        [DisplayName("Linked")]
        [DefaultValue(false)]
        public bool Linked
        {
            get
            {
                return this.linked;
            }
            set
            {
                this.linked = value;
                if (!value)
                {
                    this.LinkedObject = null;
                    this.BackColor = this.NormalColor;
                    Invalidate();
                }
                else
                {
                    this.BackColor = this.LinkedColor;
                    this.LastLocation = this.Location;
                    Invalidate();
                }
            }
        }

        [Browsable(true)]
        [Description("DragLabel's color when linked to a DragBox")]
        [DisplayName("Linked Color")]
        public Color LinkedColor
        {
            get
            {
                return this.linkedColor;
            }
            set
            {
                this.linkedColor = value;
            }
        }

        [Browsable(true)]
        [Description("DragLabel's color when not linked to a DragBox")]
        [DisplayName("Normal Color")]
        public Color NormalColor
        {
            get
            {
                return this.normalColor;
            }
            set
            {
                this.normalColor = value;
            }
        }

        [Browsable(false)]
        [Description("Last Location Point")]
        [DisplayName("Last Location")]
        public Point LastLocation
        {
            get
            {
                return this.lastLocation;
            }
            set
            {
                this.lastLocation = value;
            }
        }
    }
}
