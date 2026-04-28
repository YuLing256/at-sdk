using ATCSharpSDK.Utilities;
using ATCSharpSDK.Actions;
using ATCSharpSDK.Websocket;

namespace ATCSharpSDK;

public static class SdkSetup()
{
  public static void Initialize(string game, string uriString)
  {
	    TaskDispatcher.Initialize();
	    WebsocketHandler ws = new WebsocketHandler(game,uriString);
	    ws.Initialize();
	    
	    ExitApplicationEvent.Initialize();
	    ExitApplicationEvent.ApplicationExiting += ATActionHandler.OnApplicationQuit;
    }
}
