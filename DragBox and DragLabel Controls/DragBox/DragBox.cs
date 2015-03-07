using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace DragBox
{
    public partial class DragBox : Button
    {
        private int id = 0;
        private Color color = Color.White;
        private object linkedObject = null;
        private bool empty = true;

        private void InitializeComponent()
        {
        }

        public DragBox()
        {
            base.FlatStyle = FlatStyle.Flat;
            base.Text = "";
        }

        [Browsable(true)]
        [Description("Sets the DragBox's ID")]
        [DisplayName("ID")]
        [DefaultValue(0)]
        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        [Browsable(true)]
        [Description("Wheter the DragBox is empty or not")]
        [DisplayName("Empty")]
        [DefaultValue(true)]
        public bool Empty
        {
            get
            {
                return this.empty;
            }

            set
            {
                this.empty = value;
            }
        }

        [Browsable(true)]
        [Description("Sets the DragBox's Color")]
        [DisplayName("Color")]
        public Color Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
                base.BackColor = value;
                base.FlatAppearance.BorderColor = value;
                base.FlatAppearance.MouseDownBackColor = value;
                base.FlatAppearance.MouseOverBackColor = value;
                Invalidate();
            }
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
    }
}
