using System;
using ObjCRuntime;

[assembly: LinkWith ("libyoutube.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s, ForceLoad = true)]
