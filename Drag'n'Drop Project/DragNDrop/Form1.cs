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
                if (control != null && control.GetType().ToString().Equals("DragBox.DragLabel"))
                {
                    DragBox.DragLabel dragLabel = (DragBox.DragLabel)control;
                    dragLabel.MouseMove += Draggable_Hold;
                    dragLabel.LastLocation = dragLabel.Location;
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
                //Define o Parent do Controle como a Form o "puxa" para frente e define sua posição
                //para o mouse.
                DragBox.DragLabel dragLabel = sender as DragBox.DragLabel;
                if(dragLabel.Parent.GetType().ToString().Equals("DragBox.DragBox"))
                    ((DragBox.DragBox)dragLabel.Parent).Empty = true;
                dragLabel.AutoSize = true;
                dragLabel.Linked = false;
                dragLabel.Parent = this;
                dragLabel.BringToFront();
                dragLabel.Location = this.PointToClient(Cursor.Position);

                //Inicia o método Mouse_Up com delay de 0.1s caso o mesmo seja nulo, ou reseta o timer
                //caso já exista.
                if (mouseUpTimer == null)
                    mouseUpTimer = new System.Threading.Timer(obj => { Mouse_Up(dragLabel); }, null, 100, System.Threading.Timeout.Infinite);
                else
                    mouseUpTimer.Change(100, System.Threading.Timeout.Infinite);
            }
        }

        //Método de quando um Controle arrastado é solto
        public void Mouse_Up(DragBox.DragLabel dragLabel)
        {
            //Checa se o método foi chamado de maneira Thread-Safe e caso não tenha sido
            //se chama novamente de maneira thread-safe.
            if (this.InvokeRequired)
            {    
                Invoke(new MethodInvoker(delegate() {
                    Mouse_Up(dragLabel);
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
                    if (box != null && box != dragLabel && box.GetType().ToString().Equals("DragBox.DragBox"))
                    {
                        DragBox.DragBox dragbox = (box as DragBox.DragBox);
                        if (dragbox.Empty)
                        {
                            dragLabel.Parent = dragbox;
                            dragbox.Empty = false;
                            dragLabel.AutoSize = false;
                            dragLabel.Width = dragLabel.Parent.Width;
                            dragLabel.Height = dragLabel.Parent.Height;
                            dragLabel.Linked = true;
                            dragLabel.Location = new Point(0, 0);
                        }
                        else
                        {
                            //Caso o DragBox esteja cheio, o DragLabel é movido para sua última posição
                            dragLabel.Location = dragLabel.LastLocation;
                        }
                    }
                    else
                    {
                        //Caso o DragLabel não tenha sido arrastado para nenhum DragBox,
                        //sua última posição é atualizada;
                        dragLabel.LastLocation = this.PointToClient(Cursor.Position);
                    }
                }
            }
        }
        #endregion

    }
}
