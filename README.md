# 🏙️ East Flatbush Block-Twin: Sovereign Mapping Capsule
**Location Focus:** E 91st, E 92nd, E 93rd, E 94th St Corridor.

## 📌 1. The Vision
This project is an exact 1:1 digital replica of the physical blocks in East Flatbush. It serves as the foundation for **Geospatial Sovereignty**, allowing the community to own the data and simulations of their own streets. Unlike generic game levels, every plot here corresponds to a real-world address and building footprint.

## 🛠️ 2. How to Use This Repo

### A. For Youth Developers (The "Block-Builders")
1. **Clone the Repo**: `git clone https://github.com/Influwealth/eastflatbush-90s-unity.git`
2. **Initialize Map**: Run `python automation/generate_map.py` to extrude the 3D buildings from the data.
3. **Update Reality**: Modify `unity/Assets/Capsules/CityTwin/Data/footprints.json` to reflect changes in the physical neighborhood (new buildings, zoning, etc.).

### B. For Automation Agents (Antigravity/Gemini)
- **Map Ingestion**: Agents use `/automation` scripts to update city geometry based on new geospatial data.
- **NPC Logic**: The `npc_profiles.json` links specific "Dialogue Agents" to their physical home plots (e.g., Pops at Plot 94-10).

## 🏗️ 3. Technical Architecture (CCA Model)
- **AX (Agent Experience)**: The backend automation layer for NPCs and city growth.
- **UX (User Experience)**: A high-fidelity, walkable 1:1 Unity 6.3 LTS simulation.
- **DX (Developer Experience)**: A modular "Capsule" structure designed to be forked and taught to future urban planners and developers.

## 💰 4. WealthBridge OS Integration
This capsule is bridged to the **WealthBridge Ledger**. Each physical plot ID in this map serves as a digital twin for economic simulation, community land trust tracking, and youth-led entrepreneurial ventures.

## 🚀 5. Deployment
To generate the WebGL build for the WealthBridge OS dashboard:
```powershell
python automation/unity_build.py --target webgl
