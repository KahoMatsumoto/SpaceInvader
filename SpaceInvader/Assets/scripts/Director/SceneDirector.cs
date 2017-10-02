using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace uOSC
{

[RequireComponent(typeof(uOscServer))]
public class SceneDirector : MonoBehaviour {
//	private long latestTimeStamp = 0;
	// Use this for initialization
	void Start () {
//		OSCHandler.Instance.Init();
		var server = GetComponent<uOscServer>();
		server.onDataReceived.AddListener(OnDataReceived);
	}

	void OnDataReceived(Message message) {
		// OSCのアドレス
		Debug.Log("ここやで");
		if (message.address == "/scene") {
			var sceneName = (string)message.values [0];
			Debug.Log (sceneName);
			SceneManager.LoadScene (sceneName);
		}
	}
	
	// Update is called once per frame
	void Update () {
		//if(Input.GetKey(KeyCode.R)){
		//	SceneManager.LoadScene ("Right");
		//}
		//if(Input.GetKey(KeyCode.L)){
		//	SceneManager.LoadScene ("Left");
		//}
//        ListenToOSC();
	}
//	void ListenToOSC()
//	{
//		OSCHandler.Instance.UpdateLogs();
//
//		foreach (KeyValuePair<string, ServerLog> item in OSCHandler.Instance.Servers)
//		{
//			if (item.Value.packets.Count == 0)
//			{
//				continue;
//			}
//
//			int latestPacketIndex = item.Value.packets.Count - 1;
//
//			if (this.latestTimeStamp == item.Value.packets[latestPacketIndex].TimeStamp)
//			{
//				continue;
//			}
//
//			this.latestTimeStamp = item.Value.packets[latestPacketIndex].TimeStamp;
//
//			string s = item.Value.packets[latestPacketIndex].Data[0].ToString();
//			Debug.Log(s);
//			if (item.Value.packets [latestPacketIndex].Address == "/scene") {
//				SceneManager.LoadScene (s);
//			}
////			Debug.Log("Receive : "
////				+ item.Value.packets[latestPacketIndex].TimeStamp
////				+ " / "
////				+ item.Value.packets[latestPacketIndex].Address
////				+ " / "
////				+ item.Value.packets[latestPacketIndex].Data[0]);
//		}
//		OSCHandler.Instance.UpdateLogs();
//		Dictionary<string, ServerLog> servers = new Dictionary<string, ServerLog>();
//		servers = OSCHandler.Instance.Servers;
//
//		foreach (KeyValuePair<string, ServerLog> item in servers)
//		{
//			Debug.Log(item.Value.log.Count);
//			if (item.Value.log.Count > 0)
//			{
//				Debug.Log("count is more than zero");
//				int lastPacketIndex = item.Value.packets.Count - 1;
//
//				string s = item.Value.packets[lastPacketIndex].Data[0].ToString();
//                Debug.Log(s);
//				if (item.Value.packets[lastPacketIndex].Address == "/scene")
//				{
//					SceneManager.LoadScene (s);
////                    switch (int.Parse(s))
////                    {
////                        case 0:
////                            SceneManager.LoadScene("LeftUFO");
////                            break;
////                        case 1:
////                            SceneManager.LoadScene("RightUFO");
////                            break;
////                        default:
////                            SceneManager.LoadScene("Stage1");
////                            break;
////                    }
//					//SceneManager.LoadScene(s);
//				}
//			}
//		}
//		OSCHandler.Instance.UpdateLogs();
//		Debug.Log ("kita");
//	}

}

}