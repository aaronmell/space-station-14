using Content.Client.Administration.UI.Tabs;
using Content.Client.HUD;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.IoC;
using Robust.Shared.Localization;

namespace Content.Client.Administration.UI
{
    [GenerateTypedNameReferences]
    public partial class AdminMenuWindow : DefaultWindow
    {
        [Dependency] private readonly IGameHud? _gameHud = default!;

        public AdminMenuWindow()
        {
            MinSize = SetSize = (500, 250);
            Title = Loc.GetString("admin-menu-title");
            RobustXamlLoader.Load(this);
            IoCManager.InjectDependencies(this);
            MasterTabContainer.SetTabTitle(0, Loc.GetString("admin-menu-admin-tab"));
            MasterTabContainer.SetTabTitle(1, Loc.GetString("admin-menu-adminbus-tab"));
            MasterTabContainer.SetTabTitle(2, Loc.GetString("admin-menu-atmos-tab"));
            MasterTabContainer.SetTabTitle(3, Loc.GetString("admin-menu-round-tab"));
            MasterTabContainer.SetTabTitle(4, Loc.GetString("admin-menu-server-tab"));
            MasterTabContainer.SetTabTitle(5, Loc.GetString("admin-menu-players-tab"));
        }

        protected override void EnteredTree()
        {
            base.EnteredTree();
            if (_gameHud != null)
                _gameHud.AdminButtonDown = true;
        }

        protected override void ExitedTree()
        {
            base.ExitedTree();
            if (_gameHud != null)
                _gameHud.AdminButtonDown = false;
        }
    }
}
