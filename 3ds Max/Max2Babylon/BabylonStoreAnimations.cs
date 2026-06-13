using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Autodesk.Max;
using ActionItem = Autodesk.Max.Plugins.ActionItem;

namespace Max2Babylon
{
    class BabylonSaveAnimations:ActionItem
    {

        public override bool ExecuteAction()
        {
            Tools.InitializeGuidNodesMap();
            var selectedContainers = Tools.GetContainerInSelection();

            if (selectedContainers.Count <= 0)
            {
                AnimationGroupList.SaveDataToAnimationHelper();
                return true;
            }

            foreach (IIContainerObject containerObject in selectedContainers)
            {
                AnimationGroupList.SaveDataToContainerHelper(containerObject);
            }

            return true;
        }

        public void Close()
        {
            return;
        }

        public override int Id_ => 4;

        public override string ButtonText
        {
            get { return "Babylon 保存动画组..."; }
        }

        public override string MenuText
        {
            get
            {
                var selectedContainers = Tools.GetContainerInSelection();
                if (selectedContainers?.Count > 0)
                {
                    return "保存 Babylon 动画组到选定容器(&B)...";
                }
                else
                {
                    return "&(Xref/Merge) Babylon Store AnimationGroups";
                }
            }
        }

        public override string DescriptionText
        {
            get { return "Babylon - 将动画组复制到 BabylonAnimationHelper 或 BabylonContainerHelper"; }
        }

        public override string CategoryText
        {
            get { return "Vv4D"; }
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
