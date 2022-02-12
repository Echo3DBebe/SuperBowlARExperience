README.md for SuperBowlAR Experience: Throw the football at the Super Bowl using echo3D and ARFoundation! 

# Register
Don't have an API key? Make sure to register for FREE at [echo3D](https://www.echo3d.co/).

# Packages Used
* For AR-supported Android devices
* Unity 2019.4.0f1
* [ARFoundation 3.1.0](https://www.youtube.com/watch?v=0mpsiO2lCx0)
* ARCore XR Plugin 3.1.0
* Android Build Support (Most updated versions)
*    Android SDK & NDK Tools
*    OpenJDK

# How to Play
Tap the screen on your Android device to fire the football. Celebrate your win as the crowd goes wild!

# Setup
* Find the 3D models in 'FieldGoalFolder' 'Models' folder: GitHub\Unity-ARFoundation-echo3D-example\Assets\FieldGoalFolder.
* Go to [echo3D console](https://console.echo3d.co/#/pages/contentmanager) and click "Add to Cloud" and upload the models (we used 1 key key per model).
* Clone the 'GitHub\Unity-ARFoundation-echo3D-example\arfoundationbebe' project
* Open the 'FieldGoal' scene.
* ]Add a 3D model](https://docs.echo3d.co/quickstart/add-a-3d-model) to the cloud in the echo3D console and paste their keys under the correct “Variant” in the Hierarchy.
* [Set up](https://www.youtube.com/watch?v=0mpsiO2lCx0) your Build Settings & Player Settings and export your build to your Android device.
* (Optional) In the 'FieldGoalTrigger.cs' script, you can change the Input on lines 33 or 36 to play in Unity instead of your Android device.









-----------------------------GENERAL README BELOW-----------------------------

# Unity-ARFoundation-echo3D-example
Example Unity project with AR Foundation and echo3D integrated.

Build in Unity version 2019.2 and tested on Unity versions 2020.1, 2019.4, 2018.4.

## Register
Don't have an API key? Make sure to register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).

## Setup
Follow the instructions on our [documentation page](https://docs.echo3D.co/unity/adding-ar-capabilities) to [set your API key](https://docs.echo3D.co/unity/adding-ar-capabilities#3-set-you-api-key).

## Run
* [Add the 3D model](https://docs.echo3D.co/quickstart/add-a-3d-model) to the console.
* [Set the API key](https://docs.echo3D.co/unity/using-the-sdk) in the `echo3D.cs` script inside the `echo3D\echo3D.prefab` using the the Inspector.
* [Build and run the AR application](https://docs.echo3D.co/unity/adding-ar-capabilities#4-build-and-run-the-ar-application).

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join).
