using System.Windows.Forms;
using Autodesk.Max;
using ActionItem = Autodesk.Max.Plugins.ActionItem;

namespace Max2Babylon
{
    class BabylonToggleBakeAnimation:ActionItem
    {

        public override bool ExecuteAction()
        {
            IINode sel = Loader.Core.GetSelNode(0);
            if (sel == null) return true;

            bool bakeAnimation = sel.IsMarkedAsObjectToBakeAnimation();
            sel.SetUserPropBool("babylonjs_BakeAnimation", !bakeAnimation);
            return true;
        }

        public void Close()
        {
            return;
        }

        public override int Id_
        {
            get { return 1; }
        }

        public override string ButtonText
        {
            get { return "Babylon 切换烘焙动画状态"; }
        }

        public override string MenuText
        {
            get
            {
                IINode sel = Loader.Core.GetSelNode(0);
                if (sel == null)
                {
                    return "烘焙动画 - 已禁用(&B)";
                }

                if (!sel.IsMarkedAsObjectToBakeAnimation())
                {
                    return "烘焙动画 - 已禁用(&B)";
                }

                return "烘焙动画 - 已启用(&B)";
            }
        }

        public override string DescriptionText
        {
            get { return "Toggle Bake Animation status"; }
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
