using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace uOSC
{

[RequireComponent(typeof(uOscServer))]
public class SceneDirector : MonoBehaviour {
	void Start () {
		var server = GetComponent<uOscServer>();
		server.onDataReceived.AddListener(OnDataReceived);
	}

	void OnDataReceived(Message message) {
		// OSCのアドレス
		if (message.address == "/scene") {
			var sceneName = (string)message.values [0];
			Debug.Log (sceneName);
            if(sceneName == "Left")
                {
                    sceneName = sceneName + "UFO";
                }
            else if (sceneName == "Right") {
                    sceneName = sceneName + "UFO";
                }
			SceneManager.LoadScene (sceneName);
		}
	}
}

}