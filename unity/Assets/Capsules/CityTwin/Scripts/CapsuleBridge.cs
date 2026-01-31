using UnityEngine;
using System.Runtime.InteropServices;

public class CapsuleBridge : MonoBehaviour
{
    // This allows Unity to call JavaScript functions in the WealthBridge Web Dashboard
    [DllImport("__Internal")]
    private static extern void PostToWealthBridgeLedger(string plotId, string action, int value);

    public void TriggerPlotEvent(string plotId, string action, int value)
    {
        Debug.Log($"[CapsuleBridge] Reporting {action} on Plot {plotId} to Ledger.");
        
        #if UNITY_WEBGL && !UNITY_EDITOR
            PostToWealthBridgeLedger(plotId, action, value);
        #else
            Debug.Log("Simulating Ledger Post: Run in WebGL build to see live integration.");
        #endif
    }
}
