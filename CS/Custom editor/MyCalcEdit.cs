using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;

namespace WindowsApplication1 {
	/// <summary>
	/// MyCalcEdit is a descendant from CalcEdit.
	/// It displays a dialog form below the text box when the edit button is clicked.
	/// </summary>
    [System.ComponentModel.DesignerCategory("")]
	public class MyCalcEdit : CalcEdit {
		static MyCalcEdit() {
			RepositoryItemMyCalcEdit.Register();
		}
		public MyCalcEdit() {
            
        }

        int _lastClickedButton;

		public override string EditorTypeName { 
			get { return RepositoryItemMyCalcEdit.EditorName; } 
		}
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new RepositoryItemMyCalcEdit Properties { 
			get { return base.Properties as RepositoryItemMyCalcEdit; } 
		}

        protected override void OnPressButton(EditorButtonObjectInfoArgs buttonInfo)
        {
            if (!buttonInfo.Button.Index.Equals(_lastClickedButton))
                DestroyPopupForm();
            _lastClickedButton = buttonInfo.Button.Index;
            base.OnPressButton(buttonInfo);
        }

        protected override bool IsActionButton(EditorButtonObjectInfoArgs buttonInfo)
        {
            return base.IsActionButton(buttonInfo) || buttonInfo.Button.Index == Properties.SecondActionButtonIndex;
        }



        protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm()
        {
            if (_lastClickedButton == Properties.ActionButtonIndex)
                return base.CreatePopupForm();
            if (_lastClickedButton== Properties.SecondActionButtonIndex)
                return new MyCustomForm(this);
            return null;
        }
	}
}