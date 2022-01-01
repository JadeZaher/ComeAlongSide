VROutdoorCinema v1.0

For GearVR

Video player does not included in this asset!
To play video apply the video material to TVPlanes objects. You can find some video players on Asset Store for example EasyMovieTexture, or use Unity 5.6 which supports video playback.

Version history:
1.0 First Version 6 stereo images in 8K resolution

Instructions GearVR:
1. "File->Build settings" and switch platform to Android
2. "File->Build settings" Set Texture compression to ETC2
3. "Edit->ProjectSettings->Quaility" set Default parameter for Android platform to "Fantastic"
4. "Edit->Project Settings->Player->Other settings" set Virtual Reality Supported
5. "Edit->Project Settings->Player->Other settings" set Minimum API Level to API Level 19
6. Create two layers "Left" and "Right"
7. Open VROutdoorCinemaMenu scene
8. Check in Hierarchy SphereInside64L is set to "Left" layer, and SphereInside64R is set to "Right" layer, make sure MainCameraL has Culling Mask "Right" unchecked, MainCameraR has Culling Mask "Left" unchecked
9. Place OSIG file to Plugins/Android/Assets folder, to get OSIG file please follow instructions at https://developer.oculus.com/osig/
10. Add all scenes from TirgamesAssets/VROutdoorCinema/Scenes to "Scenes in Build" in "File->Build Setting"
11. Build!

FaceBook: https://www.facebook.com/tirgamesassets
E-Mail: tirgames.assets@gmail.com