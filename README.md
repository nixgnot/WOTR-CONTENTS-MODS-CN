# 【正义之怒】内容扩展型MOD收集计划
-------------------------------------------

+ 本文档用于收集整理为开拓者正义之怒提供内容扩充（新增或者修改职业、变体、专长、法术等游戏内容）的MOD，并尽量保持时效性。
+ ToyBox、Bubble Buffs等功能性MOD不在本文档介绍范围，但是文末会给出常用MOD链接。
+ 特别注意，本文档作者的游戏理解还是新手，很可能评价并不贴切。
+ 强烈建议先行阅读[正义之怒MOD教程](https://github.com/1onepower/KM-WotR_Modding_Wiki/blob/main/%E4%B8%AD%E6%96%87%E7%89%88.md) （1onepower）。该文档含有详细的**UMM安装教程**和部分MOD介绍，但文档时间较早，部分MOD可能已经失效。

**欢迎加入正义之怒MOD专门讨论群 755831390**

**特别提示！！不确定是否因为Github更新，直接在主页上访问此文档可能会出现页面内跳转无效**    
**为了方便阅览，建议点击上面的文件列表中的README.MD，以文档形式浏览，避免此问题**
    

## 目录

- [基础知识](#基础知识)
  - [UMM的安装](#UMM的安装)
  - [MOD须知](#MOD须知)
  - [ModFinder工具](#ModFinder工具)
  - [GITHUB访问和MOD下载](#GITHUB访问和MOD下载)
  - [Nexus访问和MOD下载](#Nexus访问和MOD下载)
  - [本文档使用说明](#本文档使用说明)
  - [前置MOD](#前置MOD)
  - [汉化文件及其他说明](#汉化文件及其他说明)
  - [MOD外挂汉化工具QuickLocalization](#MOD外挂汉化工具QuickLocalization)
- [MOD列表](#MOD列表)
  - [附录：功能MOD索引](#功能MOD索引)
  - [附录：打包MOD网盘分流](#打包MOD网盘分流) 

|  MOD   |  内容简介 |  中文  |  UMM   |  个人推荐  |  内容量  |  修改  |  最新版状况 |
|  ----  | ----  | ----  | ----  | ----  | ----  | ----  | ----  |
| [TabletopTweaks-Base](#TabletopTweaks-Base)  | TTT | 自带 | :heavy_check_mark:  | :+1::+1::+1: | :file_folder::file_folder::file_folder: | 🛠️🛠️ ||
| [TabletopTweaks-Reworks](#TabletopTweaks-Reworks)  | TTT神话扩展 | 自带 | :heavy_check_mark:  | :+1::+1: | :file_folder::file_folder: | 🛠️🛠️ ||
| [TabletopTweaks-Flanking](#TabletopTweaks-Flanking)   | TTT夹击扩展 |   | :heavy_check_mark:  | :+1::+1: | :file_folder: | 🛠️🛠️ ||
| [WrathMods-MultipleArchetypes](#WrathMods-MultipleArchetypes)   | 多重变体 |   | :heavy_check_mark:  | :+1::+1::+1: | :file_folder: | 🛠️ ||
| [MicroscopicContentExpansion](#MicroscopicContentExpansion)|MCE内容扩展| QL汉化 | :heavy_check_mark: | :+1::+1: | :file_folder::file_folder: |||
| [SparsSorcerousSundries](#SparsSorcerousSundries) | 物品扩展 | QL汉化 | :heavy_check_mark: | :+1::+1: | :file_folder::file_folder: |||
| [TomeOfTheFirebird](#TomeOfTheFirebird) | TOTF扩展 | QL汉化 | :heavy_check_mark: | :+1::+1::+1: | :file_folder::file_folder::file_folder: |||
| [HomebrewArchetypes](#HomebrewArchetypes) | 房规变体 | 自带 | :x: | :+1::+1::+1: | :file_folder::file_folder::file_folder: |||
| [ExpandedContent2022](#ExpandedContent2022)  | 内容扩展2022 | 汉化 | :heavy_check_mark: | :+1::+1: | :file_folder::file_folder::file_folder: |||
| [ToggleableThrowingWeapons](#ToggleableThrowingWeapons) | 切换投掷 | QL汉化 | :heavy_check_mark: | :+1::+1::+1: | :file_folder: |||
| [MorvarchsPlaystyleExpansions](#MorvarchsPlaystyleExpansions)  | MPE扩展 |  | :heavy_check_mark: | :+1::+1::+1: | :file_folder:|||
| [PhoenixsCantrips](#PhoenixsCantrips) | 戏法强化 | 汉化 | :heavy_check_mark: | :+1: | :file_folder: | 🛠️ ||
| [MoreCantrips](#MoreCantrips) | 更多戏法   | 汉化 | :heavy_check_mark: | :+1: | :file_folder: | 🛠️ ||
| [CharacterOptionsPlus](#CharacterOptionsPlus) | CO+扩展 | 自带 | :heavy_check_mark: | :+1::+1::+1: | :file_folder::file_folder::file_folder: |||
| [DarkCodex](#DarkCodex) | DC扩展修复 | 自带 | :heavy_check_mark: | :v::heart_eyes::v: |  :file_folder::file_folder::file_folder: |🛠️🛠️ ||
| [AddedFeats](#AddedFeats) | 新增专长 | QL汉化 | :heavy_check_mark: |  :+1::+1: |  :file_folder::file_folder: |||
| [BetterBackgrounds](#BetterBackgrounds) | 更多背景 | QL汉化| :x: |:+1::+1: | :file_folder: | 🛠️ ||
| [MartialExcellence](#MartialExcellence) | 杰出武艺 | 自带 |:heavy_check_mark: | :+1::+1: | :file_folder::file_folder: |||
| [MediumClass](#MediumClass)| 通灵者职业 |  | :heavy_check_mark: |  | :file_folder: ||:steam_locomotive:|
| [MysticalMayhem](#MysticalMayhem) | 神秘骚乱 | 自带 | :heavy_check_mark: | :v::heart_eyes::v: | :file_folder::file_folder: |||
| [MythicArcanist](#MythicArcanist) | 神话秘术 | 自带 | :heavy_check_mark: | :+1::+1: | :file_folder::file_folder: |||
| [ChampionFeatsAnew](#ChampionFeatsAnew) | 冠军专长 |   | :heavy_check_mark: |  | :file_folder::file_folder: ||:steam_locomotive:|
| [KineticistElementsExpanded](#KineticistElementsExpanded) | 操念元素扩展 | 汉化 | :heavy_check_mark: | :+1: | :file_folder::file_folder: |||
| [Madison'sMetagaming](#sMetagaming) | Madison扩展 | |:heavy_check_mark: |  | :file_folder: |||
| [NinjaClass](#NinjaClass) | 忍者职业 | 汉化 | :x: | :+1: | :file_folder: |||
| [BrawlerClass](#BrawlerClass) | 拳师职业 |QL汉化 | :heavy_check_mark: | :+1: | :file_folder::file_folder: |||
| [WOTR_PATH_OF_BLING](#WOTR_PATH_OF_BLING) | 金龙重做  | QL汉化 |:heavy_check_mark: | |:file_folder: |🛠️||
| [WOTR_PATH_OF_HELL](#WOTR_PATH_OF_HELL)  | 魔鬼重做 | QL汉化 |:heavy_check_mark: | |:file_folder: |🛠️||
| [WOTR_PATH_OF_RAGE](#WOTR_PATH_OF_RAGE) | 恶魔重做 | QL汉化 |:heavy_check_mark: | :+1::+1: |:file_folder::file_folder: |🛠️||
| [WorldCrawl](#WorldCrawl) | 大型重置 | |:heavy_check_mark: | |:file_folder::file_folder::file_folder:|🛠️🛠️🛠️||
| [AlternateHumanTraits](#AlternateHumanTraits)|人类替换特性|QL汉化| :heavy_check_mark: | :+1: | :file_folder: |||
| [WOTR_IsekaiMod](#WOTR_IsekaiMod) | 异世界主角| |:heavy_check_mark: | :+1: | :file_folder: |||
| [Way-of-the-shield](#Way-of-the-shield) | 盾牌之道 |自带 |:heavy_check_mark: | :+1: | :file_folder::file_folder: |🛠️|:steam_locomotive:|
| [CyniikalBrokenFeatures](#CyniikalBrokenFeatures) | 法师虚学派 |QL汉化| :heavy_check_mark: | :+1: | :file_folder::file_folder: |||
| [重装魔战](#重装魔战) | 重装魔战 | 自带 | :heavy_check_mark: | :+1: | :file_folder: |||
| [CompanionAscension](#CompanionAscension) | 同伴提升 |  | :heavy_check_mark: | :+1: | :file_folder: ||:steam_locomotive:|
| [SwashbucklerWOTR](#SwashbucklerWOTR) | 游荡剑客 | QL汉化 | :heavy_check_mark: | :+1::+1::+1: | :file_folder: |||
| [SmolCraft](#SmolCraft) | SmolCraft | QL汉化 | :heavy_check_mark: | :+1: | :file_folder: |||
| [EnduringRework](#EnduringRework) | 持久重置 | QL汉化 | :heavy_check_mark: | :+1: | :file_folder: |🛠️||
| [CraftMaster](#CraftMaster) | 造物MOD | 自带 | :heavy_check_mark: | :+1::+1: | :file_folder::file_folder: |||
| [Psionics](#Psionics) | 灵能MOD | QL汉化 | :heavy_check_mark: | :+1::+1: | :file_folder::file_folder: |||
| [KineticArchetypes](#KineticArchetypes) | 念力变体 | 自带 | :heavy_check_mark: | :v::heart_eyes::v: | :file_folder::file_folder: |||
| [MinosPlayerRace](#MinosPlayerRace) | 牛头人种族 | QL汉化 | :heavy_check_mark: | :+1: | :file_folder: |||
| [WoTRHolyVindicator](#WoTRHolyVindicator) | 神圣辩护者 | 暂无 | :heavy_check_mark: | :+1::+1: | :file_folder: |||
| [PrestigePlus](#PrestigePlus) | 进阶职业扩展 | 自带 | :heavy_check_mark: | :v::heart_eyes::v: | :file_folder::file_folder::file_folder: |||
| [TransfiguredCasterArchetypes](#TransfiguredCasterArchetypes) | 施法者变体 | 暂无 | :heavy_check_mark: | :+1::+1: | :file_folder: |||
| [HomebrewWarlock](#HomebrewWarlock) | 3.5e邪术师 | QL汉化 | :heavy_check_mark: | :+1::+1: | :file_folder: |||
| [AutomaticBonusProgression](#AutomaticBonusProgression) | 自动增长加值 | QL汉化 | :heavy_check_mark: | :+1::+1: | :file_folder: |||
| [WOTR_MAKING_FRIENDS](#WOTR_MAKING_FRIENDS) | 召唤师 | QL汉化 | :heavy_check_mark: | :+1: | :file_folder: |🛠️||
| [PathofWar](#PathofWar) | 战争之路 | ql汉化 | :heavy_check_mark: | :+1: | :file_folder: |🛠️||
| [RandomEquipment](#RandomEquipment) | 随机装备 | 暂无 | :heavy_check_mark: | :+1::+1: | :file_folder: |🛠️||
| [MythicSpellFlexibility](#MythicSpellFlexibility) | 灵活神话法术 |  | :heavy_check_mark: | :+1:| :file_folder: |🛠️||
| [SpellSlotFreedom](#SpellSlotFreedom) | 灵活法术位 |  | :heavy_check_mark: | :+1:| :file_folder: |🛠️||
| [MagicArmory](#MagicArmory) | 魔法军械库 | QL汉化 | :heavy_check_mark: | :+1:| :file_folder: |||
| [LevelableAivu](#LevelableAivu) | 自定义爱乌 | 暂无 | :heavy_check_mark: | :+1::+1:| :file_folder: |🛠️|:steam_locomotive:|
| [Mythic-Magic-Mayhem](#Mythic-Magic-Mayhem) | 神话法术重制 | 暂无 | :heavy_check_mark: | :+1::+1::+1:| :file_folder::file_folder: |🛠️🛠️||
| [OnePear](#OnePearl) | 珍珠合一 | 暂无 | :heavy_check_mark: | :+1::+1::+1:| :file_folder: |🛠️🛠️||
| [deceiverbuff](#deceiverbuff) | 魔法诈欺师加强 | 暂无 | :heavy_check_mark: | :+1::+1::+1:| :file_folder: |🛠️🛠️||
| [FinessableSabers](#FinessableSabers) | FinessableSabers | QL汉化 | :heavy_check_mark: | :+1:| :file_folder: |🛠️||
| [HombrewFighterMagus](#HombrewFighterMagus) | 原创魔战 | QL汉化 | :x: | :+1:| :file_folder: |🛠️||

备注
+ UMM一栏为是否使用UMM安装
+ 🛠️ 表示对游戏原本内容有大幅度修改，需要注意自行开关选项<br>
+ :steam_locomotive: 表示暂未更新到最新版本(DLC6)，或运行有已知问题


------------------------------------------- 

## 基础知识

### UMM的安装
+ UMM是**Unity Mod Manager**的简称，用于很多Unity游戏的MOD管理。对正义之怒UMM基本属于必需的前置MOD管理工具。你需要先安装UMM来启用MOD，并可对MOD进行统一管理。
+ 大部分MOD都通过UMM来进行安装和管理。少部分例外我会特别提示。
+ 关于UMM的安装，[上面链接](https://github.com/1onepower/KM-WotR_Modding_Wiki/blob/main/%E4%B8%AD%E6%96%87%E7%89%88.md) 已经有非常详细的阐述，在此不再赘述。

### MOD须知
+ 特别注意。目前绝大多数内容扩充MOD都可以随时在游戏中途新增并**正常添加内容**。
+ 但是绝对不要在游戏**中途移除内容扩充MOD**，通常这都会由于新增特性的丢失导致**存档无法载入**。如果遇到这种情况，**通常加回MOD可以解决**。
+ 绝大多数内容扩充MOD会提供**MOD选项**，可以用于单独开启或者关闭某一项特性。通常这个选项在UMM中，如果前置有**ModMenu**，则在游戏选项中的MOD页面。
+ 一般来说，修改性质的选项（比如TTT对专长的相关修改），都可以随时开关（但都需要**重启游戏才能生效**）。但是新增内容（比如增加专长）一旦已经有人物使用后关闭，很可能同样导致**存档无法载入**。**一般重新启用选项可以解决**。

### ModFinder工具
+ ModFinder是一个非必需的第三方工具，可以便捷的管理正义之怒MOD，检查MOD更新情况（包括在Github和Nexus更新的MOD），快速下载和安装（可以替代部分UMM功能）
+ 非UMM安装的MOD也可以使用ModFinder快速安装，强烈推荐
+ ModFinder可以在[这里](https://github.com/Pathfinder-WOTR-Modding-Community/ModFinder)下载。
+ [汉化分支地址](https://github.com/magicskysword/ModFinder_CN)
+ ModFinder为绿色工具，可以在任何路径打开（但是最好不要用中文路径），会自动识别正义之怒的安装位置。
+ ModFinder在启动时可能会出现弹框错误，发生此种情况多半是Github访问失败的导致的，请参照下一节解决。

### GITHUB访问和MOD下载
+ 在国内很多网络环境，Github访问都存在一定抽风现象，会出现时不时打开失败。通常刷新就可以解决。如果实在问题严重，[Watt Toolkit](https://steampp.net/)可以帮到你。
+ 给予完全萌新的提示：大部分MOD发布页中，直接点击右侧[Release页面](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/releases)按钮即打开下载页面，Assets中第一项即为MOD。下载后不需要解压缩，直接使用UMM或者ModFinder安装。

### Nexus访问和MOD下载
+ Nexus的MOD在标题右方的Manual按钮即可直接下载。如果有额外文件会在FILES标签中。
+ Nexus目前需要注册用户才能下载。

### 本文档使用说明
+ **汉化文件下载**
> 直接点击上方**Code**按钮，然后选择**Download Zip**即可打包下载全部汉化文件<br>
> 如果需要单独汉化文件，可以点击对应文件后选择右上方的Download raw file图标<br>
> 汉化文件的使用请参考下方
+ **辅助工具下载**
> 在[Release页面](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/releases)中，可以下载**MOD外挂汉化工具QuickLocalization**、**Pathfinder中文文档**<br>
> 注意不要下载Source code，为空文件
+ **临时MOD下载**
> 在[Release页面](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/releases)，可以临时下载**一部分没有主页发布的2.10MOD**<br>
> 注意不要下载Source code，为空文件

### 前置MOD
目前正义之怒所需主要前置MOD有两个：
1. [TabletopTweaks-Core](https://github.com/Vek17/TabletopTweaks-Core)（**核心必备**，绝大部分MOD的基础框架，本身不会进行任何改动。）
2. [ModMenu](https://github.com/WittleWolfie/ModMenu)（**非必备**，一部分MOD使用的基础框架。会在游戏中选项里添加一个新的页面来进行MOD功能调整。）

### 汉化文件及其他说明
+ 本文档上方会收集一些个人提供的**MOD汉化或汉化修正文件**，不定时更新。
+ 可以点击上方**code**按钮中的**Download Zip**打包下载所有附件。
+ 一般**UMM安装**的MOD，汉化文件的使用方法是直接替换游戏目录下\mods\对应mod名称\Localization\中同名文件即可。
+ 对于**非UMM安装**的MOD，替换C:\Users\你的用户文件夹\AppData\LocalLow\Owlcat Games\Pathfinder Wrath Of The Righteous\Modifications\对应mod名称\Localization\中同名文件。
+ 列表中标明**QL汉化**的MOD为**QuickLocalization用汉化**，请参考QuickLocalization说明
+ 大部分MOD是对原规则的还原，对于较为复杂的职业、专长详情会标明<i>参阅PF文档</i>，可在上述Pathfinder v2.02简体文档中查看，但实际MOD中并不一定完全效果相同。

-------------------------------------------
### MOD外挂汉化工具QuickLocalization
+ 本工具是一个“外挂式”汉化工具，用于在其他MOD载入后，再外挂载入语言文件，实现不需要修改原MOD就能实现外挂汉化
+ 只要原MOD更新后没有修改语言文件，汉化也不会受到更新影响
+ 且本工具可以实现在游戏启动中动态重载文本，来帮助进行所见即所得的汉化或修改汉化文件错误
+ 在[Release页面](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/releases)可以找到最新QuickLocalization下载
+ 在[这里](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/blob/main/QL%E4%BD%BF%E7%94%A8%E8%AF%B4%E6%98%8E.md)可以阅读QuickLocalization的详细使用说明

> 本MOD由@magicskysword制作，适用版本为WOTR 2.1<br>
> 该版本为临时版本，不保证完善。但该MOD不涉及任何存档操作，不会对游戏本身造成任何影响。

+ UMM安装后，找到游戏文件夹下\Mods\QuickLocalization
+ 新建一个**Localization**文件夹和一个**TTTLocalization**文件夹，然后放入汉化文件。
+ 具体放入哪个文件夹和MOD本身本地化格式有关，此处我分享的文件已经分别放好了位置，请注意不要放错文件夹。
+ 建议直接使用**code**按钮中的**Download Zip**打包下载所有附件。如果你没有安装汉化文件对应的MOD，不会影响实际运行但是QL会出现警告。觉得碍眼可以手动删除多余的汉化文件。
+ 外挂汉化文件需为JSON格式，文件名不限（建议建立子文件夹并妥善命名，方便管理）

目前已经完成的汉化：
+ **Brawler(拳师) MOD 2.10用版本**
+ **AlternateHumanTraits（人类替换特性）**
+ **CyniikalBrokenFeatures（法师虚学派，在release中有）**
+ **ToggleableThrowingWeapons（可切换投掷武器）**
+ **AddedFeats**
+ **SparsSorcerousSundries**
+ **TomeOfTheFirebird**
+ **MicroscopicContentExpansion**
+ **CharacterOptionsPlus(临时补充)** CharacterOptionsPlus汉化已经提交给官方但是有遗漏，此处提供临时补充汉化


本文档会不定期更新补充一些汉化

-------------------------------------------
## MOD列表
**若无特别说明，则MOD在2.1.0版本测试通过**
-------------------------------------------
### [TabletopTweaks-Base](https://github.com/Vek17/TabletopTweaks-Base)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **自带中文**<br>
> *安装方式：* UMM<br>
> *修改内容：* UI、核心规则、法术、专长、职业特性、神话能力、神话专长，等<br>
> *新增内容：* 变体、巅峰、法术、专长、种族、背景，等<br>
+ 简称**TTT**，提到正义之怒MOD就必定会提到TTT，基本上也是大部分人第一个玩的内容型MOD。
+ 新增了海量的游戏内容，让游戏完全变了个样的同时，也提供了很多新的选项。
+ 例如新增的巅峰系统给很多纯职都提供了福利
+ 特别需要注意的是，TTT对原版做出了大量修改和修复，尤其是**良性BUG**方面。
+ 如果你习惯了原版体系和构建，可能用了TTT会有极大怨言。好在这些修复都是可以关闭的<br>
+ 友情提示，但是由于新增了大量内容，关闭这些修复很容易导致过于滥强<br>
+ TTT的更新过于庞杂海量，建议有一定英文基础和游戏基础再玩（虽然内容已经汉化但是选项菜单无法汉化，此处提供选项对照）

<table>  
<tr><th colspan="5">修改列表</th></tr> 
<tr><td>分类</td><td>Config中选项</td><td>默认</td><td>房规</td><td>效果</td></tr>
<tr><td rowspan="37">基本修复<br>Base</td>
   <td>AreaOfEffectDoubleTrigger
        </td><td>:x:
        </td><td>:x:
        </td><td>修复AOE法术释放时额外触发一次</td></tr>
     <tr><td>BuffInspector
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>BUFF指示器现在更好的显示实际生效的BUFF</td></tr>
      <tr><td>CoupDeGrace
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>致命一击DC现在基于伤害</td></tr>
      <tr><td>DamageReductionRework
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>防止DR叠加，除非特别声明</td></tr>
      <tr><td>DamageVulnerability
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>易伤对多类型伤害正确生效</td></tr>
      <tr><td>DiceReplacementUI
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修改掷骰点数显示</td></tr>
      <tr><td>DisableAfterCombatDeactivationOfUnlimitedAbilities
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>允许无限使用能力战斗后保持激活</td></tr>
      <tr><td>DisableCannyDefenseStacking
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>防止剑圣和决斗家AC奖励叠加</td></tr>
      <tr><td>DisableNaturalArmorStacking
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>天生防御加值不再叠加，除非特别说明。“天生防御加值”和“天生防御加值增强”依然正确叠加</td></tr>
      <tr><td>DisablePolymorphSizeStacking
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>激活变形法术会正确压制非变形法术的尺寸变化效果</td></tr>
      <tr><td>DisablePolymorphStacking
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>防止多个变形效果叠加</td></tr>
      <tr><td>DisableSizeStacking
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>防止多个尺寸变化效果叠加，后获得的效果只会被压制不生效，并不会被移除</td></tr>
      <tr><td>DisplaySpellbookInTooltips
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修改法术界面显示其法术书来源</td></tr>
      <tr><td>DynamicItemNaming
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>为装备名称添加上附魔词缀</td></tr>
      <tr><td>DynamicItemNamingTemporary
        </td><td>:x:
        </td><td>:x:
        </td><td>词缀包括临时附魔</td></tr>
      <tr><td>FeatSelections
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td><s>改正奖励专长选择，比如战士的额外专长，来允许选择所有指定类型专长</s>原版已修复</td></tr>
      <tr><td>FixBackgroundModifiers
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>背景给予的技能和攻击加值改为特性加值</td></tr>
      <tr><td>FixBuffCasterOnSaveLoad
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>读取存档时BUFF施法者能够被正确记录 </td></tr>
      <tr><td>FixConcealment
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修复隐形的隐蔽效果</td></tr>
      <tr><td>FixCriticalConfirmation
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>允许天然20自动确认重击</td></tr>
      <tr><td>FixInherentBonuses
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>永久属性奖励能够作为专长前置</td></tr>
      <tr><td>FixInherentSkillpoints
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>永久智力奖励能够准确获取技能点</td></tr>
      <tr><td>FixMountedLongspearModifer
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>长矛在骑乘冲锋时获得额外伤害</td></tr>
      <tr><td>FixMonkAcBonusNames
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修复武僧的AC奖励显示</td></tr>
      <tr><td>FixPrebuffCasterLevels
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修正敌人自带BUFF的CL</td></tr>
      <tr><td>FixProgressionDisplay
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>进程不再显示你不会获得的特性</td></tr>
      <tr><td>FixShadowSpells
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修复阴影模拟系列法术，使其正确从幻象学派获益</td></tr>
      <tr><td>FixSizeShiftLimits
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修正从Fine到Colossal的尺寸比例</td></tr>
      <tr><td>FixWeaponEnhancmentBonusModifiers
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>武器增强加值和非武器增强价值现在从逻辑上区分开</td></tr>
      <tr><td>MetamagicStacking
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>防止强效超魔的额外骰子受到极效作用</td></tr>
      <tr><td>MetamagicBolsterDoubleDiping
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>防止法术增效超魔多次应用于同一法术</td></tr>
      <tr><td>MountedActions
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>骑乘移动后不能再进行整轮动作</td></tr>
      <tr><td>NauseatedDescriptors
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>移除反胃的中毒描述</td></tr>
      <tr><td>SpellImmunity
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>忽略法术抗力不再无视法术免疫</td></tr>
      <tr><td>SelectiveMetamagicNonInstantaneous
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修复持续时间不是立即的法术也能应用甄选附魔的问题</td></tr>
      <tr><td>StaggeredDescriptors
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>移除恍惚的移动受限描述</td></tr>
      <tr><td>SuppressedBuffUI
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>改变被抑制的BUFF的渲染方式</td></tr>
 <tr><td rowspan="3">御衡道途</td>
          <td>AeonDemythication
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>神话抑制能够正确抑制神话效果了</td></tr>
      <tr><td>AeonTenthLevelImmunities
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修复御衡者免疫效果</td></tr>
      <tr><td>PowerOfLaw
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>逼迫凝视（秩序之力）对于重投类效果正确生效了</td></tr>
  <tr><td>恶魔道途</td>
      <td>BrimorakAspect
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>爆燃魔相对所有法术都能正确生效了</td></tr>
  <tr><td rowspan="2">巫妖道途</td>
      <td>DeathRush
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>死亡冲击不再产生多次伪攻击并触发武器效果</td></tr>
      <tr><td>SpellbookMerging
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>允许自然魔法师巫妖合书</td></tr>
  <tr><td>诡计道途</td>
      <td>UseMagicDevice2
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>神话诡计使用魔法装置2允许诡计大师忽略装备的阵营和职业需求</td></tr>
  <tr><td>巅峰</td>
      <td>AlternateCapstones</td><td colspan="3">允许单独开关各个职业巅峰，详见新增内容</td></tr>
  <tr><td rowspan="7">炼金术士<br>Alchemist</td>
      <td>Base - DispelingBombs
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>解法炸弹正确驱散单个BUFF而不是全部BUFF</td></tr>
	<tr><td>Base - MutagenStacking
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>防止诱变剂叠加</td></tr>
        <tr><td>Archetypes - Grenadier - BrewPotions
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>掷弹兵：移除变体调制药水能力</td></tr>
        <tr><td>Archetypes - Grenadier - PoisonResistance
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>掷弹兵：移除变体毒素抵抗能力</td></tr>
         <tr><td>Archetypes - IncenseSynthesizer - ImprovedIncense
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>调香师：修正强化熏香范围扩大后效果</td></tr>
          <tr><td>Archetypes - IncenseSynthesizer - ThickFog
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>调香师：将浓雾的隐蔽类型改为烟雾性质而不再是幻象性质</td></tr>
          <tr><td>Archetypes - IncenseSynthesizer - SacredIncense
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>调香师：修复崇圣熏香效果</td></tr>
  <tr><td rowspan="2">奥能师<br>Arcanist</td>
    <td>Base - reparedSpellUI
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>让奥能师的法术书UI更符合记忆施法者</td></tr>
    <tr><td>Base - EnableMultipleMemorization
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>允许奥能师记忆不同超魔的同个法术</td></tr>
  <tr><td rowspan="2">野蛮人<br>Barbarian</td>
        <td>Base - CripplingBlows
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>致残猛击允许狂暴中使用</td></tr>
        <tr><td>Base - WreckingBlows
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>毁灭猛击允许狂暴中使用</td></tr>
  <tr><td rowspan="10">血怒者<br>Bloodrager</td>
    <td>Base - AbysalBulk
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>深渊血脉巨化魔躯能力在狂暴结束时不再驱散已有的增大效果</td></tr>
        <tr><td>Base - ArcaneBloodrage
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>重做奥术血怒UI</td></tr>
        <tr><td>Base - CastersBane
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>允许奥术血怒巅峰 - 施法者克星</td></tr>
        <tr><td>Base - DisruptiveBloodrage
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>允许奥术血怒 - 扰法血怒</td></tr>
        <tr><td>Base - Spellbook
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>修复法术进程防止某些以施法为前提的早期特性不生效</td></tr>
        <tr><td>Base - TemporaryHitPoints
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>修复临时生命值计算</td>
        <tr><td>Archetypes - Primalist - FixBrokenRagePowers
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>原怒者：允许血怒下使用所有狂暴之力</td></tr>
        <tr><td>Archetypes - Primalist - RagePowerFeatQualifications
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>原怒者：防止允许学习额外狂暴特技专长</td></tr>
        <tr><td>Archetypes - ReformedFiend - DamageReduction
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>自新魔士：DR纠正为DR/善良.</td></tr>
        <tr><td>Archetypes - ReformedFiend - HatredAgainstEvil
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>自新魔士：修复憎恨邪恶奖励</td></tr>
  <tr><td rowspan="5">骑将<br>Cavalier</td>
    <td>Base - CavalierMobility
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>骑乘移动时忽略运动检定的护甲惩罚</td></tr>
        <tr><td>Base - CavalierMountSelection
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>小体型骑将允许选择狼坐骑</td></tr>
        <tr><td>Base - OrderOfTheStarCalling
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>修复星辰骑士团使命感效果</td></tr>
        <tr><td>Base - SupremeCharge
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>防止至高冲锋伤害重击，使用新的冲锋伤害系统</td></tr>
        <tr><td>Archetypes - Gendarme - TransfixingCharge
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>防止穿透冲锋伤害重击，使用新的冲锋伤害系统</td></tr>
  <tr><td>牧师<br>Cleric</td>
      <td>Base - GloryDomain
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td><s>修复荣耀领域魅力奖励</s>原版已修复</td></tr>
  <tr><td rowspan="6">战士<br>Fighter</td>
        <td>Base - AdvancedArmorTraining
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>允许战士选择高级护甲训练，替代护甲训练升级</td></tr>
        <tr><td>AdvancedWeaponTraining
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>修复武器训练先决条件</td></tr>
        <tr><td>TwoHandedWeaponTraining
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>修复双手武器战士训练没有被正确视为武器训练的问题</td></tr>
        <tr><td>UnarmedWeaponTraining
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>徒手攻击被正确算作近身武器组</td></tr>
        <tr><td>WeaponTrainingStacking
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>防止多个武器训练组叠加</td></tr>
        <tr><td>Archetypes - TwoHandedFighter - AdvancedWeaponTraining
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>双手武器战士：允许选择进阶武器训练专长</td></tr>
  <tr><td rowspan="1">猎人</td>
    <td>Archetypes - DivineHunter - OtherworldlyCompanion
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>神眷猎人：天界和魔界变体不再给予无限辟邪斩类能力</td></tr>
  <tr><td rowspan="5">魔战士<br>Magus</td>
    <td>Base - AddMissingArcaneWeaponEffects
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>添加缺少的奥法武器效果：焰爆、霜爆、电爆</td></tr>
        <tr><td>Base - SpellCombatAbilityVariants
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>使得法术战斗能够对带有进一步选项的法术（如：次元门）适用</td></tr>
        <tr><td>Base - SpellCombatDisableImmediatly
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>关闭法术战斗时当个回合立刻生效，不需要等待下个回合</td></tr>
        <tr><td>Base - SpellCombatSpellbookRestrictions
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>防止不在魔战士法术表上的法术适用于法术战斗</td></tr>
        <tr><td>Archetypes - SwordSaint - PerfectCritical
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>剑圣：完美重击花费2点奥法点数</td></tr>
  <tr><td rowspan="5">武僧<br>Monk</td>
        <td>Base - StunningFistVarriants
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>增加缺失的在12、16、20级获得的震慑拳选项</td></tr>
        <tr><td>Base - StunningFistDescriptors
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>修复震慑拳描述字段，避免免疫对应效果时生效</td></tr>
        <tr><td>Archetypes - ZenArcher - PerfectStrike
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>禅宗射手：10级时极意击改为投3个骰子</td></tr>
        <tr><td>Archetypes - ScaledFist - FixStunningStrike
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>鳞甲之拳：使得震慑拳使用普通版本</td></tr>
          <tr><td>DraconicFury
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>鳞甲之拳：龙裔怒火替换为Unchained版本 </td></tr>
  <tr><td rowspan="2">先知<br>Oracle</td>
        <td>Base - NaturesWhisperMonkStacking</td>
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>启示：自然低语不能再和鳞甲之拳的AC奖励叠加。拥有鳞甲之拳效果时会改回使用敏捷奖励</td></tr>
        <tr><td>Base - RevelationBurningMagic
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>启示：烈焰魔法机制改为桌面规则</td></tr>
  <tr><td rowspan="3">圣武士<br>Paladin</td>
        <td>Base - DivineMountTemplate</td>
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>修复圣骑士坐骑模板，给予应有特性</td></tr>
	 <tr><td>Base - DivineMountIntelligence
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>神圣坐骑现在至少拥有6点智力</td></tr>
        <tr><td>Base - SmiteAttackBonus
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>辟邪斩攻击加值不能再和类似能力（辟乱斩、正义烙印）等叠加</td></tr>
   <tr><td rowspan="2">游侠<br>Ranger</td>
        <td>Base - FavoredEnemy</td>
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>统一三种恶魔宿敌为异界生物，不能再选择单独种类恶魔（对于已经选择的不会删除，你依然可以继续选择防止出现兼容性问题）</td></tr>
    <tr><td>Archetypes - EspionageExpert - Trapfinding
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>谍报专家：寻找陷阱特性现在对察觉和巧手生效</td></tr>   
  <tr><td rowspan="7">游荡者<br>Rogue</td>
        <td>Base - DispellingAttack
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>修复职业特性解除正确CL，不会解除DEBUFF</td></tr>
        <tr><td>Base - RogueTalentSelection
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>游荡者天赋不能重复选择同一个（比如战斗专长）</td></tr>
        <tr><td>Base - SlipperyMind
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>心智灵活纠正为高级天赋</td></tr>
        <tr><td>Base - Trapfinding
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>寻找陷阱特性现在对察觉和巧手生效</td></tr>
        <tr><td>Archetypes - EldritchScoundrel - RogueTalentProgression
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>奥法暴徒：2级游荡者天赋移动到4级</td></tr>
         <tr><td>Archetypes - EldritchScoundrel - SneakAttackProgression
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>奥法暴徒：移除1级偷袭骰</td></tr>
         <tr><td>Archetypes - SylvanTrickster - FeyTricks
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>林妖诡术师：妖精诡术现包括所有游荡者天赋</td></tr>
  <tr><td>萨满<br>Shaman</td>
        <td>Base - AmelioratingHex
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>救难不再给予完全免疫能力，改为压制效果</td></tr>
  <tr><td rowspan="4">化形师<br>Shifter</td>
        <td>Archetypes - GriffonheartShifter
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>允许玩家创建人物使用鹫心变体</td></tr>
       <tr><td>Archetypes - WildEffigy - ArmorPlating
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>荒野塑像：修复多变体叠加时甲片护身问题</td></tr>
       <tr><td>Archetypes - WildEffigy - HeartOfEarth
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>荒野塑像：修复多变体叠加时大地之心问题</td></tr>
       <tr><td>Archetypes - WildEffigy - StoneclawStrike
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>荒野塑像：修复多变体叠加时石爪打击问题</td></tr>
  <tr><td rowspan="2">歌者<br>Skald</td>
    <td>Base - SpellKenning
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>允许法术认知特性</td></tr>      
    <tr><td>Archetypes - BattleScion - BattleProwessSelection
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>战歌贵胄：补充缺失的狂暴之力选项</td></tr>
  <tr><td>杀手<br>Slayer</td>
    <td>Base - Trapfinding
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>寻找陷阱特性现在对察觉和巧手生效</td></tr>
  <tr><td rowspan="3">术士<br>Sorcerer</td>
    <td>Base - DraconicBloodlineDescriptions
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>血承：修正奥术血承描述</td></tr>
        <tr><td>PatchElementalBloodlineDescriptions
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>修复升级UI上元素血承的错误</td></tr>
      <tr><td>Archetypes - Crossblooded - Drawbacks
            </td><td>:heavy_check_mark:
            </td><td>:x:
            </td><td>混血术士：补充混血术士应承受的-2意志豁免惩罚</td></tr>       
  <tr><td rowspan="6">战斗祭司<br>Warpriest</td>
        <td>Base - AirBlessing
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>空气主要祝福不再造成过多的伤害实例</td></tr>
        <tr><td>Base - EarthBlessing
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>大地次要祝福不再造成过多的伤害实例</td></tr>
        <tr><td>Base - FireBlessing
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>火焰次要祝福不再造成过多的伤害实例</td></tr>
        <tr><td>Base - LuckBlessing
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>幸运祝福提供正确主要能力</td></tr>
        <tr><td>Base - WaterBlessing
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>流水次要祝福不再造成过多的伤害实例</td></tr>
        <tr><td>Base - WeatherBlessing
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>天气次要祝福不再造成过多的伤害实例</td></tr>      
  <tr><td rowspan="3">巫师<br>Witch</td>
        <td>Base - AgilityPatron
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>机敏庇护主提供动物之型和变化形体</td></tr>
        <tr><td>Base - AmelioratingHex
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>救难不再给予完全免疫能力，改为压制效果</td></tr>
        <tr><td>Base - MajorAmelioratingHex
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>强效救难不再给予完全免疫能力，改为压制效果</td></tr>
  <tr><td>地狱骑士<br>Hellknight</td>
      <td>PentamicFaith
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>五誓：仅限神爪骑士团，不限信仰神祗</td></tr>
  <tr><td rowspan="4">博学士<br>Loremaster</td>
      <td>Prerequisites
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>将前置条件改为更符合桌面规则</td></tr>
      <tr><td>SpellProgression
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>1级获得施法能力升级（拿可知法术），这个改动不能回溯</td></tr>
      <tr><td>SpellSecrets
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>允许法术秘闻</td></tr>
      <tr><td>TricksterTricks
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>从秘闻战斗专长列表中移除诡计道途相关专长</td></tr>
  <tr><td rowspan="3">冬巫<br>WinterWitch</td>
      <td>ColdFlesh
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>：寒冰血肉：新特性，增加寒冷抗性</td></tr>
     <tr><td>UnearthlyCold
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>异界严寒：修复和超魔及伤害加值的互动</td></tr>
     <tr><td>UnnaturalCold
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>：超然酷寒：新特性，忽略目标一半寒冷抗性</td></tr>
  <tr><td rowspan="59">法术<br>Spells</td>
      <td>AbsoluteOrder
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>绝对指令：加入胁迫描述</td></tr>
      <tr><td>AbyssalStorm
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>深渊风暴：不再豁免减半，不会杀死施法者</td></tr>
      <tr><td>AcidMaw
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>酸液之啮：攻击时不再造成过多伤害实体</td></tr>
      <tr><td>AnimalGrowth
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>动物异变：对动物同伴正确生效</td></tr>
      <tr><td>BelieveInYourself
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>自信之心：修正奖励数值</td></tr>
      <tr><td>BestowCurseGreater
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>高等降咒：修复效果为高级版</td></tr>
      <tr><td>BreakEnchantment
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>破除魔咒：不再影响友军BUFF</td></tr>
      <tr><td>ChainLightning
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>链状闪电：伤害骰上限为 20 CL</td></tr>
      <tr><td>Command
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>命令术：修复缺失的描述，符合桌面规则</td></tr>
      <tr><td>CommandGreater
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>高等命令术：修复缺失的描述，符合桌面规则</td></tr>
      <tr><td>ConeOfCold
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>寒冰锥：加入巫师法术表</td></tr>
      <tr><td>CorruptMagic
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>腐化魔法：如同其他驱散，使用单个驱散掷骰</td></tr>
      <tr><td>CrusadersEdge
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>圣战之刃：只有重击才能触发反胃</td></tr>
      <tr><td>DeathWard
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>防死结界：压制已经存在的效果</td></tr>
      <tr><td>DispelMagicGreater
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>高等解除魔法：最多只会驱散 1/4 CL个BUFF</td></tr>
      <tr><td>EyeOfTheSun
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>烈阳之眼：修正伤害</td></tr>
     <tr><td>FieryBody
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>火焰之躯：不再是变形法术</td></tr>
      <tr><td>Firebrand
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>火焰烙印：攻击时不再造成过多伤害实例</td></tr>
      <tr><td>IcyBody
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>寒冰之躯：不再是变形法术</td></tr>
      <tr><td>IronBody
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>钢铁之躯：不再是变形法术</td></tr>
      <tr><td>SunMarked
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>太阳印记：攻击时不再造成过多伤害实例</td></tr>
      <tr><td>FieldOfFlowers
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>繁花原野：修复正确BUFF</td></tr>
      <tr><td>FixSpellFlags
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>将来自法术的BUFF正确标记，确保能被正确驱散</td></tr>
      <tr><td>FlameStrike
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>炽焰击：正确豁免减半</td></tr>
      <tr><td>FriendlyHug
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>友善之拥：修复免疫效果</td></tr>
      <tr><td>FrightfulAspect
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>可怖外表：正确应用恐惧</td></tr>
      <tr><td>Geniekind
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>巨灵化身：攻击时不再造成过多伤害实例</td></tr>
      <tr><td>GreaterMagicWeapon
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>高等魔化武器：不再和已有附魔叠加</td></tr>
      <tr><td>HellfireRay
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>地狱烈焰射线：不再有火焰描述，修复正确的半伤</td></tr>
      <tr><td>JoyOfLife
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>生命欢愉：正确转换神圣伤害</td></tr>
      <tr><td>LegendaryProportions
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>伟岸雄姿：只增加1级体型，符合桌面规则</td></tr>
      <tr><td>MagicalVestment
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>魔化防具：实际增强护甲而不是获取modifier.</td></tr>
      <tr><td>MicroscopicProportions
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>微缩雄姿：获得体型加值，不再是其他</td></tr>
      <tr><td>NaturesGrasp
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>自然桎梏：修正伤害</td></tr>
      <tr><td>OdeToMiraculousMagic
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>奇迹颂诗：正确按照CL决定持续时间</td></tr>
      <tr><td>PerfectForm
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>完美形态：不再能叠加多次获取多重奖励</td></tr>
      <tr><td>PowerFromDeath
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>死亡之力：修正持续时间为轮级</td></tr>
      <tr><td>ProtectionFromAlignmentGreater
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>秩序之盾和混沌护幕：不再错误的给予心智免疫效果</td></tr>
      <tr><td>ProtectionOfNature
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>自然庇护：掩蔽不再受到真视影响</td></tr>
      <tr><td>RemoveFear
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>移除恐惧：不再免疫颤栗和恐惧效果</td></tr>
      <tr><td>RemoveSickness
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>移除恶心：不再免疫不适和反胃效果</td></tr>
      <tr><td>RepulsiveNature
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>烦扰植被：使用正确的法术DC并修复应用DEBUFF</td></tr>
      <tr><td>ShadowConjuration
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>阴影咒法：加入法师法术表</td></tr>
      <tr><td>ShadowEvocation
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>阴影塑能：正确应用超魔</td></tr>
      <tr><td>ShadowEvocationGreater
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>高等阴影塑能：正确应用超魔，修复阴影真实度</td></tr>
      <tr><td>SongsOfSteel
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>钢铁之歌：修复奖励武器伤害</td></tr>
      <tr><td>Starlight
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>星光：不再受真视影响</td></tr>
      <tr><td>SuddenSquall
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>狂风突现：可选目标，拥有DEBUFF效果</td></tr>
      <tr><td>SunForm
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>太阳形态：修正伤害</td></tr>
      <tr><td>Supernova
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>超新星：修复致盲豁免，修正伤害</td></tr>
      <tr><td>UnbreakableBond
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>不破联结：正确应用免疫效果</td></tr>
      <tr><td>UnbreakableHeart
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>绝不动摇：不再完全免疫对应效果，改为压制</td></tr>
      <tr><td>WaterPush
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>水流击退：可选目标，修复伤害和推动距离</td></tr>
      <tr><td>WaterTorrent
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>洁净激流：可选目标，拥有DEBUFF效果</td></tr>
      <tr><td>WindsOfFall
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>秋风扫叶：可选目标，拥有DEBUFF效果</td></tr>
      <tr><td>WintersGrasp
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>凛冬之握：改为桌面规则效果，不再击倒</td></tr>
      <tr><td>WrackingRay
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>剧痛射线：修复伤害数值</td></tr>
      <tr><td>VampiricBlade
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>吸血鬼之刃：不再造成过多伤害实体.</td></tr>
      <tr><td>ZeroState
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>归零：使用单个骰子决定所有驱散效果</td></tr>
  <tr><td rowspan="5">其他特性<br>Features</td>
        <td>AnimalCompanions - AnimalCompanionProgression
        </td><td>:x:
        </td><td>:x:
        </td><td>修正动物同伴成长匹配桌面数据</td></tr>
     <tr><td>Bloodlines - BloodlineRestrictions
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修正血承限制正确和龙脉术士等互动</td></tr>
     <tr><td>Features - IncorporealCharm
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>虚化风姿：正确反映魅力的变化</td></tr>
      <tr><td>MongrolsBlessing
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>混种人的祝福：正确应用负向等级</td></tr>
      <tr><td>ProfaneAscension
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>亵渎晋升：优先用基础属性来计算最高属性</td></tr>
  <tr><td rowspan="34">专长<br>Feats</td>
      <td>AlliedSpellcaster
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>结盟施法者：不再全局生效（测试发现也不会多次叠加）</td></tr>
      <tr><td>ArcaneStrike
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>奥术打击：防止龙族奥术打击造成过多伤害实例</td></tr>
      <tr><td>BolsteredMetamagic
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>超魔 - 增效：可用于黏液之触</td></tr>
      <tr><td>BrewPotions
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>调制药水：不再被视为战斗专长</td></tr>
      <tr><td>Cleave
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>顺势斩：正确检查临接目标而不是任意触及目标，对终誓斩同理</td></tr>
      <tr><td>CraneWing
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>白鹤亮翅：需要空出一只手才有效</td></tr>
      <tr><td>DestructiveDispel
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>暴力解法：现在使用驱散的有效CL和最高精神属性来计算DC，公式为 10 + 1/2 CL + 最高精神属性</td></tr>
      <tr><td>DestructiveDispelPrerequisites
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>暴力解法：修改先决条件符合桌面规则</td></tr>
      <tr><td>DispelSynergy
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>解法余波：修改先决条件符合桌面规则</td></tr>
      <tr><td>EmpowerMetamagic
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>超魔 - 强效：可用于黏液之触</td></tr>
      <tr><td>Endurance
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>坚韧：如同同类专长在运动10级后获得额外加值</td></tr>
      <tr><td>EnergizedWildShapeDamage
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>赋能野性变身：不再造成独立伤害实例</td></tr>
      <tr><td>EnergizedWildShapePrerequisites
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>赋能野性变身前置：修复对于非德鲁伊但是拥有野性变身能力的职业的前置条件</td></tr>
      <tr><td>FencingGrace
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>优雅刺击：永远只对单手武器生效</td></tr>
      <tr><td>FrightfulShape
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>慑人变身：修复对于非德鲁伊但是拥有野性变身能力的职业的前置条件</td></tr>
      <tr><td>Lunge
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td><s>突刺专长</s>原版已有</td></tr>
      <tr><td>IndomitableMount
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>不屈坐骑：正确生效</td></tr>
      <tr><td>MagicalTail
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>魔性之尾：改变给予法术为狂笑和英雄气概</td></tr>
      <tr><td>MaximizeMetamagic
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>超魔 - 极效：可用于黏液之触</td></tr>
      <tr><td>MountedCombat
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>骑乘战斗：正确生效</td></tr>
      <tr><td>NaturalSpell
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>自然施法：修复对于非德鲁伊但是拥有野性变身能力的职业的前置条件</td></tr>
      <tr><td>PersistantMetamagic
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>超魔 - 顽强：所有有豁免骰的法术均可用</td></tr>
     <tr><td>RakingClaws
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>裂伤之爪：修复对于非德鲁伊但是拥有野性变身能力的职业的前置条件</td></tr>
      <tr><td>SelectiveMetamagic
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>超魔 - 甄选：不能用于非立即生效法术</td></tr>
      <tr><td>SelectivePrerequisites
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>超魔 - 甄选：需要10级知识（神秘）作为前置条件</td></tr>
      <tr><td>ShatterDefenses
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>粉碎防御：需要击中后才会生效</td></tr>
      <tr><td>ShifterRush
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>化形师疾冲：修复对于非德鲁伊但是拥有野性变身能力的职业的前置条件</td></tr>
      <tr><td>SiezeTheMoment
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>抓准时机：攻击丢失不再触发</td></tr>
      <tr><td>SlashingGrace
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>优雅挥砍：永远只对单手武器生效</td></tr>
      <tr><td>SpellSpecialization
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>法术专精：任意职业可选<br><b>注：据说会造成无法更换专精的BUG</b></td></tr>
      <tr><td>SpiritedCharge
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>奋力冲刺：额外伤害不再重击</td></tr>
      <tr><td>VitalStrike
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>要害打击：额外伤害不再重击</td></tr>
      <tr><td>WeaponFinesse
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>武器娴熟：不再把拥有灵巧/优雅的武器都视为娴熟武器</td></tr>
      <tr><td>VitalStrike
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>要害打击：修复和过肩斩的互动</td></tr>
  <tr><td rowspan="8">神话能力<br>MythicAbilities</td>
      <td>AscendantElement
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>巅峰元素：现在可以正确无视免疫</td></tr>
      <tr><td>BloodlineAscendance
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>巅峰血承：可以选择所有血承</td></tr>
      <tr><td>CloseToTheAbyss
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>深渊陷堕：修正伤害系数</td></tr>
      <tr><td>EnduringSpells
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>持久法术：对圣战之刃这类装备增强效果正确生效</td></tr>
      <tr><td>ExposeVulnerability
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>揭示弱点：不再能重击和触发武器效果</td></tr>
      <tr><td>MythicCharge
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>神话冲锋：防止触发多次伪攻击并触发武器效果</td></tr>
      <tr><td>SecondBloodline
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>第二血承：可以选择所有血承</td></tr>
      <tr><td>SecondBloodragerBloodline
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>第二血怒血承：自新魔士可选</td></tr>
  <tr><td rowspan="3">神话专长<br>MythicFeats</td>
      <td>ExpandedArsenal
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>扩充战法：不再能从多个其他学派获得DC和CL</td></tr>
      <tr><td>ExtraFeat
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>额外专长：只能选择一次</td></tr>
      <tr><td>ExtraMythicAbility
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>额外神话能力：只能选择一次</td></tr>
    <tr><td rowspan="4">BOSS和敌人修复<br>Bosses/Enemies</td>
          <td>Deskari
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>德斯卡瑞：完善UI描述</td></tr>
        <tr><td>StauntonVane
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>斯陶顿·卫恒拥有正确专长</td></tr>
	 <tr><td>Anomaly
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>混乱心智正常生效</td></tr>
        <tr><td>Balors
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>霸烙魔：修复斩首武器</td></tr>
  <tr><td>圣教军模式<br>Crusade</td>
    <td>Buildings - TrainingGrounds
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>训练场：修正伤害奖励</td></tr>
  <tr><td rowspan="30">物品<br>Items</td>
         <td>Armor - Haramaki
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>盔甲 - 腹卷：正确视为轻型护甲（原版视为无甲）</td></tr>
        <tr><td>Armor - SingingSteel
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>盔甲 - 歌唱钢：正确生效</td></tr>
        <tr><td>Equipment - AmuletOfQuickDraw
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>快速应敌护符：不再造成单独伤害实例</td></tr>
	<tr><td>Equipment - ApprenticeRobe
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>学徒长袍：不再受到法师护甲影响时获得额外1AC </td></tr>
        <tr><td>Equipment - AspectOfTheAsp
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>蛇相：修复生效 </td></tr>
        <tr><td>Equipment - BaneOfSpirit
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>灵魂之灾：使用为自由动作</td></tr>
	 <tr><td>Equipment - BoundOfPossibilityAeon
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>或然之缚（御衡）：加值匹配描述</td></tr>
	<tr><td>Equipment - BracersOfArchery
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>神射护腕：修复效果</td></tr>
        <tr><td>Equipment - FixScrollUMDDCs
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>使用魔法卷轴DC：现在等级正确改为 20 + 卷轴 CL </td></tr>
        <tr><td>Equipment - FlawlessBeltOfPhysicalPerfection8CritIncrease
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>无瑕+8极致体能腰带：重击范围增加修复 </td></tr>
        <tr><td>Equipment - HalfOfThePair
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>出双入对：效果生效判定优化</td></tr>
        <tr><td>Equipment - HolySymbolofIomedae
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>艾奥梅黛神圣徽记：可以在存读档或切换区域时保留激活</td></tr>
        <tr><td>Equipment - MagiciansRing
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>魔术师的戒指：现为 +2 DC</td></tr>
        <tr><td>Equipment - ManglingFrenzy
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>凌虐狂怒：对血承狂暴也有效果</td></tr>
        <tr><td>Equipment - MetamagicRods
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>物品 - 超魔权杖（默认关闭）</td></tr>
	<tr><td>Equipment - ShapeshiftersHelm
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>变形者头盔：修复和化形师的互动</td></tr>
        <tr><td>Equipment - StormlordsResolve
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>风暴领主的决意：现在可以立即关闭而不需等待1轮</td></tr>
	<tr><td>Equipment - QuiverOfRosesThorns
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>玫瑰刺弹药箭筒：修复效果匹配描述</td></tr>
        <tr><td>Weapons - BladeOfTheMerciful
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>慈悲之刃：防止多次触发伪攻击并过多触发武器特效</td></tr>
	<tr><td>Weapons - DevastatingBlowFromAbove
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>居高夺命：防止多次触发伪攻击并过多触发武器特效</td></tr>
        <tr><td>Weapons - EnergyBurst
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>元素附魔：修复各类元素爆附魔（焰爆）伤害计算</td></tr>
	<tr><td>Weapons - EyeForAnEye
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>以眼还眼：防止多次触发伪攻击并过多触发武器特效</td></tr>
        <tr><td>Weapons - Finnean
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>菲尼安：防止多次触发伪攻击并过多触发武器特效</td></tr>
        <tr><td>Weapons - HonorableJudgement
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>高尚裁决：防止多次触发伪攻击并过多触发武器特效</td></tr>
        <tr><td>Weapons - MusicOfDeath
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>死亡之音：修复效果</td></tr>
        <tr><td>Weapons - Radiance
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>辉光：正确获得法术抗力</td></tr>
        <tr><td>Weapons - SoundOfTheVoid
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>虚空之声：修复效果</td></tr>
        <tr><td>Weapons - TerrifyingTremble
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>惧颤：修复效果</td></tr>
        <tr><td>Weapons - ThunderingBurst
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>武器附魔 - 鸣爆：修复伤害</td></tr>
        <tr><td>Weapons - Vorpal
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>武器附魔 - 斩首：正确生效</td></tr>
  <tr><td>烹饪<br>Cooking</td>
    <td>ScreamingOmelet
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>尖叫煎蛋卷：正确获得每级2点生命值</td></tr>
</table>

<table>
<tr><th colspan="2">新增内容列表</th></tr> 
  <tr><td>基础能力</td>
    <td>单手持用：在加载TableTopTweaks后，许多需要你空出一只手的能力*真的*需要你空出一只手。激活此能力以强制单手握持你的武器，你会因此只能将1倍调整值应用在伤害上而不是1.5倍。</td>
  </tr>   
  <tr><td rowspan="7">变体</td>
      <td>Elemental Master 奥能师 - 元素大师</td></tr>
  <tr><td>Metamagic Rager 血怒者 - 超魔狂怒者</td></tr>
  <tr><td>Channeler Of The Unknown 牧师 - 熵化导能师</td></tr>
  <tr><td>Blade Bound 魔战士 - 剑缚者</td></tr>
  <tr><td>NatureFang 德鲁伊 - 自然之牙</td></tr>
  <tr><td>Divine Commander 战斗祭司 - 圣战指挥官</td></tr>
  <tr><td>Cauldron Witch 巫师 - 炼药巫师</td></tr>
  <tr><td>巅峰</td>
      <td>TTT新增，当一个角色在某一职业上达到20级可以选择一个巅峰奖励。部分巅峰只供特定职业选择，另外一些则为通用。<br>
        原版游戏中已经有不少职业拥有所谓“20级大招”。在TTT中将其与巅峰进行了整合。你可以在选择巅峰时选择原有“20级大招”，但是如此你便不能选择其他巅峰奖励。<br>
        <b>重要</b>：若角色通过变体更换了职业原本的“20级大招”，那么他也无法选择其他巅峰，这条规则对<b>其他MOD职业</b>同样适用<br>
      <b>完化身心</b>：通用巅峰。角色属性总值增加8点。可以自由选择加点。<br>
      <b>伟兽</b>：通用巅峰。拥有动物伙伴可以选择。动物伙伴的力量、敏捷、体质与智慧各增加4。<br>
      <b>推陈出新</b>：通用巅峰。职业具有至少4个奖励战斗专长可以选择。再获得4个奖励战斗专长。<br>
      其他职业还各自有不同的巅峰选择，例如法师可以获得额外法术位，在此不再一一列出。
      </td></tr>  
  <tr><td rowspan="7">职业特性</td>
      <td>血承：Aberrant 异怪血承、Destined 命运血承</td></tr>
  <tr><td>奥能技艺：Familiar 魔宠、Item Crafting 造物精通、Metamagic Knowledge 超魔学识、Quick Study 快速研读 </td></tr>
  <tr><td>战士进阶防具训练：Armored Confidence 自信着甲、Armored Juggernaut 盔甲主宰、Armor Specialization 重甲掌握、Critical Deflection 重击偏转、Steel Headbutt 钢铁头槌</td></tr>
  <tr><td>战士进阶武器训练：Defensive Weapon Training 防御式武器训练、 Focused Weapon 专注武器、Trained Grace 庖丁解牛、Trained Throw 精通投掷、Warrior Spirit 勇士之魂"</td> </tr>
  <tr><td>魔战士奥秘：Broad Study 奥术扩展、Spell Blending 混合奥法 </td></tr>
  <tr><td>游荡者天赋： Graceful Athlete 灵巧运动、Bleeding Attack 流血攻击、Emboldening Strike 鼓舞攻击</td></tr>    
  <tr><td>狂暴之力： Greater Animal Fury 高等兽类冲动</td></tr>    
  <tr><td rowspan="6">法术</td>
      <td>Cloak of Winds 风之斗篷：敌方远程攻击受到惩罚</td></tr>
  <tr><td>Long Arm 长臂咒：增加触及</td></tr>
  <tr><td>Mage's Disjunction <b>法师裂解术</b>：无豁免驱散/过穿戴者意志豁免使得魔法物品失效，逆天</td></tr>
  <tr><td>Shadow Enchantment 阴影惑控：幻术系模拟惑控</td></tr>
  <tr><td>Shadow Enchantment Greater 高等阴影惑控：楼上的高级版</td></tr>
  <tr><td>Stunning Barrier Greater 重型重创壁垒：防御法术</td></tr>
  <tr><td rowspan="60">专长和职业特性</td>
      <td>Metamagic (Burning Spell) 超魔（燃烧法术）：火酸法术附加持续伤害</td></tr>
  <tr><td>Metamagic (Encouraging Spell) 超魔（激励法术）：增加士气加值</td></tr>
  <tr><td>Metamagic (Flaring Spell) 超魔（闪耀法术）：火光电法术使敌人眩晕</td></tr>
  <tr><td>Metamagic (Intensified Spell) 超魔（强化法术）：增加伤害骰数量上限</td></tr>
  <tr><td>Metamagic (Piercing Spell) 超魔（法术穿刺）：降低对方有效法术抗力</td></tr>
  <tr><td>Metamagic (Rime Spell) 超魔（霜冻法术）：寒冷法术纠缠敌人</td></tr>
  <tr><td>Metamagic (Solid Shadows) 超魔（真实阴影）：提高阴影真实度</td></tr>
  <tr><td>Metamagic (Elemental Spell) 超魔（元素魔法）：转变法术伤害类型</td></tr>
  <tr><td>Ability Focus - Stunning Fist 能力专攻-震慑拳：提高震慑拳DC</td></tr>
  <tr><td>Animal Ally 动物盟友：获得动物伙伴</td></tr>
  <tr><td>Celestial Servant 天界仆从：动物伙伴获得天界模板</td></tr>
  <tr><td>Dervish Dance 致命舞步：当你持有一把弯刀且另一手空置时，你用敏捷取代力量作为伤害调整值。此外你将弯刀视为刺击而非挥砍武器</td></tr>
  <tr><td>Dispel Focus 解法专攻：尝试解除魔法时，在施法者等级检定上获得+2加值</td></tr>
  <tr><td>Greater Dispel Focus 高等解法专攻：楼上再+2</td></tr>
  <tr><td>Erastil's Blessing 猎手祝福：用感知取代敏捷作为用弓进行远程攻击的攻击调整值</td></tr>
  <tr><td>Expanded Spell Kenning 扩充法术认知：你使用法术认知时，你还可以从德鲁伊或巫师法表中选取法术</td></tr>
  <tr><td>Extra Arcana 额外魔战士奥秘</td></tr>
  <tr><td>Extra Arcanist Exploit 额外奥能技艺</td></tr>
  <tr><td>Extra Discovery 额外医学发现</td></tr>
  <tr><td>Extra Hex 额外巫术</td></tr>
  <tr><td>Extra Ki 额外气海池</td></tr>
  <tr><td>Extra Mercy 额外救赎</td></tr>
  <tr><td>Extra Reservoir 额外奥能点</td></tr>
  <tr><td>Extra Revelation 额外启示</td></tr>
  <tr><td>Extra Rogue Talent 额外游荡者天赋</td></tr>
  <tr><td>Extra Slayer Talent 额外杀手绝技</td></tr>
  <tr><td>Graceful Athlete 灵巧运动：敏捷代替力量做运动检定</td></tr>
  <tr><td>Improved Channel 精通导能：导能DC+2</td></tr>
  <tr><td><s>Lunge 突刺</s>原版已有</td></tr>
  <tr><td>Lunging Spell Touch 法术突刺：增加近战接触触及范围</td></tr>
  <tr><td>Magical Aptitude 奥法本能：知识(神秘)和使用魔法物品上获得加值</td></tr>
  <tr><td>Mantis Style 螳螂拳：你获得一次震慑拳每日使用次数。当你使用螳螂拳流派架势时，你的震慑拳DC+2</td></tr>
  <tr><td>Mantis Wisdom 六合拳劲：你可以将你的非武僧等级折半加上你的武僧等级来决定你的震慑拳效果。你使用螳螂拳流派架势时，你的震慑拳攻击骰有+2加值</td></tr>
  <tr><td>Mantis Torment 螳螂铁刺：使用螳螂拳流派架势时，你的震慑拳DC+2</td></tr>
  <tr><td>Mounted Skirmisher 骑乘散兵：如果坐骑在本回合移动的距离不超过它1个移动动作，你在本回合内仍然可以进行一次整轮攻击（原版本就可以，适合TTT改动）</td></tr>
  <tr><td>Nature Soul 自然之魂：知识(自然)和察觉上获得加值</td></tr>
  <tr><td>Two-Weapon Defense 双武器防御：双持武器提高AC</td></tr>
  <tr><td>Quick Channel 快速导能：消耗两次导能次数，以移动动作引导能量</td></tr>
  <tr><td>Quick Draw 快速拔刀：以自由动作切换或拔出武器</td></tr>
  <tr><td>Quicken Blessing 迅捷祝福：选择你的一项祝福，你可以用迅捷动作开启这项祝福，消耗两次每日祝福次数</td></tr>
  <tr><td>Riving Strike 奥能收割：给你的武器注入奥术力量时，你的攻击会使敌人豁免降低</td></tr>
  <tr><td>Scholar 学者：知识(神秘)和知识(世界)上获得加值</td></tr>
  <tr><td>Self-Sufficient 自给自足：学识(自然)和学识(宗教)上获得加值</td></tr>
  <tr><td>Shingle Runner 短跑健将：运动和灵巧上获得加值</td></tr>
  <tr><td>Greater Spell Specialization 高等法术专精：随意牺牲一个同环或更高环的法术位来自发施放你专精的法术</td></tr>
  <tr><td>Stalwart 坚毅：使用防御式攻击或寓守于攻时，你可以失去其AC加值，代之以获得等量的Dr</td></tr>
  <tr><td>Improved Stalwart 精通坚毅：从坚毅获得的Dr翻倍但有上限</td></tr>
  <tr><td>Trick Riding 诡计骑手：增加骑乘战斗可用次数</td></tr>
  <tr><td>Undersized Mount 灵巧骑术：可以骑同体型生物</td></tr>
  <tr><td>Varisian Tattoo 瓦里西安纹身：学派CL+1</td></tr>
  <tr><td>Armor Mastery Feats - Intense Blows 盔甲掌握 - 强力冲击：猛力攻击提高自身CMD</td></tr>
  <tr><td>Armor Mastery Feats - Knocking Blows 盔甲掌握 - 震撼冲击：猛力攻击降低对方CMD</td></tr>
  <tr><td>Armor Mastery Feats - Secured Armor 盔甲掌握 - 护心盔甲：概率抵消重击或者偷袭，和护命叠加</td></tr>
  <tr><td>Armor Mastery Feats - Sprightly Armor 盔甲掌握 - 轻快盔甲：盔甲的增强加值作为加值加到你的先攻检定</td></tr>
  <tr><td>Defended Movement 谨慎移动：提高对借机攻击AC</td></tr>
  <tr><td>Stumbling Bash 衰弱盾击：盾击降低对方AC</td></tr>
  <tr><td>Toppling Bash 倾覆盾击：盾击附带绊摔</td></tr>
  <tr><td>Tower Shield Specialist 塔盾专家：减少塔盾处罚</td></tr>  
  <tr><td>Arcane Discoveries 奥术发现（法师）：Alchemical Affinity 炼金亲和、Idealize 理想化、Knowledge Is Power 知识就是力量、Opposition Research 禁制研究、Yuelral's Blessing 约尔拉的赐福</td></tr>   
  <tr><td>Magic Trick (Fireball) 魔术技法（火球）</td></tr>  	
  <tr><td rowspan="1">新物品</td>
     <td>新增超魔对应的超魔权杖（商人购买）</td></tr>  
  <tr><td rowspan="10">神话专长</td>
      <td>Cleave (Mythic) 顺势斩（神话）：原版顺势斩效果（TTT砍了原版的顺势斩和终势斩）</td></tr>
  <tr><td>Critical Focus (Mythic) 重击专攻（神话）：自动确认对非神话对手的重击威胁，护命类需要确认2次</td></tr> 
  <tr><td>Combat Expertise (Mythic) 寓守于攻（神话）：寓守于攻获得额外两点AC的闪避加值</td></tr> 
  <tr><td>Combat Reflexes (Mythic) 战斗反射（神话）：每轮可以进行借机攻击的次数没有上限</td></tr> 
  <tr><td>Intimidating Prowess (Mythic) 威逼（神话）：威吓检定获得等同神话阶层的加值</td></tr> 
  <tr><td>Manyshot (Mythic) 多重射击（神话）：第一次和第二次攻击中都触发多重射击专长的效果</td></tr> 
  <tr><td>Shatter Defenses (Mythic) 神话粉碎防御：受到你的粉碎防御影响的敌人对所有攻击视为措手不及</td></tr> 
  <tr><td>Two-Weapon Defense (Mythic) 双武器防御（神话）：双武器防御额外附加你的武器中增强加值较高者的增强加值作为盾牌AC</td></tr> 
  <tr><td>Warrior Priest (Mythic) 信仰战士（神话）：你在先攻和专注上获得神话等级一半的加值</td></tr> 
  <tr><td>Titan Strike 泰坦之力：徒手攻击的伤害骰提升一级。此外，你在你的所有战技检定和震慑拳的DC上附加你的对手的体型比中型大的级数作为加值</td></tr>   
  <tr><td rowspan="25">神话能力</td>
      <td>Abundant Blessing 无穷祝福</td></tr>
  <tr><td>Abundant Bombs 无穷炸弹</td></tr>
  <tr><td>Abundant Lay On Hands 无穷圣疗</td></tr>
  <tr><td>Abundant Incense 无穷调香</td></tr>
  <tr><td>Abundant Fervor 无尽热诚</td></tr>
  <tr><td>Abundant Spell Kenning 充裕法术认知</td></tr>
  <tr><td>Armored Might 超凡护甲：提高盔甲AC</td></tr>
  <tr><td>Armor Master 神话护甲大师(重甲)：完全忽略重甲处罚</td></tr>
  <tr><td>Enhanced Blessings 强效祝福：祝福的持续时间翻倍</td></tr>
  <tr><td>Favorite Metamagic 偏好超魔（增加可选种类）</td></tr>
  <tr><td>Harmonious Mage 奥术调谐：准备对立学派的法术不再需要额外一个法术槽</td></tr>
  <tr><td>Impossible Blessing 奇迹祝福：获得一项额外祝福，忽略先决条件</td></tr>
  <tr><td>Impossible Speed 非凡神速：提高移动速度</td></tr>
  <tr><td>Mounted Maniac 疯狂骑手：骑乘冲锋时对周围30尺的所有敌人尝试打击士气</td></tr>
  <tr><td>Mythic Spell Combat 神话法术战斗：魔战士可以用任何道途法术书的法术施展法术战斗</td></tr>
  <tr><td>Precision Critical 精准重击：当你确认一次重击，将所有精准伤害的伤害骰乘二</td></tr>
  <tr><td>Second Patron 第二庇护主</td></tr>  
  <tr><td>Maximized Critical 极效重击：每当你进行一次重击时，武器的伤害结果永远是你可以掷出的最大值</td></tr>
  <tr><td>Adamantine Mind 精金意志</td></tr>
  <tr><td>Eldritch Breach 冲击魔障：当你尝试进行施法者等级检定来解除效果或克服法术抗力时，掷两次并取较高的结果。</td></tr>
  <tr><td>Elemental Bond 元素联结：对某个元素的法术增加施法者等级并获得对应抗性</td></tr>
  <tr><td>Energy Conversion 能量转换：转换法术元素类型</td></tr>
  <tr><td>Mythic Bond 神话羁绊：加强游侠羁绊效果</td></tr>
  <tr><td>Arcane Metamastery 奥术超魔熟稔：10轮内自动运用一个不超过2级的超魔</td></tr>
  <tr><td>Greater Arcane Metamastery 高等奥术超魔熟稔：奥术超魔熟稔允许的超魔等级提升到4</td></tr>
  <tr><td rowspan="1">背景</td>
         <td>Lecturer 讲师： 将知识（世界）和沟通加入本职技能列表，并可以用智力取代魅力进行沟通检定</td></tr>         
  <tr><td rowspan="4">额外种族替换特性</td>
      <td>矮人：Stoutheart 坚定、Stoic Negotiator 坚毅谈判者</td></tr>
  <tr><td>精灵： Fierani 菲拉尼、Arcane Focus 奥术专攻、Long Limbed 长跑者、Moon Kissed 月吻者、Vigilance 警觉</td></tr>
  <tr><td>侏儒： Artisan 艺术家、Keen 敏锐、Fell Magic 凶狠魔法、Utilitarian Magic 实用主义魔法、Inquisitive 好奇、Nosophobia 恐惧症</td></tr>
  <tr><td>半身人： Bruiser 粗鲁、Blessed 受祝福者、Secretive Survivor 秘密求生者、Underfoot 低位防守</td></tr>
</table>

-------------------------------------------
### [TabletopTweaks-Reworks](https://github.com/Vek17/TabletopTweaks-Reworks)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **自带中文（需要QL修正）**<br>
> *安装方式：* UMM<br>
> *修改内容：* 神话能力、神话专长，道途等<br>
> *新增内容：* 神话道途能力<br>
+ **TTT**的扩展附件，主要集中在**神话道途**的修改
+ 对神话能力、神话专长、道途均有修改，也导致很多人不习惯
<table>
<tr><th colspan="5">修改列表</th></tr> 
<tr><td>分类</td><td>Config中选项</td><td>默认</td><td>房规</td><td>效果</td></tr>  
    <tr><td>专长<br>Feats</td>
      <td>BolsterSpell
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>超魔 - 增效：法术等级变为I+2.</td></tr>  
    <tr><td  rowspan="4">神话能力<br>MythicAbilities</td>
      <td>AbundantCasting
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>充裕施法：额外法术位减半</td></tr>  
      <td>DimensionalRetribution
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>次元反击：使其如魔猫飞扑版生效，自动传送并攻击对手</td></tr>  
      <td>ElementalBarrage
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>元素狂潮：重做元素狂潮，改为施法者能力（原作也已修改），且队友可以触发</td></tr>  
      <td>GreaterEnduringSpells
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>高等持久法术：对10分钟以上法术才能生效</td></tr>            
    <tr><td  rowspan="3">神话专长<br>MythicFeats</td>
      <td>MythicSneakAttack
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>神话偷袭：改为增大偷袭骰，而不是增加</td></tr>  
      <td>SchoolMastery
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>学派掌控：改为 CL + 2</td></tr>  
      <td>MythicImprovedCritical
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>神话精通重击：改为重击附加额外伤害</td></tr>  
    <tr><td rowspan="10">御衡道途<br>MythicReworks - Aeon</td>
      <td>AeonBaneIcon
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>御衡破敌：修改图标</td></tr>  
      <td> AeonBaneAction
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>御衡破敌：改为自由动作</td></tr>  
      <td> AeonBaneSpellResistance
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>御衡破敌：加入神话等级进入抗力计算</td></tr>  
      <td>AeonBaneUses
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>御衡破敌：使用次数随 2x 神话阶层 + 角色等级增加</td></tr>  
      <td>AeonGazeActionSystem
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>逼迫凝视：如审判官审判一般可多次运用，并用迅捷动作释放</td></tr>  
      <td>AeonGazeIcons
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>逼迫凝视：修改图标</td></tr>  
      <td>AeonGreaterBaneActionBoost
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>高等御衡破敌：可用移动动作释放迅捷法术</td></tr>  
      <td>AeonGreaterBaneDamage
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>高等御衡破敌：伤害加入主武器，不再是单独实例</td></tr>  
      <td>AeonImprovedBaneDispelLimit
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>精通御衡破敌：使用同高等解法规则，CL为角色等级+神话阶层</td></tr>  
      <td>PatchAeonGreaterBaneDispel
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>高等御衡破敌：修复攻击解除魔法效果</td></tr>                  
    <tr><td rowspan="9">灵使道途<br>MythicReworks - Azata</td>
      <td>AzataPerformanceResource
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>灵使外观</td></tr>  
      <td>AzataSpellList
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>灵使法术书默认包含所有剧情分支灵使法术</td></tr>  
      <td>AzataSongActions
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>灵使之歌：从标准动作改为移动动作</td></tr>  
      <td>AzataSongToggles
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>灵使之歌：可在非战斗时使用</td></tr>  
      <td>FavorableMagic
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>卓越魔法：对于重投类效果正确生效（削弱4骰）</td></tr>  
      <td>ZippyMagic
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>灵动魔法：忽略部分有害效果，只对法术有效</td></tr>  
      <td>IncredibleMight
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>惊世神力：从士气加值改为神话加值</td></tr>  
      <td>LifeBondingFriendship
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>同生共死：次数现在基于神话阶层</td></tr>  
      <td>SupersonicSpeed
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>超音速：可与加速叠加</td></tr>  
    <tr><td rowspan="5">巫妖道途<br>MythicReworks - Lich</td>
      <td>DeadlyMagic
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>夺命魔法：可以使用等于神话阶层的轮数</td></tr>  
      <td>DecayingTouch
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>腐烂之触：完全重写减少BUG</td></tr>  
      <td>EclipseChill
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>噬星之寒：DC为 10 + 1/2 角色等级 + 神话阶层 + 最高属性加值. 可以使用等于神话阶层的轮数</td></tr>  
      <td>FearControl
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>操纵恐惧：DC为 10 + 1/2 角色等级 + 神话阶层 + 最高属性加值</td></tr>  
      <td>TainedSneakAttack
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>污染偷袭：对法术有效，DC为 10 + 1/2 角色等级 + 神话阶层 + 最高属性加值</td></tr>  
    <tr><td rowspan="18">诡术道途<br>MythicReworks - Trickster</td>
      <td>BoundOfPossibility
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>或然之缚（诡术）：任何技能鉴定双骰取高</td></tr>  
      <td>Progression
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>进程：改变获取神话诡计的进度</td></tr>  
      <td>TricksterKnowledgeArcana2
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>学识（神秘）2：增加允许的附魔类型</td></tr>  
      <td>TricksterKnowledgeArcana3
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>学识（神秘）3：增加允许的附魔类型</td></tr>  
      <td>TricksterLoreNature3
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>学识（自然）3：重建掉落表，增加大量物品</td></tr>  
      <td>TricksterLoreReligion2/3
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>学识（宗教）2/3：领域能力使用角色等级作为有效牧师等级，神话阶层作为感知修正，允许学习领域痴迷，领域法术单独成书而不再作为类法术能力</td></tr>  
      <td>TricksterMobility3
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>运动3：对所有攻击骰，包括法术攻击骰生效</td></tr>  
      <td>TricksterPerception1
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>察觉1：获得侦测潜行和掩蔽的掷骰重投</td></tr>  
      <td>TricksterPerception2
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>察觉2：不再解锁相关专长，改为获得护命重投，无视重击和偷袭免疫，+2 重击范围</td></tr>  
      <td>TricksterPerception3
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>察觉3：队友获得神话轨迹察觉效果</td></tr>  
      <td>TricksterPersuasion2
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>沟通2：造成恍惚1轮，DC为 10 + 沟通等级，打击士气使目标攻击和伤害骰将受到1 + 你的神话阶层一半的惩罚</td></tr>  
      <td>TricksterPersuasion3
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>沟通3：打击士气使敌人有50%概率攻击最近目标来替代正常行动，并减少其AC和豁免受到1 + 你的神话阶层一半的惩罚</td></tr>  
      <td>TricksterStealth1
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>潜行1：隐形不能再被预言类法术比如真知等发现</td></tr>  
      <td>TricksterStealth2
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>潜行2：隐形不能再被预言类法术比如真知等发现</td></tr>  
      <td>TricksterStealthAbilityName
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>修复潜行能力名称</td></tr>  
      <td>TricksterTrickery3
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>巧手3：巧手现在变为迅捷动作并可在触及范围内使用</td></tr>  
      <td>TricksterUseMagicDevice2
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>使用魔法装置2：除了原本效果还会获得专长，超魔-超正常法术</td></tr>  
      <td>UpdateIcons
          </td><td>:heavy_check_mark:
          </td><td>:heavy_check_mark:
          </td><td>升级图标</td></tr>  
</table>


-------------------------------------------
### [TabletopTweaks-Flanking](https://github.com/Vek17/TabletopTweaks-Flanking/releases/tag/v0.1.0)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **暂无中文**<br>
> *安装方式：* UMM<br>
> *修改内容：* 夹击规则<br>
> *新增内容：* 相关专长<br>
+ **TTT**的新扩展附件，主要集中在**夹击规则**的修改
+ 恢复了桌面规则对夹击角度的要求，同时增加了相关专长
<table>
<tr><th colspan="3">修改列表</th></tr> 
<tr><td>分类</td><td>名称</td><td>效果</td></tr>  
    <tr><td rowspan="3">专长<br>Feats</td>
      <td>Improved Outflank
        </td><td>精通包抄：降低夹击所需角度</td></tr>  
      <tr><td>Gang Up
        </td><td>一拥而上：至少两个盟友与敌人邻接时视同形成夹击</td></tr>  
      <tr><td>Pack Flanking
        </td><td>兽群围猎 ：与动物伙伴威胁同一个对手视同形成夹击</td></tr>  
</table>

-------------------------------------------
### [WrathMods-MultipleArchetypes](https://github.com/Vek17/WrathMods-MultipleArchetypes)
> *前置：* 无<br>
> *中文：* **无文本**<br>
> *安装方式：* UMM<br>
> *新增内容：* 多重变体<br>
+ 小型MOD，允许兼选同一职业的多个变体形成新的混合职业，前提是这些变体能力之间不会冲突（不会替换同一基础职业能力）

-------------------------------------------
### [MicroscopicContentExpansion](https://github.com/alterasc/MicroscopicContentExpansion)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **QL汉化**<br>
> *安装方式：* UMM<br>
> *修改内容：* 无<br>
> *新增内容：* 职业、专长、法术等<br>
+ 特别注意。本MOD不依赖于[TabletopTweaks-Base](#TabletopTweaks-Base)，但是作者建议安装来获得完整功能。
+ 增加部分新内容
<table>
<tr><th colspan="2">新增内容列表</th></tr> 
   <tr><td>职业</td>
       <td>Antipaladin 反圣武士及变体：Knight of the Sepulcher 死骸骑士、Iron Tyrant 钢铁暴君、Tyrant 暴君<br><i>参阅PF文档</i></td>
   <tr><td rowspan="5">职业特性</td>
       <td>Druidic Herbalism 德鲁伊草药学：德鲁伊可以免费酿造任何药水，还能将本来只能对自己释放的法术如同应用了炼金术师的注入炼成释放于盟友</td></tr>
   <tr><td>Antipaladin exclusive companion and mount - Nightmare (flaming horse) 反圣武士专属坐骑-梦魇</td></tr>
   <tr><td>Legion's Blessing 军团祝福（牧师变体圣教军8级能力）：通过额外献祭高3环法术位，将正常范围为接触的无害法术，用于 10 英尺半径内的所有盟友。</td></tr>
   <tr><td>Timeless Body 不老身躯：17级起，武僧的属性将不再因年龄而承受减值，也不会因为魔法而衰老。</td></tr>
   <tr><td>Flawless Mind 无垢识：19级起，武僧将可以完全掌控自己的心灵。当武僧进行意志豁免检定时，可以骰两次并取较好的结果。</td></tr>
   <tr><td rowspan="12">专长</td>
       <td>Unsanctioned Knowledge 禁忌学识（反圣武士版）：添加其他职业法术到圣武士法表</td></tr>
   <tr><td>Snake Style 蛇拳：察言观色+2，徒手攻击可造成穿刺伤害</td></tr>
   <tr><td>Snake Sidewind 蛇行：使用蛇拳流派徒手时对抗击倒和地面效果的反射检定+4，徒手攻击重击确认+4</td></tr>
   <tr><td>Snake Fang 白蛇吐信：使用蛇拳流派徒手时对方攻击失手后对其借机攻击</td></tr>
   <tr><td>Startoss Style 散星式：<i>参阅PF文档</i>，投掷远程攻击增益</td></tr>
   <tr><td>Startoss Comet 散星击：<i>参阅PF文档</i>，投掷二目标攻击</td></tr>
   <tr><td>Startoss Shower 散星流光：<i>参阅PF文档</i>，投掷多目标攻击</td></tr>
   <tr><td>Dimensional Agility 次元灵巧：<i>参阅PF文档</i>，次元门后继续行动</td></tr>
   <tr><td>Dimensional Assault 次元突击：<i>参阅PF文档</i>，可作为冲锋的一部分释放次元门</td></tr>
   <tr><td>Dimensional Dervish 次元狂舞：<i>参阅PF文档</i>，整轮攻击中，能够以迅捷动作使用次元门</td></tr>
   <tr><td>Flickering Step 闪现步伐：可用类法术能力释放次元门</td></tr>
   <tr><td>Crusader's Flurry 圣战连击：可以用神祇偏好的近战武器进行疾风连击</td></tr>
   <tr><td rowspan="3">法术</td>
       <td>Deadly Juggernaut 死亡化身（牧师3，审判官3，圣武士3，反圣武士3，战斗祭司3）：<i>参阅PF文档</i>，击杀对手获得奖励</td></tr>
   <tr><td>Blade of Dark Triumph 黑暗祝胜之刃（反圣武士3）：<i>参阅PF文档</i>，强化神契武器</td></tr>
   <tr><td>Blade of Bright Victory 光辉胜利之刃（圣武士3）：<i>参阅PF文档</i>，强化神契武器</td></tr>
   <tr><td rowspan="2">武僧气力</td>
       <td>Deadly Juggernaut 死亡化身：同同名法术</td></tr> 
       <td>Diamond Resilience 金钟罩：获得伤害减免</td></tr> 
</table>

-------------------------------------------
### [SparsSorcerousSundries](https://github.com/TheSparhawk/SparsSorcerousSundries)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **QL汉化**<br>
> *安装方式：* UMM<br>
> *修改内容：* 修复辉光最终形态附魔效果<br>
> *新增内容：* 物品、法术等<br>
+ 主要是增加物品

<table>
<tr><th colspan="2">新增内容列表</th></tr> 
   <tr><td>前作武器</td>
       <td>增加大约40件前作装备，在商人处购买（大部分在原游戏商人，同时第四章O院万乐园加入了一个新商人）</td>
   <tr><td>其他</td>
       <td>增加10件新物品，1个新法术</td></tr>
</table>

**注意，更新游戏到2.12版本后，SparsSorcerousSundries似乎出现了BUG，万乐园的新商人无法成功出现**<br>
**为暂时解决此问题，可以用记事本打开VendorItemList.txt，将其中C4Gilmore全部替换为C4Heraxa（万乐园新老板）**<br>
**自制全物品补丁已同样操作**<br>

> 上方文件中补了充一个自制补丁，需要安装SparsSorcerousSundries才能使用<br>
> 在商店添加了几乎全部前代特殊装备<br>
> 添加位置：ACT1酒保、矮人 ACT2军需官、卷轴商人、小贼 ACT3 军需官、牧师 ACT4 万乐园新老板 ACT5 牧师、异种武器商<br>
> 售价随便定的，效果也可能有BUG，仅供娱乐！<br>

-------------------------------------------
### [TomeOfTheFirebird](https://github.com/pheonix99/TomeOfTheFirebird)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **QL汉化**<br>
> *安装方式：* UMM<br>
> *修改内容：* 修复部分BUG，职业能力调整<br>
> *新增内容：* 物品、法术等<br>
+ 大型MOD，增加很多新内容
+ 重要改动：驱散魔法类现在成为了”安全法术“，只会驱散敌人身上的BUFF和我方身上的DEBUFF
<table>
<tr><th colspan="2">新增内容列表</th></tr> 
   <tr><td>变体</td>
      <td>Eldritch Scion (Sage) 魔战士 - 奥法后继者（贤者）<br><b>注意不要和术士兼职</b></td></tr>  
   <tr><td rowspan="5">职业特性</td>
       <td>血怒血承：Phoenix  凤凰血承，需要TabletopTweaks-Base</td></tr>
   <tr><td>原力：Clockwork Heart 械动之心</td></tr>
   <tr><td>庇护主：Light 光耀、Animal 动物、 Protection 保护、Plague 疫病</td></tr>
   <tr><td>狂暴之力：Rage Stance Mastery 狂暴姿态大师，同时使用两种野蛮人姿态、Elemental Stance 元素战姿，近战攻击额外造成能量伤害</td></tr>
   <tr><td>圣疗救赎：Injured 救赎创伤（给予快速治疗）、Ensorcelled 救赎蛊惑（驱散，可对敌）</td></tr>
   <tr><td rowspan="12">法术<br><i>参阅PF文档</i></td>
       <td>Bone Fists 骸骨之拳：增加天生防御和天生武器伤害</td></tr>
   <tr><td>Chains Of Fire 连环炽焰：闪电链火焰版本</td></tr>
   <tr><td>Fire Shield 火焰护盾：攻击者受到火焰伤害并减免寒冷伤害，也有完全相反的寒冷版本</td></tr>
   <tr><td>Vitrolic Mist 硫酸雾甲：火焰护盾酸蚀版</td></tr>
   <tr><td>Entropic Shield 熵光护盾：偏转远程攻击</td></tr>
   <tr><td>Freezing Sphere 冰封法球：寒冷伤害</td></tr>
   <tr><td>Gloomblind bolts 黑盲矢：多发负能量飞弹，附带目盲</td></tr>
   <tr><td>Heal Mount 医疗坐骑：效果如名字</td></tr>
   <tr><td>Keen Edge 锋锐术：为武器附加锐锋</td></tr>
   <tr><td>Spear Of Purity 纯善之矛：远程接触，对邪恶异界特效</td></tr>
   <tr><td>Telekinetic Strikes 念力打击：徒手和天生武器附带力场伤害</td></tr>
   <tr><td>Burst Of Radiance 光耀爆发：群体致盲，邪恶生物受到伤害</td></tr>  
   <tr><td rowspan="12">专长<br><i>参阅PF文档</i></td>
       <td>Ability Focus- Breath Weapon 能力专攻 - 吐息武器：增加吐息攻击DC</td></tr>
   <tr><td>Ancestral Scorn 先祖蔑视：当你成功使用威吓检定挫败邪恶子类的异界生物的士气时，目标除了受到挫败士气的正常影响以外，还会恶心1轮。如果你的检定高于DC5点或更多的话，该生物则会反胃1轮以取代恶心效果</td></tr>
   <tr><td>Burn Resistance 超载抵抗：计算操念超载非致命伤害时将自己等级视为低2级计算</td></tr>
   <tr><td>Extra Burn 额外超载：增加每日超载限制</td></tr>
   <tr><td>Extended Buffer 额外念力缓冲：增加念力缓冲（MOD新增操念自带特性，减少一定量的超载）</td></tr>
   <tr><td>Discordant Song 不谐之歌：诗人歌曲。为盟友武器增加音波伤害，远程武器需要目标也在范围内</td></tr>
   <tr><td>Prodigious Two-Weapon Fighting 有力双武器战斗：副手单手武器视为轻型，用力量属性代替敏捷属性来满足双武器系列专长的先决条件</td></tr>
   <tr><td>Sundering Strike 破甲重击：原为破武重击，成功重击后附加击破武器，游戏中实为附加击破盔甲</td></tr>
   <tr><td>Coordinated Shoot 准线规避：团队专长，如果同样有此专长的盟友威胁目标且不提供掩蔽，远程攻击检定+1，如果该盟友再和其他盟友（可以无此专长）夹击目标，变为+2</td></tr>
   <tr><td>Lastwall Phalanx 终焉之墙：团队专长，在对抗邪恶生物攻击的AC和豁免获得等同拥有此专长队友数量的崇圣加值</td></tr>
   <tr><td>Swarm Strike 集群攻击：团队专长，敌人引起借机攻击时，你的攻击得到＋1加值，每多一个拥有此专长并威胁该敌人的盟友再＋1</td></tr>
   <tr><td>Armor Of The Pit 深渊铠甲：魔裔种族专长，天生防御+2</td></tr>        
   <tr><td rowspan="2">物品</td>
       <td>Bracers Of The Merciful Knight 仁慈骑士护腕：阿尔西诺伊处购买，增加使用圣疗时的有效等级和使用次数</td></tr>
   <tr><td>Bracers Of The Avenging Knight 复仇骑士护腕：阿尔西诺伊处购买，增加使用破邪斩时的有效等级</td></tr>    
   <tr><td>神话能力</td>
       <td>Mythic Kinetic Aegis 神话念盾：视为拥有1点超载来计算原力-元素防御，在神话3/6/9各增加1点</td></tr>       
 </table> 

-------------------------------------------
### [HomebrewArchetypes](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/279)
+ **注意！Homebrew Archetypes不能使用UMM安装，可以使用ModFinder安装或者参考汉化帖手动安装**
> *前置：* 无<br>
> *中文：* **自带中文（建议使用QL修正）**<br>
> *安装方式：* **非UMM**<br>
> *修改内容：* 物品、变体和机制（AC）<br>
> *新增内容：* 大量变体，职业、信仰、领域、专长<br>
+ 大型MOD，增加很多新内容
+ Homebrew Archetypes分为三个部分：
  + 本体：核心内容
  + AC：修改部分物品和机制，**队友入队等级变为1**
  + ACTestingGrounds：将部分队友变为原创职业、规则书职业或变体，未汉化 
 <table>
 <tr><th colspan="3">新增内容列表<br>详细介绍可以参阅汉化发布贴或游戏内说明</th></tr> 
   <tr><td colspan="2" rowspan="2">职业</td>
       <td>Investigator 调查员及变体：Jinyiwei 锦衣卫、Questioner 发问者、Empiricist 演绎家</td></tr>
  <tr><td>NPC职业：5个NPC用职业，基本白板</td></tr>
  <tr><td rowspan="28">变体</td>
    <td rowspan="2">奥能师</td>
         <td>Blood Arcanist 血奥师</td></tr>
         <tr><td>School Savant 学派家</td></tr>
    <tr><td rowspan="2">野蛮人</td>
         <td>Hateful Rager 恨意狂暴者</td></tr>
         <tr><td>Primal Hunter 原始猎手</td></tr>
    <tr><td rowspan="3">吟游诗人</td>  
         <td>Arcane Duelist 奥术决斗者</td></tr>
         <tr><td>Dervish of Dawn 晨光舞者</td></tr>
         <tr><td>Stonesinger 石之歌者</td></tr>
    <tr><td rowspan="2">血怒者</td>       
         <td>Untouchable Rager 抗咒狂怒者</td></tr>
         <tr><td>Bloody-Knuckled Rowdy 血暴铁拳</td></tr>
    <tr><td rowspan="1">骑将</td>      
         <td>Green Knight 苍翠骑士</td></tr>
    <tr><td rowspan="3">牧师</td>          
         <td>Evangelist 宣教士</td></tr>
         <tr><td>Undead Lord 尸骸领主</td></tr>
         <tr><td>Elder Mythos Cultist 旧神密教徒</td></tr>
    <tr><td rowspan="1">德鲁伊</td>      
         <td>Halcyon Druid 宁静德鲁伊</td></tr>
    <tr><td rowspan="1">战士</td>      
         <td>Viking 维京人</td></tr>
    <tr><td rowspan="2">武僧</td>      
         <td>Hellcat 地狱猫</td></tr>
         <tr><td>Monk of the Mantis 螳螂拳僧</td></tr>
    <tr><td rowspan="5">圣武士</td>      
         <td>Oathbound - Oath of Vengeance 圣武士 - 复仇誓约圣武士</td></tr>
         <tr><td>Oathbound - Oath of the People's Council 圣武士 - 人民民主誓约圣武士</td></tr>
         <tr><td>Wilderness Warden 圣武士 - 荒野守望者</td></tr>
         <tr><td>Holy Guide 圣武士 - 神圣向导</td></tr>
         <tr><td>Faithful Wanderer 圣武士 - 虔信流浪者(<b>暂未汉化<b>)</td></tr>
     <tr><td rowspan="1">先知</td>       
         <td>Ancient Lorekeeper 传古学者</td></tr>
     <tr><td rowspan="2">游侠</td>      
         <td>Wild Stalker 野性潜猎者</td></tr>
         <tr><td>Sword-Devil 剑魔</td></tr>
     <tr><td rowspan="1">战斗祭司</td>        
         <td>Sacred Fist 神拳使</td></tr>
     <tr><td rowspan="1">法师</td>     
         <td>Undead Master 死灵之主</td></tr>
     <tr><td rowspan="1">巫师</td>      
         <td>Scarred Witch Doctor 疤痕巫医</td></tr>
  <tr><td colspan="2" rowspan="2">进阶职业</td>
       <td>Razmiran Priest 拉兹密安牧师</td>
  <tr><td>Assassin 刺客</td></tr>
  <tr><td colspan="2" rowspan="10">专长</td>
       <td>Adept Channel 导师导能：增加导能能力</td>
  <tr><td>Strike True 克敌机先：消耗移动动作增加AB</td></tr>
  <tr><td>Channel Smite 导能打击：迅捷动作附带导能伤害到攻击</td></tr>
  <tr><td>Greater Channel Smite 高等导能打击：楼上升级版，没打中不会消耗</td></tr>
  <tr><td>Guided Hand 引导之手：使用神祗偏爱武器变为感知上AB（<b>仅限原版神祗和本MOD神祗才有效</b>）</td></tr>
  <tr><td>Hex Strike 巫术打击：徒手攻击附加巫术</td></tr>
  <tr><td>Monastic Legacy 修道传承：非武僧等级一半视为武僧等级</td></tr>
  <tr><td>Blooded Arcane Strike 血术之击：狂暴时可以释放法术</td></tr>
  <tr><td>Fire Music 燃火之乐：法术伤害转为火焰伤害并强化召唤生物</td></tr>
  <tr><td>Discordant Voice 不谐之音：吟游诗人乐曲为盟友附加音波伤害</td></tr>
  <tr><td colspan="2">基础动作</td>
         <td>Aid Another 援助他人：消耗动作为盟友附加AB或者AC</td></tr>
  <tr><td colspan="2">信仰</td>
         <td>克苏鲁系11个信仰</td></tr>
  <tr><td colspan="2">领域</td>
         <td>Void 虚空领域：擅长旅行移动和召唤</td></tr>
  <tr><td rowspan="5">神话能力</td>
    <td rowspan="2">本体</td>
       <td>Poison Vulnerability 透体之毒：解除敌人毒免</td>
  <tr><td>Sustained Vulnerability 毒入骨髓：延长透体之毒有效期</td></tr>
    <tr><td rowspan="3"><b>AC专属</b></td>
          <td>Abundant Casting(Homebrew) <b>连锁施法：一定次数唤回任意法术</b></td></tr>
      <tr><td>Empowered Bombs 增强炸弹：提高炼金炸弹伤害</td></tr>
      <tr><td>Maximized Bombs 终极炸弹：炼金炸弹总是造成最大伤害</td></tr>
  <tr><td colspan="2" rowspan="2">神话专长</td>
          <td>Mythic Guided Hand 引导之手（神话）：引导之手后修，感知上伤害</td>
      <tr><td>Mythic Crossbow Training 神话弩箭训练：弩获得敏上伤害</td></tr>
</table>

-------------------------------------------
### [ExpandedContent2022](https://github.com/ka-dyn/ExpandedContent)
+ [贴吧汉化帖](https://tieba.baidu.com/p/8108212678)
> *前置：* 无<br>
> *中文：* **有汉化，提供QL汉化修正**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 大量信仰、变体、专长等<br>
+ 大型MOD，增加很多新内容
 <table>
 <tr><th colspan="3">新增内容列表<br>详细介绍可以参阅汉化发布贴或游戏内说明</th></tr> 
   <tr><td rowspan="3">职业及变体</td>
       <td>Oathbreaker 复仇暴徒</td>
           <td>Castigator 惩戒者</td></tr> 
   <tr><td rowspan="2">DreadKnight 恐惧骑士</td>
           <td>Conqueror 征服者</td></tr> 
           <tr><td>Claw of the False Wyrm 虚龙之爪</td></tr> 
   <tr><td rowspan="27">变体</td>
       <td rowspan="3">审判官</td>
           <td>Living Scripture 活圣经</td></tr> 
	   <tr><td>Ravener Hunter 狩魔猎手</td></tr> 
	   <tr><td>Sworn of the Eldest 原初誓者</td></tr> 
       <tr><td rowspan="1">战斗祭司</td>
           <td>Mantis Zealot 螳螂狂徒</td></tr> 
       <tr><td rowspan="1">牧师</td>
           <td>Divine Scourge 神圣鞭笞者</td></tr> 
       <tr><td rowspan="6">德鲁伊</td>
           <td>Mooncaller 唤月者</td></tr> 
           <tr><td>Draconic Druid 龙之德鲁伊</td></tr> 
           <tr><td>Storm Druid 风暴德鲁伊</td></tr> 
           <tr><td>Urban Druid 文明德鲁伊</td></tr> 
           <tr><td>Bear Totem Shaman 熊图腾萨满</td></tr> 
	   <tr><td>Treesinger 树之歌者</td></tr> 
       <tr><td rowspan="1">牧师</td>
           <td>Divine Scourge 神圣鞭笞者</td></tr> 
       <tr><td rowspan="2">圣骑士</td>
           <td>Temple Champion 圣殿冠军</td></tr> 
           <tr><td>Silver Champion 银冠勇士</td></tr> 
       <tr><td rowspan="1">游侠</td>
           <td>Drake Warden 龙兽守望者</td></tr> 
       <tr><td rowspan="1">游荡者</td>
           <td>Clutch Thief 龙蛋小偷</td></tr> 
       <tr><td rowspan="1">先知</td>
           <td>Ocean's Echo 海洋回声</td></tr>
       <tr><td rowspan="1">萨满</td>
           <td>Draconic Shaman 龙族萨满</td></tr> 
       <tr><td rowspan="1">奥能师</td>
           <td>Draconic Scholar 龙之学者</td></tr> 
       <tr><td rowspan="1">歌者</td>
           <td>Wyrm Singer 龙战颂者</td></tr> 
       <tr><td rowspan="3">战士</td>
           <td>Archer 弓手</td></tr> 
	   <tr><td>Spear Fighter 枪矛手</td></tr> 
	   <tr><td>Child of Acavna and Amaznen 旧神圣子</td></tr> 
       <tr><td rowspan="2">猎人</td>
           <td>Skulking Hunter 潜伏猎手</td></tr>
           <td>Plant Master 植物大师</td></tr>
       <tr><td rowspan="1">骑将</td>
           <td>Drakerider 龙兽骑士</td></tr> 
       <tr><td rowspan="1">炼金术师</td>
           <td>Mindchemist 心智药师</td></tr> 
   <tr><td rowspan="7">职业特性</td>
       <td>先知秘示域</td>
       <td>Dragon 龙、Heavens 苍天、Succor 救助 Wood 林木 Winter 凛冬 Lunar 月亮</td></tr>
   <tr><td>战斗祭司祝福</td>
       <td>Community 团队 Plant 植物 Artifice 手艺 War 战争</td></tr>
   <tr><td>炼金术师科研发现</td>
       <td>Pheromones 信息素 Healer's Touch</td></tr>
   <tr><td>先知诅咒</td>
       <td>Vampirism 吸血鬼</td></tr>
   <tr><td>萨满精魂</td>
       <td>Heavens 苍天</td></tr>
   <tr><td>动物伙伴</td>
       <td>Wolverine 狼獾、Web Tyrant Spider 暴君蜘蛛、Giant Fly 巨苍蝇</td></tr>
   <tr><td>龙兽伙伴</td>
       <td>部分职业或变体可用</td></tr>
   <tr><td colspan="2">基础动作</td>
       <td>Aid Another 援助他人</td></tr>
   <tr><td colspan="2" rowspan="5">专长</td>
       <td>Swift Aid 迅速援助</td></tr>
       <tr><td>Opening Volley 远近夹攻</td></tr>
       <tr><td>Demon Hunter 恶魔猎手</td></tr>
       <tr><td>Bullseye Shot 中的射击</td></tr>
       <tr><td>Pinpoint Targeting 精确瞄准</td></tr>
   <tr><td colspan="2" rowspan="2">神话能力</td>
       <td>Mythic Drake 神话龙兽</td>
   <tr><td>Impossible Subdomain 无限子域可能</td></tr>
   <tr><td rowspan="3">信仰</td>
       <td>神祗</td>
       <td><b>海量新神祗</b></td></tr>
   <tr><td>领域</td>
       <td>Scalykind 鳞状<br>Plant 植物领域修改为桌面规则</td></tr>
   <tr><td>子领域</td>
       <td>Agathion 阿加西翁、 Archon 亚空, Blood 血液、Caves 洞穴、Curse 诅咒、 Demon, Dragon 龙、Ferocity 凶猛、Ice 冰、Lust 欲望、Psychopomp 招魂、Rage 狂暴、 Resolve 决心、Restoration 恢复、Revelation 启示、Revolution 革命、Rivers 河流、Stars 星空、Storm 风暴、Thievery 盗窃、Undead 不死、Whimsy 滑稽、Wind 风、Growth 生长、Fist 铁拳、Loyalty 忠诚 Fist 铁拳 Loyalty 忠诚</td></tr>
   <tr><td colspan="2" rowspan="35">法术<br><i>参阅PF文档</i></td>
       <td>Hydraulic push 水流冲击</td></tr>
   <tr><td>Slipstream 滑流</td></tr>
   <tr><td>Scourge of the Horsemen 天启诸骑的蹂躏</td></tr>
   <tr><td>Rigor mortis 尸僵</td></tr>
   <tr><td>Reviving Finale 重振谢幕曲</td></tr>
   <tr><td>Deadly Finale 致命谢幕曲</td></tr>
   <tr><td>Purging Finale 净化谢幕曲</td></tr>
   <tr><td>Stunning Finale 惊叹谢幕曲</td></tr>
   <tr><td>Hollow Blades 空心刀刃</td></tr>
   <tr><td>Goodberry 神莓</td></tr>
   <tr><td>Steam Ray Fusillade 蒸汽融化射线</td></tr>
   <tr><td>Inflict Pain 痛苦创伤</td></tr>
   <tr><td>Inflict Pain Mass 群体疼痛创伤</td></tr>
   <tr><td>Gloomblind Bolts 阴暗飞弹</td></tr>
   <tr><td>Fury of the Sun 太阳之怒</td></tr>
   <tr><td>Invoke Deity 召唤神明</td></tr>
   <tr><td>Wall of Fire 烈焰之墙</td></tr>
   <tr><td>Zephyr's Fleetness 岚风敏捷</td></tr>
   <tr><td>Hypnotic Pattern 催眠图纹</td></tr>
   <tr><td>Clay Skin 粘土皮肤</td></tr>
   <tr><td>Entropic Shield 熵能护盾</td></tr>
   <tr><td>Shield of Fortification 强化之盾</td></tr>
   <tr><td>Greater Shield of Fortification 极化护盾</td></tr>
   <tr><td>Dance of a Hundred Cuts 百袭战舞</td></tr>
   <tr><td>Dance of a Thousand Cuts 千袭战舞</td></tr>
   <tr><td>Particulate Form 粒子形态</td></tr>
   <tr><td>Plant Shape 植物形态（I、II、III）</td></tr>
   <tr><td>Shillelagh 橡棍术</td></tr>
   <tr><td>Wooden Phalanx 点木成兵</td></tr>
   <tr><td>Arcane Concordance 秘法调和</td></tr>
   <tr><td>Blood Mist 血雾术</td></tr>
   <tr><td>Dust of Twilight 暮光之尘</td></tr>
   <tr><td>King's Castle 王车易位</td></tr>
   <tr><td>Moonstruck 痴狂月光</td></tr>
   <tr><td>Moment of Prescience 片刻预知</td></tr>
 </table>   

-------------------------------------------
### [ToggleableThrowingWeapons](https://github.com/pheonix99/ToggleableThrowingWeapons)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* 匕首和星刃投掷<br>
+ 小型MOD，持有匕首和星刃时会多出一个开关型能力，可以自由在**远程使用和近战使用**间切换。
+ Nexus上有类似功能的MOD Thrown Daggers，但是强烈推荐这个，不管是功能上还是兼容性上，本MOD都遥遥领先

-------------------------------------------
### [MorvarchsPlaystyleExpansions](https://github.com/MorvarchPrincess/MorvarchsPlaystyleExpansions)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 专长等<br>
+ 增加少量新内容
<table>
 <tr><th colspan="2">新增内容列表<br></th></tr> 
   <tr><td rowspan="2">专长</td>
       <td>Bladed brush 战刃舞绘：大砍刀使用敏捷决定AB和伤害</td></tr>
   <tr><td>Way of the shooting star 飞星之道：星刃使用魅力决定AB和伤害（可与上方星刃投掷同时使用）</td></tr>
   <tr><td rowspan="1">变体</td>
       <td>The Hellknight Shadow 地狱骑士之影：游荡者和地狱骑士混合职业</td></tr>
   <tr><td rowspan="1">职业特性</td>
       <td>Hellknight Signifier Fixes：地狱骑士持节士和神术施法者获得联动强化</td></tr>
 </table> 
 
-------------------------------------------  
### [PhoenixsCantrips](https://github.com/pheonix99/PhoenixsCantrips)
 + [贴吧汉化帖](https://tieba.baidu.com/p/8298217679)
> *前置：* 无<br>
> *中文：* **有汉化**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* 戏法强化<br>
+ 小型MOD，强化戏法，使其拥有更高成长性
  
------------------------------------------- 
### [MoreCantrips](https://github.com/pheonix99/MoreCantrips)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **有汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 更多戏法<br>
+ PhoenixsCantrips 戏法强化的扩展，增加了其他属性的接触戏法
<table>  
 <tr><th colspan="2">新增内容列表<br></th></tr> 
   <tr><td rowspan="7">法术（戏法）</td>
       <td>Firebolt 火焰箭：火焰远程接触</td></tr>
   <tr><td>Burning Touch 燃烧之触：火焰近战接触</td></tr>
   <tr><td>Painful Note 苦痛单音：音波远程接触</td></tr>
   <tr><td>Dissonant Touch 不谐之触：音波近战接触</td></tr>
   <tr><td>Lesser Corrosive Touch 次级酸蚀之触：酸蚀近战接触</td></tr>
   <tr><td>Lesser Shocking Grasp 次级电爪：电击近战接触</td></tr>
   <tr><td>Frosty Touch 寒霜之触：寒冷近战接触</td></tr>
 </table>   
 
------------------------------------------- 
### [CharacterOptionsPlus](https://github.com/WittleWolfie/CharacterOptionsPlus)
> *前置：* TabletopTweaks-Core, ModMenu<br>
> *中文：* **自带（本人维护）**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 大量，法术专长为主<br>
+ 大型MOD，增加很多新内容
<table>  
 <tr><th colspan="3">新增内容列表<br></th></tr> 
  <tr><td colspan="2" rowspan="2">变体<br><i>参阅PF文档</i></td>
       <td>Arrowsong Minstrel 吟游诗人 - 箭歌咏者</td></tr> 
   <tr><td>Winter Witch 巫师 - 冬巫 <b>基础职业巫师变体，和进阶职业不同</b></td></tr> 
   <tr><td rowspan="7">职业特性</td>
       <td rowspan="2">原力</td>
           <td>Shimmering Mirage 微光幻影，获得隐蔽</td></tr>
           <tr><td>Suffocate 窒息，窒息目标可导致昏迷</td></tr>
       <tr><td rowspan="1">游荡者天赋</td>
           <td>Shadow Duplicate 影分身，被击中时可释放类似镜影</td></tr>
       <tr><td rowspan="3">杀手绝技</td>
           <td>Armored Marauder 装甲强袭，擅长重甲并减少惩罚</td></tr>
           <tr><td>Armored Swiftness 迅捷甲士，重甲不影响速度并提高最大敏捷加值</td></tr>
           <tr><td>Slowing Strike 延缓打击，偷袭造成减速</td></tr>
       <tr><td rowspan="1">巫术</td>
           <td>Ice Tomb 冰冢，寒冷并麻痹</td></tr>
   <tr><td colspan="2" rowspan="11">专长<br><i>参阅PF文档</i></td>
       <td>Dazing Assault 晕眩强袭：AB换取敌人眩晕</td></tr> 
   <tr><td>Divine Fighting Technique 神圣武器技法：包含11个神圣武器技法专长，限定信仰</td></tr>
   <tr><td>Eldritch Heritage 悠远血脉（另有进阶和高等）：获得额外血承能力</td></tr>
   <tr><td>Furious Focus 沉着暴怒：每轮第一次猛力攻击不受减值</td></tr>
   <tr><td>Glorious Heat 火热荣耀：释放火焰法术时治疗盟友并提供士气加值</td></tr>
   <tr><td>Hurtful 痛殴：成功威吓检定挫败了一个处于你的触及范围内生物的士气时，你可以以一个迅捷动作对这个目标进行一次近战攻击</td></tr>
   <tr><td>Paired Opportunists 双重藉机：对共同威胁敌人借机攻击获得环境加值，触发队友借机攻击可以引发你也借机攻击</td></tr>
   <tr><td>Purifying Channel 净化导能：引导正能量可以对一个敌人造成火焰伤害和目眩</td></tr>
   <tr><td>Signature Skill 标志性技能：选择一项技能获得奖励，游荡者可自动获得</td></tr>
   <tr><td>Skald's Vigor 健硕之歌（另有高等）：维持战怒之歌给予快速医疗，高等在启动时对队友有效</td></tr>
   <tr><td>Energy Channel 元素能量引导：消耗引导能量使你的武器攻击获得额外元素伤害</td></tr>
   <tr><td colspan="2" rowspan="39">法术<br><i>参阅PF文档</i></td>
       <td>Bladed Dash 飞刃袭：直线移动并对路径上敌人攻击</td></tr> 
   <tr><td>Burning Disarm 灼热缴械：使物品变热强迫敌人丢下</td></tr> 
   <tr><td>Consecrate 祝圣术：祝圣一片区域</td></tr> 
   <tr><td>Desecrate 亵渎术：亵渎一片区域</td></tr> 
   <tr><td>Dimensional Blade 次元剑：迅捷动作，使得1轮内武器能够进行接触攻击</td></tr> 
   <tr><td>Fleshworm Infestation 血蛆侵袭：接触攻击造成持续生命值和敏捷伤害</td></tr> 
   <tr><td>Freezing Sphere 冰封法球：寒冷伤害</td></tr> 
   <tr><td>Frost Fall 冰河瀑布：区域内持续造成寒冷伤害，初始可造成恍惚</td></tr> 
   <tr><td>Frozen Note 冻结音符：持续造成麻痹</td></tr> 
   <tr><td>Hedging Weapons 护神武具：创造神祇的偏好武器悬浮在身边，提供保护并可抓住投掷</td></tr> 
   <tr><td>Ice Slick 冰滑术：类似油腻术，释放时造成寒冷伤害</td></tr> 
   <tr><td>Ice Spears 冰矛术：多发冰矛造成寒冷和穿刺伤害，可以击倒敌人</td></tr> 
   <tr><td>Implosion 内爆术：维持专注，每一轮造成CL*10伤害</td></tr> 
   <tr><td>Invisibility Purge 消除隐形：反隐形效果法球</td></tr> 
   <tr><td>Judgement Light 审判之光：审判官法术，基于审判产生不同效果</td></tr> 
   <tr><td>Keen Edge 锋锐术：为武器附加锐锋</td></tr> 
   <tr><td>Mortal Terror 凡人怖惧：造成效果逐渐提升的恐惧</td></tr> 
   <tr><td>Nine Lives 九命天猫：帮助抵消九次有害效果</td></tr> 
   <tr><td>Screaming Flames 尖叫火墙：火焰及感知伤害</td></tr> 
   <tr><td>Shadow Trap 阴影陷阱：纠缠目标</td></tr> 
   <tr><td>Stricken Heart 剜心手：近战接触造成负能量伤害和恍惚</td></tr> 
   <tr><td>Touch of Blindness 目盲之触：近战接触造成目盲</td></tr> 
   <tr><td>Unshakable Zeal 狂热执念：增益，检定失败后下次检定获得加值；可以抵消情绪效果并消散</td></tr> 
   <tr><td>Weapon of Awe 敬畏武器：强化武器，在伤害骰上获得+2神圣加值，并且重击目标将会无豁免战栗一轮。
</td></tr> 
   <tr><td>Wrath 狂怒：锁定目标，对指定目标攻击和伤害获得士气加值</td></tr> 
   <tr><td>Cheetah's Sprint 豹急：迅捷动作，1轮内巨幅增加移动速度</td></tr> 
   <tr><td>Defensive Shock 闪电之盾：对攻击你的敌人造成闪电伤害</td></tr> 
   <tr><td>Frostbite 冻伤：近战接触造成寒冷非致命伤害和疲乏，可多次使用</td></tr> 
   <tr><td>Chill Touch 寒冷之触：近战接触造成负能量和力量伤害，对不死生物造成恐慌，可多次使用</td></tr> 
</table>  
  
------------------------------------------- 
### [DarkCodex](https://github.com/Truinto/DarkCodex)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **自带中文**（本人维护，已经合并到官方）<br>
> *安装方式：* **UMM**<br>
> *修改内容：* 较多可选，包括核心规则<br>
> *新增内容：* 大量<br>
+ 大型MOD，增加很多新内容 
+ **特别注意，本MOD的滥强离谱东西很多，尤其是房规内容** 
> **重要对游戏机制改变选项提示**<br>
> **下列选项默认为关闭状态**<br>
> **General.PatchBasicFreebieFeats** 减少“专长税”，将大量低级基础专长（如猛力攻击、武器娴熟等）变为免费赠送，解放大量专长<br>
> **Mythic.PatchElementalBarrage** 元素狂潮回滚，可以用武器伤害触发<br>
> **Patch.Patch_ZippySpellLike** 灵动魔法回滚，可以对类法术能力生效<br>
     
<table>
<tr><th colspan="5">新增和修改内容列表<br>实装：:construction:表示是否未经作者测试<br>实装：:x:表示未实装，无实际效果</th></tr> 
<tr><td>分类</td>
    <td>选项</td>
    <td>内容</td>
    <td>房规</td>
    <td>实装</td></tr>
<tr>
<th rowspan="1">DEBUG</td> 
    <td>DEBUG.Enchantments</td>
    <td>DEBUG：显示隐藏附魔</td>
    <td>:x:</td>
    <td>:construction:</td></tr>
<tr>
<th rowspan="1">附魔</td> 
    <td>Enchantments.NameAll</td>
    <td>给予所有附魔名称和描述</td>
    <td>:x:</td>
    <td>:construction:</td></tr>
<tr>
<th rowspan="17">通用</td> 
    <td>General.CreateAbilityFocus</td>
    <td><b>新增专长：</b>Ability Focus 能力专注，增加能力DC</td>
    <td>:x:</td>
    <td>:x:</td></tr>
<tr><td>General.CreateBackgrounds</td>
    <td><b>新增专长：</b>Additional Traits 额外背景特性<br>新增背景：<br>Magical Lineage 魔法裔,指定一个法术。当你超魔施展该法术时，其最终占用的法术环位视为比正常状况降低1级，cl+2（但是不会超过当前HD）<br>
Metamagic Master 超魔主宰：指定一个法术。当你超魔施展该法术时，其最终占用的法术环位视为比正常状况降低2级<br>Fate’s Favored 天佑者：所有幸运加值额外+1</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateBardStopSong</td>
    <td>增加能力，随意立即结束吟游诗人歌曲</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateDirtyFighting</td>
    <td><b>新增专长：</b>Dirty Fighting 卑劣战斗，在没有夹击且没有相应专长时，战技不会引发借机攻击但是受到减值</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateHeritage</td>
    <td>半兽人替换种族特性：Orc-Atavism 正宗绿皮，亲眷半精灵重新获得精灵免疫</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateKitsuneFoxfire</td>
    <td>魔性之尾获得Foxfire Bolt 狐火箭</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateMadMagic</td>
    <td><b>新增战斗专长：</b>Mad Magic 疯狂魔法，允许狂暴时施法e</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateOpportuneParry</td>
    <td><b>新增战斗专长：</b>Opportune Parry 适时格挡，决斗家消耗借机攻击次数，用自由动作进行格挡</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreatePreferredSpell</td>
    <td><b>新增专长：</b>Preferred Spell 偏好法术，选定一个法术，使其能够自发转换施法</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateSacredSummons</td>
    <td><b>新增专长：</b>Sacred Summons 神圣召唤，特定召唤生物可以立即召唤</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateSpellPerfection</td>
    <td><b>新增专长：</b>Spell Perfection 完全法术，附加任意一个超魔到法术而不影响其实际环数（但附加此超魔后理论环数不能大于9）和施法时间，专攻等专长数值奖励对该法术加倍</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.PatchAngelsLight</td>
    <td>天使之光（天使）：给予等于角色等级的临时生命值</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.PatchBasicFreebieFeats</td>
    <td>减少“专长税”，将大量低级基础专长（如猛力攻击、武器娴熟等）变为免费赠送，解放大量专长<br>https://michaeliantorno.com/feat-taxes-in-pathfinder/</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.PatchHideBuffs</td>
    <td>隐藏部分BUFF使UI更清晰</td>
    <td>:x:</td>
    <td>:construction:</td></tr>
<tr><td>General.PatchVarious</td>
    <td>移除贵重款待的处罚，防护XX法术持续时间变为10分钟</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.FixMasterShapeshifter</td>
    <td>确保带有变形描述符的法术都能享受变化自如效果</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.FixSpellElementChange</td>
    <td>修复元素血承和法术专攻的交互</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="4">物品</td> 
    <td>Items.CreateButcheringAxe</td>
    <td><b>新武器类型：</b> Butchering Axe 屠戮斧</td>
    <td>:x:</td>
    <td>:construction:</td></tr>
<tr><td>Items.CreateImpactEnchantment</td>
    <td><b>新附魔类型：</b> Impact 冲击</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Items.PatchArrows</td>
    <td>战后拾起非魔法的箭矢</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Items.PatchTerendelevScale</td>
    <td>特伦笛利弗鳞片能够每日复活一次</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="24">操念</td> 
    <td>Kineticist.CreateAutoMetakinesis</td>
    <td>拥有超载自动增强念袭</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateBladeRushInfusion</td>
    <td><b>注能(念刃骑士)：</b> Blade Rush 念刃冲锋</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateChainInfusion</td>
    <td><b>注能：</b> Chain 连锁</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateElementalScion</td>
    <td><b>新操念使变体：</b>元素后继者</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateExpandedElement</td>
    <td><b>新增专长：</b>select extra elements 选择额外元素</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateExtraWildTalentFeat</td>
    <td><b>新增专长：</b>Extra Wild Talent 额外原力，前置专长</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateHurricaneQueen</td>
    <td><b>原力：</b>Hurricane Queen 飓风女王</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateImpaleInfusion</td>
    <td><b>注能：</b>Impale 贯通</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateKineticEnergizeWeapon</td>
    <td><b>注能：</b>Energize Weapon 充能武器</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateKineticFist</td>
    <td><b>注能：</b>Kinetic Fist 念拳</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateKineticistBackground</td>
    <td><b>出生地背景：</b>作为专长学习前置时，操念使等级视为 +1</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateMindShield</td>
    <td><b>原力：</b>Mind Shield 减半心念使处罚</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateMobileGatheringFeat</td>
    <td><b>新增专长：</b>Mobile Gathering 移动凝聚 - 念力凝聚时可以以减半速度移动</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateSelectiveMetakinesis</td>
    <td>7级时获得甄选超念</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateVenomInfusion</td>
    <td><b>注能：</b>Venom Infusion 毒素注能：对目标造成恶心或毒素效果</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.CreateWhipInfusion</td>
    <td><b>注能(念刃骑士)：</b> Kinetic Whip 念鞭</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.FixExpandedElementFocus</td>
    <td>元素扩展：修复多次选择同一元素时缺失的原力和掌控</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.PatchDarkElementalist</td>
    <td>黑暗元素使：加快战斗外动画速度并可随处使用</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.PatchDemonCharge</td>
    <td>恶魔降临：不再影响使用念力凝聚</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.PatchGatherPower</td>
    <td>念力凝聚：可以手动使用</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.PatchVarious</td>
    <td>强击注能可用于沙暴念袭，应用心念使主属性设置，修复负向能量掌控</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.FixBlastsAreSpellLike</td>
    <td>念袭成为类法术能力，而不再是超自然能力</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Kineticist.FixBloodKineticist</td>
    <td>尝试修复血念使相关BUG</td>
    <td>:x:</td>
    <td>:construction:</td></tr>
<tr><td>Kineticist.FixWallInfusion</td>
    <td>修复墙壁注能不对内部敌人造成伤害的问题</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>  
<tr>
<th rowspan="3">魔战士</td> 
    <td>Magus.CreateAccursedStrike</td>
    <td>巫战士：奥秘 - Accursed Strike 诅咒打击</td>
    <td>:x:</td>
    <td>:x:</td></tr>
<tr><td>Magus.FixHexcrafterProgression</td>
    <td>巫战士：允许任意奥秘选择巫术, 修复缺失的法术唤回</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Magus.PatchSwordSaint</td>
    <td>剑圣：允许选择任意武器</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="4">武技</td> 
    <td>MartialArt.CreateBladedBrush</td>
    <td><b>新增专长：</b>Bladed Brush 战刃舞绘，对大砍刀应用武器娴熟和精确刺击</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>MartialArt.CreatePaladinVirtuousBravo</td>
    <td><b>圣武士变体仁义剑客</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>MartialArt.CreateProdigiousTwoWeaponFighting</td>
    <td><b>新增专长：</b>Prodigious Two Weapon Fighting 有力双武器战斗，使用力量代替敏捷计算双武器专长要求，副手单手武器视为轻型</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>MartialArt.CreateTwoWeaponRend</td>
    <td><b>新增专长：</b>Two Weapon Rend 双武器撕裂，双武器命中造成额外伤害</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="2">武僧</td> 
    <td>Monk.CreateFeralCombatTraining</td>
    <td><b>新增专长：</b>Feral Combat Training 野性战斗训练 - 使用任意天生武器时，你可以应用那些需要精通徒手击打作为前提的专长。如果你是武僧，也可以应用两仪回风效果。</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Monk.PatchSoheiRapidShot</td>
    <td>僧兵：禁用快速射击</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="39">神话</td> 
    <td>Mythic.CreateDemonLord</td>
    <td>恶魔道途：增加恶魔领主特性 - 随意传送等</td>
    <td>:heavy_check_mark:</td>
    <td>:construction:</td></tr>
<tr><td>Mythic.CreateDemonMastery</td>
    <td><b>神话专长：</b>Demon Mastery 恶魔掌握 - 需要恶魔道途6，选择一种魔相成为被动效果</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateExtraMythicFeats</td>
    <td><b>神话能力可以选择额外神话专长，反之亦然</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateHarmoniousMage</td>
    <td><b>神话能力：</b>Harmonious Mage 奥术调谐 - 忽略对立学派惩罚</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateKineticMastery</td>
    <td><b>神话专长：</b>Kinetic Mastery 物理念袭获得等于神话阶层的攻击加值，能量念袭加值减半</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessArcanePool</td>
    <td><b>神话能力：</b>Limitless Arcane Pool 无限奥法池 - 除了法术唤回外的能力不消耗奥法池点数</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessArcaneReservoir</td>
    <td><b>神话能力：</b>Limitless Arcane Reservoir 无限奥能源泉</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessBardicPerformance</td>
    <td><b>神话能力：</b>Limitless Bardic Performance 无限吟游演艺；Limitless Raging Song 无限战怒之歌</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessBloodlineClaws</td>
    <td><b>神话能力：</b>True Dragon 真龙 - 无限使用龙裔血承龙爪，增加龙息次数，随意使用龙型II</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessBombs</td>
    <td><b>神话能力：</b>Limitless Alchemist's Creations 无限炼金造物 - 无限使用炼金炸弹和熏香</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessDomain</td>
    <td><b>神话能力：</b>Limitless Domain Powers 无限领域能力</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessInquisitorBane</td>
    <td><b>神话能力：</b>Limitless Inquisitor Bane 无限审判官破敌</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessKi</td>
    <td><b>神话能力：</b>Limitless Ki 无限气海 - 气海消耗量-1</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessShaman</td>
    <td><b>神话能力：</b>Limitless Spirit Weapon 无限精魂武器（萨满和精魂猎手）</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessSmite</td>
    <td><b>神话能力：</b>Limitless Smite 无限辟邪/辟乱斩，需要原版无穷辟邪/辟乱斩作为前提</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessWarpriest</td>
    <td><b>神话能力：</b>Limitless Sacred Warpriest 无限崇圣战祭 - 无限使用崇圣武器和崇圣盔甲</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessWarpriestBlessing</td>
    <td><b>神话能力：</b>Limitless Warpriest Blessings 无限战斗祭司祝福</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateLimitlessWitchHexes</td>
    <td><b>神话能力：</b>Limitless Witch Hexes 无限巫术 - 无视冷却时间</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateMagicItemAdept</td>
    <td><b>神话能力：</b>Magic Item Adept 魔法物品专家 - 魔法物品（不包括魔杖、卷轴、药水）使用自身等级作为施法者等级</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateMetamagicAdept</td>
    <td><b>神话专长：</b>Mythic Metamagic Adept 神话超魔专家 - 自发施法者超魔不再需要整轮</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateMythicCompanion</td>
    <td><b>神话专长：</b>Mythic Animal Companion 神话动物同伴 - 解锁动物同伴所有装备槽</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateMythicEschewMaterials</td>
    <td><b>神话能力：</b>Mythic Eschew Materials 神话节约材料：施法不再需要材料</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateNotAChance</td>
    <td><b>神话能力：</b>Not A Chance 并非良机 - 对方投出20也不会自动命中，免疫重击</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateResourcefulCaster</td>
    <td><b>神话能力：</b>Resourceful Caster 丰裕施法者 - 法术失败、专注失败、被抵抗、被豁免时回收法术位</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateSwiftHex</td>
    <td><b>神话能力：</b>Cursing Gaze 诅咒凝视 - 可以迅捷动作使用巫术和强力巫术，高等巫术除外</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateSwiftHuntersBond</td>
    <td><b>神话能力：</b>Swift Hunters Bond 迅捷猎人羁绊 - 猎人羁绊变为迅捷动作</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.ExtendLimitlessAnimalFocus</td>
    <td><b>神话能力：</b>Limitless Animal Focus 无限动物之力 - 获得猎人巅峰宗师猎人</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchAscendantSummons</td>
    <td>巅峰召唤：强化为+4属性, DR 10</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchBoundlessHealing</td>
    <td>无界治疗：将治疗法术加入法术书</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchBoundlessInjury</td>
    <td>伤害能力：Boundless Injury 无界伤害 - 类似无界治疗，对造成伤害类法术生效</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchElementalBarrage</td>
    <td>元素狂潮：回滚补丁，可被武器攻击触发</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchJudgementAura</td>
    <td>永恒审判：现在对审判灵光也有效果</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchKineticOvercharge</td>
    <td>念力超量：持续保持有效，不再需要念力凝聚</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchLimitlessDemonRage</td>
    <td>无限狂暴：现在对恶魔狂怒也有效果</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchRangingShots</td>
    <td>试射瞄准：击中后加成不会减少</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchUnstoppable</td>
    <td>一往无前：对更多状态如震慑、眩晕、困惑有效</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchVarious</td>
    <td>加快恶魔传送，允许任何伤害触发元素狂潮，无限狂暴对元素凶性（元素蛮徒）有效</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchWanderingHex</td>
    <td>游魂巫术：可以随意切换巫术</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.PatchAlwaysAChance</td>
    <td>不失水准：投出自然1时自动成功，对绝大多数d20有效</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="1">游侠</td> 
    <td>Ranger.CreateImprovedHuntersBond</td>
    <td><b>新增专长：</b>Improved Hunter's Bond 强化猎人羁绊 - 猎人羁绊给予完整加值</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="2">游荡者</td> 
    <td>Rogue.CreateBleedingAttack</td>
    <td>游荡者天赋：Bleeding Attack 流血攻击<br><b>新增专长：</b>Flensing Strike 剥皮打击 - 偷袭削弱天生护甲</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Rogue.CreateExtraRogueTalent</td>
    <td><b>新增专长：</b>Extra Rogue Talent 额外游荡者天赋</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="6">施法者</td> 
    <td>Spellcasters.CreateBestowHope</td>
    <td><b>新增专长：</b>Bestow Hope 授予希望 - 引导能量减少恐惧等级</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spellcasters.CreateChannelForm</td>
    <td><b>新增专长：</b>Channel Form 导能塑形 - 改变引导能量形状的一系列能力</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spellcasters.CreateEnergyChannel</td>
    <td><b>新增专长：</b>Energy Channel 元素能量引导 - 使用引导次数为武器充能</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spellcasters.CreatePurifyingChannel</td>
    <td><b>新增专长：</b>Purifying Channel 净化导能 - 引导正能量造成火焰伤害</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spellcasters.FixBloodlineArcane</td>
    <td>奥术血承：奥法巅峰能够无视超魔施法时间惩罚</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spellcasters.PatchArcanistBrownFur</td>
    <td>棕毛变化师：允许分享变化用于任何法术</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="7">法术<br><i>法术详<br>情可参<br>阅PF文<br>档</i></td> 
 <td>Spells.CreateBladedDash</td>
    <td><b>新增法术：</b>Bladed Dash 飞刃袭</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spells.CreateChillTouch</td>
    <td><b>新增法术：</b>Chill Touch 寒冷之触</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spells.CreateDivineTrident</td>
    <td><b>新增法术：</b>Divine Trident 神圣三叉戟</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spells.CreateFlameBlade</td>
    <td><b>新增法术：</b>Flame Blade 火焰刀<br><b>新增专长：</b>Flame Blade Dervish Combat 炎刃狂舞</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spells.CreateHealingFlames</td>
    <td><b>新增法术：</b>Healing Flames 治愈之焰</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spells.CreateProduceFlame</td>
    <td><b>新增法术：</b>Produce Flame 燃火术</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spells.PatchVarious</td>
    <td>修复维生气泡为范围效果</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="3">解锁</td> 
    <td>Unlock.UnlockAnimalCompanion</td>
    <td>允许动物伙伴提升到最多40级</td>
    <td>:heavy_check_mark:</td>
    <td>:construction:</td></tr>
<tr><td>Unlock.UnlockKineticist</td>
    <td>提升操念使注能/原力/元素到最多40级</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Unlock.UnlockSpells</td>
    <td>解锁部分法术：变形</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="6">Witch<br>巫师</td> 
    <td>Witch.CreateCackleActivatable</td>
    <td>尖笑/诵咒可以切换为被动使用移动动作</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Witch.CreateExtraHex</td>
    <td><b>新增专长：</b>Extra Hex 额外巫术</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Witch.CreateIceTomb</td>
    <td><b>新增巫术：</b>Ice Tomb 冰冢</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Witch.CreateSplitHex</td>
    <td><b>新增专长：</b>Split Hex 分裂巫术；Split Major Hex 分裂强效巫术</td>
    <td>:x:</td>
    <td>:construction:</td></tr>
<tr><td>Witch.FixBoundlessHealing</td>
    <td>无界治疗：对治疗性巫术生效</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Witch.FixFortuneHex</td>
    <td>祈福：每个类型每轮只能触发一次</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="30">补丁</td> 
    <td>Patch.Patch_AbilityRange</td>
    <td>每2CL提高法术射程5尺</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_ActivatableHandleUnitRunCommand</td>
    <td>修复移动动作会自动关闭可激活能力（当有2个同时激活时）</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_ActivatableOnNewRound</td>
    <td>触发时使用光移动动作，无剩余动作自动关闭</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_ActivatableOnTurnOn</td>
    <td>修复使用同一动作的可激活能力不能同时激活</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_ActivatableTryStart</td>
    <td>修复可激活能力在战斗外不能二次激活</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_AllowAchievements</td>
    <td>禁用'has used mods before' 标签，允许解锁成就</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_ArcanistSpontaneous</td>
    <td>允许奥能师使用未记忆超魔，但是需要增加施法时间</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_AzataFavorableMagic</td>
    <td>卓越魔法（灵使）对光环豁免生效，如果开启了TTT的相关卓越魔法选项，本功能无效</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_BackgroundChecks</td>
    <td>防止相同的背景技能导致错误</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_DarkElementalistBurn</td>
    <td>对于原力，当前超载值也包含成功的灵魂能源次数</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_DismissAnything</td>
    <td>无视施法者来解除法术</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_EnduringSpells</td>
    <td>允许持久法术对任何来源法术生效; 修复魔化武器</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_EnvelopingWindsCap</td>
    <td>移除Hurricane Queen 飓风女王的 50% 闪避上限</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_FixAreaDoubleDamage</td>
    <td>修复范围效果施法时触发两次</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_FixAreaEndOfTurn</td>
    <td>回合模式中范围效果在目标单位的回合结束触发，而不是施法者的回合开始触发</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_FixFeatureSelection</td>
    <td>修复错误 #189</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_FixPolymorphGather</td>
    <td>变形后可以使用念力凝聚，有手生物可以使用念刃</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_FixQuickenMetamagic</td>
    <td>修复如果已经使用迅捷动作后，瞬发能力需要消耗更长时间</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_HexcrafterSpellStrike</td>
    <td>巫战士：接触型巫术适用于法术打击</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_KineticistAllowOpportunityAttack</td>
    <td>允许念鞭借机攻击，念鞭不可用时也能使用天生攻击</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_LimitlessActivatables</td>
    <td>可无限使用的能力战斗外可以激活并在战斗后保持</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_MagicItemAdept</td>
    <td>修复魔法物品专家</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_ParryAlways</td>
    <td>即使攻击本会丢失，也强制使用格挡（决斗家）</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_Polymorph</td>
    <td>允许debug flag在变形期间保持物品栏和模型</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_PreferredSpellMetamagic</td>
    <td>偏好法术所需补丁</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_ResourcefulCaster</td>
    <td>丰裕施法者所需补丁</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_RespecPartially</td>
    <td>允许重置后加点随时终止</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_TrueGatherPowerLevel</td>
    <td>通常情况下念力凝聚等级基于选择的模式，如果模式低于实际积累等级，凝聚等级会丢失。修复后凝聚等级基于选择的模式或者积累量中较高者</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_UnlockClassLevels</td>
    <td>允许职业等级超过20级，但是并不会增加新的能力（除了基本加值），通常情况下角色等级也不能超过20级</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_ZippySpellLike</td>
    <td>允许灵动魔法（灵使）对类法术能力生效</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td>
 </table>

------------------------------------------- 
### [AddedFeats](https://github.com/Telyl/AddedFeats)
> *前置：* ModMenu<br>
> *中文：* **QL汉化（@HerryZheng8提供）**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 专长，法术<br>
+ **注意！本MOD原更新网址不适用于新版，请在本页面右侧下载重编译版**
+ 小型内容Mod，持续开发中

 <table>  
 <tr><th colspan="3">新增内容列表<br></th></tr> 
  <tr><td rowspan="1">房规</i></td>
      <td>Mythic Bond<br>(Mythic Animal Focus)</td><td>
      神话羁绊（神话动物之力）：允许猎人激活额外一种动物之力</td></tr>
  <tr><td rowspan="10">专长</i></td>
      <td>Forceful Charge</td><td>
      暴力冲锋（动物同伴专长，包括进阶版Improved Forceful Charge）：冲锋攻击附带重装</td></tr>
      <tr><td>Favored Animal Focus</td><td>
      偏好动物之力：加强动物之力效果</td></tr>
      <tr><td>Planar Focus</td><td>
      位面之力：动物之力获得新的形态</td></tr>
      <tr><td>Totem Beast</td><td>
      兽魂图腾：动物伙伴获得额外选定的动物之力效果</td></tr>
      <tr><td>Evolved Companion (partial)</td><td>
      伙伴进化：动物伙伴获得进化</td></tr>
      <tr><td>Improved Natural Armor (Animal Companion Feat)</td><td>
      精通天生护甲（动物伙伴专长）</td></tr>
      <tr><td>Improved Natural Attack (Animal Companion Feat)</td><td>
      精通天生武器攻击（动物伙伴专长）</td></tr>
      <tr><td>Spirit's Gift</td><td>
      精魂赠礼：授予动物伙伴精魂</td></tr>
      <tr><td>Vampiric Companion</td><td>
      吸血同伴：伙伴转为亡灵生物并获得亡灵主人能力</td></tr>
      <tr><td>Improved Spell Sharing (Teamwork)</td><td>
      精通法术共享（团队专长）：可以将自身法术效果分享给动物同伴，持续时间平分</td></tr>
  <tr><td rowspan="2">法术</i></td>
      <td>Strong Jaw</td><td>
      铁碎颚：增强天生武器威力</td></tr>
      <tr><td>Atavism</td><td>
      原始野性：动物获得进化模板</td></tr>
 </table>
 
------------------------------------------- 
### [BetterBackgrounds](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/205)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **非UMM**<br>
> *修改内容：* <br>
> *新增内容：* 人物背景<br>
+ 修改了大量原版背景，还加入几个新背景，有滥强，非UMM安装
+ 本处提供汉化。请查阅安装说明，或用modfinder安装，然后把汉化放进
C:\Users\你的用户名\AppData\LocalLow\Owlcat Games\Pathfinder Wrath Of The Righteous\Modifications\BetterBackgrounds\Localization
<table>
   <tr><th colspan="2">新增内容列表<br></th></tr> 
   <td>新增背景</td><td>奥法技工<br>骑士<br>终焉之墙骑士团<br>天寻者<br>星球行者<br>神殿武士<br>天狗门徒</tr><tr> 
   <td>原背景</td><td>对大量原背景进行了修改，包括新特性和擅长武器等<br>背景提供的武器擅长在你已有相应擅长时变为特征加值</td>
</table>
  
------------------------------------------- 
### [MartialExcellence](https://github.com/Envibel/MartialExcellence)
> *前置：* 无<br>
> *中文：* **已自带中文（本人提交）**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 种族，专长等<br>
+ 小型内容Mod，持续开发中
+ 汉化已经提交给官方但是不一定能及时更新，可以在[这里](https://github.com/nixgnot/MartialExcellence/blob/main/MartialExcellence/LocalizedStrings.json)下载并替换汉化（直接复制全文并替换MOD文件夹下LocalizedStrings.json内容）

<table>
   <tr><th colspan="3">新增内容列表</th></tr> 
   <td>种族</td>
          <td>Skinwalker</td>
          <td>兽态人<br>包含亚种Classic 典型、Ragebred 怒孽、Bloodmarked 血印、Coldborn 冷嗣、Scaleheart 鳞心、Nightskulk 夜隐、Seascarred 海疤、Fanglord 牙王、Witchwolf 巫狼、Aerieborn 羽族<br><i>参阅PF文档</i></td></tr>
   <tr><td rowspan="7">专长</td>
          <td>Dazing Assault</td><td>
             晕眩强袭：降低5AB为代价攻击造成敌人眩晕，DC=10+BAB</td></tr>
          <tr><td>Stunning Assault</td><td>
             震慑强袭：降低5AB为代价攻击造成敌人震慑，DC=10+BAB</td></tr>
          <tr><td>Shield Slam</td><td>
             盾牌猛冲：（有修改）盾击时发动冲撞</td></tr>
          <tr><td>Vicious Stomp</td><td>
             恶毒踩踏：对方倒地时借机攻击（不和恶毒践踏者叠加）</td></tr>
          <tr><td>Raging Brutality</td><td>
             狂暴猛击：（有修改）狂暴时将体质修正添加到伤害，无双手奖励，可重击</td></tr>
          <tr><td>Hands of Valor</td><td>
             勇猛之手：1天1次，使用圣疗时可以灌输友军，使其在攻击鉴定和对抗恐惧的豁免检定上获得等于你魅力修正的崇圣加值，持续1分钟</td></tr>
          <tr><td>Extra Feature</td><td>
             额外特性：兽态人使用自带改变形态时，可以选择额外一种获得的特性</td></tr>
    <tr><td rowspan="2">狂暴之力</td>
         <td>Come and Get Me!</td><td>
             反击态势：直到野蛮人的下一回合之前，敌人对他的攻击检定和伤害检定+4，但是敌人对他的每次攻击之前都会引起野蛮人的借机攻击</td></tr>
         <tr><td>Unrestrained Rage</td><td>
             无尽狂怒：（有修改）狂暴时免疫麻痹</td></tr>
     <tr><td>背景</td>
         <td>Jungle Explorer</td><td>
             丛林探索者：（房规原创）+1强韧豁免，运动和灵巧成为本职技能，擅长反曲刀</td></tr>   
</table>
      
------------------------------------------- 
### [MediumClass](https://github.com/Telyl/MediumClass)
> *前置：* 无<br>
> *中文：* **无**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 通灵者职业，少量专长<br>

**注意！本MOD在最新版本尚未测试**
+ 早期版本，主要添加通灵者（Medium）职业，还做了一些制作中的专长，不保证有效，建议等待完善
        
------------------------------------------- 
### [MysticalMayhem](https://gitgud.io/Kreaddy/mysticalmayhem)
> *前置：* 无<br>
> *中文：* **自带（需要QL汉化补全内容）**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 变体，专长，神话能力，法术等<br>
+ 增加了新内容， **自带中文！** 推荐
<table>
<tr><th colspan="4">新增内容列表</th></tr> 
<tr><td>类别</td>
       <td>选项</td>
       <td>描述</td>
       <td>房规</td></tr>
<tr><td rowspan="1">职业<br>Class</td>
	<td>邪术师<br>Warlock</td>
	<td>来自第三方内容，含变体。需要QL汉化</td>
	<td>:x:</td></tr>
<tr><td rowspan="5">变体<br>Archetype</td>
	<td>苦修者<br>Flagellant</td>
		<td>牧师变体，对自己造成伤害来获得CL或DC加成，适合施法者构建</td>
		<td>:heavy_check_mark:</td></tr>
	<tr><td>密契法师<br>Pact Wizard</td>
		<td>法师变体，失去奖励专长获得巫师庇护主和先知诅咒等能力</td>
		<td>:x:</td></tr>
	<tr><td>金袍法师<br>Gold-Robed Wizard</td>
		<td>法师变体，拥有类似圣武士的法术辟邪能力</td>
		<td>:x:</td></tr>
	<tr><td>拉兹密安牧师<br>Razmiran Priest</td>
		<td>非进阶职业，术士变体，失去部分血承能力换取消耗法术位来无限使用特定的魔杖和卷轴的能力</td>
		<td>:x:</td></tr>
	<tr><td>千军武神<br>Warsighted</td>
		<td>先知变体，获得额外战斗专长但是失去启示。</td>
		<td>:x:</td></tr>
<tr><td rowspan="7">专长<br>Feat</td>
	<td>魔学院毕业生<br>Acadamae Graduate</td>
		<td>当你施放一个当天已准备的具有召唤描述符的咒法系奥术法术时，将施法时间由整轮动作缩短为标准动作</td>
		<td>:x:</td></tr>
	<tr><td>大地魔法<br>Earth Magic</td>
		<td>当你处于你偏好的地形时，你的有效施法者等级提高1级</td>
		<td>:x:</td></tr>
	<tr><td>纯粹之罪<sup>注</sup><br>Purity of Sin</td>
		<td>当你施放属于你的塔西伦专精学派的法术时，你在施法者等级上获得+2加值</td>
		<td>:heavy_check_mark:</td></tr>
	<tr><td>学派专擅<sup>注</sup><br>School Expertise</td>
		<td>你的专精学派能力获得额外3次使用次数。你可以多次选取这项发现</td>
	       <td>:heavy_check_mark:</td></tr>
	<tr><td>类权杖魔杖<sup>注</sup><br>Staff-like Wand</td>
		<td>你通过魔杖施放的法术的DC使用你自己的智力和相关专长调整值，使用你的施法者等级</td>
		<td>:x:</td></tr>
  	<tr><td>巫师之刃<br>Witch Knife</td>
		<td>所有庇护主法术DC +1</td>
		<td>:x:</td></tr>
  	<tr><td>神通<br>Theurgy</td>
		<td>你能用奥术能量增强你的神术，也能用神力增强你的奥术。\n当你施展一个神术时，可以用迅捷动作牺牲一个同环级或者更高的奥术可用法术位或已准备的奥术，此神术的CL+1。反之亦然。</td>
		<td>:x:</td></tr>
<tr><td rowspan="2">魔战士奥秘<br>Magus Arcana</td>
	<td>秩序之环<br>Circle of Order</td>
		<td>以一个迅捷动作，消耗奥法池。在对抗混乱敌人时，AC获得等同于他魔战士等级的一半的闪避加值</td>
		<td>:x:</td></tr>
	<tr><td>恶意<br>Malice</td>
		<td>巫战士专用，近战攻击对任何正在受其巫术影响的敌人额外造成2d6点污邪伤害</td>
		<td>:heavy_check_mark:</td></tr>
<tr><td rowspan="1">奥术发现（TTT）</td>
	<td>信念魔法<br>Faith Magic</td>
		<td>获得信仰神祇的领域法术</td>
		<td>:x:</td></tr>
<tr><td rowspan="3">科研发现<br>Discovery</td>
	<td>生命灵药<br>Elixir of Life</td>
		<td>复活</td>
		<td>:x:</td></tr>
	<tr><td>永恒药水<br>Eternal Potion</td>
		<td>药剂持续时间变为永久，同时只能存在一个</td>
		<td>:x:</td></tr>
	<tr><td>法术知识<br>Spell Knowledge</td>
		<td>获取法师/术士列表上的法术</td>
		<td>:x:</td></tr>
<tr><td rowspan="2">神话能力<br>Mythic Ability</td>
	<td>充裕双法合璧<br>Abundant Spell Synthesis</td>
		<td>每有三个神话阶层，你可以额外使用一次双法合璧能力</td>
		<td>:heavy_check_mark:</td></tr>
	<tr><td>材料自由<br>Material Freedom</td>
		<td>选择一种特定的材料成分：你可以在不持有此材料成分的情况下施放某个通常需要它的法术</td>
		<td>:heavy_check_mark:</td></tr>
<tr><td rowspan="2">神话专长<br>Mythic Feat</td>
	<td>纯粹之罪（神话）<br>Purity of Sin (Mythic)</td>
		<td>纯粹之罪的额外加值现在也适用于法术的DC</td>
		<td>:heavy_check_mark:</td></tr>
	<tr><td>神话巫师之刃<br>Witch Knife（Mythic）</td>
		<td>你能够将巫师之刃作为所有你的巫师法术的额外器材成分，而不仅仅是庇护主法术，为其DC增加1。这个加值和巫师之刃对庇护主效果叠加。给予庇护主法术总计+2 DC。</td>
		<td>:x:</td></tr>
<tr><td rowspan="2">职业特性<br>Class Feature</td>
	<td>双法合璧<br>Spell Synthesis</td>
		<td>添加秘术师巅峰，10级时，秘术师可以使用一个动作施放两个法术</td>
		<td>:x:</td></tr>
	<tr><td>显圣<br>Manifestations</td>
		<td>添加萨满精魂巅峰，类似先知最终启示效果</td>
		<td>:x:</td></tr>
<tr><td rowspan="4">法术<br>Spell</td>
	<td>流星爆<br>Meteor Swarm</td>
		<td>流星爆是一个强力且壮观的法术，当你施放此法术时，四颗炽热的流星将坠落在你选定的区域，一旦它们到达地面就会爆炸，对该区域的所有生物造成28d6点火焰伤害</td>
		<td>:x:</td></tr>
	<tr><td>石肤（博德之门）<br>Baldur's Gate Stoneskin</td>
		<td><b>默认未开启</b><br>改变石肤法术，使其更接近[博德之门中的版本](https://baldursgate.fandom.com/wiki/Stoneskin)<br>此法术创造一层完全覆盖施法者的石制外壳。石肤当然是魔法的，不会妨碍到施法者。它可以抵御物理攻击，如近战武器和炮弹。施法者等级每提高2级，施法时会获得额外的石肤层数(到第20级时最多可获得10层石肤)。施法者每拥有一层石肤，该法术将抵御一次攻击。如果所有石肤都被移除，法术就会消散。需要注意的是，这并不能保护施法者免受任何能量或力场攻击</td>
		<td>:heavy_check_mark:</td></tr>
	<tr><td>精确施法<br>Staff-like Wand</td>
		<td>下个法术穿透法术抗力</td>
		<td>:x:</td></tr>
	<tr><td>血泪与利齿狞笑<br>Bloody Tears and Jagged Smile</td>
		<td>获得啮咬攻击、威吓和恐惧法术获得加成。</td>
		<td>:x:</td></tr>
</table>
注：如果同时安装了TTT，会成为奥术发现中的一种 
 
------------------------------------------- 
### [MythicArcanist](https://github.com/Llisandur/MythicArcanist)
> *前置：* 无<br>
> *中文：* **自带**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 变体，专长，神话能力，法术等<br>
+ 增加了新内容， **自带中文！** 推荐
  
<table>
<tr><th colspan="3">新增内容列表</th></tr> 

<tr><td rowspan="1">变体</td>
    <td>双持战士<br>Two-Weapon Warrior</td>
        <td>专精双持的战士变体</td></tr>
<tr><td rowspan="2">职业特性</td>    
    <td>博学士秘闻 - 圣武士法术</td>
        <td><b>房规原创</b><br>博学士可以学习圣武士法术</td></tr>
    <tr><td>奥能技艺 - 武术训练 / 高等武术训练</td>
        <td>为奥能师提供AB奖励</td></tr>
<tr><td rowspan="5">法术</td>    
    <td>力场护甲<br>Force Armor</td>    
        <td><b>第三方</b><br>类似虔诚护盾的奥术</td></tr>
    <tr><td>法师护甲 II / III / IV <br>Mage Armor II / III / IV </td>    
        <td><b>第三方</b><br>高级法师护甲，给予 +6/+8/+10 AC.</td></tr>
    <tr><td>高等魔法飞弹<br>Magic Missile, Greater</td>    
        <td><b>第三方</b><br>造成更高伤害的高级版魔法飞弹</td></tr>
    <tr><td><br>大师魔法飞弹</td>    
        <td><b>第三方</b><br>更高级的魔法飞弹，没有弹数上限</td></tr>
    <tr><td>护盾术 II<br>Shield II</td>    
        <td><b>第三方</b><br>高级版护盾术，视为塔盾并持续更久</td></tr>
<tr><td rowspan="3">神话能力</td>    
   <td>充裕备法<br>Abundant Preparation</td>
        <td><b>房规原创</b><br>类似充裕施法，为奥能师提供额外1到3级法术准备位</td></tr>
   <tr><td>高等充裕备法<br>Improved Abundant Preparation</td>
        <td><b>房规原创</b><br>为奥能师提供额外4到6级法术准备位</td></tr>
   <tr><td>精通充裕备法<br>Greater Abundant Preparation (Homebrew)</td>
        <td><b>房规原创</b><br>为奥能师提供额外7到9级法术准备位</td></tr>
</table>
  
------------------------------------------- 
### [ChampionFeatsAnew](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/384)
> *前置：* 无<br>
> *中文：* **自带**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* "冠军"专长<br>

**注意！本MOD在最新版本尚未测试**
+ 增加一系列原创"冠军"专长，挺强的  
  
------------------------------------------- 
### [KineticistElementsExpanded](https://github.com/SpencerMycek/KineticistExpandedElements)
> *前置：* 无<br>
> *中文：* **自带**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 操念使元素<br>
 为操念使加入Aether 以太、Void 虚空、Wood 木三种元素
  <table>  
  <tr><th colspan="4">新增内容列表<br></th></tr> 
  <tr><th colspan="22">以太 Aether<br></th></tr>
  <td rowspan="2">护身原力 Defense Wild Talents</td></tr>
       <tr><td>力场结界 Force Ward<br>你获得临时生命值，数值等同于你的操念使等级。这些临时生命值会以每分钟1点的速度进行再生。通过以标准动作承受1点超载，你能够让力场结界提供的临时生命值上限得到提升，提升的量为你的操念使等级的一半，直至你所承受的超载得以移除为止。若你重复使用该能力，那么对此上限的提升会进行叠加。你以此方式承受2点超载时，力场结界的再生速率便会增加每分钟1点。</td></tr>
  <tr><td rowspan="2">简易念袭 Simple Blasts</td></tr>
       <td colspan="2">念动 Telekinetic Blast 超载: 0 念袭性质：物理；伤害类型：钝击、穿刺或挥砍</td></tr>
  <td rowspan="4">复合念袭 Composite Blasts</td></tr>
       <td>力场弹 Force Blast 超载: 3 前置：首要元素（以太），元素扩展（以太）念袭性质：能量 伤害类型: 力场</td></tr>
           <tr><td>以太增压 Aetheric Boost 超载: 2 前置: 念动，任意简易念袭 念袭性质：特殊<br>你将以太灌注到自己所掌握的简易念袭中，使得这个简易念袭的每个伤害骰额外多造成1点相同类型的伤害；它在其他方面如同简易念袭一般生效。</td></tr>
           <tr><td>高等以太增压 Aetheric Boost, Greater 超载: 3 前置: 念动，任意简易念袭 念袭性质：特殊<br>你将以太灌注到自己所掌握的复合念袭中，使得这个简易念袭的每个伤害骰额外多造成1点相同类型的伤害。</td></tr>
  <td rowspan="5">注能原力 Infusion Wild Talents</td></tr>
       <td>抛敌 Foe Throw 类别: 塑形注能 等级: 3 超载: 2 关联念袭类别: 念动 豁免: 强韧，通过则无效<br>你的念动能够投掷大型或更小的生物，以取代无主物体；你能够增加1点超载来影响具有更大体型的生物。若你尝试用来投掷的生物成功通过强韧豁免，那么它可以免受整个念袭的影响。否则当你的念袭命中时，被投掷的生物和目标均会承受来自念动的全额伤害，被投掷的生物还会俯卧在沿着投掷路径上最后一个可占据空间里。若你的念袭未命中，被投掷的生物能够选择占据目标周围30尺内的任意空间，它不会倒地，而且它仅会由你的念袭承受正常伤害的一半。投掷期间进行的移动不会引起藉机攻击。</td></tr>
           <tr><td>力场钩 Force Hook 类别: 塑形注能 等级: 3 超载: 2 关联念袭类别: 力场弹 豁免: 无<br>你的力场弹会勾住目标，并将你拽到向目标旁边。</td></tr>
           <tr><td>多重念动 Many Throw 类别: 塑形注能 等级: 6 超载: 4 前置：增距 关联念袭类别: 念动 豁免: 无<br>你能够使用你的念动做出攻击检定对抗120尺内的复数目标，数量等同于你的操念使等级，但是任意两个目标之间的距离不得超过30尺。</td></tr>
           <tr><td>分解注能 Disintegrating Infusion 类别: 性质注能 等级: 6 超载: 4 关联念袭类别: 力场弹 豁免: 强韧，通过则部分生效<br>在对抗生物时，你的念袭造成两倍于正常伤害的数值，但是目标可以进行豁免来使伤害降低至正常数值的一半（对于增强后的念袭伤害总量来说为四分之一）。任何生命值被念袭降低至0点以下的生物会被完全分解，就如同解离术一般。</td></tr>
  <tr><td rowspan="8">通用原力 Utility Wild Talents</td></tr>
       <td colspan="2">念动戏法 Telekinetic Finesse 等级：1；超载：0<br>一名心灵操念使可以再30尺范围内远程使用巧手</td></tr>	
       <td colspan="2">念动遁形 Telekinetic Invisibility 等级：3；超载：0<br>这相当于隐身，除了念动遁形比普通隐身更容易被发现，所以你的隐身检定加成减半(移动时+10，静止时+20)。</td></tr>	 
       <td colspan="2">念力御身 Self Telekinesis 等级：3；超载：0<br>你可以使用念动能力搬运自己。这项原力在其他方面的功能就如同火焰喷进（flame jet）一般。</td></tr>	 
       <td colspan="2">念动战技 Telekinetic Maneuvers 等级：4；超载：0<br>你能够以心灵念力执行战技，但是你会使用操念使主要属性来判断战技加值。若你具有念动戏法原力，则可以将阴招和盗取战技加到你能够执行的战技列表中；当你执行这些战技时，使用敏捷调整值来判断战技加值。</td></tr>	
       <td colspan="2">高等念力御身 Self Telekinesis, Greater 等级：5；超载：0<br>在使用念力操控自身这方面，你获得了更强的掌控力。这项原力在其他方面的功能就如同高等火焰喷进（flame jet，greater）一般。</td></tr>	 
       <td colspan="2">反射性感知域 Touchsite，Reactive 等级：5；超载：0<br>角色可以对即将到来的危险做出反应。即使攻击者不可见，角色也不会失去敏捷ac加值。如果角色被固定，他仍然会失去敏捷ac加值。如果对手使用佯攻并且成功，角色如常失去敏捷加值。</td></tr>	
       <td colspan="2">法术偏转 Spell Deflection 等级：7；超载：0<br>直到你的下一回合开始，获得等于10 +你的操念使等级的法术抗性。你可以接受1点超载，增加持续时间到10分钟每你拥有的操念使等级。</td></tr>	
  <tr><th colspan="25">虚空 Void<br></th></tr>
  <td rowspan="2">护身原力 Defense Wild Talents</td></tr>
       <tr><td>空寂 Emptiness<br>你获得2点负能量抗力，5%的机率忽视重击和偷袭，并且在对抗情绪效果的意志豁免上获得+1加值。通过承受1点超载，你可以增加2点负能量抗力，忽视重击和偷袭的机率提高5%，并且对抗情绪效果的意志豁免加值增加1，直至你所承受的超载得以移除为止。</td></tr>
  <tr><td rowspan="3">简易念袭 Simple Blasts</td></tr>
       <td colspan="2">重压 Gravity Blast 超载: 0 念袭性质：物理；伤害类型：钝击</td></tr>
       <td colspan="2">负能 Negative Blast 超载: 0 念袭性质：能量；伤害类型：负能量</td></tr>
  <td rowspan="5">复合念袭 Composite Blasts</td></tr>
       <td>虚无力 Void Blast 超载: 2 前置：首要元素（虚空），元素扩展（虚空）念袭性质：物理 伤害类型: 一半钝击，一半负能量</td></tr>
           <tr><td>负能混爆 Negative Admixture 超载: 2 前置: 负能，任意简易念袭 念袭性质：特殊<br>选择你所知的另一个简易念袭击。负能混爆的伤害一半为负能量，一半为你所选择念袭的类型。</td></tr>
           <tr><td>重压推进 Gravitic Boost 超载: 2 前置: 重压，任意简易物理念袭 念袭性质：特殊<br>将重压加入到一个简易物理念袭中，将伤害骰从d6增加到d8；在其他方面则如同简易念袭一般造成伤害。</td></tr>
           <tr><td>高等重压推进 Gravitic Boost, Greater 超载: 3 前置: 重压，任意复合物理念袭 念袭性质：特殊<br>你将重压加入到一个复合物理念袭中，将伤害骰从d6增加到d8；在其他方面则如同简易念袭一般造成伤害。</td></tr>
  <td rowspan="8">注能原力 Infusion Wild Talents</td></tr>
       <td>障目注能 Dampening Infusion 类别: 性质注能 等级: 1 超载: 1 关联念袭类别: 负能，虚无力 豁免: 意志<br>你的念袭携带有黑暗的力量，使你更难被看到，如同炫目注能。</td></tr>
           <tr><td>拉行注能 Pulling Infusion 类别: 性质注能 等级: 1 超载: 1 关联念袭类别: 重力，虚无力 豁免: 无<br>你的念袭将敌人拽向你这边。尝试一次拖拽战技检定对抗每个被你的注能念袭伤害的目标（此注能只能使敌人靠近你），使用你的体质调整值替代你的力量调整值来确定战技检定的加值。</td></tr>
           <tr><td>加重注能 Weighing Infusion 类别: 性质注能 等级: 2 超载: 2 关联念袭类别: 重力，虚无力 豁免: 反射，通过则无效<br>该注能如同纠缠注能（Entangle Infusion），除了该注能通过增加目标的重量来令其纠缠（entangle）与无法移动（immobilize），而不是通过元素物质缠绕敌人。</td></tr>
           <tr><td>恐吓注能 Unnerving Infusion 类别: 性质注能 等级: 3 超载: 2 关联念袭类别: 负能，虚无力 豁免: 意志，通过则无效<br>每当念袭对敌人产生负能量伤害是，敌人进入战栗1轮。</td></tr>  
           <tr><td>奇点 Singularity 类别: 塑形注能 等级: 4 超载: 3 关联念袭类别: 重压，负能，虚无力 豁免: 强韧，通过则减半<br>选择30尺内的一个网格交点，所有在交点中心5尺半径爆发范围内的生物和物体受到相当于念袭正常伤害的四分之一的伤害（负能量则为一半伤害）。在你的下一回合，奇点造成伤害的范围变成10尺半径爆发；再往后一回合，其造成伤害的范围变成15尺半径爆发。该豁免DC基于敏捷。</td></tr>
	  <tr><td>吸血注能 Vampiric Infusion 类别: 性质注能 等级: 5 超载: 3 前置: 念力医者 关联念袭类别: 负能，虚无力 豁免: 无<br>如果你的念袭命中敌人（或者对你的念袭豁免失败），你使用的下一个念力医者无须承受超载。</td></tr>
	  <tr><td>衰弱注能 Enervating Infusion 类别: 性质注能 等级: 7 超载: 4 前置：增距 关联念袭类别: 负能，虚无力 豁免: 强韧，通过则无效<br>你每当注能念袭对敌人造成伤害时，同时使其获得1个临时负向等级。由此注能造成的负向等级会在24小时后被移除，并且永远不会成为永久负向等级。</td></tr>
  <tr><td rowspan="7">通用原力 Utility Wild Talents</td></tr>
       <td colspan="2">虚空医者 Void Healer 等级：1；超载：1<br>此能力如同念力医者般生效，除了它被用于治疗不死生物（以及其他受到负能量治疗的生物）。</td></tr>	
       <td colspan="2">束缚亡灵 Undead Grip 等级：3；超载：1 豁免: 意志 法术抗力: 可<br>该原力如同束缚元素，除了它作用于单个不死生物，如同死灵定身术</td></tr>
       <td colspan="2">重力控制 Gravity Control 等级：3；超载：0 前置: 空寂<br>你可以就如同火焰喷进一般操控重力移动自身。</td></tr>	 
       <td colspan="2">高等重力控制 Gravity Control, Greater 等级：3；超载：0 前置: 空寂<br>你对重力的操作更进一步。这项原力在其他方面的功能就如同高等火焰喷进。</td></tr>	
       <td colspan="2">尸体傀儡 Corpse Puppet 等级：4；超载：1<br>你使用负能量来以丧尸或者快速丧尸（由你选择）的形式驱动一个附近的尸体。 该能力同操作死尸</td></tr>	
       <td colspan="2">破除诅咒 Curse Breaker 等级：4；超载：1 前置: 空寂<br>你在对抗诅咒和巫术的豁免上获得+4加值。你可以额外承受1点超载，通过一个标准动作，尝试一次施法者等级检定来移除一个你自己或者其他目标身上的诅咒，如同移除诅咒。</td></tr>	
  <tr><th colspan="24">木 wood<br></th></tr>
  <td rowspan="2">护身原力 Defense Wild Talents</td></tr>
       <tr><td>木身 Flesh of Wood<br>你在你已有的天生防御上获得+1增强加值。通过承受1点超载，你可以将增强加值再提升1点。在2级后的每3级，你可以额外承受1点超载从而进一步将增强加值提升1点（最多在20级达到+7）。</td></tr>
  <tr><td rowspan="3">简易念袭 Simple Blasts</td></tr>
       <td colspan="2">正能量袭 Positive Blast 超载: 0 念袭性质：能量；伤害类型：正能量</td></tr>
       <td colspan="2">木袭 Wood Blast 超载: 0 念袭性质：物理；伤害类型：钝击、穿刺或挥砍</td></tr>
  <td rowspan="7">复合念袭 Composite Blasts</td></tr>
       <td>藤花乱舞 Verdant Blast 超载: 2 前置：首要元素（木），元素扩展（木）念袭性质：物理 伤害类型: 钝击, 挥砍，穿刺，以及可选正能量<br>藤花乱舞的伤害只有在对你有益的时候才算正能量。</td></tr>
           <tr><td>拂春风 Spring Blast 元素：气和木 超载: 2 前置: 突风，木袭 念袭性质：物理 伤害类型: 钝击, 穿刺或者挥砍</td></tr>
           <tr><td>通夏火 Summer Blast 元素：火和木 超载: 2 前置: 火冲，木袭 念袭性质：物理 伤害类型:一半火焰，一半钝击, 挥砍或者穿刺</td></tr>
           <tr><td>起秋尘 Autumn Blast 元素：土和木 超载: 2 前置: 岩击，木袭 念袭性质：物理 伤害类型: 钝击, 挥砍，穿刺中的任意两种</td></tr>
           <tr><td>漫冬雪 Winter Blast 元素：水和木 超载: 2 前置: 霜打，木袭 念袭性质：物理 伤害类型: 一半寒冷，一半钝击, 挥砍或者穿刺</td></tr>
           <tr><td>正能混爆 Winter Blast 超载: 2 前置: 正能量念袭, 任何其他简易能量念袭 念袭性质：能量 伤害类型: 选择另外一种你所知的简易能量念袭。正能量混合的伤害一半为正能量伤害，另一半为所选念袭类型。</td></tr>
  <td rowspan="4">注能原力 Infusion Wild Talents</td></tr>
       <td>萃毒注能 Toxic Infusion 类别: 性质注能 等级: 4 超载: 3 关联念袭类别: 拂春风，通夏火，起秋尘，漫冬雪，木袭 豁免: 强韧，通过则无效<br>所有从你的念袭中受到挥砍或穿刺伤害的生物都会恶心1轮。</td></tr>
           <tr><td>孢子注能 Spore Infusion 类别: 性质注能 等级: 5 超载: 2 关联念袭类别: 拂春风，通夏火，起秋尘，漫冬雪，木袭 豁免: 强韧，通过则无效<br>你任何在你的念袭中承受挥砍和穿刺伤害的生物会受到植物和孢子的感染。如果目标在强韧豁免中失败，每轮承受1d6伤害，持续10轮。在该时间结束时，目标会受到pulsing puffs的影响。</td></tr>
	   <tr><td>高等萃毒注能 Toxic Infusion, Greater 类别: 性质注能 等级: 7 超载: 3 前置：萃毒注能 关联念袭类别: 拂春风，通夏火，起秋尘，漫冬雪，木袭 豁免: 强韧，通过则无效<br>当你使用此注能的时候，所有从你的念袭中受到挥砍或穿刺伤害的生物都会暴露在毒性之下，造成1d2体质伤害。</td></tr>
  <tr><td rowspan="8">通用原力 Utility Wild Talents</td></tr>
       <td colspan="2">草木医者 Wood Healer 等级：1；超载：1 前置: 正能量念袭<br>如同念力医者，但是你必须令你的治疗量基于你的正能量念袭，而不是木念袭。可以替代念力医者作为其他通用原力的先决条件。</td></tr>	
       <td colspan="2">木行术 Woodland Step 等级：1；超载：0<br>你可以在困难地形中以正常速度移动，而不受任何伤害或者其他损害。</td></tr>	 
       <td colspan="2">棘肤 Thorn Flesh 等级：3；超载：1 前置: 木身<br>你将荆棘覆于皮肤之上，以此伤害那些敢于攻击你的敌人。此能力如同锯齿皮肤。</td></tr>	 
       <td colspan="2">解毒草药 Herbal Antivenom 等级：8；超载：0<br>在对抗毒素时，你在豁免检定上获得+5炼金加值，如同受到抗毒剂的影响。此外，你的医疗知识使你的学识：宗教获得+5加值。</td></tr>	
       <td colspan="2">野性生长 Wild Growth 等级：8；超载：0<br>你能够用生命的能力滋长植物，以此阻碍你的敌人。在效果开始时位于范围内或者进入生效范围的生物须进行反射豁免，失败则被纠缠，成功则可以正常移动。被纠缠的生物每回合可使用战技、灵巧或者运动检定尝试挣脱纠缠。效果持续时，整个区域被认为时困难地形。</td></tr>
	<td colspan="2">竖木为兵 Wood Soldiers 等级：8；超载：1<br>你召唤四个木魔像，持续到你下次恢复超载。如果你有春、夏、秋或冬的冲击波，你的魔像将获得独特的升级。如果你拥有起秋尘（Autumn Blast），你的魔像获得物理伤害抗性。如果你拥有拂春风（Autumn Blast），你的魔像获得飞行。如果你拥有通夏火（Summer Blast），你的魔像获得火焰抗性，并在所有攻击中额外造成1d6的火焰伤害。如果你拥有漫冬雪（Winter Blast），你的魔像获得寒冷抗性，并在所有攻击中额外造成1d6的寒冷伤害。</td></tr>		 
       <td colspan="2">战争之林 Forest Siege 等级：9；超载：1<br>这个能力每三个操念使等级影响一个植物。在消耗超载后激活此技能，直到下次你的超载被移除。你可以花一个标准动作使附近的植物像重型投石器一样，向选定的目标投掷石块，如果他们击中目标，造成6d6的钝击伤害。</td></tr>	

       	 

 </table>  
      
------------------------------------------- 
### [Madison'sMetagaming](https://github.com/madisoncfallin/MadisonsMetagaming)
> *前置：* 无<br>
> *中文：* **无**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 专长<br>
+ 目前只加入了一个专长Fey Foundling
        
------------------------------------------- 
### [NinjaClass](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/233)
[2.10汉化发布贴](https://tieba.baidu.com/p/8303652146?qq-pf-to=pcqq.c2c)
> *前置：* 无<br>
> *中文：* **汉化**<br>
> *安装方式：* **非UMM**<br>
> *修改内容：* <br>
> *新增内容：* 忍者职业<br>
+ 加入了Ninja 忍者职业，较久没有更新
+ **注意！本MOD已经被合并进Homebrew Archtypes MOD。由于该mod有拖慢载入等问题，建议直接使用Homebrew Archtypes**
<table>  
<tr><th colspan="2">新增内容列表<br></th></tr> 
  <tr><td rowspan="4">职业及变体</i></td>
       <td>忍者 Ninja</td></tr>
       <tr><td> - 轩猿众 Nokizaru</td></tr>
       <tr><td> - 千面狐 Formless Ninja</td></tr>
       <tr><td> - 火影忍者 Rappa</td></tr>
 </table>  
          
------------------------------------------- 
### [BrawlerClass](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/207)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 拳师职业<br>
+ 加入了Brawler 拳师职业。原发布页已经更新了2.10版本<br>
+ **已有汉化**，通过QL挂载<br>
<table>  
<tr><th colspan="2">新增内容列表<br></th></tr> 
  <tr><td rowspan="9">职业及变体</i></td>
       <td>拳师 Brawler</td></tr>
       <tr><td> - 毒拳士 Venomous Fist</td></tr>
       <tr><td> - 野性之子 Wild Child</td></tr>
       <tr><td> - 蛇咬击士 Snakebite Striker</td></tr>
       <tr><td> - 断钢拳士 Steel-Breaker</td></tr>
       <tr><td> - 地头蛇 Turfer</td></tr>
       <tr><td> - 搏兽士 Beast Wrestler</td></tr>
       <tr><td> - 教头 Exemplar</td></tr>
       <tr><td> - 变异狂徒 Mutagenic Mauler</td></tr>
 </table>  
               
-------------------------------------------   
### [WOTR_PATH_OF_BLING](https://github.com/Balkoth-dev/WOTR_PATH_OF_BLING)
### [WOTR_PATH_OF_HELL](https://github.com/Balkoth-dev/WOTR_PATH_OF_HELL)
### [WOTR_PATH_OF_RAGE](https://github.com/Balkoth-dev/WOTR_PATH_OF_RAGE)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 道途重做<br>
+ 同一作者的三个MOD，分别重做了金龙、魔鬼、恶魔三个比较被人诟病的道途
+ 其中恶魔几乎完全重做，比较有趣  
         
-------------------------------------------   
### [WorldCrawl](https://www.moddb.com/mods/worldcrawl-core/downloads)
> *前置：* 无<br>
> *中文：* **无**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 海量<br>
+ 超大型MOD，对游戏多方面进行了调整，几乎成为了全新游戏
+ 大量的平衡性调整，并对游戏的遭遇和掉落进行了随机  
+ 改动文档就有4M大...  
+ 和其他MOD可预见的兼容性差，游戏本体更新后可能问题也比较多
+ 笔者没有尝试过，玩家可以自行尝试
         
-------------------------------------------   
### [AlternateHumanTraits](https://github.com/microsoftenator2022/AlternateHumanTraits)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 人类替换种族特性<br>
+ 提供来自规则书的人类可选替换种族特性
> 重写版：[AlternateRacialTraits](https://github.com/microsoftenator2022/AlternateRacialTraits)
> 功能一致，优化了代码，但是也不能使用双重天赋获得任意属性+4了，可自行选用
<table>  
 <tr><th colspan="3">新增内容列表<br></th></tr> 
  <tr><td rowspan="10">种族特性</i></td>
       <td>Adoptive Parentage</td>
          <td>养子：选择一种不具备人类亚种的种族。你使用该种族的起始语言以及【武器熟悉】种族特性。如果该种族没有武器熟悉，获得一种和该种族风格相符的“技能专攻”或者“武器专攻”。本特性替换人类的奖励专长</td></tr>
       <tr><td>Awareness</td>
          <td>洞察：在所有的豁免检定和专注检定上获得+1种族加值。本特性替换人类的奖励专长</td></tr>
       <tr><td>Comprehensive Education</td>
          <td>素质教育：将所有知识技能视为本职技能，并在所有他们通过职业等级获得作为本职技能的知识技能检定上获得+1种族加值。本特性替换奖励技能</td></tr>
       <tr><td>Dual Talent</td>
          <td>双重天赋：选择两种属性获得+2种族加值。这个种族特性取代单项属性+2，奖励专长以及奖励技能</td></tr>
       <tr><td>Focused Study</td>
          <td>精研：在1级、8级以及16级时，选择一项技能，获得该技能的“技能专攻”专长。这个种族特性取代奖励专长</td></tr>
       <tr><td>Giant Ancestry</td>
          <td>巨人祖先：+1战技检定和CMD，-2潜行，这个种族特性取代奖励技能</td></tr>
       <tr><td>History Of Terrors</td>
          <td>壮胆：同同名专长，不能同时选择这个特性和对应专长，这个种族特性取代奖励技能</td></tr>
       <tr><td>Military Tradition</td>
         <td>战斗民族：根据他们的所属文化群体获得最多两件军用或异种武器的擅长。本特性替换人类的奖励专长</td></tr>
       <tr><td>Practiced Hunter</td>
         <td>老练猎手：在潜行和生存检定上获得+2种族加值，并且潜行和生存被他们视为本职技能。本特性替换奖励技能</td></tr>
       <tr><td>Unstoppable Magic</td>
         <td>法力澎湃：在穿透法术抗力的施法者等级检定上获得+2种族加值。本特性替换人类的奖励专长</td></tr>
  </table>
  
  -------------------------------------------   
### [WOTR_IsekaiMod](https://github.com/JohN100x1/WOTR_IsekaiMod)
> *前置：* 无<br>
> *中文：* **自带中文（机翻），提供QL用修正（By 无望的灰烬）**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 人类替换种族特性<br>
+ **极端不平衡imba警告**
+ 提供新职业“异世界主角”及其变体，还有相关的专长、神祗等
+ 大量动漫NETA
+ 都是异世界主角了，能有多离谱你们自己想象下

  -------------------------------------------   
### [Way-of-the-shield](https://github.com/ScaredKurufinve/Way-of-the-shield)
> *前置：* ModMenu<br>
> *中文：* **自带中文（本人维护）**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* 夹击规则<br>
> *新增内容：* 变体、专长<br>
+ **注意！本MOD原更新网址不适用于新版，请在本页面右侧下载重编译版**
+ 提供了还原桌面规则的夹击功能
+ 提供了盾牌的原创规则
+ 提供了新变体和专长
+ 笔者提供汉化，现已提交到原作者处合并
<table>
 <tr><th colspan="4">新增内容列表<br></th></tr> 
  <tr><td rowspan="2">变体</i></td>
      <td>Sacred Shield</td>
      <td>圣盾卫</td>
          <td>专精于保护队友的圣武士防御性变体</td></tr>
      <td colspan="2">其它</td>
          <td>擅长盾牌不再包括小圆盾</td></tr>
  <tr><td rowspan="2">桌面规则</i></td>
      <td>Soft Cover</td>
      <td>软掩蔽</td>
     	  <td>加入桌面规则中由于软掩蔽导致的AC加值</td></tr>
      <td>Flanking</td>
      <td>夹击</td>
          <td>修改夹击规则和桌面相同，要求计算夹角</td></tr>
   <tr><td rowspan="1">原创规则</i></td>
      <td>Backstab</td>
      <td>背刺</td>
     	  <td>背后攻击可以无视对方盾牌、获得隐蔽加值，甚至视为完全隐蔽（视同对方措手不及），可在选项中调节</td></tr>
  <tr><td rowspan="11">专长</i></td>
      <td>Shield Brace</td>
      <td>盾牌支撑</td>
          <td>使用盾牌同时可以单手使用长柄类武器</td></tr>
      <td>Unhindering Shield</td>
      <td>自由之盾</td>
          <td>使用小圆盾视为空手</td></tr>
      <tr><td>Light Shield Parry</td>
      <td>轻盾格挡</td>
          <td>使用轻盾格挡攻击</td></tr>
      <tr><td>Upsetting Shield Style<br>Upsetting Strike<br>Upsetting Vengeance</td>
      <td>盾扰流派<br>盾扰强击<br>盾扰回击</td>
          <td>小圆盾系列专长，使用小圆盾盾击，造成对方攻击减值，并在对方攻击失手后对其借机攻击</td></tr>
      <tr><td>Immediate Repositioning</td>
      <td>瞬间换防</td>
          <td>塔盾专精斗士能力，迅捷动作改变塔盾方向</td></tr>
      <tr><td>Phalanx Formation</td>
      <td>集团方阵</td>
          <td>你使用擅长的长触及武器时，盟友不会为你攻击的敌人提供软掩蔽</td></tr>
      <tr><td>Improved Outflank</td>
      <td>精通包抄</td>
          <td>降低夹击所需最小角度</td></tr>
      <tr><td>Friendly Fire Maneuvers</td>
      <td>友军火力</td>
          <td>有该专长的敌人不会为敌人提供对你的软掩蔽，对你释放区域型法术时你获得反射豁免加值</td></tr> 
      <tr><td>Back To Back</td>
      <td>背靠背</td>
          <td>针对背刺规则调整背靠背效果</td></tr>
      <tr><td>Improved Back To Back</td>
      <td>精通背靠背</td>
          <td>加强背靠背专长，背刺规则下效果变更</td></tr>
      <tr><td>Mounted Combat</td>
      <td>骑乘战斗</td>
          <td>骑乘战斗下可以单手持矛</td></tr>
   <tr><td rowspan="3">特殊能力</i></td>
      <td>BucklerParry</td>
      <td>擅长小圆盾（圆盾格挡）</td>
          <td>使用小圆盾格挡攻击，但是会受到双武器减值</td></tr>
      <tr><td>Tower Shield Defense</td>
      <td>塔盾防御姿态</td>
          <td>躲在塔盾后方。面对正面攻击获得完全掩蔽</td></tr>
      <tr><td>Shielded Defense</td>
      <td>盾牌防御</td>
          <td>获得额外盾牌AC但是受到双武器减值</td></tr>
    <tr><td rowspan="2">神话专长</i></td>
      <td>Shielded Defense, Mythic</td>
      <td>神话盾牌防御</td>
          <td>使用盾牌防御时，每第二次攻击才会降低其AC加值</td></tr>
      <tr><td>Buckler Parry, Mythic</td>
      <td>神话圆盾格挡</td>
          <td>增加圆盾格挡次数</td></tr>
</table>

-------------------------------------------   
### CyniikalBrokenFeatures
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 法师学派：虚<br>
+ 增加了法师的虚学派
+ 原发布在Discord，本文档[Release页面](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/releases)处有临时下载

-------------------------------------------   
### 重装魔战
> *前置：* 无<br>
> *中文：* **自带中文**<br>
> *安装方式：* **非UMM**<br>
> *新增内容：* 魔战士变体：重装魔战<br>
+ 正义之怒群友自制，增加魔战士新变体重装魔战。本文档[Release页面](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/releases)处可下载，注意非UMM安装

-------------------------------------------   
### [CompanionAscension](https://github.com/WraithJT/CompanionAscension)
> *前置：* 无<br>
> *中文：* **暂无**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 同伴神话能力<br>

**注意！本MOD在最新版本尚未测试**
+ 为同伴增加额外神话特性（在神话4和神话8获取）


<table>
 <tr><th colspan="4">新增内容列表<br></th></tr> 
  <tr><td rowspan="3">神话4</i></td>
		    <td colspan="3">选择一个神话英雄奖励（无拘乐器等）</td></tr>
		<tr><td colspan="3">选择一个奖励专长、神话能力，或者神话专长</td></tr>
		<tr><td colspan="3">给予同伴无视职业阵营限制的能力（如同主角效果）<br>
				- 只能重新激活阵营限制的职业特性和能力<br>
				- 并不能允许提升阵营限制的职业等级<br>
				- 目前只能影响一个同伴</td></tr>
  <tr><td rowspan="12">神话8</i></td>
		<td colspan="3">选择一个奖励专长、神话能力，或者神话专长</td></tr>
		<tr><td rowspan="11">其他选项<br>取决于主角道途</td>
			    <td>默认选项</td>
				<td>神话身心：提升你最高的物理属性、最高的精神属性、最低的豁免</td></tr>
			<tr><td>御衡</td>
				<td>御衡破敌：仅基础能力，无后续提升<br>
				    御衡者免疫：为同伴获取第二项（神话9获得第三项）御衡者免疫</td></tr>
			<tr><td>天使</td>
				<td>天堂宝剑：仅基础能力，无后续提升<br>
				    天使之伴：为同伴提供多种天界生物模板的特性</td></tr>
			<tr><td>灵使</td>
				<td>选取一项超然之力</td></tr>
			<tr><td>恶魔</td>
				<td>恶魔狂怒：仅基础能力，无后续提升<br>
				    恶魔降临：仅基础能力，无后续提升<br>
				    恶魔之相：选择2个恶魔之相或者1个高等恶魔之相的被动效果</td></tr>
			<tr><td>巫妖</td>
				<td>巫妖之力：选取一项巫妖之力<br>
				    亡灵之伴：为同伴提供亡灵生物模板</td></tr>
			<tr><td>诡计</td>
				<td>选取一项1级的神话诡计</td></tr>
			<tr><td>魔鬼<br>（仍在构建和平衡）</td>
				<td>戴玛维嘎契约：提升敏捷、魅力、法术和近战范围<br>
				    深狱炼魔契约：提升力量、感知、AC、豁免和法术抗力<br>
				    燔祭魔契约：提升体质、智力，增加法术伤害和武器上的混乱异界生物破敌</td></tr>
			<tr><td>金龙</td>
				<td>选择两项金龙专长（另一项在神话9）<br>
				    金龙防御：获取免疫、能量抗性、豁免加值和翅膀<br>
				    金龙力量：增加所有属性到最低14，增加最高属性，所有武器被视为+5增强</td></tr>
			<tr><td>传奇<br>（仍在构建和平衡）</td>
				<td>传奇属性：增加所有属性值2<br>
				    传奇之伴：允许所有同伴等级提升到24</td></tr>
			<tr><td>虫群</td>
				<td>你特喵的还有同伴？啥都没！</td></tr>
  </table>

-------------------------------------------   
### [SwashbucklerWOTR](https://github.com/novumvita/SwashbucklerWOTR)
> *前置：* 无<br>
> *中文：* **汉化已提交**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 游荡剑客<br>
+ 增加基础职业游荡剑客
 <table>
 <tr><th colspan="3">新增内容列表<br></th></tr> 
  <tr><td rowspan="1">职业</i></td>
       <td>游荡剑客</td>
          <td>变体<br> - 灵感之刃<br> - 灵使剑客<br> - 花间诗剑<br> - 雷斯兰暴徒</td></tr>
  <tr><td rowspan="11">专长</i></td>
       <td>Feint 虚招</td>
          <td>你能够尝试使用移动动作对对手发动虚招。使用虚招时，进行一次唬骗技能检定，虚招的DC为“10+目标BAB+感知修正”。如果你成功地使用了虚招，目标将在对抗你的下一次近战攻击时或者直到其下一轮前（取较先发生者），无法在AC上获得自己的敏捷加值。</td></tr>
	<tr><td>Greater Feint 高等虚招</td>
          <td>当你使用虚招使得敌人失去其AC上的敏捷加值时，效果持续到其下一轮。</td></tr>
	<tr><td>Swordplay Style 刺剑流</td>
          <td>当你开启此流派架势时，如果你持有重刃或轻刃战士武器组中的武器，进行防御式战斗或使用寓守于攻时，那么你会在防御等级上获得+1盾牌加值。除此之外，你在使用寓守于攻专长时每轮发动的第一次近战攻击不会因为使用寓守于攻而承受减值。你本轮的其他攻击，包括藉机攻击，仍然会承受正常减值。</td></tr>
	<tr><td>Swordplay Upset 刺剑闪</td>
          <td>当开启刺剑流架势时，你可以在一个敌人对你近战攻击失手时对他发动一次虚招。</td></tr>
	<tr><td>Spring Attack 跳跃攻击</td>
          <td>以一个全回合动作，你能够移动至多等同于你速度的距离并做一次单次的近战攻击，这不会引发你所攻击目标的借机攻击。你在攻击之前和之后都可以移动，但你在攻击前必须至少移动10尺，并且你移动的总距离不可以超过你的速度。你不可以使用此能力攻击在你回合开始时就和你相邻的敌人。</td></tr>
	<tr><td>Improved Spring Attack 精通跳跃攻击</td>
          <td>使用跳跃攻击时，你可以选择在移动中攻击两个目标而不是一个。使用这个方式进行的第二次攻击使用你的全部基础攻击加值-5。所有跳跃攻击的限制对两个都目标有效，且你的移动不会引发这两个目标的借机攻击。你不能选择同一个目标两次。</td></tr>
	<tr><td>Greater Spring Attack 高等跳跃攻击</td>
          <td>使用跳跃攻击时，你可以选择在移动中攻击三个目标而不是一个。使用这个方式进行的第二次攻击使用你的全部基础攻击加值-5，第三次攻击使用你的全部基础攻击加值-10。所有跳跃攻击的限制对每个目标都有效，且你的移动不会引发这些目标的借机攻击。你不能选择同一个目标多于一次。</td></tr>
	<tr><td>Spring-Heeled Reaping 跃击收割</td>
          <td>你可以在跳跃攻击中应用要害打击效果。如果你拥有精通要害打击或高等要害打击，则改为应用对应效果。</td></tr>
	<tr><td>Seize the Opportunity 把握良机</td>
          <td>当你做出借机攻击时，你可以应用要害打击。</td></tr>
	<tr><td>Wind Stance 疾风步</td>
          <td>若你在一轮中移动超过10尺，则该轮中你针对远程攻击获得20％隐蔽。</td></tr>
	<tr><td>Lightning Stance 闪电步</td>
          <td>若你在一轮中移动超过60尺，则该轮中你获得50％隐蔽。</td></tr>
  <tr><td rowspan="9">神话能力</i></td>
       <td>Abundant Panache 充裕时髦</td>
          <td>每次游荡剑客使用轻型或者单手穿刺近战武器击中，或者将敌人的攻击导向其他敌人时，都能返还1点时髦值。</td></tr>
  </table>

--------------------------------------
### SmolCraft
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 神话能力。专长，动物伙伴<br>
+ Discord发布，早期版本，自行承担风险。本文档[Release页面](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/releases)处可下载（SmolCraft.zip）

 <table>
 <tr><th colspan="3">新增内容列表<br></th></tr> 
  <tr><td rowspan="2">神话能力</i></td>
       <td>平凡重击</td>
          <td>你的非重击攻击造成额外伤害，如同其尺寸增大一级。</td></tr>
       <tr><td>大德鲁伊护甲</td>
          <td>你对自己施放的法师护甲可提供等于你的神话阶层的天生防御加值。</td></tr>
  <tr><td rowspan="1">专长</i></td>
       <td>精通擒抱</td>
          <td>你可以进行擒抱</td></tr>
  <tr><td rowspan="1">其他</i></td>
       <td colspan="2">动物伙伴（狮子）</td>
  </table>
  
--------------------------------------
### [EnduringRework](https://github.com/alterasc/EnduringRework)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* 持久法术和高等持久法术<br>
+ 修改神话能力持久法术和高等持久法术的机制

 <table>
 <tr><th colspan="3">修改内容列表<br></th></tr> 
  <tr><td rowspan="2">神话能力</i></td>
       <td>持久法术</td>
          <td>当你对盟友释放应用了延时超魔的法术时，如果其效果持续时间本应超过1小时但是低于24小时，现在持续24小时。<br>本应超过10分钟（但是不超过1小时）的效果现在持续1小时。<br>本应超过1分钟（但是不超过10分钟）的效果现在持续10分钟 。</td></tr>
       <tr><td>高等持久法术</td>
          <td>除原本效果外，现在当你对盟友释放应用了延时超魔的法术时，持续时间本应超过1小时的效果变为永久效果。</td></tr>
  </table>
  
--------------------------------------
### [CraftMaster](https://github.com/magicskysword/CraftMaster)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 制造奇物功能<br>
+ 国产MOD，由@magicskysword（也是QL Mod的作者）制作
+ 增加了制造奇物的功能，Mod目前处于开发阶段
+ 详细说明反馈问题和建议请去原发布页
  
--------------------------------------
### [Psionics](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/513)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 灵能<br>
+ 增加了灵能内容的MOD，目前仍在开发阶段
+ 目前增加了魂刃基础职业，和少量灵能专长
+ 未来可期
<table>
 <tr><th colspan="3">新增内容列表<br></th></tr> 
  <tr><td rowspan="1">职业</i></td>
       <td colspan="2">魂刃</td>
  <tr><td rowspan="4">灵能专长</i></td>
       <td>Extra Blade Skill 额外魂之剑技</td>
          <td>你获得额外一个魂之剑技。</td></tr>
	<tr><td>Power Point Pool 灵能点池</td>
          <td>你拥有灵能点池</td></tr>
	<tr><td>Psionic Body 灵能身躯</td>
          <td>当你选取本专长时，你每拥有一个灵能专长（包括这个），就获得2点生命值。你获得每个新灵能专长时，还可以再获得2点生命值。</td></tr>
	<tr><td>Psionic Meditation 灵能冥想</td>
          <td>你能用一个移动动作进入“灵能集中”状态。</td></tr>
   <tr><td rowspan="1">专长</i></td>
	<td>Wild Talent 原始天赋</td>
          <td>你潜在的灵能力量在你的生命中闪亮起来，你现在变为了一名灵能人物。作为灵能人物，你获得了2点灵能点而且可以选择灵能专长、超能专长和制造灵能物品专长，不过本专长本身不会给你展现异能的能力。此外，当你多次获得此专长时，首次你获得2点额外灵能点，之后每次只获得1点。</td></tr>
  </table>  

-------------------------------------------   
### [KineticArchetypes](https://github.com/NosVladimir/KineticArchetypes)
> *前置：* 无<br>
> *中文：* **自带中文**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 操念相关<br>
+ 国产MOD，增加了操念类变体并修正了一些BUG，还在进一步开发
+ [贴吧发布页](https://tieba.baidu.com/p/8467346017)
+ 详细内容和反馈问题请去贴吧发布页，也提供了网盘下载
变体非常有（强）趣（力），推荐尝试！
<table>
 <tr><th colspan="3">新增内容列表<br></th></tr> 
  <tr><td rowspan="5">变体</i></td>
       <td rowspan="4">操念使</td>
	       <td>斗念使</td></tr>
	   <tr><td>薪火驭者</td></tr>
	   <tr><td>念枪</td></tr>
	   <tr><td>狂轰使</td></tr>
      <tr><td rowspan="1">战士</td>
	   <td>秘刃</td></tr>
</table> 

-------------------------------------------   
### [MinosPlayerRace](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/517)
> *前置：* TabletopTweaks-Core、TabletopTweaks-Base<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 牛头人种族<br>
<table>
 <tr><th colspan="3">新增内容列表<br></th></tr> 
  <tr><td rowspan="1">种族</i></td>
       <td colspan="2">牛头人 Minos</td>
  </table>    

-------------------------------------------   
### [WoTRHolyVindicator](https://github.com/SpencerMycek/WoTR-HolyVindicator)
> *前置：* 无<br>
> *中文：* **已提交作者，可用临时覆盖**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 神圣辩护者<br>
<table>
 <tr><th colspan="3">新增内容列表<br></th></tr> 
  <tr><td rowspan="1">进阶职业</i></td>
       <td colspan="2">神圣辩护者 Holy Vindicator</td>
</table>    

-------------------------------------------   
### [PrestigePlus](https://github.com/YLMstring/PrestigePlus)
> *前置：* 影舞者专长需要MicroscopicContentExpansion和TabletopTweaks-Core，戍乡人专长需要TabletopTweaks-Base和ExpandedContent,德丝娜的流星飞刃需要CharacterOptionsPlus<br>
> *中文：* **自带中文**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 进阶职业<br>
<table>
 <tr><th colspan="3">新增内容列表<br></th></tr> 
  <tr><td rowspan="44">变体</i></td>
       <td rowspan="3">炼金术师 Alchemist</td>
       <td>构装骑士 Construct Rider</td></tr>
       <tr><td>内修药师 Internal Alchemist</td></tr>
       <tr><td>科学狂人 Mad Scientist</td></tr>
       <td rowspan="1">奥能师 Arcanist</td>
       <td>御天使 Aeromancer</td></tr>
       <td rowspan="3">吟游诗人 Brad</td>
       <td>杂耍者 Juggler</td></tr>
       <td>艺伎 Geisha</td></tr>
       <td>音爆使 Sound Striker</td></tr>
       <td rowspan="4">野蛮人 Barbarian</td>
       <td>醉蛮 Drunken Brute</td></tr>
       <td>野性蛮人 Savage Barbarian</td></tr>
       <td>不驯蛮人 Untamed Rager</td></tr>
       <td>泰坦猛士 Titan Mauler</td></tr>
       <td rowspan="1">血脉狂怒者 Bloodrager</td>
       <td>狂血导魔者 Blood Conduit</td></tr>
       <td rowspan="2">骑将 Cavalier</td>
       <td>警长 Constable</td></tr>
       <tr><td>先锋使者 Emissary</td></tr>
       <td rowspan="1">牧师 Cleric</td>
       <td>神圣典范 Divine Paragon</td></tr>
       <td rowspan="5">德鲁伊 Druid</td>
       <td>立石贤者 Menhir Savant</td></tr>
       <tr><td>平原德鲁伊 Plains Druid</td></tr>
       <tr><td>超自然学家 Supernaturalist<br>有独特异能法术</td></tr>
       <tr><td>真菌朝圣者 Fungal Pilgrim</td></tr>
       <tr><td>毒理学家 Toxicologist</td></tr>
       <td rowspan="7">战士 Fighter</td>
       <td>奥法卫士 Eldritch Guardian</td></tr>
       <tr><td>学识守卫 Lore Warden</td></tr>
       <tr><td>晨花狂舞者 Dawnflower Dervish</td></tr>
       <tr><td>战争领主 Warlord</td></tr>
       <tr><td>御林铁卫 High Guardian</td></tr>
       <tr><td>武器大师 Weapon Master</td></tr>
       <td>野性战士 Savage Warrior</td></tr>
       <td rowspan="2">魔战士 Magus</td>
       <td>尖塔防卫者 Drunken Brute</td></tr>
       <tr><td>杖法师 Staff Magus</td></tr>
       <td rowspan="3">武僧 Monk</td>
       <td>战技宗师 Maneuver Master</td></tr>
       <tr><td>拆招僧 Master of Many Styles</td></tr>
       <tr><td>执械僧 Weapon Adept</td></tr>
       <td rowspan="1">先知 Oracle</td>
       <td>真理追寻者 Truth Seeker</td></tr>
       <td rowspan="1">圣武士 Paladin</td>
       <td>光耀骑士 Shining Knight</td></tr>
       <td rowspan="3">游侠 Ranger</td>
       <td>神射手 Divine Marksman</td></tr>
       <tr><td>守巫人 Witchguard</td></tr>
       <tr><td>渗透者 Infiltrator</td></tr>
       <td rowspan="1">游荡者 Rogue</td>
       <td>巴克雅尔绑匪 Kidnapper</td></tr>
       <td rowspan="1">歌者 Skald</td>
       <td>天命勇者 Fated Champion</td></tr>
       <td rowspan="1">杀手 Slayer</td>
       <td>死魂精之影 Ankou's Shadow</td></tr>
       <td rowspan="1">术士 Sorcerer</td>
       <td>真理追寻者 Truth Seeker</td></tr>
       <td rowspan="1">战斗祭司 Warpriest</td>
       <td>神伐先勇 Divine Champion</td></tr>
       <td rowspan="2">巫师 Witch</td>
       <td>白发魔女 White-Haired Witch</td></tr>
       <tr><td>卡牌占卜师 Cartomancer</td></tr>
  <tr><td rowspan="28">进阶职业</i></td>
       <td colspan="2">骑士 Chevalier</td></tr>
       <tr><td colspan="2">绯红圣教军 Crimson Templar</td></tr>
       <tr><td colspan="2">晨花隐者 Dawnflower Anchorite</td></tr>
       <tr><td colspan="2">秘契骑士 Esoteric Knight</td></tr>
       <tr><td colspan="2">妩媚交际花 Enchanting Courtesan</td></tr>
       <tr><td colspan="2">传道者 Evangelist</td></tr>
       <tr><td colspan="2">狂怒卫士 Furious Guardian</td></tr>
       <tr><td colspan="2">狮子剑 Lion Blade</td></tr>
       <tr><td colspan="2">信仰哨卫 Sentinel</td></tr>
       <tr><td colspan="2">魂饮者 Souldrinker</td></tr>
       <tr><td colspan="2">后继者远征骑士 Inheritor’s Crusader</td></tr>
       <tr><td colspan="2">后继骑士 Heritor Knight</td></tr>
       <tr><td colspan="2">影舞者 Shadowdancer</td></tr>
       <tr><td colspan="2">墓穴使徒 Agent of the Grave</td></tr>
       <tr><td colspan="2">戍乡人 Hinterlander</td></tr>
       <tr><td colspan="2">魔射手 Arcane Archer<br>魔射手变体 神射信徒 Deadeye Devotee</td></tr>
       <tr><td colspan="2">大地旅者 Horizon Walker</td></tr>
       <tr><td colspan="2">染血天使 Sanguine Angel</td></tr>
       <tr><td colspan="2">负痕求道者 Scar Seeker</td></tr>
       <tr><td colspan="2">阴影代理人 Umbral Agent</td></tr>
       <tr><td colspan="2">巨兽驭手 Mammoth Rider</td></tr>
       <tr><td colspan="2">亚萨维尔 Asavir</td></tr>
       <tr><td colspan="2">半身任侠 Halfling Opportunist</td></tr>
       <tr><td colspan="2">龙怒狂徒 Dragon Fury</td></tr>
       <tr><td colspan="2">黄金军士 Golden Legionnaire</td></tr>
       <tr><td colspan="2">王牌弩手 Bolt Ace<br>在桌面上是铳士变体，作者修改成了5级封顶的进阶职业</td></tr>
       <tr><td colspan="2">森林守护者 Forest Warden</td></tr>
       <tr><td colspan="2">凡世渡魂人 Mortal Usher</td></tr>
  <tr><td rowspan="38">职业特性和其他</i></td>
       <tr><td rowspan="7">狂暴之力 Rage Power</td></tr>
       <td>醉怒狂吼 Roaring Drunk<br>狂暴时，野蛮人获得威吓检定以及她创造的任何恐惧效果DC的士气加值，每4野蛮人等级增加1点。</td></tr>
       <td>勇气之水 Liquid Courage<br>狂暴时，野蛮人获得针对影响心智效果的豁免士气加值，每4野蛮人等级增加1点。</td></tr>
       <td>可怖怒视 Intimidating Glare<br>野蛮人能以移动动作对一名邻接敌人进行一次威吓技能检定。如果他成功挫败对方士气，则敌人将战栗1d4轮，野蛮人的检定结果每超过威吓DC5点额外增加1轮。</td></tr>
       <td>返祖 Atavism<br>野蛮人获得凶暴能力，不再会在生命值降至负值时陷入昏迷，不过他只能在生命值为负值时进行单个标准动作或移动动作。</td></tr>
       <td>高等返祖 Greater Atavism<br>野蛮人获得践踏能力。</td></tr>
       <td>怒涛狂涌 Strength Surge<br>以一个迅捷动作，野蛮人将她的职业等级加到两轮内下一次战技检定上，每次狂暴中限一次。</td></tr>
       <tr><td rowspan="6">魔战士奥能 Magus Arcana</td></tr>
       <td>战技掌控 Maneuver Mastery<br>当魔战士尝试战技时，用他的魔战士等级作为其基本攻击加值（与其他职业带来的基本攻击加值合计）。</td></tr>
       <td>魔宠 Familiar<br>获得一只魔宠。</td></tr>
       <td>及远法术打击 Reach Spellstrike<br>魔战士可以使用近战接触法术来进行远程法术打击。</td></tr>
       <td>近程法术打击 Close Range<br>选择本奥能的魔战士可以将需要远程接触攻击的射线法术以近战接触攻击方式传递。他可利用此奥能施放目标多于一个的远程接触法术（如灼热射线），但他只能用一次近战攻击传递一个远程接触效果，该法术额外的远程接触攻击则被浪费掉且没有效果。这些法术只能用于法术打击职业能力。</td></tr>
       <td>扰法者 Disruptive<br>魔战士获得扰法者作为额外专长。</td></tr>
       <tr><td rowspan="3">气力 Ki Power</td></tr>
       <td>气力：一指禅 One Touch<br>只要武僧气池内还至少有1点气，他就可用标准动作，对一个目标进行一次徒手攻击近战接触攻击。本次攻击获得等同于1/2武僧等级的伤害加值。他可以选择消耗1点气翻倍该伤害加值。</td></tr>
       <td>气力：凌波微步 Freedom of Movement<br>习得此绝学的武僧获得如同行动自如法术的好处，持续1轮。使用该能力是一个迅捷动作，需消耗1点气。</td></tr>
       <tr><td rowspan="7">游荡者天赋 Rogue Talents</td></tr>
       <td>防御翻滚 Defensive Roll<br>房规改动，加入类似屹立不倒的效果</td></tr>
       <td>改日再死 Another Day<br>每日限一次，当盗贼即将被近战攻击伤害到0血或以下，她可以后退5尺且不受这次攻击的伤害，但恍惚一轮。</td></tr>
       <td>密集暗影 Cloying Shades<br>每当具有该天赋的游荡者使用次元门法术或类法术能力，包括无相挪移或者阴影跳跃能力，所有在传送开始和结束时临近她的生物被纠缠一轮，通过反射检定可以豁免此效果，豁免dc为10+1/2游荡者+智力或者魅力加值取高。</td></tr>
       <td>疾速射击 Quick Shot<br>每当游荡者骰先攻时，她可以用远程武器攻击距离最近的敌人。</td></tr>
       <td>战技偷袭 Sneaky Maneuver<br>每当具有该天赋的游荡者尝试近战偷袭一个正在被她夹击或者对她的攻击失去敏捷加值的生物，她可以在本次攻击中获得-2减值，如果攻击命中，她放弃偷袭伤害，正常造成其余伤害，并可以在本回合用迅捷动作尝试阴招，缴械，击破或绊摔战技。</td></tr>
       <td>忍术 Ninja Trick<br>具有此项天赋的游荡者可以从忍者的忍术列表中选择一项，她能够多次选择该天赋。</td></tr>
       <tr><td rowspan="4">裁决域 Inquisition</td></tr>
       <td>灭法审判域 Spellkiller Inquisition<br>你获得扰法者作为额外专长。你击败一个敌人时，便在防御等级上获得+2神圣或亵渎加值，持续1分钟每审判者等级。</td></tr>
       <td>革新审判域 Reformation Inquisition<br>你可以使用感知调整值而非魅力调整值加到任意说服检定的结果上。4级起，当你进行一次交涉或威吓技能检定时，你可以双骰取高。你每天可以使用本能力的轮数等同于你的感知调整值。</td></tr>
       <td>策略审判域 Tactics Inquisition<br>你可以放弃整轮动作以及本轮所有的借机攻击，使一个距离你不超过30尺的盟友获得加速术的好处1轮。8级起，所有距离你不超过30尺的盟友都可以将你的感知调整值加到他们的先攻检定结果上。</td></tr>
       <tr><td rowspan="2">骑士团 Order</td></tr>
       <td>大锤骑士团 Order of the Hammer<br>大锤骑士团的骑将在全回合攻击她正在挑战的对手时，可以用自由动作进行一次擒抱或击破战技，此战技不会引发借机攻击。15级起，以标准动作，她可以给自己和30尺内所有盟友的近战攻击，战技检定，强韧豁免和运动检定提供+4士气加值。她可以用自由动作维持，每日可使用此能力的轮数等同1/2骑将等级，不必连续。"</td></tr>
       <tr><td>魔宠 Familiar</td><td>蟹王 Crab King<br>主人获得+2擒抱检定加值。</td></tr>
       <tr><td>炼金科研发现 Discovery</td><td>触手 Tentacle<br>此触手不会给予炼金术师每轮额外的攻击或动作，但触手的“攫抓”能力具有+4擒抱检定加值。</td></tr>
       <tr><td rowspan="6">诗人传世名作 Bardic Masterpieces<br>吟游诗人必须花费一个已知法术或是通过专长来学习传世名作，他可以花费比该传世名作要求最低等级还高的法术位以学习传世名作。</td></tr>
       <td>三倍时制御（1）Triple Time (1)<br>你那如簧的活泼曲调一般让人可以不倦的行进。响亮、活泼的声音模仿了人类的脚步，缓缓的建立出一个稳健、刚毅的步伐。当你完成此表演的时候，你可以使所有听觉范围内的盟友受到此传世名作的影响，此效果可以在之后的每个诗人等级10分钟，最多1小时之内，让目标的陆地移动速度得到10尺增强加值。</td></tr>
       <td>折剑物语（3）Tales of Twisting Steel (3)<br>这组寓言激励着听众攀登英勇和自我奉献的新高度，其中包含广阔天空，兔王子和疫病三则故事。当你完成这个表演时，选择一个相邻的生物。如同你对其施放了护卫他人。</td></tr>
       <td>四鼠方舞曲（3）Rat Quadrille (3)<br>这个回环往复，令人分神的旋律使敌人感到疲惫。你咏唱或击打出一串令人分心的曲调，深深嵌入目标的心智之中，令其在接下来10分钟内的攻击检定上承受-2减值并在专注检定上承受-4减值。通过一次意志检定目标能将减值减半并减少持续时间至1分钟。这是一个的影响心智的胁迫效果。</td></tr>
       <td>面瘫（2）Stone Face (2)<br>你滑稽的动作可以软化最坚硬的面容。你述说着一个古老的幽默故事，内容是一个拒绝露出笑容的女人，不管事情多么有趣，都无法让她发笑。直到她看到了一系列几乎不可能发生的事件：整车的有机肥，一位国王，还有一只飞毯。她不曾舒展的传说之眉终于舒展开来。当你完成表演的时候，目标将会受到“解除石化”的影响。</td></tr>
       <td>祭司王之安魂曲（10）The Requiem of the Fallen Priest-King (10)<br>你的表演揭示了欺骗时间的方法。此乐章描述伟大的祭司王，他自无数敌人重围中反败为胜，就像违抗了时光之力一般。当你完成表演，你可以在之后的10分钟之内加速时间的流动一次。当启动此效果时你可以用一个迅捷动作恢复你的标准动作。这个额外动作必须在启动之后10分钟之内被使用，否则就会失效。你的盟友可以在此传世名作中获益，不过他们必须在你表演时专心聆听，且不能进行其他活动。</td></tr>
  <tr><td colspan="20">崇神仪典 Deific Obedience<br></th></tr> 
  <tr><td rowspan="152">崇神仪典 Deific Obedience</i></td>
	 <tr><td rowspan="5">拉贾瑟尔 Ragathiel</td><td>需要信仰拉贾瑟尔（Expanded Content）或守序善良</td></tr>
	  <td>服从仪典 Obedience<br>以拉贾瑟尔之名斩杀一名作恶者。仅仅拥有邪恶的内心或意图是不够的，确实犯下违法或邪恶的罪行才能作为祭品。对抗邪恶生物的法术与效果时豁免得到+4神圣加值。</td></tr>
	  <td>义战 Virtuous Combat<br>祝福武器3次/天，正义祷言2次/天，或魔化防具1次/天</td></tr>
	  <td>正义复仇 Retribution<br>当你用挥砍武器攻击24小时内最后一个物理伤害过你的生物时，造成的伤害获得等同生命骰一半的神圣加值。</td></tr>
	  <td>纯洁之魂 Pure Soul<br>每天一次，你可以向自己施展神圣灵光，在持续期间除了既有法术效果，你还获得 DR 10/善良与寒铁，并将手中持握的任何武器视为+5神圣武器。</td></tr>
  	 <tr><td rowspan="5">雪琳（信仰哨卫） Shelyn (Sentinel)</td><td>需要信仰雪琳或中立善良</td></tr>
	  <td>服从仪典 Obedience<br>绘制一幅画，创作一首短诗或短歌，跳出舞剧中的一个场景，或者进行其他艺术创作，当你如此做的时候低声赞颂雪琳的美丽与优雅。这些艺术品不需要庞大或复杂，但是要尽你所能进行真挚的创作。将作品赠与一个陌生人，并且在这么做的时候向其致以真挚的赞美。若没有合适的人能够接受礼物，那么将它放置在明显的地方，并留下纸条，写有对雪琳的颂扬之词以及对找到作品并取走之人的热情祝福。你的使用魔法物品检定获得+4神圣加值。</td></tr>
	  <td>优雅武者 Graceful Warrior<br>纠缠术 3次/日，猫之优雅 2次/日，或加速术 1次/日</td></tr>
	  <td>辉煌神力 Glorious Might<br>当你使用制裁邪恶职业能力时，你能够将魅力加值的两倍加到攻击检定上，并且将你的魅力加值和你的圣武士等级相加之后加到伤害检定上。这会取代使用制裁邪恶时正常的加值。若你不具有制裁邪恶职业能力，那么你会在对抗邪恶目标时，攻击检定获得+2加值作为替代。</td></tr>
	  <td>飞羽斗篷 Cloak of Feathers<br>你获得15点闪电抗力。</td></tr>
  	 <tr><td rowspan="5">奈德丽（信仰哨卫） Naderi (Sentinel)</td><td>需要信仰奈德丽或中立</td></tr>
	  <td>服从仪典 Obedience<br>收集两朵洁白无瑕，正当盛放，没有枯萎花瓣的玫瑰花。站在河边，从茎上剪下花朵，然后将它们放在水上顺流而下。冥想美丽而圆满的爱情，和那从命运多舛的恋人们手中夺去这份爱情的充满缺憾的人生。你在基于魅力的技能检定中获得+2神圣加值。</td></tr>
	  <td>冰封绝望 Frozen Despair<br>严加斥责 2/天</td></tr>
	  <td>众生皆有死别时 All Who Live Suffer Loss<br>所有30尺锥形爆发范围内的敌人在等同于你生命骰的轮数中陷入恍惚，且在攻击骰、豁免骰、技能检定和武器伤害骰中受到-1减值。成功通过意志豁免（DC=10+1/2生命骰+你的魅力调整值）可以避免这一效果。</td></tr>
	  <td>潇湘夜雨泪湿衣 Mantle of Tragic Grace<br>你可以一个标准动作激活该衣袍，给予10尺内所有生物12+你的生命骰数的法术抗力。你每天可以使用这一能力的轮数等于你的生命骰数。这些轮数不需要连续使用。</td></tr>
  	 <tr><td rowspan="5">德丝娜 Desna</td><td>需要信仰德丝娜或混乱善良</td></tr>
	  <td>服从仪典 Obedience<br>在星光下随性舞动，相信命运的指引。如果无法看到星星，便要一边轻声颂唱所有你所知晓的星星的名字，一边舞蹈。让你的心灵扩展，让你的思维离开双脚所处的大地，让你的脚步在机缘的指引下踏落。在感觉舞蹈完成时停下。思索你所踏出的步伐和最终停下的方位，考虑这些微妙的线索可能预示着何种未来。你的先攻检定获得+1幸运加值。</td></tr>
	  <td>旅者戏法 Traveler's Tricks<br>大步奔行 3/天</td></tr>
	  <td>星光术者 Starlit Caster<br>你将自身的魅力加值加到你的专注检定、以及用于克服法术抗力的施法者等级检定中。此外，当你在夜晚施放造成生命值伤害的法术时，你能够让它造成额外2d6点神圣伤害。</td></tr>
	  <td>繁星之眼 Starry Eyes<br>即使在白天，你也能用星光术者造成额外2d6点神圣伤害。</td></tr>
  	 <tr><td rowspan="5">艾若斯提 Erastil</td><td>需要信仰艾若斯提或守序善良</td></tr>
	  <td>服从仪典 Obedience<br>在肥沃的土地中种下5颗种子，种植时将其摆成箭头的形状。这些种子是可以在当地环境生根发芽的任何植物种子，不过可种出食物的种子为首选。这些种子并不需要是某一类能够在本地的土壤中茁长成长的植物，不过它们都必须有概率成活。若没有合适的土地，则将一小堆种子（同样地，那些可种出食物的种子仍为首选）、一小捆腌制食品或者一袋箭放在路人可以看到的地方。在你的礼物上留下艾若斯提的标志，并为周边社区以及那些需要艾若斯提指引的人们祈祷，祝福他们健康安全。你的知识（自然）检定获得+4神圣加值。</td></tr>
	  <td>家庭纽带 Family's Bond<br>治疗轻伤 3次/日，护卫他人 2次/日，或祈祷术 1次/日</td></tr>
	  <td>双生獠牙 Retribution<br>每日1次以标准动作，你能够召唤一个与自身的动物伙伴完全相同的复制体。它在场时你的动物伙伴造成双倍伤害，受到减半伤害。复制体存在的轮数与你具有的生命骰数相同，在之后便会消失不见。</td></tr>
	  <td>虔信射手 Faithful Archer<br>你使用长弓时能够将你的感知加值加到攻击和伤害检定上。</td></tr>
  	 <tr><td rowspan="5">格鲁姆（信仰哨卫） Gorum (Sentinel)</td><td>需要重甲熟练和信仰格鲁姆或混乱中立</td></tr>
	  <td>服从仪典 Obedience<br>穿上你所拥有的一套最重的铠甲。发自肺腑地大声咆哮出对格鲁姆的忠诚，在每一次停顿呼吸时，用武器敲打盾牌或你那铠甲披挂的躯体。在誓言结束之后，肩扛武器，单膝跪地。用洪亮的声音诵读你在战斗中取得的胜利，直至服从仪典结束为止。若你在执行服从仪典时遭受攻击，则屠杀那些胆敢挑战你的家伙（你可以得到盟友的辅助，但是必须由你完成击杀）。你在运动检定中获得+4亵渎加值。</td></tr>
	  <td>威猛战士 Mighty Warrior<br>变巨术 3次/日，牛之蛮力 2次/日，或野兽形态Ⅰ 1次/日</td></tr>
	  <td>双手猛击 Two-Handed Smash<br>若你在持用双手近战武器时作出全回合攻击，那么除了正常的攻击之外，你还可以额外作出单次徒手打击。这次额外攻击使用你最高的基本攻击加值，且攻击检定会受到进行双武器战斗如常产生的惩罚，除非你具有相关专长来减少惩罚。</td></tr>
	  <td>虔信狂暴 Devout Rage<br>每当你狂暴时，便会进入一种神圣或污邪的愤怒中，取决于你的阵营。当你狂暴时，你的攻击和伤害检定获得+2加值。</td></tr>
  	 <tr><td rowspan="5">玛哈萨拉（大尊者） Mahathallah (Exalted)</td><td>需要信仰阿司莫迪斯或守序邪恶</td></tr>
	  <td>服从仪典 Obedience<br>花一个小时深度冥想，反思宇宙的本质和你在多宇宙计划中的特殊地位，在这个过程中最好使用会改变感知的药物。你施放的所有幻术系法术DC增加+2，并且你在针对影响心灵效果的豁免时获得+2亵渎加值。</td></tr>
	  <td>心灵迷雾 Mists of the Mind<br>隐形术2次/天</td></tr>
	  <td>宙域呼吸 Breathe in the Cosmos<br>在每次战斗结束时，你可以吸收药物，在其成瘾性中获取3d6点治疗。在服用阿德顿时，你受到1d4点力量伤害，意志豁免自动成功，从而令你的意识传送至名为阿德顿的心灵世界，你可以在其中随意逗留，并在你愿意时返回现实。</td></tr>
	  <td>呼出死亡 Breathe Out Death<br>你对抗毒素的豁免检定得到+4加值，且不再对药物上瘾。此外，你的寿命被超自然地延长了，每一个衰老阶段（中年、老年、暮年）都推迟等同于你感知调整值两倍的年份。</td></tr>
  	 <tr><td rowspan="5">诺格巴 Norgorber</td><td>需要信仰诺格巴或中立邪恶</td></tr>
	  <td>服从仪典 Obedience<br>你走路穿过一群人（至少6人）的时候，用仅有自己能听到的音量向诺格巴祈祷。若你怀疑人群中有人听到你说的话，那么你必须尾随该人并且使用淬毒的针或其他锐器刺伤她。若你找不到合适的人群，则要在地上挖出至少6英寸深的洞，向着这个坑低语你的祷词，并将之埋葬其中。在仪典结束时，给一根针淬毒并且将它丢在道路上、窗台外侧、或者其他任何可能让路人无意间刺中自己的地方。在唬骗检定上获得+3亵渎加值。</td></tr>
	  <td>毒性 Virulence<br>毒击术 1次/日</td></tr>
	  <td>剧毒爆弹 Noxious Bomb<br>你能够将一剂毒素和投掷用的炼金炸弹相结合。这个炸弹会如常造成直接和溅射伤害，炸弹直接命中的目标还必须进行豁免检定，失败就要承受毒素的效果，如同7环的剧毒吐息法术。被炸弹的溅射伤害击中的生物不会受到毒素的影响。</td></tr>
	  <td>隐藏人格 Secret Self<br>每日1次，你能够以类法术能力对自身使用高等隐形术。当你使用这个类法术能力时，除了法术原本的效果之外，诺格巴还会赐予你特殊的赠礼。你在隐形时察觉检定会获得+4亵渎加值。并且在隐形时使用投掷武器、远程武器和短剑进行的攻击检定都会获得+2亵渎加值。这些加值仅会在你使用这个类法术能力时生效，其他来源的法术或效果产生的高等隐形术无法使你获得这些效果。此外，该隐形效果的持续时间变为1分钟/等级而非正常的1轮/等级。</td></tr>
  	 <tr><td rowspan="6">拉玛什图（大尊者） Lamashtu (Exalted)</td><td>需要信仰拉玛什图或混乱邪恶</td></tr>
	  <td>服从仪典 Obedience<br>以怪物之母的名义献祭一个非自愿的活物。在此过程中要最大程度地激发出祭品的恐惧之心并让其承受无上的苦痛。你施加的致命一击应当是狂野而极具毁灭性的——不要让你的祭品干净利落地死去。该名生物死亡后，便从它体内抽出一根骨头削尖。用这根骨头深深切开自己，使创口足以留下伤疤。最后将祭品那残缺不全的尸体暴露在有食腐生物能吃掉它，或者有旅者能看到它，因此知晓拉玛什图伟大力量的地方。你的AC获得+1天生防御加值。</td></tr>
	  <td>恶魔仪典 Demonic Obedience<br>带着让自己或伴侣怀孕的真诚意图进行一场幽会，或献祭一个存活时间不超过一周的生物。在对抗困惑和变形效果的豁免中获得+4亵渎加值。</td></tr>
	  <td>可怖怒嚎 Howling Terror<br>惊恐术 3次/日，惧死术 2次/日，或恐惧术 1次/日</td></tr>
	  <td>狂乱思维 Maddening Thoughts<br>你在对抗影响心智（胁迫）的法术和效果时，豁免检定获得+4亵渎加值。任何以你为目标使用上述法术或效果的人，都必须进行一次意志豁免检定（DC为10 + 你的感知调整值 + 1/2你的生命骰），失败则会受到1d4点感知伤害。</td></tr>
	  <td>怪物变形 Monstrous Transformation<br>你每日能够使用1次恶意变形术，不过你会将目标转变为你所选择动物的可怕变异体。目标在对抗你的法术的豁免检定中受到-4减值。除原本的效果之外，受术者还会在这种扭曲的畸变形态中感到持续的痛苦，每轮受到1d6点伤害。这种持续的苦痛还会让目标的所有技能检定、豁免检定、攻击检定和伤害检定受到-2减值。</td></tr>
  	 <tr><td rowspan="5">奥托门斯 Otolmens</td><td>需要信仰奥托门斯或守序中立</td></tr>
	  <td>服从仪典 Obedience<br>花费1小时以详尽的细节和术语，系统地绘制您的一项日常任务或即将进行的项目的蓝图。你在确认重击时的攻击检定获得+4加值。</td></tr>
	  <td>善断心智 Discerning Mind<br>移位术 1次/日</td></tr>
	  <td>战机计算 Combat Calculus<br>每天三次，以一个移动动作，你可以凭空进行一系列的数学计算。你在下回合开始之前进行的下一次攻击将获得克敌机先法术的增益，忽略等于你的生命骰的伤害减免，并造成公理武器特殊能力一般的额外伤害。</td></tr>
	  <td>修正现实 Revise Reality<br>每日1次，你能够复制任何6级或更低等级的法师法术，或复制任何5级或更低等级的其他法术。复制的法术会按照9级法术进行计算。</td></tr>
  	 <tr><td rowspan="5">亚拉兹妮（信仰哨卫） Arazni (sentinel)</td><td>需要信仰乌伽娑婀或中立邪恶</td></tr>
	  <td>服从仪典 Obedience<br>花一个小时重温或想象发生在你身上的可怕事情。这个过程在精神上相当费力，会对你造成 1d6 点伤害。你不能让任何人知道你的挣扎：谈论它们，在考虑时表现出痛苦，甚至在治疗该伤害时寻求帮助都会令你失去这个仪典带来的好处。当你在对抗某个生物的法术或类法术能力的豁免检定失败时，你在对抗该生物任何能力的豁免检定上获得+4亵渎加值，持续1分钟。</td></tr>
	  <td>红王后之剑 Red Queen’s Rapier<br>神恩术3/天，重甲轻装2/天，或狂暴术1/天</td></tr>
	  <td>潜意识之抗 Subliminal<br>你免疫魅惑和胁迫效果，并且在对抗恐惧效果的豁免检定上获得+4加值。</td></tr>
	  <td>陨落圣教军之回击 Fallen Crusader’s Retaliation<br>你对战斗中施法者保持时刻警惕，磨练你的反应能力，在最意想不到的时候发动攻击。你获得扰法者作为额外专长。</td></tr>
  	 <tr><td rowspan="5">卡戎（信仰哨卫） Charon (Sentinel)</td><td>需要信仰卡戎（Expanded Content）或中立邪恶</td></tr>
	  <td>服从仪典 Obedience<br>细细反思凡躯的脆弱，以及时光对肉体与心灵所造成的缓慢却不可阻挡的衰退。将自己或一名受害者浸入冰水直至几乎失去知觉，或通过饮酒，服用药物模糊记忆力和精神来模拟这种感觉。你在对抗死灵系法术和负能量效果的豁免检定上获得+4亵渎加值。</td></tr>
	  <td>死亡斗士 Death’s Crusader<br>召唤怪物1级，3次/天</td></tr>
	  <td>灰马之上 On a Pale Horse<br>你获得呼唤灰马力量的能力。你可以迅捷动作召唤灰马的幻影出现在你身边的一个10尺方格内。被灰马幻象穿过的生物若未通过强韧豁免，则力量，敏捷和体质受到-6减值，就好似突然步入暮年。通过强韧豁免（DC=10+1/2HD+魅力调整值）能抵抗该效果。这是一个衰老诅咒效果。你可以用意志操纵灰马在你周围30尺范围内移动，这需要一个专注的移动动作。</td></tr>
	  <td>死亡呼唤 Death’s Call<br>每天一次，你可以祈唤卡戎的力量，令你的敌人化为尘土。该能力如同女妖之嚎法术一般，但没有声波描述符。</td></tr>
  	 <tr><td rowspan="4">祖瑞尔（信仰哨卫） Szuriel (sentinel)</td><td>需要信仰祖瑞尔（Expanded Content）或中立邪恶</td></tr>
	  <td>服从仪典 Obedience<br>选择一个或多个你宣泄怒火的目标，研究一段时间后，在有多个目击者的公开战斗中击杀他们或将他们钉在公共场所的十字架上。对抗火焰效果的豁免获得+4亵渎加值。</td></tr>
	  <td>武器学识 Weapon Lore<br>你擅长所有武器，但特别精通剑术。武器攻击和伤害检定获得+2亵渎加值；使用巨剑时该加值变为+4。</td></tr>
	  <td>炽天使化身 Avatar of the Seraph<br>你的力量和体质获得+2亵渎加值</td></tr>
  	 <tr><td rowspan="5">艾奥梅黛（信仰哨卫） Iomedae (sentinel)</td><td>需要信仰艾奥梅黛或守序善良</td></tr>
	  <td>服从仪典 Obedience<br>将你的主手武器举在身前，并将艾奥梅黛的圣徽悬挂在武器之上。以此姿势跪下并专注于圣徽，祈求后继者的指引与保护，并立誓遵从她的教诲。你的交涉检定获得+4神圣加值。</td></tr>
	  <td>英勇骑士 Knight of Valor<br>祝福武器 3次/日，牛之蛮力 2次/日，或魔化防具 1次/日</td></tr>
	  <td>勇气斩 Valorous Smite<br>若你具有制裁邪恶职业能力，那么该能力的每日使用次数额外增加1次。在判断该能力造成的额外伤害时，将你的信仰哨卫等级加到圣武士等级之上。若你成功使用制裁邪恶造成伤害，那么你的目标必须进行意志豁免（DC为10 + 你的魅力调整值 + 1/2你的生命骰），失败则会震慑，持续时间为1轮，你每有4个生命骰额外增加1轮（最高6轮）。如果目标成功豁免，会在24小时内免疫这个震慑效果。</td></tr>
	  <td>放逐斩 Banishing Strike<br>每日1次，你能够将放逐术的效果引导至你的武器上，不过这并不需要施放（甚至学会）该法术。你必须在做出攻击检定之前声明使用该能力。若命中，目标会受到放逐术的效果影响。若你公开佩戴着艾奥梅黛的圣徽，那么你会在克服目标的法术抗力（若有）的施法者等级检定中获得+1加值，并且该效果的豁免DC增加2点。</td></tr>
  	 <tr><td rowspan="5">美洛妮（信仰哨卫） Milani (sentinel)</td><td>需要信仰美洛妮（Expanded Content）或混乱善良</td></tr>
	  <td>服从仪典 Obedience<br>在自己种植的玫瑰花丛中冥想，在向美洛妮祈祷的同时呼吸着它们神圣的香气。如果没有这样的玫瑰花，你可以用香草和玫瑰花瓣泡茶，并与亲密的朋友或邻居一起喝。茶会上首选的话题包括对未来的希望，未雨绸缪等等，但不聊这些也没关系。但在战争或冲突时期，你必须击剑，最好是与你计划在即将到来的冲突中并肩作战的朋友或邻居击剑。如果你被监禁并且无法击剑，你可以与一名或多名狱友齐声唱任何关于希望或抵抗的歌曲。你在对抗魅惑和胁迫效果的豁免检定上获得+2神圣加值，并且基于施法者等级的所有解除魔法检定获得+2加值。</td></tr>
	  <td>家园守护者 Neighborhood Guardian<br>防护邪恶 3次/日，护卫他人 2次/日，或魔化防具 1次/日</td></tr>
	  <td>隐修守护者 Stoic Guardian<br>你免疫恐惧和魅惑效果，并且在对抗胁迫效果的所有豁免检定上获得+4神圣加值。</td></tr>
	  <td>殉难 Martyrdom<br>你的护卫他人效果的目标不会受到任何伤害。其未受到的伤害将由你承担。</td></tr>
  	 <tr><td rowspan="5">妮维（大尊者） Nivi (exalted)</td><td>需要信仰托拉格或中立</td></tr>
	  <td>服从仪典 Obedience<br>参与一场运气游戏，赌上金钱、宝石或其它价值至少 10 金币的物品。必须双方自愿参与。在赌局开始前向妮维大声祈祷（例如，如果赌注涉及骰子，在掷骰子之前献上祈祷）。如果您独自一人并且没有其他人可以下注，请代表妮维和自己对赌，如果代表妮维的一方获胜，将赌注献祭给妮维。私下陶醉于冒险下注的兴奋快感，并为不可避免的骰运不佳做好准备。在唬骗和巧手检定上获得+4亵渎加值。</td></tr>
	  <td>忠实好运 Faithful’s Fortune<br>祝福术 3次/日，护卫他人 2次/日，或英雄气概 1次/日</td></tr>
	  <td>宝石卫士 Gemstone Guardian<br>每天一次，以一个标准动作，你可以召唤一个巨型土元素，它会出现在你指定的地方，并尽力攻击你的对手。</td></tr>
	  <td>七棱宝石 Pure Soul<br>以一个迅捷动作，你可以在下一次攻击检​​定中获得相当于生命骰一半的幸运加值。你每天可以使用该能力的次数等于你的魅力加值（最少 1 次）。你用完所有的次数后，可以再使用此能力一次，但你有50%的概率不会获得运气加值，而是受到相等的减值。每当这种攻击命中，并且不用这个能力本来就能命中时，你能以后一种方式额外再使用一次本能力。</td></tr>
  	 <tr><td rowspan="5">索克斯贝诺（信仰哨卫） Socothbenoth (sentinel)</td><td>需要信仰吉罗娜或混乱邪恶</td></tr>
	  <td>服从仪典 Obedience<br>达到高潮，自行解决或者依靠伴侣均可。接着玷污一张从守序善良神明的教典上撕下来的书页。对抗惑控效果的豁免获得+4加值。</td></tr>
	  <td>月盈未亏 Before The Fall<br>命令术 3次/天，镜影术 2次/天，或英雄气概 1次/天</td></tr>
	  <td>横行霸道 Violent Vice<br>每天3次，当你对一个生物造成伤害时，激增的快感会赋予你相当于双倍魅力调整值的临时生命值。这些临时生命值会因多次使用该能力而叠加，持续1分钟或耗尽为止。只要你生命值全满，且至少有1点该能力赋予的临时生命值，你便在攻击检定和意志豁免上获得+4士气加值。</td></tr>
	  <td>风情万种 Sensuous Facade<br>你的魅力获得+2亵渎加值。只要你的AC没有护甲加值，你的AC与强韧豁免就会得到等于你魅力调整值的亵渎加值。每当一个生物通过攻击对你造成伤害，你在下一次对该生物的武器攻击检定上获得等于你魅力调整值的亵渎加值。</td></tr>
  	 <tr><td rowspan="5">法蕾娜 Falayna</td><td>需要信仰法蕾娜（Expanded Content）或守序善良</td></tr>
	  <td>服从仪典 Obedience<br>每根手指戴一枚宝石戒指，空手击打训练人偶，直到戒指的痕迹印在你的皮肤上。你的CMD和擒抱检定获得+4神圣加值。</td></tr>
	  <td>杰出武艺 Martial Excellence<br>神恩术 3次/天，骨拳术 2次/天，或高等魔化武器 1次/天</td></tr>
	  <td>强臂 Strong Arm<br>以一个迅捷动作提升武器伤害骰一级，持续时间为等同于你的HD的轮数，无需连续。</td></tr>
	  <td>法蕾娜之戒 Falayna's Rings<br>你的强臂能力不再有每日轮数限制。</td></tr>
  	 <tr><td rowspan="5">卡怖厉厉（大尊者） Kabriri (exalted)</td><td>需要信仰卡怖厉厉（Expanded Content）或混乱邪恶</td></tr>
	  <td>服从仪典 Obedience<br>参加一场食人筵席，你需要在坟墓上进食，或者你吃掉的尸体已经放了一星期以上。在对抗麻痹和疾病效果的豁免检定中获得+4亵渎加值。</td></tr>
	  <td>坟墓之吻 Kiss of the Grave<br>食尸鬼之触 2次/天</td></tr>
	  <td>不死仆从 Undead Minion<br>每场战斗1次，你可以施放唤起死灵，这是一个类法术能力。创造出的不死生物完全忠实地服从你的命令。</td></tr>
	  <td>尸鬼飞升 Ghoulish Apotheosis<br>对你来说，死亡并非结束，而是新的开始。该能力如同墓穴使徒的转化食尸鬼，并且获得+2天生护甲加值。如果你得到该神恩时已经是不死生物或者走上巫妖道途，则原效果改为令你的魅力获得+4亵渎加值。</td></tr>
      	 <tr><td rowspan="5">查尔迪菈（信仰哨卫） Chaldira (sentinel)</td><td>需要一级盗贼和信仰莎恩芮或中立善良</td></tr>
	  <td>服从仪典 Obedience<br>从不太可能会想念或需要它的人那里偷一枚硬币或纽扣。偷偷将其放在武器边缘，然后抛向空中，并猜它如何落地。如果猜对，把硬币或纽扣送给别人——甚至可以是它的原主人——并解释它如何带来好运。在短剑攻击检定中获得+2神圣加值。如果一个小时内你找不到能够送出的人，或者猜错，那就把它藏在一个能被找到的，并且捡到它的人可能会感到很幸运的地方。你在使用其他武器进行攻击时只获得+1神圣加值。</td></tr>
	  <td>幸运一闪 Lucky Miss<br>移位术 1次/天</td></tr>
	  <td>好运之子 Fortune’s Child<br>你的任何运气加值增加1点。</td></tr>
	  <td>霹雳火 Impetuous Ardor<br>你移动接近敌人时不会引发借机攻击。</td></tr>
      	 <tr><td rowspan="5">璞露拉 Pulura</td><td>需要信仰璞露拉或混乱善良</td></tr>
	  <td>服从仪典 Obedience<br>坐在地上仰头观星，维持1小时并辨认出12个星座。如果看不到夜空，在半永久平面上（墙壁，硬地板）画上12个星座图。你散发出10尺范围的光芒。</td></tr>
	  <td>极光 Aurora<br>七彩喷射 3次/天</td></tr>
	  <td>星光弹 Starshot<br>每天三次，你能将你的投石索弹药转化为星光弹，视为+2光能投石索弹药，持续1分钟。</td></tr>
	  <td>异界旅者 Otherworldly Traveler<br>你能每天瞬发一次破空步。</td></tr>
      	 <tr><td rowspan="5">洛瓦古格 Rovagug</td><td>需要信仰洛瓦古格或混乱邪恶</td></tr>
	  <td>服从仪典 Obedience<br>摧毁至少价值10金币的物品，最好是脆弱，美丽或者对善神（尤其是莎伦莱）重要的物品。而更为虔诚的洛瓦古格仆从，则会寻找并囤积价格昂贵、具有艺术价值或罕见的物品，比如上好的葡萄酒或稀有的珍奇物品，并在仪典中摧毁它们。在被摧毁的物品碎片上翻滚，狂嚎出赞颂和诅咒，祈唤毁天巨兽之力，直至身体被碎片割出鲜血，肺部因狂叫而发痛为止。你的击破检定获得+4加值。</td></tr>
	  <td>巨兽代行者 Agent of the Beast<br>阵营武器（仅限邪恶） 2次/日</td></tr>
	  <td>法术湮灭 Destructive Spell<br>你可以在施放一个造成生命值伤害，并且施法时间为标准动作或更快的法术时使用该能力。你以整轮动作施法，使其豁免DC获得+4加值。此外，该法术的每一个伤害骰都造成1点额外伤害。</td></tr>
	  <td>毁灭者之赐 The Destroyer's Gifts<br>你每天可以施展一次内爆术或怪物召唤术IX，这是一个类法术能力，但可以视为法术。</td></tr>
      	 <tr><td rowspan="5">灯王 The Lantern King</td><td>需要信仰灯王（Expanded Content）或混乱中立</td></tr>
	  <td>服从仪典 Obedience<br>点亮一盏小灯笼，给它讲一个笑话，或是你恶搞某人的故事——每次都必须是不同的笑话或故事。你在对抗幻术的豁免检定上获得+4神圣加值。</td></tr>
	  <td>恶作剧之触 Prankster's Touch<br>狂笑术 2次/日</td></tr>
	  <td>变化万物 Transform Others<br>每天一次，你可以复制恶意变形术，高等变形术或解除石化的效果，这视为一个8级的类法术能力。此外，该变形效应至少持续3小时。</td></tr>
	  <td>是我，都是我 Anyone and Anything<br>你可以用迅捷动作任意施放形体转换，并且用自由动作恢复原本形态。</td></tr>
      	 <tr><td rowspan="5">哥兹莱（大尊者） Gozreh (exalted)</td><td>需要信仰哥兹莱或中立</td></tr>
	  <td>服从仪典 Obedience<br>将一套铃铛悬挂在能够被风或水摇荡的地方。若没有合适的地点来悬挂铃铛，你就必须在整个服从仪典中举着它们并轻轻地摇动。颂唱《风澜谣》中的祈祷文，逐渐将自己与铃声同调，之后喝下一口洁净的水，再将一把水洒在头顶。你在对抗闪电和寒冷法术与效果时，豁免检定获得+4神圣加值。</td></tr>
	  <td>环境保护者 Green Worker<br>纠缠术 3次/日</td></tr>
	  <td>风暴之子 Lightning Child<br>你能够抵抗雷电以及类似的效果。你获得闪电抗力，数值等同于5+你的生命骰。</td></tr>
	  <td>自然伙伴 Nature's Companion<br>首先，你的动物伙伴的智力和感知属性获得+1加值。其次，你的动物伙伴的攻击与伤害检定获得+2神圣加值。最后，你的动物伙伴在对抗寒冷、闪电以及火焰法术和效果时，豁免检定获得+4神圣加值。</td></tr>
      	 <tr><td rowspan="5">卡莉丝翠（大尊者） Calistria (exalted)</td><td>需要信仰卡莉丝翠或混乱中立</td></tr>
	  <td>服从仪典 Obedience<br>为了交换金钱、情报或者其他贵重资源而和某人进行性行为。双方都必须是自愿；你不应为此而涉险或者陷入某种令你不适的状况。在行房前后向卡莉丝翠大声祈祷，并鼓励你的伴侣也这么做。若没有合适的伴侣，则需要用黄色的丝绸包裹全身，用手握住圣徽按在胸前。默想卡莉丝翠的教诲，并幻想如何报复那些亏待你的人。当和你对其有性吸引力的智慧生命互动时，你在沟通和唬骗检定中获得+4亵渎加值。</td></tr>
	  <td>卡莉丝翠之舌 Calistria's Tongue<br>鹰之威仪 2次/日</td></tr>
	  <td>离魂之触 Stunning Touch<br>在使用魅惑领域的接触能力时，你能够让目标震慑1轮，以取代原本的晕眩。只有生命骰高于你的敌人不受影响。若你并不具有正常的魅惑领域，那么你会获得魅惑领域的接触能力，每日使用次数为3 + 你的感知调整值，如同该能力所描述的一样，但你只能让敌人晕眩，而不是震慑。</td></tr>
	  <td>优雅护身 Protective Grace<br>当你穿着轻甲或者不穿甲时，可以将你的魅力调整值加到你的AC上。该加值可以用于对抗接触攻击。任何会使你的AC失去敏捷加值的状态，也会使你失去AC上的魅力加值。</td></tr>
      	 <tr><td rowspan="5">莫求 Mrtyu</td><td>需要信仰莫求（Expanded Content）或中立</td></tr>
	  <td>服从仪典 Obedience<br>聆听垂死者的忏悔，或在战斗后花至少1小时埋葬死者。如果该地区没有垂死者，也没有死者，则用这些时间为你遇到的最后一个死者祈祷。对抗影响多个生物的法术的豁免检定获得+4洞察加值。</td></tr>
	  <td>激情俘虏 Ruled by Passion<br>移除恐惧 3次/天，援助术 2次/天，移除目盲 1次/天</td></tr>
	  <td>死神之爱 Death's Lover<br>你的交涉和察觉成为本职技能，并且进行这些检定时获得等同于你生命骰一半的加值。</td></tr>
	  <td>死亡之手 Hands of Death<br>每天一次，你可以召唤大量旋转着的匕首和剑，如同剑刃屏障法术。该效果仅持续每生命骰1轮，但你可以通过一个移动动作使其在近程范围内移动。</td></tr>
      	 <tr><td rowspan="5">墨菲斯托菲利斯 Mephistopheles</td><td>需要信仰墨菲斯托菲利斯（Expanded Content）或守序邪恶</td></tr>
	  <td>服从仪典 Obedience<br>为了自身利益而对某人撒谎（同一个人每周不能超过一次）。此外，每周一次，你必须写下一个新掌握的别人的秘密，并将其烧掉，作为对墨菲斯托菲利斯的献祭。交涉检定获得+4亵渎加值。</td></tr>
	  <td>钓鱼人 Fool Maker<br>催眠术 3次/天</td></tr>
	  <td>迫害者 Persecutor<br>你可以使用唬骗技能来挫败对手的士气，并影响对手的态度，如同威吓技能一般。此外，如果你掌握地狱法令，获得黑堕湮灭作为额外专长。</td></tr>
	  <td>迷人骗徒 Charming Liar<br>你可以使用交涉技能来挫败对手的士气，并影响对手的态度，如同唬骗技能一般。此外，你的任何魅惑效果的DC都会增加2。</td></tr>
      	 <tr><td rowspan="6">诺缇库拉（信仰哨卫） Nocticula(Sentinel)</td><td>需要信仰诺缇库拉（Expanded Content）或混乱中立</td></tr>
	  <td>服从仪典 Obedience<br>在僻静处花一个小时制作一件艺术品。 如果你的工作时间闭区间包含午夜，那么艺术主题可以自定，否则需要以某种方式包含午夜的概念。 当你不与盟友相邻时，你的AC和所有豁免检定都会获得+1士气加值。</td></tr>
	  <td>恶魔仪典 Demonic Obedience<br>服下一株迷幻植物或真菌，进行任意数量的性行为（独自或与别人），期间有至少一品脱的血液流出。在对抗目盲和魅惑效果的豁免获得+4亵渎加值。</td></tr>
	  <td>午夜恩典 Midnight’s Grace<br>克敌机先 3次/天，猫之优雅 2次/天，吸血鬼之触 1次/天</td></tr>
	  <td>灵尾匕舞 Sinuous Daggerplay<br>你长出一条弯曲灵活的尾巴（如果你已经有一条尾巴，会长出第二条尾巴）。 这条尾巴极易操纵并且能够控制和抓握轻小物体，但除了挥舞匕首之外，它不能像手一样进行精细的手工操作。 当你用该匕首全回合攻击时，你可以进行一次额外攻击。</td></tr>
	  <td>死就一个字 Death Is But a Word<br>你对诺缇库拉的忠诚得到了回报，一声独属于你的低语，从她的嘴唇到你的耳边。这是阴影女士所知晓的无数个带来死亡的真言之一。她的每个信徒收到的真言都是独一无二的。当你学会它时，便可以将律令死亡作为类法术能力施展，每天一次。</td></tr>
      	 <tr><td rowspan="5">阿卡艾克克（信仰哨卫） Achaekek (Sentinel)</td><td>需要信仰阿卡艾克克（Expanded Content）或守序邪恶</td></tr>
	  <td>服从仪典 Obedience<br>在一个私密处所中，于从你签下契约而杀死的目标身上取得的战利品或破碎的圣徽之前冥想。该战利品必须涂有你的一滴由反曲剑取出的血，并且战利品必须在冥想结束时被销毁。如果你还没有完成契约杀人，或是手头没有合适的战利品，或者寻求以其他方式侍奉螳螂神，而非作为神的刺客，你必须用反曲剑沿着右臂割伤自己，将自己的生命之液献给鲜血行者。你在确认重击时获得+2加值。</td></tr>
	  <td>斩头沥血 Blood Must Flow<br>重压之刃 3次/日</td></tr>
	  <td>鲜血淋漓 Bleeding Wounds<br>你用反曲剑产生的所有伤口都会流血不止，对目标造成1d4点流血伤害（不叠加）。</td></tr>
	  <td>螳螂门不传之秘 Mantis Style Mastery<br>同时持用两把反曲剑时，你不会受到双武器战斗的攻击检定减值，并且你在反曲剑的所有伤害检定上获得+2亵渎加值。如果你用反曲剑造成偷袭伤害，每个偷袭骰都会额外造成2点伤害。</td></tr>
      	 <tr><td rowspan="5">义洛理 Irori</td><td>需要信仰义洛理或守序中立</td></tr>
	  <td>服从仪典 Obedience<br>在1小时的修行中，分配同样的时间做以下三件事：练习拳脚功夫或者操演武器、阅读任何你从未读过的文本、一边编发辫一边思索宇宙之奥秘。当仪典完成时，将发辫绕在脖颈上并在今天内保持如此。在所有知识检定中获得+4神圣加值。</td></tr>
	  <td>渊博学识 Expansive Knowledge<br>狐之狡黠 2次/日</td></tr>
	  <td>命定之拳 Inevitable Fist<br>每日轮数等同于你的生命骰数，你能够向自身的肢体灌入纯粹的秩序能量。你的徒手打击造成的伤害就如同你的体型比当前大一级，而且获得公理武器特殊能力。启动和解消该能力是自由动作，且轮数不必连续。</td></tr>
	  <td>符文之躯 Runic Form<br>九个符文纹身出现在你的身体上，其中各有三个符文对应着义洛理的身心灵三种教导。每日3次以标准动作，你能够耗用一个纹身的力量。身之符文容有复原术作为类法术能力，心之符文使用时为你的感知提供+4神圣加值，持续1分钟。灵之符文可以使你进入灵体状态1分钟，如同破空步法术一般。</td></tr>
  <tr><td rowspan="32">专长</i></td>
       <td colspan="2">崇神仪典 Deific Obedience<br>根据所信仰神明获得特殊神恩</td></tr>
       <td colspan="2">多样尊崇 Diverse Obedience<br>在确定获得崇神仪典的神恩时，将你的hd视为比实际高2。每当你获得神恩时，你可以从传道者或信仰哨卫神恩中进行选择。</td></tr>
       <td colspan="2">神导之手 Guided Hand<br>当你使用偏好武器时，你在掷攻击骰时可以用你的感知修正代替力量或敏捷修正。</td></tr>
       <td colspan="2">战技突袭 Surprise Maneuver<br>如果你拥有偷袭骰，当你对一个正在被你夹击或者对你的攻击失去敏捷加值的生物使用战技时，你对手的CMD获得等同于偷袭骰数量的减值。</td></tr>
       <td colspan="2">下三滥打法 Dirty Fighting<br>当你对一个被你夹击的敌人使用战技攻击时，夹击提供的加值提升至+4。还可以在选择精通战技类专长时视为拥有13敏捷，13智力，寓守于攻和精通徒手击打作为先决条件，同样对需要这些精通战技专长作为先决条件的专长生效。</td></tr>
       <tr><td colspan="2">割喉者 Throat Slicer<br>当你使用单手，轻型，或者天生武器时，可以以一个标准动作对失去知觉，或被擒抱状态所压制或捆绑的目标发起致命一击。</td></tr>
       <tr><td colspan="2">批亢捣虚 Seize the Opportunity<br>当你进行借机攻击时，你可以使用要害打击或尝试一个已学会的战技（如冲撞、卸武或阴招）来代替借机攻击。</td></tr>
       <tr><td colspan="2">风吹幡动 Ripple in Still Water<br>将你的操念使等级与武僧等级叠加，决定你气池的每日点数和你念袭的伤害。此外，在你受威胁时使用念袭不会引发借机攻击。</td></tr>
       <tr><td colspan="2">次级双法合璧 Lesser Spell Synthesis<br>参见[MysticalMayhem](#MysticalMayhem)</td></tr>
       <tr><td colspan="2">太极拳 Ki Throw<br>当你成功对目标进行徒手绊摔攻击，在走动之前你能够让目标摔倒在任何你正在威胁的方格内，而非他原本占据的方格。这个移动不会引发藉机攻击，你也无法将该名生物摔进有其他生物占据的空间内。</td></tr>
       <tr><td colspan="2">太极-揽雀尾 Improved Ki Throw<br>当你使用“太极拳”专长时，你能够将你的目标丢至任何处于你威胁范围的方格内，并且该方格被任何其他生物所占据。你需要对次要目标进行受到-4减值的冲撞战技检定。如果检定成功，被投掷的生物会倒在次要目标所在的方格，而次要目标会被推开，并且倒在相邻的方格内。如果检定失败，被投掷的生物会倒地，他的位置会与次要目标相邻并且在你威胁范围内的最近的方格。</td></tr>
       <tr><td colspan="2">太极-抱虎归山 Binding Throw<br>当你成功的对一个敌人使用了“太极拳”前，你可以用一次迅捷动作对其进行一次战技检定以尝试擒抱他。</td></tr>
       <tr><td colspan="2">太极-倒撵猴 Enhanced Ki Throw<br>当你使用太极拳专长时，你可以花费一点真气，强化你的力道，如果你成功的将敌人摔出，当他倒地时，将承受相当于你徒手击打的伤害。</td></tr>
       <tr><td colspan="2">高等徒手击打 Greater Unarmed Strike<br>你的徒手击打的基础伤害提升至1d8（中等体型），角色等级10级起，该基础伤害提升到1d10。</td></tr>
       <tr><td colspan="2">出奇制胜 Surprising Strategy<br>当你成功格挡后，除了借机攻击以外，你还能额外发起一次阴招，缴械或击破战技，且带有+2士气加值，只要目标在触及范围内，该战技不会引起借机攻击。</td></tr>
       <tr><td colspan="2">保镖 Bodyguard<br>你获得圣洁守卫（圣武士）的保镖能力。</td></tr>
       <tr><td colspan="2">违逆神意 Divine Defiance<br>你在对抗神术施法者或神话生物时，豁免检定获得+2加值。</td></tr>
       <tr><td colspan="2">偶像破坏者 Iconoclast<br>当你成功对违逆神意中所提及的生物使用破武战技，你可以用一个自由动作尝试一次威吓检定来挫败士气。这次挫败士气会影响在30尺内所有敌人。</td></tr>
       <tr><td colspan="2">犀牛冲锋 Rhino Charge<br>未骑乘时你能以标准动作准备一次冲锋，但只能移动等同于你速度的距离。</td></tr>
       <tr><td colspan="2">牛头冲锋 Minotaur’s Charge<br>每当你的冲锋攻击命中敌人，你可以用自由动作冲撞，如果冲撞距离达到15尺以上，目标还会倒地。</td></tr>
       <tr><td colspan="2">奥法强袭 Eldritch Assault<br>每当你在魔法来源的全掩蔽效果中（例如移位术或者隐形术）攻击，你每轮第一个造成重击的攻击骰自动确认重击。</td></tr>
       <tr><td colspan="2">浪子好运 Wanderer’s Fortune<br>以一个迅捷动作,你可以获得行动自如法术的好处，持续1轮。你能每天使用1次本专长，在知识（神秘）上每有5级额外增加一次。</td></tr>
       <tr><td colspan="2">精通招架 Improved Parry<br>当你成功招架敌人的近战攻击时，你的下一次近战攻击不允许敌人将敏捷加值加到防御等级上（若有），但该攻击需要在你的下回合结束前进行。</td></tr>
       <tr><td colspan="2">盾牌猛击 Shield Slam<br>任何被你的盾击命中的敌人也会成为你的一次自由动作冲撞的目标，和盾击采用相同掷骰。该战技不引发借机攻击。</td></tr>
       <tr><td colspan="2">盾牌缠陷 Shield Snag<br>任何被你的盾击命中的敌人也会成为你的一次自由动作缴械的目标，和盾击采用相同掷骰。该战技不引发借机攻击。</td></tr>
       <tr><td colspan="2">抓取飞箭 Snatch Arrows<br>当使用“拨挡飞箭”专长时你可以选择抓住那武器而不仅仅只是偏转它。该远程武器可以立刻被扔回去，视为对原攻击者的一次攻击。</td></tr>
       <tr><td colspan="2">机先克敌 Strike True<br>你可以通过移动动作集中注意力，令你在回合结束前的下一次近战攻击检定中获得+4加值。</td></tr>
       <tr><td colspan="2">长棍大师 Quarterstaff Master<br>你可以将长棍作为单手武器来使用。</td></tr>
       <tr><td colspan="2">灵巧夺命 Deadly Agility<br>效果如同武器娴熟（神话）。</td></tr>
       <tr><td rowspan="3">德丝娜的流星飞刃 Desna's Shooting Star</td></tr>
       <tr><td colspan="2">你可以将你的魅力调整值添加到使用星刃的攻击和伤害检定上。如果你如此做，你无法应用你的力量调整值，敏捷调整值（如果你有武器娴熟）或其他属性（如果你拥有将你替代攻击和伤害检定的能力）。</td></tr>
       <tr><td colspan="2">进阶条件：敏捷17，近程射击，快速射击，BAB+11或巧手11级。10级或以上的混乱善良诗人可以无视条件。你可以给一枚抛出的星刃赋予强大的回旋效果，使得多个刃叶击中目标而非四个刃叶中的某一个，并造成额外的伤害。作为一个整轮动作，你可以投掷星刃进行一次攻击，投掷1d4来决定获得几次有效攻击（如果你投掷出1，则只有一次）。如果攻击命中，则每一击都会成功伤害目标。其中重击伤害只能触发一次，来自固定加值的伤害则适用于每个伤害骰，例如吟游诗人的激发勇气加值。抗性和伤害减免能力适用于每一击。如果你不知道如何投掷星刃，这些攻击视为近战攻击。</td></tr>
  <tr><td rowspan="14">擒抱专长</i></td>
       <td colspan="2">擒抱（精通擒抱）<br>使用擒抱战技时不会引发借机攻击。此外你在擒抱检定上获得+2加值，同时在对抗擒抱的战技防御上获得+2加值。Grapple</td></tr>
       <tr><td colspan="2">高等擒抱 Greater Grapple<br>你在擒抱检定中获得+2加值，此加值与“精通擒抱”专长带来的加值累计。当你成功擒抱一个生物，可以用移动动作维持擒抱。本专长允许你以标准动作进行第二次擒抱检定来进一步移动、伤害或压制你的对手。</td></tr>
       <td colspan="2">擒抱（神话） Grapple (Mythic)<br>在你尝试进行擒抱检定，或者对试图擒抱你的敌人做战技防御（CMD）时，获得等于神话阶层一半的加值。这个加值能够和精通擒抱提供的加值叠加。另外，你还能对任何擒抱你的生物发起借机攻击，除非它也有这个专长。</td></tr>
       <tr><td colspan="2">快速擒抱 Rapid Grappler<br>当你成功地使用“高等擒抱”以移动动作维持了一次擒抱之后，接下来你只用迅捷动作就可以以承受-5减值进行维持擒抱的战技检定。</td></tr>
       <tr><td colspan="2">盘身扭 Unfair Grip<br>当你发动擒抱战技攻击时，你在维持擒抱的战技检定上获得+1加值，你的对手在挣脱你的擒抱的战技对抗检定上承受-1减值。</td></tr>
       <tr><td colspan="2">压制击昏 Pinning Knockout<br>当你压制一个对手，如果你成功的进行了一次擒抱战技检定对其造成伤害，你的伤害翻倍。</td></tr>
       <tr><td colspan="2">压制撕裂 Pinning Rend<br>当你压制一个对手，如果你成功的进行了一次擒抱战技检定对其造成伤害，同时产生3d6流血伤害。</td></tr>
       <tr><td colspan="2">野蛮裂地 Savage Slam<br>当你以正在擒抱对手的状态开始回合时，作为尝试用战技检定维持擒抱的代替，你可以尝试猛然将敌人摔倒在地上。当你用擒抱战技鉴定对敌人造成伤害时，解开擒抱，且对手会被击倒为俯卧。</td></tr>
       <tr><td colspan="2">炫目裂地 Dramatic Slam<br>当你使用野蛮裂地时，如果你成功用擒抱战技检定击倒了对手，你可以尝试立刻进行威吓鉴定，对30尺内能看到你的敌人进行打击士气。</td></tr>
       <tr><td colspan="2">尖刺魔之触 Hamatula Strike<br>当你的穿刺武器对敌人造成伤害时，你可以立即做一个擒抱检定；如果成功则敌人被你的武器所“刺穿”，你们同时进入擒抱状态。当对手处于“刺穿”状态时，在你的回合你可以承受-4罚值的以攻击动作进行擒抱检定来用武器来伤害你的对手，即便是正常擒抱中不能使用的武器此时也可。</td></tr>
       <tr><td colspan="2">粗野擒抱 Uncanny Grapple<br>当你对正在擒抱的对手施加野蛮裂地时，你可以将其投掷到最多每神话阶层 10 尺远处，造成每神话阶层 10 点神力伤害，且目标会被击倒为俯卧。</td></tr>
       <tr><td colspan="2">飞跃突袭 Aerial Assault<br>当进行冲锋攻击时，你可以将冲锋中的近战攻击改为进行擒抱检定，即使目标生物在通常状况下免疫擒抱也是如此。</td></tr>
       <tr><td colspan="2">绳结专家 Knot Expert<br>以一个整轮动作，你可以对范围内的任何生物进行一次远程接触攻击，如果击中可以尝试使用擒抱战技检定，将你的神话阶层加入战技检定中。如果成功，你不被视为进入擒抱状态，但不能移动。</td></tr>
       <tr><td colspan="2">肉盾 Meat Shield<br>若你正在擒抱1名生物，并且受到近战或远程攻击，以直觉动作，你能够尝试进行擒抱战技检定对抗被擒抱的敌人。若成功，到来的攻击会以你擒抱的敌人为目标。若失败，被擒抱的敌人会从擒抱中挣脱，到来的攻击会如常以你为目标。</td></tr>
  <tr><td rowspan="6">绊摔专长</i></td>
       <tr><td colspan="2">剪刀脚 Vindictive Fall<br>当一个生物令你倒地，比如法术（油腻术）或成功的绊摔战技，你可以对你近战武器范围内最近的一名敌人尝试绊摔战技。</td></tr>
       <tr><td colspan="2">远距绊摔 Ranged Trip<br>以一个全回合动作，可以用你的远程武器进行一次-2减值的绊摔，使用敏捷加值，而非力量加值。如果目标距离30尺以上，额外获得-2减值。如果绊摔成功，目标还会受到你的武器攻击的伤害。</td></tr>
       <tr><td colspan="2">王牌绊摔 Ace Trip<br>你的远距绊摔不会有减值，且你可以绊摔任何目标，即使它对其免疫。</td></tr>
       <tr><td colspan="2">下三路顺劈 Cleaving Sweep<br>以一个全回合动作，你可以对所有触及内的敌人尝试绊摔，对每个敌人单独掷骰。</td></tr>
       <tr><td colspan="2">多米诺牌手 Down Like Dominoes<br>成功绊摔一个敌人时，可以用自由动作再绊摔一个附近的敌人，但有-4减值。如果这次绊摔也成功，立刻移动至其方格并可以继续绊摔，获得累计的-4减值，以此类推。一轮内最多能如此额外绊摔的生物数量等于1+你一半的神话阶级。</td></tr>
  <tr><td rowspan="4">碎甲专长</i></td>
       <tr><td colspan="2">碎甲 Crush Armor<br>当你成功使用击破战技对敌人的盔甲造成伤害后，该敌人疲劳一轮，但不会因此力竭。</td></tr>
       <tr><td colspan="2">闪破风暴 Sunder Storm<br>当你成功使用击破战技，你将打碎的物品碎片轰入穿戴着血肉之中，造成1d6+神话等级点神力伤害。此外，你可以用一个整轮动作向武器范围内所有敌人尝试击破战技。</td></tr>
       <tr><td colspan="2">血肉撕扯 Tear Apart<br>你的击破战技不再禁用对手的盔甲，二是直接撕裂它。如果战技检定成功，你造成武器攻击伤害并在对手的盔甲，天生护甲或者盾牌加值中减少等同于神话等级1/2的加值（至少为1），如果对手在上述加值中有增强加值，也可以扣减，但不能扣减成负值。</td></tr>
  <tr><td rowspan="7">冲撞专长</i></td>
       <tr><td colspan="2">快速冲撞 Quick Bull Rush<br>当你行动时，你可以用一次单独的冲撞战技检定来代替你的全回合的一次近战攻击。</td></tr>
       <tr><td colspan="2">狂暴投技 Raging Throw<br>当你在狂暴中尝试使用冲撞战技时，你能以迅捷动作消耗1轮每日狂暴轮数，来将体质修正添加到冲撞战技检定上。此外，当你冲撞成功，对手受到等同于你的“力量修正+体质修正”钝击伤害。</td></tr>
       <tr><td colspan="2">飓风神拳 Hurricane Punch<br>当你一轮内用徒手击打命中同一生物两次时，你可以用迅捷动作进行推撞。另外，你可以随冲撞目标一起移动。</td></tr>
       <tr><td colspan="2">一击震退 Knockback<br>每轮限一次，野蛮人可以用一次单独的冲撞战技检定来代替你的全回合的一次近战攻击，成功的话，目标如常被击退且受到等同于野蛮人力量加值的伤害。</td></tr>
       <tr><td colspan="2">一夫当关 Drive Back<br>你可以用全回合动作对触及范围内所有敌人进行一次最高攻击加值的攻击，然后对每个你击中的敌人尝试推撞。</td></tr>
       <tr><td colspan="2">战斗诡术 Combat Trickery<br>你可以用标准动作对所有邻接敌人进行冲撞，用唬骗技能加值代替你的CMB进行战技检定。</td></tr>
  <tr><td rowspan="11">卸武专长</i></td>
       <tr><td colspan="2">顺势缴械 Sweeping Disarm<br>当你成功进行缴械检定时，你可以受到-5减值对原本目标邻接的一个目标再进行一次缴械检定。你不需要威胁第二个目标。你每轮只能用这个专长进行一次卸武战技检定。</td></tr>
       <tr><td colspan="2">突破防御 Break Guard<br>当你装备两把武器，你成功卸除敌人的武器后可以消耗一次迅捷动作来用副手武器立刻对其进行一次攻击。</td></tr>
       <tr><td colspan="2">跟进追击 Follow-Up Strike<br>每当你成功用战技缴械对手，你可以使用迅捷动作，以最高攻击加值向其发动一次徒手击打。</td></tr>
       <tr><td colspan="2">空手入白刃 Hold the Blade<br>当受到手持近战武器的敌人的夹击或偷袭伤害时，可以进行一次战技检定以卸除对方武器。必须至少有一手空闲才能使用此专长。使用此专长后，在下一回合开始之前承受-4AC，一轮只能使用一次。</td></tr>
       <tr><td colspan="2">擒肘拿腕 Wrist Grab<br>当对手的攻击失手的差值达到5或以上，你可以尝试缴械战技。你一轮只能使用此专长一次。</td></tr>
       <tr><td colspan="2">远程缴械 Ranged Disarm<br>以一个全回合动作，你可以使用远程武器对目标尝试一次受-2罚值的卸除武器战技。使用敏捷调整值代替力量调整值来计算该次战技修正。若目标在30尺外，还会额外承受-2罚值。若卸武战技检定成功，目标会承受1次伤害，如同你通过武器成功命中目标一样。</td></tr>
       <tr><td colspan="2">远程缴械（神话） Ranged Disarm (Mythic)<br>你可以轻松使用远程攻击缴械对手。在远程缴械时增加等同于神话等级的加值，如果该缴械成功，再尝试一次额外的缴械。</td></tr>
       <tr><td colspan="2">王牌缴械 Ace Disarm<br>当你使用远程卸武专长以远程武器发动缴械战技攻击时，你不会在攻击检定上承受-2减值。除此之外，如果目标使用的是天生武器，你可以偷窃一件随机装备。</td></tr>
       <tr><td colspan="2">缠臂锁肩 Arm Bind<br>你能够尝试一次战技检定来卸除敌人武器，包括天生武器。该战技视为缴械战技。若你的检定成功，而且敌人使用的是天生武器，则可以选择限制住一只手臂，直至你的下个回合结束为止阻止该敌人下一次攻击命中。</td></tr>
       <tr><td colspan="2">连抓带打 Strike and Seize<br>以标准动作，你能够用武器做出单次攻击，并且用空着的手尝试一次缴械战技且无需承受双武器战斗的惩罚。</td></tr>
  <tr><td rowspan="30">流派专长</i></td>
       <td rowspan="3">黑堕</td>
           <td>黑堕流 Black Seraph Style<br>在对抗战栗、惊惧、恐慌或畏缩的敌人时，你的防御等级和豁免检定得到+1亵渎加值。此加值在5级和之后每5个等级提高1点。</td></tr>
       <tr><td>黑堕恶念 Black Seraph’s Malevolence<br>你的污邪武器同时成为神圣武器。</td></tr>
       <tr><td>黑堕湮灭 Black Seraph Annihilation<br>距你30尺内的生物即使免疫恐惧也会被恐惧效果影响。距你30尺内的生物即使免疫影响心灵效果也会被打击士气效果影响，但若需要豁免检定则有+5抗力加值。</td></tr>
       <tr><td rowspan="3">擒拿</td>
           <td>擒拿手 Grabbing Style<br>当你开启擒拿手流派时，你在仅用单手擒抱目标的战技攻击检定上不再承受-4减值。除此之外，你在压制一个敌人时不再会失去防御等级上的敏捷加值。</td></tr>
       <tr><td>擒拿手-擒龙控鹤 Grabbing Drag<br>你可以以移动动作对三十尺内一个生物发起擒抱检定，若成功则将其拉向你，该移动及本能力均会引发借机攻击。</td></tr>
       <tr><td>擒拿手-五指山 Grabbing Master<br>你可以擒抱任何生物，即使它对其免疫。</td></tr>
       <tr><td rowspan="3">鹿家</td>
           <td>鹿家赶蟾步 Charging Stag Style<br>当你使用鹿家赶蟾步且并未骑乘时，可以冲锋穿过友军，小障碍物或困难地形，在必要时转向。你必须在冲锋开始时就能看到你的目标，并且冲锋结束时也只能进行一次攻击，即使你通常可以进行多次攻击（例如猛扑能力）。</td></tr>
       <tr><td>鹿家鹰爪功 Stag Horns<br>当你使用鹿家赶蟾步时，如果你在冲锋结束时进行了一次成功的徒手攻击，那么你可以免费对目标进行一次不会引发借机攻击的擒抱检定。</td></tr>
       <tr><td>鹿家一指 Stag Submission<br>当你使用鹿家赶蟾步并成功通过战技检定压制敌人时，你可以选择同时将敌人击倒或者对敌人造成攻击伤害。</td></tr>
       <tr><td rowspan="3">玄武</td>
           <td>玄武掌 Snapping Turtle Style<br>当你处于该流派架势时，你在AC上得到+1盾牌加值。</td></tr>
       <tr><td>玄武寂灭抓 Snapping Turtle Clutch<br>你从该流派架势获得的盾牌加值能加到CMD和接触AC上；当你采用该流派架势时，如果对手对你近战攻击失手，每轮一次你可对该对手发起一次受-2减值的擒抱。</td></tr>
       <tr><td>玄武不坏神功 Snapping Turtle Shell<br>当你处于该流派架势时，你在此架势获得的盾牌加值变成+2，而且对手对你的重击确认骰受到-4减值。</td></tr>
       <tr><td rowspan="3">缠丝手</td>
           <td>缠丝手 Kraken Style<br>当你使用该流派并成功通过一次擒抱检定时，被你擒抱的目标额外受到等同于你感知调整值的数值的钝击伤害。此外你维持擒抱的擒抱战技检定获得+2加值。</td></tr>
       <tr><td>缠丝手-金蛇擒鹤 Kraken Wrack<br>你在擒抱战技检定成功时触手流专长所提供的额外伤害增加为你的感知调整值+4力场伤害。当你使用该流派时，你在成功维持擒抱后可以选择压碎目标，而非锁喉、造成伤害、移动、压制或捆绑目标。若如此做，一回合内目标失去护甲带来的防御加值。</td></tr>
       <tr><td>缠丝手-万蛇出洞 Medusa's Wrath<br>每当你进行全力攻击并做出至少一次徒手击打攻击时，你可以额外以最高BAB做出两次徒手击打攻击。这些额外攻击必须针对晕眩、措手不及、麻痹、恍惚、震慑或昏迷状态的敌人。</td></tr>
       <tr><td rowspan="3">散花掌<br></td>
           <td>散花掌 Jabbing Style<br>当你徒手攻击命中一名单位时，若本轮你之前也用徒手攻击命中过该单位，则你本次徒手攻击额外造成1d6点伤害。</td></tr>
       <tr><td>一苇渡江 Jabbing Dancer<br>在使用散花掌流派时，你在进行五尺快步时可以额外移动五尺距离。</td></tr>
       <tr><td>如来千叶手 Jabbing Master<br>在使用散花掌流派时，你同一轮两次徒手击打命中造成的额外伤害提升到2d6。三次或以上徒手击打命中造成的额外伤害提升到4d6。</td></tr>
       <tr><td rowspan="3">豹尾脚</td>
           <td>豹尾脚 Panther Style<br>当你使用豹尾脚流派时，当你在穿过威胁区域而引发借机攻击时，你能以迅捷动作用徒手攻击你的对手。这次攻击在诱发对方借机攻击后才能发动。</td></tr>
       <tr><td>九转连环腿 Panther Claw<br>你使用豹尾脚流派时，你可以用自由动作进行对借机攻击的反击。你在你的行动轮中可以做出等同你感知修正次数的反击。</td></tr>
       <tr><td>神龙摆尾 Panther Parry<br>你使用豹尾脚流派时，你的反击可以在对方进行借机攻击前作出，如果你的这次反击对对手造成伤害，对手对你的借机攻击在攻击骰和伤害骰都有-2罚值。</td></tr>
           <td rowspan="3">美人三招</td>
           <td>美人三招-贵妃回眸 Cloak and Dagger Style<br>你的攻击能轻易对未察觉的对手造成不良状态。选择一种轻型近战武器。当你开启该流派时，你用所选的武器在你进入战斗的第一回合中首次攻击一个失去AC上的敏捷加值的敌人时，你可以用自由动作对该敌人进行一次阴招战技检定。</td></tr>
       <tr><td>美人三招-小怜横陈 Cloak and Dagger Subterfuge<br>当你开启美人三招并持用你所选的武器时，每当你对一个敌人进行借机攻击时，你同时还能用一个自由动作对他进行一次额外的阴招战技检定。另外。每当你成功对一个敌人进行阴招战技时，你能立刻以一个自由动作对他进行一次缴械战技检定。</td></tr>
       <tr><td>美人三招-飞燕回翔 Cloak and Dagger Tactics<br>当你开启美人三招并持用你所选的武器时，每当你击中一个失去AC上的敏捷加值或被你夹击的敌人，或是使用要害打击（以及其精通和高等版本）进行一次攻击时，你可以用自由动作对该敌人进行一次阴招战技检定。如果你成功了，该目标必须成功通过强韧检定（DC=10+1/2你的BAB+你的智力调整），否则就会困惑，如果免疫则会恍惚，如果免疫则会力竭，如果免疫则会被钉在原地不能移动。无论阴招造成的普通惩罚持续多久，该额外的惩罚只持续一轮。你每轮只能使用该专长一次来以进行额外的阴招战技检定。</td></tr>
       <td rowspan="3">枪舞流</td>
           <td>枪舞流 Spear Dancing Style<br>使用此流派时，你可以单手持用任何来自长柄或枪矛战士武器组中的武器。</td></tr>
       <tr><td>枪舞流-少林棍法禅宗 Spear Dancing Spiral<br>使用枪舞流时，你的这些武器获得武器娴熟的好处。此外，你还可以用它们施展两仪回风，韦陀杵和伏魔杖。</td></tr>
       <tr><td>枪舞流-纪效新书 Spear Dancing Reach<br>使用枪舞流时，你的触及增加5尺。</td></tr>
       <tr><td colspan="2">大力金刚掌 Smashing Style<br>使用这个流派时，当你成功使用击破战技对敌人的盔甲造成伤害后，你可以立即用相同的战技加值尝试冲撞或者绊摔，不引起借机攻击。</td></tr>
       <tr><td colspan="2">韦陀杵 Stick-Fighting Counter<br>当你进行防御式攻击时，可以准备反击本回合攻击过的敌人，每轮限一次，当其对你的近战攻击失手时，会引起你的借机攻击。你需要处于能威胁他的范围，且持用棍棒类武器。</td></tr>
       <tr><td colspan="2">伏魔杖 Stick-Fighting Maneuver<br>当你使用棍棒类武器全回合攻击时，你可以以最高攻击加值使用一次额外的战技。</td></tr>
  <tr><td rowspan="7">魔法技艺</i></td>
       <tr><td rowspan="5">魔法技艺（法师之手） Magic Trick (mage hand)<br>只要你符合相应要求即可施展法师之手的任何魔法技艺。</td></tr>
       <tr><td colspan="2">魔法阴招（精通阴招） Dirty Magic Trick<br>可以以你的CMB对近距内的一个对手使用阴招战技。</td></tr>
       <tr><td colspan="2">远程协助（基础攻击加值+1） Ranged Aid<br>你可以在近距内远程使用援助他人动作。</td></tr>
       <tr><td colspan="2">劈空掌（精通徒手打击） Throw Punch<br>你可以用法师之手在近距内进行近战徒手击打，造成1D3点力场伤害。ab等于你的施法者等级加上最高精神属性调整值。法术抗力对该技艺生效。你不能以此全回合攻击。</td></tr>
       <tr><td colspan="2">弹指神通（精准射击或法术及远） Reaching Hand<br>你能以迅捷动作集中注意力，将劈空掌距离增加至中距。</td></tr>
       <tr><td colspan="2">魔法技艺（护盾术） Magic Trick (shield)<br>你可以让你的盟友获得你的护盾术的好处。你失去其好处，你的盟友在法术持续时间内获得其好处。</td></tr>
  <tr><td rowspan="14">神话专长</i></td>
       <td colspan="2">擒抱（神话） Grapple (Mythic)<br>在你尝试进行擒抱检定，或者对试图擒抱你的敌人做战技防御（CMD）时，获得等于神话阶层一半的加值。这个加值能够和精通擒抱提供的加值叠加。另外，你还能对任何擒抱你的生物发起借机攻击，除非它也有这个专长。</td></tr>
       <tr><td colspan="2">粗野擒抱 Uncanny Grapple<br>当你对正在擒抱的对手施加野蛮裂地时，你可以将其投掷到最多每神话阶层 10 尺远处，造成每神话阶层 10 点神力伤害，且目标会被击倒为俯卧。</td></tr>
       <tr><td colspan="2">飞跃突袭 Aerial Assault<br>当进行冲锋攻击时，你可以将冲锋中的近战攻击改为进行擒抱检定，即使目标生物在通常状况下免疫擒抱也是如此。</td></tr>
       <tr><td colspan="2">绳结专家 Knot Expert<br>以一个整轮动作，你可以对范围内的任何生物进行一次远程接触攻击，如果击中可以尝试使用擒抱战技检定，将你的神话阶层加入战技检定中。如果成功，你不被视为进入擒抱状态，但不能移动。</td></tr>
       <tr><td colspan="2">肉盾 Meat Shield<br>若你正在擒抱1名生物，并且受到近战或远程攻击，以直觉动作，你能够尝试进行擒抱战技检定对抗被擒抱的敌人。若成功，到来的攻击会以你擒抱的敌人为目标。若失败，被擒抱的敌人会从擒抱中挣脱，到来的攻击会如常以你为目标。</td></tr>
       <tr><td colspan="2">多米诺牌手 Down Like Dominoes<br>成功绊摔一个敌人时，可以用自由动作再绊摔一个附近的敌人，但有-4减值。如果这次绊摔也成功，立刻移动至其方格并可以继续绊摔，获得累计的-4减值，以此类推。一轮内最多能如此额外绊摔的生物数量等于1+你一半的神话阶级。</td></tr>
       <tr><td colspan="2">闪破风暴 Sunder Storm<br>当你成功使用击破战技，你将打碎的物品碎片轰入穿戴着血肉之中，造成1d6+神话等级点神力伤害。此外，你可以用一个整轮动作向武器范围内所有敌人尝试击破战技。</td></tr>
       <tr><td colspan="2">血肉撕扯 Tear Apart<br>你的击破战技不再禁用对手的盔甲，二是直接撕裂它。如果战技检定成功，你造成武器攻击伤害并在对手的盔甲，天生护甲或者盾牌加值中减少等同于神话等级1/2的加值（至少为1），如果对手在上述加值中有增强加值，也可以扣减，但不能扣减成负值。</td></tr>
       <tr><td colspan="2">远程缴械（神话） Ranged Disarm (Mythic)<br>你可以轻松使用远程攻击缴械对手。在远程缴械时增加等同于神话等级的加值，如果该缴械成功，再尝试一次额外的缴械。</td></tr>
       <tr><td colspan="2">战技专家 Maneuver Expert<br>你的所有豁免-2，因为你将这部分神话之力用于在尝试战技检定时，获取对应战技的精通和高等专长效果。</td></tr>
       <tr><td colspan="2">太极-四两拨千斤 Ki Throw Mastery<br>你能通过阴招，缴械或击破来使用太极拳。另外，你的目标每比你大一个体型，你的战技检定就获得+2加值。</td></tr>
       <td colspan="2">神导之手（神话） Guided Hand(Mythic)<br>当你使用偏好武器时，你在掷武器伤害骰时可以用你的感知修正代替力量或敏捷修正。</td></tr>
       <tr><td colspan="2">拨挡飞箭（神话） Deflect Arrows (Mythic)<br>当你使用拨挡飞箭专长时，每轮能够偏转远程攻击的次数增加等同于你的神话等级的一半。你也可以偏转以你为目标且来自射线法术或效果的单条射线。</td></tr>
       <tr><td colspan="2">血脉传承（神话） Racial Heritage (Mythic)<br>选择另一个类人种族。在获得特性和专长时，你可以视为那个种族。然后，你获得所选种族的一个特性。</td></tr>

  <tr><td rowspan="10">神话进阶职业特性</i></td>
       <td colspan="2">轻巧夺命 Swift Death<br>你的夺命攻击变成标准动作，刺客10级时还会变成移动动作。</td></tr>
       <tr><td colspan="2">高等轻巧夺命 Greater Swift Death<br>你的夺命攻击变成移动动作，刺客10级时还会变成迅捷动作。</td></tr>
       <tr><td colspan="2">固若金汤 UnbreakableDefance<br>你使用防御姿态时不再有轮数限制。</td></tr>
       <tr><td colspan="2">龙翼 Draconic Wings<br>你获得两个1d4翼击作为主要天生武器。</td></tr>
       <tr><td colspan="2">无尽吐息 Endless Breath<br>你每回合开始时有1/3概率恢复一次吐息次数，另外，你的金龙道途吐息变成移动动作。</td></tr>
       <tr><td colspan="2">格挡反击（神话）Riposte (Mythic)<br>决斗家在格挡和反击时将神话等级加到攻击骰上，不与时刻备战神话专长的效果叠加。</td></tr>
       <tr><td colspan="2">形上学偷袭 Metaphysical Sneak Attack<br>战争学徒在偷袭敌人时自动研究目标，可以直接进行知识检定。另外，他的偷袭伤害不再是精准伤害。</td></tr>
       <tr><td colspan="2">秘术催化剂 Mystic Catalyst<br>你能随意使用次级双法合璧。</td></tr>
       <tr><td colspan="2">阿卡西之秘 Secret of the Akashic<br>将阿卡西窥视术和阿卡西构形添加到你的所有法术列表中。（博学士）</td></tr>
       <tr><td colspan="2">魅影之秘 Secret of the Phantom<br>将魅影杀手，魅影蛛网和魅影手添加到你的所有法术列表中。（博学士）</td></tr>
  <tr><td rowspan="23">法术 spell</i></td>
       <tr><td colspan="2">正义祷言 Litany of Righteousness<br>如果目标是邪恶阵营，拥有善良灵光的生物（当且只有当你是崇拜善良神明的牧师/战斗祭司，圣武士或善良异界生物时你才具有善良灵光。）的攻击对其造成双倍伤害。如果目标同时拥有邪恶亚种，它还会目眩1d4轮。</td></tr>
       <tr><td colspan="2">护卫他人 Shield Other<br>受术者的AC获得+1偏斜加值，豁免检定获得+1抗力加值。另外受术者所受的任何造成HP损失的创伤和攻击均减半 (包括由特殊能力造成的)，剩下的部分则由施法者承受。使用移动动作来结束法术而不是移出范围，这样你就不会在过场动画、酒馆等过程中丢失它。</td></tr>
       <tr><td colspan="2">后继者神击术 Inheritor's Smite<br>你在下一次发动近战攻击（若在下一回合结束前发动攻击）时，攻击检定可以获得+5神圣加值。如果该攻击命中，你可以立即尝试冲撞目标（对抗检定时同样获得+5神圣加值），并且不会引发借机攻击。</td></tr>
       <tr><td colspan="2">洛瓦古格之怒 Rovagug's Fury<br>对法术区域内所有生物进行一次摔绊攻击检定。你不会因为这次摔绊攻击而引发借机攻击（但是施放此法术可能会引发借机攻击）。</td></tr>
       <tr><td colspan="2">激流术 Hydraulic Torrent<br>你召唤一股强力的水流，冲击其路径上的所有生物和障碍物，直到撞上推不动的东西。水流路径上所有生物都受到一次冲撞战技攻击。你的冲撞战技检定加值等于你的施法者等级加上你精神属性调整值中最高的一项。这次冲撞不会引发借机攻击。</td></tr>
       <tr><td colspan="2">雷霆重踏 Thunderstomp<br>你用力跺脚或者使用武器击打地面，这会创造出能够用于摔绊一个生物的强大震波。尝试战技检定来摔绊目标，你的战技检定加值等于你的施法者等级加上你的施法属性调整值，且不会引发借机攻击。</td></tr>
       <tr><td colspan="2">高等雷霆重踏 Thunderstomp, Greater<br>该法术如同雷霆重踏一般，除了后述内容以外：法术对效果区域内所有生物有效，无关目标体型大小。对区域内所有生物进行一次战技检定。</td></tr>
       <tr><td colspan="2">念动战技 Telekinetic Maneuver<br>每轮一次，你可以使用心灵遥控在近程范围内进行冲撞、缴械、或者绊摔。此外，你还可以进行擒抱 (包括压制) 。如常处理这些战技尝试，但你的战技检定加值等于你的施法者等级加上你的施法者属性调整值，且不会引发借机攻击。对方不能进行豁免检定，但法术抗力仍会生效。</td></tr>
       <tr><td colspan="2">冲阵术 Linebreaker<br>你在冲撞以及闯越战技检定上获得+2加值。</td></tr>
       <tr><td colspan="2">剑刃鞭笞 Blade Lash<br>你的武器被拉长，变得如同鞭子一般。作为施放该法术的一部分，你能够使用该武器尝试对20尺内的一个生物进行一次摔绊战技，而且你在检定中获得+10加值，在此之后，你的武器会还原至它原本的形态。</td></tr>
       <tr><td colspan="2">树脂皮肤 Resinous Skin<br>你获得DR5/穿刺，对抗缴械的CMD+4环境加值。此外，你的擒抱、保持擒抱和压制敌人的战技检定获得+2环境加值。任何被你擒抱的敌人在试图打破擒抱和逃离擒抱时都有-2减值。任何武器在命中你之后都会被粘住，除非持有者通过一次反射检定。当你以此法粘住武器时，可以立刻施展缴械战技。"</td></tr>
       <tr><td colspan="2">第三只手 Pilfering Hand<br>你创造并且控制一股无形的精神力量，立刻对范围内的一个目标施展缴械战技。使用你的施法者等级作为你的战技加值，加上你的施法者属性调整值。该战技不会引发目标的借机攻击（但是施放此法术可能会引发借机攻击）。</td></tr>
       <tr><td colspan="2">不谐冲击 Linebreaker<br>你制造一股轰鸣的力场波动，影响以你为中心半径10尺的范围，或者30尺锥形的范围。在该区域内的生物会受到3d6点音波伤害并被推开，如同被冲撞一般。对区域内的所有生物进行战技检定。你的冲撞CMB等同于你的施法者等级+魅力调整值。该冲撞不会引起借机攻击。</td></tr>
       <tr><td colspan="2">钳颚术 Lockjaw<br>你令一个生物能够使用某种天生武器将自身紧紧附着在敌人身上。当未处于变形效应下时，该生物的爪抓或者啮咬攻击获得擒抓能力，包括在尝试以及维持擒抱时，战技检定获得的+4加值。</td></tr>
       <tr><td colspan="2">烦扰巨人 Vex Giant<br>当你施放侵扰巨人后，若敌人的体型比你至少大1级，你的感官与身手会就在对抗60尺内的单个敌人时变得更加凌厉。你可以在施放该法术时以自由动作选择你所专注的敌人——将你专注的目标切换为60尺内的另一个敌人是移动动作。法术名称虽然叫侵扰巨人，但对付其他比你体型至少大1级的目标时也有用。在对抗你所专注的敌人时，你不会引起其借机攻击。此外，在一轮内你对该名敌人做出的第一次成功近战攻击会额外造成1d6点伤害。最后，在对抗专注敌人时，你的战技检定均会获得+4洞察加值。</td></tr>
       <tr><td colspan="2">大师表演 Virtuoso Performance<br>在该法术生效时，你可以在维持一种吟游表演的同时开始进行第二种吟游表演。每轮同时维持两种吟游表演需要花费共计3轮而非2轮吟游表演轮数。</td></tr>
       <tr><td colspan="2">魅影手 Phantom Limb<br>该法术创造一个半可见的异能显现物，令目标长出两条魅影手臂，提供两次额外的天生爪抓攻击（1d4）。</td></tr>
       <tr><td colspan="2">阿卡西构形 Akashic Form<br>施放法术时，你在阿卡西记录中创造出自身肉体的完美记录。在法术持续时间内的任何时候，若你的生命值降低到零以下，改为恢复全满。</td></tr>
       <tr><td colspan="2">阿卡西窥视术 Virtuoso Performance<br>释放法术后在接下来的一天中，你可以通过自由动作激活你从阿卡西记录中获取的知识；当你这么做时，你在所有的技能鉴定、攻击检定、伤害检定、豁免检定以及战技检定上获得等于你的施法者等级的环境加值，持续1分钟。在这段时间结束之后，阿卡西记录那磅礴浩荡之性侵入了你的心智，令你震慑2轮并恶心1分钟。</td></tr>
       <tr><td colspan="2">衰竭剧痛 Debilitating Pain<br>目标被剧烈的痛苦压垮，使得它在豁免失败时被震慑。而成功通过豁免时则为眩晕1轮。</td></tr>
       <tr><td colspan="2">群体衰竭剧痛 Debilitating Pain, Mass<br>该法术如同衰竭剧痛，但你可以指定近距范围内生命骰数最高的敌人，其总数等于施法者等级除以4。</td></tr>
       <tr><td colspan="2">赫氏潜能术 Hermean Potential<br>你赐予目标通过清晰的头脑完美执行动作的能力。在目标尝试下一次攻击投骰，豁免检定或技能检定时，可以投骰两次，并取更有利的结果。你每有5个施法者等级，目标就可以额外重骰一次（次数最多在20级时达到5次）。</td></tr>
       <tr><td rowspan="8">其余修改</i></td>
       <tr><td colspan="2">拔刀术 Quick Draw<br>如果剑爵已经拥有拔刀术或者警觉专长，他获得阿尔多瑞决斗精通作为额外专长。</td></tr>
       <tr><td colspan="2">教理讲授 Catechesis<br>若地狱骑士持节士拥有以战筑信专长，他的地狱骑士持节士等级与其他神术施法者等级叠加，以计算那些职业的领域效果，但不会因此获得新能力。拥有以战筑信专长的持节士还会获得选择导能作为额外专长。</td></tr>
       <tr><td colspan="2">Estimated THC Shield Other<br>在回合模式下显示攻击命中和法术豁免概率。并不精确，因为它无法计算一些效果，例如隐蔽，法术穿透和有条件的豁免加值。（默认关闭）</td></tr>
       <tr><td colspan="2">地狱治疗 Infernal Healing<br>你可以通过花费金币在战斗之外完全治愈，如同你购买一根地狱治疗魔杖并使用它一样。（金币：生命值=3：2）</td></tr>
       <tr><td colspan="2">Weak Crits against Enemies<br>Symmetrical with owlcat weak crits settings, making it fair (default off)</td></tr>
       <tr><td colspan="2">修复高难度cmd Fix Difficulty CMD Tripple-Dipped<br>这将在较高难度下显着降低敌人的 CMD。CMD 是通过添加力量加值、敏捷加值和AC加值来计算的，这意味着原版难度属性提升在cmd中提升了3次，导致数值完全疯了。</td></tr>
       <tr><td colspan="2">修复猛力攻击 Fix Power Attack<br>现在按描述工作：如果您使用副手武器进行攻击，则伤害加成减半（–50%）。请注意，食人鱼打击也有相同的错误，但尚未修复，因为这可能会让食人鱼打击比猛力攻击更具优势，这非常酷。</td></tr>
</table>    

-------------------------------------------   
### [TransfiguredCasterArchetypes](https://github.com/AdamMeloy/TransfiguredCasterArchetypes)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 变体<br>
<table>
 <tr><th colspan="3">新增内容列表<br></th></tr> 
  <tr><td rowspan="1">变体</i></td>
       <td rowspan="1">审判官</td>
	       <td>怀言者 Living Grimoire</td></tr>
</table>    

-------------------------------------------   
### [HomebrewWarlock](https://github.com/microsoftenator2022/HomebrewWarlock)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 职业<br>
+ 移植并改编DND3.5E的邪术师到WOTR
<table>
 <tr><th colspan="2">新增内容列表<br></th></tr> 
  <tr><td rowspan="2">职业</i></td>
       <td rowspan="1">原邪术师 Warlock</td></tr>
	       <td>注：由于MysticalMayhem已经添加了为PF设计的第三方规则邪术师（Warlock），为了更好区别两者，故翻译中将该来自DND3.5E移植改编的职业改名原邪术师，并将Eldritch Blast译名改为“魔能爆”，以防止相关专长混淆。</td></tr>
  <tr><td rowspan="1">专长</i></td>
       <td rowspan="1">魔能爆相关超魔</td></tr>
</table>    

-------------------------------------------  
### [AutomaticBonusProgression](https://github.com/WittleWolfie/AutomaticBonusProgression)
> *前置：* ModMenu<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 可选规则：自动增长加值<br>
+ 引入变体规则，角色无需给予加值和属性的物品，他们将在等级成长的过程中自动获得这些加值，至此他们可以空下那些装备栏位给各种有特效的物品
<table>
 <tr><th>新增内容列表<br></th></tr> 
  <tr><td>参阅http://li1186-129.members.linode.com/bbs/index.php?topic=76351.0</td></tr>
</table>    

-------------------------------------------  
### [WOTR_MAKING_FRIENDS](https://github.com/Balkoth-dev/WOTR_MAKING_FRIENDS)
> *前置：* ModMenu<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 职业<br>
+ 添加召唤师。职业详情可参考CHM
<table>
 <tr><th colspan="5">新增内容列表<br></th></tr> 
  <tr><td rowspan="1">职业</i></td>
       <td colspan="2">召唤师 Summoner Mod</td></tr>
  <tr><td rowspan="1">神话能力</i></td>
	<td rowspan="1">进化召唤<br>Evolved Summons</td>
	<td rowspan="1">每当你召唤任何生物的时候，它们都会共享幻灵的所有进化。注意：召唤物不会因为进化改变体型，但会共享从体型增大进化增加的属性。</i></td>
  <tr><td rowspan="15">法术</i></td>
	<td rowspan="1">召唤次级怪物<br>Summon Minor Monster</td>
	<td rowspan="1">这个法术类似召唤一级怪物，但是你可以召唤1d3只超小型或更小的动物。</i></td>
	<tr><td rowspan="1">召唤狂躁邪魔<br>Summon Cacodaemon</td>
        <td rowspan="1">这个法术类似召唤怪物，除了它只能召唤一个狂躁邪魔。</i></td>
        <tr><td rowspan="1">高等召唤狂躁邪魔<br>Summon Cacodaemon, Greater</td>
	<td rowspan="1">这个法术类似召唤狂躁邪魔，除了它能召唤1d4＋1只狂躁邪魔。</i></td>
	<tr><td rowspan="1">飞虫走兽<br>Summon Swarm</td>
        <td rowspan="1">你可以召唤一个蜘蛛集群来攻击它所在区域内的所有生物 (你可以召唤这些集群并于其他其他生物共用同一片区域内)。</i></td>
	<tr><td rowspan="1">萌龙仆从<br>Draconic Ally</td>
	<td rowspan="1">你创造一个有智力的半生命体，这种萌龙仆从可以忠诚地服从和侍奉你。</i></td>
	<tr><td rowspan="1">召唤次级恶魔<br>Summon Lesser Demon</td>
	<td rowspan="1">这个法术类似召唤怪物，除了它能召唤一个火灾魔，一个梦魔，1d3个希尔魔或者1d4个虫裂魔。</i></td>
	<tr><td rowspan="1">召唤狂野兽群<br>Summon Stampede</td>
	<td rowspan="1">这个法术类似召唤怪物，除了它召唤1d4＋4匹马。这些马不会攻击敌人，但会不断在战场移动，包围敌人并造成伤害。</i></td>
	<tr><td rowspan="1">关门放狗<br>Release The Hounds</td>
	<td rowspan="1">这个法术类似召唤怪物，除了它能召唤1d4＋4只霜狼。这些霜狼不会攻击敌人，但会不断在战场移动，包围敌人并造成伤害。</i></td>
	<tr><td rowspan="1">召唤怒魔<br>Summon Erinyes</td>
	<td rowspan="1">这个法术类似召唤怪物，除了它能召唤一个怒魔。</i></td>
	<tr><td rowspan="1">召唤饥馑邪魔<br>Summon Meladaemon</td>
	<td rowspan="1">这个法术类似召唤怪物，除了它能召唤一个饥馑邪魔。</i></td>
	<tr><td rowspan="1">黑触手<br>Black Tentacles</td>
	<td rowspan="1">这个法术产生一片具有韧性的黑色触手，它们从地上涌起并伸向区域内的任何生物，每轮对生物进行一次擒抱战技检定。</i></td>
	<tr><td rowspan="1">地狱治疗<br>Infernal Healing</td>
	<td rowspan="1">你以魔鬼血液或诅咒邪水涂抹受伤生物，使其获得1快速治疗。</i></td>
        <tr><td rowspan="1">高等地狱治疗<br>Infernal Healing, Greater</td>
	<td rowspan="1">你以魔鬼血液或诅咒邪水涂抹受伤生物，使其获得4快速治疗。</i></td>
        <tr><td rowspan="1">激情四溢<br>Overstimulate</td>
	<td rowspan="1">你使一个目标获得凶猛（ferocity）能力。</i></td>
 	<tr><td rowspan="1">幻灵重塑术<br>Transmogrify</td>
  	<td rowspan="1">该法术允许你通过将幻灵的进化池分配给新的进化，来改变它当前的任何进化。</i</td>
	
 
	
</table>    

-------------------------------------------  
### [PathofWar](https://github.com/novumvita/PathofWar)
> *前置：* 无<br>
> *中文：* ql汉化<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 战争之路<br>
+ 添加第三方资源战争之路中的武技系统。好评更新中
<table>
<tr><th colspan="4">房规改动<br></th></tr> 
       <tr><td colspan="5">所有应对（Counter）都改为架势，且出于平衡考虑每轮只能激活一次效果</td></tr>
       <tr><td colspan="5">所有角色都可以在1级选择流派，并在升级时选择击技和架势。</td></tr>
       <tr><td colspan="5">可以同时激活2个架势。</td></tr>
<tr><th colspan="5">武术流派<br></th></tr> 
<tr><th colspan="5">辉晨<br></th></tr> 
  <tr><td rowspan="6">击技 Strike</i></td>
       <td colspan="2">柳叶扶风 Dismiss (Mythic)<br>发起一次攻击。如果它击中，你会如常造成武器伤害并对目标进行绊摔尝试。如果你的绊摔尝试成功，目标也会被推开。当决定你这次打击的战技加值时，你用你的角色等级代替你的基础攻击加成，用你的武术属性调整代替你的力量调整值。</td></tr>
       <td colspan="2">趁势而起 Lifeburst Strike<br>进行一次攻击，如果命中，如常造成武器伤害，并治疗自己和附近盟友，总数值和武术属性调整成比例，治疗量在你和盟友之间分配，优先严重受伤的目标。</td></tr>
       <td colspan="2">黄泉判令 Decree of Death<br>挑选一个目标执行判断。进行一次攻击，如果命中，如常造成武器伤害，且一轮内下一次对其造成的伤害实例伤害增加50%。</td></tr>
       <td colspan="2">暴君之终 Tyrant's End<br>进行一次攻击，如果命中，你额外造成6d6的伤害，并且目标的伤害减免、能量抗力和免疫都被压制1轮，并在1轮内对所有类型的伤害易伤。</td></tr>
       <td colspan="2">破法驱魔 Shatter Spell<br>进行一次攻击，如果命中，如常造成武器伤害并增加额外的2d6点伤害。目标会受到目标型解除魔法的影响。此能力的施法者等级等于武术家等级。</td></tr>
       <td colspan="2">九狱断罪 Judgement Day<br>该区域内的所有敌人都被纯净的阿克夏之火焚烧，受到50点神圣伤害。范围内的盟友会受到被治疗50点的伤害。这种治疗作用如同生命之息法术，可以使目标复活。</td></tr>
  <tr><td rowspan="3">应对 Counter</i></td>
       <td colspan="2">格物知天 Bolster<br>你使盟友下次被敌人击中时，获得等于你武术属性调整的DR/-，持续1轮。</td></tr>
       <td colspan="2">慈悲为怀 Decree of Mercy<br>下次目标使用造成生命值伤害的效果时，不会杀死受影响的目标。</td></tr>
       <td colspan="2">位高责重 Noblesse Oblige<br>每当近距离内的盟友死亡或被摧毁时，即使不是你的回合，你回启动这项武技。该盟友的生命值变为1。然后，你对触发该武技的攻击者造成（4d6+你的武术属性调整）点伤害，同时你也会治疗受该动作影响的盟友等量生命值。</td></tr>
  <tr><td rowspan="4">架势 Stance</i></td>
       <td colspan="2">天下布武 Spoils of War<br>当你保持这个架势时，近距离内的盟友每次攻击命中都会恢复 3 点生命值。在 5 级时，此治疗效果会增加到你的武术属性调整加 3。在 10 级时，此治疗效果会增加到你的武术属性调整的两倍加 3。此效果每个盟友每轮只能触发一次。</td></tr>
       <td colspan="2">金乌困笼 The Caged Sun<br>当你保持这个架势时，你无法治疗除你自己之外的生物，但你收到的任何治疗效果都会提高 50%。如果您获得的治疗量超过了最大生命值，您将获得相当于超额治疗量的临时生命值。这些临时生命值持续一分钟。</td></tr>
       <td colspan="2">帝国武装 Armaments of the Empire<br>当你保持这个架势时，你可以增强近距离盟友的武器和盔甲。每件武器都获得神圣附魔和+3增强加值，每件盔甲都获得+3增强加值。</td></tr>
       <td colspan="2">大日凌天 Battle Against the Sun<br>当你保持这个架势时，你会在近距离范围内发出明亮的光芒，如同昼明法术。每轮开始时，您都会在昼明范围内发出一道闪光。区域内的敌人受到的伤害等于你的武术家等级+战斗持续的轮数。成功的反射豁免（DC 16 + 武术属性调整）可将该伤害减半。与之相反，被光线包围的盟友会受到治疗，生命值等于你的武术家等级+战斗持续的轮数。</td></tr>
  <tr><td rowspan="1">强化技 Boost</i></td>
       <td colspan="2">无暇判令 Decree of Purity<br>在近距离内治疗自己和盟友，总数值和武术属性调整成比例，治疗量在你和盟友之间分配，优先严重受伤的目标。</td></tr>
<tr><th colspan="5">朦月<br></th></tr> 
  <tr><td rowspan="6">击技 Strike</i></td>
       <td colspan="2">月食 Eclipsing Moon<br>以一个全回合攻击动作，使用者可以攻击一个目标并传送至一个距离不超过他的基本陆地速度的新目标，再次发起攻击，每次攻击都对应目标的措手不及AC，他能够多次重复这一流程，最多等同于他在全回合攻击中所能做出的攻击次数（包括副手攻击和次要攻击）。他可以多次攻击同一个目标，但每次传送的位置必须允许他攻击一个目标生物（他必须在每次传送结束时进行攻击）。如果敌人死于其中一次攻击，她将获得额外的攻击次数。</td></tr>
       <td colspan="2">闪现之触 Flashing Ether Touch<br>使用者对目标进行一次近战接触攻击，若攻击命中，目标必须通过意志豁免（DC17+关键属性调整值）否则将被传送最多60尺远。成功的豁免检定能令招式失效，若豁免失败，目标将因为高速撞击地面而承受10d6点伤害并倒地。</td></tr>
       <td colspan="2">歪曲虫洞 Warp Worm<br>使用者传送到所选的目标，然后传送到距第一个目标最近的敌人，并对第三个目标也重复此流程，对受影响的敌人造成 10d6 点力场伤害，通过意志豁免可以减半（DC 17 + 武术调整值）。 结束了对最后一个目标的攻击之后，门徒出现在最后的目标的背后10尺处以结束她的回合。</td></tr>
       <td colspan="2">维度打击 Dimensional Strike<br>此招式的使用者能让他的敌人对这次攻击措手不及。</td></tr>
       <td colspan="2">消散打击 Dispersal Strike<br>使用者对目标生物进行一次攻击，若攻击命中，则能造成额外6d6点力场伤害，且目标在1d4轮中获得虚体亚种。此招式对已经是虚体的目标没有效果。</td></tr>
       <td colspan="2">虚体破碎 Vaporform Crash<br>门徒对一个虚体目标进行一次近战攻击，若攻击命中，目标将在1d4轮间失去虚体亚种，并承受18d6点力场伤害，门徒在 1d4 轮内获得虚体亚种。</td></tr>
  <tr><td rowspan="1">应对 Counter</i></td>
       <td colspan="2">月之半影 Lunar Penumbra<br>使用者进行一次隐匿检定，对抗攻击者的察觉检定。若检定成功，他和攻击者将交换位置，并且指向门徒的攻击现在将转而影响攻击者，有效地让目标命中他自己。</td></tr>
  <tr><td rowspan="4">架势 Stance</i></td>
       <td colspan="2">次元门之姿 Stance of the Ether Gate<br>当门徒处于这个架势时，她可以随意传送而不是移动。她的正常移动速度仍然适用。她必须清楚地看到自己的目的地才能传送到目的地。传送时使用者不得携带任何生物；只有她自己和她携带的装备。</td></tr>
       <td colspan="2">锚定灵魂 Anchoring Spirit<br>当处于此架势中时，使用者获得虚体亚种，且他身边30尺范围内所有敌人使用（传送）类效果的尝试都有可能失败。一旦离开此架势的影响范围，生物便不再受到影响。</td></tr>
       <td colspan="2">无形之舞 Formless Dance<br>当处于此架势中时，门徒获得识破隐形（see invisibility）和朦胧术（blur）法术的好处。</td></tr>
       <td colspan="2">灵魂武器之姿 Spiritual Weapon Stance<br>当处于此架势中时，使用者的武器如同具有幽冥特性一般处理，并且他的攻击能造成额外2d6点力场伤害。这些来自灵界的能量能起到减缓法术攻击的作用，给予门徒5+等级点的法术抗力。</td></tr>
  <tr><td rowspan="2">强化技 Boost</i></td>
       <td colspan="2">次元回转 Twisting Ether<br>以一个迅捷动作，使用者可以指定30尺范围内的一位自愿的盟友，并通过传送与他交换位置。</td></tr>
       <td colspan="2">幽灵步 Ghostwalk<br>直到他的下个行动轮开始时，使用者获得虚体亚种。</td></tr>
  <tr><td rowspan="2">无类型 Untyped</i></td>
       <td colspan="2">逝形穿梭 Fade Through<br>使用者可以以一个迅捷动作传送最多不超过他的基本陆地速度的两倍的距离。</td></tr>
       <td colspan="2">飘渺回忆 Ethereal Reminiscence<br>在虚体状态下的一个标准动作，使用者可以恢复两倍于隐匿技能等级的生命值。</td></tr>

</table>   

-------------------------------------------  
### [RandomEquipment](https://github.com/thehambeard/RandomEquipment)
> *前置：* ModMenu<br>
> *中文：* **暂无**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 随机装备<br>
+ 允许装备随机掉落

------------------------------------------- 
### [MythicSpellFlexibility](https://github.com/alterasc/MythicSpellFlexibility)
> *前置：* 无<br>
> *中文：* **无文本**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 独特的神话法术会添加到角色所有的普通法术书中。<br>
+ 法术环数不变
+ 普通法术书中的神话法术会像该法术书中的普通法术一样计算施法者等级和DC。
+ 如果你在学习神话法术时还不能施展对应环数的普通法术，并且后来才达到能释放的施法等级，那么此时就会添加神话法术到法术书中。
+ 法术是临时添加的 - 如果你切换到没有神话法术的道途，它们将从普通法术书中删除。
+ 如果你有不止一本普通法术书，神话法术就会被放入所有这些书里。
+ 支持职业与神话道途的任意组合。
+ 所有恢复法术位的神话法术都不会被复制到普通法术书里。不会有无限的法术位。
+ 天使和巫妖拥有的 10 级法术不会被复制，因为通常没有法术书达到 10 级。
  
------------------------------------------- 
### [SpellSlotFreedom](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/603?tab=description) 
> *前置：* 无<br>
> *中文：* **无文本**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 能在没有升阶超魔的情况下使用高级法术位释放低级法术<br>
+ 通过在法术书菜单中，将你想要在更高级别施放的法术拖放到切换环位的按钮中你需要的法术级别上来把低级法术添加的更高的环位中。
+ 要忘记以这种方式添加到更高环位的法术，请将其拖放到任何较低级别的按钮中，这将删除它。
+ 你只能在没有应用超魔的情况下移动法术。
+ DC 不会增加 - 因为根据规则它不应该增加
+ 仅适用于鼠标和键盘。

------------------------------------------- 
### [MagicArmory](https://github.com/alterasc/MagicArmory) 
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 目前新增加两个装备<br>
<table>
<tr><th colspan="2">道具列表<br></th></tr> 
       <tr><td>弱效猛力投掷腰带 Belt of Mighty Hurling (Lesser)</td><td> 位于第二章的怀尔瑟·格阿姆斯处<br>力量获得＋2增强加值且允许使用投掷武器时使用力量代替敏捷提供攻击加值</td></tr>
       <tr><td>驴背短衫 Muleback Cords</td><td>位于第一章酒馆的酒保和第三章的织秘者<br>在计算载重能力时力量视作高8点</td></tr>

</table>   

-------------------------------------------
### [LevelableAivu](https://github.com/pheonix99/LevelableAivu) 
> *前置：* 无<br>
> *中文：* **无**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 能自定义爱乌的能力加点<br>

-------------------------------------------
### [Mythic-Magic-Mayhem](https://github.com/YLMstring/Mythic-Magic-Mayhem) 
> *前置：* [SpellbookMerge](https://github.com/vikigenius/SpellbookMerge/tree/master)<br>
> *中文：* **自带**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 神话法术系统重制<br>
重制了神话道途法术系统，允许所有道途任意合书
<table>
<tr><th colspan="4">修改列表<br></th></tr> 
     <tr><td>合书规则</td><td colspan="3">所有施法者、所有道途现在都可以合术。4环和6环施法者在合书后会获得高环法术位。</td></tr>
	 <tr><td rowspan="4">巫妖</td>
		 <td colspan="3">将次级操纵亡者加入法术书</td></tr>
	         <tr><td colspan="3">加强死灵伴兽，获得等于你神话阶层的魅力加值</td></tr>
	         <tr><td colspan="3">增加神话能力，可以将同伴的动物伙伴变为不死生物模板</td></tr>
	         <tr><td colspan="3">在神话5获得被动分支，选择使用魅力和体质中较高者进行强韧豁免和生命值修正</td></tr>
	 <tr><td rowspan="5">天使</td>
		 <td rowspan="3">法术改动</td>
	            <td colspan="2">审判之矢提升到7环</td></tr>
	            <tr><td colspan="2">审判风暴提升到9环</td></tr>
	            <tr><td colspan="2">正义之怒现在为8环且只会影响邪恶恶魔（爱酱！）</td></tr>
	         <td rowspan="2">新增强化天使光环</td>
	            <td>神圣勇士</td><td>激活天使光环时，天使造成的所有能量伤害转化为神圣伤害。</td></tr>
	            <tr><td>天堂烈焰</td><td>激活天使光环时，天使造成的所有能量伤害转化为火焰伤害。</td></tr>
	 <tr><td rowspan="4">灵使</td>
		 <td colspan="3">现在灵使道途法术为9环，法术获得进度已经重制</td></tr>
	         <tr><td rowspan="1">新增超然之力</td>
	            <td>和声回响</td><td>可以在持续一首灵使之歌的同时启动第二首。</td></tr>
		 <tr><td rowspan="2">新增法术</td>
	            <td>抱成一团</td><td>效果同友善之拥，群体。</td></tr>
	            <tr><td>快乐大合唱</td><td>效果期间使用你所知的一切表演且不消耗这些能力的每日使用次数</td></tr>
	 <tr><td rowspan="3">御衡</td>
		 <td colspan="3">现在御衡道途法术为9环，法术获得进度已经重制</td></tr>
		 <tr><td rowspan="2">新增法术</td>
	            <td>完全虚无法令</td><td>御衡者和 20 英尺半径内的所有盟友都获得群体防护能量法术的好处，但它适用于所有伤害类型。</td></tr>
	            <tr><td>绝对权威法令</td><td>以一个迅捷动作，你可以使30英尺半径内的所有敌人受到报复法令和不抵抗法令的影响</td></tr>
	 <tr><td rowspan="3">恶魔</td>
		 <td colspan="3">现在恶魔道途法术为9环，法术获得进度已经重制</td></tr>
		 <tr><td rowspan="2">新增法术</td>
	            <td>盲目狂怒</td><td>范围内所有目标必须通过意志豁免，否则受到目盲以及狂暴术的效果。此外，未能通过豁免者还会失去真知术，盲斗，以及任何令其无视隐蔽，或是重投隐蔽失手的效果所带来的好处。</td></tr>
	            <tr><td>深渊裂隙</td><td>每轮都会出现一个随机的恶魔，并为你战斗1分钟。</td></tr>
	 <tr><td rowspan="4">诡计</td>
		 <td colspan="3">现在诡计道途法术为9环，法术获得进度已经重制</td></tr>
		 <tr><td rowspan="3">新增法术</td>
	            <td>镜影殿堂</td><td>你和全体友军受到镜影术影响并且每轮刷新。</td></tr>
	            <tr><td>天降戟兵</td><td>这个法术的功能与戟雨一样，除了它在法术持续时间内，每有四个施法者等级便召唤一名坟墓骑士（如同创造不死生物法术）。</td></tr>
	            <tr><td>诡术开发者</td><td>选择释放下列 10 级神话法术之一（天堂军势、绝对死亡、深渊裂隙、绝对权威法令或快乐大合唱）</td></tr>	
</table> 

-------------------------------------------
### [OnePearl](https://github.com/alterasc/OnePearl)
> *前置：* 无<br>
> *中文：* **无**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 增加合一珍珠，可以将物品栏中的法力珍珠功能合并，便于回复法术位<br>
注：合一珍珠没有直接获得途径，只能在选项 - mod选项菜单中手动获得

------------------------------------------- 
### [deceiverbuff](https://github.com/CasDragon/deceiverbuff)
> *前置：* 无<br>
> *中文：* **无**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 加强魔法诈欺师<br>
<table>
<tr><th colspan="3">修改列表<br></th></tr> 
       <tr><td>法术进程</td><td>诈欺师现在使用完整的法术进程(九环)，每日法术量按照法师的规则</td></tr>
       <tr><td>合书</td><td>魔法诈欺师现在可以和任意神话魔法书合书</td></tr>
       <tr><td>抄写卷轴</td><td>魔法诈欺师现在可以能复制任何卷轴的法术到他们的法术书中</td></tr>
       <tr><td rowspan="19">魔法诈欺师新增法术</td>
           <td>地狱烈焰射线</td></tr>
	   <tr><td>吸能术</td></tr>
           <tr><td>凶兆</td></tr>
           <tr><td>闪光尘</td></tr>
           <tr><td>极寒射线</td></tr>
           <tr><td>力竭波</td></tr>
	   <tr><td>极寒射线</td></tr>
           <tr><td>力竭波</td></tr>
           <tr><td>潮汐波涌</td></tr>
           <tr><td>高等天使之貌</td></tr>
	   <tr><td>高等虚假生命</td></tr>
	   <tr><td>高等英雄气概</td></tr>
	   <tr><td>高等魔化武器</td></tr>
           <tr><td>加速术</td></tr>
	   <tr><td>酸液飞溅</td></tr>
	   <tr><td>冷冻射线</td></tr>
	   <tr><td>放电</td></tr>
	   <tr><td>共用防护混乱/邪恶</td></tr>
	   <tr><td>龙型 红龙/金龙</td></tr>
	</table> 
 
------------------------------------------- 
### [FinessableSabers](https://github.com/StoyanKucarov/FinessableSabers)
> *前置：* 无<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 锯齿刀巧技训练和一个神话能力
<table>
<tr><th colspan="3">修改列表<br></th></tr> 
       <tr><td>巧计训练 锯齿刀</td><td>游荡者的敏上伤能力</td></tr>
       <tr><td>神话能力 夜王迅捷</td><td>你的所有血池能力成为迅捷动作</td></tr>
       
</table>   

------------------------------------------- 
### [HombrewFighterMagus](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/648)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **QL汉化**<br>
> *安装方式：* **非UMM**<br>
> *新增内容：* 原创魔战士，用部分职业能力换取武器训练护甲训练能力
<table>
<tr><th colspan="3">修改列表<br></th></tr> 
       <tr><td rowspan="2">新增变体</td>
	    <td rowspan="2">魔战士</td>
                    <td>秘奥战兵</td></tr>
	        <tr><td>秘奥继者</td></tr>
       
</table>   

------------------------------------------- 

### 功能MOD索引
+ [ToyBox](https://github.com/xADDBx/ToyBox-Wrath) 应该不用介绍？
+ [RespecMod](https://github.com/BarleyFlour/RespecMod) 洗点MOD（允许更自由洗点，自定义初始点数等）
+ [BubblesBuffs](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/195) 自动BUFF
+ [BubbleTweaks](https://github.com/factubsio/BubbleTweaks) 选项调节（调节动画速度等）
+ [MoreBulkSell](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/163) 强化自动出售（一键出售支持更多物品）
+ [SpellPouch](https://github.com/Truinto/SpellPouch) 图标合一（可以将多个能力合为一个层叠图标便于使用）
+ [FamiliarPlus](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/192) 宠物加强（物品小宠物不召唤出来能力也生效）
+ [PuzzleSkip](https://github.com/Balkoth-dev/PuzzleSkip) 跳过部分解谜

### 打包MOD网盘分流
由网友猫猫虫分享的百度网盘，收集了大部分MOD，便于下载
链接：https://pan.baidu.com/s/153DyjGYLKe7Vc1dczhGYBg 
提取码：wotr
