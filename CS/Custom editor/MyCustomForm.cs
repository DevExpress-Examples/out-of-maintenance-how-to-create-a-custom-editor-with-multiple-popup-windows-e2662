using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;
using WindowsApplication1.Custom_editor;

namespace WindowsApplication1
{
    public class MyCustomForm : CustomBlobPopupForm
    {
        public MyCustomForm(PopupBaseEdit ownerEdit)
            : base(ownerEdit)
        {
            CreateControls();
        }
        private void CreateControls()
        {
            CustomFormDesigner uc = new CustomFormDesigner();
            uc.Dock = DockStyle.Fill;
            Controls.Add(uc);
        }
   
    }
}
