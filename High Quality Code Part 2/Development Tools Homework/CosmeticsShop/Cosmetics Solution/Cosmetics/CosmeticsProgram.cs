using Cosmetics.Engine;
using log4net;
using log4net.Config;

namespace Cosmetics
{
    /// <summary>
    /// Cosmetisc program start up.
    /// </summary>
    public class CosmeticsProgram
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CosmeticsProgram));

        public static void Main()
        {
            BasicConfigurator.Configure();
            Logger.Debug("Debugged");
            Logger.Error("Error");
            CosmeticsEngine.Instance.Start();
            Logger.Info("Exit of application.");
        }
    }
}
