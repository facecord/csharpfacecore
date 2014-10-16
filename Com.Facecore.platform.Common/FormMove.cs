using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Com.Facecore.platform.Common
{
    public class FormMove
    {
        //mouse point
        private int mouseX = 0; 
        private int mouseY = 0;
        private Form form = null;
        /// <summary>
        /// 控件必须包含在form内，该方法才
        /// </summary>
        /// <param name="c">触发事件的控件</param>
        public void AddMoveForm(Control c)
        {
            form = c.FindForm();
            
            AddMoveForm(c, form);
        }
        private Form GetForm(Control c)
        {
            if (c.Parent == null)
                return null;
            if (c.Parent.GetType() == typeof(Form))
                return (Form)c.Parent;
            else
                return GetForm(c.Parent);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="c">触发事件的控件</param>
        /// <param name="f">窗体</param>
        public void AddMoveForm(Control c, Form f)
        {
            if (f == null || c == null)
                return;
            form = f;
            c.MouseDown += f_MouseDown;
            c.MouseMove += f_MouseMove;
        }

        void f_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                form.Location = new Point(Control.MousePosition.X - mouseX, Control.MousePosition.Y - mouseY);
            }
        }

        void f_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }
    }
}
