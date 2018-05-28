#!/bin/sh

BASE_URL=http://netstorage.unity3d.com/unity
HASH=88d00a7498cd
VERSION=5.5.1f1

download() {
  file=$1
  url="$BASE_URL/$HASH/$package"

  echo "Downloading from $url: "
  curl -o `basename "$package"` "$url"
}

installUnity() {
  package=$1
  download "$package"

  echo "Installing "`basename "$package"`
  sudo installer -dumplog -package `basename "$package"` -target /
}

# See $BASE_URL/$HASH/unity-$VERSION-$PLATFORM.ini for complete list
# of available packages, where PLATFORM is `osx` or `win`

installUnity "MacEditorInstaller/Unity-$VERSION.pkg"
installUnity "MacEditorTargetInstaller/UnitySetup-Windows-Support-for-Editor-$VERSION.pkg"
installUnity "MacEditorTargetInstaller/UnitySetup-Mac-Support-for-Editor-$VERSION.pkg"
installUnity "MacEditorTargetInstaller/UnitySetup-Linux-Support-for-Editor-$VERSION.pkg"

wget -O Blender.dmg https://download.blender.org/release/Blender2.79/blender-2.79b-macOS-10.6.dmg
sudo hdiutil attach Blender.dmg
cp /Volumes/Blender/Blender /Applications/
