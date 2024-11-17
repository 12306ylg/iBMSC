（自用）

[English](../readme.md) | 简体中文

-----

# µBMSC

µBMSC是iBMSC的一个修改版，用于添加功能、清理iBMSC代码、修复错误等。
请查看README.md.old以获取原始iBMSC的README文件。

# 改动

* 预设OGG预览
  * 如果OGG不存在，则寻找WAV文件，反之亦然
* 修复错误
  * 修复了BMSE剪贴板输入问题
* 新增功能
  * 地雷（？）支持（Shift + Ctrl + 点击）
  * 多种新编码（EUC-KR, Shift-JIS）
  * 跳转到节拍器（Ctrl+G）
  * 鼠标行/列高亮
  * 使用Ctrl+滚轮改变缩放级别
  * 支持更大的BPM（10e12）
  * 用户界面改进
  - **更多的自定义UI选项**
  * **时间选择模式** 将区域转换为停止
  * **选择模式** 在屏幕上选择带有标签的音符，选择所有带有标签的音符（Shift+Ctrl+点击，Shift+Ctrl+A）
  * 不依赖本地的数字输出（不再使用逗号代替句号）
  * **写入模式** 自动增加Autowav功能
  * **dtinth** 移动和取消选择（Shift+数字）
  * **NS-Kazuki** #SCROLL支持
* 开发
  * 为开发者重新组织代码库
- 平台
  - 升级.NET版本至9