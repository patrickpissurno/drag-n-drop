using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace DragNDrop
{
    public partial class Form1 : Form, IMessageFilter
    {
        //Delayed methods timer
        System.Threading.Timer mouseUpTimer = null;

        public Form1()
        {
            InitializeComponent();
            #region Mouse Hook
            Application.AddMessageFilter(this);
            this.FormClosed += delegate { Application.RemoveMessageFilter(this); };
            #endregion

            #region Add Drag Events
            foreach (Control control in this.Controls)
            {
                if (control != null && control.GetType().ToString().Equals("System.Windows.Forms.Label"))
                {
                    control.MouseMove += Draggable_Hold;
                }
            }
            #endregion
        }

        #region Mouse Hook Event
        //Define os valores globais de Mouse.Pressed
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x201)
                Mouse.Pressed = true;
            else if (m.Msg == 0x202)
                Mouse.Pressed = false;
            return false;
        }
        #endregion

        #region Drag'n'Drop
        //Evento de quando um Controle é arrastado
        private void Draggable_Hold(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control control = sender as Control;

                //Define o Parent do Controle como a Form o "puxa" para frente e define sua posição
                //para o mouse.
                if (control.Parent.GetType().ToString().Equals("DragBox.DragBox"))
                {
                    (control.Parent as DragBox.DragBox).Empty = true;
                    if ((control.GetType().ToString()).Equals("System.Windows.Forms.Label"))
                        (control as Label).AutoSize = true;
                    control.BackColor = Color.Transparent;
                    control.Parent = this;
                }
                control.BringToFront();
                control.Location = this.PointToClient(Cursor.Position);

                //Inicia o método Mouse_Up com delay de 0.1s caso o mesmo seja nulo, ou reseta o timer
                //caso já exista.
                if (mouseUpTimer == null)
                    mouseUpTimer = new System.Threading.Timer(obj => { Mouse_Up((Control)sender); }, null, 100, System.Threading.Timeout.Infinite);
                else
                    mouseUpTimer.Change(100, System.Threading.Timeout.Infinite);
            }
        }

        //Método de quando um Controle arrastado é solto
        public void Mouse_Up(Control sender)
        {
            //Checa se o método foi chamado de maneira Thread-Safe e caso não tenha sido
            //se chama novamente de maneira thread-safe.
            if (this.InvokeRequired)
            {    
                Invoke(new MethodInvoker(delegate() {
                    Mouse_Up(sender);
                }));
            }
            else
            {
                //Se o mouse estiver apertado reinicia o timer
                if (Mouse.Pressed)
                    mouseUpTimer.Change(100, System.Threading.Timeout.Infinite);
                else
                {
                    //Define o timer para nulo, pega o controle que se encontra abaixo da posição do mouse e
                    //"prende" o controle que estava sendo arrastado à ele.
                    mouseUpTimer = null;
                    Control box = this.GetChildAtPoint(this.PointToClient(new Point(Cursor.Position.X - 1, Cursor.Position.Y - 1)));
                    if (box != null && box != sender)
                    {
                        if (box.GetType().ToString().Equals("DragBox.DragBox"))
                        {
                            DragBox.DragBox dragbox = (box as DragBox.DragBox);
                            if (dragbox.Empty)
                            {
                                sender.Parent = dragbox;
                                dragbox.Empty = false;
                                if ((sender.GetType().ToString()).Equals("System.Windows.Forms.Label"))
                                    (sender as Label).AutoSize = false;
                                sender.Width = sender.Parent.Width;
                                sender.Height = sender.Parent.Height;
                                sender.BackColor = Color.FromArgb(255, 196, 13);
                                sender.Location = new Point(0, 0);
                            }
                            else
                            {
                                sender.Location = new Point(box.Location.X + box.Width + 5, box.Location.Y + box.Height + 5);
                            }
                        }
                    }
                }
            }
        }
        #endregion

    }
}
