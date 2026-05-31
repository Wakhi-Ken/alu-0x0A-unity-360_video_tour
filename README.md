# Extended 360 VR Tour

<img width="593" height="356" alt="Screenshot 2026-05-31 184346" src="https://github.com/user-attachments/assets/b91a5128-3e21-4283-aa3d-2c07dff57a85" />

## Folder Structure

### Assets

#### Animations
Contains animations used for the information panel pop-up and fademask animation.

#### Materials
Contains materials for all panorama spheres and teleportation areas.

#### Models
Contains:
- An inverted sphere model used for displaying 360° content.
- A FadeMask sphere prefab used for transition effects between locations.

#### RenderTextures
Contains Render Texture assets used by the spheres.

#### Scenes
Contains the following scenes:
- **MainMenu**
- **CustomTour**
- **IntranetTour**

#### Textures
Contains textures used for teleportation areas.

#### UI
Contains images used for buttons and information panels.

#### Videos
Contains 360° recorded videos used in the Intranet Tour.

#### VR Pictures
Contains 360° panoramic images used in the Custom Tour.

---

## Scripts

### Hover.cs
Handles information button interactions. When the user selects an information button, the corresponding information panel is displayed.

### TransitionManager.cs
Manages transitions between tour locations by switching spheres and applying a FadeMask animation for smooth visual transitions.

### SceneLoader.cs
Handles scene navigation throughout the application. It also provides a custom secondary trigger action on the left controller that returns the user to the Main Menu.

---

## Features

- Interactive 360° VR tours
- Teleportation between locations
- Information panels for points of interest
- Smooth fade transitions between scenes
- Support for both image-based and video-based 360° experiences
- VR controller interaction

---

## Requirements

- Unity
- XR Interaction Toolkit
- OpenXR
- Meta Quest 2/3 (or compatible VR headset)

---

## How to Run

1. Open the project in Unity.
2. Load the **MainMenu** scene.
3. Connect your VR headset.
4. Press **Play** or build the project to your target device.
