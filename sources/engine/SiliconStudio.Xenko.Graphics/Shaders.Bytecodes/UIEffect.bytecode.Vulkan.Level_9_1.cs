﻿#if SILICONSTUDIO_XENKO_GRAPHICS_API_VULKAN
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [UIEffect]
//
//     Command Line: C:\Dev\Xenko\Vulkan\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --profile=Windows-Vulkan --platform=Windows --output-path=C:\Dev\Xenko\Vulkan\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\app_data --build-path=C:\Dev\Xenko\Vulkan\sources\engine\SiliconStudio.Xenko.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Xenko.Graphics 
{
    internal partial class UIEffect
    {
        private static readonly byte[] binaryBytecode = new byte[] {
3, 192, 254, 239, 0, 5, 0, 0, 0, 14, 85, 73, 69, 102, 102, 101, 99, 116, 83, 104, 97, 100, 101, 114, 1, 11, 199, 77, 176, 148, 82, 115, 206, 132, 146, 186, 47, 167, 110, 27, 119, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 76, 31, 25, 215, 193, 29, 168, 182, 119, 159, 125, 91, 
210, 35, 12, 84, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 252, 149, 143, 37, 199, 91, 237, 34, 31, 232, 194, 67, 83, 107, 157, 134, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 90, 7, 144, 56, 150, 36, 71, 168, 103, 101, 181, 74, 154, 179, 90, 
203, 12, 67, 111, 108, 111, 114, 85, 116, 105, 108, 105, 116, 121, 1, 77, 232, 0, 156, 217, 55, 64, 161, 231, 217, 185, 133, 139, 109, 6, 40, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 9, 0, 
0, 0, 7, 0, 0, 0, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 0, 0, 0, 0, 12, 
83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 0, 234, 11, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 
0, 0, 8, 80, 79, 83, 73, 84, 73, 79, 78, 1, 0, 0, 0, 0, 5, 67, 79, 76, 79, 82, 2, 0, 0, 0, 0, 9, 84, 69, 88, 67, 79, 79, 82, 68, 48, 3, 0, 0, 0, 0, 13, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 0, 0, 0, 0, 0, 0, 160, 11, 
0, 0, 3, 2, 35, 7, 0, 0, 1, 0, 1, 0, 8, 0, 94, 0, 0, 0, 0, 0, 0, 0, 17, 0, 2, 0, 1, 0, 0, 0, 17, 0, 2, 0, 32, 0, 0, 0, 17, 0, 2, 0, 33, 0, 0, 0, 11, 0, 6, 0, 1, 0, 0, 0, 71, 76, 83, 76, 46, 115, 116, 100, 46, 52, 
53, 48, 0, 0, 0, 0, 14, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 15, 0, 13, 0, 0, 0, 0, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 15, 0, 0, 0, 21, 0, 0, 0, 27, 0, 0, 0, 32, 0, 0, 0, 74, 0, 0, 0, 79, 0, 0, 0, 83, 0, 
0, 0, 87, 0, 0, 0, 3, 0, 3, 0, 2, 0, 0, 0, 194, 1, 0, 0, 5, 0, 4, 0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 5, 0, 5, 0, 9, 0, 0, 0, 86, 83, 95, 73, 78, 80, 85, 84, 0, 0, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 0, 0, 
0, 0, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 0, 0, 0, 6, 0, 6, 0, 9, 0, 0, 0, 1, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 51, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 2, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 
100, 54, 49, 0, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 3, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 52, 0, 0, 0, 0, 5, 0, 5, 0, 11, 0, 0, 0, 95, 48, 105, 110, 112, 117, 116, 95, 48, 0, 0, 0, 5, 0, 7, 0, 15, 0, 0, 0, 97, 95, 
66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 0, 0, 0, 0, 5, 0, 5, 0, 21, 0, 0, 0, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 5, 0, 27, 0, 0, 0, 97, 95, 67, 79, 76, 79, 82, 48, 0, 0, 0, 0, 5, 0, 5, 0, 32, 0, 
0, 0, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 0, 5, 0, 5, 0, 35, 0, 0, 0, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 0, 0, 6, 0, 7, 0, 35, 0, 0, 0, 0, 0, 0, 0, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 50, 0, 0, 0, 6, 0, 
6, 0, 35, 0, 0, 0, 1, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 51, 0, 0, 6, 0, 7, 0, 35, 0, 0, 0, 2, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 6, 0, 7, 0, 35, 0, 0, 0, 3, 0, 0, 0, 83, 119, 
105, 122, 122, 108, 101, 95, 105, 100, 55, 52, 0, 0, 0, 0, 6, 0, 8, 0, 35, 0, 0, 0, 4, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 5, 0, 4, 0, 37, 0, 0, 0, 115, 116, 114, 101, 97, 109, 115, 0, 5, 0, 
5, 0, 54, 0, 0, 0, 86, 83, 95, 79, 85, 84, 80, 85, 84, 0, 0, 0, 6, 0, 8, 0, 54, 0, 0, 0, 0, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 6, 0, 6, 0, 54, 0, 0, 0, 1, 0, 0, 0, 67, 111, 
108, 111, 114, 95, 105, 100, 55, 51, 0, 0, 6, 0, 7, 0, 54, 0, 0, 0, 2, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 6, 0, 7, 0, 54, 0, 0, 0, 3, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 52, 0, 0, 
0, 0, 5, 0, 5, 0, 56, 0, 0, 0, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 0, 0, 5, 0, 6, 0, 72, 0, 0, 0, 103, 108, 95, 80, 101, 114, 86, 101, 114, 116, 101, 120, 0, 0, 0, 0, 6, 0, 6, 0, 72, 0, 0, 0, 0, 0, 0, 0, 103, 108, 95, 80, 111, 115, 
105, 116, 105, 111, 110, 0, 6, 0, 7, 0, 72, 0, 0, 0, 1, 0, 0, 0, 103, 108, 95, 80, 111, 105, 110, 116, 83, 105, 122, 101, 0, 0, 0, 0, 6, 0, 7, 0, 72, 0, 0, 0, 2, 0, 0, 0, 103, 108, 95, 67, 108, 105, 112, 68, 105, 115, 116, 97, 110, 99, 101, 0, 6, 0, 
7, 0, 72, 0, 0, 0, 3, 0, 0, 0, 103, 108, 95, 67, 117, 108, 108, 68, 105, 115, 116, 97, 110, 99, 101, 0, 5, 0, 3, 0, 74, 0, 0, 0, 0, 0, 0, 0, 5, 0, 5, 0, 79, 0, 0, 0, 118, 95, 67, 79, 76, 79, 82, 48, 0, 0, 0, 0, 5, 0, 5, 0, 83, 0, 
0, 0, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 7, 0, 87, 0, 0, 0, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 0, 0, 0, 0, 71, 0, 4, 0, 15, 0, 0, 0, 30, 0, 0, 0, 3, 0, 0, 0, 71, 0, 4, 0, 21, 0, 
0, 0, 30, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 27, 0, 0, 0, 30, 0, 0, 0, 1, 0, 0, 0, 71, 0, 4, 0, 32, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 72, 0, 5, 0, 72, 0, 0, 0, 0, 0, 0, 0, 11, 0, 0, 0, 0, 0, 0, 0, 72, 0, 
5, 0, 72, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 1, 0, 0, 0, 72, 0, 5, 0, 72, 0, 0, 0, 2, 0, 0, 0, 11, 0, 0, 0, 3, 0, 0, 0, 72, 0, 5, 0, 72, 0, 0, 0, 3, 0, 0, 0, 11, 0, 0, 0, 4, 0, 0, 0, 71, 0, 3, 0, 72, 0, 
0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 79, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 83, 0, 0, 0, 30, 0, 0, 0, 1, 0, 0, 0, 71, 0, 4, 0, 87, 0, 0, 0, 30, 0, 0, 0, 2, 0, 0, 0, 19, 0, 2, 0, 2, 0, 0, 0, 33, 0, 
3, 0, 3, 0, 0, 0, 2, 0, 0, 0, 22, 0, 3, 0, 6, 0, 0, 0, 32, 0, 0, 0, 23, 0, 4, 0, 7, 0, 0, 0, 6, 0, 0, 0, 4, 0, 0, 0, 23, 0, 4, 0, 8, 0, 0, 0, 6, 0, 0, 0, 2, 0, 0, 0, 30, 0, 6, 0, 9, 0, 0, 0, 7, 0, 
0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 6, 0, 0, 0, 32, 0, 4, 0, 10, 0, 0, 0, 7, 0, 0, 0, 9, 0, 0, 0, 21, 0, 4, 0, 12, 0, 0, 0, 32, 0, 0, 0, 1, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 13, 0, 0, 0, 3, 0, 0, 0, 32, 0, 
4, 0, 14, 0, 0, 0, 1, 0, 0, 0, 6, 0, 0, 0, 59, 0, 4, 0, 14, 0, 0, 0, 15, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 17, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 19, 0, 0, 0, 2, 0, 0, 0, 32, 0, 
4, 0, 20, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 20, 0, 0, 0, 21, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 23, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 25, 0, 0, 0, 1, 0, 0, 0, 32, 0, 
4, 0, 26, 0, 0, 0, 1, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 26, 0, 0, 0, 27, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 29, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 43, 0, 4, 0, 12, 0, 0, 0, 31, 0, 0, 0, 0, 0, 0, 0, 59, 0, 
4, 0, 26, 0, 0, 0, 32, 0, 0, 0, 1, 0, 0, 0, 30, 0, 7, 0, 35, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 6, 0, 0, 0, 7, 0, 0, 0, 32, 0, 4, 0, 36, 0, 0, 0, 7, 0, 0, 0, 35, 0, 0, 0, 43, 0, 4, 0, 12, 0, 
0, 0, 50, 0, 0, 0, 4, 0, 0, 0, 30, 0, 6, 0, 54, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 8, 0, 0, 0, 6, 0, 0, 0, 32, 0, 4, 0, 55, 0, 0, 0, 7, 0, 0, 0, 54, 0, 0, 0, 21, 0, 4, 0, 69, 0, 0, 0, 32, 0, 0, 0, 0, 0, 
0, 0, 43, 0, 4, 0, 69, 0, 0, 0, 70, 0, 0, 0, 1, 0, 0, 0, 28, 0, 4, 0, 71, 0, 0, 0, 6, 0, 0, 0, 70, 0, 0, 0, 30, 0, 6, 0, 72, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 71, 0, 0, 0, 71, 0, 0, 0, 32, 0, 4, 0, 73, 0, 
0, 0, 3, 0, 0, 0, 72, 0, 0, 0, 59, 0, 4, 0, 73, 0, 0, 0, 74, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 77, 0, 0, 0, 3, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 77, 0, 0, 0, 79, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 82, 0, 
0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 82, 0, 0, 0, 83, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 86, 0, 0, 0, 3, 0, 0, 0, 6, 0, 0, 0, 59, 0, 4, 0, 86, 0, 0, 0, 87, 0, 0, 0, 3, 0, 0, 0, 54, 0, 5, 0, 2, 0, 
0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 248, 0, 2, 0, 5, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 11, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 36, 0, 0, 0, 37, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 55, 0, 0, 0, 56, 0, 
0, 0, 7, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 16, 0, 0, 0, 15, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 18, 0, 0, 0, 11, 0, 0, 0, 13, 0, 0, 0, 62, 0, 3, 0, 18, 0, 0, 0, 16, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 22, 0, 
0, 0, 21, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 24, 0, 0, 0, 11, 0, 0, 0, 19, 0, 0, 0, 62, 0, 3, 0, 24, 0, 0, 0, 22, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 28, 0, 0, 0, 27, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 30, 0, 
0, 0, 11, 0, 0, 0, 25, 0, 0, 0, 62, 0, 3, 0, 30, 0, 0, 0, 28, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 33, 0, 0, 0, 32, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 34, 0, 0, 0, 11, 0, 0, 0, 31, 0, 0, 0, 62, 0, 3, 0, 34, 0, 
0, 0, 33, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 38, 0, 0, 0, 11, 0, 0, 0, 31, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 39, 0, 0, 0, 38, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 40, 0, 0, 0, 37, 0, 0, 0, 31, 0, 0, 0, 62, 0, 
3, 0, 40, 0, 0, 0, 39, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 41, 0, 0, 0, 11, 0, 0, 0, 25, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 42, 0, 0, 0, 41, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 43, 0, 0, 0, 37, 0, 0, 0, 25, 0, 
0, 0, 62, 0, 3, 0, 43, 0, 0, 0, 42, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 44, 0, 0, 0, 11, 0, 0, 0, 19, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 45, 0, 0, 0, 44, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 46, 0, 0, 0, 37, 0, 
0, 0, 19, 0, 0, 0, 62, 0, 3, 0, 46, 0, 0, 0, 45, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 47, 0, 0, 0, 11, 0, 0, 0, 13, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 48, 0, 0, 0, 47, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 49, 0, 
0, 0, 37, 0, 0, 0, 13, 0, 0, 0, 62, 0, 3, 0, 49, 0, 0, 0, 48, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 51, 0, 0, 0, 37, 0, 0, 0, 31, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 52, 0, 0, 0, 51, 0, 0, 0, 65, 0, 5, 0, 29, 0, 
0, 0, 53, 0, 0, 0, 37, 0, 0, 0, 50, 0, 0, 0, 62, 0, 3, 0, 53, 0, 0, 0, 52, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 57, 0, 0, 0, 37, 0, 0, 0, 50, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 58, 0, 0, 0, 57, 0, 0, 0, 65, 0, 
5, 0, 29, 0, 0, 0, 59, 0, 0, 0, 56, 0, 0, 0, 31, 0, 0, 0, 62, 0, 3, 0, 59, 0, 0, 0, 58, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 60, 0, 0, 0, 37, 0, 0, 0, 25, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 61, 0, 0, 0, 60, 0, 
0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 62, 0, 0, 0, 56, 0, 0, 0, 25, 0, 0, 0, 62, 0, 3, 0, 62, 0, 0, 0, 61, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 63, 0, 0, 0, 37, 0, 0, 0, 19, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 64, 0, 
0, 0, 63, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 65, 0, 0, 0, 56, 0, 0, 0, 19, 0, 0, 0, 62, 0, 3, 0, 65, 0, 0, 0, 64, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 66, 0, 0, 0, 37, 0, 0, 0, 13, 0, 0, 0, 61, 0, 4, 0, 6, 0, 
0, 0, 67, 0, 0, 0, 66, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 68, 0, 0, 0, 56, 0, 0, 0, 13, 0, 0, 0, 62, 0, 3, 0, 68, 0, 0, 0, 67, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 75, 0, 0, 0, 56, 0, 0, 0, 31, 0, 0, 0, 61, 0, 
4, 0, 7, 0, 0, 0, 76, 0, 0, 0, 75, 0, 0, 0, 65, 0, 5, 0, 77, 0, 0, 0, 78, 0, 0, 0, 74, 0, 0, 0, 31, 0, 0, 0, 62, 0, 3, 0, 78, 0, 0, 0, 76, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 80, 0, 0, 0, 56, 0, 0, 0, 25, 0, 
0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 81, 0, 0, 0, 80, 0, 0, 0, 62, 0, 3, 0, 79, 0, 0, 0, 81, 0, 0, 0, 65, 0, 5, 0, 23, 0, 0, 0, 84, 0, 0, 0, 56, 0, 0, 0, 19, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 85, 0, 0, 0, 84, 0, 
0, 0, 62, 0, 3, 0, 83, 0, 0, 0, 85, 0, 0, 0, 65, 0, 5, 0, 17, 0, 0, 0, 88, 0, 0, 0, 56, 0, 0, 0, 13, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 89, 0, 0, 0, 88, 0, 0, 0, 62, 0, 3, 0, 87, 0, 0, 0, 89, 0, 0, 0, 65, 0, 
6, 0, 86, 0, 0, 0, 90, 0, 0, 0, 74, 0, 0, 0, 31, 0, 0, 0, 70, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 91, 0, 0, 0, 90, 0, 0, 0, 127, 0, 4, 0, 6, 0, 0, 0, 92, 0, 0, 0, 91, 0, 0, 0, 65, 0, 6, 0, 86, 0, 0, 0, 93, 0, 
0, 0, 74, 0, 0, 0, 31, 0, 0, 0, 70, 0, 0, 0, 62, 0, 3, 0, 93, 0, 0, 0, 92, 0, 0, 0, 253, 0, 1, 0, 56, 0, 1, 0, 1, 150, 120, 5, 163, 228, 97, 109, 88, 182, 182, 232, 190, 139, 220, 37, 101, 0, 5, 0, 0, 0, 0, 72, 11, 0, 0, 0, 0, 0, 
0, 0, 0, 2, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 1, 0, 0, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 2, 0, 0, 0, 0, 12, 11, 0, 0, 3, 2, 35, 7, 0, 0, 1, 
0, 1, 0, 8, 0, 100, 0, 0, 0, 0, 0, 0, 0, 17, 0, 2, 0, 1, 0, 0, 0, 11, 0, 6, 0, 1, 0, 0, 0, 71, 76, 83, 76, 46, 115, 116, 100, 46, 52, 53, 48, 0, 0, 0, 0, 14, 0, 3, 0, 0, 0, 0, 0, 1, 0, 0, 0, 15, 0, 10, 0, 4, 0, 0, 
0, 4, 0, 0, 0, 109, 97, 105, 110, 0, 0, 0, 0, 61, 0, 0, 0, 65, 0, 0, 0, 69, 0, 0, 0, 72, 0, 0, 0, 97, 0, 0, 0, 16, 0, 3, 0, 4, 0, 0, 0, 7, 0, 0, 0, 3, 0, 3, 0, 2, 0, 0, 0, 194, 1, 0, 0, 5, 0, 4, 0, 4, 0, 0, 
0, 109, 97, 105, 110, 0, 0, 0, 0, 5, 0, 5, 0, 9, 0, 0, 0, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 0, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 6, 0, 7, 0, 9, 0, 0, 
0, 1, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 52, 0, 0, 0, 0, 6, 0, 6, 0, 9, 0, 0, 0, 2, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 51, 0, 0, 6, 0, 7, 0, 9, 0, 0, 0, 3, 0, 0, 0, 67, 111, 108, 111, 114, 84, 97, 
114, 103, 101, 116, 95, 105, 100, 49, 0, 5, 0, 14, 0, 13, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 115, 116, 114, 117, 99, 116, 45, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 45, 118, 102, 50, 45, 102, 49, 45, 118, 102, 52, 45, 118, 102, 52, 49, 59, 0, 
0, 5, 0, 4, 0, 12, 0, 0, 0, 115, 116, 114, 101, 97, 109, 115, 0, 5, 0, 6, 0, 16, 0, 0, 0, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 0, 0, 0, 0, 5, 0, 6, 0, 19, 0, 0, 0, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 0, 0, 
0, 5, 0, 6, 0, 23, 0, 0, 0, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 0, 0, 0, 0, 5, 0, 6, 0, 33, 0, 0, 0, 115, 119, 105, 122, 122, 108, 101, 100, 67, 111, 108, 111, 114, 0, 0, 0, 5, 0, 5, 0, 56, 0, 0, 0, 86, 83, 95, 79, 85, 84, 80, 
85, 84, 0, 0, 0, 6, 0, 8, 0, 56, 0, 0, 0, 0, 0, 0, 0, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 0, 6, 0, 6, 0, 56, 0, 0, 0, 1, 0, 0, 0, 67, 111, 108, 111, 114, 95, 105, 100, 55, 51, 0, 0, 6, 0, 7, 
0, 56, 0, 0, 0, 2, 0, 0, 0, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 0, 0, 0, 6, 0, 7, 0, 56, 0, 0, 0, 3, 0, 0, 0, 83, 119, 105, 122, 122, 108, 101, 95, 105, 100, 55, 52, 0, 0, 0, 0, 5, 0, 5, 0, 58, 0, 0, 0, 95, 48, 105, 
110, 112, 117, 116, 95, 48, 0, 0, 0, 5, 0, 7, 0, 61, 0, 0, 0, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 0, 0, 0, 0, 5, 0, 5, 0, 65, 0, 0, 0, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 0, 5, 0, 5, 0, 69, 0, 0, 
0, 118, 95, 67, 79, 76, 79, 82, 48, 0, 0, 0, 0, 5, 0, 6, 0, 72, 0, 0, 0, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 0, 0, 0, 0, 5, 0, 4, 0, 75, 0, 0, 0, 115, 116, 114, 101, 97, 109, 115, 0, 5, 0, 4, 0, 85, 0, 0, 0, 112, 97, 114, 
97, 109, 0, 0, 0, 5, 0, 5, 0, 90, 0, 0, 0, 80, 83, 95, 79, 85, 84, 80, 85, 84, 0, 0, 0, 6, 0, 7, 0, 90, 0, 0, 0, 0, 0, 0, 0, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 0, 5, 0, 5, 0, 92, 0, 0, 0, 95, 48, 111, 
117, 116, 112, 117, 116, 95, 48, 0, 0, 5, 0, 10, 0, 97, 0, 0, 0, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 0, 71, 0, 4, 0, 19, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 
0, 71, 0, 4, 0, 19, 0, 0, 0, 33, 0, 0, 0, 1, 0, 0, 0, 71, 0, 4, 0, 23, 0, 0, 0, 34, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 23, 0, 0, 0, 33, 0, 0, 0, 2, 0, 0, 0, 71, 0, 4, 0, 61, 0, 0, 0, 30, 0, 0, 0, 2, 0, 0, 
0, 71, 0, 4, 0, 65, 0, 0, 0, 30, 0, 0, 0, 1, 0, 0, 0, 71, 0, 4, 0, 69, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 0, 71, 0, 4, 0, 72, 0, 0, 0, 11, 0, 0, 0, 15, 0, 0, 0, 71, 0, 4, 0, 97, 0, 0, 0, 30, 0, 0, 0, 0, 0, 0, 
0, 19, 0, 2, 0, 2, 0, 0, 0, 33, 0, 3, 0, 3, 0, 0, 0, 2, 0, 0, 0, 22, 0, 3, 0, 6, 0, 0, 0, 32, 0, 0, 0, 23, 0, 4, 0, 7, 0, 0, 0, 6, 0, 0, 0, 2, 0, 0, 0, 23, 0, 4, 0, 8, 0, 0, 0, 6, 0, 0, 0, 4, 0, 0, 
0, 30, 0, 6, 0, 9, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 8, 0, 0, 0, 8, 0, 0, 0, 32, 0, 4, 0, 10, 0, 0, 0, 7, 0, 0, 0, 9, 0, 0, 0, 33, 0, 4, 0, 11, 0, 0, 0, 8, 0, 0, 0, 10, 0, 0, 0, 32, 0, 4, 0, 15, 0, 0, 
0, 7, 0, 0, 0, 8, 0, 0, 0, 25, 0, 9, 0, 17, 0, 0, 0, 6, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 32, 0, 4, 0, 18, 0, 0, 0, 0, 0, 0, 0, 17, 0, 0, 0, 59, 0, 4, 
0, 18, 0, 0, 0, 19, 0, 0, 0, 0, 0, 0, 0, 26, 0, 2, 0, 21, 0, 0, 0, 32, 0, 4, 0, 22, 0, 0, 0, 0, 0, 0, 0, 21, 0, 0, 0, 59, 0, 4, 0, 22, 0, 0, 0, 23, 0, 0, 0, 0, 0, 0, 0, 27, 0, 3, 0, 25, 0, 0, 0, 17, 0, 0, 
0, 21, 0, 4, 0, 27, 0, 0, 0, 32, 0, 0, 0, 1, 0, 0, 0, 43, 0, 4, 0, 27, 0, 0, 0, 28, 0, 0, 0, 0, 0, 0, 0, 32, 0, 4, 0, 29, 0, 0, 0, 7, 0, 0, 0, 7, 0, 0, 0, 43, 0, 4, 0, 27, 0, 0, 0, 35, 0, 0, 0, 1, 0, 0, 
0, 32, 0, 4, 0, 36, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 43, 0, 4, 0, 6, 0, 0, 0, 39, 0, 0, 0, 0, 0, 0, 0, 20, 0, 2, 0, 40, 0, 0, 0, 43, 0, 4, 0, 27, 0, 0, 0, 50, 0, 0, 0, 2, 0, 0, 0, 30, 0, 6, 0, 56, 0, 0, 
0, 8, 0, 0, 0, 8, 0, 0, 0, 7, 0, 0, 0, 6, 0, 0, 0, 32, 0, 4, 0, 57, 0, 0, 0, 7, 0, 0, 0, 56, 0, 0, 0, 43, 0, 4, 0, 27, 0, 0, 0, 59, 0, 0, 0, 3, 0, 0, 0, 32, 0, 4, 0, 60, 0, 0, 0, 1, 0, 0, 0, 6, 0, 0, 
0, 59, 0, 4, 0, 60, 0, 0, 0, 61, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 64, 0, 0, 0, 1, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 64, 0, 0, 0, 65, 0, 0, 0, 1, 0, 0, 0, 32, 0, 4, 0, 68, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 
0, 59, 0, 4, 0, 68, 0, 0, 0, 69, 0, 0, 0, 1, 0, 0, 0, 59, 0, 4, 0, 68, 0, 0, 0, 72, 0, 0, 0, 1, 0, 0, 0, 30, 0, 3, 0, 90, 0, 0, 0, 8, 0, 0, 0, 32, 0, 4, 0, 91, 0, 0, 0, 7, 0, 0, 0, 90, 0, 0, 0, 32, 0, 4, 
0, 96, 0, 0, 0, 3, 0, 0, 0, 8, 0, 0, 0, 59, 0, 4, 0, 96, 0, 0, 0, 97, 0, 0, 0, 3, 0, 0, 0, 54, 0, 5, 0, 2, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 248, 0, 2, 0, 5, 0, 0, 0, 59, 0, 4, 0, 57, 0, 0, 
0, 58, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 75, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 10, 0, 0, 0, 85, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 91, 0, 0, 0, 92, 0, 0, 0, 7, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 
0, 62, 0, 0, 0, 61, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 63, 0, 0, 0, 58, 0, 0, 0, 59, 0, 0, 0, 62, 0, 3, 0, 63, 0, 0, 0, 62, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 66, 0, 0, 0, 65, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 
0, 67, 0, 0, 0, 58, 0, 0, 0, 50, 0, 0, 0, 62, 0, 3, 0, 67, 0, 0, 0, 66, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 70, 0, 0, 0, 69, 0, 0, 0, 65, 0, 5, 0, 15, 0, 0, 0, 71, 0, 0, 0, 58, 0, 0, 0, 35, 0, 0, 0, 62, 0, 3, 
0, 71, 0, 0, 0, 70, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 73, 0, 0, 0, 72, 0, 0, 0, 65, 0, 5, 0, 15, 0, 0, 0, 74, 0, 0, 0, 58, 0, 0, 0, 28, 0, 0, 0, 62, 0, 3, 0, 74, 0, 0, 0, 73, 0, 0, 0, 65, 0, 5, 0, 15, 0, 0, 
0, 76, 0, 0, 0, 58, 0, 0, 0, 35, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 77, 0, 0, 0, 76, 0, 0, 0, 65, 0, 5, 0, 15, 0, 0, 0, 78, 0, 0, 0, 75, 0, 0, 0, 50, 0, 0, 0, 62, 0, 3, 0, 78, 0, 0, 0, 77, 0, 0, 0, 65, 0, 5, 
0, 29, 0, 0, 0, 79, 0, 0, 0, 58, 0, 0, 0, 50, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 80, 0, 0, 0, 79, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 0, 81, 0, 0, 0, 75, 0, 0, 0, 28, 0, 0, 0, 62, 0, 3, 0, 81, 0, 0, 0, 80, 0, 0, 
0, 65, 0, 5, 0, 36, 0, 0, 0, 82, 0, 0, 0, 58, 0, 0, 0, 59, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 83, 0, 0, 0, 82, 0, 0, 0, 65, 0, 5, 0, 36, 0, 0, 0, 84, 0, 0, 0, 75, 0, 0, 0, 35, 0, 0, 0, 62, 0, 3, 0, 84, 0, 0, 
0, 83, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 86, 0, 0, 0, 75, 0, 0, 0, 62, 0, 3, 0, 85, 0, 0, 0, 86, 0, 0, 0, 57, 0, 5, 0, 8, 0, 0, 0, 87, 0, 0, 0, 13, 0, 0, 0, 85, 0, 0, 0, 61, 0, 4, 0, 9, 0, 0, 0, 88, 0, 0, 
0, 85, 0, 0, 0, 62, 0, 3, 0, 75, 0, 0, 0, 88, 0, 0, 0, 65, 0, 5, 0, 15, 0, 0, 0, 89, 0, 0, 0, 75, 0, 0, 0, 59, 0, 0, 0, 62, 0, 3, 0, 89, 0, 0, 0, 87, 0, 0, 0, 65, 0, 5, 0, 15, 0, 0, 0, 93, 0, 0, 0, 75, 0, 0, 
0, 59, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 94, 0, 0, 0, 93, 0, 0, 0, 65, 0, 5, 0, 15, 0, 0, 0, 95, 0, 0, 0, 92, 0, 0, 0, 28, 0, 0, 0, 62, 0, 3, 0, 95, 0, 0, 0, 94, 0, 0, 0, 65, 0, 5, 0, 15, 0, 0, 0, 98, 0, 0, 
0, 92, 0, 0, 0, 28, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 99, 0, 0, 0, 98, 0, 0, 0, 62, 0, 3, 0, 97, 0, 0, 0, 99, 0, 0, 0, 253, 0, 1, 0, 56, 0, 1, 0, 54, 0, 5, 0, 8, 0, 0, 0, 13, 0, 0, 0, 0, 0, 0, 0, 11, 0, 0, 
0, 55, 0, 3, 0, 10, 0, 0, 0, 12, 0, 0, 0, 248, 0, 2, 0, 14, 0, 0, 0, 59, 0, 4, 0, 15, 0, 0, 0, 16, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 15, 0, 0, 0, 33, 0, 0, 0, 7, 0, 0, 0, 59, 0, 4, 0, 15, 0, 0, 0, 34, 0, 0, 
0, 7, 0, 0, 0, 61, 0, 4, 0, 17, 0, 0, 0, 20, 0, 0, 0, 19, 0, 0, 0, 61, 0, 4, 0, 21, 0, 0, 0, 24, 0, 0, 0, 23, 0, 0, 0, 86, 0, 5, 0, 25, 0, 0, 0, 26, 0, 0, 0, 20, 0, 0, 0, 24, 0, 0, 0, 65, 0, 5, 0, 29, 0, 0, 
0, 30, 0, 0, 0, 12, 0, 0, 0, 28, 0, 0, 0, 61, 0, 4, 0, 7, 0, 0, 0, 31, 0, 0, 0, 30, 0, 0, 0, 87, 0, 5, 0, 8, 0, 0, 0, 32, 0, 0, 0, 26, 0, 0, 0, 31, 0, 0, 0, 62, 0, 3, 0, 16, 0, 0, 0, 32, 0, 0, 0, 65, 0, 5, 
0, 36, 0, 0, 0, 37, 0, 0, 0, 12, 0, 0, 0, 35, 0, 0, 0, 61, 0, 4, 0, 6, 0, 0, 0, 38, 0, 0, 0, 37, 0, 0, 0, 180, 0, 5, 0, 40, 0, 0, 0, 41, 0, 0, 0, 38, 0, 0, 0, 39, 0, 0, 0, 247, 0, 3, 0, 43, 0, 0, 0, 0, 0, 0, 
0, 250, 0, 4, 0, 41, 0, 0, 0, 42, 0, 0, 0, 45, 0, 0, 0, 248, 0, 2, 0, 42, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 44, 0, 0, 0, 16, 0, 0, 0, 62, 0, 3, 0, 34, 0, 0, 0, 44, 0, 0, 0, 249, 0, 2, 0, 43, 0, 0, 0, 248, 0, 2, 
0, 45, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 46, 0, 0, 0, 16, 0, 0, 0, 79, 0, 9, 0, 8, 0, 0, 0, 47, 0, 0, 0, 46, 0, 0, 0, 46, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 62, 0, 3, 0, 34, 0, 0, 
0, 47, 0, 0, 0, 249, 0, 2, 0, 43, 0, 0, 0, 248, 0, 2, 0, 43, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 48, 0, 0, 0, 34, 0, 0, 0, 62, 0, 3, 0, 33, 0, 0, 0, 48, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 49, 0, 0, 0, 33, 0, 0, 
0, 65, 0, 5, 0, 15, 0, 0, 0, 51, 0, 0, 0, 12, 0, 0, 0, 50, 0, 0, 0, 61, 0, 4, 0, 8, 0, 0, 0, 52, 0, 0, 0, 51, 0, 0, 0, 133, 0, 5, 0, 8, 0, 0, 0, 53, 0, 0, 0, 49, 0, 0, 0, 52, 0, 0, 0, 254, 0, 2, 0, 53, 0, 0, 
0, 56, 0, 1, 0, 1, 5, 126, 234, 100, 26, 17, 152, 114, 218, 12, 161, 186, 64, 104, 103, 65, 
        };
    }
}
#endif
