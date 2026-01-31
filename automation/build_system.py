import os
import subprocess

def run_build(platform):
    unity_path = "C:/Program Files/Unity/Hub/Editor/6.3.0f1/Editor/Unity.exe" # Confirm your path
    project_path = os.getcwd() + "/unity"
    method = f"BuildScripts.Build{platform}"
    
    cmd = [unity_path, "-quit", "-batchmode", "-projectPath", project_path, "-executeMethod", method]
    print(f"🚀 Antigravity: Triggering {platform} Build...")
    # subprocess.run(cmd) # Uncomment when ready to build live

if __name__ == "__main__":
    run_build("WebGL")
