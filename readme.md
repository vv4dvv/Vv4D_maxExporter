# Vv4D Max Exporter — 中文化 Babylon.js 3ds Max 导出器

基于 [Babylon.js Exporters](https://github.com/BabylonJS/Exporters) 的 3ds Max 导出器插件，**全面汉化**了导出面板 UI。

## 修改内容

将 3ds Max 中 Babylon 导出 glTF/glb 模型的所有弹出面板进行了完整中文化，共修改 **24 个文件**：

| 类别 | 内容 |
|---|---|
| **主导出面板** | 输出格式、模型路径、纹理路径、导出选项、PBR/变形目标/GLTF 选项、日志输出等 40+ 控件 |
| **属性面板** | 场景属性（碰撞、天空盒、声音）、相机属性、灯光属性（阴影）、对象属性（物理、声音） |
| **动画面板** | 动画组管理（创建/删除/导入/导出）、动画选项、节点树菜单 |
| **辅助面板** | 多文件导出、图层选择器、Draco 压缩参数 |
| **菜单入口** | 所有 Babaylon 菜单项、按钮文字、动态状态提示 |
| **MaxScript** | 材质属性 Rollout 面板 |

详见下方截图对比。

## 兼容性

- ✅ 3ds Max 2022-2027（全版本）
- ✅ 当前编译版本：**3ds Max 2025**（Release_MAX2025）

## 编译

### 环境要求

- .NET 8.0 SDK
- 3ds Max 2025 SDK（`Autodesk.Max.dll` 等已包含在 `Refs/2025/` 目录）

### 编译命令

```bash
# 安装 .NET 8.0 SDK（如未安装）
winget install Microsoft.DotNet.SDK.8

# 编译 2025 版本
cd "3ds Max"
dotnet build Max2Babylon.sln --configuration Release_MAX2025

# 手动部署到 3ds Max 2025
cp bin/Release/2025/*.dll "D:/Program Files/Autodesk/3ds Max 2025/bin/assemblies/"
```

### 编译其他版本

```bash
dotnet build Max2Babylon.sln --configuration Release_MAX2022
dotnet build Max2Babylon.sln --configuration Release_MAX2023
dotnet build Max2Babylon.sln --configuration Release_MAX2024
dotnet build Max2Babylon.sln --configuration Release_MAX2025
dotnet build Max2Babylon.sln --configuration Release_MAX2026
dotnet build Max2Babylon.sln --configuration Release_MAX2027
```

## 安装和使用

1. 将编译好的 DLL 复制到 3ds Max 的 `bin/assemblies/` 目录
2. 启动 3ds Max
3. 菜单栏找到 **Babylon** 菜单
4. 点击 **"Babylon 文件导出器..."** 即可打开汉化面板

> 提示：如果已安装原版英文插件，直接覆盖 DLL 即可，汉化版会自动替换。

## 原始项目

本项目基于 [BabylonJS/Exporters](https://github.com/BabylonJS/Exporters)，原始项目已不再活跃开发，但仍可正常使用。

- Babylon.js 官方论坛：https://forum.babylonjs.com/
- 替代导出方案：https://doc.babylonjs.com/preparingArtForBabylon/dccToGltf

## 许可证

沿用原始项目的 Apache 2.0 许可证。

## 截图

> TODO: 添加汉化前后的面板截图对比
