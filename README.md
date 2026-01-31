# East Flatbush 90s — Unity City Twin Capsule

A sovereign, simulation-grade digital twin of 1990s East Flatbush, built using Unity 6.3 LTS, the WealthBridge Capsule SDK, and the Antigravity automation engine.

## 📌 Project Overview
The East Flatbush 90s City Twin recreates a historically accurate, culturally rich version of East Flatbush during the 1990s.
- **NPCs**: Real schedules, dialogue, and behaviors (Antigravity-driven).
- **Environment**: Dynamic 90s atmosphere, bodegas, and subway nodes.
- **Integration**: Full WealthBridge OS Ledger connectivity.

## 🧱 Repository Structure
- /unity: The core Unity 6.3 project.
- /automation: Python scripts for Antigravity & Gemini agents.
- /capsules: Metadata and templates for the City Twin SDK.
- /docs: Architecture and NPC design specs.

## ⚙️ Build Pipeline
Run python automation/unity_build.py --target webgl to deploy to WealthBridge OS.
