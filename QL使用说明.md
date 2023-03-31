# QuickLocalization使用详解

+ 本文档为正义之怒MOD外挂汉化工具Quick Localization的使用说明
+ 文档前半部分为使用方式，普通玩家只需要阅读此部分
+ 文档后半部分为运行机制和文件格式，如果有兴趣自行汉化、修改汉化、帮助排错等，可以阅读。

## 目录

- [QuickLocalization使用](#QuickLocalization使用)
  - [我为什么要使用QL](#我为什么要使用QL)
  - [QL使用指南](#QL使用指南)
- [进阶：QL运行机制和文件格式](#进阶：QL运行机制和文件格式)
  - [标准语言文件格式](#标准语言文件格式)
  - [官方接口MOD格式](#官方接口MOD格式)
  - [无语言文件的MOD](#无语言文件的MOD)
  - [使用TTT语言接口的MOD](#使用TTT语言接口的MOD)


## QuickLocalization使用
+ Quick Localization是由 @magicskysword 制作的一个“外挂式”汉化工具，用于在其他MOD载入后，再外挂载入语言文件
+ 在[这里](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/releases)可以找到最新QuickLocalization下载
### 我为什么要使用QL
+ 使用外挂载入的方式，对于**没有语言文件的MOD**也能实现**不需要修改原MOD**即可汉化
+ 汉化文件**不受MOD更新影响**，尤其适合解决使用TTT语言接口的MOD的“**屎山问题**”
+ 各个MOD的汉化文件可以集中在一起，方便管理
+ 可以**不需要重启游戏**就动态重载文本，帮助快速修正汉化错误和确认汉化效果
### QL使用指南
+ **UMM安装**后，找到游戏文件夹下\Mods\QuickLocalization
+ 新建一个**Localization**文件夹和一个**TTTLocalization**文件夹（一般会自动创建，最好确认一下），然后放入汉化文件。
+ 具体汉化文件放入哪个文件夹和MOD本身本地化格式有关。请注意汉化文件的说明。
+ 本文档分享的[汉化文件](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/tree/main/QuickLocalization%E7%94%A8%E6%B1%89%E5%8C%96%E6%96%87%E6%9C%AC)都已经放好了对应文件夹，打包下载即可，请勿改变文件结构。

## 进阶：QL运行机制和文件格式
+ QL会自动加载**Localization**和**TTTLocalization**两个文件夹下所有后缀为**JSON**的文件，文件名不会影响加载。
+ 你可以自行改变子文件夹或者文件名来方便自己管理。
+ 特别注意，语言文件的**编码格式**需要为**UTF-8无签名**，否则游戏中会乱码。
+ 下面是想要自制汉化文件和修改汉化文件的说明。你可能会需要以下工具：
   + 加强型文本编辑器，比如**EmEditor**
   + JSON语法检查工具，比如**VScode**或者[在线校验](https://www.sojson.com/)
   + MOD反编译工具，比如[**dnSpy**](https://github.com/dnSpy/dnSpy)
### 标准语言文件格式
### 官方接口MOD格式
### 无语言文件的MOD
### 使用TTT语言接口的MOD
