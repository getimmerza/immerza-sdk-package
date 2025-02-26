# immerza-sdk-package
This repository contains the UPM package of the Immerza SDK.

# Immerza Scene Creation & Submission Guide

Welcome to the Immerza developer community! This guide will walk you through the process of creating and submitting immersive and engaging meditation scenes for the Immerza VR app.

## 1. Project Setup

**Unity Version:** Ensure you are using **Unity version [6000.0.36f1](https://unity.com/releases/editor/whats-new/6000.0.36#installs)**. This is essential for scene compatibility with the Immerza platform.

**Template Project:** Begin by cloning the Immerza standard scene template repository from GitHub: 
[https://github.com/getimmerza/standard-scene-template](https://github.com/getimmerza/standard-scene-template)

This template provides a pre-configured foundation for your scene.

## 2. Install the Immerza SDK

1. Open your Unity project
2. Navigate to **Window -> Package Manager**
3. Click the "+" button in the top left corner of the Package Manager window
4. Select "**Add package from git URL...**"
5. Enter the following URL: `https://github.com/getimmerza/immerza-sdk-package.git`
6. Click "**Add**"

The Immerza SDK package will be installed in your project.

## 3. Create and Configure Your Scene

1. Create a new scene in your Unity project (**File -> New Scene**)
2. **Add XR Origin:** Within your newly created scene, add the **XROrigin (VR)** prefab. This provides the necessary VR setup and camera rigging.

## 4. Scene Design and Development

**Design your scene:** Unleash your creativity! Design your meditative environment using models, textures, audio, and other visual elements. Remember to optimize for performance on the Oculus Quest 2 (72 FPS target). Refer to the previous guidelines of assets, licenses and so on.

**Develop features:** Implement any custom features or interactive elements that enhance the meditative experience. Leverage the Immerza SDK to access platform-specific functionalities and integrate seamlessly with the Immerza app.

## 5. Scene Export using the Immerza Scene Bundler

1. Once your scene is complete, open the Immerza Scene Bundler: **Immerza -> Scene Bundler** (in the Unity editor menu bar)
2. In the Scene Bundler window:
   - Click the "Refresh" button to populate the scene selection dropdown
   - Select your scene from the dropdown
   - Click the "**Export Scene**" button

## 6. Locate the Exported Scene Bundle Files

After the export process is complete:
1. Navigate to the **root directory** of your Unity project
2. Locate the "**ImmerzaBundles**" folder
3. Inside this folder, you will find two files:
   - `immerza_data.bundle`: This file contains the compiled scene data
   - `immerza_metadata.json`: This file contains metadata describing your scene and scripts

## 7. Scene Submission on the Immerza Platform

1. Open your web browser and go to [https://yourworld.immerza.com/](https://yourworld.immerza.com/)
2. Log in to your Immerza developer account
3. Click "**Add new scene**"
4. Fill in the required fields:
   - **Name:** The name of your scene
   - **Category:** Select the appropriate category for your scene (e.g., Nature, Abstract, Guided)
   - **Labels:** Add relevant labels to help users find your scene (e.g., Mindfulness, Relaxation, Sleep)
   - **Description:** Provide a detailed description of the scene's experience and purpose
   - **Audio Guide Text:** If your scene includes an audio guide, provide the script/text for the narration
5. Upload a Screenshot:
   - Take a representative screenshot of your scene within the VR environment
   - Upload the screenshot to the platform
6. Upload Scene Files:
   - Upload the `immerza_data.bundle` file
   - Upload the `immerza_metadata.json` file
7. Submit your scene

## 8. Scene Review and Approval

1. Your submitted scene will undergo a review process by the Immerza team
2. We will assess your scene for technical compliance, content quality, and adherence to the Immerza guidelines
3. You may receive feedback and be asked to make revisions
4. Once approved, your scene will be published and made available to Immerza users

**Congratulations!** You have successfully submitted your scene to Immerza. We appreciate your contribution to creating enriching VR meditation experiences.
