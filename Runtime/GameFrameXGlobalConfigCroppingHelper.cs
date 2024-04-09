using UnityEngine;

namespace GameFrameX.GlobalConfig.Runtime
{
    public class GameFrameXGlobalConfigCroppingHelper : MonoBehaviour
    {
        private void Start()
        {
            _ = typeof(GlobalConfigComponent);
            _ = typeof(HttpJsonResult);
            _ = typeof(ResponseGameAppVersion);
            _ = typeof(ResponseGlobalInfo);
        }
    }
}