# Medical Scan to 3D Image Conversion
## Overview
This Unity project converts medical scan results, such as X-ray images, into 3D images. Utilizing Unity's powerful rendering capabilities, this project aims to provide an intuitive and interactive way to visualize medical scans in three dimensions, enhancing the ability for diagnosis and analysis.

## Features
X-ray Image Import: Import X-ray images in standard formats (JPEG, PNG, DICOM).
3D Reconstruction: Convert 2D X-ray images into 3D models using advanced algorithms.
Interactive Visualization: Rotate, zoom, and pan the 3D models for detailed examination.
Customizable Settings: Adjust rendering parameters for optimized visualization.
User-Friendly Interface: Simple and intuitive UI for ease of use by medical professionals and researchers.
## Getting Started
### Prerequisites
Unity 2020.3 or later
Windows, macOS, or Linux operating system
Basic knowledge of Unity and C# scripting

### Installation
1.Clone the repository:

sh 
Copy code
git clone https://github.com/vanshikak03/medical-scan-to-3d.git

2.Open the project in Unity:

Launch Unity Hub.
Click on "Open" and navigate to the cloned repository folder.
Select the folder and open the project.

3.Install necessary packages:

Open the Unity Package Manager (Window > Package Manager).
Install any recommended or required packages listed under "Dependencies" in the project.
### Usage
1. Import X-ray Image:

Place your X-ray image file into the Assets/Resources/XrayImages folder.
The image should be in JPEG, PNG, or DICOM format.

2.Load and Convert:

Run the scene named MainScene.
Use the UI to load your image from the dropdown menu.
Click the "Convert to 3D" button to start the reconstruction process.

3.Interact with the 3D Model:

Use mouse or touch controls to interact with the generated 3D model.
Adjust visualization settings via the settings panel.

## Folder Structure
Assets/
Scripts/: Contains C# scripts for image processing, 3D reconstruction, and UI interaction.
Resources/: Stores resources like X-ray images and prefabs.
Scenes/: Contains Unity scenes, including the main scene for the project.
Prefabs/: Prefabricated objects used in the scenes.
Materials/: Materials used for rendering 3D models.
UI/: UI elements and panels.

## Contributing
We welcome contributions to enhance the project. To contribute:

1.Fork the repository.
2.Create a new branch (git checkout -b feature/new-feature).
3.Commit your changes (git commit -m 'Add new feature').
4.Push to the branch (git push origin feature/new-feature).
5.Create a Pull Request.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Acknowledgements
Thanks to the Unity community for the invaluable resources and support.
Inspired by existing medical imaging tools and technologies.
