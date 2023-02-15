# 【正义之怒】内容扩展型MOD收集计划
-------------------------------------------

+ 本文档用于收集整理为开拓者正义之怒提供内容扩充（新增或者修改职业、变体、专长、法术等游戏内容）的MOD，并尽量保持时效性。
+ ToyBox、Bubble Buffs等功能性MOD不在本文档介绍范围。
+ 特别注意，本文档作者的游戏理解还是新手，很可能评价并不贴切。
+ 强烈建议先行阅读[正义之怒MOD教程](https://github.com/1onepower/KM-WotR_Modding_Wiki/blob/main/%E4%B8%AD%E6%96%87%E7%89%88.md) （1onepower）。该文档含有详细的**UMM安装教程**和部分MOD介绍，但文档时间较早，部分MOD可能已经失效。


## 目录

- [基础知识](#前置安装)
  - [UMM的安装](#UMM的安装)
  - [MOD须知](#MOD须知)
  - [ModFinder工具](#ModFinder工具)
  - [GITHUB访问和MOD下载](#GITHUB访问和MOD下载)
  - [Nexus访问和MOD下载](#Nexus访问和MOD下载)
  - [前置MOD](#前置MOD)
  - [汉化修正文件及其他说明](#汉化修正文件及其他说明)
- [MOD列表](#MOD列表)
  - [TabletopTweaks-Base](#TabletopTweaks-Base) TTT
    - [TabletopTweaks-Reworks](#TabletopTweaks-Reworks) TTT神话扩展
  - [MicroscopicContentExpansion](#MicroscopicContentExpansion) Microscopic内容扩展
  - [SparsSorcerousSundries](#SparsSorcerousSundries) SSS内展
  - [TomeOfTheFirebird](#TomeOfTheFirebird) TOTF扩展
  - [HomebrewArchetypes](#HomebrewArchetypes) Homebrew(村规)变体
  - [ExpandedContent2022](#ExpandedContent2022) 扩展内容2022
  - [ToggleableThrowingWeapons](#ToggleableThrowingWeapons) 可切换投掷武器
  - [MorvarchsPlaystyleExpansions](#MorvarchsPlaystyleExpansions) Morvarchs玩法扩展
  - [PhoenixsCantrips](#PhoenixsCantrips) Phoenixs戏法强化
    - [MoreCantrips](#MoreCantrips) 更多戏法
  - [CharacterOptionsPlus](#CharacterOptionsPlus) 角色选项+

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
+ ModFinder为绿色工具，可以在任何路径打开（但是最好不要用中文路径），会自动识别正义之怒的安装位置。
+ ModFinder在启动时可能会出现弹框错误，发生此种情况多半是Github访问失败的导致的，请参照下一节解决。

### GITHUB访问和MOD下载
+ 在国内很多网络环境，Github访问都存在一定抽风现象，会出现时不时打开失败。通常刷新就可以解决。如果实在问题严重，[Watt Toolkit](https://steampp.net/)可以帮到你。
+ 给予完全萌新的提示：大部分MOD发布页中，直接点击右侧**Releases** 按钮即打开下载页面，Assets中第一项即为MOD。下载后不需要解压缩，直接使用UMM或者ModFinder安装。

### Nexus访问和MOD下载
+ Nexus的MOD在标题右方的Manual按钮即可直接下载。如果有额外文件会在FILES标签中。
+ Nexus目前需要注册用户才能下载。

### 前置MOD
目前正义之怒所需主要前置MOD有两个：
1. [TabletopTweaks-Core](https://github.com/Vek17/TabletopTweaks-Core)（**核心必备**，绝大部分MOD的基础框架，本身不会进行任何改动。）
2. [ModMenu](https://github.com/WittleWolfie/ModMenu)（**非必备**，一部分MOD使用的基础框架。会在游戏中选项里添加一个新的页面来进行MOD功能调整。）

### 汉化修正文件及其他说明
+ 本文档上方会收集一些个人提供的**MOD汉化或汉化修正文件**，不定时更新。
+ 可以点击上方**code**按钮中的**Download Zip**打包下载素有附件。
+ 一般**UMM安装*的MOD，汉化文件的使用方法是直接替换游戏目录下\mods\对应mod名称\Localization\中同名文件即可。
+ 对于**非UMM安装*的MOD，替换C:\Users\你的用户文件夹\AppData\LocalLow\Owlcat Games\Pathfinder Wrath Of The Righteous\Modifications\对应mod名称\Localization\中同名文件。
+ 但是某些MOD没有语言文件，有些替换后无效，我就不知道咋办了。文档作者是代码盲，需要大佬协助233
+ **变体、专长等可以尝试在“Pathfinder v2.02简体文档”（分卷压缩）中搜索译文，本文档尽量提供中英文对照。**
+ 大部分MOD是对原规则的还原，对于较为复杂的职业、专长详情会标明<i>参阅PF文档</i>，可在上述Pathfinder v2.02简体文档中查看，但实际MOD中并不一定完全效果相同。
-------------------------------------------

## MOD列表
**本列表中MOD均在2.0.7版本测试通过**
-------------------------------------------
### [TabletopTweaks-Base](https://github.com/Vek17/TabletopTweaks-Base)
> *前置：* TabletopTweaks-Core<br>
> *中文：* **自带中文（部分内容没更新，本处提供修复）**<br>
> *安装方式：* UMM<br>
> *修改内容：* UI、核心规则、法术、专长、职业特性、神话能力、神话专长，等<br>
> *新增内容：* 变体、巅峰、法术、专长、种族、背景，等<br>
+ 简称**TTT**，提到正义之怒MOD就必定会提到TTT，基本上也是大部分人第一个玩的内容型MOD。
+ 新增了海量的游戏内容，让游戏完全变了个样的同时，也提供了很多新的选项。
> 例如，新增的重甲系两个神话专长可以进一步提升重甲提供的AC，同时降低重甲的惩罚，让玩家在无甲+大法师护甲外有了额外选项。<br>
> 新增的奥术发现专长可以让法师的变化系法术（动物园系列）提供额外属性加成，20级达到+8，是的玩家拥有属性头带腰带外的大量选择。<br>
> 新增的巅峰系统给很多纯职都提供了福利
+ 特别需要注意的是，TTT对原版做出了大量修改，尤其是**良性BUG**方面。
+ 如果你习惯了原版体系和构建，可能用了TTT会有极大怨言。好在这些修复都是可以关闭的<br>
+ （友情提示，但是由于新增了大量内容，关闭这些修复很容易导致过于滥强）<br>
+ TTT的更新过于庞杂海量，建议有一定英文基础和游戏基础再玩（虽然内容已经汉化但是选项菜单无法汉化）

<table>
<tr><th colspan="5">修改列表</th></tr> 
<tr><td>分类</td><td>Config中选项</td><td>默认开启</td><td>房规</td><td>效果</td></tr>
<tr><td rowspan="34">基本修复<br>Base</td>
   <td>AreaOfEffectDoubleTrigger
        </td><td>是
        </td><td>否
        </td><td>修复AOE法术释放时额外触发一次</td></tr>
      <tr><td>CoupDeGrace
        </td><td>是
        </td><td>否
        </td><td>致命一击DC现在基于伤害</td></tr>
      <tr><td>DamageReductionRework
        </td><td>是
        </td><td>否
        </td><td>防止DR叠加，除非特别声明</td></tr>
      <tr><td>DamageVulnerability
        </td><td>是
        </td><td>否
        </td><td>易伤对多类型伤害正确生效</td></tr>
      <tr><td>DiceReplacementUI
        </td><td>是
        </td><td>否
        </td><td>修改掷骰点数显示</td></tr>
      <tr><td>DisableAfterCombatDeactivationOfUnlimitedAbilities
        </td><td>是
        </td><td>否
        </td><td>允许无限使用能力战斗后保持激活</td></tr>
      <tr><td>DisableCannyDefenseStacking
        </td><td>是
        </td><td>否
        </td><td>防止剑圣和决斗家AC奖励叠加</td></tr>
      <tr><td>DisableNaturalArmorStacking
        </td><td>是
        </td><td>否
        </td><td>天生防御加值不再叠加，除非特别说明。“天生防御加值”和“天生防御加值增强”依然正确叠加</td></tr>
      <tr><td>DisablePolymorphSizeStacking
        </td><td>是
        </td><td>否
        </td><td>激活变形法术会正确压制非变形法术的尺寸变化效果</td></tr>
      <tr><td>DisablePolymorphStacking
        </td><td>是
        </td><td>否
        </td><td>防止多个变形效果叠加</td></tr>
      <tr><td>DisableSizeStacking
        </td><td>是
        </td><td>否
        </td><td>防止多个尺寸变化效果叠加，后获得的效果只会被压制不生效，并不会被移除</td></tr>
      <tr><td>DisplaySpellbookInTooltips
        </td><td>是
        </td><td>否
        </td><td>修改法术界面显示其法术书来源</td></tr>
      <tr><td>DynamicItemNaming
        </td><td>是
        </td><td>否
        </td><td>为装备名称添加上附魔词缀</td></tr>
      <tr><td>DynamicItemNamingTemporary
        </td><td> 否
        </td><td>否
        </td><td>词缀包括临时附魔</td></tr>
      <tr><td>FeatSelections
        </td><td>是
        </td><td>否
        </td><td><s>改正奖励专长选择，比如战士的额外专长，来允许选择所有指定类型专长</s>原版已修复</td></tr>
      <tr><td>FixBackgroundModifiers
        </td><td>是
        </td><td>是
        </td><td>背景给予的技能和攻击加值改为特性加值</td></tr>
      <tr><td>FixBuffCasterOnSaveLoad
        </td><td>是
        </td><td>否
        </td><td>读取存档时BUFF施法者能够被正确记录 </td></tr>
      <tr><td>FixConcealment
        </td><td>是
        </td><td>否
        </td><td>修复隐形的隐蔽检定</td></tr>
      <tr><td>FixCriticalConfirmation
        </td><td>是
        </td><td>否
        </td><td>允许天然20自动确认重击</td></tr>
      <tr><td>FixInherentBonuses
        </td><td>是
        </td><td>否
        </td><td>永久属性奖励能够作为专长前置</td></tr>
      <tr><td>FixInherentSkillpoints
        </td><td>是
        </td><td>否
        </td><td>永久智力奖励能够准确获取技能点</td></tr>
      <tr><td>FixMountedLongspearModifer
        </td><td>是
        </td><td>否
        </td><td>长矛在骑乘冲锋时获得额外伤害</td></tr>
      <tr><td>FixPrebuffCasterLevels
        </td><td>是
        </td><td>否
        </td><td>修正敌人自带BUFF的CL</td></tr>
      <tr><td>FixProgressionDisplay
        </td><td>是
        </td><td>否
        </td><td>进程不再显示你不会获得的特性</td></tr>
      <tr><td>FixShadowSpells
        </td><td>是
        </td><td>否
        </td><td>修复阴影模拟系列法术，使其正确从幻象学派获益</td></tr>
      <tr><td>FixSizeShiftLimits
        </td><td>是
        </td><td>否
        </td><td>修正从Fine到Colossal的尺寸比例</td></tr>
      <tr><td>FixWeaponEnhancmentBonusModifiers
        </td><td>是
        </td><td>否
        </td><td>武器增强加值和非武器增强价值现在从逻辑上区分开</td></tr>
      <tr><td>MetamagicStacking
        </td><td>是
        </td><td>否
        </td><td>防止强效超魔的额外骰子受到极效作用</td></tr>
      <tr><td>MetamagicBolsterDoubleDiping
        </td><td>是
        </td><td>否
        </td><td>防止法术增效超魔多次应用于同一法术</td></tr>
      <tr><td>MountedActions
        </td><td>是
        </td><td>否
        </td><td>骑乘移动后不能再进行整轮动作</td></tr>
      <tr><td>NauseatedDescriptors
        </td><td>是
        </td><td>否
        </td><td>移除恶心的移动受限描述</td></tr>
      <tr><td>SelectiveMetamagicNonInstantaneous
        </td><td>是
        </td><td>否
        </td><td>修复持续时间不是立即的法术也能应用甄选附魔的问题</td></tr>
      <tr><td>StaggeredDescriptors
        </td><td>是
        </td><td>否
        </td><td>移除恍惚的移动受限描述</td></tr>
      <tr><td>SuppressedBuffUI
        </td><td>是
        </td><td>否
        </td><td>改变被抑制的BUFF的渲染方式</td></tr>
 <tr><td rowspan="3">御衡道途</td>
          <td>AeonDemythication
        </td><td>是
        </td><td>否
        </td><td>神话抑制能够正确抑制神话效果了</td></tr>
      <tr><td>AeonTenthLevelImmunities
        </td><td>是
        </td><td>否
        </td><td>修复御衡者免疫效果</td></tr>
      <tr><td>PowerOfLaw
        </td><td>是
        </td><td>否
        </td><td>逼迫凝视（秩序之力）对于重投类效果正确生效了</td></tr>
  <tr><td>恶魔道途</td>
      <td>BrimorakAspect
        </td><td>是
        </td><td>否
        </td><td>爆燃魔相对所有法术都能正确生效了</td></tr>
  <tr><td rowspan="2">巫妖道途</td>
      <td>DeathRush
        </td><td>是
        </td><td>否
        </td><td>死亡冲击不再产生多次伪攻击并触发武器效果</td></tr>
      <tr><td>SpellbookMerging
        </td><td>是
        </td><td>否
        </td><td>允许自然魔法师巫妖合书</td></tr>
  <tr><td>诡计道途</td>
      <td>UseMagicDevice2
        </td><td>是
        </td><td>否
        </td><td>神话诡计使用魔法装置2允许诡计大师忽略装备的阵营和职业需求</td></tr>
  <tr><td>巅峰</td>
      <td>AlternateCapstones</td><td colspan="3">允许单独开关各个职业巅峰，详见新增内容</td></tr>
  <tr><td rowspan="6">炼金术士<br>Alchemist</td>
      <td>Base - MutagenStacking
            </td><td>是
            </td><td>否
            </td><td>防止诱变剂叠加</td></tr>
        <tr><td>Archetypes - Grenadier - BrewPotions
            </td><td>是
            </td><td>否
            </td><td>掷弹兵：移除变体调制药水能力</td></tr>
        <tr><td>Archetypes - Grenadier - PoisonResistance
            </td><td>是
            </td><td>否
            </td><td>掷弹兵：移除变体毒素抵抗能力</td></tr>
         <tr><td>Archetypes - IncenseSynthesizer - ImprovedIncense
            </td><td>是
            </td><td>否
            </td><td>调香师：修正强化熏香范围扩大后效果</td></tr>
          <tr><td>Archetypes - IncenseSynthesizer - ThickFog
            </td><td>是
            </td><td>否
            </td><td>调香师：将浓雾的隐蔽类型改为烟雾性质而不再是幻象性质</td></tr>
          <tr><td>Archetypes - IncenseSynthesizer - SacredIncense
            </td><td>是
            </td><td>否
            </td><td>调香师：修复崇圣熏香效果</td></tr>
  <tr><td rowspan="2">奥能师<br>Arcanist</td>
    <td>Base - reparedSpellUI
          </td><td>是
          </td><td>否
          </td><td>让奥能师的法术书UI更符合记忆施法者</td></tr>
    <tr><td>Base - EnableMultipleMemorization
          </td><td>是
          </td><td>否
          </td><td>允许奥能师记忆不同超魔的同个法术</td></tr>
  <tr><td rowspan="2">野蛮人<br>Barbarian</td>
        <td>Base - CripplingBlows
          </td><td>是
          </td><td>否
          </td><td>致残猛击允许狂暴中使用</td></tr>
        <tr><td>Base - WreckingBlows
          </td><td>是
          </td><td>否
          </td><td>毁灭猛击允许狂暴中使用</td></tr>
  <tr><td rowspan="10">血怒者<br>Bloodrager</td>
    <td>Base - AbysalBulk
          </td><td>是
          </td><td>否
          </td><td>深渊血脉巨化魔躯能力在狂暴结束时不再驱散已有的增大效果</td></tr>
        <tr><td>Base - ArcaneBloodrage
          </td><td>是
          </td><td>否
          </td><td>重做奥术血怒UI</td></tr>
        <tr><td>Base - CastersBane
          </td><td>是
          </td><td>否
          </td><td>允许奥术血怒巅峰 - 施法者克星</td></tr>
        <tr><td>Base - DisruptiveBloodrage
          </td><td>是
          </td><td>否
          </td><td>允许奥术血怒 - 扰法血怒</td></tr>
        <tr><td>Base - Spellbook
          </td><td>是
          </td><td>否
          </td><td>修复法术进程防止依赖预先施法的特性不生效</td></tr>
        <tr><td>Base - TemporaryHitPoints
          </td><td>是
          </td><td>否
          </td><td>修复临时生命值计算</td>
        <tr><td>Archetypes - Primalist - FixBrokenRagePowers
            </td><td>是
            </td><td>否
            </td><td>原怒者：允许血怒下使用所有狂暴之力</td></tr>
        <tr><td>Archetypes - Primalist - RagePowerFeatQualifications
            </td><td>是
            </td><td>否
            </td><td>原怒者：防止允许学习额外狂暴特技专长</td></tr>
        <tr><td>Archetypes - ReformedFiend - DamageReduction
            </td><td>是
            </td><td>否
            </td><td>自新魔士：DR纠正为DR/善良.</td></tr>
        <tr><td>Archetypes - ReformedFiend - HatredAgainstEvil
            </td><td>是
            </td><td>否
            </td><td>修复憎恨邪恶奖励</td></tr>
  <tr><td rowspan="5">骑将<br>Cavalier</td>
    <td>Base - CavalierMobility
          </td><td>是
          </td><td>否
          </td><td>骑乘移动时忽略运动检定的护甲惩罚</td></tr>
        <tr><td>Base - CavalierMountSelection
          </td><td>是
          </td><td>否
          </td><td>小体型骑将允许选择狼坐骑</td></tr>
        <tr><td>Base - OrderOfTheStarCalling
          </td><td>是
          </td><td>否
          </td><td>修复星辰骑士团使命感效果</td></tr>
        <tr><td>Base - SupremeCharge
          </td><td>是
          </td><td>否
          </td><td>防止至高冲锋伤害重击，使用新的冲锋伤害系统</td></tr>
        <tr><td>Archetypes - Gendarme - TransfixingCharge
            </td><td>是
            </td><td>否
            </td><td>防止穿透冲锋伤害重击，使用新的冲锋伤害系统</td></tr>
  <tr><td>牧师<br>Cleric</td>
      <td>Base - GloryDomain
          </td><td>是
          </td><td>否
          </td><td><s>修复荣耀领域魅力奖励</s>原版已修复</td></tr>
  <tr><td rowspan="6">战士<br>Fighter</td>
        <td>Base - AdvancedArmorTraining
          </td><td>是
          </td><td>否
          </td><td>允许战士选择高级护甲训练，替代护甲训练升级</td></tr>
        <tr><td>AdvancedWeaponTraining
          </td><td>是
          </td><td>否
          </td><td>修复武器训练先决条件</td></tr>
        <tr><td>TwoHandedWeaponTraining
          </td><td>是
          </td><td>否
          </td><td>修复双手武器战士训练没有被正确视为武器训练的问题</td></tr>
        <tr><td>UnarmedWeaponTraining
          </td><td>是
          </td><td>否
          </td><td>徒手攻击被正确算作近身武器组</td></tr>
        <tr><td>WeaponTrainingStacking
          </td><td>是
          </td><td>否
          </td><td>防止多个武器训练组叠加</td></tr>
        <tr><td>Archetypes - TwoHandedFighter - AdvancedWeaponTraining
            </td><td>是
            </td><td>否
            </td><td>双手武器战士：允许选择进阶武器训练专长</td></tr>
  <tr><td rowspan="1">猎人</td>
    <td>Archetypes - DivineHunter - OtherworldlyCompanion
            </td><td>是
            </td><td>否
            </td><td>神眷猎人：天界和魔界变体不再给予无限辟邪斩类能力</td></tr>
  <tr><td rowspan="5">魔战士<br>Magus</td>
    <td>Base - AddMissingArcaneWeaponEffects
          </td><td>是
          </td><td>否
          </td><td>添加缺少的奥法武器效果：焰爆、霜爆、电爆</td></tr>
        <tr><td>Base - SpellCombatAbilityVariants
          </td><td>是
          </td><td>否
          </td><td>使得法术战斗能够对带有进一步选项的法术（如：次元门）适用</td></tr>
        <tr><td>Base - SpellCombatDisableImmediatly
          </td><td>是
          </td><td>否
          </td><td>关闭法术战斗时当个回合立刻生效，不需要等待下个回合</td></tr>
        <tr><td>Base - SpellCombatSpellbookRestrictions
          </td><td>是
          </td><td>否
          </td><td>防止不在魔战士法术表上的法术适用于法术战斗</td></tr>
        <tr><td>Archetypes - SwordSaint - PerfectCritical
            </td><td>是
            </td><td>否
            </td><td>剑圣：完美重击花费2点奥法点数</td></tr>
  <tr><td rowspan="5">武僧<br>Monk</td>
        <td>Base - StunningFistVarriants
          </td><td>是
          </td><td>否
          </td><td>增加缺失的在12、16、20级获得的震慑拳选项</td></tr>
        <tr><td>Base - StunningFistDescriptors
          </td><td>是
          </td><td>否
          </td><td>修复震慑拳描述字段，避免免疫对应效果时生效</td></tr>
        <tr><td>Archetypes - ZenArcher - PerfectStrike
            </td><td>是
            </td><td>否
            </td><td>禅宗射手：10级时极意击改为投3个骰子</td></tr>
        <tr><td>Archetypes - ScaledFist - FixStunningStrike
            </td><td>是
            </td><td>否
            </td><td>鳞甲之拳：使得震慑拳使用普通版本</td></tr>
          <tr><td>DraconicFury
            </td><td>是
            </td><td>否
            </td><td>鳞甲之拳：龙裔怒火替换为Unchained版本 </td></tr>
  <tr><td rowspan="2">先知<br>Oracle</td>
        <td>Base - NaturesWhisperMonkStacking</td>
          </td><td>是
          </td><td>否
          </td><td>启示：自然低语不能再和鳞甲之拳的AC奖励叠加。拥有鳞甲之拳效果时会改回使用敏捷奖励</td></tr>
        <tr><td>Base - RevelationBurningMagic
          </td><td>是
          </td><td>否
          </td><td>启示：修复烈焰魔法CL计算</td></tr>
  <tr><td rowspan="2">圣武士<br>Paladin</td>
        <td>Base - DivineMountTemplate</td>
          </td><td>是
          </td><td>否
          </td><td>修复圣骑士模板，给予应有特性</td></tr>
        <tr><td>Base - SmiteAttackBonus
          </td><td>是
          </td><td>否
          </td><td>辟邪斩攻击加值不能再和类似能力（辟邪斩、正义烙印）等叠加</td></tr>
   <tr><td rowspan="2">游侠<br>Ranger</td>
        <td>Base - FavoredEnemy</td>
          </td><td>是
          </td><td>否
          </td><td>统一三种恶魔宿敌为异界生物，不能再选择单独种类恶魔（对于已经选择的不会删除，你依然可以继续选择防止出现兼容性问题）</td></tr>
    <tr><td>Archetypes - EspionageExpert - Trapfinding
            </td><td>是
            </td><td>否
            </td><td>谍报专家：寻找陷阱特性现在对察觉和巧手生效</td></tr>   
  <tr><td rowspan="7">游荡者<br>Rogue</td>
        <td>Base - DispellingAttack
          </td><td>是
          </td><td>否
          </td><td>修复职业特性解除正确CL，不会解除DEBUFF</td></tr>
        <tr><td>Base - RogueTalentSelection
          </td><td>是
          </td><td>否
          </td><td>游荡者天赋不能重复选择同一个（比如战斗专长）</td></tr>
        <tr><td>Base - SlipperyMind
          </td><td>是
          </td><td>否
          </td><td>心智灵活纠正为高级天赋</td></tr>
        <tr><td>Base - Trapfinding
          </td><td>是
          </td><td>否
          </td><td>寻找陷阱特性现在对察觉和巧手生效</td></tr>
        <tr><td>Archetypes - EldritchScoundrel - RogueTalentProgression
            </td><td>是
            </td><td>否
            </td><td>奥法暴徒：2级游荡者天赋移动到4级</td></tr>
         <tr><td>Archetypes - EldritchScoundrel - SneakAttackProgression
            </td><td>是
            </td><td>否
            </td><td>奥法暴徒：移除1级偷袭骰</td></tr>
         <tr><td>Archetypes - SylvanTrickster - FeyTricks
            </td><td>是
            </td><td>否
            </td><td>林妖诡术师：妖精诡术现包括所有游荡者天赋</td></tr>
  <tr><td>萨满<br>Shaman</td>
        <td>Base - AmelioratingHex
          </td><td>是
          </td><td>否
          </td><td>救难不再给予完全免疫能力，改为压制效果</td></tr>
  <tr><td rowspan="2">歌者<br>Skald</td>
    <td>Base - SpellKenning
          </td><td>是
          </td><td>否
          </td><td>允许法术认知特性</td></tr>      
    <tr><td>Archetypes - BattleScion - BattleProwessSelection
            </td><td>是
            </td><td>否
            </td><td>战歌贵胄：补充缺失的狂暴之力选项</td></tr>
  <tr><td>杀手<br>Slayer</td>
    <td>Base - Trapfinding
          </td><td>是
          </td><td>否
          </td><td>寻找陷阱特性现在对察觉和巧手生效</td></tr>
  <tr><td rowspan="3">术士<br>Sorcerer</td>
    <td>Base - DraconicBloodlineDescriptions
          </td><td>是
          </td><td>否
          </td><td>血承：修正奥术血承描述</td></tr>
        <tr><td>PatchElementalBloodlineDescriptions
          </td><td>是
          </td><td>否
          </td><td>修复升级UI上元素血承的错误</td></tr>
      <tr><td>Archetypes - Crossblooded - Drawbacks
            </td><td>是
            </td><td>否
            </td><td>混血术士：补充混血术士应承受的-2意志豁免惩罚</td></tr>       
  <tr><td rowspan="6">战斗祭司<br>Warpriest</td>
        <td>Base - AirBlessing
          </td><td>是
          </td><td>否
          </td><td>空气主要祝福不再造成过多的伤害实例</td></tr>
        <tr><td>Base - EarthBlessing
          </td><td>是
          </td><td>否
          </td><td>大地次要祝福不再造成过多的伤害实例</td></tr>
        <tr><td>Base - FireBlessing
          </td><td>是
          </td><td>否
          </td><td>火焰次要祝福不再造成过多的伤害实例</td></tr>
        <tr><td>Base - LuckBlessing
          </td><td>是
          </td><td>否
          </td><td>幸运祝福提供正确主要能力</td></tr>
        <tr><td>Base - WaterBlessing
          </td><td>是
          </td><td>否
          </td><td>流水次要祝福不再造成过多的伤害实例</td></tr>
        <tr><td>Base - WeatherBlessing
          </td><td>是
          </td><td>否
          </td><td>天气次要祝福不再造成过多的伤害实例</td></tr>      
  <tr><td rowspan="3">巫师<br>Witch</td>
        <td>Base - AgilityPatron
          </td><td>是
          </td><td>否
          </td><td>机敏庇护主提供动物之型和变化形体</td></tr>
        <tr><td>Base - AmelioratingHex
          </td><td>是
          </td><td>否
          </td><td>救难不再给予完全免疫能力，改为压制效果</td></tr>
        <tr><td>Base - MajorAmelioratingHex
          </td><td>是
          </td><td>否
          </td><td>强效救难不再给予完全免疫能力，改为压制效果</td></tr>
  <tr><td>地狱骑士<br>Hellknight</td>
      <td>PentamicFaith
        </td><td>是
        </td><td>否
        </td><td>五誓：仅限神爪骑士团，不限信仰神祗</td></tr>
  <tr><td rowspan="4">博学士<br>Loremaster</td>
      <td>Prerequisites
        </td><td>是
        </td><td>否
        </td><td>将前置条件改为更符合桌面规则</td></tr>
      <tr><td>SpellProgression
        </td><td>是
        </td><td>否
        </td><td>1级获得施法能力升级（拿可知法术），这个改动不能回溯</td></tr>
      <tr><td>SpellSecrets
        </td><td>是
        </td><td>否
        </td><td>允许法术秘闻</td></tr>
      <tr><td>TricksterTricks
        </td><td>是
        </td><td>否
        </td><td>从秘闻战斗专长列表中移除诡计道途相关专长</td></tr>
  <tr><td>冬巫<br>WinterWitch</td>
      <td>UnearthlyCold
        </td><td>是
        </td><td>否
        </td><td>修复异界严寒和超魔及奖励伤害的互动</td></tr
  <tr><td rowspan="54">法术<br>Spells</td>
      <td>AbsoluteOrder
        </td><td>是
        </td><td>否
        </td><td>Adds the compulsion spell descriptor to match command.</td></tr>
      <tr><td>AbyssalStorm
        </td><td>是
        </td><td>否
        </td><td>Abyssal Storm no longer saves for half and no longer kills the caster.</td></tr>
      <tr><td>AcidMaw
        </td><td>是
        </td><td>否
        </td><td>Acid Maw no longer causes excessive damage instances to trigger when attacking.</td></tr>
      <tr><td>AnimalGrowth
        </td><td>是
        </td><td>否
        </td><td>Should now work properly on animal companions.</td></tr>
      <tr><td>BelieveInYourself
        </td><td>是
        </td><td>否
        </td><td>Believe in yourself now grants the correct bonus amount.</td></tr>
      <tr><td>BestowCurseGreater
        </td><td>是
        </td><td>否
        </td><td>Bestow Greater Curse now actually bestows a greater curse not a normal curse.</td></tr>
      <tr><td>BreakEnchantment
        </td><td>是
        </td><td>否
        </td><td>Break Enchantment no longer affects friendly buffs.</td></tr>
      <tr><td>ChainLightning
        </td><td>是
        </td><td>否
        </td><td>Chain Lightning now respect the 20 CL max for damage dice.</td></tr>
      <tr><td>Command
        </td><td>是
        </td><td>否
        </td><td>Adds missing spell descriptors to match tabletop.</td></tr>
      <tr><td>CommandGreater
        </td><td>是
        </td><td>否
        </td><td>Adds missing spell descriptors to match tabletop.</td></tr>
      <tr><td>ConeOfCold
        </td><td>是
        </td><td>否
        </td><td>Adds Cone of Cold to the Witch spell list.</td></tr>
      <tr><td>CorruptMagic
        </td><td>是
        </td><td>否
        </td><td>Corrupt Magic now uses a single dispel roll for all buffs like other dispels.</td></tr>
      <tr><td>CrusadersEdge
        </td><td>是
        </td><td>否
        </td><td>Crusaders Edge's nauseate effect now only procs on critical hits.</td></tr>
      <tr><td>DeathWard
        </td><td>是
        </td><td>否
        </td><td>Now suppresses existing negative levels.</td></tr>
      <tr><td>DispelMagicGreater
        </td><td>是
        </td><td>否
        </td><td>Greater Dispel Magic now only removes 1/4 CL buffs instead of all buffs.</td></tr>
      <tr><td>EyeOfTheSun
        </td><td>是
        </td><td>否
        </td><td>Eye Of The Sun now deals the correct amount of damage.</td></tr>
      <tr><td>Firebrand
        </td><td>是
        </td><td>否
        </td><td>Firebrand no longer causes excessive damage instances to trigger when attacking.</td></tr>
      <tr><td>SunMarked
        </td><td>是
        </td><td>否
        </td><td>Sun Marked no longer causes excessive damage instances to trigger when attacking.</td></tr>
      <tr><td>FieldOfFlowers
        </td><td>是
        </td><td>否
        </td><td>FieldOfFlowers ow correctly applies the Field of Flower debuffs instead of Repulsive Nature ones.</td></tr>
      <tr><td>FixSpellFlags
        </td><td>是
        </td><td>否
        </td><td>Retags buffs from spells as coming from spells to allow them to be dispelled correctly.</td></tr>
      <tr><td>FlameStrike
        </td><td>是
        </td><td>否
        </td><td>Now correctly halves divine damage on saving throw.</td></tr>
      <tr><td>FriendlyHug
        </td><td>是
        </td><td>否
        </td><td>Friendly Hug now correctly applies all immunities.</td></tr>
      <tr><td>FrightfulAspect
        </td><td>是
        </td><td>否
        </td><td>Frightful Aspect now correctly applies fear when hit in melee.</td></tr>
      <tr><td>Geniekind
        </td><td>是
        </td><td>否
        </td><td>Geniekind no longer causes excessive damage instances to trigger when attacking.</td></tr>
      <tr><td>GreaterMagicWeapon
        </td><td>是
        </td><td>否
        </td><td>Greater Magic Weapon no longer stacks with existing enhancement bonuses.</td></tr>
      <tr><td>HellfireRay
        </td><td>是
        </td><td>否
        </td><td>Hellfire Ray no longer has the Fire descriptor and deals the correct half damage.</td></tr>
      <tr><td>JoyOfLife
        </td><td>是
        </td><td>否
        </td><td>Joy of Life now converts outgoing damage to Holy.</td></tr>
      <tr><td>LegendaryProportions
        </td><td>是
        </td><td>否
        </td><td>LegendaryProportions now only increases size by one step instead of two to correctly match tabletop.</td></tr>
      <tr><td>MagicalVestment
        </td><td>是
        </td><td>否
        </td><td>Magical Vestment now enhances your armor instead of granting a floating modifier.</td></tr>
      <tr><td>MicroscopicProportions
        </td><td>是
        </td><td>否
        </td><td>Microscopic Proportions now correctly grants a size bonus instead of an untyped bonus.</td></tr>
      <tr><td>NaturesGrasp
        </td><td>是
        </td><td>否
        </td><td>Natures Grasp now deals the correct amount of damage.</td></tr>
      <tr><td>OdeToMiraculousMagic
        </td><td>是
        </td><td>否
        </td><td>Ode to Miraculous Magic's duration now correctly scales off CL instead of mythic rank.</td></tr>
      <tr><td>PerfectForm
        </td><td>是
        </td><td>否
        </td><td>Perfect Form can no longer be stacked multiple time for multiple stat boosts.</td></tr>
      <tr><td>PowerFromDeath
        </td><td>是
        </td><td>否
        </td><td>Now correctly lasts rounds per level instead of minutes per level.</td></tr>
      <tr><td>ProtectionOfNature
        </td><td>是
        </td><td>否
        </td><td>Protection of Nature's concealment is no longer bypassed by true seeing.</td></tr>
      <tr><td>RemoveFear
        </td><td>是
        </td><td>否
        </td><td>Remove fear no longer makes you immune to shaken and fear.</td></tr>
      <tr><td>RemoveSickness
        </td><td>是
        </td><td>否
        </td><td>Remove Sickness no longer makes you immune to sickness and nausea.</td></tr>
      <tr><td>RepulsiveNature
        </td><td>是
        </td><td>否
        </td><td>RepulsiveNature now uses the correct spell DC and actually applies its debuffs on fail.</td></tr>
      <tr><td>ShadowConjuration
        </td><td>是
        </td><td>否
        </td><td>Shadow Conjuration has been added to the Wizard spell list.</td></tr>
      <tr><td>ShadowEvocation
        </td><td>是
        </td><td>否
        </td><td>Shadow Evocation can now have the correct metamagics applied.</td></tr>
      <tr><td>ShadowEvocationGreater
        </td><td>是
        </td><td>否
        </td><td>Greater Shadow Evocation can now have the correct metamagic applied and get the correct shadow factor of 60.</td></tr>
      <tr><td>SongsOfSteel
        </td><td>是
        </td><td>否
        </td><td>Songs of Steel bonus weapon damage now works correctly.</td></tr>
      <tr><td>Starlight
        </td><td>是
        </td><td>否
        </td><td>Starlight no longer is affected by true sight.</td></tr>
      <tr><td>SuddenSquall
        </td><td>是
        </td><td>否
        </td><td>Sudden Squall now can be targeted and has a working debuff.</td></tr>
      <tr><td>SunForm
        </td><td>是
        </td><td>否
        </td><td>Sun Form now deals the correct amount of damage.</td></tr>
      <tr><td>Supernova
        </td><td>是
        </td><td>否
        </td><td>Supernova now respects the saving throw for the blind and always deals the correct amount of damage.</td></tr>
      <tr><td>UnbreakableBond
        </td><td>是
        </td><td>否
        </td><td>Friendly Hug now correctly applies all immunities.</td></tr>
      <tr><td>UnbreakableHeart
        </td><td>是
        </td><td>否
        </td><td>Unbreakable Heart no longer grants complete immunity to effects and instead suppresses correctly.</td></tr>
      <tr><td>WaterPush
        </td><td>是
        </td><td>否
        </td><td>Water Push now can be targeted and has the correct damage scaling and push distance.</td></tr>
      <tr><td>WaterTorrent
        </td><td>是
        </td><td>否
        </td><td>Water Torrent now can be targeted and has a working debuff.</td></tr>
      <tr><td>WindsOfFall
        </td><td>是
        </td><td>否
        </td><td>Winds of the Fall now can be targeted and has a working debuff.</td></tr>
      <tr><td>WrackingRay
        </td><td>是
        </td><td>否
        </td><td>Wracking Ray now deals the correct amount of ability damage.</td></tr>
      <tr><td>VampiricBlade
        </td><td>是
        </td><td>否
        </td><td>Vampiric Blade no longer causes excessive damage instances.</td></tr>
      <tr><td>ZeroState
        </td><td>是
        </td><td>否
        </td><td>Zero State now uses a single dispel roll for all buffs like other dispels.</td></tr>
  <tr><td rowspan="4">职业特性</td>
        <td>AnimalCompanions - AnimalCompanionProgression
        </td><td> 否
        </td><td>否
        </td><td>Updates animal companion progressions to reflect tabletop values.</td></tr>
     <tr><td>Bloodlines - BloodlineRestrictions
        </td><td>是
        </td><td>否
        </td><td>Cleans up bloodline restrictions to actually work correctly with things like Dragon disciple.</td></tr>
     <tr><td>Features - IncorporealCharm
        </td><td>是
        </td><td>否
        </td><td>Now properly updates when charisma is modified.</td></tr>
      <tr><td>MongrolsBlessing
        </td><td>是
        </td><td>否
        </td><td>Now properly applies negative levels.</td></tr>
  <tr><td rowspan="28">专长<br>Feats</td>
      <td>AlliedSpellcaster
        </td><td>是
        </td><td>否
        </td><td>Prevents Allied Spellcaster from applying globally.</td></tr>
      <tr><td>ArcaneStrike
        </td><td>是
        </td><td>否
        </td><td>Prevents draconic arcane strike from generating too many damage instances.</td></tr>
      <tr><td>BolsteredMetamagic
        </td><td>是
        </td><td>否
        </td><td>Allows sticky touch spells to be bolstered.</td></tr>
      <tr><td>BrewPotions
        </td><td>是
        </td><td>否
        </td><td>No longer is tagged as a combat feat.</td></tr>
      <tr><td>Cleave
        </td><td>是
        </td><td>否
        </td><td>Now checks for adjacency instead of just within reach. This also applies to cleaving finish.</td></tr>
      <tr><td>CraneWing
        </td><td>是
        </td><td>否
        </td><td>Now requires a free hand to receive the bonuses.</td></tr>
      <tr><td>DestructiveDispel
        </td><td>是
        </td><td>true,
        </td><td>Now calculates the DC based on the effective CL of the dispel and the highest mental stat to better support edge cases. Formula is 10 + 1/2 CL + Highest Mental Stat.</td></tr>
      <tr><td>DestructiveDispelPrerequisites
        </td><td>是
        </td><td>否
        </td><td>Reworked prerequisites to match tabletop.</td></tr>
      <tr><td>DispelSynergy
        </td><td>是
        </td><td>否
        </td><td>Reworked prerequisites to match tabletop.</td></tr>
      <tr><td>EmpowerMetamagic
        </td><td>是
        </td><td>否
        </td><td>Allows sticky touch spells to be empowered.</td></tr>
      <tr><td>Endurance
        </td><td>是
        </td><td>true,
        </td><td>Endurance now grants +4 Athletics if you have 10 ranks in Athletics like similar feats.</td></tr>
      <tr><td>FencingGrace
        </td><td>是
        </td><td>否
        </td><td>Now only works on one handed weapons always.</td></tr>
      <tr><td>Lunge
        </td><td>是
        </td><td>否
        </td><td>Now is available as a feat.</td></tr>
      <tr><td>IndomitableMount
        </td><td>是
        </td><td>否
        </td><td>Now works correctly.</td></tr>
      <tr><td>MagicalTail
        </td><td>是
        </td><td>true,
        </td><td>Magical Tail gives Hideous Laughter at 2 and Heroism at 5 instead of sleep spells.</td></tr>
      <tr><td>MaximizeMetamagic
        </td><td>是
        </td><td>否
        </td><td>Allows sticky touch spells to be maximized.</td></tr>
      <tr><td>MountedCombat
        </td><td>是
        </td><td>否
        </td><td>Now works correctly.</td></tr>
      <tr><td>Outflank
        </td><td>是
        </td><td>否
        </td><td>No longer triggers on missed attacks.</td></tr>
      <tr><td>PersistantMetamagic
        </td><td>是
        </td><td>否
        </td><td>Allows any spell with a saving throw to be made persistent.</td></tr>
      <tr><td>SelectiveMetamagic
        </td><td>是
        </td><td>否
        </td><td>Retags selective spells to exclude non instantaneous spells.</td></tr>
      <tr><td>SelectivePrerequisites
        </td><td>是
        </td><td>否
        </td><td>Now requires 10 ranks of knowledge arcana.</td></tr>
      <tr><td>ShatterDefenses
        </td><td>是
        </td><td>否
        </td><td>Now requires you to hit a shaken target once before they become flat footed.</td></tr>
      <tr><td>SiezeTheMoment
        </td><td>是
        </td><td>否
        </td><td>No longer triggers on missed attacks.</td></tr>
      <tr><td>SlashingGrace
        </td><td>是
        </td><td>否
        </td><td>Now only works on one handed weapons always.</td></tr>
      <tr><td>SpellSpecialization
        </td><td>是
        </td><td>否
        </td><td>Enables spell specialization selection on all classes.</td></tr>
      <tr><td>SpiritedCharge
        </td><td>是
        </td><td>否
        </td><td>Bonus damage no longer can crit.</td></tr>
      <tr><td>VitalStrike
        </td><td>是
        </td><td>否
        </td><td>Bonus damage no longer can crit.</td></tr>
      <tr><td>WeaponFinesse
        </td><td>是
        </td><td>否
        </td><td>No longer treats any weapon with Fencing/Slashing grace into a finesse weapon.</td></tr>
  <tr><td rowspan="8">神话能力<br>MythicAbilities</td>
      <td>AscendantElement
        </td><td>是
        </td><td>否
        </td><td>Actually ignores immunities again.</td></tr>
      <tr><td>BloodlineAscendance
        </td><td>是
        </td><td>否
        </td><td>All bloodline should now qualify including mutated ones.</td></tr>
      <tr><td>CloseToTheAbyss
        </td><td>是
        </td><td>否
        </td><td>Fixes the magic gore's damage multiplier to be 1.5 instead of 0.5</td></tr>
      <tr><td>EnduringSpells
        </td><td>是
        </td><td>否
        </td><td>Now works on equipment enhancing effects like crusader's edge.</td></tr>
      <tr><td>ExposeVulnerability
        </td><td>是
        </td><td>否
        </td><td>Now no longer critically hits and procs additional weapons effects.</td></tr>
      <tr><td>MythicCharge
        </td><td>是
        </td><td>否
        </td><td>Prevents Mythic charge from triggering multiple fake attacks and procing weapon effects more often than it should.</td></tr>
      <tr><td>SecondBloodline
        </td><td>是
        </td><td>否
        </td><td>All bloodlines now qualify for second bloodline including mutated ones.</td></tr>
      <tr><td>SecondBloodragerBloodline
        </td><td>是
        </td><td>否
        </td><td>Reformed fiend now qualifies.</td></tr>
  <tr><td rowspan="3">神话专长<br>MythicFeats</td>
      <td>ExpandedArsenal
        </td><td>是
        </td><td>否
        </td><td>No longer allows stacking multiple spell focuses, or school mastery on the same school to increase DC and CL, you can only benefit from spell focus and school mastery once.</td></tr>
      <tr><td>ExtraFeat
        </td><td>是
        </td><td>否
        </td><td>Can no longer be picked more than once.</td></tr>
      <tr><td>ExtraMythicAbility
        </td><td>是
        </td><td>否
        </td><td>Can no longer be picked more than once.</td></tr>
    <tr><td>BOSS和敌人修复<br>Bosses/Enemies</td>
        <tr><td>Deskari
          </td><td>是
          </td><td>否
          </td><td>Made more of the hidden features visible in the inspect UI to make his mechanics make more sense.  </td></tr>
        <tr><td>StauntonVane
          </td><td>是
          </td><td>否
          </td><td>Now has the correct fighter feats instead of random default feats.  </td></tr>
        <tr><td>Balors
          </td><td>是
          </td><td>否
          </td><td>Now Correctly have Vorpal weapons.  </td></tr>
  <tr><td>圣教军模式<br>Crusade</td>
    <td>Buildings - TrainingGrounds
          </td><td>是
          </td><td>否
          </td><td>Now grants the correct damage bonus.  </td></tr>
  <tr><td>物品<br>Items</td>
         <td>Armor - Haramaki
          </td><td>是
          </td><td>否
          </td><td>Haramaki are now counted as light armor properly.  </td></tr>
        <tr><td>Armor - SingingSteel
          </td><td>是
          </td><td>否
          </td><td>Singing Steel now works.  </td></tr>
        <tr><td>Equipment - AmuletOfQuickDraw
          </td><td>是
          </td><td>否
          </td><td>No longer creates a separate damage instance and works with critical hits.  </td></tr>
        <tr><td>Equipment - AspectOfTheAsp
          </td><td>是
          </td><td>否
          </td><td>Will now actually grant damage on ray spells.  </td></tr>
        <tr><td>Equipment - BaneOfSpirit
          </td><td>是
          </td><td>否
          </td><td>Now is a free action to use.  </td></tr>
        <tr><td>Equipment - FixScrollUMDDCs
          </td><td>是
          </td><td>否
          </td><td>Now properly uses 20 + Scroll CL instead of 20 + Scroll spell level.  </td></tr>
        <tr><td>Equipment - FlawlessBeltOfPhysicalPerfection8Availability
          </td><td> 否
          </td><td>否
          </td><td>Now is available as a DLC reward instead of a normal +6 belt.  </td></tr>
        <tr><td>Equipment - FlawlessBeltOfPhysicalPerfection8CritIncrease
          </td><td>是
          </td><td>否
          </td><td>Now increases critical threat range by 1 in all cases.  </td></tr>
        <tr><td>Equipment - HalfOfThePair
          </td><td>是
          </td><td>否
          </td><td>Will more accurately update the bonus with range.  </td></tr>
        <tr><td>Equipment - HolySymbolofIomedae
          </td><td>是
          </td><td>否
          </td><td>Will now stay on after saving/loading or changing areas.  </td></tr>
        <tr><td>Equipment - MagiciansRing
          </td><td>是
          </td><td>否
          </td><td>Now grants +2 DC instead of +1 DC.  </td></tr>
        <tr><td>Equipment - ManglingFrenzy
          </td><td>是
          </td><td>否
          </td><td>Now works with bloodrage.  </td></tr>
        <tr><td>Equipment - MetamagicRods
          </td><td>是
          </td><td>否
          </td><td>Now default to off.  </td></tr>
        <tr><td>Equipment - StormlordsResolve
          </td><td>是
          </td><td>否
          </td><td>Can now be deactivated immediately instead of taking 1 turn to turn off.  </td></tr>
        <tr><td>Weapons - BladeOfTheMerciful
          </td><td>是
          </td><td>否
          </td><td>Prevents from triggering multiple fake attacks and procing weapon effects more often than it should.  </td></tr>
        <tr><td>Weapons - EnergyBurst
          </td><td>是
          </td><td>否
          </td><td>Fixes the critical multiplier calculation of energy burst (like flaming burst) effects to get the correct value.  </td></tr>
        <tr><td>Weapons - Finnean
          </td><td>是
          </td><td>否
          </td><td>Prevents from triggering multiple fake attacks and procing weapon effects more often than it should.  </td></tr>
        <tr><td>Weapons - HonorableJudgement
          </td><td>是
          </td><td>否
          </td><td>Prevents from triggering multiple fake attacks and procing weapon effects more often than it should.  </td></tr>
        <tr><td>Weapons - MusicOfDeath
          </td><td>是
          </td><td>否
          </td><td>Now correctly deals bonus damage against flat footed.  </td></tr>
        <tr><td>Weapons - Radiance
          </td><td>是
          </td><td>否
          </td><td>Now grants spell resistance correctly instead of spell penetration.  </td></tr>
        <tr><td>Weapons - SoundOfTheVoid
          </td><td>是
          </td><td>否
          </td><td>Now properly strips spell resistance.  </td></tr>
        <tr><td>Weapons - TerrifyingTremble
          </td><td>是
          </td><td>否
          </td><td>Implements the missing on kill effect. Whenever the wielder of this weapon lands a killing blow, he deals sonic damage equal to his ranks in the Athletics skill to all enemies within 10 feet. Successful Reflex save (DC 30) halves the damage.  </td></tr>
        <tr><td>Weapons - ThunderingBurst
          </td><td>是
          </td><td>否
          </td><td>Fixes thundering burst to deal D10s like the description says instead of D8s.  </td></tr>
        <tr><td>Weapons - Vorpal
          </td><td>是
          </td><td>否
          </td><td>Vorpal now works correctly.  </td></tr>
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
> *中文：* **自带中文（本处提供修复，但是依然存在小问题）**<br>
> *安装方式：* UMM<br>
> *修改内容：* 神话能力、神话专长，道途等<br>
> *新增内容：* 神话道途能力<br>
+ **TTT**的扩展附件，主要集中在**神话道途**的修改
+ 对神话能力、神话专长、道途均有修改，也导致很多人不习惯
> 比较重点（坑爹）的修改：<br>
> **充裕施法**数量减半<br>
> **高等持久法术**现在只能对持续10分钟以上法术生效，再也没法轮级常驻了<br>
+ 其他还包括对神话偷袭的修改（从多1骰变为骰子放大1级）。对御衡、灵使、巫妖、诡计均有修改，尤其是诡计几乎大变样
> **目前发现问题：灵使惊世神力改为了其他加值，但是文本描述依然是士气加值**

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
> *修改内容：* 修复少量物品<br>
> *新增内容：* 物品、法术等<br>
+ 主要是增加物品
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
> *中文：* **自带中文（缺少最新更新，此处提供补充）**<br>
> *安装方式：* **非UMM**<br>
> *修改内容：* 物品、变体和机制（AC）<br>
> *新增内容：* 大量变体，职业、信仰、领域、专长<br>
+ 大型MOD，增加很多新内容
+ Homebrew Archetypes分为三个部分：
  + 本体：核心内容
  + AC：修改部分物品和机制，**队友入队等级变为1**
  + ACTestingGrounds：将部分队友变为原创职业、规则书职业或变体，未汉化 
 <table>
 <tr><th colspan="2">新增内容列表<br>详细介绍可以参阅汉化发布贴或游戏内说明</th></tr> 
   <tr><td rowspan="2">职业</td>
       <td>Investigator 调查员及变体：Jinyiwei 锦衣卫、Questioner 发问者、Empiricist 演绎家</td></tr>
  <tr><td>NPC职业：5个NPC用职业，基本白板</td></tr>
  <tr><td rowspan="26">变体</td>
         <td>Blood Arcanist 奥能师 - 血奥师</td></tr>
  <tr><td>School Savant 奥能师 - 学派家</td></tr>
  <tr><td>Hateful Rager 野蛮人 - 恨意狂暴者</td></tr>
  <tr><td>Arcane Duelist 吟游诗人 - 奥术决斗者</td></tr>
  <tr><td>Dervish of Dawn 吟游诗人 - 晨花狂舞者</td></tr>
  <tr><td>Stonesinger 吟游诗人 - 石之歌者</td></tr>
  <tr><td>Untouchable Rager 血怒者 - 抗咒狂怒者</td></tr>
  <tr><td>Bloody-Knuckled Rowdy 血怒者 - 血暴铁拳</td></tr>
  <tr><td>Green Knight 骑将 - 苍翠骑士</td></tr>
  <tr><td>Evangelist 牧师 - 宣教士</td></tr>
  <tr><td>Undead Lord 牧师 - 尸骸领主</td></tr>
  <tr><td>Elder Mythos Cultist 牧师 - 旧神密教徒</td></tr>
  <tr><td>Halcyon Druid 德鲁伊 - 宁静德鲁伊</td></tr>
  <tr><td>Viking 战士 - 维京人</td></tr>
  <tr><td>Hellcat 武僧 - 地狱猫</td></tr>
  <tr><td>Monk of the Mantis 武僧 - 螳螂僧</td></tr>
  <tr><td>Oathbound - Oath of Vengeance 圣骑士 - 复仇誓约圣武士</td></tr>
  <tr><td>Oathbound - Oath of the People's Council 圣骑士 - 人民民主誓约圣武士</td></tr>
  <tr><td>Wilderness Warden 圣骑士 - 荒野守望者</td></tr>
  <tr><td>Holy Guide 圣骑士 - 神圣向导</td></tr>
  <tr><td>Ancient Lorekeeper 先知 - 传古学者</td></tr>
  <tr><td>Wild Stalker 游侠 - 野性潜猎者</td></tr>
  <tr><td>Sword-Devil 游侠 - 剑魔</td></tr>
  <tr><td>Sacred Fist 战斗祭司 - 神拳使</td></tr>
  <tr><td>Undead Master 法师 - 死灵之主</td></tr>
  <tr><td>Scarred Witch Doctor 巫师 - 疤痕巫医</td></tr>
  <tr><td rowspan="2">进阶职业</td>
       <td>Razmiran Priest 拉兹密安牧师</td>
  <tr><td>Assassin 刺客</td></tr>
  <tr><td rowspan="10">专长</td>
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
  <tr><td>基础动作</td>
         <td>Aid Another 援助他人：消耗动作为盟友附加AB或者AC</td></tr>
  <tr><td>信仰</td>
         <td>克苏鲁系11个信仰</td></tr>
  <tr><td>领域</td>
         <td>Void 虚空领域：擅长旅行移动和召唤</td></tr>
  <tr><td rowspan="5">神话能力</td>
       <td>Poison Vulnerability 透体之毒：解除敌人毒免</td>
  <tr><td>Sustained Vulnerability 毒入骨髓：延长透体之毒有效期</td></tr>
  <tr><td><b>AC专属</b> - Abundant Casting(Homebrew) <b>连锁施法：一定次数唤回任意法术**</b></td></tr>
  <tr><td><b>AC专属</b> - Empowered Bombs 增强炸弹：提高炼金炸弹伤害</td></tr>
  <tr><td><b>AC专属</b> - Maximized Bombs 终极炸弹：炼金炸弹总是造成最大伤害</td></tr>
  <tr><td rowspan="2">神话专长</td>
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
 <tr><th colspan="2">新增内容列表<br>详细介绍可以参阅汉化发布贴或游戏内说明</th></tr> 
   <tr><td rowspan="2">职业</td>
       <td>Oathbreaker 复仇暴徒及变体：Castigator 惩戒者</td></tr> 
   <tr><td>DreadKnight 恐惧骑士及变体：Conqueror 征服者、Claw of the False Wyrm 虚龙之爪</td></tr> 
   <tr><td rowspan="14">变体</td>
       <td>Living Scripture 审判官 - 活圣经</td></tr> 
   <tr><td>Mantis Zealot 战斗祭司 - 螳螂狂徒</td></tr> 
   <tr><td>Mooncaller 德鲁伊 - 唤月者</td></tr> 
   <tr><td>Draconic Druid 德鲁伊 - 龙之德鲁伊</td></tr> 
   <tr><td>Storm Druid 德鲁伊 - 风暴德鲁伊</td></tr> 
   <tr><td>Urban Druid 德鲁伊 - 文明德鲁伊</td></tr> 
   <tr><td><s>Bear Shaman</s></td></tr> 
   <tr><td>Temple Champion 圣骑士 - 圣殿冠军</td></tr> 
   <tr><td>Silver Champion 圣骑士 - 银冠勇士</td></tr> 
   <tr><td>Drake Warden 游侠 - 龙兽守望者</td></tr> 
   <tr><td>Clutch Thief 游荡者 - 龙蛋小偷</td></tr> 
   <tr><td>Ocean's Echo 先知 - 海洋回声</td></tr> 
   <tr><td>Draconic Shaman 萨满 - 龙族萨满</td></tr> 
   <tr><td>Draconic Scholar 奥能师 - 龙之学者</td></tr> 
   <tr><td rowspan="2">职业特性</td>
       <td>先知秘示域：Dragon 龙、Heavens 天堂、Succor 救助</td></tr>
   <tr><td>先知诅咒：Vampirism 吸血鬼</td></tr>
   <tr><td>基础动作</td>
       <td>Aid Another 援助他人</td></tr>
   <tr><td>专长</td>
       <td>Swift Aid 迅速援助</td></tr>
   <tr><td rowspan="2">神话能力</td>
       <td>Mythic Drake 神话龙兽</td>
   <tr><td>Impossible Subdomain 无限子域可能</td></tr>
   <tr><td>信仰</td>
       <td><b>海量新信仰</b></td></tr>
   <tr><td>领域</td>
       <td>Scalykind 鳞状</td></tr>
   <tr><td>子领域</td>
       <td>Agathion 阿加西翁、 Archon 亚空, Blood 血液、Caves 洞穴、Curse 诅咒、 Demon, Dragon 龙、Ferocity 凶猛、Ice 冰、Lust 欲望、Psychopomp 招魂、Rage 狂暴、 Resolve 决心、Restoration 恢复、Revelation 启示、Revolution 革命、Rivers 河流、Stars 星空、Storm 风暴、Thievery 盗窃、Undead 不死、Whimsy 滑稽、Wind 风</td></tr>
   <tr><td rowspan="25">法术<br><i>参阅PF文档</i></td>
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
> *中文：* **无**<br>
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
> *前置：* 无<br>
> *中文：* **无**<br>
> *安装方式：* **UMM**<br>
> *修改内容：* 戏法强化<br>
+ 小型MOD，强化戏法，使其拥有更高成长性
  
------------------------------------------- 
### [MoreCantrips](https://github.com/pheonix99/MoreCantrips)
> *前置：* 无<br>
> *中文：* **无**<br>
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
> *中文：* **无**<br>
> *安装方式：* **UMM**<br>
> *新增内容：* 大量，法术专长为主<br>
+ 大型MOD，增加很多新内容
<table>  
 <tr><th colspan="2">新增内容列表<br></th></tr> 
  <tr><td rowspan="2">变体<br><i>参阅PF文档</i></td>
       <td>Arrowsong Minstrel 吟游诗人 - 箭歌咏者</td></tr> 
   <tr><td>Winter Witch 巫师 - 冬巫 <b>基础职业巫师变体，和进阶职业不同</b></td></tr> 
   <tr><td rowspan="4">职业特性</td>
       <td>原力：<br>Shimmering Mirage 微光幻影，获得隐蔽<br>Suffocate 窒息，窒息目标可导致昏迷</td></tr>
   <tr><td>游荡者天赋：Shadow Duplicate 影分身，被击中时可释放类似镜影</td></tr>
   <tr><td>杀手绝技：<br>Armored Marauder 装甲强袭，擅长重甲并减少惩罚<br>Armored Swiftness 迅捷甲士，重甲不影响速度并提高最大敏捷加值<br>Slowing Strike 延缓打击，偷袭造成减速</td></tr>
   <tr><td>巫术：Ice Tomb 冰冢，寒冷并麻痹</td></tr>
   <tr><td rowspan="11">专长<br><i>参阅PF文档</i></td>
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
   <tr><td rowspan="39">法术<br><i>参阅PF文档</i></td>
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
> *前置：* TabletopTweaks-Core,<br>
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
 <tr><th colspan="2">新增内容列表<br></th></tr> 
  <tr><td rowspan="1">变体<br><i>参阅PF文档</i></td>
       <td>Elemental Scion 操念使 - 元素后继者</td></tr> 
  <tr><td rowspan="3">职业特性</i></td>
       <td>操念使内容<br><b>DarkCodex对操念使进行了大量扩充，包括允许自动使用过载来强化念袭、相应专长、专用背景、新的原力和注能、BUG修复等等</b><br>原力：Hurricane Queen、Mind Shield<br>注能：Blade Rush、Chain Infusion、Impale Infusion、Energize Weapon、Kinetic Fist、Venom Infusion、Kinetic Whip</td></tr> 

