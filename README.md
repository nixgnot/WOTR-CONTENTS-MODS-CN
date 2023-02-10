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
  - [TabletopTweaks-Base](#TabletopTweaks-Base)
  - [TabletopTweaks-Reworks](#TabletopTweaks-Reworks)
  - [MicroscopicContentExpansion](#MicroscopicContentExpansion)
  - [SparsSorcerousSundries](#SparsSorcerousSundries)
  - [TomeOfTheFirebird](#TomeOfTheFirebird)
  - [HomebrewArchetypes](#HomebrewArchetypes)
  - [ExpandedContent2022](#ExpandedContent2022)
   
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
> 典型的包括<br>
> **甄选法术不能再对持续性AOE法术生效**<br>
> **扩充战法不能再由多系专攻获得大量DC**<br>
> **游荡者天赋中额外战斗专长只能选一次**<br>
> **AOE法术不会在释放时额外触发一次**<br>
> **坐骑移动后主人无法整轮攻击**<br>
> 等等<br>
+ 如果你习惯了原版体系和构建，可能用了TTT会有极大怨言。好在这些修复都是可以关闭的<br>
+ （友情提示，但是由于新增了大量内容，关闭这些修复很容易导致过于滥强）<br>
+ TTT的更新过于庞杂海量，建议有一定英文基础和游戏基础再玩（虽然内容已经汉化但是选项菜单无法汉化）

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
  <tr><td>Divine Commander 战争祭祀 - 圣战指挥官</td></tr>
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
  <tr><td rowspan="6">职业特性</td>
      <td>血承：Aberrant 异怪血承、Destined 命运血承</td></tr>
  <tr><td>奥能技艺：Familiar 魔宠、Item Crafting 造物精通、Metamagic Knowledge 超魔学识、Quick Study 快速研读 </td></tr>
  <tr><td>战士进阶防具训练：Armored Confidence 自信着甲、Armored Juggernaut 盔甲主宰、Armor Specialization 重甲掌握、Critical Deflection 重击偏转、Steel Headbutt 钢铁头槌</td></tr>
  <tr><td>战士进阶武器训练：Defensive Weapon Training 防御式武器训练、 Focused Weapon 专注武器、Trained Grace 庖丁解牛、Trained Throw 精通投掷、Warrior Spirit 勇士之魂"</td></tr>
  <tr><td>魔战士奥秘：Broad Study 奥术扩展、Spell Blending 混合奥法 </td></tr>
  <tr><td>游荡者天赋： Graceful Athlete 灵巧运动、Bleeding Attack 流血攻击、Emboldening Strike 鼓舞攻击</td></tr>    
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
       <td>Deadly Juggernaut 死亡化身（牧师3，审判官3，圣武士3，反圣武士3，战争祭祀3）：<i>参阅PF文档</i>，击杀对手获得奖励</td></tr>
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
+ 重要改动：驱散魔法类现在成为了”安全法术“，只会驱散敌人身上的BUFF和我方身上的DEBUFF
<table>
<tr><th colspan="2">新增内容列表</th></tr> 
  <tr><td>变体</td>
      <td>Eldritch Scion (Sage) 魔战士 - 奥法后继者（贤者）<br><b>注意不要和术士兼职</b></td></tr>      
   <tr><td rowspan="12">法术<br><i>参阅PF文档</i></td>
       <td>Bone Fists 骸骨之拳：增加天生防御和天生武器伤害</td></tr>
   <tr><td>Chains Of Fire 火焰链：闪电链火焰版本</td></tr>
   <tr><td>Fire Shield 火焰护盾：攻击者受到火焰伤害并减免寒冷伤害，也有完全相反的寒冷版本</td></tr>
   <tr><td>Vitrolic Mist 硫酸雾甲：火焰护盾酸蚀版</td></tr>
   <tr><td>Entropic Shield 熵光护盾：偏转远程攻击</td></tr>
   <tr><td>Freezing Sphere 冰封法球：寒冷伤害</td></tr>
   <tr><td>Gloomblind bolts 黑盲矢：多发负能量飞弹，附带目盲</td></tr>
   <tr><td>Heal Mount 医疗坐骑：效果如名字</td></tr>
   <tr><td>Keen Edge 锋锐术：效果如名字</td></tr>
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
   <tr><td rowspan="5">职业特性</td>
       <td>血怒血承：Phoenix  凤凰血承，需要TabletopTweaks-Base</td></tr>
   <tr><td>原力：Clockwork Heart 械动之心</td></tr>
   <tr><td>庇护主：Light 光耀、Animal 动物、 Protection 保护、Plague 疫病</td></tr>
   <tr><td>狂暴之力：Rage Stance Mastery 狂暴姿态大师：同时使用两种野蛮人姿态</td></tr>
   <tr><td>圣疗救赎：Injured 救赎创伤（给予快速治疗）、Ensorcelled 救赎蛊惑（驱散，可对敌）</td></tr>
 </table> 

-------------------------------------------
### [HomebrewArchetypes](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/279)
+ [贴吧汉化帖](https://tieba.baidu.com/p/7977216047?pn=1)
+ **注意！Homebrew Archetypes不能使用UMM安装，可以使用ModFinder安装或者参考汉化帖手动安装**
> *前置：* 无<br>
> *中文：* **自带中文（缺少最新更新，此处提供补充）**<br>
> *安装方式：* **非UMM**<br>
> *修改内容：* 物品、变体和机制（AC）<br>
> *新增内容：*大量变体，信仰、领域、专长<br>
+ Homebrew Archetypes分为三个部分：
  + 本体：核心内容
  + AC：修改部分物品和机制，**队友入队等级变为1**
  + ACTestingGrounds：将部分队友变为桌面版规则原职业或变体，未汉化 
 <table>
 <tr><th colspan="2">新增内容列表<br>详细介绍可以参阅汉化发布贴或游戏内说明</th></tr> 
 
  <tr><td rowspan="2">职业</td>
       <td>Investigator 调查员及变体：Jinyiwei 锦衣卫、Questioner 发问者、Empiricist 演绎家</td>
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
  <tr><td>Sacred Fist 战争祭祀 - 神拳使</td></tr>
  <tr><td>Undead Master 法师 - 死灵之主</td></tr>
  <tr><td>Scarred Witch Doctor 巫师 - 疤痕巫医</td></tr>
  <tr><td rowspan="2">进阶职业</td>
       <td>Razmiran Priest 拉兹密安牧师</td>
  <tr><td>Assassin 刺客</td></tr>
  <tr><td rowspan="10">专长</td>
       <td>Adept Channel 导师导能</td>
  <tr><td>Strike True 克敌机先</td></tr>
  <tr><td>Channel Smite 导能打击</td></tr>
  <tr><td>Greater Channel Smite 高等导能打击.</td></tr>
  <tr><td>Guided Hand 引导之手</td></tr>
  <tr><td>Hex Strike 巫术打击</td></tr>
  <tr><td>Monastic Legacy 修道传承</td></tr>
  <tr><td>Blooded Arcane Strike 血术之击</td></tr>
  <tr><td>Fire Music 燃火之乐</td></tr>
  <tr><td>Discordant Voice 不谐之音</td></tr>
  <tr><td>基础动作</td>
         <td>Aid Another 援助他人</td></tr>
  <tr><td>信仰</td>
         <td>克苏鲁系11个信仰</td></tr>
  <tr><td>领域</td>
         <td>Void 虚空领域</td></tr>
  <tr><td rowspan="5">神话能力</td>
       <td>Poison Vulnerability 透体之毒</td>
  <tr><td>Sustained Vulnerability 毒入骨髓</td></tr>
  <tr><td><b>AC专属</b> - Abundant Casting(Homebrew) <b>连锁施法：一定次数唤回任意法术**</b></td></tr>
  <tr><td><b>AC专属</b> - Empowered Bombs 增强炸弹：提高炼金炸弹伤害</td></tr>
  <tr><td><b>AC专属</b> - Maximized Bombs 终极炸弹：炼金炸弹总是造成最大伤害</td></tr>
  <tr><td rowspan="2">神话专长</td>
       <td>Mythic Guided Hand 引导之手（神话）</td>
  <tr><td>Mythic Crossbow Training 神话弩箭训练</td></tr>
</table>

-------------------------------------------
### [ExpandedContent2022](https://www.nexusmods.com/pathfinderwrathoftherighteous/mods/377)
+ [贴吧汉化帖](https://tieba.baidu.com/p/7977216047?pn=1)
> *前置：* 无<br>
> *中文：* **贴吧汉化**<br>
> *安装方式：* **UMM**<br>
> *新增内容：*大量变体，信仰、领域、专长、职业特性<br>
