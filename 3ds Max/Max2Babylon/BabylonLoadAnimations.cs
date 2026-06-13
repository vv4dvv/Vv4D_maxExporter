using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Autodesk.Max;
using ActionItem = Autodesk.Max.Plugins.ActionItem;

namespace Max2Babylon
{
    class BabylonLoadAnimations:ActionItem
    {
        public override bool ExecuteAction()
        {
            var selectedContainers = Tools.GetContainerInSelection();

            if (selectedContainers?.Count <= 0)
            {
                AnimationGroupList.LoadDataFromAnimationHelpers();
                return true;
            }

            foreach (IIContainerObject containerObject in selectedContainers)
            {
                AnimationGroupList.LoadDataFromContainerHelper(containerObject);
            }

            return true;
        }

        public void Close()
        {
            return;
        }

        public override int Id_ => 5;
        public override string ButtonText
        {
            get { return "Babylon 加载动画组"; }
        }

        public override string MenuText
        {
            get
            {
                var selectedContainers = Tools.GetContainerInSelection();
                if (selectedContainers?.Count > 0)
                {
                    return "从选定容器加载 Babylon 动画组(&B)";
                }
                else
                {
                    return "&(Xref/Merge) Babylon Load AnimationGroups";
                }
            }
        }

        public override string DescriptionText
        {
            get { return "Babylon - 从场景或选定容器加载动画组"; }
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