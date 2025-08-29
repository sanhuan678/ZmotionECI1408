
基于C#与正运动ECI1408的四轴运动控制平台软件开发项目。

## 项目概述

本项目是一个Windows上位机软件，通过正运动ECI1408四轴EtherCAT总线控制卡实现对步进电机的精确控制。软件采用WinForm作为前端开发框架，利用正运动技术提供的ZMC API动态链接库进行二次开发，实现了上位机与控制卡之间基于以太网通信的完整解决方案。

## 系统功能

- **设备连接**：通过扫描IP地址与ECI1408轴卡建立稳定连接
- **轴配置**：支持X、Y、Z三轴独立配置与管理
- **参数设置**：全面的运动参数配置，包括：
  - 起始速度
  - 运行速度
  - 加速度
  - 减速度
  - S曲线参数
  - 脉冲当量


- **运动控制**：
  - 点动控制(ZAux_Direct_SingleJog)：支持正、负方向点动操作
  - 寸动控制(ZAux_Direct_SetMovePos + ZAux_Direct_SingleMove)：支持相对运动与绝对运动两种模式，可设置正负方向及移动距离
  - 回零操作(ZAux_Direct_Home)：使各轴返回初始位置
<img width="1170" height="669" alt="image" src="https://github.com/user-attachments/assets/76013569-cf6e-4054-8ecf-6b9c5a8a6d57" />
<img width="400" height="468" alt="image" src="https://github.com/user-attachments/assets/d9daa1de-d74c-4dd8-b932-6b694d7c7a9d" />

<img width="646" height="527" alt="image" src="https://github.com/user-attachments/assets/4a8a9bd2-c01a-4a34-a614-babdfccc5134" />
## 技术架构

- **开发平台**：Windows Form (.NET Framework/C#)
- **控制卡**：正运动ECI1408四轴EtherCAT总线控制卡
- **通信方式**：以太网通信
- **API**：正运动ZMC API动态链接库

## 开发环境

- Visual Studio 2017或更高版本
- .NET Framework 4.5或更高版本
- 正运动技术ZMC API开发包

## 安装与使用

1. 克隆或下载本项目到本地
2. 使用Visual Studio打开解决方案文件
3. 添加正运动技术提供的ZMC API引用
4. 编译并运行项目
5. 确保ECI1408控制卡与PC处于同一网络
6. 扫描并连接控制卡，配置各轴参数后即可进行运动控制



## API使用示例

```csharp
// 点动控制示例
ZAux_Direct_SingleJog(handle, axis, speed);

// 寸动控制示例
ZAux_Direct_SetMovePos(handle, axis, distance);
ZAux_Direct_SingleMove(handle, axis, mode);

// 回零操作示例
ZAux_Direct_Home(handle, axis);
```


## 许可证

本项目仅用于学习和研究目的，请遵守正运动技术相关API的使用条款。

## 支持与联系

如有问题或建议，请通过GitHub Issues提交反馈。

---
