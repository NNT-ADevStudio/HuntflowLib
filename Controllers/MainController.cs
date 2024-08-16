using HuntflowLib.Models.HelpModels;

namespace HuntflowLib.Controllers
{
    public class MainController
    {
        public virtual string ControllerUrl => "";

        public Auth Auth { get; set; }

        public MainController(Auth auth)
        {
            Auth = auth;
        }
    }
}
