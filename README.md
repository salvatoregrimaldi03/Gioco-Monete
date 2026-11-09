# Gioco-Monete 🪙

A Unity-based coin collection game with a finish line goal.

## Table of Contents

- [About the Project](#about-the-project)
- [Features](#features) ✨
- [Tech Stack](#tech-stack) 🛠️
- [Installation](#installation) 🚀
- [Usage](#usage) ▶️
- [Project Structure](#project-structure) 📂
- [Contributing](#contributing) 🤝
- [License](#license) 📄
- [Footer](#footer) 💖

## About the Project 🌍

Gioco-Monete is a simple yet engaging game developed using the Unity engine. The core gameplay involves collecting coins scattered throughout the game environment and reaching a designated finish line. This project serves as a foundational example of game development principles within Unity, focusing on player movement, object interaction (coin collection), and goal-oriented progression.

## Features ✨

*   **Coin Collection Mechanism:** Players can collect coins within the game world.
*   **Goal-Oriented Gameplay:** The objective is to reach the finish line after collecting coins.
*   **Player Controller:** Implements basic player movement and interaction.
*   **Camera Follow:** A script to keep the camera focused on the player.
*   **Unity Engine Development:** Built using the powerful Unity game development platform.

## Tech Stack 🛠️

*   **Game Engine:** Unity
*   **Primary Language:** C# (for scripts), ShaderLab (for materials/shaders)
*   **Assets:** PNG, TGA (for textures), .mat, .shader (for materials and shaders), .unity (for scenes)
*   **Input System:** Unity's Input System (`InputSystem_Actions.inputactions`)
*   **UI:** TextMesh Pro for in-game text rendering.

## Installation 🚀

This project is built using Unity, and the primary way to interact with it is by opening it in the Unity Editor.

1.  **Prerequisites:**
    *   **Unity Hub:** Download and install Unity Hub from the [official Unity website](https://unity.com/download).
    *   **Unity Editor:** Install a compatible version of the Unity Editor. Based on the `ProjectSettings/ProjectVersion.txt` file, the version used is likely `2022.3.14f1`. It's recommended to use this version or a compatible later version.

2.  **Cloning the Repository:**
    Clone the repository to your local machine:
    ```bash
    git clone https://github.com/salvatoregrimaldi03/Gioco-Monete.git
    cd Gioco-Monete
    ```

3.  **Opening in Unity Hub:**
    *   Open Unity Hub.
    *   Click on the 'Add' button and select 'Add project from disk'.
    *   Navigate to the cloned `Gioco-Monete` directory and select it.

4.  **Importing Packages (if necessary):**
    The `Packages/manifest.json` file indicates the project uses specific Unity packages. Unity Hub should handle these automatically when opening the project. If any issues arise, you can manually check and install packages via `Window > Package Manager` in the Unity Editor.

## Usage ▶️

Once the project is open in the Unity Editor, you can play the game directly:

1.  **Open the Sample Scene:**
    Navigate to `Assets/Scenes/` and double-click on `SampleScene.unity` to open it.

2.  **Play the Game:**
    Press the Play button (▶️) in the Unity Editor's toolbar to start the game.

### Gameplay:

*   The player (likely controlled by WASD or arrow keys, inferred from `InputSystem_Actions.inputactions`) moves around the environment.
*   Collect the coins (materials like `gold.mat` and `Money.mat` suggest coin assets) scattered on the ground.
*   Reach the finish line (indicated by `FinishLine.mat`) to complete the level.

## Project Structure 📂

The project follows a standard Unity project structure:

```
Gioco-Monete/
├── Assets/
│   ├── Blue_01_*
│   ├── Dirt_Path_*
│   ├── FinishLine.mat
│   ├── InputSystem_Actions.inputactions
│   ├── Materials/
│   │   └── gold.mat
│   ├── Money.mat
│   ├── Platforms.mat
│   ├── Player.mat
│   ├── Scenes/
│   │   └── SampleScene.unity
│   ├── Scripts/
│   │   ├── CameraFollow.cs
│   │   └── GameManager.cs
│   │   └── PlayerController.cs
│   ├── Skybox.mat
│   ├── T_02_*
│   ├── TextMesh Pro/  (Contains UI assets, shaders, fonts)
│   └── gold.jpeg
├── Packages/
│   ├── manifest.json
│   └── packages-lock.json
├── ProjectSettings/
│   ├── AudioManager.asset
│   ├── ClusterInputManager.asset
│   ├── DynamicsManager.asset
│   ├── EditorSettings.asset
│   ├── GraphicsSettings.asset
│   ├── InputManager.asset
│   ├── MemorySettings.asset
│   ├── MultiplayerManager.asset
│   ├── NavMeshAreas.asset
│   ├── PackageManagerSettings.asset
│   ├── Physics2DSettings.asset
│   ├── PresetManager.asset
│   ├── ProjectSettings.asset
│   ├── ProjectVersion.txt
│   ├── QualitySettings.asset
│   ├── SceneTemplateSettings.json
│   ├── TagManager.asset
│   ├── TimeManager.asset
│   ├── UnityConnectSettings.asset
│   ├── VFXManager.asset
│   ├── VersionControlSettings.asset
│   └── XRSettings.asset
└── README.md
```

### Key Scripts:

*   `Assets/Scripts/PlayerController.cs`: Handles player input and movement.
*   `Assets/Scripts/CameraFollow.cs`: Attaches to the camera and smoothly follows the player.
*   `Assets/Scripts/GameManager.cs`: Manages game state, scoring (coin collection), and potentially win/lose conditions.

## Contributing 🤝

Contributions are welcome! If you have suggestions for improvement or find bugs, please open an issue or submit a pull request.

To contribute:

1.  Fork the repository.
2.  Create a new branch (`git checkout -b feature/AmazingFeature`).
3.  Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4.  Push to the branch (`git push origin feature/AmazingFeature`).
5.  Open a Pull Request.

## License 📄

This project does not specify a license. Please refer to the repository for any licensing information. **(Note: No license was detected in the provided information.)**

## Footer 💖

© 2023 Gioco-Monete. All rights reserved.

This project is maintained by [salvatoregrimaldi03](https://github.com/salvatoregrimaldi03).

--- 

**Star this repository ⭐ | Fork this repository 🍴**
