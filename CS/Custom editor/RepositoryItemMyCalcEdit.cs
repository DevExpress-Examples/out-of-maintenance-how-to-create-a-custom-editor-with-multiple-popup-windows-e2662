using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;

namespace WindowsApplication1
{
    [System.ComponentModel.DesignerCategory("")]
    [UserRepositoryItem("Register")]
    public class RepositoryItemMyCalcEdit : RepositoryItemCalcEdit
    {
        static RepositoryItemMyCalcEdit()
        {
            Register();
        }
        public RepositoryItemMyCalcEdit() { }

        internal const string EditorName = "MyCalcEdit";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyCalcEdit),
                typeof(RepositoryItemMyCalcEdit), typeof(DevExpress.XtraEditors.ViewInfo.CalcEditViewInfo),
                new ButtonEditPainter(), true, null));
        }
        public override string EditorTypeName
        {
            get { return EditorName; }
        }

        private int _SecondActionButtonIndex;
        public int SecondActionButtonIndex
        {
            get { return _SecondActionButtonIndex; }
            set { _SecondActionButtonIndex = value; }
        }
    }
}
