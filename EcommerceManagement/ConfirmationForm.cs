using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceManagement
{
    public partial class ConfirmationForm : Form
    {
        public EventHandler<bool> ConfirmFormReturn;
        private string confirmationText;
        public ConfirmationForm()
        {
            InitializeComponent();
        }
        public ConfirmationForm(string confirmText)
        {
            InitializeComponent();
            confirmationText = confirmText;
            FormText.Text = confirmationText;
        }
        private void YesButtonClick(object sender, EventArgs e)
        {
           ConfirmFormReturn?.Invoke(this, true);
            this.Dispose();
        }

        private void NoButtonClick(object sender, EventArgs e)
        {
            ConfirmFormReturn?.Invoke(this, false);
            this.Dispose();
        }
    }
}
