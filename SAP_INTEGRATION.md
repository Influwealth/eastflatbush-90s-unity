# East Flatbush 90s Unity — SAP Integration

## Role in Sovereign Architecture
East Flatbush 90s Unity is the Unity3D game component of the metaverse layer,
complementing the Roblox implementation in `roblox-wealthbridge-east-flatbush`.

## SAP Node ID: `eastflatbush-unity`

## Token Economy Integration
The Unity client participates in the same East Flatbush Token (EBTK) economy
as the Roblox implementation:

```
Unity Client (C#)
    ↓ HTTP (Unity WebRequest or UnityWebRequest)
WealthBridge API Bridge (api-bridge.ts, port 8002+)
    ↓ REST
Token Gateway (port 8002)
    ↓ ICP calls
Greenville Coin canister (GVC)
```

## API Bridge Integration (C#)
```csharp
// Unity C# — connect to WealthBridge Token Gateway
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class WealthBridgeBridge : MonoBehaviour
{
    private const string TOKEN_GATEWAY_URL = "http://localhost:8002";
    private const string NODE_ID = "eastflatbush-unity";

    public IEnumerator GetBalance(string playerId, System.Action<float> callback)
    {
        string url = $"{TOKEN_GATEWAY_URL}/balance/unity:{playerId}?tier=1";
        using var req = UnityWebRequest.Get(url);
        req.SetRequestHeader("x-sap-node-id", NODE_ID);
        req.SetRequestHeader("x-sap-version", "1.0");
        yield return req.SendWebRequest();
        // parse response...
        callback(0f); // placeholder
    }
}
```

## Relationship to Roblox Implementation
Both Unity and Roblox clients:
- Share the same EBTK token ledger
- Connect via the same WealthBridge Token Gateway (port 8002)
- Can bridge EBTK → GVC for real-world value extraction

## Development
- Unity 2022 LTS or later
- Install WealthBridgeBridge.cs in Assets/Scripts/
- Ensure Token Gateway is running on port 8002

## Branch
All synthesis work: `claude/deepflex-argus-synthesis-jWjmO`
