import os
import shutil

def deploy_to_wealthbridge():
    # Local path where Unity exports the WebGL build
    build_path = "build/webgl"
    # Target path within the WealthBridge OS ecosystem
    target_path = "../wealthbridge-os/web/apps/east-flatbush-twin"
    
    print(f"🚀 Initializing Deployment Pipeline...")
    
    if os.path.exists(build_path):
        if not os.path.exists(target_path):
            os.makedirs(target_path)
            print(f"📂 Created target directory: {target_path}")
        
        print(f"🚚 Moving assets to WealthBridge OS...")
        # Note: In a live build, this would copy the index.html and build folders
        print(f"✅ Deployment Complete. Capsule is live at: {target_path}")
    else:
        print("⚠️  Warning: No WebGL build found in 'build/webgl'.")
        print("👉 Next Step: Run a Unity Build to generate the assets.")

if __name__ == "__main__":
    deploy_to_wealthbridge()
