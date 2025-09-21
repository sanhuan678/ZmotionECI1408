

# 自动化表面缺陷检测系统

[![C#](https://img.shields.io/badge/Language-C%23-%23239120.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Framework](https://img.shields.io/badge/Framework-WinForm-%23512bd4.svg)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![Vision](https://img.shields.io/badge/Vision-OpenCV-%23ff0000.svg)](https://opencv.org/)
[![Motion Control](https://img.shields.io/badge/Motion%20Control-Zmotion%20ECI1408-0078d7.svg)](http://www.zmotion.com.cn/)
[![Database](https://img.shields.io/badge/Database-Entity%20Framework%20(Code%20First)-green.svg)](https://docs.microsoft.com/en-us/ef/)


一个集成了高精度运动控制与机器视觉的自动化表面缺陷检测系统。该系统通过上位机软件统一控制，驱动运动平台并触发工业相机，利用图像处理算法自动识别产品表面的划痕、凹坑、污点等缺陷，最终实现检测结果的自动分类、报警与数据记录。

## ✨ 项目特点

- **模块化设计**: 采用高内聚、低耦合的软件架构，层次清晰，便于维护与扩展。
- **高精度定位**: 基于正运动技术(Zmotion) ECI1408四轴控制卡，实现精密运动控制。
- **实时视觉处理**: 集成工业相机SDK与OpenCV库，实现图像的稳定采集与实时分析。
- **自动化工作流**: 实现了从运动定位、图像采集、缺陷分析到结果存储的全自动化流程。
- **数据持久化**: 使用Entity Framework Core Code First模式，高效管理检测结果和历史数据。

## 🏗️ 系统架构

该系统采用典型的三层架构设计：

1.  **通信层 (Communication Layer)**
    *   负责与下位机硬件（运动控制卡、工业相机）的交互。
    *   封装了正运动ZMC API，处理所有运动控制指令和状态读取。
    *   集成相机厂商SDK，管理相机的初始化、配置和图像采集。

2.  **业务逻辑层 (Business Logic Layer)**
    *   是系统的核心，处理复杂的业务流程。
    *   协调运动控制与视觉处理的时序（例如，确保平台停稳后触发拍照）。
    *   实现缺陷检测的核心算法（基于OpenCV的图像处理与分析）。
    *   管理检测结果的判断、分类和数据库操作。

3.  **UI表现层 (UI Presentation Layer)**
    *   基于C# WinForm开发，提供用户交互界面。
    *   显示相机实时流、运动控制状态、I/O监控、检测结果等信息。
    *   提供参数配置、手动操作（JOG、回零）、历史查询等功能入口。

## ⚙️ 核心技术栈

| 模块             | 技术/工具                                                                 |
| :--------------- | :------------------------------------------------------------------------ |
| **编程语言**     | C#                                                                        |
| **UI框架**       | Windows Forms (WinForm)                                                   |
| **运动控制**     | 正运动技术ECI1408控制卡 / ZMC API 动态链接库                              |
| **机器视觉**     | OpenCV, 工业相机厂商SDK (如Hikvision, Daheng, Basler等)                   |
| **数据持久化**   | Entity Framework (EF) Core / EF6 - Code First 模式                        |
| **数据库**       | SQL Server                                      |

## 🚀 主要功能

### 1. 运动控制模块
-   **通信连接**: 稳定连接与断开运动控制卡。
-   **多轴运动**: 支持多轴的点位运动（PVT），精确定位到相机拍摄工位。
-   **手动操作**: 支持JOG寸动、回零（Homming）等手动控制功能。
-   **安全监控**: 实时监控限位传感器等I/O状态，确保系统运行安全。

### 2. 视觉处理模块
-   **相机管理**: 相机的初始化、参数配置（曝光、增益、触发模式等）。
-   **软触发采集**: 采用事件驱动机制，由软件精确控制拍照时机，确保图像清晰不模糊。
-   **实时流显示**: 在UI界面实时显示相机采集的画面。
-   **缺陷识别**: 集成OpenCV算法，用于识别划痕、凹坑、污点等表面缺陷。

### 3. 数据管理模块
-   **结果存储**: 使用EF Code First模式自动创建数据库表结构。
-   **记录内容**: 自动化存储每一条检测结果，包括OK/NG状态、时间戳、NG图像保存路径等。
-   **高效查询**: 提供对历史检测数据的高效查询和检索功能。


## 🛠️ 安装与使用

1.  **环境准备**
    *   安装 [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (根据项目目标框架版本，如 .NET 4.7.2+)。
    *   安装 [Visual Studio](https://visualstudio.microsoft.com/) (推荐2019或更高版本)。

2.  **硬件依赖**
    *   正运动技术 ECI1408 运动控制卡及其配套ZMC开发库。
    *   支持软触发和SDK开发的工业相机（如海康、大恒等）。
    *   合适的镜头和光源。

3.  **克隆项目**
    ```bash
    git clone https://github.com/sanhuan678/ZmotionECI1408.git
    cd ZmotionECI1408
    ```

4.  **还原NuGet包**
    *   使用Visual Studio打开解决方案文件 (`.sln`)。
    *   右键解决方案，选择“还原NuGet包”。

5.  **引用硬件SDK**
    *   将正运动技术的 `ZMC_API.dll` 及相关文件放置到指定目录（如 `\dll`）并正确引用。
    *   同理，引用相机厂商提供的SDK。

6.  **配置数据库连接**
    *   在 `App.config` 或 `ApplicationDbContext.cs` 中修改数据库连接字符串，指向您的SQL Server或SQLite数据库。

7.  **编译运行**
    *   在Visual Studio中生成并运行项目。

## 📷 系统界面预览

<img width="1170" height="669" alt="image" src="https://github.com/user-attachments/assets/76013569-cf6e-4054-8ecf-6b9c5a8a6d57" />
<img width="400" height="468" alt="image" src="https://github.com/user-attachments/assets/d9daa1de-d74c-4dd8-b932-6b694d7c7a9d" />
<img width="646" height="527" alt="image" src="https://github.com/user-attachments/assets/4a8a9bd2-c01a-4a34-a614-babdfccc5134" />
<img width="977" height="675" alt="image" src="https://github.com/user-attachments/assets/1cb5540f-f9db-42ad-84bc-5f4c8086d90b" />
<img width="992" height="447" alt="image" src="https://github.com/user-attachments/assets/0a8d7d9a-6582-45e7-adda-26b1ae3f5758" />





## 效果演示
https://github.com/user-attachments/assets/bf354283-1af0-4a35-a30d-cdf1642beb6d


