using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Net;

public class AnalyticsManager : MonoBehaviour
{
    public static IEnumerator PostMethod(string json)
    {
        string url = "https://localhost:5000/upload_data";

        using (UnityWebRequest request = UnityWebRequest.Put(url, json))
        {
            request.method = UnityWebRequest.kHttpVerbPOST;
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Accept", "application/json");

            yield return request.SendWebRequest();

            if (!request.isNetworkError && request.responseCode == (int)HttpStatusCode.OK)
            {
                Debug.Log("Data successfully sent to the server");
            }
            else
            {
                Debug.Log("Error sending data to the server: Error " + request.responseCode);
            }
        }
    }
}
