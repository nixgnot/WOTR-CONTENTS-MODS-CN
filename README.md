# 【正义之怒】内容扩展型MOD收集计划
-------------------------------------------

+ 本文档用于收集整理为开拓者正义之怒提供内容扩充（新增或者修改职业、变体、专长、法术等游戏内容）的MOD，并尽量保持时效性。
+ ToyBox、Bubble Buffs等功能性MOD不在本文档介绍范围，但是文末会给出常用MOD链接。
+ 特别注意，本文档作者的游戏理解还是新手，很可能评价并不贴切。
+ 强烈建议先行阅读[正义之怒MOD教程](https://github.com/1onepower/KM-WotR_Modding_Wiki/blob/main/%E4%B8%AD%E6%96%87%E7%89%88.md) （1onepower）。该文档含有详细的**UMM安装教程**和部分MOD介绍，但文档时间较早，部分MOD可能已经失效。


## 目录

- [基础知识](#前置安装)
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
  - [TabletopTweaks-Base](#TabletopTweaks-Base) TTT :star::star::star: :exclamation:
    - [TabletopTweaks-Reworks](#TabletopTweaks-Reworks) TTT神话扩展 :star::star: :exclamation:
    - [TabletopTweaks-Flanking](#TabletopTweaks-Flanking) TTT夹击扩展 :star::star: :exclamation:
  - [MicroscopicContentExpansion](#MicroscopicContentExpansion) Microscopic内容扩展 :star::star::star:
  - [SparsSorcerousSundries](#SparsSorcerousSundries) SSS扩展 :star::star:
  - [TomeOfTheFirebird](#TomeOfTheFirebird) TOTF扩展 :star::star::star:
  - [HomebrewArchetypes](#HomebrewArchetypes) Homebrew(房规)变体 :star::star::star:
  - [ExpandedContent2022](#ExpandedContent2022) 扩展内容2022 :star:
  - [ToggleableThrowingWeapons](#ToggleableThrowingWeapons) 可切换投掷武器 :star::star::star:
  - [MorvarchsPlaystyleExpansions](#MorvarchsPlaystyleExpansions) Morvarchs玩法扩展 :star::star::star:
  - [PhoenixsCantrips](#PhoenixsCantrips) Phoenixs戏法强化 :star:
    - [MoreCantrips](#MoreCantrips) 更多戏法 
  - [CharacterOptionsPlus](#CharacterOptionsPlus) 角色选项+ :star::star::star:
  - [DarkCodex](#DarkCodex) DarkCodex扩展和修复 :star::star::star: :exclamation:
  - [AddedFeats](#AddedFeats) 新增专长 :star::star:
  - [BetterBackgrounds](#BetterBackgrounds) 更多背景 :star::star:
  - [MartialExcellence](#MartialExcellence) 杰出武艺:star::star:
  - [MediumClass](#MediumClass) 通灵者职业
  - [MysticalMayhem](#MysticalMayhem) 神秘骚乱:star::star::star:
  - [MythicArcanist](#MythicArcanist) 神话秘术:star::star::star: 
  - [ChampionFeatsAnew](#ChampionFeatsAnew) 冠军专长 
  - [KineticistElementsExpanded](#KineticistElementsExpanded) 操念元素扩展 :star:
  - [Madison'sMetagaming](#sMetagaming) Madison的超级游戏
  - [NinjaClass](#NinjaClass) 忍者职业
  - [BrawlerClass](#BrawlerClass)  拳师职业
  - [WOTR_PATH_OF_BLING](#WOTR_PATH_OF_BLING) 金龙重做  
  - [WOTR_PATH_OF_HELL](#WOTR_PATH_OF_HELL)  魔鬼重做
  - [WOTR_PATH_OF_RAGE](#WOTR_PATH_OF_RAGE) 恶魔重做 :star::star: :exclamation:
  - [WorldCrawl](#WorldCrawl)  :exclamation:
  - [AlternateHumanTraits](#AlternateHumanTraits) 人类替换特性
  - [WOTR_IsekaiMod](#WOTR_IsekaiMod) 异世界主角（滥强警告）
  - [Way-of-the-shield](#Way-of-the-shield) 盾牌之道
  - [CyniikalBrokenFeatures](#CyniikalBrokenFeatures) 法师虚学派
  - [功能MOD索引](#功能MOD索引) 


:star:表示笔者个人推荐
:exclamation: 表示对游戏原本内容有大幅度修改，需要注意

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
+ ModFinder可以在[这里](https://github.com/Pathfinder-WOTR-Modding-Community/ModFinder)下载。
+ [汉化分支地址](https://github.com/magicskysword/ModFinder_CN)
+ ModFinder为绿色工具，可以在任何路径打开（但是最好不要用中文路径），会自动识别正义之怒的安装位置。
+ ModFinder在启动时可能会出现弹框错误，发生此种情况多半是Github访问失败的导致的，请参照下一节解决。

### GITHUB访问和MOD下载
+ 在国内很多网络环境，Github访问都存在一定抽风现象，会出现时不时打开失败。通常刷新就可以解决。如果实在问题严重，[Watt Toolkit](https://steampp.net/)可以帮到你。
+ 给予完全萌新的提示：大部分MOD发布页中，直接点击右侧**Releases** 按钮即打开下载页面，Assets中第一项即为MOD。下载后不需要解压缩，直接使用UMM或者ModFinder安装。

### Nexus访问和MOD下载
+ Nexus的MOD在标题右方的Manual按钮即可直接下载。如果有额外文件会在FILES标签中。
+ Nexus目前需要注册用户才能下载。

### 本文档使用说明
+ **汉化文件下载**
> 直接点击上方**Code**按钮，然后选择**Download Zip**即可打包下载全部汉化文件<br>
> 如果需要单独汉化文件，可以自行新建文本文档并复制放入文件内容，注意保存格式为**UTF-8**<br>
> 汉化文件的使用请参考下方
+ **辅助工具下载**
> 在右侧的Release中，可以下载**MOD外挂汉化工具QuickLocalization**、**Pathfinder中文文档**<br>
> 注意不要下载Source code，为空文件
+ **临时MOD下载**
> 在右侧的Release中，可以临时下载**一部分没有主页发布的2.10MOD**<br>
> 注意不要下载Source code，为空文件

### 前置MOD
目前正义之怒所需主要前置MOD有两个：
1. [TabletopTweaks-Core](https://github.com/Vek17/TabletopTweaks-Core)（**核心必备**，绝大部分MOD的基础框架，本身不会进行任何改动。）
2. [ModMenu](https://github.com/WittleWolfie/ModMenu)（**非必备**，一部分MOD使用的基础框架。会在游戏中选项里添加一个新的页面来进行MOD功能调整。）

### 汉化文件及其他说明
+ 本文档上方会收集一些个人提供的**MOD汉化或汉化修正文件**，不定时更新。
+ 可以点击上方**code**按钮中的**Download Zip**打包下载素有附件。
+ 一般**UMM安装**的MOD，汉化文件的使用方法是直接替换游戏目录下\mods\对应mod名称\Localization\中同名文件即可。
+ 对于**非UMM安装**的MOD，替换C:\Users\你的用户文件夹\AppData\LocalLow\Owlcat Games\Pathfinder Wrath Of The Righteous\Modifications\对应mod名称\Localization\中同名文件。
+ 对于**QuickLocalization用汉化**，请参考QuickLocalization说明
+ 大部分MOD是对原规则的还原，对于较为复杂的职业、专长详情会标明<i>参阅PF文档</i>，可在上述Pathfinder v2.02简体文档中查看，但实际MOD中并不一定完全效果相同。

-------------------------------------------
### MOD外挂汉化工具QuickLocalization
+ 本工具是一个“外挂式”汉化工具，用于在其他MOD载入后，再外挂载入语言文件，实现不需要修改原MOD就能实现外挂汉化
+ 只要原MOD更新后没有修改语言文件，汉化也不会受到更新影响
+ 且本工具可以实现在游戏启动中动态重载文本，来帮助进行所见即所得的汉化或修改汉化文件错误

> 本MOD由@magicskysword制作，适用版本为WOTR 2.1<br>
> 该版本为临时版本，不保证完善。但该MOD不涉及任何存档操作，不会对游戏本身造成任何影响。

+ UMM安装后，找到游戏文件夹下\Mods\QuickLocalization
+ 新建一个Localization文件夹，然后将外挂汉化文件丢进去即可。
+ 外挂汉化文件需为JSON格式，文件名不限（建议建立子文件夹并妥善命名，方便管理）

目前已经完成的汉化：
**Brawler(拳师) MOD 2.10用版本**
**AlternateHumanTraits（人类替换特性）**
**CyniikalBrokenFeatures（法师虚学派，在release中有）**
**ToggleableThrowingWeapons（可切换投掷武器）**


本文档会不定期更新补充一些汉化

-------------------------------------------
## MOD列表
**若无特别说明，则MOD在2.0.7版本测试通过**
-------------------------------------------
### [TabletopTweaks-Base](https://github.com/Vek17/TabletopTweaks-Base)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **自带中文（部分内容没更新）**<br>
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
<tr><td rowspan="34">基本修复<br>Base</td>
   <td>AreaOfEffectDoubleTrigger
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修复AOE法术释放时额外触发一次</td></tr>
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
        </td><td>修复隐形的隐蔽检定</td></tr>
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
        </td><td>移除恶心的移动受限描述</td></tr>
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
  <tr><td rowspan="6">炼金术士<br>Alchemist</td>
      <td>Base - MutagenStacking
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
          </td><td>修复法术进程防止依赖预先施法的特性不生效</td></tr>
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
            </td><td>修复憎恨邪恶奖励</td></tr>
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
          </td><td>启示：修复烈焰魔法CL计算</td></tr>
  <tr><td rowspan="2">圣武士<br>Paladin</td>
        <td>Base - DivineMountTemplate</td>
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>修复圣骑士模板，给予应有特性</td></tr>
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
  <tr><td>冬巫<br>WinterWitch</td>
      <td>UnearthlyCold
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>修复异界严寒和超魔及奖励伤害的互动</td></tr
  <tr><td rowspan="54">法术<br>Spells</td>
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
      <tr><td>Firebrand
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>火焰烙印：攻击时不再造成过多伤害实例</td></tr>
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
        </td><td>死亡之力：修正持续时间为论级</td></tr>
      <tr><td>ProtectionOfNature
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>自然庇护：掩蔽不再受到真视影响.</td></tr>
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
        </td><td>友善之拥：正确应用免疫效果</td></tr>
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
  <tr><td rowspan="4">职业特性</td>
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
  <tr><td rowspan="28">专长<br>Feats</td>
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
      <tr><td>FencingGrace
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>优雅刺击：永远只对单手武器生效</td></tr>
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
      <tr><td>Outflank
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>包抄：攻击丢失不再触发</td></tr>
      <tr><td>PersistantMetamagic
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>超魔 - 顽强：所有有豁免骰的法术均可用</td></tr>
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
  <tr><td rowspan="8">神话能力<br>MythicAbilities</td>
      <td>AscendantElement
        </td><td>:heavy_check_mark:
        </td><td>:x:
        </td><td>颠覆元素：现在可以正确无视免疫</td></tr>
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
    <tr><td rowspan="3">BOSS和敌人修复<br>Bosses/Enemies</td>
          <td>Deskari
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>德斯卡瑞：完善UI描述</td></tr>
        <tr><td>StauntonVane
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>斯陶顿·卫恒拥有正确专长</td></tr>
        <tr><td>Balors
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>霸烙魔：修复斩首武器</td></tr>
  <tr><td>圣教军模式<br>Crusade</td>
    <td>Buildings - TrainingGrounds
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>训练场：修正伤害奖励</td></tr>
  <tr><td rowspan="24">物品<br>Items</td>
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
        <tr><td>Equipment - AspectOfTheAsp
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>蛇相：修复生效 </td></tr>
        <tr><td>Equipment - BaneOfSpirit
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>灵魂之灾：使用为自由动作</td></tr>
        <tr><td>Equipment - FixScrollUMDDCs
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>使用魔法卷轴DC：现在等级正确改为 20 + 卷轴 CL </td></tr>
        <tr><td>Equipment - FlawlessBeltOfPhysicalPerfection8Availability
          </td><td>:x:
          </td><td>:x:
          </td><td><s>无瑕+8极致体能腰带</s>原版已修复</td></tr>
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
        <tr><td>Equipment - StormlordsResolve
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>风暴领主的决意：现在可以立即关闭而不需等待1轮</td></tr>
        <tr><td>Weapons - BladeOfTheMerciful
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>慈悲之刃：防止多次触发伪攻击并过多触发武器特效</td></tr>
        <tr><td>Weapons - EnergyBurst
          </td><td>:heavy_check_mark:
          </td><td>:x:
          </td><td>元素附魔：修复各类元素爆附魔（焰爆）伤害计算</td></tr>
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
  <tr><td rowspan="6">职业特性</td>
      <td>血承：Aberrant 异怪血承、Destined 命运血承</td></tr>
  <tr><td>奥能技艺：Familiar 魔宠、Item Crafting 造物精通、Metamagic Knowledge 超魔学识、Quick Study 快速研读 </td></tr>
  <tr><td>战士进阶防具训练：Armored Confidence 自信着甲、Armored Juggernaut 盔甲主宰、Armor Specialization 重甲掌握、Critical Deflection 重击偏转、Steel Headbutt 钢铁头槌</td></tr>
  <tr><td>战士进阶武器训练：Defensive Weapon Training 防御式武器训练、 Focused Weapon 专注武器、Trained Grace 庖丁解牛、Trained Throw 精通投掷、Warrior Spirit 勇士之魂"</td> </tr>
  <tr><td>魔战士奥秘：Broad Study 奥术扩展、Spell Blending 混合奥法 </td></tr>
  <tr><td>游荡者天赋： Graceful Athlete 灵巧运动、Bleeding Attack 流血攻击、Emboldening Strike 鼓舞攻击</td></tr>    
  <tr><td rowspan="6">法术</td>
      <td>Cloak of Winds 风之斗篷：敌方远程攻击受到惩罚</td></tr>
  <tr><td>Long Arm 长臂咒：增加触及</td></tr>
  <tr><td>Mage's Disjunction <b>法师裂解术</b>：无豁免驱散/过穿戴者意志豁免使得魔法物品失效，逆天</td></tr>
  <tr><td>Shadow Enchantment 阴影惑控：幻术系模拟惑控</td></tr>
  <tr><td>Shadow Enchantment Greater 高等阴影惑控：楼上的高级版</td></tr>
  <tr><td>Stunning Barrier Greater 重型重创壁垒：防御法术</td></tr>
  <tr><td rowspan="59">专长和职业特性</td>
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
  <tr><td rowspan="17">神话能力</td>
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
> *中文：* **自带中文（部分内容需要更新）**<br>
> *安装方式：* UMM<br>
> *修改内容：* 神话能力、神话专长，道途等<br>
> *新增内容：* 神话道途能力<br>
+ **TTT**的扩展附件，主要集中在**神话道途**的修改
+ 对神话能力、神话专长、道途均有修改，也导致很多人不习惯
> **目前发现问题：灵使惊世神力改为了其他加值，但是文本描述依然是士气加值**
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
    <tr><td  rowspan="2">神话专长<br>MythicFeats</td>
      <td>MythicSneakAttack
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>神话偷袭：改为增大偷袭骰，而不是增加</td></tr>  
      <td>SchoolMastery
        </td><td>:heavy_check_mark:
        </td><td>:heavy_check_mark:
        </td><td>学派掌控：改为 CL + 2</td></tr>  
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
### [MicroscopicContentExpansion](https://github.com/alterasc/MicroscopicContentExpansion)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **无**<br>
> *安装方式：* UMM<br>
> *修改内容：* 无<br>
> *新增内容：* 职业、专长、法术等<br>
+ 特别注意。本MOD不依赖于[TabletopTweaks-Base](#TabletopTweaks-Base)，但是作者建议安装来获得完整功能。
+ 增加部分新内容
<table>
<tr><th colspan="2">新增内容列表</th></tr> 
   <tr><td>职业</td>
       <td>Antipaladin 反圣武士及变体：Knight of the Sepulcher 死骸骑士、Iron Tyrant 钢铁暴君、Tyrant 暴君<br><i>参阅PF文档</i></td>
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
   <tr><td>Blade of Dark Triumph 光辉胜利之刃（圣武士3）：<i>参阅PF文档</i>，强化神契武器</td></tr>
   <tr><td>武僧气力</td>
       <td>Deadly Juggernaut 死亡化身：同同名法术</td></tr> 
</table>

-------------------------------------------
### [SparsSorcerousSundries](https://github.com/TheSparhawk/SparsSorcerousSundries)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **无**<br>
> *安装方式：* UMM<br>
> *修改内容：* 修复辉光最终形态附魔效果<br>
> *新增内容：* 物品、法术等<br>
+ 主要是增加物品
+ **2.1版本Discord发布了临时更新，可在本处Release下载临时版**
<table>
<tr><th colspan="2">新增内容列表</th></tr> 
   <tr><td>前作武器</td>
       <td>增加大约40件前作装备，在商人处购买（大部分在原游戏商人，同时第四章O院加入了一个新商人）</td>
   <tr><td>其他</td>
       <td>增加10件新物品，1个新法术</td></tr>
</table>

-------------------------------------------
### [TomeOfTheFirebird](https://github.com/pheonix99/TomeOfTheFirebird)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **无**<br>
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
   <tr><td>狂暴之力：Rage Stance Mastery 狂暴姿态大师：同时使用两种野蛮人姿态</td></tr>
   <tr><td>圣疗救赎：Injured 救赎创伤（给予快速治疗）、Ensorcelled 救赎蛊惑（驱散，可对敌）</td></tr>
   <tr><td rowspan="12">法术<br><i>参阅PF文档</i></td>
       <td>Bone Fists 骸骨之拳：增加天生防御和天生武器伤害</td></tr>
   <tr><td>Chains Of Fire 火焰链：闪电链火焰版本</td></tr>
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
   <tr><td rowspan="11">专长<br><i>参阅PF文档</i></td>
       <td>Ability Focus- Breath Weapon 能力专攻 - 吐息武器：增加吐息攻击DC</td></tr>
   <tr><td>Burn Resistance 超载抵抗：计算操念超载非致命伤害时将自己等级视为低2级计算</td></tr>
   <tr><td>Extra Burn 额外超载：增加每日超载限制</td></tr>
   <tr><td>Extended Buffer 额外念力缓冲：增加念力缓冲（MOD新增操念自带特性，减少一定量的超载）</td></tr>
   <tr><td>Discordant Song 不谐之歌：诗人歌曲。为盟友武器增加音波伤害，远程武器需要目标也在范围内</td></tr>
   <tr><td>Prodigious Two-Weapon Fighting 有力双武器战斗：副手单手武器视为轻型，用力量属性代替敏捷属性来满足双武器系列专长的先决条件</td></tr>
   <tr><td>Sundering Strike 破甲重击：原为破武重击，成功重击后附加击破武器，游戏中实为附加击破盔甲</td></tr>
   <tr><td>Coordinated Shoot 准线规避：团队专长，如果同样有此专长的盟友威胁目标，远程攻击检定+1，如果该盟友再和其他盟友（可以无此专长）夹击目标，变为+2</td></tr>
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
+ [贴吧汉化帖](https://tieba.baidu.com/p/7977216047?pn=1)
+ **注意！Homebrew Archetypes不能使用UMM安装，可以使用ModFinder安装或者参考汉化帖手动安装**
> *前置：* 无<br>
> *中文：* **自带中文（主页中文不一定保持最新，可在贴吧汉化贴确认）**<br>
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
         <tr><td>Primal Hunter 原始猎手(<b>暂未汉化<b>)</td></tr>
    <tr><td rowspan="3">吟游诗人</td>  
         <td>Arcane Duelist 奥术决斗者</td></tr>
         <tr><td>Dervish of Dawn 晨花狂舞者</td></tr>
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
         <tr><td>Monk of the Mantis 螳螂僧(<b>暂未汉化<b>)</td></tr>
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
### [ExpandedContent2022](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/377)
+ [贴吧汉化帖](https://tieba.baidu.com/p/8108212678)
> *前置：* 无<br>
> *中文：* **汉化发布**<br>
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
   <tr><td rowspan="14">变体</td>
       <td rowspan="1">审判官</td>
           <td>Living Scripture 活圣经</td></tr> 
       <tr><td rowspan="1">战斗祭司</td>
           <td>Mantis Zealot 螳螂狂徒</td></tr> 
       <tr><td rowspan="5">德鲁伊</td>
           <td>Mooncaller 唤月者</td></tr> 
           <tr><td>Draconic Druid 龙之德鲁伊</td></tr> 
           <tr><td>Storm Druid 风暴德鲁伊</td></tr> 
           <tr><td>Urban Druid 文明德鲁伊</td></tr> 
           <tr><td>Bear Totem Shaman 熊图腾萨满(<b>暂未翻译</b>)</td></tr> 
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
   <tr><td rowspan="2">职业特性</td>
       <td>先知秘示域</td>
       <td>Dragon 龙、Heavens 天堂、Succor 救助</td></tr>
   <tr><td>先知诅咒</td>
       <td>Vampirism 吸血鬼</td></tr>
   <tr><td colspan="2">基础动作</td>
       <td>Aid Another 援助他人</td></tr>
   <tr><td colspan="2">专长</td>
       <td>Swift Aid 迅速援助</td></tr>
   <tr><td colspan="2" rowspan="2">神话能力</td>
       <td>Mythic Drake 神话龙兽</td>
   <tr><td>Impossible Subdomain 无限子域可能</td></tr>
   <tr><td rowspan="3">信仰</td>
       <td>神祗</td>
       <td><b>海量新神祗</b></td></tr>
   <tr><td>领域</td>
       <td>Scalykind 鳞状</td></tr>
   <tr><td>子领域</td>
       <td>Agathion 阿加西翁、 Archon 亚空, Blood 血液、Caves 洞穴、Curse 诅咒、 Demon, Dragon 龙、Ferocity 凶猛、Ice 冰、Lust 欲望、Psychopomp 招魂、Rage 狂暴、 Resolve 决心、Restoration 恢复、Revelation 启示、Revolution 革命、Rivers 河流、Stars 星空、Storm 风暴、Thievery 盗窃、Undead 不死、Whimsy 滑稽、Wind 风</td></tr>
   <tr><td colspan="2" rowspan="25">法术<br><i>参阅PF文档</i></td>
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
 </table>   

-------------------------------------------
### [ToggleableThrowingWeapons](https://github.com/pheonix99/ToggleableThrowingWeapons)
> *前置：* 无<br>
> *中文：* **已有汉化（本人提供，QL挂载）**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* 匕首和星刃投掷<br>
+ 小型MOD，持有匕首和星刃时会多出一个开关型能力，可以自由在**远程使用和近战使用**间切换。
+ Nexus上有类似功能的MOD Thrown Daggers，但是强烈推荐这个，不管是功能上还是兼容性上，本MOD都遥遥领先

-------------------------------------------
### [MorvarchsPlaystyleExpansions](https://github.com/MorvarchPrincess/MorvarchsPlaystyleExpansions)
> *前置：* 无<br>
> *中文：* **无**<br>
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
> *前置：* 无<br>
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
   <tr><td>Energy Channel 引导元素：消耗引导能量使你的武器攻击获得额外元素伤害</td></tr>
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
> *中文：* **无**<br>
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
    <td><b>新增专长：</b>Ability Focus 技能专精，增加技能DC</td>
    <td>:x:</td>
    <td>:x:</td></tr>
<tr><td>General.CreateBackgrounds</td>
    <td><b>新增专长：</b>Additional Traits 附加背景<br>新增背景：<br>Magical Lineage 魔法裔,指定一个法术。当你超魔施展该法术时，其最终占用的法术环位视为比正常状况降低1级，cl+2（但是不会超过当前HD）<br>
Metamagic Master 超魔主宰：指定一个法术。当你超魔施展该法术时，其最终占用的法术环位视为比正常状况降低2级<br>Fate’s Favored 命运眷顾：所有幸运加值额外+1</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateBardStopSong</td>
    <td>增加能力，随意立即结束吟游诗人歌曲</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateDirtyFighting</td>
    <td><b>新增专长：</b>Dirty Fighting 卑劣战斗，如果你没有进行夹击或者拥有对应战技专长，使用战技时不会引发借机攻击但是受到-4处罚</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateHeritage</td>
    <td>半兽人替换种族特性：Orc-Atavism 返祖兽人，亲眷半精灵重新获得精灵免疫</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateKitsuneFoxfire</td>
    <td>魔性之尾获得Foxfire Bolt 狐火箭</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateMadMagic</td>
    <td><b>新增战斗专长：</b>Mad Magic 狂躁魔法，允许狂暴时施法e</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateOpportuneParry</td>
    <td><b>新增战斗专长：</b>Opportune Parry 适时格挡，决斗家消耗借机攻击次数，用自由动作进行格挡</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreatePreferredSpell</td>
    <td><b>新增专长：</b>Preferred Spell 偏好法术，选定一个法术，使其能够自发施法</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>General.CreateSacredSummons</td>
    <td><b>新增专长：</b>Sacred Summons 特定召唤生物可以立即召唤</td>
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
    <td>拥有过量超载自动增强念袭</td>
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
    <td>强击注能可用于沙暴念袭，心念使状态设置，修复负向能量掌控</td>
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
<th rowspan="1">武技</td> 
    <td>MartialArt.CreateProdigiousTwoWeaponFighting</td>
    <td><b>新增专长：</b>Prodigious Two Weapon Fighting 有力双武器战斗，使用力量代替敏捷计算双武器专长要求，副手单手武器视为轻型</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="2">武僧</td> 
    <td>Monk.CreateFeralCombatTraining</td>
    <td><b>新增专长：</b>Feral Combat Training 野性战斗训练 - 选择一种天生武器，视为徒手攻击应用以精通徒手攻击为前提的专长，也包括疾风连击</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Monk.PatchSoheiRapidShot</td>
    <td>僧兵：禁用快速射击</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr>
<th rowspan="38">神话</td> 
    <td>Mythic.CreateDemonLord</td>
    <td>恶魔道途：增加恶魔领主特性 - 随意传送等</td>
    <td>:heavy_check_mark:</td>
    <td>:construction:</td></tr>
<tr><td>Mythic.CreateDemonMastery</td>
    <td><b>神话专长：</b>Demon Mastery 恶魔掌握 - 需要恶魔道途6，选择一种魔相成为被动效果</td>
    <td>:heavy_check_mark:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Mythic.CreateExtraMythicFeats</td>
    <td><b>神话能力：</b>Extra Mythic Feats 额外神话专长</td>
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
<th rowspan="5">施法者</td> 
    <td>Spellcasters.CreateBestowHope</td>
    <td><b>新增专长：</b>Bestow Hope 授予希望 - 引导减少恐惧等级</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spellcasters.CreateEnergyChannel</td>
    <td><b>新增专长：</b>Energy Channel 能力引导 - 使用引导次数为武器充能</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Spellcasters.CreatePurifyingChannel</td>
    <td><b>新增专长：</b>Purifying Channel 净化引导 - 引导正能量造成火焰伤害</td>
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
    <td><b>新增专长：</b>Split Hex 分裂巫术；Split Major Hex 分裂强力巫术</td>
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
    <td>修复可激活能力移动动作会自动关闭</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_ActivatableOnNewRound</td>
    <td>触发时使用移动动作，无剩余动作自动关闭</td>
    <td>:x:</td>
    <td>:heavy_check_mark:</td></tr>
<tr><td>Patch.Patch_ActivatableOnTurnOn</td>
    <td>修复同类动作可激活能力不能同时激活</td>
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
    <td>允许持久法术对任何来源法术生效; 修复魔法武器</td>
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
> *中文：* **已有汉化（@HerryZheng8提供，QL挂载）**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 专长，法术<br>
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
> *中文：* **无**<br>
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
+ 早期版本，主要添加通灵者（Medium）职业，还做了一些制作中的专长，不保证有效，建议等待完善
        
------------------------------------------- 
### [MysticalMayhem](https://github.com/kreaddy/MysticalMayhem)
> *前置：* 无<br>
> *中文：* **自带**<br>
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
<tr><td rowspan="4">变体<br>Archetype</td>
	<td>苦修者<br>Flagellant</td>
		<td>牧师变体，对自己造成伤害来获得CL或DC加成，适合施法者构建</td>
		<td>:heavy_check_mark:</td></tr>
	<tr><td>密契法师<br>Pact Wizard</td>
		<td>法师变体，失去奖励专长获得巫师庇护主和先知诅咒等能力</td>
		<td>:x:</td></tr>
	<tr><td>拉兹密安牧师<br>Razmiran Priest</td>
		<td>非进阶职业，术士变体，失去部分血承能力换取消耗法术位来无限使用特定的魔杖和卷轴的能力</td>
		<td>:x:</td></tr>
	<tr><td>千军武神<br>Warsighted</td>
		<td>先知变体，获得额外战斗专长但是失去启示。</td>
		<td>:x:</td></tr>
<tr><td rowspan="5">专长<br>Feat</td>
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
<tr><td rowspan="2">魔战士奥秘<br>Magus Arcana</td>
	<td>秩序之环<br>Circle of Order</td>
		<td>以一个迅捷动作，消耗奥法池。在对抗混乱敌人时，AC获得等同于他魔战士等级的一半的闪避加值</td>
		<td>:x:</td></tr>
	<tr><td>恶意<br>Malice</td>
		<td>巫战士专用，近战攻击对任何正在受其巫术影响的敌人额外造成2d6点污邪伤害</td>
		<td>:heavy_check_mark:</td></tr>
<tr><td rowspan="2">神话能力<br>Mythic Ability</td>
	<td>充裕双法合璧<br>Abundant Spell Synthesis</td>
		<td>每有三个神话阶层，你可以额外使用一次双法合璧能力</td>
		<td>:heavy_check_mark:</td></tr>
	<tr><td>材料自由<br>Material Freedom</td>
		<td>选择一种特定的材料成分：你可以在不持有此材料成分的情况下施放某个通常需要它的法术</td>
		<td>:heavy_check_mark:</td></tr>
<tr><td rowspan="1">神话专长<br>Mythic Feat</td>
	<td>纯粹之罪（神话）<br>Purity of Sin (Mythic)</td>
		<td>纯粹之罪的额外加值现在也适用于法术的DC</td>
		<td>:heavy_check_mark:</td></tr>
<tr><td rowspan="2">职业特性<br>Class Feature</td>
	<td>双法合璧<br>Spell Synthesis</td>
		<td>添加秘术师巅峰，10级时，秘术师可以使用一个动作施放两个法术</td>
		<td>:x:</td></tr>
	<tr><td>显圣<br>Manifestations</td>
		<td>添加萨满精魂巅峰，类似先知最终启示效果</td>
		<td>:x:</td></tr>
<tr><td rowspan="2">法术<br>Spell</td>
	<td>流星爆<br>Meteor Swarm</td>
		<td>流星爆是一个强力且壮观的法术，当你施放此法术时，四颗炽热的流星将坠落在你选定的区域，一旦它们到达地面就会爆炸，对该区域的所有生物造成28d6点火焰伤害</td>
		<td>:x:</td></tr>
	<tr><td>石肤（博德之门）<br>Baldur's Gate Stoneskin</td>
		<td><b>默认未开启</b><br>改变石肤法术，使其更接近[博德之门中的版本](https://baldursgate.fandom.com/wiki/Stoneskin)<br>此法术创造一层完全覆盖施法者的石制外壳。石肤当然是魔法的，不会妨碍到施法者。它可以抵御物理攻击，如近战武器和炮弹。施法者等级每提高2级，施法时会获得额外的石肤层数(到第20级时最多可获得10层石肤)。施法者每拥有一层石肤，该法术将抵御一次攻击。如果所有石肤都被移除，法术就会消散。需要注意的是，这并不能保护施法者免受任何能量或力场攻击</td>
		<td>:heavy_check_mark:</td></tr>
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
        <td>专精双持的展示变体</td></tr>
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
+ 增加一系列原创"冠军"专长，挺强的  
  
------------------------------------------- 
### [KineticistElementsExpanded](https://github.com/SpencerMycek/KineticistExpandedElements)
+ [贴吧汉化帖](https://tieba.baidu.com/p/8112471310)
> *前置：* 无<br>
> *中文：* **汉化发布**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 操念使元素<br>
+ 为操念使加入Aether 以太、Void 虚空、Wood 木三种元素
      
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
> *中文：* **无**<br>
> *安装方式：* **非UMM**<br>
> *修改内容：* <br>
> *新增内容：* 忍者职业<br>
+ 加入了Ninja 忍者职业，较久没有更新
          
------------------------------------------- 
### [BrawlerClass](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/207)
> *前置：* 无<br>
> *中文：* **已有汉化（本人提供，QL挂载）**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 拳师职业<br>
+ 加入了Brawler 拳师职业
+ **已有2.10临时版本和汉化，请在release下载MOD，在上方下载汉化**
        
-------------------------------------------   
### [WOTR_PATH_OF_BLING](https://github.com/Balkoth-dev/WOTR_PATH_OF_BLING)
### [WOTR_PATH_OF_HELL](https://github.com/Balkoth-dev/WOTR_PATH_OF_HELL)
### [WOTR_PATH_OF_RAGE](https://github.com/Balkoth-dev/WOTR_PATH_OF_RAGE)
> *前置：* 无<br>
> *中文：* **无**<br>
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
> *中文：* **已有汉化（本人提供，QL挂载）**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* <br>
> *新增内容：* 人类替换种族特性<br>
+ 提供来自规则书的人类可选替换种族特性
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
> *中文：* **无**<br>
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

### CyniikalBrokenFeatures
> *前置：* 无<br>
> *中文：* **已有汉化（本人维护，QL挂载）**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 法师学派：虚<br>
+ 增加了法师的虚学派
+ 原发布在Discord，本文档Release处有临时下载

   --------------------------------------
### 功能MOD索引
+ [ToyBox](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/8) 应该不用介绍？
+ [RespecMod](https://github.com/BarleyFlour/RespecMod) 洗点MOD（允许更自由洗点，自定义初始点数等）
+ [BubblesBuffs](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/195) 自动BUFF
+ [BubbleTweaks](https://github.com/factubsio/BubbleTweaks) 选项调节（调节动画速度等）
+ [MoreBulkSell](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/163) 强化自动出售（一键出售支持更多物品）
+ [SpellPouch](https://github.com/Truinto/SpellPouch) 图标合一（可以将多个能力合为一个层叠图标便于使用）
+ [FamiliarPlus](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/192) 宠物加强（物品小宠物不召唤出来能力也生效）
+ [PuzzleSkip](https://github.com/Balkoth-dev/PuzzleSkip) 跳过部分解谜
