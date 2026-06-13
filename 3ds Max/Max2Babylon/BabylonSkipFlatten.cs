using System.Windows.Forms;
using Autodesk.Max;
using ActionItem = Autodesk.Max.Plugins.ActionItem;

namespace Max2Babylon
{
    class BabylonSkipFlattenToggle:ActionItem
    {

        public override bool ExecuteAction()
        {
            IINode sel = Loader.Core.GetSelNode(0);
            if (sel == null) return true;

            bool doNotFlatten = sel.IsMarkedAsNotFlattenable();
            sel.SetUserPropBool("babylonjs_DoNotFlatten", !doNotFlatten);
            return true;
        }

        public void Close()
        {
            return;
        }

        public override int Id_ => 6;

        public override string ButtonText
        {
            get { return "Babylon 切换跳过展平状态"; }
        }

        public override string MenuText
        {
            get
            {
                IINode sel = Loader.Core.GetSelNode(0);
                if (sel == null)
                {
                    return "节点展平 - 已禁用(&N)";
                }

                if (!sel.IsMarkedAsNotFlattenable())
                {
                    return "节点展平 - 已禁用(&N)";
                }

                return "节点展平 - 已启用(&N)";
            }
        }

        public override string DescriptionText
        {
            get { return "Babylon - 切换跳过展平状态"; }
        }

        public override string CategoryText
        {
            get { return "Babylon"; }
        }

        public override bool IsChecked_
        {
            get { return false; }
        }

        public override bool IsItemVisible
        {
            get { return true; }
        }

        public override bool IsEnabled_
        {
            get { return true; }
        }
    }

}
