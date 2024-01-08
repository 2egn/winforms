using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class VisibilityHandler
    {
        internal event EventHandler VisibilitySignalRecieved;

        protected virtual void OnSignalRecieved(EventArgs e)
        {
            VisibilitySignalRecieved?.Invoke(this, e);
        }

        public void ChangeVisibilityToTrue(Form formname)
        {
            Form FormToDelete = formname;
            FormToDelete.Visible = true;
        }
    }
}
